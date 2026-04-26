

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6081896878689126d, y: 0.8893519998458359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653220360415989d, y: 0.9202733080723532d), new NpgsqlTypes.NpgsqlPoint(x: 0.189670078787035d, y: 0.47782577199766496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5395710479628612d, y: 0.10579831742237922d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835059758622131d, y: 0.9551727591372645d), new NpgsqlTypes.NpgsqlPoint(x: 0.15632184140583227d, y: 0.7557341641823323d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15698962662259686d, y: 0.03175162872753978d), new NpgsqlTypes.NpgsqlPoint(x: 0.7684829238354578d, y: 0.33035208761717805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944228220310116d, y: 0.4953754583653661d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4616244588301106d, y: 0.013381925157047392d), new NpgsqlTypes.NpgsqlPoint(x: 0.997052757964448d, y: 0.6779806290688523d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344975214306015d, y: 0.929837644026977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43685468681998674d, y: 0.7825420850561002d), new NpgsqlTypes.NpgsqlPoint(x: 0.40430283277103396d, y: 0.3080226814867164d), new NpgsqlTypes.NpgsqlPoint(x: 0.4409919274698155d, y: 0.39354018827984627d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955923935372901d, y: 0.4700417590338908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9136807914838381d, y: 0.5631745824600485d), new NpgsqlTypes.NpgsqlPoint(x: 0.24053087815731722d, y: 0.494617802362724d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7724482356343205d, y: 0.23810616473767277d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444831035397539d, y: 0.26504836809062027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8065654341534306d, y: 0.3907545272981391d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.568237551903321d, y: 0.1361241997728181d), new NpgsqlTypes.NpgsqlPoint(x: 0.718682887756309d, y: 0.1913638882595491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882365455874751d, y: 0.004065456617906693d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.915831541417308d, y: 0.3048450980399722d), new NpgsqlTypes.NpgsqlPoint(x: 0.660244039959172d, y: 0.701278420900589d), new NpgsqlTypes.NpgsqlPoint(x: 0.25737342481991243d, y: 0.048303367332291125d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0749949848971454d, y: 0.7868981344822852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3286514428424855d, y: 0.05863550236294113d), new NpgsqlTypes.NpgsqlPoint(x: 0.07524078118982802d, y: 0.03379907801569193d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2287755340147395d, y: 0.07003921615145892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873352951623092d, y: 0.4808441426640143d), new NpgsqlTypes.NpgsqlPoint(x: 0.13920541487206373d, y: 0.30773138282339985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9154652075069304d, y: 0.5323049006836826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175316165424471d, y: 0.277571489064916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779683516749341d, y: 0.46274350618725457d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1834863613829948d, y: 0.8618246364349538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6307793130170312d, y: 0.6172725913795507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5275830219044789d, y: 0.7140229161559385d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2209040259308095d, y: 0.6059940897102597d), new NpgsqlTypes.NpgsqlPoint(x: 0.21475503302391807d, y: 0.15639809658893256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8076137116144984d, y: 0.5203237018120838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18849850079310815d, y: 0.916849361419572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169467440579536d, y: 0.14257511740913786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9296112191537197d, y: 0.9301089452582889d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11697271022332123d, y: 0.5056366424597976d), new NpgsqlTypes.NpgsqlPoint(x: 0.694095082961139d, y: 0.7202108540413155d), new NpgsqlTypes.NpgsqlPoint(x: 0.580872908688381d, y: 0.1747073580650994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07333634530016275d, y: 0.24541072557819743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5480936472558692d, y: 0.2489951710794428d), new NpgsqlTypes.NpgsqlPoint(x: 0.025415509472615616d, y: 0.15999503248259617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29066453576254814d, y: 0.30075084693325405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9817042247983817d, y: 0.5749001292938285d), new NpgsqlTypes.NpgsqlPoint(x: 0.1849220754214813d, y: 0.012522593131688242d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47188268485387774d, y: 0.8051155103876438d), new NpgsqlTypes.NpgsqlPoint(x: 0.3666671106091155d, y: 0.15485405096789517d), new NpgsqlTypes.NpgsqlPoint(x: 0.06525605240256771d, y: 0.8575553875165536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3469416321301554d, y: 0.8954187755684098d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869570508828886d, y: 0.10879554274026171d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721042797590619d, y: 0.1996878217599507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7114406611561069d, y: 0.32486541667518753d), new NpgsqlTypes.NpgsqlPoint(x: 0.06597697447396533d, y: 0.36817871969435534d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633023864544386d, y: 0.9992728423281836d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33169741289437193d, y: 0.509911303922527d), new NpgsqlTypes.NpgsqlPoint(x: 0.2728129667691255d, y: 0.8615907460338958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460140803974208d, y: 0.48097228817193227d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8561135212450449d, y: 0.5182953113619937d), new NpgsqlTypes.NpgsqlPoint(x: 0.9296600057486704d, y: 0.15180339175613677d), new NpgsqlTypes.NpgsqlPoint(x: 0.4284940794167239d, y: 0.8315562414732927d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07373685643895977d, y: 0.9758932712862262d), new NpgsqlTypes.NpgsqlPoint(x: 0.10548114985659474d, y: 0.2902376694177766d), new NpgsqlTypes.NpgsqlPoint(x: 0.14619435595434183d, y: 0.07440032753962611d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32071126139314976d, y: 0.02510280645495866d), new NpgsqlTypes.NpgsqlPoint(x: 0.835541226867921d, y: 0.3980300744506525d), new NpgsqlTypes.NpgsqlPoint(x: 0.4161598239954588d, y: 0.25258982058896284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5651354173806172d, y: 0.20302261439789682d), new NpgsqlTypes.NpgsqlPoint(x: 0.05005871835024678d, y: 0.6663805753757874d), new NpgsqlTypes.NpgsqlPoint(x: 0.17137887604691204d, y: 0.4798023646336762d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18533067561593275d, y: 0.16976872653551844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357305808708547d, y: 0.13904990026088326d), new NpgsqlTypes.NpgsqlPoint(x: 0.24016245171606732d, y: 0.13494232978354892d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9812628825484679d, y: 0.6418710340431905d), new NpgsqlTypes.NpgsqlPoint(x: 0.9892055492956209d, y: 0.3291982564301418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242101618518665d, y: 0.7397472678180846d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45784123402819166d, y: 0.7692221114380893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255215134024247d, y: 0.26934568467666054d), new NpgsqlTypes.NpgsqlPoint(x: 0.10473570812535649d, y: 0.6070659440940384d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052114198712514104d, y: 0.5936738089992437d), new NpgsqlTypes.NpgsqlPoint(x: 0.13845647985405474d, y: 0.18661731248372637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998232643000409d, y: 0.6921608861414987d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5436861152676755d, y: 0.44993834748843187d), new NpgsqlTypes.NpgsqlPoint(x: 0.12497532263815003d, y: 0.4315607756479566d), new NpgsqlTypes.NpgsqlPoint(x: 0.47548341325832666d, y: 0.5893301034515692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7145869370627044d, y: 0.4618297722094744d), new NpgsqlTypes.NpgsqlPoint(x: 0.09049420766642302d, y: 0.7020339591609887d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422608514494601d, y: 0.8285960324777446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13946295292927136d, y: 0.7446669647662412d), new NpgsqlTypes.NpgsqlPoint(x: 0.2683776224309371d, y: 0.6438211744260556d), new NpgsqlTypes.NpgsqlPoint(x: 0.2550040498846684d, y: 0.6803203428454457d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9468095171377962d, y: 0.4937989914029154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130308290959262d, y: 0.09962974613464037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664251968669815d, y: 0.5975223714732807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3013127253772512d, y: 0.9008043664745702d), new NpgsqlTypes.NpgsqlPoint(x: 0.030343364070647194d, y: 0.9039437606951584d), new NpgsqlTypes.NpgsqlPoint(x: 0.25854453996109705d, y: 0.9195734818153812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.527996835352804d, y: 0.9810409844925347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7346171452774031d, y: 0.17938485303226404d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986437823252669d, y: 0.7047745446761935d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5735968548347754d, y: 0.971967830912708d), new NpgsqlTypes.NpgsqlPoint(x: 0.14060865706687464d, y: 0.8176885194281255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095909221583529d, y: 0.9997236546277853d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0420938280060168d, y: 0.06784857505996311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674104779405624d, y: 0.8947669522788996d), new NpgsqlTypes.NpgsqlPoint(x: 0.3605924377012921d, y: 0.27058708668026044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6904670039661318d, y: 0.7252809914237917d), new NpgsqlTypes.NpgsqlPoint(x: 0.515040153095967d, y: 0.4066913723860356d), new NpgsqlTypes.NpgsqlPoint(x: 0.23674174787293345d, y: 0.5504455588445266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11044968269310251d, y: 0.4252285558013035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904618917124346d, y: 0.33195516089923194d), new NpgsqlTypes.NpgsqlPoint(x: 0.32358292057049776d, y: 0.48276080066810456d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16250607967225128d, y: 0.7329567047540824d), new NpgsqlTypes.NpgsqlPoint(x: 0.6456294907599482d, y: 0.26293224898844547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497639260883981d, y: 0.6588725688680452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8518195646127623d, y: 0.9733971767893295d), new NpgsqlTypes.NpgsqlPoint(x: 0.026744882089642874d, y: 0.25130938313854934d), new NpgsqlTypes.NpgsqlPoint(x: 0.90467227067933d, y: 0.16757798133176982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33925862095987225d, y: 0.2570823872489991d), new NpgsqlTypes.NpgsqlPoint(x: 0.8650325908002182d, y: 0.6927730000210586d), new NpgsqlTypes.NpgsqlPoint(x: 0.3691605371686132d, y: 0.3437498191891384d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22392615672275085d, y: 0.41523244027479833d), new NpgsqlTypes.NpgsqlPoint(x: 0.28428295819754756d, y: 0.7172370129684078d), new NpgsqlTypes.NpgsqlPoint(x: 0.11186529845077775d, y: 0.9783452278275232d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8468505547652098d, y: 0.2727163725729197d), new NpgsqlTypes.NpgsqlPoint(x: 0.183092669745057d, y: 0.8982302624395994d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927941490336474d, y: 0.36366060627589536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7560853201890828d, y: 0.7569140419900842d), new NpgsqlTypes.NpgsqlPoint(x: 0.727326208776876d, y: 0.34788390463146246d), new NpgsqlTypes.NpgsqlPoint(x: 0.47049264713481787d, y: 0.43021645685952725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35219816841034113d, y: 0.6832926340420861d), new NpgsqlTypes.NpgsqlPoint(x: 0.0696247389421415d, y: 0.006224421762538901d), new NpgsqlTypes.NpgsqlPoint(x: 0.708701467783225d, y: 0.10466476569955874d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43435340518402954d, y: 0.9274487739956578d), new NpgsqlTypes.NpgsqlPoint(x: 0.15381460245695466d, y: 0.5591310897767425d), new NpgsqlTypes.NpgsqlPoint(x: 0.896536291152931d, y: 0.35032886891353787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15768427570838572d, y: 0.38681697509239266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3497797419293738d, y: 0.12885572831847392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5225368390367016d, y: 0.4513823918028257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6450224343888219d, y: 0.21188501803092286d), new NpgsqlTypes.NpgsqlPoint(x: 0.45379299807297346d, y: 0.06292578142386307d), new NpgsqlTypes.NpgsqlPoint(x: 0.14919300108135802d, y: 0.7884985295579628d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6503537195701949d, y: 0.21238526836323102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085657926114363d, y: 0.6086712047315751d), new NpgsqlTypes.NpgsqlPoint(x: 0.25294828803143166d, y: 0.7211065200783868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.262978583134606d, y: 0.19750932767601237d), new NpgsqlTypes.NpgsqlPoint(x: 0.48824067173623886d, y: 0.0061895710054169495d), new NpgsqlTypes.NpgsqlPoint(x: 0.12810524443938176d, y: 0.18709994664257468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11552880209103511d, y: 0.7004382093732029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549333549604545d, y: 0.15311169277518544d), new NpgsqlTypes.NpgsqlPoint(x: 0.922231317772466d, y: 0.5358154591263613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.172478863141994d, y: 0.00843308331884629d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296827950004612d, y: 0.2631100879570699d), new NpgsqlTypes.NpgsqlPoint(x: 0.5417742592402854d, y: 0.7007378713619042d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12485059090295914d, y: 0.3638372655782367d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875494098761753d, y: 0.37478721099567924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022398919749203d, y: 0.08552113021985142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.912452269784826d, y: 0.29775772234216524d), new NpgsqlTypes.NpgsqlPoint(x: 0.016651167028992386d, y: 0.7584086986164372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520663858753917d, y: 0.9222557298004728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45882140109787495d, y: 0.46715132213160393d), new NpgsqlTypes.NpgsqlPoint(x: 0.3524626191301249d, y: 0.26756575839328633d), new NpgsqlTypes.NpgsqlPoint(x: 0.27145203188979516d, y: 0.48975002577498883d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305761662203681d, y: 0.9902183149660879d), new NpgsqlTypes.NpgsqlPoint(x: 0.26221362065482723d, y: 0.17048422429709875d), new NpgsqlTypes.NpgsqlPoint(x: 0.850446926163039d, y: 0.46043531582349084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2647953005984519d, y: 0.0448003325360391d), new NpgsqlTypes.NpgsqlPoint(x: 0.13046597935919957d, y: 0.2701390859330435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8995339709888243d, y: 0.49256152529848196d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4411835742711886d, y: 0.27348241529879946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749401107072788d, y: 0.6901038314187443d), new NpgsqlTypes.NpgsqlPoint(x: 0.4920343481972561d, y: 0.6195489616591359d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07956958862804941d, y: 0.44304163692366083d), new NpgsqlTypes.NpgsqlPoint(x: 0.18832816566299315d, y: 0.6103191591787056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121097411463557d, y: 0.9143061133440756d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39368225814333135d, y: 0.07475866318635804d), new NpgsqlTypes.NpgsqlPoint(x: 0.31633521975428547d, y: 0.004089157961719825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929160384582359d, y: 0.38119704025419365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7265675365123287d, y: 0.09173990381823349d), new NpgsqlTypes.NpgsqlPoint(x: 0.750822798765826d, y: 0.6965121057068294d), new NpgsqlTypes.NpgsqlPoint(x: 0.195452688791933d, y: 0.2105465272090904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41019724141951885d, y: 0.6900219181798498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335481357453504d, y: 0.4266256238504482d), new NpgsqlTypes.NpgsqlPoint(x: 0.7349580915766761d, y: 0.22833464901041045d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6871617541635527d, y: 0.44461112061002805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813578863395149d, y: 0.9841016744034043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402377852351014d, y: 0.5393513379023204d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5145814127945019d, y: 0.5235464126751619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093440327727201d, y: 0.6579134186903653d), new NpgsqlTypes.NpgsqlPoint(x: 0.1169090625737581d, y: 0.23671975842835247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11520757325987196d, y: 0.5726111798563567d), new NpgsqlTypes.NpgsqlPoint(x: 0.16154208720205798d, y: 0.28380778696396314d), new NpgsqlTypes.NpgsqlPoint(x: 0.26372997175352964d, y: 0.1445565674564382d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31117135203255186d, y: 0.3261056956122498d), new NpgsqlTypes.NpgsqlPoint(x: 0.3264988696267034d, y: 0.7450362881039827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7273653298716275d, y: 0.8833696891869877d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1986137112633154d, y: 0.050453660632337916d), new NpgsqlTypes.NpgsqlPoint(x: 0.024286674086298032d, y: 0.8616964432426838d), new NpgsqlTypes.NpgsqlPoint(x: 0.12983141735753612d, y: 0.9618696926538499d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6346355981128236d, y: 0.8673913953920492d), new NpgsqlTypes.NpgsqlPoint(x: 0.2032670362807777d, y: 0.09515729233240655d), new NpgsqlTypes.NpgsqlPoint(x: 0.00713589357143074d, y: 0.3711291955824292d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6471790700232568d, y: 0.4646627635232524d), new NpgsqlTypes.NpgsqlPoint(x: 0.29112979796005545d, y: 0.5204228572386413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085831034002395d, y: 0.5931958859954675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26602225990021333d, y: 0.3648106000697481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500119452434436d, y: 0.15046515921077308d), new NpgsqlTypes.NpgsqlPoint(x: 0.1047713896741006d, y: 0.10242130672422645d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2679582016251021d, y: 0.9280434161211412d), new NpgsqlTypes.NpgsqlPoint(x: 0.9517453144834117d, y: 0.9761871449528432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379532247387004d, y: 0.7332179881173314d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6898860071824013d, y: 0.5034636345325503d), new NpgsqlTypes.NpgsqlPoint(x: 0.91948934185738d, y: 0.03910276519350819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433754686567491d, y: 0.27971054255188976d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7209856904900923d, y: 0.3967616658511347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411492669703751d, y: 0.4642433739831937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759345187944085d, y: 0.4187816691379874d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6479524708422657d, y: 0.49891989200565734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8986692524665034d, y: 0.37289058352936877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485173409604941d, y: 0.03908178806177809d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3597327861029682d, y: 0.06748141329700796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157551811641859d, y: 0.6623200963866321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9710623319262385d, y: 0.3618983905505053d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31867818950561877d, y: 0.16847443603277312d), new NpgsqlTypes.NpgsqlPoint(x: 0.22468909651577973d, y: 0.10778395069014235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4975513820194134d, y: 0.5734722850693396d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08928939078286147d, y: 0.3635443340604516d), new NpgsqlTypes.NpgsqlPoint(x: 0.018599904437596848d, y: 0.9286765698479734d), new NpgsqlTypes.NpgsqlPoint(x: 0.833198326753833d, y: 0.6116854434691374d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7319586752701974d, y: 0.5485718115580521d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718904856928827d, y: 0.5126423796521576d), new NpgsqlTypes.NpgsqlPoint(x: 0.15570917494258263d, y: 0.16132914456322434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8551518683900028d, y: 0.2601538522282174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923431355438604d, y: 0.1219142627409252d), new NpgsqlTypes.NpgsqlPoint(x: 0.891273334945506d, y: 0.8602839195175602d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12095209543311658d, y: 0.42727794533014896d), new NpgsqlTypes.NpgsqlPoint(x: 0.487006811044314d, y: 0.22325341825893097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6692294703387136d, y: 0.950503105634724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7577008269921321d, y: 0.34641864101857556d), new NpgsqlTypes.NpgsqlPoint(x: 0.32558185008685014d, y: 0.6192192077767041d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518304086022057d, y: 0.01856547130824482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12665180213194926d, y: 0.015162789722269143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7670599188820629d, y: 0.64191709894791d), new NpgsqlTypes.NpgsqlPoint(x: 0.692815505986417d, y: 0.24754332623985742d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6155089544024229d, y: 0.9438899120226977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9745033561806545d, y: 0.6519992196612431d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628730562084696d, y: 0.6205022736219977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3177507635884701d, y: 0.6312820566579522d), new NpgsqlTypes.NpgsqlPoint(x: 0.31066753548024484d, y: 0.5841165410053061d), new NpgsqlTypes.NpgsqlPoint(x: 0.18315839150930335d, y: 0.10000632529853393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7914513256673831d, y: 0.04429430021735781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101130916853033d, y: 0.19467687141611623d), new NpgsqlTypes.NpgsqlPoint(x: 0.42314092377538315d, y: 0.4587288238162933d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0118837905252972d, y: 0.6278372379871039d), new NpgsqlTypes.NpgsqlPoint(x: 0.18814706248456503d, y: 0.7985449446587495d), new NpgsqlTypes.NpgsqlPoint(x: 0.556827615910767d, y: 0.8020495663977396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1285256182446839d, y: 0.6280944237169479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003469111642842d, y: 0.14680588508544812d), new NpgsqlTypes.NpgsqlPoint(x: 0.41431687483541446d, y: 0.5196716396106702d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36851162218750055d, y: 0.2060581447514943d), new NpgsqlTypes.NpgsqlPoint(x: 0.37630433260350216d, y: 0.09266845994115591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6685507287992403d, y: 0.1568513277386674d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9083811014455092d, y: 0.2552896749298459d), new NpgsqlTypes.NpgsqlPoint(x: 0.45002749624345595d, y: 0.06809716898376339d), new NpgsqlTypes.NpgsqlPoint(x: 0.026976207455143397d, y: 0.22961524393013144d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7821535484875982d, y: 0.07518382117832001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263992680360517d, y: 0.8847527326668992d), new NpgsqlTypes.NpgsqlPoint(x: 0.5884255823077718d, y: 0.6576162007514958d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8946271578262859d, y: 0.4100256533305754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789681205171885d, y: 0.25253587538482947d), new NpgsqlTypes.NpgsqlPoint(x: 0.7109164926626327d, y: 0.4913293301884878d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013134005255057035d, y: 0.5385920949716702d), new NpgsqlTypes.NpgsqlPoint(x: 0.4830584257857471d, y: 0.1281275747488091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8019047719469968d, y: 0.18903346975245228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6603161034204859d, y: 0.2966443521169104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176028291344182d, y: 0.2814033776800383d), new NpgsqlTypes.NpgsqlPoint(x: 0.026785117371100675d, y: 0.025210080311098393d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14910280179835522d, y: 0.6258150216121791d), new NpgsqlTypes.NpgsqlPoint(x: 0.10627491073171347d, y: 0.06359253850951863d), new NpgsqlTypes.NpgsqlPoint(x: 0.22033452945938592d, y: 0.5586022381253202d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4483368571655235d, y: 0.05333075190505099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8340639191198228d, y: 0.39689142840658d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879549235335461d, y: 0.39491024738609226d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3875721930472812d, y: 0.44228626724341125d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514616698089897d, y: 0.15681836355964818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628241423063328d, y: 0.6702468091122178d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16840441588911825d, y: 0.46634077858833967d), new NpgsqlTypes.NpgsqlPoint(x: 0.36865190787550894d, y: 0.16361923968594616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408694149641689d, y: 0.25428821165355486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6671861229099683d, y: 0.756491213465024d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654288423324455d, y: 0.681192978738166d), new NpgsqlTypes.NpgsqlPoint(x: 0.29193888997198414d, y: 0.5451968845339633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4752939224043389d, y: 0.34759729789532723d), new NpgsqlTypes.NpgsqlPoint(x: 0.8943242439029163d, y: 0.07637388845614235d), new NpgsqlTypes.NpgsqlPoint(x: 0.991153660841402d, y: 0.8615283921411352d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5160518935473047d, y: 0.09939738560536115d), new NpgsqlTypes.NpgsqlPoint(x: 0.314833748576517d, y: 0.6988525272456972d), new NpgsqlTypes.NpgsqlPoint(x: 0.19189619150931025d, y: 0.22179144546939933d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7311124187754675d, y: 0.03003326590327582d), new NpgsqlTypes.NpgsqlPoint(x: 0.2748521223620981d, y: 0.9918437045924637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6186937877701315d, y: 0.30034640932436196d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2011100988951895d, y: 0.8297151494274378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443473750740305d, y: 0.007006983559215141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165005092320205d, y: 0.2285584166403266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5276446341959666d, y: 0.9550644704977694d), new NpgsqlTypes.NpgsqlPoint(x: 0.973923449441221d, y: 0.44033956638710325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522388684012359d, y: 0.8359455942004431d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19896087124183937d, y: 0.26121262422948677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198042129725317d, y: 0.713163584326203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8523828361784277d, y: 0.14333856614107365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046278649416357065d, y: 0.15094688527440547d), new NpgsqlTypes.NpgsqlPoint(x: 0.4874128544874773d, y: 0.29996659047732677d), new NpgsqlTypes.NpgsqlPoint(x: 0.4849732960677674d, y: 0.9360025620419002d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9117394068106403d, y: 0.30101958819726593d), new NpgsqlTypes.NpgsqlPoint(x: 0.2611258318546583d, y: 0.8015284900346069d), new NpgsqlTypes.NpgsqlPoint(x: 0.3258993996967826d, y: 0.9912910093615556d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4401280814084123d, y: 0.5829686082954403d), new NpgsqlTypes.NpgsqlPoint(x: 0.90103065402329d, y: 0.7562552306130527d), new NpgsqlTypes.NpgsqlPoint(x: 0.14251862811914706d, y: 0.6943023250662776d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15120636058296522d, y: 0.29000297147732357d), new NpgsqlTypes.NpgsqlPoint(x: 0.37253526966322026d, y: 0.8133946401581172d), new NpgsqlTypes.NpgsqlPoint(x: 0.9368695936281236d, y: 0.07815310993519653d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3318794329837427d, y: 0.9863423648390967d), new NpgsqlTypes.NpgsqlPoint(x: 0.17110497238262756d, y: 0.41710486603408503d), new NpgsqlTypes.NpgsqlPoint(x: 0.12258865182520307d, y: 0.47563302913014815d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18819394158236735d, y: 0.27606004512294646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273846138939094d, y: 0.9195474249010159d), new NpgsqlTypes.NpgsqlPoint(x: 0.8785499582853163d, y: 0.37037797274613893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5948192591217162d, y: 0.772620589239643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849123984917992d, y: 0.043951223901786185d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502991765322368d, y: 0.9974989088653583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8644215422589961d, y: 0.2502423656584879d), new NpgsqlTypes.NpgsqlPoint(x: 0.3508654123152801d, y: 0.7052750569352126d), new NpgsqlTypes.NpgsqlPoint(x: 0.1817599427426757d, y: 0.4278691957289421d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32998857247427715d, y: 0.8978861986798216d), new NpgsqlTypes.NpgsqlPoint(x: 0.34461171197772833d, y: 0.7265722881007173d), new NpgsqlTypes.NpgsqlPoint(x: 0.89721686521797d, y: 0.5800439467239565d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395461760929388d, y: 0.8264446210803954d), new NpgsqlTypes.NpgsqlPoint(x: 0.734239585833103d, y: 0.15536651398529966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6229630438419524d, y: 0.8180493606430974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12901489326480742d, y: 0.4977905791740246d), new NpgsqlTypes.NpgsqlPoint(x: 0.16533666429797522d, y: 0.3303670456309259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073353743993626d, y: 0.6362762457547787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008972389161134964d, y: 0.8201084816475142d), new NpgsqlTypes.NpgsqlPoint(x: 0.08391254952636507d, y: 0.33810578451281215d), new NpgsqlTypes.NpgsqlPoint(x: 0.3371547499270535d, y: 0.6943593235330072d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3138100486290647d, y: 0.8838337946926189d), new NpgsqlTypes.NpgsqlPoint(x: 0.7650907821597895d, y: 0.9951381882681685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9946985633435206d, y: 0.6230640246850828d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38598378079470574d, y: 0.09043969172104482d), new NpgsqlTypes.NpgsqlPoint(x: 0.2498061550381515d, y: 0.2950916109420322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222274621387216d, y: 0.3388167675988676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774836330536716d, y: 0.7268979387755719d), new NpgsqlTypes.NpgsqlPoint(x: 0.11189252852759468d, y: 0.6934547667790018d), new NpgsqlTypes.NpgsqlPoint(x: 0.3715075569731071d, y: 0.07182017625113346d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31227787800609774d, y: 0.4568003552596739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6529386464053422d, y: 0.6572575467791618d), new NpgsqlTypes.NpgsqlPoint(x: 0.525436770289919d, y: 0.7024315775435691d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4849509807758531d, y: 0.37623061040715844d), new NpgsqlTypes.NpgsqlPoint(x: 0.35050454326744906d, y: 0.7716709034083319d), new NpgsqlTypes.NpgsqlPoint(x: 0.20366399418633552d, y: 0.15644401835164257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3826149056404209d, y: 0.27924800276438766d), new NpgsqlTypes.NpgsqlPoint(x: 0.018168678678410433d, y: 0.6796892300280923d), new NpgsqlTypes.NpgsqlPoint(x: 0.08947513841204568d, y: 0.8330473187055293d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395467683704161d, y: 0.9018376398617827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3351606897789511d, y: 0.9096874906016794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442967456999399d, y: 0.4503415391033818d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04938070245275239d, y: 0.21438454755211933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955422522998578d, y: 0.20136035388252937d), new NpgsqlTypes.NpgsqlPoint(x: 0.3361977248385156d, y: 0.6876385392853505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.279987849355424d, y: 0.938664566124924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337623677308238d, y: 0.7516731825286234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8231350315025648d, y: 0.20411886944169821d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7751523650869326d, y: 0.31548889706839733d), new NpgsqlTypes.NpgsqlPoint(x: 0.35195048112662897d, y: 0.280559872945214d), new NpgsqlTypes.NpgsqlPoint(x: 0.0699328115773612d, y: 0.633024042727202d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7027780287859224d, y: 0.7772174099766338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6033537094128525d, y: 0.8993767165809272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431665870168465d, y: 0.5530075855129093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2805222424292154d, y: 0.8433075354828936d), new NpgsqlTypes.NpgsqlPoint(x: 0.03276641183820095d, y: 0.7001805970300718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920600296917085d, y: 0.7498669194282206d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7980351212309185d, y: 0.9239719798797994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7228507498492207d, y: 0.2097551249819143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7219810460232251d, y: 0.6053787219879513d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23134324472231904d, y: 0.8144949478760449d), new NpgsqlTypes.NpgsqlPoint(x: 0.11061543495171133d, y: 0.8720633479886002d), new NpgsqlTypes.NpgsqlPoint(x: 0.18348695627985d, y: 0.5059992236423814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9261217802248595d, y: 0.714201249881294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693552043768687d, y: 0.1377247819869164d), new NpgsqlTypes.NpgsqlPoint(x: 0.05355796006992597d, y: 0.8702982922669272d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.855094821219135d, y: 0.24866600270380612d), new NpgsqlTypes.NpgsqlPoint(x: 0.14815753568246315d, y: 0.08293294289917741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826272883802172d, y: 0.022428088158470416d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5015638323962326d, y: 0.9186485587653433d), new NpgsqlTypes.NpgsqlPoint(x: 0.07666788480209297d, y: 0.620383286265853d), new NpgsqlTypes.NpgsqlPoint(x: 0.17140759936525551d, y: 0.9518426045955216d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08028317993311818d, y: 0.25221184632315263d), new NpgsqlTypes.NpgsqlPoint(x: 0.3677690278348601d, y: 0.20782859405717968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2555083468703937d, y: 0.6070832166123473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5573506307892886d, y: 0.14754001714914433d), new NpgsqlTypes.NpgsqlPoint(x: 0.13467917033766486d, y: 0.9098228146563755d), new NpgsqlTypes.NpgsqlPoint(x: 0.20848053672962796d, y: 0.13596095245465645d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4900151926803743d, y: 0.38602757380328623d), new NpgsqlTypes.NpgsqlPoint(x: 0.282125627566699d, y: 0.30087589175798524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8210116563061388d, y: 0.2210781318685474d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9787047388425935d, y: 0.3280345215895447d), new NpgsqlTypes.NpgsqlPoint(x: 0.29039736438422126d, y: 0.0014639407040715202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194483293601725d, y: 0.7920932790116617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6951529673105151d, y: 0.7865776378967174d), new NpgsqlTypes.NpgsqlPoint(x: 0.34978327362731243d, y: 0.8584512662074452d), new NpgsqlTypes.NpgsqlPoint(x: 0.8438095559253027d, y: 0.6672685570925784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48278077944299613d, y: 0.4038405716814436d), new NpgsqlTypes.NpgsqlPoint(x: 0.33590493660574805d, y: 0.9933527667430507d), new NpgsqlTypes.NpgsqlPoint(x: 0.24622460461424667d, y: 0.11455766001556655d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48209334981685503d, y: 0.5349605637874488d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227754013872054d, y: 0.0868475702939503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5452597169567094d, y: 0.4843576788218472d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2554636492304475d, y: 0.5608981508142887d), new NpgsqlTypes.NpgsqlPoint(x: 0.6326863945855917d, y: 0.6472254033869936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854325154520923d, y: 0.8452653591982076d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24681205368081327d, y: 0.03240942533638147d), new NpgsqlTypes.NpgsqlPoint(x: 0.20878331308409936d, y: 0.5555757154754041d), new NpgsqlTypes.NpgsqlPoint(x: 0.18622024024237727d, y: 0.6276459573588197d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.416411769858835d, y: 0.25612982653796657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7497137415681125d, y: 0.8574323106331513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5318249353925151d, y: 0.10098456025268854d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28588831017105265d, y: 0.8547257450764292d), new NpgsqlTypes.NpgsqlPoint(x: 0.04353674904752747d, y: 0.8080609873423583d), new NpgsqlTypes.NpgsqlPoint(x: 0.2727545504929072d, y: 0.8883355259217113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8757671387720231d, y: 0.5520057269150459d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357160339598423d, y: 0.16755152892787217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138865783587625d, y: 0.27883222260514606d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25950006690453786d, y: 0.8954809309431879d), new NpgsqlTypes.NpgsqlPoint(x: 0.11186229782762691d, y: 0.5217149500744231d), new NpgsqlTypes.NpgsqlPoint(x: 0.48237249745955724d, y: 0.448080374181001d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07992900523109558d, y: 0.7131292860677707d), new NpgsqlTypes.NpgsqlPoint(x: 0.20417635452742988d, y: 0.12826600807013355d), new NpgsqlTypes.NpgsqlPoint(x: 0.38026727904274993d, y: 0.8320520478710983d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9975189131954386d, y: 0.19070394980827488d), new NpgsqlTypes.NpgsqlPoint(x: 0.42705812013387323d, y: 0.24488629944061568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7541388375408872d, y: 0.3336699502246562d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4389192792931761d, y: 0.804900632066104d), new NpgsqlTypes.NpgsqlPoint(x: 0.40409903524774116d, y: 0.67138868422918d), new NpgsqlTypes.NpgsqlPoint(x: 0.9170982343101021d, y: 0.791157843591745d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39308091924652244d, y: 0.13902615494725212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036814185596263d, y: 0.7099430148243083d), new NpgsqlTypes.NpgsqlPoint(x: 0.22808647261727288d, y: 0.03550975402332135d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08666966481371341d, y: 0.5622186023862871d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973572361660178d, y: 0.12280302135163357d), new NpgsqlTypes.NpgsqlPoint(x: 0.4851595634084195d, y: 0.7970332507092973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8476383212812895d, y: 0.47039028746661504d), new NpgsqlTypes.NpgsqlPoint(x: 0.1371799931711064d, y: 0.6026044126856341d), new NpgsqlTypes.NpgsqlPoint(x: 0.6610381745741062d, y: 0.9786711963351565d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4686261932024621d, y: 0.7414983299702111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8186690092894835d, y: 0.6673218370879437d), new NpgsqlTypes.NpgsqlPoint(x: 0.702094249043007d, y: 0.6343538210031993d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778430695925194d, y: 0.8195829026720094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4028780061585452d, y: 0.4998515454146343d), new NpgsqlTypes.NpgsqlPoint(x: 0.012518125598289909d, y: 0.5695319039415294d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45252691527939515d, y: 0.9946244174580807d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637822798243407d, y: 0.6532488756285899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848710823432105d, y: 0.9030147288198296d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20250718056960926d, y: 0.11481408157414141d), new NpgsqlTypes.NpgsqlPoint(x: 0.858191141126771d, y: 0.3016084052705922d), new NpgsqlTypes.NpgsqlPoint(x: 0.043042331023437685d, y: 0.9845583055922158d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14449901247989783d, y: 0.31890744888914857d), new NpgsqlTypes.NpgsqlPoint(x: 0.7154328725393877d, y: 0.5025362277483711d), new NpgsqlTypes.NpgsqlPoint(x: 0.26441083150079403d, y: 0.9502745691398797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.960440974566858d, y: 0.9404015364656989d), new NpgsqlTypes.NpgsqlPoint(x: 0.36636295939780483d, y: 0.24157713878317144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6692722349965107d, y: 0.9320396110874062d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7403530842578099d, y: 0.00680895843052276d), new NpgsqlTypes.NpgsqlPoint(x: 0.3950185154501745d, y: 0.47541258593734004d), new NpgsqlTypes.NpgsqlPoint(x: 0.19467603752845453d, y: 0.6203615670685465d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6577988283010091d, y: 0.7148101923022732d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115964292474661d, y: 0.7541144554777802d), new NpgsqlTypes.NpgsqlPoint(x: 0.41076165029540423d, y: 0.5405575419471708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011069277243736297d, y: 0.4981117971079648d), new NpgsqlTypes.NpgsqlPoint(x: 0.22307948720334214d, y: 0.06463942829310543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5093421774316624d, y: 0.262835679330483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9850713637967061d, y: 0.9683368706855484d), new NpgsqlTypes.NpgsqlPoint(x: 0.8596820424966967d, y: 0.10377488860018724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243238618698158d, y: 0.9949068009165125d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029909876337474328d, y: 0.04039388876133598d), new NpgsqlTypes.NpgsqlPoint(x: 0.10298122641013185d, y: 0.8165365475174466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345169537538695d, y: 0.32636043957577443d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24121360696918814d, y: 0.4850732135640393d), new NpgsqlTypes.NpgsqlPoint(x: 0.16229638051466044d, y: 0.9357791582375403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767091526217478d, y: 0.03920392916941695d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6170853145277481d, y: 0.27786854072982836d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793019654967602d, y: 0.2911319322961595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732598371701816d, y: 0.2946429167854048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.319222320615244d, y: 0.665057478064997d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129418465592298d, y: 0.2353008224661608d), new NpgsqlTypes.NpgsqlPoint(x: 0.08004482988265038d, y: 0.8369931283025048d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1736218694168814d, y: 0.36515973576722627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537940805553763d, y: 0.859526622940277d), new NpgsqlTypes.NpgsqlPoint(x: 0.46676213003611944d, y: 0.5806108610921351d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4474100187211103d, y: 0.1564087774405194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557616149347419d, y: 0.9524404232375752d), new NpgsqlTypes.NpgsqlPoint(x: 0.2500572760699158d, y: 0.020310143764630473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017492402537462648d, y: 0.30940905999582236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7971648204075086d, y: 0.5100651532905442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3459854601140222d, y: 0.6792329859229197d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4975705887492722d, y: 0.28250571241682565d), new NpgsqlTypes.NpgsqlPoint(x: 0.35395924267262713d, y: 0.7926419807085229d), new NpgsqlTypes.NpgsqlPoint(x: 0.0974181102436742d, y: 0.7616984929889452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7704046130083376d, y: 0.619008831944976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9585343408815566d, y: 0.6452138557519854d), new NpgsqlTypes.NpgsqlPoint(x: 0.25066130032987044d, y: 0.6306192607442324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.144191309579083d, y: 0.7601187988295224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107547152019788d, y: 0.3452360187520348d), new NpgsqlTypes.NpgsqlPoint(x: 0.7673110279355427d, y: 0.8556323792154638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9389387138469905d, y: 0.9313812055125603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691761153267691d, y: 0.6688791792473043d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528637274890436d, y: 0.9382171847252843d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46252518019565747d, y: 0.8317626562412307d), new NpgsqlTypes.NpgsqlPoint(x: 0.6688900420119633d, y: 0.047411044158924165d), new NpgsqlTypes.NpgsqlPoint(x: 0.03421431862213031d, y: 0.986892035420637d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.987965930185767d, y: 0.2611130553247195d), new NpgsqlTypes.NpgsqlPoint(x: 0.18478781344897555d, y: 0.3854920092534414d), new NpgsqlTypes.NpgsqlPoint(x: 0.3051132091686133d, y: 0.6056556800362746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9223300303664036d, y: 0.623103388737627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390729720518977d, y: 0.3690412627511971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316260340028998d, y: 0.07716911179958785d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7029881764059713d, y: 0.26292849536948315d), new NpgsqlTypes.NpgsqlPoint(x: 0.21832511098800933d, y: 0.4930017114748545d), new NpgsqlTypes.NpgsqlPoint(x: 0.30701317123612204d, y: 0.3404926936720015d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3158152636053815d, y: 0.06331456698970706d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547868858137539d, y: 0.11120590551652398d), new NpgsqlTypes.NpgsqlPoint(x: 0.7323752335001147d, y: 0.08023846923045419d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6931985136272623d, y: 0.9134552362056306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8763799627682353d, y: 0.661818249221569d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694210547786578d, y: 0.5186659134533442d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.773790829609865d, y: 0.9222257149593608d), new NpgsqlTypes.NpgsqlPoint(x: 0.18003452977443013d, y: 0.19397000885652538d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096969420993927d, y: 0.7661269801464728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6718580466090607d, y: 0.5676026960774931d), new NpgsqlTypes.NpgsqlPoint(x: 0.09143426663492704d, y: 0.581188118409331d), new NpgsqlTypes.NpgsqlPoint(x: 0.2693310992726031d, y: 0.11955535321803923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9389206651835456d, y: 0.2452387924624463d), new NpgsqlTypes.NpgsqlPoint(x: 0.32205502565401634d, y: 0.3978113568878937d), new NpgsqlTypes.NpgsqlPoint(x: 0.12005345628753394d, y: 0.17669190928160283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20334241537729902d, y: 0.6339209485930462d), new NpgsqlTypes.NpgsqlPoint(x: 0.4980445609015449d, y: 0.35473299621733523d), new NpgsqlTypes.NpgsqlPoint(x: 0.002275019938971057d, y: 0.3476681549965155d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29811755371228155d, y: 0.17027453174506868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842835638213728d, y: 0.17749685613181654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367884945697348d, y: 0.6096033256841619d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9316435393221388d, y: 0.14028023268649814d), new NpgsqlTypes.NpgsqlPoint(x: 0.44408378628252554d, y: 0.8673662454840559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4503793879874767d, y: 0.8066828515610134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.53353141050837d, y: 0.08851614555185139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473168571744566d, y: 0.3765368763268574d), new NpgsqlTypes.NpgsqlPoint(x: 0.11786752794146493d, y: 0.8034882373899127d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2722809837963609d, y: 0.7012475037069185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5881744755140742d, y: 0.3135514226612002d), new NpgsqlTypes.NpgsqlPoint(x: 0.1794454320290637d, y: 0.933550763193485d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19270248382387978d, y: 0.7672258167341918d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424646589625388d, y: 0.34957982562799117d), new NpgsqlTypes.NpgsqlPoint(x: 0.030660073500418883d, y: 0.3026754776527155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5829224815531444d, y: 0.5489099795501623d), new NpgsqlTypes.NpgsqlPoint(x: 0.4415019485159709d, y: 0.6885870083849664d), new NpgsqlTypes.NpgsqlPoint(x: 0.14092352766963157d, y: 0.0438367757672703d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3753292451437418d, y: 0.213107629840387d), new NpgsqlTypes.NpgsqlPoint(x: 0.9945534437393522d, y: 0.14401115335773707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9448062273740024d, y: 0.6676353679349925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4890534947013615d, y: 0.28408156042547783d), new NpgsqlTypes.NpgsqlPoint(x: 0.30845425750663713d, y: 0.34298925124543034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459756592184995d, y: 0.42806301050898676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.227481322905157d, y: 0.7588475915323113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196052174873488d, y: 0.6364505447461497d), new NpgsqlTypes.NpgsqlPoint(x: 0.4087695960725727d, y: 0.27224634546103366d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9632808155743414d, y: 0.4969501780952412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085210739385691d, y: 0.9285305947073254d), new NpgsqlTypes.NpgsqlPoint(x: 0.632987436531164d, y: 0.5265743564358336d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08392137923442133d, y: 0.8314017013476892d), new NpgsqlTypes.NpgsqlPoint(x: 0.041452010719019716d, y: 0.15847834411293038d), new NpgsqlTypes.NpgsqlPoint(x: 0.574052348259415d, y: 0.6752250729680747d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8753986276555368d, y: 0.12034854737346756d), new NpgsqlTypes.NpgsqlPoint(x: 0.002330795459345003d, y: 0.6803314324430976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183754592652817d, y: 0.9695984268532588d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6744465103255286d, y: 0.09688195701440894d), new NpgsqlTypes.NpgsqlPoint(x: 0.820646473817801d, y: 0.7049377253002423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5968071716794358d, y: 0.696659439369487d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3979553652754404d, y: 0.8293669447050225d), new NpgsqlTypes.NpgsqlPoint(x: 0.27505507237079396d, y: 0.6820764572377735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9065326060812424d, y: 0.7447479046660238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20517261904641948d, y: 0.16883978574169412d), new NpgsqlTypes.NpgsqlPoint(x: 0.8012186194014359d, y: 0.9563297740153289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569798650202721d, y: 0.439722685607586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9365442717188358d, y: 0.15275301820315734d), new NpgsqlTypes.NpgsqlPoint(x: 0.12082428712525639d, y: 0.6205665429524448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485594797064637d, y: 0.5744426879788183d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5476189504593225d, y: 0.3172240842499635d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023148272096685796d, y: 0.7925659252651294d), new NpgsqlTypes.NpgsqlPoint(x: 0.11853257725703403d, y: 0.630923931755147d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7452158365109369d, y: 0.3876854973196979d), new NpgsqlTypes.NpgsqlPoint(x: 0.2275544648858332d, y: 0.21971576313289742d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216630757389292d, y: 0.4565858377728319d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05287819911663294d, y: 0.63130577871648d), new NpgsqlTypes.NpgsqlPoint(x: 0.39759350636608326d, y: 0.6767304677383921d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420518494996935d, y: 0.9832469771418553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46223950395932145d, y: 0.9048136256625638d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842476880787452d, y: 0.49186602779997657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7718447890364863d, y: 0.29884024879560944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4573129607354286d, y: 0.03509419193634622d), new NpgsqlTypes.NpgsqlPoint(x: 0.751490440076688d, y: 0.7860172352545417d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121758521808353d, y: 0.39206041679915316d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20452488256422707d, y: 0.2999730084614003d), new NpgsqlTypes.NpgsqlPoint(x: 0.25183007128545853d, y: 0.5912620779482785d), new NpgsqlTypes.NpgsqlPoint(x: 0.04369985851197922d, y: 0.36843801110853747d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8553450388453624d, y: 0.9032878772932108d), new NpgsqlTypes.NpgsqlPoint(x: 0.19314229771746494d, y: 0.09750438987336019d), new NpgsqlTypes.NpgsqlPoint(x: 0.15682779923225043d, y: 0.150716184581691d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6155465378917439d, y: 0.7554269324934938d), new NpgsqlTypes.NpgsqlPoint(x: 0.4711538729765835d, y: 0.5481487175880188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9136040212104469d, y: 0.7659116668387034d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.339087621215579d, y: 0.5017660908961482d), new NpgsqlTypes.NpgsqlPoint(x: 0.10820012986278038d, y: 0.05543829608130302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9435579889340656d, y: 0.8967019289875775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12903165664799743d, y: 0.8427673350455155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403245699630532d, y: 0.8874201199007451d), new NpgsqlTypes.NpgsqlPoint(x: 0.6516959833090105d, y: 0.8659161738621468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21405790611183229d, y: 0.4791873830478981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6033607790556681d, y: 0.12449151243501788d), new NpgsqlTypes.NpgsqlPoint(x: 0.6909024678022933d, y: 0.8401219618884369d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5006497781435257d, y: 0.816270057280231d), new NpgsqlTypes.NpgsqlPoint(x: 0.7665816851211863d, y: 0.4842979723118511d), new NpgsqlTypes.NpgsqlPoint(x: 0.4162310673974672d, y: 0.38960856993326654d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47500347648544905d, y: 0.12499517910365632d), new NpgsqlTypes.NpgsqlPoint(x: 0.1847548011754725d, y: 0.3800046083206601d), new NpgsqlTypes.NpgsqlPoint(x: 0.928259672627054d, y: 0.009190106869037096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7390908620803778d, y: 0.4434226015415714d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863913630381155d, y: 0.4703249454150933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7929471013095087d, y: 0.30357451244487477d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3618446303240219d, y: 0.5534704813127646d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544729365352181d, y: 0.4217451873197099d), new NpgsqlTypes.NpgsqlPoint(x: 0.013531045052869617d, y: 0.9371973085455939d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.961897398387703d, y: 0.4668141189606123d), new NpgsqlTypes.NpgsqlPoint(x: 0.794754738919361d, y: 0.2765210298972154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5059983465062311d, y: 0.8631060053843267d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5796701633410241d, y: 0.3064146377960487d), new NpgsqlTypes.NpgsqlPoint(x: 0.20849025742845895d, y: 0.5703074440460346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991115286023181d, y: 0.9244616341316455d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0783346627971474d, y: 0.2818727615917873d), new NpgsqlTypes.NpgsqlPoint(x: 0.036210513536184985d, y: 0.5148222480679212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993640713627785d, y: 0.8461140110960728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038851195282056605d, y: 0.936542244742554d), new NpgsqlTypes.NpgsqlPoint(x: 0.3669591741367878d, y: 0.29625358386013345d), new NpgsqlTypes.NpgsqlPoint(x: 0.07232855912504055d, y: 0.8841381329655776d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6872569282407727d, y: 0.05155417356049519d), new NpgsqlTypes.NpgsqlPoint(x: 0.2942540575263882d, y: 0.38295122641502033d), new NpgsqlTypes.NpgsqlPoint(x: 0.13530091897369012d, y: 0.5478328816619911d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5063878477238125d, y: 0.8671083023341397d), new NpgsqlTypes.NpgsqlPoint(x: 0.913974857618438d, y: 0.7646906366111863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5883028245534271d, y: 0.723841403502665d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37444682601026646d, y: 0.7885272391741529d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447583404894658d, y: 0.7407577469857018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117260831019768d, y: 0.4269671608168265d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6065007184020003d, y: 0.8956664327424427d), new NpgsqlTypes.NpgsqlPoint(x: 0.47104183198278815d, y: 0.649117696490944d), new NpgsqlTypes.NpgsqlPoint(x: 0.44409403071208786d, y: 0.6152990856747127d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5274236163274981d, y: 0.6687064603438907d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196480829351553d, y: 0.9240988921037069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371826185797842d, y: 0.09492396573777273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2815867799222127d, y: 0.5726162700706822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203927080904484d, y: 0.36430805546656597d), new NpgsqlTypes.NpgsqlPoint(x: 0.36905471522599365d, y: 0.602443530053087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6025479978476692d, y: 0.6168519591251399d), new NpgsqlTypes.NpgsqlPoint(x: 0.49906512480421794d, y: 0.5654816674104628d), new NpgsqlTypes.NpgsqlPoint(x: 0.830021099129918d, y: 0.16425175567892003d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1943720379486782d, y: 0.8416660950122622d), new NpgsqlTypes.NpgsqlPoint(x: 0.39851923315066295d, y: 0.3738695359721774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236145894214722d, y: 0.9840764438706371d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43393139260484814d, y: 0.13505527996250122d), new NpgsqlTypes.NpgsqlPoint(x: 0.06364168219422195d, y: 0.6626068166597059d), new NpgsqlTypes.NpgsqlPoint(x: 0.12813958024548677d, y: 0.8568368788622687d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6377829221603586d, y: 0.4479152430782867d), new NpgsqlTypes.NpgsqlPoint(x: 0.46353244439611063d, y: 0.6522342503663092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6406893903476558d, y: 0.8632179729321348d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15437132569919998d, y: 0.7653349647197923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971397620867362d, y: 0.9383924087855753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9312061871871856d, y: 0.1634423034287873d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18943444603489867d, y: 0.2696577485567896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774559409759765d, y: 0.49204344796414223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653213709887509d, y: 0.9287207259604405d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7590849570423105d, y: 0.39757831216562645d), new NpgsqlTypes.NpgsqlPoint(x: 0.20193613000215838d, y: 0.6910963618241229d), new NpgsqlTypes.NpgsqlPoint(x: 0.14015651634404014d, y: 0.06474925469384907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.571334027913417d, y: 0.5318893150024302d), new NpgsqlTypes.NpgsqlPoint(x: 0.027010424176570957d, y: 0.06526048623949254d), new NpgsqlTypes.NpgsqlPoint(x: 0.024556340907539664d, y: 0.9811679552074851d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5977693459221403d, y: 0.6539606609941324d), new NpgsqlTypes.NpgsqlPoint(x: 0.12056213716538322d, y: 0.983684467419476d), new NpgsqlTypes.NpgsqlPoint(x: 0.33524239722252014d, y: 0.6304087965315045d)),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9468095171377962d, y: 0.4937989914029154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130308290959262d, y: 0.09962974613464037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664251968669815d, y: 0.5975223714732807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3013127253772512d, y: 0.9008043664745702d), new NpgsqlTypes.NpgsqlPoint(x: 0.030343364070647194d, y: 0.9039437606951584d), new NpgsqlTypes.NpgsqlPoint(x: 0.25854453996109705d, y: 0.9195734818153812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.527996835352804d, y: 0.9810409844925347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7346171452774031d, y: 0.17938485303226404d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986437823252669d, y: 0.7047745446761935d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5735968548347754d, y: 0.971967830912708d), new NpgsqlTypes.NpgsqlPoint(x: 0.14060865706687464d, y: 0.8176885194281255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095909221583529d, y: 0.9997236546277853d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43435340518402954d, y: 0.9274487739956578d), new NpgsqlTypes.NpgsqlPoint(x: 0.15381460245695466d, y: 0.5591310897767425d), new NpgsqlTypes.NpgsqlPoint(x: 0.896536291152931d, y: 0.35032886891353787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15768427570838572d, y: 0.38681697509239266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3497797419293738d, y: 0.12885572831847392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5225368390367016d, y: 0.4513823918028257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6450224343888219d, y: 0.21188501803092286d), new NpgsqlTypes.NpgsqlPoint(x: 0.45379299807297346d, y: 0.06292578142386307d), new NpgsqlTypes.NpgsqlPoint(x: 0.14919300108135802d, y: 0.7884985295579628d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12485059090295914d, y: 0.3638372655782367d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875494098761753d, y: 0.37478721099567924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022398919749203d, y: 0.08552113021985142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.912452269784826d, y: 0.29775772234216524d), new NpgsqlTypes.NpgsqlPoint(x: 0.016651167028992386d, y: 0.7584086986164372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520663858753917d, y: 0.9222557298004728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45882140109787495d, y: 0.46715132213160393d), new NpgsqlTypes.NpgsqlPoint(x: 0.3524626191301249d, y: 0.26756575839328633d), new NpgsqlTypes.NpgsqlPoint(x: 0.27145203188979516d, y: 0.48975002577498883d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08928939078286147d, y: 0.3635443340604516d), new NpgsqlTypes.NpgsqlPoint(x: 0.018599904437596848d, y: 0.9286765698479734d), new NpgsqlTypes.NpgsqlPoint(x: 0.833198326753833d, y: 0.6116854434691374d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7319586752701974d, y: 0.5485718115580521d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718904856928827d, y: 0.5126423796521576d), new NpgsqlTypes.NpgsqlPoint(x: 0.15570917494258263d, y: 0.16132914456322434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8551518683900028d, y: 0.2601538522282174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923431355438604d, y: 0.1219142627409252d), new NpgsqlTypes.NpgsqlPoint(x: 0.891273334945506d, y: 0.8602839195175602d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 86, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatchAsync(connection, 122, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatch(connection, 9, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

