

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
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9985742019401141d,right: 0.7749919062387798d,bottom: 0.598742880688873d,left: 0.690227888203009d),
new NpgsqlTypes.NpgsqlBox(top: 0.8846091080698552d,right: 0.3727585933937868d,bottom: 0.7454775202175181d,left: 0.19206470585580981d),
new NpgsqlTypes.NpgsqlBox(top: 0.454945017398945d,right: 0.9682181169461882d,bottom: 0.29301153402838553d,left: 0.5933875101162496d),
new NpgsqlTypes.NpgsqlBox(top: 0.5139141185576631d,right: 0.5501538375815046d,bottom: 0.41386344310337964d,left: 0.5267276716563773d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41924584551670885d,right: 0.8878485198042135d,bottom: 0.14857853525127906d,left: 0.16112119787143409d),
new NpgsqlTypes.NpgsqlBox(top: 0.898701947304377d,right: 0.8880020826131632d,bottom: 0.007790148621851789d,left: 0.24069666521014088d),
new NpgsqlTypes.NpgsqlBox(top: 0.22634582475029486d,right: 0.9686240936801688d,bottom: 0.022319756612860453d,left: 0.639295585092413d),
new NpgsqlTypes.NpgsqlBox(top: 0.34317880002659806d,right: 0.3824459622827543d,bottom: 0.10496480225571136d,left: 0.20736506476532213d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9715813781372673d,right: 0.16614149488351604d,bottom: 0.41732361777706006d,left: 0.024470624377224914d),
new NpgsqlTypes.NpgsqlBox(top: 0.8073749754225573d,right: 0.7799426847555535d,bottom: 0.27463476950349874d,left: 0.6665760204514564d),
new NpgsqlTypes.NpgsqlBox(top: 0.9979968726728188d,right: 0.40565987935175196d,bottom: 0.7429486455648731d,left: 0.336133166083167d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5179425245667705d,right: 0.3443326424427655d,bottom: 0.0900273400238063d,left: 0.26057468875760725d),
new NpgsqlTypes.NpgsqlBox(top: 0.7983375562968522d,right: 0.7986119776460935d,bottom: 0.33307301454420735d,left: 0.7438500056793976d),
new NpgsqlTypes.NpgsqlBox(top: 0.7842683158488417d,right: 0.9383510635158776d,bottom: 0.34386186507262206d,left: 0.9232005443940623d),
new NpgsqlTypes.NpgsqlBox(top: 0.7245513428181327d,right: 0.44273404604373034d,bottom: 0.1508761938257408d,left: 0.18578045689591438d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6418740277526913d,right: 0.9896370456544634d,bottom: 0.2039541239117736d,left: 0.1627105142000258d),
new NpgsqlTypes.NpgsqlBox(top: 0.8002520553043946d,right: 0.986512350245106d,bottom: 0.11716427201844815d,left: 0.28632508411988533d),
new NpgsqlTypes.NpgsqlBox(top: 0.9542362436870888d,right: 0.9671303060942162d,bottom: 0.7523906426745742d,left: 0.8582416691307674d),
new NpgsqlTypes.NpgsqlBox(top: 0.9613283597418215d,right: 0.9807496033932178d,bottom: 0.5104879895877662d,left: 0.6379016717884242d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.605398237982906d,right: 0.5894391750349657d,bottom: 0.4009683687655313d,left: 0.5504236755400498d),
new NpgsqlTypes.NpgsqlBox(top: 0.8993703296713838d,right: 0.6321464310495797d,bottom: 0.3145432361909323d,left: 0.6028375776145662d),
new NpgsqlTypes.NpgsqlBox(top: 0.49990363337083843d,right: 0.7394167452834277d,bottom: 0.13315017210348135d,left: 0.5717717205200431d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5496949274450837d,right: 0.5198969472584176d,bottom: 0.4495873697017473d,left: 0.0691104393465537d),
new NpgsqlTypes.NpgsqlBox(top: 0.8100385231920837d,right: 0.4254700947008798d,bottom: 0.6964834735163943d,left: 0.11293826740083002d),
new NpgsqlTypes.NpgsqlBox(top: 0.5631893575111033d,right: 0.13822477684834478d,bottom: 0.2743822843383946d,left: 0.07883163690763562d),
new NpgsqlTypes.NpgsqlBox(top: 0.4060391033456866d,right: 0.6701478505569582d,bottom: 0.36197451346714504d,left: 0.19812148764367998d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9420404609629804d,right: 0.9189928858768555d,bottom: 0.1706393578839076d,left: 0.15938290671386468d),
new NpgsqlTypes.NpgsqlBox(top: 0.3817286519143186d,right: 0.3000656780783334d,bottom: 0.05541257006236078d,left: 0.23517387051032135d),
new NpgsqlTypes.NpgsqlBox(top: 0.58755240969531d,right: 0.3854522252033744d,bottom: 0.2694584809353544d,left: 0.21388441015585669d),
new NpgsqlTypes.NpgsqlBox(top: 0.9993469242631022d,right: 0.4720037027051144d,bottom: 0.2955907239690385d,left: 0.0005341686709879889d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40292333182486306d,right: 0.5542880154296566d,bottom: 0.20139533743232008d,left: 0.4050949422554746d),
new NpgsqlTypes.NpgsqlBox(top: 0.9801773511744882d,right: 0.9085196540890651d,bottom: 0.6537203278201618d,left: 0.43405945170291915d),
new NpgsqlTypes.NpgsqlBox(top: 0.9128751908266922d,right: 0.38361301616923804d,bottom: 0.2735822945180255d,left: 0.1380141968021189d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.13419846858730788d,right: 0.8403710025707637d,bottom: 0.10040019078761853d,left: 0.15322189264767228d),
new NpgsqlTypes.NpgsqlBox(top: 0.4710529233364147d,right: 0.7997214071868387d,bottom: 0.07699886963827152d,left: 0.1765010778940198d),
new NpgsqlTypes.NpgsqlBox(top: 0.9383107073455031d,right: 0.9288865329549568d,bottom: 0.3971594996951445d,left: 0.19942068436954496d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3045219448692449d,right: 0.990390932335631d,bottom: 0.19129825580681448d,left: 0.7353587809212581d),
new NpgsqlTypes.NpgsqlBox(top: 0.6903988202691157d,right: 0.8556182657687907d,bottom: 0.6024958751825663d,left: 0.4803974625361884d),
new NpgsqlTypes.NpgsqlBox(top: 0.7188793572267745d,right: 0.5948711252938973d,bottom: 0.002575075130880844d,left: 0.15294421045880047d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25941965389777255d,right: 0.6049747731365992d,bottom: 0.055220029636986245d,left: 0.5840549121381354d),
new NpgsqlTypes.NpgsqlBox(top: 0.6501872078395179d,right: 0.6313407635905949d,bottom: 0.23704190207734765d,left: 0.34355203719416194d),
new NpgsqlTypes.NpgsqlBox(top: 0.932467646328625d,right: 0.6583284533227008d,bottom: 0.7410012461862281d,left: 0.025733226656675212d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7134243834539667d,right: 0.9576847655693146d,bottom: 0.1382817320236387d,left: 0.22992207768920592d),
new NpgsqlTypes.NpgsqlBox(top: 0.9456431080350807d,right: 0.618300923737369d,bottom: 0.7020905700549682d,left: 0.22041725411601687d),
new NpgsqlTypes.NpgsqlBox(top: 0.8280700747712646d,right: 0.7842964245946303d,bottom: 0.6553667017081065d,left: 0.2833654762278961d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6286226784522464d,right: 0.9419077453612243d,bottom: 0.4960499927697758d,left: 0.7629959503643241d),
new NpgsqlTypes.NpgsqlBox(top: 0.35019845823201823d,right: 0.9733555678754897d,bottom: 0.013715556966513387d,left: 0.6488967094235626d),
new NpgsqlTypes.NpgsqlBox(top: 0.9642725511885423d,right: 0.6387592779603852d,bottom: 0.6460463792451788d,left: 0.5305660779987146d),
new NpgsqlTypes.NpgsqlBox(top: 0.6495437362342111d,right: 0.6667071278451971d,bottom: 0.2600904389346034d,left: 0.05262975009457793d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17635883057599944d,right: 0.2548542806195472d,bottom: 0.06902316153607946d,left: 0.09330108872648935d),
new NpgsqlTypes.NpgsqlBox(top: 0.8964808791740627d,right: 0.6187399450504047d,bottom: 0.44382178350834844d,left: 0.4772804859135955d),
new NpgsqlTypes.NpgsqlBox(top: 0.965464903228649d,right: 0.7336488619196012d,bottom: 0.9273439493088396d,left: 0.6129525434793138d),
new NpgsqlTypes.NpgsqlBox(top: 0.6596001311027353d,right: 0.4273415350358739d,bottom: 0.4646060721649301d,left: 0.4119322962913864d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8774120652518357d,right: 0.47724335581765387d,bottom: 0.3460308496398351d,left: 0.42835693694173993d),
new NpgsqlTypes.NpgsqlBox(top: 0.47641297390167126d,right: 0.2663610031652348d,bottom: 0.10107850246107297d,left: 0.22620728543675483d),
new NpgsqlTypes.NpgsqlBox(top: 0.7038905231198378d,right: 0.4834688890327784d,bottom: 0.06128571039560049d,left: 0.11459573894028219d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3822413539349969d,right: 0.2910394460868829d,bottom: 0.12785209085881444d,left: 0.005577735989548582d),
new NpgsqlTypes.NpgsqlBox(top: 0.6353332124011289d,right: 0.690433666554901d,bottom: 0.11371728230557843d,left: 0.11512483272263008d),
new NpgsqlTypes.NpgsqlBox(top: 0.9657099929560347d,right: 0.243550722814599d,bottom: 0.46204861672958075d,left: 0.2031439334285553d),
new NpgsqlTypes.NpgsqlBox(top: 0.9150291136764772d,right: 0.5803728100936228d,bottom: 0.4506932617186291d,left: 0.5405231242820276d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9048102804015077d,right: 0.8864444700463775d,bottom: 0.4561738490469406d,left: 0.8097705699254519d),
new NpgsqlTypes.NpgsqlBox(top: 0.6708611560276244d,right: 0.4341410422534715d,bottom: 0.00495514205777936d,left: 0.27209232128790395d),
new NpgsqlTypes.NpgsqlBox(top: 0.5587746059716457d,right: 0.9665019536593118d,bottom: 0.08986181064057752d,left: 0.471531064130694d),
new NpgsqlTypes.NpgsqlBox(top: 0.46116672985032736d,right: 0.497728590892241d,bottom: 0.27970635518341214d,left: 0.22838843061988012d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4158962341638448d,right: 0.33147497085668975d,bottom: 0.09322921544658114d,left: 0.2720734977308047d),
new NpgsqlTypes.NpgsqlBox(top: 0.9565122223388187d,right: 0.824601128369891d,bottom: 0.7135403801844219d,left: 0.8133220937831358d),
new NpgsqlTypes.NpgsqlBox(top: 0.8470044207973296d,right: 0.6545057380020275d,bottom: 0.3345603789749998d,left: 0.31707316501512617d),
new NpgsqlTypes.NpgsqlBox(top: 0.4577174281983001d,right: 0.619906386439493d,bottom: 0.0021721889916205273d,left: 0.19902460943886802d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6912361410207352d,right: 0.8636405055774966d,bottom: 0.003572790790156599d,left: 0.13284937564368293d),
new NpgsqlTypes.NpgsqlBox(top: 0.8238119110163762d,right: 0.6305610106555704d,bottom: 0.5906589561545904d,left: 0.042285413176134434d),
new NpgsqlTypes.NpgsqlBox(top: 0.3191509808776355d,right: 0.9361487635806118d,bottom: 0.1353652257385458d,left: 0.6458243639652999d),
new NpgsqlTypes.NpgsqlBox(top: 0.7619890972399327d,right: 0.6231678455497301d,bottom: 0.652092478569793d,left: 0.10678843513064229d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44505944377163953d,right: 0.17156821247335952d,bottom: 0.046254796074641336d,left: 0.11497369342463926d),
new NpgsqlTypes.NpgsqlBox(top: 0.8244686552524487d,right: 0.798666745219154d,bottom: 0.5734691880499975d,left: 0.6863777381021554d),
new NpgsqlTypes.NpgsqlBox(top: 0.8797936586768584d,right: 0.7311403869209473d,bottom: 0.7222092356849672d,left: 0.6841720451460815d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7368840855799828d,right: 0.5750303158239258d,bottom: 0.47248358009530633d,left: 0.42862546206669316d),
new NpgsqlTypes.NpgsqlBox(top: 0.7728816223996099d,right: 0.7945651761270304d,bottom: 0.710610285913386d,left: 0.2663235203243539d),
new NpgsqlTypes.NpgsqlBox(top: 0.7673147549931687d,right: 0.7422203947737315d,bottom: 0.1898968932209768d,left: 0.1238279591679462d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3388597931490116d,right: 0.7252330558824978d,bottom: 0.08528907216177961d,left: 0.6739624310758563d),
new NpgsqlTypes.NpgsqlBox(top: 0.9646915464523582d,right: 0.4385813134291111d,bottom: 0.4851605659322171d,left: 0.018842644882802184d),
new NpgsqlTypes.NpgsqlBox(top: 0.9275783928600579d,right: 0.753557345249373d,bottom: 0.17102288060219917d,left: 0.09404986990729347d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9335563966249418d,right: 0.1555859266518893d,bottom: 0.5273179489938814d,left: 0.09435630797097228d),
new NpgsqlTypes.NpgsqlBox(top: 0.8865018879326952d,right: 0.8487481309889022d,bottom: 0.5105803026560988d,left: 0.5916565586368319d),
new NpgsqlTypes.NpgsqlBox(top: 0.7066793225253427d,right: 0.7622034894141501d,bottom: 0.1469742890679855d,left: 0.44351957829714395d),
new NpgsqlTypes.NpgsqlBox(top: 0.954460764831929d,right: 0.9521423485194588d,bottom: 0.3133086926067584d,left: 0.3380455214556862d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.36860121008661284d,right: 0.6056983019380126d,bottom: 0.020102015014380914d,left: 0.24931806347187258d),
new NpgsqlTypes.NpgsqlBox(top: 0.6094438642463182d,right: 0.7556442843766055d,bottom: 0.5615251122814804d,left: 0.74641268805629d),
new NpgsqlTypes.NpgsqlBox(top: 0.7377578385023525d,right: 0.6191496548013017d,bottom: 0.12086037597283261d,left: 0.5385937354418392d),
new NpgsqlTypes.NpgsqlBox(top: 0.6173994636489938d,right: 0.9393840762495544d,bottom: 0.49999171048474345d,left: 0.03041570862512699d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7272844828063622d,right: 0.49344657602264985d,bottom: 0.22529373487452609d,left: 0.30168646246188424d),
new NpgsqlTypes.NpgsqlBox(top: 0.8611584819292184d,right: 0.1908319759475563d,bottom: 0.14199047128785947d,left: 0.03879914402321427d),
new NpgsqlTypes.NpgsqlBox(top: 0.7706871692822042d,right: 0.7390905773603265d,bottom: 0.24482608222684643d,left: 0.44465184723066853d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6876412291795865d,right: 0.4267479595761059d,bottom: 0.524190678956628d,left: 0.17437608699821494d),
new NpgsqlTypes.NpgsqlBox(top: 0.5079137539049128d,right: 0.4186172617375221d,bottom: 0.26979663410199406d,left: 0.05435110740899629d),
new NpgsqlTypes.NpgsqlBox(top: 0.8780232356819219d,right: 0.7898219933333066d,bottom: 0.29730076875904765d,left: 0.27182466226522306d),
new NpgsqlTypes.NpgsqlBox(top: 0.30231348251804147d,right: 0.9647862174306229d,bottom: 0.17235445977379416d,left: 0.14334565309950442d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6570059070917964d,right: 0.798528544190262d,bottom: 0.07793212600331234d,left: 0.15636662229321296d),
new NpgsqlTypes.NpgsqlBox(top: 0.6337086098743842d,right: 0.7272426434911992d,bottom: 0.2388995502826451d,left: 0.39973097180914297d),
new NpgsqlTypes.NpgsqlBox(top: 0.4058230362381158d,right: 0.8058982052329337d,bottom: 0.052681140672906746d,left: 0.3849034156421375d),
new NpgsqlTypes.NpgsqlBox(top: 0.9895294793488615d,right: 0.214623384542188d,bottom: 0.4221235351797952d,left: 0.1508761514341681d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8487907390094682d,right: 0.261320863400357d,bottom: 0.46861563587556243d,left: 0.07266207125134494d),
new NpgsqlTypes.NpgsqlBox(top: 0.7429588734873018d,right: 0.5009802753636348d,bottom: 0.17252096369741066d,left: 0.28559119740867667d),
new NpgsqlTypes.NpgsqlBox(top: 0.738389722017216d,right: 0.9599451486325357d,bottom: 0.22057119120438418d,left: 0.5265913079473213d),
new NpgsqlTypes.NpgsqlBox(top: 0.728143399939102d,right: 0.9348148220836322d,bottom: 0.5317607857517045d,left: 0.9210240585478006d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7844167060510032d,right: 0.7325897004874763d,bottom: 0.31522055032335994d,left: 0.15580899932216197d),
new NpgsqlTypes.NpgsqlBox(top: 0.8989006005135238d,right: 0.8162914824294769d,bottom: 0.7633134548454067d,left: 0.4388666169329519d),
new NpgsqlTypes.NpgsqlBox(top: 0.7358768677981108d,right: 0.5805046254162857d,bottom: 0.6707349109101066d,left: 0.2440882044350724d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.763532024696116d,right: 0.35895660760081893d,bottom: 0.521318758603656d,left: 0.06096003014240525d),
new NpgsqlTypes.NpgsqlBox(top: 0.7841610836885868d,right: 0.9160881115003092d,bottom: 0.05426549862222496d,left: 0.564273501257645d),
new NpgsqlTypes.NpgsqlBox(top: 0.6033457689489627d,right: 0.5205285386057581d,bottom: 0.03360511194206128d,left: 0.02597933231070071d),
new NpgsqlTypes.NpgsqlBox(top: 0.9589408784971294d,right: 0.9749989442520428d,bottom: 0.09772026747710028d,left: 0.38579200172391936d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.14601850859209764d,right: 0.7829004535247319d,bottom: 0.03267898650972478d,left: 0.7737237039715227d),
new NpgsqlTypes.NpgsqlBox(top: 0.6866193040255915d,right: 0.56531725211205d,bottom: 0.3313313954145015d,left: 0.3499131569522108d),
new NpgsqlTypes.NpgsqlBox(top: 0.2642308770730123d,right: 0.8641236731120339d,bottom: 0.11383476150887328d,left: 0.17499523182789212d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6376257645345287d,right: 0.573310188843757d,bottom: 0.34103506215286317d,left: 0.04757952092367124d),
new NpgsqlTypes.NpgsqlBox(top: 0.6025039764662455d,right: 0.8030845229007665d,bottom: 0.08715283512435701d,left: 0.17871193723106427d),
new NpgsqlTypes.NpgsqlBox(top: 0.3548742259714791d,right: 0.5036980561463389d,bottom: 0.07893600829174396d,left: 0.19271685869472388d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35544295405314186d,right: 0.9665398435133636d,bottom: 0.32692898795326797d,left: 0.4518467936961583d),
new NpgsqlTypes.NpgsqlBox(top: 0.2579836179631658d,right: 0.5399711538616216d,bottom: 0.10794042590874608d,left: 0.03806751359825766d),
new NpgsqlTypes.NpgsqlBox(top: 0.5081492315437658d,right: 0.42859188938642545d,bottom: 0.1477159816912258d,left: 0.0686580414844975d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8349754898652999d,right: 0.8441186625335279d,bottom: 0.8035726781922194d,left: 0.26315638525590135d),
new NpgsqlTypes.NpgsqlBox(top: 0.779850180261429d,right: 0.9142704238185451d,bottom: 0.09907109843943696d,left: 0.2606314730105356d),
new NpgsqlTypes.NpgsqlBox(top: 0.9819767790751247d,right: 0.689092247405032d,bottom: 0.5529803959641971d,left: 0.5032298924665402d),
new NpgsqlTypes.NpgsqlBox(top: 0.9727357682291462d,right: 0.5321324425415129d,bottom: 0.6451187494520567d,left: 0.2667062143221359d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5982733766063963d,right: 0.9365536452300474d,bottom: 0.4813318156948718d,left: 0.6351583362538386d),
new NpgsqlTypes.NpgsqlBox(top: 0.9382440493998337d,right: 0.7850578070292792d,bottom: 0.443723165619367d,left: 0.2194489840756466d),
new NpgsqlTypes.NpgsqlBox(top: 0.8836348795664885d,right: 0.7077193436159331d,bottom: 0.6658266545346263d,left: 0.09223587953864909d),
new NpgsqlTypes.NpgsqlBox(top: 0.3653569579975344d,right: 0.4375754022579339d,bottom: 0.19967427245529734d,left: 0.4374913775412643d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.547350021244966d,right: 0.6227073054381551d,bottom: 0.49845279354030614d,left: 0.3691948843828833d),
new NpgsqlTypes.NpgsqlBox(top: 0.295888404685805d,right: 0.9271453842422409d,bottom: 0.23526631173997525d,left: 0.8184685690678294d),
new NpgsqlTypes.NpgsqlBox(top: 0.8114941206307181d,right: 0.6792258088688448d,bottom: 0.6334094926130123d,left: 0.13529953019052599d),
new NpgsqlTypes.NpgsqlBox(top: 0.9464125752000435d,right: 0.25221790992661797d,bottom: 0.7275429815814994d,left: 0.011339808376944704d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8676168165677023d,right: 0.6607544770317466d,bottom: 0.0622381772271291d,left: 0.6307956536302867d),
new NpgsqlTypes.NpgsqlBox(top: 0.8157090235603789d,right: 0.8111483129927901d,bottom: 0.28845824074232496d,left: 0.06904038110968014d),
new NpgsqlTypes.NpgsqlBox(top: 0.3671624687434051d,right: 0.8492013496924191d,bottom: 0.20444351066805466d,left: 0.46939614814912667d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.941703418683677d,right: 0.6975174522116959d,bottom: 0.16083781826928245d,left: 0.22724993925824755d),
new NpgsqlTypes.NpgsqlBox(top: 0.7759007719633844d,right: 0.8020080779287095d,bottom: 0.06582065471975163d,left: 0.4959749390369086d),
new NpgsqlTypes.NpgsqlBox(top: 0.9528308048126448d,right: 0.5831879034092095d,bottom: 0.19391453655015878d,left: 0.3477292057478597d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8937183756069683d,right: 0.9158463973874879d,bottom: 0.8380595565616494d,left: 0.43348431236855756d),
new NpgsqlTypes.NpgsqlBox(top: 0.5824119234540803d,right: 0.7513579929486082d,bottom: 0.23050831785189208d,left: 0.45955740230473396d),
new NpgsqlTypes.NpgsqlBox(top: 0.1739783914602856d,right: 0.35362212697585393d,bottom: 0.1591150298560764d,left: 0.30556416659861707d),
new NpgsqlTypes.NpgsqlBox(top: 0.6213105052643857d,right: 0.39174891703476633d,bottom: 0.5489890781462625d,left: 0.3355888564117089d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8892240196191173d,right: 0.793396749099026d,bottom: 0.6853490112940512d,left: 0.3082803479590319d),
new NpgsqlTypes.NpgsqlBox(top: 0.1331395425613756d,right: 0.8396046460908202d,bottom: 0.12570747119198988d,left: 0.02555113085663452d),
new NpgsqlTypes.NpgsqlBox(top: 0.4752883602992124d,right: 0.9497824675825558d,bottom: 0.28064405639774936d,left: 0.047444787681165d),
new NpgsqlTypes.NpgsqlBox(top: 0.2997888539959972d,right: 0.8401311038832021d,bottom: 0.1853995679717826d,left: 0.33144759017564907d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1557965267848317d,right: 0.5429858482132551d,bottom: 0.12797876973322764d,left: 0.3363025848337148d),
new NpgsqlTypes.NpgsqlBox(top: 0.021554506701252363d,right: 0.24045106486144574d,bottom: 0.017253747301921307d,left: 0.06176740356457011d),
new NpgsqlTypes.NpgsqlBox(top: 0.32082423300856167d,right: 0.8507297483055629d,bottom: 0.09135697185846281d,left: 0.7255344133564469d),
new NpgsqlTypes.NpgsqlBox(top: 0.6947267189125959d,right: 0.26827851993154006d,bottom: 0.5258417371403526d,left: 0.17122603893876953d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9220504280233827d,right: 0.3755656843705214d,bottom: 0.1218054695127615d,left: 0.07512315249147838d),
new NpgsqlTypes.NpgsqlBox(top: 0.9877817390775362d,right: 0.9696145349093057d,bottom: 0.2309550685051205d,left: 0.22817411208278304d),
new NpgsqlTypes.NpgsqlBox(top: 0.6481410766348614d,right: 0.46135835158005567d,bottom: 0.5764170802135627d,left: 0.4505119821169754d),
new NpgsqlTypes.NpgsqlBox(top: 0.7138677830985569d,right: 0.6119067108154975d,bottom: 0.7054097312044588d,left: 0.14689336268020803d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9764830821051387d,right: 0.7952147837660927d,bottom: 0.5051415719647983d,left: 0.43724195753041284d),
new NpgsqlTypes.NpgsqlBox(top: 0.8652249266889834d,right: 0.49423477488107237d,bottom: 0.3112132966681571d,left: 0.11717577906491372d),
new NpgsqlTypes.NpgsqlBox(top: 0.9945829136891298d,right: 0.19538532534891784d,bottom: 0.8411759156080788d,left: 0.08134741143938296d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4489679884962927d,right: 0.26949690835317164d,bottom: 0.01198654870431326d,left: 0.17000455557065808d),
new NpgsqlTypes.NpgsqlBox(top: 0.6980462888274681d,right: 0.9232241395294319d,bottom: 0.1352887405330564d,left: 0.5035679645769763d),
new NpgsqlTypes.NpgsqlBox(top: 0.8264200917362571d,right: 0.7720812698292673d,bottom: 0.10633089167322218d,left: 0.27463502678169294d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8994547648557453d,right: 0.9822354618979504d,bottom: 0.5669242106440275d,left: 0.2571717775825928d),
new NpgsqlTypes.NpgsqlBox(top: 0.3314304968941384d,right: 0.8290583186983448d,bottom: 0.29917528492667256d,left: 0.43086605025804725d),
new NpgsqlTypes.NpgsqlBox(top: 0.9405507010730961d,right: 0.7406929973683682d,bottom: 0.5566957345913173d,left: 0.561970792158633d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3919939344439697d,right: 0.9104947458535055d,bottom: 0.1018468976060587d,left: 0.5837640793167959d),
new NpgsqlTypes.NpgsqlBox(top: 0.8416259519851661d,right: 0.8788991884865225d,bottom: 0.32284235668809735d,left: 0.7753788201564343d),
new NpgsqlTypes.NpgsqlBox(top: 0.8231658942884703d,right: 0.8735960506423192d,bottom: 0.29995944663134d,left: 0.032203565834222014d),
new NpgsqlTypes.NpgsqlBox(top: 0.9239950262341291d,right: 0.7094959074432331d,bottom: 0.008703285158223606d,left: 0.23994431579874465d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7869691514568931d,right: 0.5921374592272934d,bottom: 0.6099435648015992d,left: 0.17868943717333785d),
new NpgsqlTypes.NpgsqlBox(top: 0.5942753473114065d,right: 0.7726687112205883d,bottom: 0.5672607919935136d,left: 0.4929204602399624d),
new NpgsqlTypes.NpgsqlBox(top: 0.552405073687697d,right: 0.8946307045461629d,bottom: 0.39511485006374525d,left: 0.5963182030436033d),
new NpgsqlTypes.NpgsqlBox(top: 0.7300845616060833d,right: 0.24565366739251826d,bottom: 0.40453996393355096d,left: 0.1369927128804419d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5336483932697668d,right: 0.5855860020183741d,bottom: 0.29829229180947303d,left: 0.4958057541652683d),
new NpgsqlTypes.NpgsqlBox(top: 0.5413925388324144d,right: 0.8970717669939139d,bottom: 0.3864996312275377d,left: 0.5394191034559537d),
new NpgsqlTypes.NpgsqlBox(top: 0.8243932198976002d,right: 0.8915034225406611d,bottom: 0.02881296932619759d,left: 0.1254476658612631d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5657166213489838d,right: 0.6072911739492747d,bottom: 0.5374963813771002d,left: 0.17906859090941252d),
new NpgsqlTypes.NpgsqlBox(top: 0.653599448565356d,right: 0.9823436929235839d,bottom: 0.07531841395110128d,left: 0.711715695964894d),
new NpgsqlTypes.NpgsqlBox(top: 0.6429214754525507d,right: 0.9936002712803464d,bottom: 0.5589581019472308d,left: 0.13550012717131d),
new NpgsqlTypes.NpgsqlBox(top: 0.4995748990126402d,right: 0.1584742052701662d,bottom: 0.20581701906675176d,left: 0.1340678128961783d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42992813310974887d,right: 0.4129818898709451d,bottom: 0.02141353444123051d,left: 0.10476621623498572d),
new NpgsqlTypes.NpgsqlBox(top: 0.34593728494529763d,right: 0.6733504698449266d,bottom: 0.19944338199281142d,left: 0.5148686438370135d),
new NpgsqlTypes.NpgsqlBox(top: 0.9754259200020753d,right: 0.9559581808633162d,bottom: 0.36462297261746546d,left: 0.3864421650318972d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5247611936394969d,right: 0.8409446175399558d,bottom: 0.45772419394028674d,left: 0.12344880544546577d),
new NpgsqlTypes.NpgsqlBox(top: 0.683871464808838d,right: 0.893514411094739d,bottom: 0.17210307626830446d,left: 0.22856335737259348d),
new NpgsqlTypes.NpgsqlBox(top: 0.9244800214786371d,right: 0.7465970998776097d,bottom: 0.0705759997265124d,left: 0.620079941273385d),
new NpgsqlTypes.NpgsqlBox(top: 0.35563197500375887d,right: 0.7919187629217631d,bottom: 0.34107743000488444d,left: 0.6878433435732484d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5448382567475575d,right: 0.9820030280330759d,bottom: 0.49678188265542056d,left: 0.3768953553755069d),
new NpgsqlTypes.NpgsqlBox(top: 0.8395788035883622d,right: 0.4743701828875656d,bottom: 0.27882812420896486d,left: 0.12640956172086748d),
new NpgsqlTypes.NpgsqlBox(top: 0.15414822065680056d,right: 0.7446163587373609d,bottom: 0.10463057610020488d,left: 0.08356756568245371d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1434351088724949d,right: 0.9181456307609276d,bottom: 0.043432984513295025d,left: 0.8665277653546211d),
new NpgsqlTypes.NpgsqlBox(top: 0.6692081042486391d,right: 0.9002448703327274d,bottom: 0.6550416381183914d,left: 0.4064118816052992d),
new NpgsqlTypes.NpgsqlBox(top: 0.5580335434381174d,right: 0.3606280767590754d,bottom: 0.293529955687136d,left: 0.2691556974606929d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4451500348327778d,right: 0.03320823711591925d,bottom: 0.22524352528633573d,left: 0.024595802094042885d),
new NpgsqlTypes.NpgsqlBox(top: 0.5094572878507615d,right: 0.8732910376461364d,bottom: 0.20509840775932076d,left: 0.4726978162891665d),
new NpgsqlTypes.NpgsqlBox(top: 0.8575282014406732d,right: 0.45496725005719674d,bottom: 0.7043757509929095d,left: 0.03360587151492056d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5311794547472322d,right: 0.8238552361784228d,bottom: 0.03150794252884992d,left: 0.4616001373581272d),
new NpgsqlTypes.NpgsqlBox(top: 0.37055664651013154d,right: 0.9951890299960432d,bottom: 0.27815939267772416d,left: 0.5324427716813074d),
new NpgsqlTypes.NpgsqlBox(top: 0.705194583455348d,right: 0.149054951918841d,bottom: 0.5947959773672491d,left: 0.028751336024873342d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9420578296968843d,right: 0.3980472552612794d,bottom: 0.816429862946771d,left: 0.3949835141760879d),
new NpgsqlTypes.NpgsqlBox(top: 0.7218100728870912d,right: 0.7666475865119117d,bottom: 0.14454205947336773d,left: 0.3814155734907787d),
new NpgsqlTypes.NpgsqlBox(top: 0.7598585461846529d,right: 0.6550931746517797d,bottom: 0.11203952535365536d,left: 0.1253132146111564d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9658366625325211d,right: 0.9836612204052884d,bottom: 0.5389221944133179d,left: 0.8037685234481965d),
new NpgsqlTypes.NpgsqlBox(top: 0.9741612545393784d,right: 0.5658144308093139d,bottom: 0.8486428713757761d,left: 0.39244467492050916d),
new NpgsqlTypes.NpgsqlBox(top: 0.5573350774404081d,right: 0.8929237444431286d,bottom: 0.5443091830138859d,left: 0.2989321917941128d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8571611983634246d,right: 0.9080894758321209d,bottom: 0.7255684807917194d,left: 0.8082036266382763d),
new NpgsqlTypes.NpgsqlBox(top: 0.6924565301537433d,right: 0.10713998712721473d,bottom: 0.1275384547853624d,left: 0.06519944313067771d),
new NpgsqlTypes.NpgsqlBox(top: 0.9438530392794227d,right: 0.40823448747533675d,bottom: 0.8975487574598595d,left: 0.04672359483357702d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.21595415535068252d,right: 0.8032937194485726d,bottom: 0.07686116757171801d,left: 0.17227251457654746d),
new NpgsqlTypes.NpgsqlBox(top: 0.929792337142568d,right: 0.6914445362693905d,bottom: 0.1754282394760346d,left: 0.26116956970198035d),
new NpgsqlTypes.NpgsqlBox(top: 0.6499810422854572d,right: 0.6192134051691626d,bottom: 0.48929430741356694d,left: 0.41707871306871114d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.610844137507109d,right: 0.18669560357253556d,bottom: 0.4859346548761605d,left: 0.02667606091411656d),
new NpgsqlTypes.NpgsqlBox(top: 0.8813057476023397d,right: 0.4147780880791291d,bottom: 0.5465934223687485d,left: 0.0644599675564137d),
new NpgsqlTypes.NpgsqlBox(top: 0.72078212608543d,right: 0.9306209633430736d,bottom: 0.5411370653609852d,left: 0.7818285851053784d),
new NpgsqlTypes.NpgsqlBox(top: 0.2955498116353602d,right: 0.39802691825460745d,bottom: 0.07652658361506526d,left: 0.04407145880091812d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6506588157607813d,right: 0.9145976033943334d,bottom: 0.16749476520646234d,left: 0.07813810676018673d),
new NpgsqlTypes.NpgsqlBox(top: 0.8126340672934284d,right: 0.49567835307700814d,bottom: 0.45787997571502137d,left: 0.2575697690769817d),
new NpgsqlTypes.NpgsqlBox(top: 0.956973225447654d,right: 0.8775147297590331d,bottom: 0.8599535100067816d,left: 0.08883746516579705d),
new NpgsqlTypes.NpgsqlBox(top: 0.7790695225138973d,right: 0.9435324191079903d,bottom: 0.008337014275428545d,left: 0.3122948856615477d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8894692647042055d,right: 0.9687863802208502d,bottom: 0.541948038985407d,left: 0.40472506408800835d),
new NpgsqlTypes.NpgsqlBox(top: 0.6825828039115667d,right: 0.6943815743309285d,bottom: 0.3338624232749636d,left: 0.13703847041605277d),
new NpgsqlTypes.NpgsqlBox(top: 0.9559105516599247d,right: 0.7442570114044756d,bottom: 0.45295525389363345d,left: 0.33768811730179016d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5915588306873784d,right: 0.5349105805822311d,bottom: 0.5379533817394663d,left: 0.3512923842808079d),
new NpgsqlTypes.NpgsqlBox(top: 0.6867702339150775d,right: 0.7997554662380126d,bottom: 0.10886588799881491d,left: 0.6530779293527891d),
new NpgsqlTypes.NpgsqlBox(top: 0.24503583993896538d,right: 0.594185904403135d,bottom: 0.0981024818424141d,left: 0.5926746735810053d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6179940897952255d,right: 0.7485390497823525d,bottom: 0.290015294021316d,left: 0.7275785735792138d),
new NpgsqlTypes.NpgsqlBox(top: 0.6840638235651497d,right: 0.645719915234947d,bottom: 0.24533592625179157d,left: 0.5358265595479125d),
new NpgsqlTypes.NpgsqlBox(top: 0.5772641972285292d,right: 0.5581723224957829d,bottom: 0.047938191722056045d,left: 0.457380547065797d),
new NpgsqlTypes.NpgsqlBox(top: 0.7898609783540472d,right: 0.9349758143882765d,bottom: 0.27519700647433165d,left: 0.1780685482992903d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.39738045774806674d,right: 0.8534543142139427d,bottom: 0.20709139078161554d,left: 0.814575594218588d),
new NpgsqlTypes.NpgsqlBox(top: 0.7768361635797336d,right: 0.47552470272224623d,bottom: 0.07473135145269838d,left: 0.35312283021570334d),
new NpgsqlTypes.NpgsqlBox(top: 0.8677458612587009d,right: 0.6675963177997973d,bottom: 0.6066604078853538d,left: 0.3808942343036843d),
new NpgsqlTypes.NpgsqlBox(top: 0.8341751331174324d,right: 0.9731508333684391d,bottom: 0.5106611894912276d,left: 0.02223980999246644d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4033413906128315d,right: 0.9486990794011855d,bottom: 0.30716350005105697d,left: 0.06400883869781282d),
new NpgsqlTypes.NpgsqlBox(top: 0.8182046269290766d,right: 0.8190162623148503d,bottom: 0.3056115538893611d,left: 0.2602315353881651d),
new NpgsqlTypes.NpgsqlBox(top: 0.12451900210707334d,right: 0.4926896517553685d,bottom: 0.07649117540621941d,left: 0.28415443119843153d),
new NpgsqlTypes.NpgsqlBox(top: 0.8835134811502601d,right: 0.9480385726166608d,bottom: 0.8533980313158195d,left: 0.44499185605221203d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2820422083210825d,right: 0.8177827130475643d,bottom: 0.23515559401788366d,left: 0.7769723258125223d),
new NpgsqlTypes.NpgsqlBox(top: 0.5177622802979909d,right: 0.8274559602902263d,bottom: 0.38049390006384887d,left: 0.47198220103341404d),
new NpgsqlTypes.NpgsqlBox(top: 0.9663626259432802d,right: 0.10155115186252339d,bottom: 0.05270858888424701d,left: 0.07813266412463293d),
new NpgsqlTypes.NpgsqlBox(top: 0.6411390573527633d,right: 0.662731894920639d,bottom: 0.2431691564823597d,left: 0.4998836370565709d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlBox(top: 0.9048102804015077d,right: 0.8864444700463775d,bottom: 0.4561738490469406d,left: 0.8097705699254519d),
new NpgsqlTypes.NpgsqlBox(top: 0.6708611560276244d,right: 0.4341410422534715d,bottom: 0.00495514205777936d,left: 0.27209232128790395d),
new NpgsqlTypes.NpgsqlBox(top: 0.5587746059716457d,right: 0.9665019536593118d,bottom: 0.08986181064057752d,left: 0.471531064130694d),
new NpgsqlTypes.NpgsqlBox(top: 0.46116672985032736d,right: 0.497728590892241d,bottom: 0.27970635518341214d,left: 0.22838843061988012d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7368840855799828d,right: 0.5750303158239258d,bottom: 0.47248358009530633d,left: 0.42862546206669316d),
new NpgsqlTypes.NpgsqlBox(top: 0.7728816223996099d,right: 0.7945651761270304d,bottom: 0.710610285913386d,left: 0.2663235203243539d),
new NpgsqlTypes.NpgsqlBox(top: 0.7673147549931687d,right: 0.7422203947737315d,bottom: 0.1898968932209768d,left: 0.1238279591679462d),
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
new NpgsqlTypes.NpgsqlBox(top: 0.9335563966249418d,right: 0.1555859266518893d,bottom: 0.5273179489938814d,left: 0.09435630797097228d),
new NpgsqlTypes.NpgsqlBox(top: 0.8865018879326952d,right: 0.8487481309889022d,bottom: 0.5105803026560988d,left: 0.5916565586368319d),
new NpgsqlTypes.NpgsqlBox(top: 0.7066793225253427d,right: 0.7622034894141501d,bottom: 0.1469742890679855d,left: 0.44351957829714395d),
new NpgsqlTypes.NpgsqlBox(top: 0.954460764831929d,right: 0.9521423485194588d,bottom: 0.3133086926067584d,left: 0.3380455214556862d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6876412291795865d,right: 0.4267479595761059d,bottom: 0.524190678956628d,left: 0.17437608699821494d),
new NpgsqlTypes.NpgsqlBox(top: 0.5079137539049128d,right: 0.4186172617375221d,bottom: 0.26979663410199406d,left: 0.05435110740899629d),
new NpgsqlTypes.NpgsqlBox(top: 0.8780232356819219d,right: 0.7898219933333066d,bottom: 0.29730076875904765d,left: 0.27182466226522306d),
new NpgsqlTypes.NpgsqlBox(top: 0.30231348251804147d,right: 0.9647862174306229d,bottom: 0.17235445977379416d,left: 0.14334565309950442d),
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
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
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 3, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 125, query1, 43, query2))
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
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatchAsync(connection, 1, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatch(connection, 26, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
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

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
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

