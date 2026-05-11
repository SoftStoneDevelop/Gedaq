

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
    internal partial interface INpgsqlPointMArraypointMMArrayD3
    {
    }
    
    internal partial class NpgsqlPointMArraypointMMArrayD3 : INpgsqlPointMArraypointMMArrayD3
    {


#region TestData

        private readonly NpgsqlPointpointMMArrayD3E1M[] _testData = new NpgsqlPointpointMMArrayD3E1M[]
        {
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.8185467766076798d, y: 0.48894438477438584d), new NpgsqlTypes.NpgsqlPoint(x: 0.19761787269169018d, y: 0.9532983267741479d), new NpgsqlTypes.NpgsqlPoint(x: 0.5983729215772035d, y: 0.05592109349318952d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.37535313496187783d, y: 0.6111138451386555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4907883203228123d, y: 0.9966430092906607d), new NpgsqlTypes.NpgsqlPoint(x: 0.32262572493255226d, y: 0.3001120423796986d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9672495593098777d, y: 0.7253689262213034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6343854982782975d, y: 0.06694388733623302d), new NpgsqlTypes.NpgsqlPoint(x: 0.49437481979065945d, y: 0.16660822920616392d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.34831757889888126d, y: 0.016304809578837287d), new NpgsqlTypes.NpgsqlPoint(x: 0.526267415549939d, y: 0.18409051755767825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9160267520344315d, y: 0.7965274684153355d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8002877335275927d, y: 0.5729736356983443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9314504112147403d, y: 0.32253058519678146d), new NpgsqlTypes.NpgsqlPoint(x: 0.22826133271201332d, y: 0.04418547234595882d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.679543342371555d, y: 0.5009270453231655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358904440439715d, y: 0.3498603163144124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7041609246663165d, y: 0.746556052013349d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7721485110858417d, y: 0.669844109557308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155345759345639d, y: 0.47227503100381507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9578780235977336d, y: 0.5876274236590222d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4130663715140481d, y: 0.04965968777502561d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015299517430512d, y: 0.10810951206520358d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761932866514271d, y: 0.47613780481741574d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45139736491648197d, y: 0.7831298497806771d), new NpgsqlTypes.NpgsqlPoint(x: 0.16178651894358287d, y: 0.8331786374186446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414573564055381d, y: 0.009467641073576116d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.890892683023832d, y: 0.5375714015245919d), new NpgsqlTypes.NpgsqlPoint(x: 0.2627002638953173d, y: 0.8180100657973436d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144500443969506d, y: 0.7836268797293416d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7705132558716903d, y: 0.6629406912331456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5637979438281906d, y: 0.9100877335317866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5584999991442682d, y: 0.028411520990193506d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9678178094358949d, y: 0.21121143707691203d), new NpgsqlTypes.NpgsqlPoint(x: 0.6191300676472995d, y: 0.11993988503980058d), new NpgsqlTypes.NpgsqlPoint(x: 0.031824097216163416d, y: 0.6018796671067876d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5375969851674351d, y: 0.289413761394148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6408320158232146d, y: 0.1887626739563525d), new NpgsqlTypes.NpgsqlPoint(x: 0.4622541213845909d, y: 0.9002924054397631d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9797436762128834d, y: 0.35278968269371314d), new NpgsqlTypes.NpgsqlPoint(x: 0.33971961790261085d, y: 0.10273079486696002d), new NpgsqlTypes.NpgsqlPoint(x: 0.03344071668408688d, y: 0.6160500092558447d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3892978379013896d, y: 0.8672712489876844d), new NpgsqlTypes.NpgsqlPoint(x: 0.49444820184147786d, y: 0.8478677045597279d), new NpgsqlTypes.NpgsqlPoint(x: 0.6209068684188734d, y: 0.011966879221666282d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9532858202434272d, y: 0.8047464059626552d), new NpgsqlTypes.NpgsqlPoint(x: 0.04931551021416325d, y: 0.9483001801530024d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465063511498919d, y: 0.31057453732713414d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.49619353778448927d, y: 0.6409540535001086d), new NpgsqlTypes.NpgsqlPoint(x: 0.762083466620792d, y: 0.4648395077877684d), new NpgsqlTypes.NpgsqlPoint(x: 0.05367220560298003d, y: 0.1428790727736905d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8042856907772785d, y: 0.45930506596526377d), new NpgsqlTypes.NpgsqlPoint(x: 0.0826443410866059d, y: 0.1413442308755153d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321628732921187d, y: 0.07125829744400425d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7076654232893108d, y: 0.6904309719753328d), new NpgsqlTypes.NpgsqlPoint(x: 0.6292929850451604d, y: 0.3177505090321314d), new NpgsqlTypes.NpgsqlPoint(x: 0.15218135552526968d, y: 0.20285990488230332d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3090663812262042d, y: 0.29802902200843484d), new NpgsqlTypes.NpgsqlPoint(x: 0.3470584258134327d, y: 0.8276588812817932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592516108974893d, y: 0.3887756680832074d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6010832573917064d, y: 0.7457369058188446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853982105995947d, y: 0.30748563530667716d), new NpgsqlTypes.NpgsqlPoint(x: 0.40509747251140515d, y: 0.06997383331562401d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8379048542854813d, y: 0.014048992741088395d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008851938600194d, y: 0.6184697657296776d), new NpgsqlTypes.NpgsqlPoint(x: 0.36517767817724556d, y: 0.3147459652960366d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8649287563882827d, y: 0.49464700761250213d), new NpgsqlTypes.NpgsqlPoint(x: 0.013388726347196789d, y: 0.7070553405106228d), new NpgsqlTypes.NpgsqlPoint(x: 0.2493780232307482d, y: 0.930170947195131d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9460283736136473d, y: 0.2914700754801627d), new NpgsqlTypes.NpgsqlPoint(x: 0.466065678928971d, y: 0.14299606294362577d), new NpgsqlTypes.NpgsqlPoint(x: 0.028672863820727645d, y: 0.5758635416539536d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7156145187804885d, y: 0.29259355256440045d), new NpgsqlTypes.NpgsqlPoint(x: 0.08172401164664977d, y: 0.04254444819042247d), new NpgsqlTypes.NpgsqlPoint(x: 0.06131387174247027d, y: 0.5420261922430311d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.49454957717191006d, y: 0.8070274164236946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138777274444962d, y: 0.40384244676383374d), new NpgsqlTypes.NpgsqlPoint(x: 0.269087630470341d, y: 0.5102901786343795d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.61207470746008d, y: 0.983993446048907d), new NpgsqlTypes.NpgsqlPoint(x: 0.021429914795071725d, y: 0.3611627659625065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8771748803380516d, y: 0.3582323744689654d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9317343371261148d, y: 0.8769135508235454d), new NpgsqlTypes.NpgsqlPoint(x: 0.951243466590458d, y: 0.8738310339831812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993833221487386d, y: 0.3630301894282677d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.09342420812153995d, y: 0.2880280030537351d), new NpgsqlTypes.NpgsqlPoint(x: 0.35071956887113587d, y: 0.14655454639377108d), new NpgsqlTypes.NpgsqlPoint(x: 0.45624222531965974d, y: 0.34671471018500655d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.628645764892476d, y: 0.7329823835938694d), new NpgsqlTypes.NpgsqlPoint(x: 0.20130507052701785d, y: 0.8805707391023957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6839390144481443d, y: 0.43931728071347353d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.42161934581758553d, y: 0.6916335473372746d), new NpgsqlTypes.NpgsqlPoint(x: 0.678285929130481d, y: 0.5054766256215202d), new NpgsqlTypes.NpgsqlPoint(x: 0.3213427397183415d, y: 0.1253765055956626d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6587342760648124d, y: 0.33367632181735307d), new NpgsqlTypes.NpgsqlPoint(x: 0.21658476069494637d, y: 0.45587537548605006d), new NpgsqlTypes.NpgsqlPoint(x: 0.011234072733401712d, y: 0.21582234831946767d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.835017763958269d, y: 0.8667195239359876d), new NpgsqlTypes.NpgsqlPoint(x: 0.927002181497633d, y: 0.9094844577810227d), new NpgsqlTypes.NpgsqlPoint(x: 0.41633934612934953d, y: 0.572433331581281d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.36673527280200835d, y: 0.29188104819120675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567939722630228d, y: 0.8225029671159134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7310584350763064d, y: 0.6966119052238103d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.20979446880824826d, y: 0.10915298408697383d), new NpgsqlTypes.NpgsqlPoint(x: 0.019090020405018282d, y: 0.6722460331425874d), new NpgsqlTypes.NpgsqlPoint(x: 0.09358128058984894d, y: 0.5326032347889269d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.13280495936101633d, y: 0.12913377614226296d), new NpgsqlTypes.NpgsqlPoint(x: 0.13422060828027849d, y: 0.8866062004024757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1510470123111598d, y: 0.9279036136200409d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.03788701997294874d, y: 0.6360855926156818d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901754708249891d, y: 0.20025898904993789d), new NpgsqlTypes.NpgsqlPoint(x: 0.35806291739914786d, y: 0.82915907526709d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4313440947123429d, y: 0.32512730526008304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747563887133605d, y: 0.6266681867163248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4823021813824794d, y: 0.5621402864224173d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.44146978958151484d, y: 0.550956805164928d), new NpgsqlTypes.NpgsqlPoint(x: 0.0107007673534123d, y: 0.8185377314997258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913810458240314d, y: 0.5604711149679937d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.593245122450983d, y: 0.7346893618721104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3682600646339881d, y: 0.964520385864985d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958746697738962d, y: 0.6213149375633318d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6859189962968274d, y: 0.16714137512822624d), new NpgsqlTypes.NpgsqlPoint(x: 0.15900811658254488d, y: 0.3843099225457235d), new NpgsqlTypes.NpgsqlPoint(x: 0.39332252932301803d, y: 0.5483888256935491d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5617192387866529d, y: 0.4681895572672886d), new NpgsqlTypes.NpgsqlPoint(x: 0.3127112558769901d, y: 0.8054346831168936d), new NpgsqlTypes.NpgsqlPoint(x: 0.19436897583029344d, y: 0.8618657863369835d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7289585142964633d, y: 0.6285341610989312d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511983617859573d, y: 0.8548700443601047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545580031698434d, y: 0.3059353793642474d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9165847445287466d, y: 0.7900996517692129d), new NpgsqlTypes.NpgsqlPoint(x: 0.46978268011420077d, y: 0.04767076480858512d), new NpgsqlTypes.NpgsqlPoint(x: 0.0075183556522108175d, y: 0.1687079679710325d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7748835789457947d, y: 0.26902763207240443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8656464300005846d, y: 0.6019712785823585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076289742262456d, y: 0.3080878298795434d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.836456128720644d, y: 0.021787795611085015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229707838622798d, y: 0.6255246249377169d), new NpgsqlTypes.NpgsqlPoint(x: 0.2893877435624823d, y: 0.21646341972535466d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2089491008258456d, y: 0.02416780296806209d), new NpgsqlTypes.NpgsqlPoint(x: 0.29048069527355125d, y: 0.14014164259152528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662203663066324d, y: 0.3327628339565213d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8188886231341397d, y: 0.07833442236696031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434478169838566d, y: 0.39097502601335854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038738703033659d, y: 0.8744224499894978d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5193839826206905d, y: 0.8227413741524955d), new NpgsqlTypes.NpgsqlPoint(x: 0.47615063248866274d, y: 0.6687058833909616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3994829129456682d, y: 0.47661342870438295d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8226106631935434d, y: 0.6963874990619067d), new NpgsqlTypes.NpgsqlPoint(x: 0.4982245618179809d, y: 0.2699302808589539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6138898228317046d, y: 0.6495350690603413d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7471833291117482d, y: 0.9645722134898823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449233814461019d, y: 0.04823235155199446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209266944171521d, y: 0.7341105099887958d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6557642072261837d, y: 0.5591827862630406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3803882035908931d, y: 0.8486137861516434d), new NpgsqlTypes.NpgsqlPoint(x: 0.604517222618861d, y: 0.6967153168393558d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10864926333223457d, y: 0.5281706811939862d), new NpgsqlTypes.NpgsqlPoint(x: 0.48582075918990686d, y: 0.43863161086589963d), new NpgsqlTypes.NpgsqlPoint(x: 0.4624696805630083d, y: 0.04919427054813985d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6686864634645252d, y: 0.2543892237197054d), new NpgsqlTypes.NpgsqlPoint(x: 0.19353256253395623d, y: 0.9342045128478424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7494501087708801d, y: 0.6687138387028547d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.04550159042182056d, y: 0.7939231920516506d), new NpgsqlTypes.NpgsqlPoint(x: 0.054368169170337044d, y: 0.9851721112866956d), new NpgsqlTypes.NpgsqlPoint(x: 0.46589790355699334d, y: 0.36673344600699864d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.006071664385381981d, y: 0.6797262850296393d), new NpgsqlTypes.NpgsqlPoint(x: 0.813775206372015d, y: 0.6354428394790882d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288175876028759d, y: 0.7830017142389551d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.41535163959310883d, y: 0.7449143560235791d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884160341048167d, y: 0.22625592613374945d), new NpgsqlTypes.NpgsqlPoint(x: 0.32689386567420853d, y: 0.6779967896722707d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8137473043896553d, y: 0.5284653636817535d), new NpgsqlTypes.NpgsqlPoint(x: 0.19604400318963833d, y: 0.30806086317651427d), new NpgsqlTypes.NpgsqlPoint(x: 0.012953594929348444d, y: 0.43574692844437357d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1866112837137921d, y: 0.8537981640811082d), new NpgsqlTypes.NpgsqlPoint(x: 0.789444645694639d, y: 0.631385603956612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574258969229901d, y: 0.9133313746763606d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8807165853696491d, y: 0.4409718223273965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269306672589984d, y: 0.5977668496104778d), new NpgsqlTypes.NpgsqlPoint(x: 0.05292431788668972d, y: 0.8396532378063979d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7462923255217259d, y: 0.7390054788569329d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935970042401287d, y: 0.13802333850236503d), new NpgsqlTypes.NpgsqlPoint(x: 0.30830443884728764d, y: 0.7635047191151503d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5502571017836713d, y: 0.7136506660975412d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769563127086936d, y: 0.2401264264842773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503446833477429d, y: 0.2862566103480454d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2805889128240626d, y: 0.00444933118190749d), new NpgsqlTypes.NpgsqlPoint(x: 0.27101910255365336d, y: 0.9418033887033954d), new NpgsqlTypes.NpgsqlPoint(x: 0.12049263573843205d, y: 0.5963273830678312d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.2849800154953549d, y: 0.24358919931365963d), new NpgsqlTypes.NpgsqlPoint(x: 0.057802376292541924d, y: 0.8430674375790895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7233460839366228d, y: 0.7147564147863882d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9007509622394414d, y: 0.4904427088939053d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080058252019985d, y: 0.9076117045691848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4429705485708232d, y: 0.47646566884389285d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.005654959173941654d, y: 0.13391285036211198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9069434263480332d, y: 0.32379924952888894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7915406649414598d, y: 0.4254918758981977d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9243329210973155d, y: 0.07101474961767318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5787908154976522d, y: 0.4540748667048742d), new NpgsqlTypes.NpgsqlPoint(x: 0.36199671807528566d, y: 0.1795604822295056d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.39485593274531805d, y: 0.9696641981675096d), new NpgsqlTypes.NpgsqlPoint(x: 0.45692598848175725d, y: 0.7517228672349011d), new NpgsqlTypes.NpgsqlPoint(x: 0.674821653624804d, y: 0.21452376438615062d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.61288364237775d, y: 0.5144277766431283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5890853787994358d, y: 0.34025337912463616d), new NpgsqlTypes.NpgsqlPoint(x: 0.22522624132292912d, y: 0.41777576057456167d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.872179934933669d, y: 0.41903792970727316d), new NpgsqlTypes.NpgsqlPoint(x: 0.26750424056948396d, y: 0.8540323091376422d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952260564320412d, y: 0.34423391506719436d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7003619617616852d, y: 0.44872417688678135d), new NpgsqlTypes.NpgsqlPoint(x: 0.6958397582824237d, y: 0.11058368074647351d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262064746161128d, y: 0.441364204134419d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5922387604910869d, y: 0.3223370835230994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4406434525266172d, y: 0.7151416904183132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243025568231876d, y: 0.1715113886925791d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.858066427084948d, y: 0.7274120370601463d), new NpgsqlTypes.NpgsqlPoint(x: 0.05476977845756459d, y: 0.1921685658486023d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511484497258423d, y: 0.7926697534846376d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3163521836314285d, y: 0.41942655529072714d), new NpgsqlTypes.NpgsqlPoint(x: 0.10434029069980877d, y: 0.09527588444843405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487185795742929d, y: 0.5104134319515402d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7567657407070115d, y: 0.9712872474005873d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739383719638917d, y: 0.5835646357370698d), new NpgsqlTypes.NpgsqlPoint(x: 0.3896440431046183d, y: 0.5725199616639532d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9486840231536233d, y: 0.9693396669136662d), new NpgsqlTypes.NpgsqlPoint(x: 0.11915123662894844d, y: 0.021805437289560414d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168702446086018d, y: 0.3615519127392052d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.25888435865331416d, y: 0.9139535351539548d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775265278861154d, y: 0.6262500570377435d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275158288231832d, y: 0.31811764631264094d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32748397368341675d, y: 0.6179946478167232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2525141273929039d, y: 0.18938865695649765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8838951911932689d, y: 0.8191814532004664d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.2913322403766111d, y: 0.05248468742098167d), new NpgsqlTypes.NpgsqlPoint(x: 0.02244354005173077d, y: 0.8887349786490468d), new NpgsqlTypes.NpgsqlPoint(x: 0.14981403950380168d, y: 0.3327302659148744d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22760742206132623d, y: 0.32225547920389586d), new NpgsqlTypes.NpgsqlPoint(x: 0.13858264048339897d, y: 0.5226235296187938d), new NpgsqlTypes.NpgsqlPoint(x: 0.529584799736867d, y: 0.7706635794681574d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1725710214405869d, y: 0.5054905746368686d), new NpgsqlTypes.NpgsqlPoint(x: 0.9321034237142864d, y: 0.8854536778179788d), new NpgsqlTypes.NpgsqlPoint(x: 0.07231059373825166d, y: 0.6872337817512918d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.14776471450548923d, y: 0.712508435561326d), new NpgsqlTypes.NpgsqlPoint(x: 0.0451655710735227d, y: 0.0853202068383152d), new NpgsqlTypes.NpgsqlPoint(x: 0.7585163453204157d, y: 0.6148572350626865d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8693971165089435d, y: 0.5003782482629883d), new NpgsqlTypes.NpgsqlPoint(x: 0.30672923310685063d, y: 0.3045794874357407d), new NpgsqlTypes.NpgsqlPoint(x: 0.054161678358498166d, y: 0.18008044200900775d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.02138968807646857d, y: 0.7289927171472002d), new NpgsqlTypes.NpgsqlPoint(x: 0.8890220760103414d, y: 0.14998446028626067d), new NpgsqlTypes.NpgsqlPoint(x: 0.918282859206167d, y: 0.17840692009826842d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8883633101411011d, y: 0.7926920826939408d), new NpgsqlTypes.NpgsqlPoint(x: 0.018646677800216782d, y: 0.8076193679449242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6432277953682521d, y: 0.5410077649487216d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.07423918518459482d, y: 0.5709499852362827d), new NpgsqlTypes.NpgsqlPoint(x: 0.1041854482835135d, y: 0.3220020241535825d), new NpgsqlTypes.NpgsqlPoint(x: 0.5752889122686734d, y: 0.9293593918967774d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.18319599341140502d, y: 0.8185481080294021d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097128548523856d, y: 0.2806616601282894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777383328127986d, y: 0.08260265080183038d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.41280310086956074d, y: 0.47353280099899353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744729386241532d, y: 0.9405857550943889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082713283047931d, y: 0.12318591722973637d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7774234478115304d, y: 0.29586133119459d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140012208933819d, y: 0.6530870829207284d), new NpgsqlTypes.NpgsqlPoint(x: 0.21452159602252807d, y: 0.029899017629935964d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7945336481260267d, y: 0.8019616327308058d), new NpgsqlTypes.NpgsqlPoint(x: 0.31100014796621744d, y: 0.04668527746696827d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558192497065255d, y: 0.944728218937989d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.2256659644989053d, y: 0.5610128272718277d), new NpgsqlTypes.NpgsqlPoint(x: 0.40535685944085376d, y: 0.8399107555618196d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458777905390753d, y: 0.7205100576213347d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9794744399967328d, y: 0.8964123994580893d), new NpgsqlTypes.NpgsqlPoint(x: 0.15961880513197124d, y: 0.6153260200474254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9607957092553373d, y: 0.37916355484936604d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4144402501284723d, y: 0.4274732470769126d), new NpgsqlTypes.NpgsqlPoint(x: 0.46889221792781555d, y: 0.4283337547832232d), new NpgsqlTypes.NpgsqlPoint(x: 0.46811228673384586d, y: 0.6439778235278079d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9090397081668743d, y: 0.6516546024605095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826331928982035d, y: 0.0055035695509886295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001106088968881d, y: 0.609318989896616d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.35792739382841954d, y: 0.00529143234414009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564041383299335d, y: 0.7959246065392934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692957497641371d, y: 0.16993833030865513d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6448428487857775d, y: 0.42574324873231906d), new NpgsqlTypes.NpgsqlPoint(x: 0.1553627672708382d, y: 0.4574105465455919d), new NpgsqlTypes.NpgsqlPoint(x: 0.4772258004525821d, y: 0.8376534873199412d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6162227824231362d, y: 0.7891048620843344d), new NpgsqlTypes.NpgsqlPoint(x: 0.20712604752676445d, y: 0.3192399037739253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554543308294018d, y: 0.05303449372245006d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6125048659612684d, y: 0.6885955904240462d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408589503047346d, y: 0.5314471393867111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674368893488086d, y: 0.46865695656249073d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7766340409635114d, y: 0.23070107641925897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856946072008755d, y: 0.5067432599114311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628125676619132d, y: 0.22407364630937932d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.8155550809074658d, y: 0.3280964252013694d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236168852565217d, y: 0.5829999959853505d), new NpgsqlTypes.NpgsqlPoint(x: 0.19585120778448273d, y: 0.22650582282946197d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.584675326427245d, y: 0.5822702890068103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337820444310023d, y: 0.7886221710928454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5448401361663717d, y: 0.7768992039032505d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08602573390307477d, y: 0.5756370986764937d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349154808400831d, y: 0.35022793532416996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795798654284733d, y: 0.8408814425574042d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3552329476366317d, y: 0.3045462091158557d), new NpgsqlTypes.NpgsqlPoint(x: 0.19144939322960086d, y: 0.686738555828d), new NpgsqlTypes.NpgsqlPoint(x: 0.6690721483033957d, y: 0.7844433195870094d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9617351264151337d, y: 0.8568816075809641d), new NpgsqlTypes.NpgsqlPoint(x: 0.479999532931505d, y: 0.4024043433070539d), new NpgsqlTypes.NpgsqlPoint(x: 0.031235780510279754d, y: 0.6520335415029598d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.0622188567701637d, y: 0.696231067069491d), new NpgsqlTypes.NpgsqlPoint(x: 0.11892841019001343d, y: 0.8317477498639896d), new NpgsqlTypes.NpgsqlPoint(x: 0.07207423488399689d, y: 0.10259628374826202d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6691224839566241d, y: 0.9894305498174166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880471226666365d, y: 0.9693548200940092d), new NpgsqlTypes.NpgsqlPoint(x: 0.4026432143752301d, y: 0.05320111433100183d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3173627412797707d, y: 0.02171970916005661d), new NpgsqlTypes.NpgsqlPoint(x: 0.881339705610178d, y: 0.34789156649899267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422130125827737d, y: 0.7616235358765876d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9434870824115618d, y: 0.4069347554086743d), new NpgsqlTypes.NpgsqlPoint(x: 0.37903909146197723d, y: 0.06944057026627459d), new NpgsqlTypes.NpgsqlPoint(x: 0.01780575646536564d, y: 0.9223889118261513d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.4396354060218626d, y: 0.4776134779909289d), new NpgsqlTypes.NpgsqlPoint(x: 0.28542145462986335d, y: 0.769994178639166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7916318080091843d, y: 0.25030673803849735d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.23723901917525647d, y: 0.8339543846452032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5598192881189807d, y: 0.31746481679443694d), new NpgsqlTypes.NpgsqlPoint(x: 0.14369307787282115d, y: 0.24088280512831994d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.06877186448132433d, y: 0.08203020811822104d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947738893122781d, y: 0.6421281007253593d), new NpgsqlTypes.NpgsqlPoint(x: 0.01765455199341015d, y: 0.6029881527310201d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.649902454928261d, y: 0.602364411578866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3121485208914484d, y: 0.5551316154041381d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866337491784054d, y: 0.08051234951768338d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6929903068974822d, y: 0.29624981672205575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486222882962632d, y: 0.2105535385000158d), new NpgsqlTypes.NpgsqlPoint(x: 0.2611957548662752d, y: 0.9349958538569278d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22355708814015163d, y: 0.9142162269426167d), new NpgsqlTypes.NpgsqlPoint(x: 0.29701462976722215d, y: 0.9214386180257943d), new NpgsqlTypes.NpgsqlPoint(x: 0.13808360075704829d, y: 0.5323735488371765d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5787909690144295d, y: 0.9865840950070764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792591217923922d, y: 0.30792511089059427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9580528142899711d, y: 0.2154821317437633d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.20166304946035418d, y: 0.7034211963187146d), new NpgsqlTypes.NpgsqlPoint(x: 0.40867173386533995d, y: 0.45416395461927106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4397855000372213d, y: 0.7268784568498174d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3032830951336779d, y: 0.6189624950802453d), new NpgsqlTypes.NpgsqlPoint(x: 0.2257495124610629d, y: 0.27349259910618307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115925100281602d, y: 0.9899692034960743d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.4240907897343734d, y: 0.020696157834522055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746881249301012d, y: 0.7305695492765717d), new NpgsqlTypes.NpgsqlPoint(x: 0.04429376406687391d, y: 0.565777782145492d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7976345728278744d, y: 0.201818175138462d), new NpgsqlTypes.NpgsqlPoint(x: 0.23283585362635462d, y: 0.2946251485437579d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868754596552137d, y: 0.686129523232809d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.24775112541513067d, y: 0.2413868849507843d), new NpgsqlTypes.NpgsqlPoint(x: 0.10137223912235505d, y: 0.3563134622606474d), new NpgsqlTypes.NpgsqlPoint(x: 0.49622053765711704d, y: 0.2294708996894248d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7538781644538949d, y: 0.5180649949394256d), new NpgsqlTypes.NpgsqlPoint(x: 0.2731095988365376d, y: 0.40244258496424d), new NpgsqlTypes.NpgsqlPoint(x: 0.11243748695643185d, y: 0.9469271538344028d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12524492849498858d, y: 0.09591091708701249d), new NpgsqlTypes.NpgsqlPoint(x: 0.3071024954480447d, y: 0.6161474371241047d), new NpgsqlTypes.NpgsqlPoint(x: 0.08771353731953746d, y: 0.3603736636435684d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.04870813917819283d, y: 0.20785938342305776d), new NpgsqlTypes.NpgsqlPoint(x: 0.18932837142156178d, y: 0.9957383057173694d), new NpgsqlTypes.NpgsqlPoint(x: 0.20082940864114895d, y: 0.8344735665269397d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.16502677420132605d, y: 0.29298876927333506d), new NpgsqlTypes.NpgsqlPoint(x: 0.08426450585912659d, y: 0.26797713913952803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126428761127983d, y: 0.12846009639640799d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8057759403479082d, y: 0.8639825822107868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040483068779597d, y: 0.17098804230124875d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317920465233337d, y: 0.8553827695230835d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.04437722339131489d, y: 0.8034819722530523d), new NpgsqlTypes.NpgsqlPoint(x: 0.0824363968818368d, y: 0.4145744249634391d), new NpgsqlTypes.NpgsqlPoint(x: 0.24045359691547197d, y: 0.27112818679616657d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.024488430191275445d, y: 0.5085315756614425d), new NpgsqlTypes.NpgsqlPoint(x: 0.697498819057367d, y: 0.15187100349433313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3453487187918658d, y: 0.9695058089800613d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.25643414165592016d, y: 0.8840912193464663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3244851985065015d, y: 0.6235523976998231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174029767442382d, y: 0.8202209957152744d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.013885811846383711d, y: 0.6759455310468773d), new NpgsqlTypes.NpgsqlPoint(x: 0.3532772604749137d, y: 0.5666173335703952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3274461132643359d, y: 0.3311657397971428d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.39296787532503896d, y: 0.8321474472374352d), new NpgsqlTypes.NpgsqlPoint(x: 0.061690494590753264d, y: 0.13703062270005784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5125361993832216d, y: 0.3381793965182758d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7255001091182063d, y: 0.39002514569419444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322227250689368d, y: 0.314780026290043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646723308654466d, y: 0.7536470728153444d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8123991687651023d, y: 0.552177726819113d), new NpgsqlTypes.NpgsqlPoint(x: 0.015386528975754987d, y: 0.9957485409353443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147945911455281d, y: 0.24697188989938923d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9546109661421011d, y: 0.22539229270664363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9383199352233538d, y: 0.40053138336065885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978767119281604d, y: 0.6537674562630411d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9575857731710105d, y: 0.8149600386505922d), new NpgsqlTypes.NpgsqlPoint(x: 0.034567427437302456d, y: 0.6556580527592293d), new NpgsqlTypes.NpgsqlPoint(x: 0.05141775324316422d, y: 0.34160232971496785d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10287687953488966d, y: 0.4749945555404629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998289216440151d, y: 0.5474077284139202d), new NpgsqlTypes.NpgsqlPoint(x: 0.39518987203079103d, y: 0.5367958978319451d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.07483486093499159d, y: 0.049589457353259814d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524439725826427d, y: 0.08704517445545079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171967117060632d, y: 0.05256847055011937d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7468582215682916d, y: 0.6274775273689885d), new NpgsqlTypes.NpgsqlPoint(x: 0.519783197699815d, y: 0.37070756251533943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8573598065600614d, y: 0.6431256321927163d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7743734919992759d, y: 0.9866952248807974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6401597690880497d, y: 0.5480181945560393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861545348779764d, y: 0.3829976168026208d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.955068193941448d, y: 0.9465994453131001d), new NpgsqlTypes.NpgsqlPoint(x: 0.33184439577381d, y: 0.8662644442443588d), new NpgsqlTypes.NpgsqlPoint(x: 0.19495153229611584d, y: 0.2098724846488701d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7190370375827153d, y: 0.44391880104812864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097087575825647d, y: 0.4281650563895616d), new NpgsqlTypes.NpgsqlPoint(x: 0.15025335485996183d, y: 0.0065987060585902535d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7272897209742298d, y: 0.5349351230205981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5225622939247229d, y: 0.40376385577599816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8122538955311077d, y: 0.1420430235155441d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.21342033615716816d, y: 0.8515037694880322d), new NpgsqlTypes.NpgsqlPoint(x: 0.14686207510643978d, y: 0.514488008318804d), new NpgsqlTypes.NpgsqlPoint(x: 0.4279494589089068d, y: 0.737649207047301d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.930963837682321d, y: 0.4954123533435212d), new NpgsqlTypes.NpgsqlPoint(x: 0.745240082409336d, y: 0.05328400055313165d), new NpgsqlTypes.NpgsqlPoint(x: 0.2473300700552532d, y: 0.04167101400726614d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08599547782726702d, y: 0.48898562991170047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805273279451687d, y: 0.8856819278261271d), new NpgsqlTypes.NpgsqlPoint(x: 0.10458924409908343d, y: 0.04254309173171944d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.8572961876045604d, y: 0.28378714178179887d), new NpgsqlTypes.NpgsqlPoint(x: 0.17935947982689426d, y: 0.6252864383822632d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058317002339216d, y: 0.06531436810725955d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.05928616452837665d, y: 0.05544408399750378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673109490829287d, y: 0.7716201820967279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295672661607226d, y: 0.4191586362598456d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.39710957390526747d, y: 0.9646407764791426d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254762050893075d, y: 0.5279136327262715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3610616384213168d, y: 0.1892222654473532d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6731012166264907d, y: 0.8469081737475944d), new NpgsqlTypes.NpgsqlPoint(x: 0.21282692778730128d, y: 0.2456362906240125d), new NpgsqlTypes.NpgsqlPoint(x: 0.07200877036108244d, y: 0.7735620639603331d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32003273679488864d, y: 0.42522027794564277d), new NpgsqlTypes.NpgsqlPoint(x: 0.17316287992699453d, y: 0.4927142321893445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711244706073046d, y: 0.18283930846159202d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7792496710861742d, y: 0.6285097692712351d), new NpgsqlTypes.NpgsqlPoint(x: 0.08541733310760502d, y: 0.9955537917582347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747460040701857d, y: 0.5106864177346665d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.4483012089468632d, y: 0.1646822329270181d), new NpgsqlTypes.NpgsqlPoint(x: 0.38020352609700925d, y: 0.6903385398598205d), new NpgsqlTypes.NpgsqlPoint(x: 0.48861156010719486d, y: 0.5814153076450012d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22278353015603525d, y: 0.4286268243591721d), new NpgsqlTypes.NpgsqlPoint(x: 0.0869273532885213d, y: 0.6073624967135965d), new NpgsqlTypes.NpgsqlPoint(x: 0.0625586617986078d, y: 0.8856908772499905d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3570344162532634d, y: 0.12047217068224458d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165043515457576d, y: 0.029822796452406153d), new NpgsqlTypes.NpgsqlPoint(x: 0.38334249923904606d, y: 0.3189280185866211d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6170249693418263d, y: 0.26067477936328975d), new NpgsqlTypes.NpgsqlPoint(x: 0.10675669010260491d, y: 0.6403991971910894d), new NpgsqlTypes.NpgsqlPoint(x: 0.23377932262290302d, y: 0.8346846762755793d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.36050424163637285d, y: 0.4712943308422497d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267845958897993d, y: 0.08979861043947601d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032030677116607d, y: 0.8633052227196767d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5922128472367745d, y: 0.5996881493790378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6023139333724093d, y: 0.9424280124855826d), new NpgsqlTypes.NpgsqlPoint(x: 0.24198185686758744d, y: 0.4650355991621d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.10063750486244682d, y: 0.33600060992516d), new NpgsqlTypes.NpgsqlPoint(x: 0.25061776237686584d, y: 0.3646457335566252d), new NpgsqlTypes.NpgsqlPoint(x: 0.3507129897269593d, y: 0.5171905866426609d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9125930766248542d, y: 0.7107158137492823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8707633885282173d, y: 0.012072114463891337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861304591485418d, y: 0.14586070381915406d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.11158213671120998d, y: 0.7764442908921118d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146364329691308d, y: 0.01683287509918374d), new NpgsqlTypes.NpgsqlPoint(x: 0.48394190113730806d, y: 0.5051441962625985d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.20087439326899714d, y: 0.7985625919150379d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087544726244582d, y: 0.15375538063598748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529195322983044d, y: 0.3673629369806777d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5319520411861131d, y: 0.6718480292850904d), new NpgsqlTypes.NpgsqlPoint(x: 0.4062250783131013d, y: 0.5809697714641384d), new NpgsqlTypes.NpgsqlPoint(x: 0.04807228768520422d, y: 0.006038848768334937d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.560802525168458d, y: 0.32235201249682044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873522143359712d, y: 0.3217115056060619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9508397910568601d, y: 0.6140659288210112d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.8535415616252817d, y: 0.8069905407372996d), new NpgsqlTypes.NpgsqlPoint(x: 0.48308282797012625d, y: 0.884492589907252d), new NpgsqlTypes.NpgsqlPoint(x: 0.10546591121603166d, y: 0.14552409820136036d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.39262624031971727d, y: 0.6853563311447639d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089222289247387d, y: 0.24234654098839437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735721243508507d, y: 0.7348663321624994d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5109811655908848d, y: 0.5762842236320798d), new NpgsqlTypes.NpgsqlPoint(x: 0.341432890667848d, y: 0.1994982686107999d), new NpgsqlTypes.NpgsqlPoint(x: 0.12892272992391118d, y: 0.9337932134869665d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8194902404131726d, y: 0.6599795389837202d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215241181663225d, y: 0.02041529464878078d), new NpgsqlTypes.NpgsqlPoint(x: 0.3396774172937579d, y: 0.6939985504531838d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5584456971245253d, y: 0.6718497177583524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846634263039996d, y: 0.04076121432750479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6782801750917118d, y: 0.863988688206824d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5151860937664656d, y: 0.1260421139642196d), new NpgsqlTypes.NpgsqlPoint(x: 0.34367551471262736d, y: 0.3046405485222152d), new NpgsqlTypes.NpgsqlPoint(x: 0.597454545586071d, y: 0.33984754195251365d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.42125688311736975d, y: 0.9933595083474362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7539156252927981d, y: 0.10569386452987606d), new NpgsqlTypes.NpgsqlPoint(x: 0.1796538986752968d, y: 0.9238670947112849d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.14277554315809626d, y: 0.3903447111242233d), new NpgsqlTypes.NpgsqlPoint(x: 0.6609451409740462d, y: 0.43969062344031695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4082221608821518d, y: 0.5129101377459695d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7723706303586928d, y: 0.7602322306301288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907798291346371d, y: 0.5877867264928495d), new NpgsqlTypes.NpgsqlPoint(x: 0.20895255771614407d, y: 0.6436949052401079d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.020736946101193032d, y: 0.19599988856856454d), new NpgsqlTypes.NpgsqlPoint(x: 0.14077779435972404d, y: 0.3681704449625317d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387345241894158d, y: 0.22533552205925522d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.35469756287167686d, y: 0.32491911619668823d), new NpgsqlTypes.NpgsqlPoint(x: 0.08703222448740167d, y: 0.25372545720762885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184857754360115d, y: 0.9779935382614718d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5874424575444055d, y: 0.5315400800964394d), new NpgsqlTypes.NpgsqlPoint(x: 0.06548741611892128d, y: 0.7623958137651565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785371361465514d, y: 0.4657585080037483d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3012330902969307d, y: 0.4663425861120932d), new NpgsqlTypes.NpgsqlPoint(x: 0.03484084497920914d, y: 0.036552958917176914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801940153558431d, y: 0.9653625759386099d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9791166909362639d, y: 0.7610633941605862d), new NpgsqlTypes.NpgsqlPoint(x: 0.22214956593229962d, y: 0.2529518918331929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075110555256804d, y: 0.8778506078005657d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8486826124403776d, y: 0.49960101624506636d), new NpgsqlTypes.NpgsqlPoint(x: 0.02779207567622821d, y: 0.6813571270421931d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795128250385362d, y: 0.4461335221103724d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.14787826230640821d, y: 0.43798447069277135d), new NpgsqlTypes.NpgsqlPoint(x: 0.17994437903530303d, y: 0.7203623220503147d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867380077042968d, y: 0.17396336325204065d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7726548389088719d, y: 0.6826292069954779d), new NpgsqlTypes.NpgsqlPoint(x: 0.15129407375452164d, y: 0.13273354671566306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4615548709824554d, y: 0.9573375400739779d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.46462343236720705d, y: 0.4234070100590581d), new NpgsqlTypes.NpgsqlPoint(x: 0.8192991039644086d, y: 0.8927264220651222d), new NpgsqlTypes.NpgsqlPoint(x: 0.475565711170321d, y: 0.45106651645525686d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6739208929895413d, y: 0.8514089448714623d), new NpgsqlTypes.NpgsqlPoint(x: 0.3954158156839782d, y: 0.5732985494637771d), new NpgsqlTypes.NpgsqlPoint(x: 0.32625008784116294d, y: 0.7576112925198096d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8756812613565867d, y: 0.9657404288554522d), new NpgsqlTypes.NpgsqlPoint(x: 0.331526786856029d, y: 0.9398440317886244d), new NpgsqlTypes.NpgsqlPoint(x: 0.49058752595953203d, y: 0.7880782134537012d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.782821599175426d, y: 0.7190614630614663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5947677736015278d, y: 0.8572237883393492d), new NpgsqlTypes.NpgsqlPoint(x: 0.08735002970388228d, y: 0.07196150421507663d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6672677100452661d, y: 0.20631141043662304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261771806035391d, y: 0.15243474447467176d), new NpgsqlTypes.NpgsqlPoint(x: 0.48488513988384974d, y: 0.6081011135283525d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45932792695565683d, y: 0.27149281956102367d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872508690495581d, y: 0.4992641437771502d), new NpgsqlTypes.NpgsqlPoint(x: 0.16177336935798126d, y: 0.3154230001909829d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45502901757442704d, y: 0.7680658759624341d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359078715013055d, y: 0.9117271381280818d), new NpgsqlTypes.NpgsqlPoint(x: 0.2428321809487618d, y: 0.00444701554315019d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9079374821927543d, y: 0.09637099581774189d), new NpgsqlTypes.NpgsqlPoint(x: 0.39668677507597827d, y: 0.8240767565592757d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055137802204242d, y: 0.7188737584821393d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3303133023224629d, y: 0.2109361920723808d), new NpgsqlTypes.NpgsqlPoint(x: 0.1186879718482472d, y: 0.1520022949225136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132000238475262d, y: 0.7420595747666819d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08541694828043922d, y: 0.0850903563294344d), new NpgsqlTypes.NpgsqlPoint(x: 0.733976023690252d, y: 0.668763593697432d), new NpgsqlTypes.NpgsqlPoint(x: 0.017511875865881876d, y: 0.8881884682999424d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.0969812114629619d, y: 0.7852611942690085d), new NpgsqlTypes.NpgsqlPoint(x: 0.05818849499923684d, y: 0.7632216509867433d), new NpgsqlTypes.NpgsqlPoint(x: 0.36034598621715597d, y: 0.9714677466369596d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6020376381273941d, y: 0.8396878890556201d), new NpgsqlTypes.NpgsqlPoint(x: 0.3109456890903348d, y: 0.02685745745975332d), new NpgsqlTypes.NpgsqlPoint(x: 0.35329946752182795d, y: 0.876277832529565d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.46566063062736807d, y: 0.6559792195247455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176295305285338d, y: 0.7506802626015938d), new NpgsqlTypes.NpgsqlPoint(x: 0.15635041612476952d, y: 0.7587124256921765d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7158301142035733d, y: 0.9340659792685077d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402174181509376d, y: 0.8300244749885335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636498637714969d, y: 0.4184221988476371d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8608713500563384d, y: 0.8475150738582333d), new NpgsqlTypes.NpgsqlPoint(x: 0.29009245107929926d, y: 0.8968652225576669d), new NpgsqlTypes.NpgsqlPoint(x: 0.32536018500747943d, y: 0.8877756272335969d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6266362747968255d, y: 0.08617834129824431d), new NpgsqlTypes.NpgsqlPoint(x: 0.36759637686782043d, y: 0.40344376343392396d), new NpgsqlTypes.NpgsqlPoint(x: 0.16752912211516902d, y: 0.07177164698472094d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.48441036407596294d, y: 0.06419926921552499d), new NpgsqlTypes.NpgsqlPoint(x: 0.7908719623012564d, y: 0.4171410218401028d), new NpgsqlTypes.NpgsqlPoint(x: 0.28859157574664274d, y: 0.7821511107520606d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8516274136993445d, y: 0.72259300462158d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243514056812894d, y: 0.17190729830716933d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484044677571073d, y: 0.26796359754018373d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7599849007728586d, y: 0.18790102844654988d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430555097276573d, y: 0.8945964374807825d), new NpgsqlTypes.NpgsqlPoint(x: 0.40830636611377247d, y: 0.010865223297443216d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9711637871416834d, y: 0.31137044197986463d), new NpgsqlTypes.NpgsqlPoint(x: 0.2013160200819576d, y: 0.327926244313249d), new NpgsqlTypes.NpgsqlPoint(x: 0.912343880550354d, y: 0.8312993398153339d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3575361470663563d, y: 0.4849023123521954d), new NpgsqlTypes.NpgsqlPoint(x: 0.1761885628668587d, y: 0.09259228515220619d), new NpgsqlTypes.NpgsqlPoint(x: 0.1765044679488742d, y: 0.9487336247603659d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3809131370329515d, y: 0.18736774700226877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761790000421903d, y: 0.8878500257334774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422250264718177d, y: 0.1952718265780794d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.857691524727996d, y: 0.03616007450562453d), new NpgsqlTypes.NpgsqlPoint(x: 0.0709581662500145d, y: 0.9690207814248805d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899471276837867d, y: 0.7249125261280913d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.33732537326130685d, y: 0.5630010227369775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9255609983676573d, y: 0.8886611628531541d), new NpgsqlTypes.NpgsqlPoint(x: 0.21811273842052048d, y: 0.06412882826824118d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9370966164599701d, y: 0.04726919017456399d), new NpgsqlTypes.NpgsqlPoint(x: 0.1632158521099406d, y: 0.790873066724016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978795750995768d, y: 0.8685086117168552d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.35539540647226586d, y: 0.2441502245724545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896605974653942d, y: 0.6714823352269368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652722018319512d, y: 0.28531357855879047d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.24504958123391685d, y: 0.757089024130219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926822745081102d, y: 0.41981479794050236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019189232458714d, y: 0.6582000833804524d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5046284896301952d, y: 0.46801303881981604d), new NpgsqlTypes.NpgsqlPoint(x: 0.026463962688627385d, y: 0.7903872926612344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936870859075541d, y: 0.6485204210012434d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.019334691738498222d, y: 0.8161439530455821d), new NpgsqlTypes.NpgsqlPoint(x: 0.9942566496620272d, y: 0.6409350396363697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9757398900829145d, y: 0.30307351277505834d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6131175474448595d, y: 0.4243494545258921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682391223143039d, y: 0.13831383030522548d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852277397329748d, y: 0.42580585091412093d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7886294819656643d, y: 0.08833232208299358d), new NpgsqlTypes.NpgsqlPoint(x: 0.3716971018726829d, y: 0.7160690958991796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7593200988959098d, y: 0.08416801630408477d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6771946795060394d, y: 0.40759194813013055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036542524746745d, y: 0.30872360380491903d), new NpgsqlTypes.NpgsqlPoint(x: 0.20940662442396396d, y: 0.3051279064420622d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2750494190020939d, y: 0.2802625540334257d), new NpgsqlTypes.NpgsqlPoint(x: 0.2003731833181568d, y: 0.7045904895003735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3725787736102323d, y: 0.038415510268143827d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.41780542605880877d, y: 0.08992071719571926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231033718079565d, y: 0.6237251097111287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529413429690283d, y: 0.938601561998215d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.21844582957180947d, y: 0.13210744425074228d), new NpgsqlTypes.NpgsqlPoint(x: 0.4416321895451839d, y: 0.11018013846787522d), new NpgsqlTypes.NpgsqlPoint(x: 0.41121651230482603d, y: 0.18895120619708483d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4919184070641235d, y: 0.3126519970444718d), new NpgsqlTypes.NpgsqlPoint(x: 0.18436919856539524d, y: 0.6097827041711841d), new NpgsqlTypes.NpgsqlPoint(x: 0.1193413900904472d, y: 0.06074359099402149d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.16952081122788487d, y: 0.9405073846181925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006596226667424d, y: 0.32065984574623296d), new NpgsqlTypes.NpgsqlPoint(x: 0.3646260992558452d, y: 0.5365769072938986d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9836090744157492d, y: 0.8989303612291769d), new NpgsqlTypes.NpgsqlPoint(x: 0.30788987796961964d, y: 0.7049847529830947d), new NpgsqlTypes.NpgsqlPoint(x: 0.003746036844740175d, y: 0.17077462212570715d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8011143903945898d, y: 0.15303027370979116d), new NpgsqlTypes.NpgsqlPoint(x: 0.21114051342328977d, y: 0.3987757135802432d), new NpgsqlTypes.NpgsqlPoint(x: 0.4728687372466228d, y: 0.15659358466313944d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9694161140430188d, y: 0.29279062551406043d), new NpgsqlTypes.NpgsqlPoint(x: 0.8469004898449489d, y: 0.037662953473365235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9233998225419981d, y: 0.8945151022385474d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7206668067219747d, y: 0.19651570015600284d), new NpgsqlTypes.NpgsqlPoint(x: 0.07531699169114892d, y: 0.23078349340387094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751577085315846d, y: 0.28902446990628583d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5921498488656544d, y: 0.19007999967909806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7800812707279777d, y: 0.2799171532619684d), new NpgsqlTypes.NpgsqlPoint(x: 0.647235222413959d, y: 0.8498773862548109d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7320006310829673d, y: 0.9508548389734619d), new NpgsqlTypes.NpgsqlPoint(x: 0.16196406698551102d, y: 0.699035175375956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884632711339123d, y: 0.9047226674804398d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5355719894443527d, y: 0.9180986248836406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473253847520701d, y: 0.8564324652320445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9381543391091676d, y: 0.9869671646398266d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7450864873255832d, y: 0.8569758611852393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662906812110654d, y: 0.663178683896888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586276180542031d, y: 0.25851215205609446d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8063764690314481d, y: 0.5808323509443256d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935577494452771d, y: 0.7074803607612267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614619690024161d, y: 0.13169875272451703d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9529154412163907d, y: 0.657844436375069d), new NpgsqlTypes.NpgsqlPoint(x: 0.16558619123855445d, y: 0.3678717189561955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702558601654314d, y: 0.36320963568293285d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.26477068782603275d, y: 0.615578736101768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190578115039925d, y: 0.9287361293993048d), new NpgsqlTypes.NpgsqlPoint(x: 0.03827409047112684d, y: 0.3364221904680965d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3809202614679503d, y: 0.3742990797985002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7876883386035404d, y: 0.46293122856166713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053933197616127d, y: 0.6297345250590581d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6799858878839973d, y: 0.1080202744321439d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517783714690813d, y: 0.7408489676809347d), new NpgsqlTypes.NpgsqlPoint(x: 0.1930272099234901d, y: 0.6576363862249935d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1021699628286935d, y: 0.8778616583210723d), new NpgsqlTypes.NpgsqlPoint(x: 0.0793686529452442d, y: 0.3224829801248793d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163110980658505d, y: 0.9488010516574397d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.05835880422920858d, y: 0.6597253513181758d), new NpgsqlTypes.NpgsqlPoint(x: 0.911560524891522d, y: 0.7083678934542011d), new NpgsqlTypes.NpgsqlPoint(x: 0.34272618089032136d, y: 0.12211615772138573d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.4713814058614315d, y: 0.8561919786034623d), new NpgsqlTypes.NpgsqlPoint(x: 0.38278911951572103d, y: 0.253822304318306d), new NpgsqlTypes.NpgsqlPoint(x: 0.756339203284145d, y: 0.4204580951023743d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4096604543337816d, y: 0.25318583025650154d), new NpgsqlTypes.NpgsqlPoint(x: 0.3428338405083612d, y: 0.6431358782921901d), new NpgsqlTypes.NpgsqlPoint(x: 0.7938372612314019d, y: 0.9426086258241464d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7828814387931087d, y: 0.11227555117199728d), new NpgsqlTypes.NpgsqlPoint(x: 0.710781551032646d, y: 0.3612107567390347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544129907050156d, y: 0.6295355402392592d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.05213840458001384d, y: 0.034399517840417726d), new NpgsqlTypes.NpgsqlPoint(x: 0.0806828143891608d, y: 0.2798562073823141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9221729307892838d, y: 0.519813983772376d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.661335992438087d, y: 0.14144959123608525d), new NpgsqlTypes.NpgsqlPoint(x: 0.4647485613983706d, y: 0.5897721857547431d), new NpgsqlTypes.NpgsqlPoint(x: 0.61324799182988d, y: 0.9918954750678382d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.0008925150384991865d, y: 0.6667714606961778d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999373060234713d, y: 0.1385639932311783d), new NpgsqlTypes.NpgsqlPoint(x: 0.19646907620436704d, y: 0.7672836861689941d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.04550954842508814d, y: 0.9562385688361422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9945390909730552d, y: 0.5037329997429798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256051677544058d, y: 0.1285349148860293d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.40654361967160335d, y: 0.8522627177647045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6352892939940472d, y: 0.5369228436122887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7850134750242569d, y: 0.7656134975110693d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10674663513811455d, y: 0.8719070474304955d), new NpgsqlTypes.NpgsqlPoint(x: 0.015394432610085329d, y: 0.7071143870356275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7382310519726453d, y: 0.39644586152452665d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.963571062163925d, y: 0.02401673062398557d), new NpgsqlTypes.NpgsqlPoint(x: 0.30948512747924617d, y: 0.1844630979794858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5189772041458282d, y: 0.4002466985563098d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.23168433240104136d, y: 0.1469518574386327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264617838396859d, y: 0.07168391169892463d), new NpgsqlTypes.NpgsqlPoint(x: 0.578252255585856d, y: 0.22112964714326988d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10562171846338198d, y: 0.7499474219971235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3823621062359692d, y: 0.20414774040724548d), new NpgsqlTypes.NpgsqlPoint(x: 0.18473570829840114d, y: 0.09568979112518283d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.8680208696269419d, y: 0.8387333870972025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161405499275685d, y: 0.3193462713198175d), new NpgsqlTypes.NpgsqlPoint(x: 0.17202470284321492d, y: 0.10369830855019557d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9179814688876867d, y: 0.07670729042462965d), new NpgsqlTypes.NpgsqlPoint(x: 0.06745797628261996d, y: 0.201531766881195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7487728126828059d, y: 0.6964234347845942d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9888142854237988d, y: 0.7632902858951934d), new NpgsqlTypes.NpgsqlPoint(x: 0.2421670429321484d, y: 0.11945891919713869d), new NpgsqlTypes.NpgsqlPoint(x: 0.09714722211306515d, y: 0.47314214777384d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5714078321488028d, y: 0.7180878642643571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7383241630032227d, y: 0.7504763716709758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742951122556952d, y: 0.5990136668416165d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8685583295839258d, y: 0.4381027871266696d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065004215751004d, y: 0.8941150936772405d), new NpgsqlTypes.NpgsqlPoint(x: 0.039140532689467045d, y: 0.12235658773796487d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.48957247420912964d, y: 0.35953675789424255d), new NpgsqlTypes.NpgsqlPoint(x: 0.39924048928234557d, y: 0.76353566314273d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693241550578986d, y: 0.48275847686867235d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5513421565179153d, y: 0.7597530095367426d), new NpgsqlTypes.NpgsqlPoint(x: 0.24530594151110707d, y: 0.052715403016458495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292855913438374d, y: 0.1719280174163046d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.34160572491814667d, y: 0.3827104055780326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7802319684520255d, y: 0.558144711151344d), new NpgsqlTypes.NpgsqlPoint(x: 0.22470076927281823d, y: 0.9211328245344917d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.23206609166066783d, y: 0.054166032616047355d), new NpgsqlTypes.NpgsqlPoint(x: 0.35865002573564475d, y: 0.5716375448135426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3457835746440787d, y: 0.4121433233060696d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.2708851802360467d, y: 0.09911341218743064d), new NpgsqlTypes.NpgsqlPoint(x: 0.11533904058066236d, y: 0.5698345487382332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570517237253616d, y: 0.20828192361086273d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.13760961024412455d, y: 0.4634839593685308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211061376985292d, y: 0.2270885731495239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8761384003024681d, y: 0.18456006340111697d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.15252488291183064d, y: 0.718921428176855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401554492045834d, y: 0.11939128714542424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3588978467064179d, y: 0.6239560732596274d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6034262530299858d, y: 0.7014546731701357d), new NpgsqlTypes.NpgsqlPoint(x: 0.03596439992515499d, y: 0.08117035759465496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671735445413395d, y: 0.4965242551080149d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2136468282184405d, y: 0.5930479629962119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4467560708224708d, y: 0.11205867167312422d), new NpgsqlTypes.NpgsqlPoint(x: 0.48307241213636243d, y: 0.7715509433236892d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5653116779527579d, y: 0.9613457250047761d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369665889231743d, y: 0.8899407802165534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6781658565287466d, y: 0.20780766748123758d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3203827504954253d, y: 0.5800457612312089d), new NpgsqlTypes.NpgsqlPoint(x: 0.3256711733665304d, y: 0.6876336797368263d), new NpgsqlTypes.NpgsqlPoint(x: 0.14204101103505062d, y: 0.043299671734206346d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.0009249740371822801d, y: 0.9230029982672376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807988952980242d, y: 0.6698849711782211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326469384792049d, y: 0.8467219432528923d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.11019857604434313d, y: 0.4476309191612302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900359567543684d, y: 0.38099449488104553d), new NpgsqlTypes.NpgsqlPoint(x: 0.40530335701699427d, y: 0.94727437986488d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.2581150630172241d, y: 0.22582142125891225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818634498629712d, y: 0.23960049049779197d), new NpgsqlTypes.NpgsqlPoint(x: 0.15315984129928384d, y: 0.5329369929570631d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2023944223069517d, y: 0.4060744727367279d), new NpgsqlTypes.NpgsqlPoint(x: 0.4680481708335211d, y: 0.361718568212236d), new NpgsqlTypes.NpgsqlPoint(x: 0.11610545506126013d, y: 0.20981529146587474d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22776619551797028d, y: 0.33461391054898637d), new NpgsqlTypes.NpgsqlPoint(x: 0.47262252324898923d, y: 0.4930034360815304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8418436526995483d, y: 0.8240362424396792d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8378767934687436d, y: 0.19917040408505715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7409424233243623d, y: 0.1421393957666175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322114427735889d, y: 0.2592792766140154d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.020894827582004893d, y: 0.18347908016724057d), new NpgsqlTypes.NpgsqlPoint(x: 0.3250404644363707d, y: 0.5786085465979464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808249723089118d, y: 0.9333086905532203d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5415861589059755d, y: 0.4042469439422558d), new NpgsqlTypes.NpgsqlPoint(x: 0.18639478720287828d, y: 0.20696300229641973d), new NpgsqlTypes.NpgsqlPoint(x: 0.2784074721210449d, y: 0.879537713142621d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.19615766761471654d, y: 0.9191351895592076d), new NpgsqlTypes.NpgsqlPoint(x: 0.058038812204941004d, y: 0.4294566825540259d), new NpgsqlTypes.NpgsqlPoint(x: 0.7763252604463285d, y: 0.6718555985778416d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1344808776760501d, y: 0.8948228967846475d), new NpgsqlTypes.NpgsqlPoint(x: 0.2521957924880006d, y: 0.3163018836098459d), new NpgsqlTypes.NpgsqlPoint(x: 0.811481729911353d, y: 0.4466023048124991d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2406668331324201d, y: 0.3727822641166275d), new NpgsqlTypes.NpgsqlPoint(x: 0.933032919567932d, y: 0.885317185852269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9745567313394918d, y: 0.6942209284432892d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.19996328068445102d, y: 0.8702061167972979d), new NpgsqlTypes.NpgsqlPoint(x: 0.10276961487087266d, y: 0.5241333281120363d), new NpgsqlTypes.NpgsqlPoint(x: 0.32082383815252835d, y: 0.8115228500448689d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.09984785833401078d, y: 0.25740212458787337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569106381660382d, y: 0.36965017768729813d), new NpgsqlTypes.NpgsqlPoint(x: 0.15831206424181898d, y: 0.13925391832920297d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.48162442145414464d, y: 0.05761668693304722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009164803433038d, y: 0.36118670160191124d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287739415339272d, y: 0.2452616022327483d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.12232206028954629d, y: 0.24383894148598106d), new NpgsqlTypes.NpgsqlPoint(x: 0.17242432869128088d, y: 0.39738107850453763d), new NpgsqlTypes.NpgsqlPoint(x: 0.09824839621569759d, y: 0.5144818680816242d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32481008430938263d, y: 0.730205222096016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7063849595895723d, y: 0.11052700335310295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6503984993262232d, y: 0.4004211004709195d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.708512033404393d, y: 0.30385459812958715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994176423948211d, y: 0.45824327613654203d), new NpgsqlTypes.NpgsqlPoint(x: 0.44809794664573255d, y: 0.6362950307918546d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.4647756366382677d, y: 0.5828545526430914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740253880695346d, y: 0.29850346113512627d), new NpgsqlTypes.NpgsqlPoint(x: 0.8849802430892458d, y: 0.673735358793969d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9623773628175338d, y: 0.08105356405756103d), new NpgsqlTypes.NpgsqlPoint(x: 0.06620299941711094d, y: 0.5025358172254826d), new NpgsqlTypes.NpgsqlPoint(x: 0.043861445752837236d, y: 0.3473656350516314d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.736057276341318d, y: 0.6834422906411705d), new NpgsqlTypes.NpgsqlPoint(x: 0.8556860229273628d, y: 0.7245541089684048d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227656170021448d, y: 0.23869993350909102d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.8007415482015408d, y: 0.9870439409769471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8211711296046315d, y: 0.9818281162112323d), new NpgsqlTypes.NpgsqlPoint(x: 0.6604260580005751d, y: 0.7107665252314814d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08315729903345936d, y: 0.11477345933125715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4509740867543639d, y: 0.12307724721179292d), new NpgsqlTypes.NpgsqlPoint(x: 0.14384075663408125d, y: 0.02481497206316119d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3055893574265224d, y: 0.150156624048576d), new NpgsqlTypes.NpgsqlPoint(x: 0.716401711572298d, y: 0.08487871341007214d), new NpgsqlTypes.NpgsqlPoint(x: 0.21127018708037004d, y: 0.2236200811541218d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3770812338920305d, y: 0.3978435660585048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620036041817319d, y: 0.9394410243705974d), new NpgsqlTypes.NpgsqlPoint(x: 0.005647938167382294d, y: 0.2590918212168529d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8454726463887327d, y: 0.9366015345852875d), new NpgsqlTypes.NpgsqlPoint(x: 0.2831658447764571d, y: 0.6318117070756152d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780122885230575d, y: 0.598398728921479d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6636420938906179d, y: 0.3752487995166086d), new NpgsqlTypes.NpgsqlPoint(x: 0.02414916660012356d, y: 0.620964353566983d), new NpgsqlTypes.NpgsqlPoint(x: 0.75932438362597d, y: 0.9664755629737956d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.02195960798107044d, y: 0.3157337644121211d), new NpgsqlTypes.NpgsqlPoint(x: 0.4294719003161186d, y: 0.6294414410080985d), new NpgsqlTypes.NpgsqlPoint(x: 0.761801088614227d, y: 0.5644873939460541d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1785778173596384d, y: 0.4523338723103245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801785524472491d, y: 0.17134741228109285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924353094620711d, y: 0.2567026206892975d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5085393190832026d, y: 0.022079805566977417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3600263725113213d, y: 0.7179801299644852d), new NpgsqlTypes.NpgsqlPoint(x: 0.0047321456874264145d, y: 0.7241569167597022d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.46954800352287995d, y: 0.8920759962643999d), new NpgsqlTypes.NpgsqlPoint(x: 0.37696482029879863d, y: 0.7585157653650307d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837529161783249d, y: 0.9760121390030738d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2703574415400479d, y: 0.2998337607411681d), new NpgsqlTypes.NpgsqlPoint(x: 0.17183610232416824d, y: 0.5895371349387692d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657701036746731d, y: 0.8140950896049195d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.020497841383066207d, y: 0.4549138840882926d), new NpgsqlTypes.NpgsqlPoint(x: 0.44547893686864326d, y: 0.4314423000319787d), new NpgsqlTypes.NpgsqlPoint(x: 0.37308237307296366d, y: 0.8732401555490373d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.009851871232879006d, y: 0.7051323570199346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6064799840924718d, y: 0.6825929715050922d), new NpgsqlTypes.NpgsqlPoint(x: 0.06634310757981277d, y: 0.11674189840864335d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9941476538021111d, y: 0.03282488545900908d), new NpgsqlTypes.NpgsqlPoint(x: 0.024438335449403215d, y: 0.6472328145758302d), new NpgsqlTypes.NpgsqlPoint(x: 0.1541635421942421d, y: 0.1470063345271817d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8997952306449716d, y: 0.006520169122998354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5983465582158278d, y: 0.602191728095406d), new NpgsqlTypes.NpgsqlPoint(x: 0.48701563696066363d, y: 0.27827981889754083d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5945144445253007d, y: 0.5151340536232449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559417548395521d, y: 0.23927257096015042d), new NpgsqlTypes.NpgsqlPoint(x: 0.21231004835768896d, y: 0.8998100669212591d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9973976177297286d, y: 0.4968538580056756d), new NpgsqlTypes.NpgsqlPoint(x: 0.46362934505378084d, y: 0.9776912682140916d), new NpgsqlTypes.NpgsqlPoint(x: 0.743375407142419d, y: 0.997014373978161d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7513255115985823d, y: 0.058780569945957706d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012145149678408629d, y: 0.913829448097486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744635302631983d, y: 0.2945333140822305d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7699558450873822d, y: 0.6114213289811108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8860555628114716d, y: 0.1521625322753729d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936038235947447d, y: 0.31975625510298544d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9530559797099328d, y: 0.4696523468732887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499375850215445d, y: 0.9416135122023241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9005078960282327d, y: 0.44453603796564134d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8842144075992973d, y: 0.8718918938098252d), new NpgsqlTypes.NpgsqlPoint(x: 0.0278417053706701d, y: 0.3058918673935702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951878652711282d, y: 0.5364199732528606d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.391567931067749d, y: 0.24015109416794578d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220768125198741d, y: 0.4267466104867831d), new NpgsqlTypes.NpgsqlPoint(x: 0.6191443481061153d, y: 0.9990728191427196d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08007201188050583d, y: 0.8110714003419013d), new NpgsqlTypes.NpgsqlPoint(x: 0.3970826583370909d, y: 0.0775630116047652d), new NpgsqlTypes.NpgsqlPoint(x: 0.4523175957410348d, y: 0.6945727576047448d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6696246655892695d, y: 0.20884973701463216d), new NpgsqlTypes.NpgsqlPoint(x: 0.42460872914901715d, y: 0.9969147192753368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820640475773099d, y: 0.7215842122839805d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.28936142380477115d, y: 0.25944809722347995d), new NpgsqlTypes.NpgsqlPoint(x: 0.277849660225419d, y: 0.7927542403809337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3663829719107362d, y: 0.8250707622240248d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7188015525554905d, y: 0.9297856656012288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6588024047689562d, y: 0.057476275830792734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9881022766084187d, y: 0.2588127034602289d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.20778518747324903d, y: 0.5646453188344637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6522158440446381d, y: 0.6820569455069917d), new NpgsqlTypes.NpgsqlPoint(x: 0.08916470238668661d, y: 0.45580084411536803d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7227665565047852d, y: 0.6513259243702055d), new NpgsqlTypes.NpgsqlPoint(x: 0.24650775057791663d, y: 0.872709011394414d), new NpgsqlTypes.NpgsqlPoint(x: 0.24143734469149714d, y: 0.29484254478654914d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3094876904674667d, y: 0.016314934960395933d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578573572317606d, y: 0.1837240780772379d), new NpgsqlTypes.NpgsqlPoint(x: 0.2704420023549492d, y: 0.3799247020959303d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7177961148020552d, y: 0.9911963876540696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294132598303301d, y: 0.7402245254947868d), new NpgsqlTypes.NpgsqlPoint(x: 0.3867802912318903d, y: 0.18816038494002718d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8419324443267958d, y: 0.26570700934505953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046715818040603d, y: 0.9765086609570264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969085258869087d, y: 0.9889341207654504d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.40539564427819597d, y: 0.3142905931969546d), new NpgsqlTypes.NpgsqlPoint(x: 0.1177447371925332d, y: 0.6529422145832354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652046128934346d, y: 0.1655463519012198d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8861170758718381d, y: 0.3531934598507611d), new NpgsqlTypes.NpgsqlPoint(x: 0.868894856907831d, y: 0.045698970225993674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271457522811242d, y: 0.9543206980405889d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9037310790552038d, y: 0.6188769176937328d), new NpgsqlTypes.NpgsqlPoint(x: 0.2475024202936893d, y: 0.17618389065763684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9702193322210314d, y: 0.10535779259400924d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4628370999878305d, y: 0.9312512237581384d), new NpgsqlTypes.NpgsqlPoint(x: 0.35366581941618835d, y: 0.2295744635739725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674229872541441d, y: 0.6958309218227702d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6383966933779958d, y: 0.4729863010480053d), new NpgsqlTypes.NpgsqlPoint(x: 0.2524913456408119d, y: 0.6078685723542565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423875103059216d, y: 0.31740703841090967d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.25216130157522565d, y: 0.6635293709227195d), new NpgsqlTypes.NpgsqlPoint(x: 0.2374456581200619d, y: 0.34701649383224864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565003160959861d, y: 0.8619426040114212d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6127939216862239d, y: 0.4370337390330499d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299989023469062d, y: 0.9159361520479606d), new NpgsqlTypes.NpgsqlPoint(x: 0.27405309852770066d, y: 0.20542852458191396d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.37782426902917465d, y: 0.8223993330630612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9251300724952964d, y: 0.5717187782677982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8890395042285469d, y: 0.7668196743587259d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8236391044910608d, y: 0.28369319829887896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5576479848056441d, y: 0.2723596750679047d), new NpgsqlTypes.NpgsqlPoint(x: 0.1696658265585027d, y: 0.8718426034823044d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22002573655541968d, y: 0.4160551441485064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382552234904862d, y: 0.6986337523443648d), new NpgsqlTypes.NpgsqlPoint(x: 0.43974736253408453d, y: 0.05024673201345109d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9057136106331117d, y: 0.5144111972170279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9767903782373633d, y: 0.328026227982101d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087294149621245d, y: 0.41994167253304826d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.040495068783400034d, y: 0.4114230420989906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341329730622115d, y: 0.5414671292542743d), new NpgsqlTypes.NpgsqlPoint(x: 0.036292698877772867d, y: 0.761298387095346d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5820208041205134d, y: 0.8341876180675442d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704387505145696d, y: 0.3079551078889934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9005042052121406d, y: 0.46065546081597586d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8073730477002672d, y: 0.5087093782893675d), new NpgsqlTypes.NpgsqlPoint(x: 0.82204995488503d, y: 0.6122010254414946d), new NpgsqlTypes.NpgsqlPoint(x: 0.737353573562036d, y: 0.21614161548207067d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.718493705153174d, y: 0.32328037007178445d), new NpgsqlTypes.NpgsqlPoint(x: 0.28442884736477014d, y: 0.8019991294362194d), new NpgsqlTypes.NpgsqlPoint(x: 0.46324379504061985d, y: 0.26528524952665267d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.15759737390154205d, y: 0.7782809916293331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847547990717438d, y: 0.1648972156175248d), new NpgsqlTypes.NpgsqlPoint(x: 0.26679128384189343d, y: 0.5997102810466902d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.56740706580425d, y: 0.07714771975928003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775720021813248d, y: 0.5272397777598882d), new NpgsqlTypes.NpgsqlPoint(x: 0.48693028032999d, y: 0.9759783667710997d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5406238854084388d, y: 0.5559371704915683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8302370883092591d, y: 0.04009536719039308d), new NpgsqlTypes.NpgsqlPoint(x: 0.271878449531065d, y: 0.15161622833126776d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3943580788833976d, y: 0.6730929572062121d), new NpgsqlTypes.NpgsqlPoint(x: 0.12613668852314086d, y: 0.35046446964179667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7505786059403374d, y: 0.6934265705678284d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12190684495560955d, y: 0.3094434921469722d), new NpgsqlTypes.NpgsqlPoint(x: 0.2367529767627763d, y: 0.24844398695776504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615487016805881d, y: 0.47362789687859697d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8808734749565541d, y: 0.5895847354147988d), new NpgsqlTypes.NpgsqlPoint(x: 0.47412165543614626d, y: 0.024844628491652476d), new NpgsqlTypes.NpgsqlPoint(x: 0.045207140881104224d, y: 0.7169700614462232d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4572430168787486d, y: 0.37258083672647446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353801802986695d, y: 0.23485997838814787d), new NpgsqlTypes.NpgsqlPoint(x: 0.2729442398523595d, y: 0.5036762044853542d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6625651891219868d, y: 0.42345442717772563d), new NpgsqlTypes.NpgsqlPoint(x: 0.851798054960707d, y: 0.8932310384446837d), new NpgsqlTypes.NpgsqlPoint(x: 0.28758297849517644d, y: 0.15693239623529442d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.19175683361181972d, y: 0.6160809844821414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133572907608399d, y: 0.4925597504526491d), new NpgsqlTypes.NpgsqlPoint(x: 0.46435473776234093d, y: 0.36699900981365496d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6092367820672961d, y: 0.43428845929698745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8746531992649277d, y: 0.36853543256428745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239447093978347d, y: 0.30358878136962075d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9437442820705645d, y: 0.28616227627825574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549038426052977d, y: 0.8716900244005487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566907721131944d, y: 0.9998931481940404d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.462057903897946d, y: 0.29371583362775244d), new NpgsqlTypes.NpgsqlPoint(x: 0.20773983797930573d, y: 0.7664097492152797d), new NpgsqlTypes.NpgsqlPoint(x: 0.13281961183756041d, y: 0.32367498436534814d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5815521063277808d, y: 0.6315640819721808d), new NpgsqlTypes.NpgsqlPoint(x: 0.6186961357748814d, y: 0.26762053248843143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295025723144959d, y: 0.7202982395510817d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.11440434936399657d, y: 0.18045745453720285d), new NpgsqlTypes.NpgsqlPoint(x: 0.41516814694786863d, y: 0.48810699816092074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9495347300196463d, y: 0.3814616070944129d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8957852897754082d, y: 0.6398865589034519d), new NpgsqlTypes.NpgsqlPoint(x: 0.04247241986897776d, y: 0.9546868895974695d), new NpgsqlTypes.NpgsqlPoint(x: 0.018922885503528386d, y: 0.8260304643999044d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7593652227016989d, y: 0.5426958247710371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5497926650785606d, y: 0.3976825992860412d), new NpgsqlTypes.NpgsqlPoint(x: 0.23060344303541225d, y: 0.32214019685293516d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.977865562897863d, y: 0.5630075659073163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4261940311382578d, y: 0.44307314522362984d), new NpgsqlTypes.NpgsqlPoint(x: 0.04125521819807165d, y: 0.09484314018489337d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.5029727213060036d, y: 0.4735323977339647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7576887621473452d, y: 0.3570780284404611d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438820596681318d, y: 0.4221122683357128d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9425348969801807d, y: 0.7329832621178295d), new NpgsqlTypes.NpgsqlPoint(x: 0.01975374205208047d, y: 0.8566109405862993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7315891585612826d, y: 0.08506694038929774d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4520041223033555d, y: 0.5967547902819865d), new NpgsqlTypes.NpgsqlPoint(x: 0.21433312603692378d, y: 0.7983908414270817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013043952535324d, y: 0.46536773955622046d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8702173470359744d, y: 0.0855510200800721d), new NpgsqlTypes.NpgsqlPoint(x: 0.054460945260336624d, y: 0.9219510875877126d), new NpgsqlTypes.NpgsqlPoint(x: 0.259856001312611d, y: 0.03819322531941505d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9393498085573467d, y: 0.5284715554253601d), new NpgsqlTypes.NpgsqlPoint(x: 0.1753533028753813d, y: 0.5085240248608988d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648559785361836d, y: 0.022927722193919697d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.03752641450980854d, y: 0.1704677336827265d), new NpgsqlTypes.NpgsqlPoint(x: 0.3904932601858201d, y: 0.47875288932210314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068332750706101d, y: 0.5593034082321716d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6661279438008454d, y: 0.10205803318823159d), new NpgsqlTypes.NpgsqlPoint(x: 0.07149230444070731d, y: 0.015438498134658585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555931286043704d, y: 0.3121045967766135d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5804519614036567d, y: 0.14251899086705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261688808149267d, y: 0.5426154952747877d), new NpgsqlTypes.NpgsqlPoint(x: 0.06865211284923667d, y: 0.5960837155070249d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45303831955660645d, y: 0.4214908073844428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380091364831404d, y: 0.022932978110246083d), new NpgsqlTypes.NpgsqlPoint(x: 0.0048546079700098055d, y: 0.10981438740317495d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6115400744381317d, y: 0.3251075016267374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177295659958356d, y: 0.5493934982271177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3334503205039163d, y: 0.004105953457645084d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.46289314446424645d, y: 0.024313244227014752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757289269043461d, y: 0.9826418997838646d), new NpgsqlTypes.NpgsqlPoint(x: 0.6434243700901164d, y: 0.5094832426752078d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6397425728380671d, y: 0.4217266262140482d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694760919797707d, y: 0.8370905544229033d), new NpgsqlTypes.NpgsqlPoint(x: 0.03796951143500582d, y: 0.11070763667094796d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.09586619546699171d, y: 0.11070108429717262d), new NpgsqlTypes.NpgsqlPoint(x: 0.49954489530734014d, y: 0.5048212586760193d), new NpgsqlTypes.NpgsqlPoint(x: 0.12686225270041662d, y: 0.6905018105173568d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6427073810228999d, y: 0.996520686735345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4683100292578465d, y: 0.9266677811010586d), new NpgsqlTypes.NpgsqlPoint(x: 0.2777139889851793d, y: 0.62441753420975d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.997208994978157d, y: 0.07637003236742967d), new NpgsqlTypes.NpgsqlPoint(x: 0.695351571380134d, y: 0.0935833566547497d), new NpgsqlTypes.NpgsqlPoint(x: 0.568079421135879d, y: 0.099962216205295d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.028528270230471664d, y: 0.46841581838622603d), new NpgsqlTypes.NpgsqlPoint(x: 0.15221903375752943d, y: 0.22224304973991038d), new NpgsqlTypes.NpgsqlPoint(x: 0.3713516057705559d, y: 0.1332033393631744d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7553512043350504d, y: 0.2013203303389679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7186451343894589d, y: 0.3137497183687532d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885075692743102d, y: 0.5035049698991788d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8302807127054661d, y: 0.9819949071485367d), new NpgsqlTypes.NpgsqlPoint(x: 0.046726923611918325d, y: 0.6695117055599566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693471838321839d, y: 0.2693354665425688d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6473968394962883d, y: 0.9597281709682339d), new NpgsqlTypes.NpgsqlPoint(x: 0.31036412470601626d, y: 0.7363414539448158d), new NpgsqlTypes.NpgsqlPoint(x: 0.022892073880420027d, y: 0.8239363293931262d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08189069201005217d, y: 0.5813017636554011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5997069655633068d, y: 0.02989607457550214d), new NpgsqlTypes.NpgsqlPoint(x: 0.22791648995406455d, y: 0.7765021803475455d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8681802246676494d, y: 0.6359937759055971d), new NpgsqlTypes.NpgsqlPoint(x: 0.24590066112268227d, y: 0.4347445942069772d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768068787006269d, y: 0.09772017579625936d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.2554826347435132d, y: 0.30359088608428064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6237934388110574d, y: 0.7140833310031669d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068233545329917d, y: 0.006497781518349899d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5577422712503813d, y: 0.6971068940318346d), new NpgsqlTypes.NpgsqlPoint(x: 0.4782672906920433d, y: 0.45134644645901767d), new NpgsqlTypes.NpgsqlPoint(x: 0.2608484996616842d, y: 0.9075612333311145d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.273865333126603d, y: 0.9752992769086688d), new NpgsqlTypes.NpgsqlPoint(x: 0.778090224162017d, y: 0.6157494168738782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236240984544482d, y: 0.40739328049864143d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8901540474186783d, y: 0.6104807000915573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464861251494071d, y: 0.5905383024881494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507869568994969d, y: 0.040880882563808396d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7669911520607282d, y: 0.9019833772848408d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781618978837723d, y: 0.766848819001164d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818316119773597d, y: 0.8363386976786812d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7946636176459327d, y: 0.34004841428603405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846677040015811d, y: 0.29980737255293677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7912126458485089d, y: 0.1535764672479959d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7496232596413468d, y: 0.0755247601832707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7315985127278499d, y: 0.4335027625006398d), new NpgsqlTypes.NpgsqlPoint(x: 0.24027257021729065d, y: 0.6492460053050859d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4689980815706646d, y: 0.2946722782170702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655886971645881d, y: 0.6552777540380673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860136207192243d, y: 0.35986390875808694d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.05941758397566965d, y: 0.44772193441047603d), new NpgsqlTypes.NpgsqlPoint(x: 0.9942855272114643d, y: 0.8563250806323657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032970478761049d, y: 0.563707508914653d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.19769159952626802d, y: 0.3212868289202361d), new NpgsqlTypes.NpgsqlPoint(x: 0.14328435912560245d, y: 0.5010871772466384d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329911683924076d, y: 0.14600176830426648d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.09033925217166772d, y: 0.18583159002302285d), new NpgsqlTypes.NpgsqlPoint(x: 0.19252392938468033d, y: 0.468127871885884d), new NpgsqlTypes.NpgsqlPoint(x: 0.515143010000135d, y: 0.5889236122315685d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8146339503681812d, y: 0.7282687802370108d), new NpgsqlTypes.NpgsqlPoint(x: 0.18485677429279979d, y: 0.5049957898435247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621943156272392d, y: 0.005083494228512397d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.2877723363702531d, y: 0.09759702011038585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859006965060283d, y: 0.1099340845963328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3728944169429378d, y: 0.84603826384681d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.05853117244618089d, y: 0.5148660758856503d), new NpgsqlTypes.NpgsqlPoint(x: 0.42474520829094575d, y: 0.7805398573737212d), new NpgsqlTypes.NpgsqlPoint(x: 0.18086832560798838d, y: 0.8807927350644118d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7758031329493157d, y: 0.8308210070800339d), new NpgsqlTypes.NpgsqlPoint(x: 0.026234707245844424d, y: 0.4905969342247959d), new NpgsqlTypes.NpgsqlPoint(x: 0.13451984597422817d, y: 0.8032784480827033d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.4526905051036777d, y: 0.015359896180323851d), new NpgsqlTypes.NpgsqlPoint(x: 0.42265905614442023d, y: 0.543168947205911d), new NpgsqlTypes.NpgsqlPoint(x: 0.7102948968504622d, y: 0.22962106614611066d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.536126445266604d, y: 0.22400156553834583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6340367215411121d, y: 0.11338624948687404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7786384872209228d, y: 0.45744393907347025d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7943505280879416d, y: 0.12994312714046585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607853365159361d, y: 0.7633606522912928d), new NpgsqlTypes.NpgsqlPoint(x: 0.20388540120623755d, y: 0.9788117914606773d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.4024010069284406d, y: 0.5361707851919666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2756887351863391d, y: 0.5999106846654446d), new NpgsqlTypes.NpgsqlPoint(x: 0.8727728725693212d, y: 0.9240768407167621d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.14370934191284646d, y: 0.6919830280346938d), new NpgsqlTypes.NpgsqlPoint(x: 0.1418693091839771d, y: 0.6595088403275078d), new NpgsqlTypes.NpgsqlPoint(x: 0.06854576770685061d, y: 0.1963401115766421d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5927044661323461d, y: 0.7017901552432103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948726268119731d, y: 0.18424580982453986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531476691427871d, y: 0.2843782437517621d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7031649210575008d, y: 0.8289554691103255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5588298641337874d, y: 0.4130122603273727d), new NpgsqlTypes.NpgsqlPoint(x: 0.08609594548463595d, y: 0.613931479219538d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5565233295401211d, y: 0.313098415497323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5804102132176199d, y: 0.3209306337388479d), new NpgsqlTypes.NpgsqlPoint(x: 0.4234788594178295d, y: 0.21622314993212488d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7958282895437456d, y: 0.7989162708316034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9473506963117263d, y: 0.8114618848267903d), new NpgsqlTypes.NpgsqlPoint(x: 0.24969974028052322d, y: 0.7157123880202191d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.33139987531582293d, y: 0.1811620810876332d), new NpgsqlTypes.NpgsqlPoint(x: 0.8389294289675056d, y: 0.06366244670068055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7910023254582221d, y: 0.6311902211438036d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9948829605550764d, y: 0.9165463547812454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885323971081388d, y: 0.1598767725724599d), new NpgsqlTypes.NpgsqlPoint(x: 0.044748547905271274d, y: 0.8518996885194287d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32445858021997587d, y: 0.1663977216521697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5414954150765878d, y: 0.010093088840384623d), new NpgsqlTypes.NpgsqlPoint(x: 0.1580700226141657d, y: 0.4586095706404919d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8009628934441088d, y: 0.0575530287478796d), new NpgsqlTypes.NpgsqlPoint(x: 0.33504989602455937d, y: 0.29730203252737974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703575841810471d, y: 0.22370314417122705d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9665322129468213d, y: 0.2935063060286105d), new NpgsqlTypes.NpgsqlPoint(x: 0.024031181278887925d, y: 0.21045097148521452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746845752379217d, y: 0.5225547353324785d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6256014953917688d, y: 0.721985783760737d), new NpgsqlTypes.NpgsqlPoint(x: 0.803339448317436d, y: 0.34375393956598876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262401995045007d, y: 0.028376322782863284d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8092864581818208d, y: 0.15660141818450846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7446351456053685d, y: 0.15361451729718267d), new NpgsqlTypes.NpgsqlPoint(x: 0.986803969334314d, y: 0.6385504033974282d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5545011228116347d, y: 0.1747158288822097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974097037979633d, y: 0.9212246896023975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2256261699882991d, y: 0.13843884816054775d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9782852095523085d, y: 0.8323899960778101d), new NpgsqlTypes.NpgsqlPoint(x: 0.8475348647941324d, y: 0.8113605339189801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648533896361861d, y: 0.8618931189066892d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.23693038062436544d, y: 0.48345299037017087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4570601552228398d, y: 0.6932623046353477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8358276016420145d, y: 0.821532048240996d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.04138066152266873d, y: 0.9959480965836575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054271987326514d, y: 0.14918208836273938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162212711492605d, y: 0.5937083409660432d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7246536747850116d, y: 0.12085965839546553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486619489497728d, y: 0.48733726278008616d), new NpgsqlTypes.NpgsqlPoint(x: 0.20175500468706986d, y: 0.437065423817404d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.20942900029842149d, y: 0.7404102581780436d), new NpgsqlTypes.NpgsqlPoint(x: 0.4726310153340184d, y: 0.09152019576140558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788871479106646d, y: 0.22127735632676415d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8127787918778242d, y: 0.9697887141848333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2252950681800301d, y: 0.42409535390009057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807535132463977d, y: 0.38897044003016934d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5326473484400104d, y: 0.8754647410457531d), new NpgsqlTypes.NpgsqlPoint(x: 0.44938873265922874d, y: 0.4097609829300095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496557434759393d, y: 0.6872329906260711d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5148587767277611d, y: 0.3477652998468854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887104463922959d, y: 0.47565831002723025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575864033283716d, y: 0.8988233927651651d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6491014810283083d, y: 0.7377810336752924d), new NpgsqlTypes.NpgsqlPoint(x: 0.40888053766708266d, y: 0.6923301616580051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476211601413593d, y: 0.19167400264388412d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5666698122114684d, y: 0.18667003687692363d), new NpgsqlTypes.NpgsqlPoint(x: 0.35670254747289987d, y: 0.3981622000216951d), new NpgsqlTypes.NpgsqlPoint(x: 0.28561700518447475d, y: 0.5049352956315152d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7967635745596389d, y: 0.06787981318372771d), new NpgsqlTypes.NpgsqlPoint(x: 0.4671177487874554d, y: 0.04685827630882122d), new NpgsqlTypes.NpgsqlPoint(x: 0.980538455646799d, y: 0.2839690717171136d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.0569082361863148d, y: 0.8673866181711621d), new NpgsqlTypes.NpgsqlPoint(x: 0.6293186122541728d, y: 0.14606868137804974d), new NpgsqlTypes.NpgsqlPoint(x: 0.2156753856672362d, y: 0.6975060704401305d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5783203066710545d, y: 0.16846626401070064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221986080144322d, y: 0.15297522360485405d), new NpgsqlTypes.NpgsqlPoint(x: 0.3919245061529124d, y: 0.6952765282593624d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.37206221424583874d, y: 0.8145228602300381d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260666743687696d, y: 0.7645353109280026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013878691189193d, y: 0.6439878939453d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7965281754208223d, y: 0.2588902466787957d), new NpgsqlTypes.NpgsqlPoint(x: 0.0473012758100364d, y: 0.552510848167681d), new NpgsqlTypes.NpgsqlPoint(x: 0.39962887812212033d, y: 0.6461767621598298d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6688556258098218d, y: 0.7811066993308513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6094924524111475d, y: 0.2616701444868659d), new NpgsqlTypes.NpgsqlPoint(x: 0.3508792648506839d, y: 0.8326244803369975d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5089841394146931d, y: 0.2857983259063024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653151555286542d, y: 0.8484474537972775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944459497749468d, y: 0.6064732428766489d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7082420746370183d, y: 0.6065383309091223d), new NpgsqlTypes.NpgsqlPoint(x: 4.929359287719759E-05d, y: 0.2713285900635811d), new NpgsqlTypes.NpgsqlPoint(x: 0.06474853688099014d, y: 0.9588032184714286d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9766221916702859d, y: 0.7006063525020169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9506948617019639d, y: 0.18415628252838145d), new NpgsqlTypes.NpgsqlPoint(x: 0.37953728249704444d, y: 0.6717371896331791d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6959479661138183d, y: 0.7535705848176549d), new NpgsqlTypes.NpgsqlPoint(x: 0.6458889947386423d, y: 0.5765193898704939d), new NpgsqlTypes.NpgsqlPoint(x: 0.4578778228979725d, y: 0.14222966422150674d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2553007064757522d, y: 0.5462857097653739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5224324753113923d, y: 0.7888230164937732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259514244966547d, y: 0.4938971609757512d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4289624226937453d, y: 0.09540674284306372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653756090100505d, y: 0.4598785914071849d), new NpgsqlTypes.NpgsqlPoint(x: 0.05517016573608691d, y: 0.007521016051987073d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.964632742498826d, y: 0.568049827747997d), new NpgsqlTypes.NpgsqlPoint(x: 0.2676425067800312d, y: 0.012639317561099372d), new NpgsqlTypes.NpgsqlPoint(x: 0.14676291823662235d, y: 0.6630499923228629d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5261150670468596d, y: 0.8553456007517592d), new NpgsqlTypes.NpgsqlPoint(x: 0.7135763332001347d, y: 0.6612439430089656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766618998033473d, y: 0.2534028056121218d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5962848350747583d, y: 0.9441798387652971d), new NpgsqlTypes.NpgsqlPoint(x: 0.11642087821557612d, y: 0.08209495531621391d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905422609201185d, y: 0.43358045194817385d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.2750355107978881d, y: 0.6414136194291966d), new NpgsqlTypes.NpgsqlPoint(x: 0.8591905711626124d, y: 0.35005643814049103d), new NpgsqlTypes.NpgsqlPoint(x: 0.35085276938277743d, y: 0.7303598743941924d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.38928111290160705d, y: 0.40126875745107926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7625059019083517d, y: 0.25292112335301986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082285151230872d, y: 0.9483382391617793d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8078111448412768d, y: 0.09285281595924255d), new NpgsqlTypes.NpgsqlPoint(x: 0.09302784132313024d, y: 0.8911742114196273d), new NpgsqlTypes.NpgsqlPoint(x: 0.04178501157012349d, y: 0.06426608847234094d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.911927127843703d, y: 0.7264424697625823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9367595265873356d, y: 0.04799712659452149d), new NpgsqlTypes.NpgsqlPoint(x: 0.32963695498161105d, y: 0.7603067395594474d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.264929591588958d, y: 0.44810901824103666d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159028245301388d, y: 0.14280717018598688d), new NpgsqlTypes.NpgsqlPoint(x: 0.81102689615256d, y: 0.942029381641197d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2766353030691663d, y: 0.28623579033309d), new NpgsqlTypes.NpgsqlPoint(x: 0.805289760283412d, y: 0.760343886677928d), new NpgsqlTypes.NpgsqlPoint(x: 0.1586641278741433d, y: 0.19611132795632757d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.08151827139353018d, y: 0.2837442553348809d), new NpgsqlTypes.NpgsqlPoint(x: 0.07367998081975569d, y: 0.040115167118794925d), new NpgsqlTypes.NpgsqlPoint(x: 0.25443836291120214d, y: 0.8428680712430368d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8546573558974604d, y: 0.083556414425493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410653312525988d, y: 0.2051726696599776d), new NpgsqlTypes.NpgsqlPoint(x: 0.600451927306033d, y: 0.7597390956870348d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7164219568132267d, y: 0.5515628535770937d), new NpgsqlTypes.NpgsqlPoint(x: 0.42462869941914516d, y: 0.17024817784560353d), new NpgsqlTypes.NpgsqlPoint(x: 0.4896481164746179d, y: 0.3481109708195739d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.22279015891090825d, y: 0.8721420893405336d), new NpgsqlTypes.NpgsqlPoint(x: 0.026413138927999014d, y: 0.28733152470399526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859338297252882d, y: 0.4687014072466882d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.843564764759852d, y: 0.2689543664932027d), new NpgsqlTypes.NpgsqlPoint(x: 0.38249391063556337d, y: 0.01003494546965844d), new NpgsqlTypes.NpgsqlPoint(x: 0.07818294970121864d, y: 0.34238475168408855d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.13848678603850306d, y: 0.5731230455701212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8122039536980943d, y: 0.09052120391963414d), new NpgsqlTypes.NpgsqlPoint(x: 0.33002609747962397d, y: 0.8857601652015291d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.546312444118906d, y: 0.04273760254587178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5696853985005056d, y: 0.893016112837831d), new NpgsqlTypes.NpgsqlPoint(x: 0.48704825066938606d, y: 0.8846685246961815d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9071649250168976d, y: 0.07057991455943602d), new NpgsqlTypes.NpgsqlPoint(x: 0.20226242669735772d, y: 0.6927532069600233d), new NpgsqlTypes.NpgsqlPoint(x: 0.9896555669258273d, y: 0.19991912128130718d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7050280456162159d, y: 0.11547986501185847d), new NpgsqlTypes.NpgsqlPoint(x: 0.1426324704570815d, y: 0.46717026152518815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511870550400422d, y: 0.33931245941378707d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8773844221261392d, y: 0.7282768502494409d), new NpgsqlTypes.NpgsqlPoint(x: 0.32307916364014244d, y: 0.6762591630733213d), new NpgsqlTypes.NpgsqlPoint(x: 0.4958938660423352d, y: 0.6434493118884499d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10612942971788641d, y: 0.9476252207358065d), new NpgsqlTypes.NpgsqlPoint(x: 0.849403230237224d, y: 0.9350281480226609d), new NpgsqlTypes.NpgsqlPoint(x: 0.1972475710766305d, y: 0.7825658410502141d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.39826840711806477d, y: 0.08643834980087362d), new NpgsqlTypes.NpgsqlPoint(x: 0.93142294289646d, y: 0.7394550948620519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9088171231899963d, y: 0.03408577736864782d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.017170397748513477d, y: 0.5782434569523539d), new NpgsqlTypes.NpgsqlPoint(x: 0.2021007219369062d, y: 0.6378410207008821d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681747609034153d, y: 0.34332902079433514d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5869861364468971d, y: 0.09709504589413731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6148778997533417d, y: 0.07820347322158627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4024081837428529d, y: 0.12169417964188955d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6446153292988976d, y: 0.29577557988985803d), new NpgsqlTypes.NpgsqlPoint(x: 0.31637090517976174d, y: 0.7010423122771641d), new NpgsqlTypes.NpgsqlPoint(x: 0.7634334057138462d, y: 0.8417196635001966d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9995047778238159d, y: 0.12952365575951819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6017248948151684d, y: 0.016750083514363467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6617114287034336d, y: 0.635748321719728d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8976366947845446d, y: 0.7247713858773668d), new NpgsqlTypes.NpgsqlPoint(x: 0.14041201329964137d, y: 0.3398462210914278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6368001252688372d, y: 0.8768607329872686d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7096998035436374d, y: 0.2637817520761322d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516375424910213d, y: 0.35611959983959696d), new NpgsqlTypes.NpgsqlPoint(x: 0.005492890344680701d, y: 0.6822715820891421d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.39892882477822944d, y: 0.25993915699857684d), new NpgsqlTypes.NpgsqlPoint(x: 0.11405381510131929d, y: 0.7158539096467269d), new NpgsqlTypes.NpgsqlPoint(x: 0.030904536081243328d, y: 0.9662143412390429d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3053589653744522d, y: 0.1506446853232588d), new NpgsqlTypes.NpgsqlPoint(x: 0.4092049215313891d, y: 0.5110039647311749d), new NpgsqlTypes.NpgsqlPoint(x: 0.40837874333861945d, y: 0.6594001692312297d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9216317565829745d, y: 0.6125963162820832d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106992426116849d, y: 0.029824300905460066d), new NpgsqlTypes.NpgsqlPoint(x: 0.07371351358868217d, y: 0.9478998258537349d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8894374700197463d, y: 0.5905308875547676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6944575337549905d, y: 0.2583777851889185d), new NpgsqlTypes.NpgsqlPoint(x: 0.0613922510879652d, y: 0.4064993575279353d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8683200522278125d, y: 0.4576129944790298d), new NpgsqlTypes.NpgsqlPoint(x: 0.4076097113209909d, y: 0.6838229564120969d), new NpgsqlTypes.NpgsqlPoint(x: 0.3362253358511611d, y: 0.6092418818861436d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6655022407835577d, y: 0.12446688050915056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6639981993332752d, y: 0.3694582240107125d), new NpgsqlTypes.NpgsqlPoint(x: 0.18910427099350902d, y: 0.20847015638265576d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9636549816991345d, y: 0.4167757228263501d), new NpgsqlTypes.NpgsqlPoint(x: 0.4905534761994358d, y: 0.5032860491968474d), new NpgsqlTypes.NpgsqlPoint(x: 0.2099550515557138d, y: 0.35695006352512537d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.03479661989922411d, y: 0.384275805078263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7371465215558625d, y: 0.9430902077175992d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158245806184953d, y: 0.6497716115883033d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.42618052331164236d, y: 0.5960010031544386d), new NpgsqlTypes.NpgsqlPoint(x: 0.2235512030664749d, y: 0.12058942717467525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579163712743628d, y: 0.6489244893343572d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.4304803955745544d, y: 0.7807044152361456d), new NpgsqlTypes.NpgsqlPoint(x: 0.022841663319933203d, y: 0.2376531862821626d), new NpgsqlTypes.NpgsqlPoint(x: 0.15281657626075962d, y: 0.11264859235759728d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.29359945238925345d, y: 0.10695665252818876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5427086850963381d, y: 0.841647040092302d), new NpgsqlTypes.NpgsqlPoint(x: 0.11247648737634786d, y: 0.20278369615714775d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7884647133686509d, y: 0.35518903089372067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122130321348038d, y: 0.1753135834207098d), new NpgsqlTypes.NpgsqlPoint(x: 0.37528490927386404d, y: 0.8884441242311907d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8483346255771449d, y: 0.5771755924127648d), new NpgsqlTypes.NpgsqlPoint(x: 0.4000204437136431d, y: 0.7156002148220512d), new NpgsqlTypes.NpgsqlPoint(x: 0.5696632380597147d, y: 0.7104251268567952d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.26600222041298704d, y: 0.32146089117618815d), new NpgsqlTypes.NpgsqlPoint(x: 0.17598666648535644d, y: 0.8514938515978417d), new NpgsqlTypes.NpgsqlPoint(x: 0.40667958209339017d, y: 0.4981965642121956d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.050994258512329305d, y: 0.8788126571786752d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339290882007365d, y: 0.561622749083669d), new NpgsqlTypes.NpgsqlPoint(x: 0.19988650385092288d, y: 0.038298792931655834d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.07334433425932341d, y: 0.36170618218112693d), new NpgsqlTypes.NpgsqlPoint(x: 0.653568293467896d, y: 0.9331318318607427d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082678883780696d, y: 0.24057584661378817d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8326665207675578d, y: 0.46125371754736755d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561732607346157d, y: 0.09740297175055934d), new NpgsqlTypes.NpgsqlPoint(x: 0.25228826792475256d, y: 0.35712620138783513d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9840856968513266d, y: 0.6226147050407629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060308262094649d, y: 0.579244139456697d), new NpgsqlTypes.NpgsqlPoint(x: 0.26562909991525196d, y: 0.5823174550374411d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3868089404567481d, y: 0.4202665356178287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451289981870653d, y: 0.6879180300144088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3780442670798637d, y: 0.23447499455302978d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9312574286854578d, y: 0.06866634946767758d), new NpgsqlTypes.NpgsqlPoint(x: 0.28584391433478595d, y: 0.6243397607848936d), new NpgsqlTypes.NpgsqlPoint(x: 0.22577815613127517d, y: 0.14180902640176274d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.09723742740201746d, y: 0.30151848145063675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8611532368030507d, y: 0.019995648251481035d), new NpgsqlTypes.NpgsqlPoint(x: 0.4462929508094402d, y: 0.7582984432337083d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6512910005701329d, y: 0.31474533839270713d), new NpgsqlTypes.NpgsqlPoint(x: 0.41266319899516357d, y: 0.9762566084642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676069347555139d, y: 0.989185676013249d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.42401663202174333d, y: 0.43819211444576156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8533546350672139d, y: 0.4175154645980128d), new NpgsqlTypes.NpgsqlPoint(x: 0.1875055726585787d, y: 0.7179840867182903d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.607674844095953d, y: 0.6942604448894396d), new NpgsqlTypes.NpgsqlPoint(x: 0.15456364943970802d, y: 0.6283728458582046d), new NpgsqlTypes.NpgsqlPoint(x: 0.7123705874145017d, y: 0.10554334290755274d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.34842978200850194d, y: 0.9427044407953105d), new NpgsqlTypes.NpgsqlPoint(x: 0.08360213194152444d, y: 0.3649940497300287d), new NpgsqlTypes.NpgsqlPoint(x: 0.32928248153252826d, y: 0.7201256833341781d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4396253624244495d, y: 0.260051332132488d), new NpgsqlTypes.NpgsqlPoint(x: 0.041476085471955915d, y: 0.8497220779914917d), new NpgsqlTypes.NpgsqlPoint(x: 0.07951657283129598d, y: 0.781817184189179d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1258963502042606d, y: 0.16749321580381182d), new NpgsqlTypes.NpgsqlPoint(x: 0.21218151831838827d, y: 0.9404439785698643d), new NpgsqlTypes.NpgsqlPoint(x: 0.492657571956278d, y: 0.6014596405024982d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.056916008652714845d, y: 0.0536854659700845d), new NpgsqlTypes.NpgsqlPoint(x: 0.4283874893837737d, y: 0.8600831915863485d), new NpgsqlTypes.NpgsqlPoint(x: 0.4171646187453413d, y: 0.5346889272344905d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.15278987260881838d, y: 0.6639427969344558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9950316611907811d, y: 0.9686854008138038d), new NpgsqlTypes.NpgsqlPoint(x: 0.01999776240750939d, y: 0.4898739898789566d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6266524994139859d, y: 0.7522310371171597d), new NpgsqlTypes.NpgsqlPoint(x: 0.16202862633366444d, y: 0.45317802618788794d), new NpgsqlTypes.NpgsqlPoint(x: 0.18187832956480576d, y: 0.9442382387413155d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6781756397185296d, y: 0.9066652175351422d), new NpgsqlTypes.NpgsqlPoint(x: 0.39740738724150226d, y: 0.4299874211020581d), new NpgsqlTypes.NpgsqlPoint(x: 0.7804618800468099d, y: 0.567889962286362d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.47091573136127707d, y: 0.002942789577101479d), new NpgsqlTypes.NpgsqlPoint(x: 0.040042530150527056d, y: 0.25086742427136455d), new NpgsqlTypes.NpgsqlPoint(x: 0.36290511115368196d, y: 0.6795177646903287d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.14941986851568445d, y: 0.04920983558070313d), new NpgsqlTypes.NpgsqlPoint(x: 0.11408436781227393d, y: 0.25383823894415647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502379305592621d, y: 0.871543621392045d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7008113214303623d, y: 0.052941183769911415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559338196247139d, y: 0.34723954138604984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7384754384937385d, y: 0.014078609251762186d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5311689999320145d, y: 0.8442621377515975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518943262610676d, y: 0.08159716217235591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195847161778082d, y: 0.6237907207214948d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.19708212214741794d, y: 0.8916679719910054d), new NpgsqlTypes.NpgsqlPoint(x: 0.7232688118141637d, y: 0.6166327706491584d), new NpgsqlTypes.NpgsqlPoint(x: 0.44975291092857184d, y: 0.5845041499342098d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6160734312096968d, y: 0.7268090206719d), new NpgsqlTypes.NpgsqlPoint(x: 0.23888152971449406d, y: 0.48921045917790096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719265774315266d, y: 0.7326221002520017d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.23479790144601742d, y: 0.7283916333422317d), new NpgsqlTypes.NpgsqlPoint(x: 0.2168963970330383d, y: 0.8369057159479375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339098842791317d, y: 0.3220109622388543d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.06266399988793903d, y: 0.52517478219435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403068538181755d, y: 0.35433494794352893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577994062700447d, y: 0.48597224419480667d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.1694216627498374d, y: 0.7564567054951284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141144458774152d, y: 0.12137430792686543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702895929945216d, y: 0.8639595488121392d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1920889096318108d, y: 0.007675876661673908d), new NpgsqlTypes.NpgsqlPoint(x: 0.33103224063716696d, y: 0.6793872950446255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032143202464779d, y: 0.6688991725328024d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9544254410606277d, y: 0.9583039190424086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7039890929696927d, y: 0.48252543500372613d), new NpgsqlTypes.NpgsqlPoint(x: 0.754128604160997d, y: 0.3236071417960189d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.5911152463683063d, y: 0.48645554702926486d), new NpgsqlTypes.NpgsqlPoint(x: 0.2870008481614479d, y: 0.6438460237361283d), new NpgsqlTypes.NpgsqlPoint(x: 0.49185122512694057d, y: 0.12529102852505958d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2949449026052541d, y: 0.3716652298379193d), new NpgsqlTypes.NpgsqlPoint(x: 0.05271273056187609d, y: 0.3137050248714456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243905877989901d, y: 0.7171353620344096d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22088801636213862d, y: 0.58292254084871d), new NpgsqlTypes.NpgsqlPoint(x: 0.8846150332932361d, y: 0.11706532928397417d), new NpgsqlTypes.NpgsqlPoint(x: 0.42081715103857653d, y: 0.0899840295592994d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6254862329869234d, y: 0.4979102300949231d), new NpgsqlTypes.NpgsqlPoint(x: 0.8707827925495965d, y: 0.1876144240717228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036840169640262d, y: 0.6394842242519062d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2595627442101782d, y: 0.8800208827375025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7898932729283157d, y: 0.7574486525654162d), new NpgsqlTypes.NpgsqlPoint(x: 0.03119804544116611d, y: 0.7304022900274235d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7154307912524789d, y: 0.5701773256550096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901295172040692d, y: 0.7694675832598289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374671319313121d, y: 0.5811727546274212d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.07777961832806413d, y: 0.12691779498765332d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296030034489794d, y: 0.3186899249466253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6214852418341329d, y: 0.7856903167979893d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5131461566564617d, y: 0.29356910003726255d), new NpgsqlTypes.NpgsqlPoint(x: 0.04984521633624195d, y: 0.7181573951247079d), new NpgsqlTypes.NpgsqlPoint(x: 0.18008752872919487d, y: 0.2289803540674339d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4014982360538416d, y: 0.9114922147562248d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022372834159594d, y: 0.3256040345186184d), new NpgsqlTypes.NpgsqlPoint(x: 0.35246877673291765d, y: 0.2720127851803099d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.5560748787911453d, y: 0.3545077139552637d), new NpgsqlTypes.NpgsqlPoint(x: 0.3760880588366534d, y: 0.8140987306942185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304023758344543d, y: 0.16156526359280432d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7313968178002935d, y: 0.8788604506034347d), new NpgsqlTypes.NpgsqlPoint(x: 0.05203632236349964d, y: 0.3027697326713312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447394432108458d, y: 0.8877097203611967d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.747457648130757d, y: 0.26597251920909326d), new NpgsqlTypes.NpgsqlPoint(x: 0.4786817985273294d, y: 0.4900256555122897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784367014320613d, y: 0.05997445288136394d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.33453450437894916d, y: 0.4560163248651453d), new NpgsqlTypes.NpgsqlPoint(x: 0.19923315129681674d, y: 0.3846515104439481d), new NpgsqlTypes.NpgsqlPoint(x: 0.23209621828228844d, y: 0.3820874639171935d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3621272720856811d, y: 0.9503956176520034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9446078306377549d, y: 0.653902957824701d), new NpgsqlTypes.NpgsqlPoint(x: 0.0564211526220606d, y: 0.25158260932566623d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.24137202698544213d, y: 0.7641398289051654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8147993307286807d, y: 0.7485871012704967d), new NpgsqlTypes.NpgsqlPoint(x: 0.44378222748344787d, y: 0.5202132927104985d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.03979476439406615d, y: 0.9006406182861202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8532668357668298d, y: 0.13810712947169723d), new NpgsqlTypes.NpgsqlPoint(x: 0.2807719864820286d, y: 0.35649325499328377d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.18338302417331276d, y: 0.4061766806065815d), new NpgsqlTypes.NpgsqlPoint(x: 0.014918968587083303d, y: 0.34686281868028146d), new NpgsqlTypes.NpgsqlPoint(x: 0.3189106288126976d, y: 0.9558939465482025d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6717961954355623d, y: 0.6858555413852887d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779913078108399d, y: 0.5697469453841263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4252633059748139d, y: 0.6641454450049883d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7416042442337294d, y: 0.07586657915356632d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800603530804055d, y: 0.36615604767092114d), new NpgsqlTypes.NpgsqlPoint(x: 0.6334607624634152d, y: 0.7699675512793688d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.25285802508135213d, y: 0.5946797950110646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3796888569103143d, y: 0.6930679891438484d), new NpgsqlTypes.NpgsqlPoint(x: 0.38015866337486814d, y: 0.2620187931819896d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6937283106572282d, y: 0.09096406215487507d), new NpgsqlTypes.NpgsqlPoint(x: 0.10272295213407878d, y: 0.34993574244999137d), new NpgsqlTypes.NpgsqlPoint(x: 0.30735015148744227d, y: 0.027879313808426676d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.08344275598989126d, y: 0.3067162002387457d), new NpgsqlTypes.NpgsqlPoint(x: 0.973644547551921d, y: 0.05972496844463149d), new NpgsqlTypes.NpgsqlPoint(x: 0.19013838803057148d, y: 0.6893977292242659d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6757521945403788d, y: 0.08420617388639196d), new NpgsqlTypes.NpgsqlPoint(x: 0.593759664279632d, y: 0.9330389683461441d), new NpgsqlTypes.NpgsqlPoint(x: 0.19872292549964055d, y: 0.9900188199770389d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9216621008663215d, y: 0.024153747341275067d), new NpgsqlTypes.NpgsqlPoint(x: 0.1249721150306593d, y: 0.023233000932349257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486910557840454d, y: 0.6106175712874372d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6555174779696876d, y: 0.49725105613885556d), new NpgsqlTypes.NpgsqlPoint(x: 0.44802538315342744d, y: 0.06505781904371455d), new NpgsqlTypes.NpgsqlPoint(x: 0.11917197288659998d, y: 0.7577377564232014d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.09208019140812129d, y: 0.1506667786110798d), new NpgsqlTypes.NpgsqlPoint(x: 0.10186135546979702d, y: 0.14714539020936346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6412781550165857d, y: 0.8446902355357049d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.00342120865096629d, y: 0.22355765557231533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890894402014809d, y: 0.28563633557353096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3577342706930443d, y: 0.5930647481939944d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7243126948177572d, y: 0.409098619889095d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738032755380714d, y: 0.9695776960818392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9736954086273413d, y: 0.7672770412408114d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12191386156138351d, y: 0.045462211481992476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7873721828207951d, y: 0.8043745897572622d), new NpgsqlTypes.NpgsqlPoint(x: 0.29436207479424237d, y: 0.687940752142199d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1806597774717551d, y: 0.49490461728302637d), new NpgsqlTypes.NpgsqlPoint(x: 0.4247614167843894d, y: 0.28650988496273344d), new NpgsqlTypes.NpgsqlPoint(x: 0.044040445128595174d, y: 0.7194374783078628d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9252604215162619d, y: 0.0012310412886481492d), new NpgsqlTypes.NpgsqlPoint(x: 0.12634929877444434d, y: 0.8304450816299329d), new NpgsqlTypes.NpgsqlPoint(x: 0.35922676531328357d, y: 0.11441220449543021d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2131306081534291d, y: 0.9318295538703995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728417919062784d, y: 0.8130907169712622d), new NpgsqlTypes.NpgsqlPoint(x: 0.39639338882283126d, y: 0.20739944449523418d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.00043001341581772046d, y: 0.1540172321013198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634242393706248d, y: 0.32712232592160195d), new NpgsqlTypes.NpgsqlPoint(x: 0.558827447754139d, y: 0.9378212174126187d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5195981654427336d, y: 0.9410053033887638d), new NpgsqlTypes.NpgsqlPoint(x: 0.12760263766552826d, y: 0.6406874748103789d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257186889255939d, y: 0.6574331247391253d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8799898579309668d, y: 0.7546711530686876d), new NpgsqlTypes.NpgsqlPoint(x: 0.06188830842965298d, y: 0.5668135524839069d), new NpgsqlTypes.NpgsqlPoint(x: 0.31345981065151096d, y: 0.28294192389624806d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6884418314010124d, y: 0.028163877998216957d), new NpgsqlTypes.NpgsqlPoint(x: 0.32073356192076474d, y: 0.18311055495793527d), new NpgsqlTypes.NpgsqlPoint(x: 0.604935196953864d, y: 0.2973576722799993d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.21051877048604606d, y: 0.6226476434573878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486361241485163d, y: 0.18975698068057356d), new NpgsqlTypes.NpgsqlPoint(x: 0.33929591887085575d, y: 0.5237539579779732d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6730139805624465d, y: 0.7349291041044259d), new NpgsqlTypes.NpgsqlPoint(x: 0.007001889714192133d, y: 0.7730483811354442d), new NpgsqlTypes.NpgsqlPoint(x: 0.07260221926094912d, y: 0.5851056077952103d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5482164219999428d, y: 0.21960295036137034d), new NpgsqlTypes.NpgsqlPoint(x: 0.4863534753238541d, y: 0.5444435142359045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876805270379369d, y: 0.577781575663001d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.40105398277012405d, y: 0.1448230931552571d), new NpgsqlTypes.NpgsqlPoint(x: 0.435623993420747d, y: 0.8862447178006914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853638884217856d, y: 0.9685197641041655d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.47140900540890796d, y: 0.13749594828177336d), new NpgsqlTypes.NpgsqlPoint(x: 0.3560138171317745d, y: 0.013998836560727645d), new NpgsqlTypes.NpgsqlPoint(x: 0.637332132964864d, y: 0.49460956401557044d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9041949590247784d, y: 0.0872096959264359d), new NpgsqlTypes.NpgsqlPoint(x: 0.2943527250002529d, y: 0.864832195873502d), new NpgsqlTypes.NpgsqlPoint(x: 0.873434025801999d, y: 0.6443912694838719d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.1488481395405057d, y: 0.09515711224755563d), new NpgsqlTypes.NpgsqlPoint(x: 0.49630622292054205d, y: 0.8855353819069596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7950327054492384d, y: 0.8748615449018515d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.33617091996404047d, y: 0.02055299323751736d), new NpgsqlTypes.NpgsqlPoint(x: 0.13823294025077482d, y: 0.2900269617331659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7658845620971502d, y: 0.9956730041183611d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6292401006779834d, y: 0.5529601813322254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059383227061396d, y: 0.21670147593469002d), new NpgsqlTypes.NpgsqlPoint(x: 0.13903947367014435d, y: 0.9378470967172614d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.22800595240372368d, y: 0.25617117161060476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6608485592315938d, y: 0.1978067693908031d), new NpgsqlTypes.NpgsqlPoint(x: 0.2732073560699818d, y: 0.6638576295083397d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3023781453273583d, y: 0.19382270476671604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784163360055368d, y: 0.11379672879681779d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815613729827593d, y: 0.8406969381073139d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3967043607669912d, y: 0.07149343932837104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7260218696284937d, y: 0.44906278441916514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487530759411559d, y: 0.09812919858000424d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7182824902543268d, y: 0.6909823774241836d), new NpgsqlTypes.NpgsqlPoint(x: 0.20818758555076644d, y: 0.7903965001651255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135670058477922d, y: 0.9921184936075556d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.07473891489811768d, y: 0.9787892520137313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9453862802857732d, y: 0.8086614844139172d), new NpgsqlTypes.NpgsqlPoint(x: 0.013255488605008248d, y: 0.2103423051933243d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4627417544501964d, y: 0.7983262897645751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667913612360856d, y: 0.25866540175426933d), new NpgsqlTypes.NpgsqlPoint(x: 0.3529497115536949d, y: 0.4570815152347508d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9916814796810284d, y: 0.7456342743060334d), new NpgsqlTypes.NpgsqlPoint(x: 0.2665992531828728d, y: 0.22948943716866954d), new NpgsqlTypes.NpgsqlPoint(x: 0.10928501838385096d, y: 0.47387992819694424d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.44497396734380734d, y: 0.6745031939692624d), new NpgsqlTypes.NpgsqlPoint(x: 0.42043074473181374d, y: 0.755694428701013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621917751414874d, y: 0.39143841462807927d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3690124726595554d, y: 0.3119358379002485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440553193320719d, y: 0.5552136744942693d), new NpgsqlTypes.NpgsqlPoint(x: 0.43125726029183986d, y: 0.6568239842189194d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.13333584940043952d, y: 0.14768194911629529d), new NpgsqlTypes.NpgsqlPoint(x: 0.3926795587827159d, y: 0.5464151162503001d), new NpgsqlTypes.NpgsqlPoint(x: 0.2442466636013093d, y: 0.2787368818407735d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.41982966605195526d, y: 0.6290290687466903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290197410087237d, y: 0.8383047138115233d), new NpgsqlTypes.NpgsqlPoint(x: 0.038043736615383295d, y: 0.25902396682305984d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6926256971193914d, y: 0.030439745135570462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9298638945795364d, y: 0.47284588648058246d), new NpgsqlTypes.NpgsqlPoint(x: 0.17466390890105354d, y: 0.4830269922880347d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5386341634717285d, y: 0.21770374789433677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954051912694751d, y: 0.4439019466818609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6354746369762049d, y: 0.7126583024114873d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6220734669130753d, y: 0.740897498462283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7748549234952444d, y: 0.9327656620032788d), new NpgsqlTypes.NpgsqlPoint(x: 0.07783592966723918d, y: 0.2987056869117102d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2675729524459942d, y: 0.6528673300109827d), new NpgsqlTypes.NpgsqlPoint(x: 0.34704364549419775d, y: 0.18554170172986706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5886428211746224d, y: 0.1934314915306169d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8692283742573362d, y: 0.2930486870123262d), new NpgsqlTypes.NpgsqlPoint(x: 0.1996012776659174d, y: 0.178313937660722d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284401763757506d, y: 0.09800761823421733d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.06752929189732992d, y: 0.4864412865689579d), new NpgsqlTypes.NpgsqlPoint(x: 0.07831264407772187d, y: 0.15190033157491367d), new NpgsqlTypes.NpgsqlPoint(x: 0.4942745146864749d, y: 0.4489353029601999d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5488503650340858d, y: 0.3455433388481952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7349979931583548d, y: 0.2417898480665307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8885547376517147d, y: 0.43206580159498154d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.056248464338186976d, y: 0.6286804548123822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594028186727526d, y: 0.30967430268438667d), new NpgsqlTypes.NpgsqlPoint(x: 0.27474429621807184d, y: 0.2778621074364539d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9676406990604548d, y: 0.311371234134187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752546266333788d, y: 0.3332734181233442d), new NpgsqlTypes.NpgsqlPoint(x: 0.17603361381495497d, y: 0.2846596006266182d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5286279048246633d, y: 0.2628446524731468d), new NpgsqlTypes.NpgsqlPoint(x: 0.39208288865104046d, y: 0.20039875683013375d), new NpgsqlTypes.NpgsqlPoint(x: 0.49447599083661553d, y: 0.5059383292933892d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7991063534994125d, y: 0.36555044310941975d), new NpgsqlTypes.NpgsqlPoint(x: 0.783838862729787d, y: 0.9864326471339846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074347364477683d, y: 0.6514378116449512d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.09353493167508009d, y: 0.01231282981713766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8011389351971528d, y: 0.7092776089325779d), new NpgsqlTypes.NpgsqlPoint(x: 0.04131333850714791d, y: 0.057693232119479076d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.39228675663194723d, y: 0.5811405912134429d), new NpgsqlTypes.NpgsqlPoint(x: 0.17522272215238266d, y: 0.018110829686587726d), new NpgsqlTypes.NpgsqlPoint(x: 0.214140323895039d, y: 0.6155405917773955d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.731552913786923d, y: 0.23654556692927664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991834825622614d, y: 0.4544965205099225d), new NpgsqlTypes.NpgsqlPoint(x: 0.14812506201078712d, y: 0.7917496154059136d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9538526552445397d, y: 0.005275112967581097d), new NpgsqlTypes.NpgsqlPoint(x: 0.24286037347236733d, y: 0.5973977521605507d), new NpgsqlTypes.NpgsqlPoint(x: 0.42871034451716683d, y: 0.5886137553638022d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6486405054162082d, y: 0.09846614340976145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6788657755274731d, y: 0.4421805253590363d), new NpgsqlTypes.NpgsqlPoint(x: 0.270155121440257d, y: 0.3405945313755505d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6099976525364513d, y: 0.23730805444389913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187662535485217d, y: 0.7136018829254955d), new NpgsqlTypes.NpgsqlPoint(x: 0.648723638560429d, y: 0.9184766539157437d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9269234244538275d, y: 0.10414547294692811d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932902455949868d, y: 0.37123263820591856d), new NpgsqlTypes.NpgsqlPoint(x: 0.28175415881231736d, y: 0.4642946372167981d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8620274623157761d, y: 0.38811254305464127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418764410385747d, y: 0.22334512772776516d), new NpgsqlTypes.NpgsqlPoint(x: 0.768261787356506d, y: 0.6992791607919722d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3121372890156131d, y: 0.2748235396835357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7921374245208923d, y: 0.9322962523465551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7047075100644089d, y: 0.605499949860136d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.0036474998750255505d, y: 0.3994024652472189d), new NpgsqlTypes.NpgsqlPoint(x: 0.2191970944954118d, y: 0.5681970922832725d), new NpgsqlTypes.NpgsqlPoint(x: 0.7330704347304671d, y: 0.6297299955640883d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08480542922434608d, y: 0.4820988305868137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3516596141948405d, y: 0.6949642672654485d), new NpgsqlTypes.NpgsqlPoint(x: 0.30366248424791165d, y: 0.21347871655721806d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3689580372825426d, y: 0.48602848956649525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301833235300234d, y: 0.14691904729030958d), new NpgsqlTypes.NpgsqlPoint(x: 0.05299457680059627d, y: 0.34945268468788926d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3726631408987495d, y: 0.4647460805753939d), new NpgsqlTypes.NpgsqlPoint(x: 0.11775491938901161d, y: 0.4016371450191266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147071190957121d, y: 0.014072514320552232d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9681186973939415d, y: 0.6092755349406244d), new NpgsqlTypes.NpgsqlPoint(x: 0.10284919408087423d, y: 0.5413374177233516d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653148849563906d, y: 0.36111636687336524d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9645941184494932d, y: 0.770299380755984d), new NpgsqlTypes.NpgsqlPoint(x: 0.07908470180844474d, y: 0.8757843979746404d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610266407029095d, y: 0.6808188241381758d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2913577984859249d, y: 0.2929749242523071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784708849120074d, y: 0.09712634258065511d), new NpgsqlTypes.NpgsqlPoint(x: 0.37315760057342207d, y: 0.2912856182693032d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12898653899685208d, y: 0.06649620658063105d), new NpgsqlTypes.NpgsqlPoint(x: 0.244988544329091d, y: 0.6300965829597649d), new NpgsqlTypes.NpgsqlPoint(x: 0.694918369833703d, y: 0.4858878285698911d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.1327755036674001d, y: 0.6244865205014758d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032536520251196d, y: 0.5440125764555516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9767878584078237d, y: 0.22207355499401782d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8447278163944522d, y: 0.9914105824079326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2519181473000349d, y: 0.23158401408738571d), new NpgsqlTypes.NpgsqlPoint(x: 0.05017328278969757d, y: 0.048641727265069656d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5667368076826754d, y: 0.09353878742881827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369895466589601d, y: 0.44308868244527166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5008582951333984d, y: 0.7911215236040697d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.0814720515731816d, y: 0.3069049401697559d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957178253667688d, y: 0.8437517744358761d), new NpgsqlTypes.NpgsqlPoint(x: 0.04256354471634416d, y: 0.09819846735196547d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22022410320393015d, y: 0.0808652057245165d), new NpgsqlTypes.NpgsqlPoint(x: 0.631330004002257d, y: 0.9323758192712709d), new NpgsqlTypes.NpgsqlPoint(x: 0.3110239781479961d, y: 0.7369971915522341d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.07671840780654926d, y: 0.6729284106250001d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885152178485903d, y: 0.1248574302377522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985329617958254d, y: 0.8296294605251077d), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.2958427345002562d, y: 0.9400918507327409d), new NpgsqlTypes.NpgsqlPoint(x: 0.5441576343348452d, y: 0.009849420764278749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3912022711071723d, y: 0.37660937729402255d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2751345885911385d, y: 0.38321047673290376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415126668553769d, y: 0.7501294859488175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403218393216812d, y: 0.826579934511137d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9099916075844695d, y: 0.0018243013237442263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9741311838980644d, y: 0.9256173056436d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531737517630239d, y: 0.8914559212259953d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.1246069169248688d, y: 0.02361858224217006d), new NpgsqlTypes.NpgsqlPoint(x: 0.640597836670301d, y: 0.9013164274374863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910178548800388d, y: 0.5250910830458823d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2883656152282985d, y: 0.45553156787779425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2532789433651552d, y: 0.25387409633476166d), new NpgsqlTypes.NpgsqlPoint(x: 0.08694013852495541d, y: 0.7593942929127185d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.14658878212814563d, y: 0.17217990762973145d), new NpgsqlTypes.NpgsqlPoint(x: 0.5031942405382214d, y: 0.500607930544969d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664945870470955d, y: 0.45907140322562423d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.571046707072119d, y: 0.8147491681541258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058531460806211d, y: 0.1812693410727063d), new NpgsqlTypes.NpgsqlPoint(x: 0.4946428251708509d, y: 0.0786494298903836d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6327711597086237d, y: 0.5687333277566536d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643315712407551d, y: 0.1336765018266305d), new NpgsqlTypes.NpgsqlPoint(x: 0.3380717052637475d, y: 0.8392630166115034d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.15669078172092765d, y: 0.7877313603690911d), new NpgsqlTypes.NpgsqlPoint(x: 0.3193584776589714d, y: 0.852149478213207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551643449532606d, y: 0.09500407693170665d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.36344696581937685d, y: 0.21037941978763985d), new NpgsqlTypes.NpgsqlPoint(x: 0.6798169653304726d, y: 0.4843408380628099d), new NpgsqlTypes.NpgsqlPoint(x: 0.5058880909376348d, y: 0.32849658062956d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.42886042773987343d, y: 0.30151425787467634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047304679161787d, y: 0.9618205443286229d), new NpgsqlTypes.NpgsqlPoint(x: 0.11456196658143991d, y: 0.3502751434363831d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3324332082452517d, y: 0.9299689158593748d), new NpgsqlTypes.NpgsqlPoint(x: 0.06106432104427162d, y: 0.3648712436231958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964167590274962d, y: 0.07832628056012281d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3671891945861846d, y: 0.622186957492129d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888662171278272d, y: 0.12614838034906428d), new NpgsqlTypes.NpgsqlPoint(x: 0.24015461933528792d, y: 0.023769406195633835d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.604516906459504d, y: 0.6839034592409338d), new NpgsqlTypes.NpgsqlPoint(x: 0.1122622037250175d, y: 0.5361866794889655d), new NpgsqlTypes.NpgsqlPoint(x: 0.525027883487371d, y: 0.5857107195744968d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32943255349503575d, y: 0.4662612106258056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288672994509791d, y: 0.06340232369673116d), new NpgsqlTypes.NpgsqlPoint(x: 0.30661511532044783d, y: 0.19595910668998673d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.49436058013636264d, y: 0.588038793284963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8749575338340515d, y: 0.8381571812781959d), new NpgsqlTypes.NpgsqlPoint(x: 0.12863170692141623d, y: 0.7178547975367582d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10364053901520032d, y: 0.04526588163434275d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482888125724601d, y: 0.3127013152618173d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423935547589665d, y: 0.5167841339573167d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5415612921585458d, y: 0.24113643615977143d), new NpgsqlTypes.NpgsqlPoint(x: 0.41308177674165103d, y: 0.9734124062108032d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621666311760757d, y: 0.9125351067658565d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.07345111774437396d, y: 0.8710605587286571d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779419690123718d, y: 0.02946792114628749d), new NpgsqlTypes.NpgsqlPoint(x: 0.750224523989179d, y: 0.27737668771179214d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.341188103729552d, y: 0.7455889867528104d), new NpgsqlTypes.NpgsqlPoint(x: 0.15045945166917107d, y: 0.7863024447961622d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488583252855854d, y: 0.13398949259043014d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9624052506213605d, y: 0.46046100305911786d), new NpgsqlTypes.NpgsqlPoint(x: 0.1213567057335061d, y: 0.49007276172209524d), new NpgsqlTypes.NpgsqlPoint(x: 0.24848964299089438d, y: 0.5427509958753629d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6400470687666946d, y: 0.06336281354466666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2839237830072411d, y: 0.1419920638644515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6671615149886729d, y: 0.6551513130981194d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.06748245273434006d, y: 0.26714311099023236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6094218337826262d, y: 0.6995041862304537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882751174298884d, y: 0.9110722749574451d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.48697434788119975d, y: 0.5499482634047649d), new NpgsqlTypes.NpgsqlPoint(x: 0.29381587560970557d, y: 0.3010168940492671d), new NpgsqlTypes.NpgsqlPoint(x: 0.02567690817527546d, y: 0.46901924450883625d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6053268176283682d, y: 0.8279921507875674d), new NpgsqlTypes.NpgsqlPoint(x: 0.847646611292386d, y: 0.8389471102028977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793510268777975d, y: 0.2600839312165003d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7310238994827516d, y: 0.9910595099282885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7552163026596607d, y: 0.5653735882565364d), new NpgsqlTypes.NpgsqlPoint(x: 0.14172222589634065d, y: 0.5498916716928917d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1407331102507533d, y: 0.5715989535380036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2479526219235747d, y: 0.4176309788952315d), new NpgsqlTypes.NpgsqlPoint(x: 0.35375534383315743d, y: 0.17879962857679588d), }, }, },
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6133884065288945d, y: 0.19281025541428654d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918199944666945d, y: 0.9395314299523585d), new NpgsqlTypes.NpgsqlPoint(x: 0.612124663333973d, y: 0.6843566324063339d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.34182634245753307d, y: 0.21587515756852194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895346826421742d, y: 0.9023313668806194d), new NpgsqlTypes.NpgsqlPoint(x: 0.773608294098625d, y: 0.676290431365566d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8173984079477495d, y: 0.7414763640124573d), new NpgsqlTypes.NpgsqlPoint(x: 0.21737928840302756d, y: 0.8169087268311169d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058643211274947d, y: 0.29222136489119266d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.24682301866979017d, y: 0.5493168963960394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582937772931919d, y: 0.49451403521776827d), new NpgsqlTypes.NpgsqlPoint(x: 0.9404339628175532d, y: 0.5381128694303234d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9205192960676309d, y: 0.8225151711337043d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182549983984444d, y: 0.40513768369247893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923616982782482d, y: 0.28799326301439d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32788571820824675d, y: 0.9187064707688556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503847084795148d, y: 0.26051541539261114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4290213863693675d, y: 0.6729478238509363d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.45368423277936853d, y: 0.09839668305844707d), new NpgsqlTypes.NpgsqlPoint(x: 0.829881692629442d, y: 0.918828717630633d), new NpgsqlTypes.NpgsqlPoint(x: 0.74718160317258d, y: 0.9404673880981748d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9107247117197047d, y: 0.6550279407065759d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724891652958642d, y: 0.7249845565222454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635651314373891d, y: 0.3168145644078715d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.44302545627824186d, y: 0.6042399950129499d), new NpgsqlTypes.NpgsqlPoint(x: 0.3881066443843608d, y: 0.0907053695921719d), new NpgsqlTypes.NpgsqlPoint(x: 0.15175727276812712d, y: 0.787555672753809d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.3190837581806574d, y: 0.8886876840130129d), new NpgsqlTypes.NpgsqlPoint(x: 0.062477637984424295d, y: 0.6624165813173933d), new NpgsqlTypes.NpgsqlPoint(x: 0.002001214971828036d, y: 0.7572782734416003d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.014343316351814073d, y: 0.820661635233398d), new NpgsqlTypes.NpgsqlPoint(x: 0.1285865663036081d, y: 0.6327809658116623d), new NpgsqlTypes.NpgsqlPoint(x: 0.38318573014572044d, y: 0.48523288286074207d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7292714534179784d, y: 0.5858054362152058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6911023141980314d, y: 0.4438406973154071d), new NpgsqlTypes.NpgsqlPoint(x: 0.23080764139858612d, y: 0.6504943699119909d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.01133889403141064d, y: 0.028542708715725396d), new NpgsqlTypes.NpgsqlPoint(x: 0.5277086220855914d, y: 0.030805664352547057d), new NpgsqlTypes.NpgsqlPoint(x: 0.3706473370699497d, y: 0.4124692167691265d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7686394001575769d, y: 0.6843824102732147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8645833631947675d, y: 0.7568358795580306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5085436626171618d, y: 0.6921776071972184d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27646913740928314d, y: 0.7617316409475695d), new NpgsqlTypes.NpgsqlPoint(x: 0.3306893060518029d, y: 0.029262295963349505d), new NpgsqlTypes.NpgsqlPoint(x: 0.04113738536400502d, y: 0.9283870769068705d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9558999655122725d, y: 0.4439799153360696d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634304745423602d, y: 0.1889829440613432d), new NpgsqlTypes.NpgsqlPoint(x: 0.641918057941322d, y: 0.4629135073597318d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9666911692105064d, y: 0.8996807534477168d), new NpgsqlTypes.NpgsqlPoint(x: 0.38762081596800557d, y: 0.05724606504854013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789431037040657d, y: 0.7405145328025982d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.00601977868639203d, y: 0.08284520644810267d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792056028754489d, y: 0.3586629297485505d), new NpgsqlTypes.NpgsqlPoint(x: 0.25671174900189064d, y: 0.0625877257945745d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.6863376996081411d, y: 0.797558033100033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306629943585844d, y: 0.27365560866510796d), new NpgsqlTypes.NpgsqlPoint(x: 0.968467710343834d, y: 0.5436855452171653d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.055379219928457624d, y: 0.9471149497353281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411426481054076d, y: 0.7594204358837419d), new NpgsqlTypes.NpgsqlPoint(x: 0.39613603461869606d, y: 0.002846337905149654d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3277481593556947d, y: 0.04542474262664231d), new NpgsqlTypes.NpgsqlPoint(x: 0.26464924123155265d, y: 0.5968023244443549d), new NpgsqlTypes.NpgsqlPoint(x: 0.559548637965034d, y: 0.18296061511309136d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.4061480440725278d, y: 0.8886523873199779d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268287500578024d, y: 0.16795382217113486d), new NpgsqlTypes.NpgsqlPoint(x: 0.35277890414085333d, y: 0.24859517419306976d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9891850729677238d, y: 0.7612702045614672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636101504873315d, y: 0.4007728810410347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3350073444965035d, y: 0.2923588069919042d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9455027754728502d, y: 0.31936896991013364d), new NpgsqlTypes.NpgsqlPoint(x: 0.19815684076788065d, y: 0.0499543665995118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962205821080311d, y: 0.4974562253086686d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6357929975981678d, y: 0.719250413921022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856792660294104d, y: 0.5802389853040985d), new NpgsqlTypes.NpgsqlPoint(x: 0.06280605963615304d, y: 0.4898552882540823d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9419468875128332d, y: 0.49261252471088157d), new NpgsqlTypes.NpgsqlPoint(x: 0.14716091218895755d, y: 0.1784751161123186d), new NpgsqlTypes.NpgsqlPoint(x: 0.24171072198142196d, y: 0.16899875221812932d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6933706879738701d, y: 0.24160995124673657d), new NpgsqlTypes.NpgsqlPoint(x: 0.577448638515223d, y: 0.24938699894619898d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719286350430403d, y: 0.7905566541533333d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.5635607112288525d, y: 0.8721980039765651d), new NpgsqlTypes.NpgsqlPoint(x: 0.20349442399673534d, y: 0.063950563079613d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570385125891764d, y: 0.10931811646215905d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.13201471455161007d, y: 0.014440393241104132d), new NpgsqlTypes.NpgsqlPoint(x: 0.1526680567837828d, y: 0.7337006103603461d), new NpgsqlTypes.NpgsqlPoint(x: 0.7715375432235299d, y: 0.4619685182061153d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9007780600930032d, y: 0.10471218908220925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4472673427534605d, y: 0.13555409491488724d), new NpgsqlTypes.NpgsqlPoint(x: 0.4898700000361025d, y: 0.5915201579562217d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9765492097597609d, y: 0.8011635403262314d), new NpgsqlTypes.NpgsqlPoint(x: 0.06837643436552421d, y: 0.4025994663562622d), new NpgsqlTypes.NpgsqlPoint(x: 0.2538512890162016d, y: 0.22206401941491194d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.26066348382656856d, y: 0.8269647936872485d), new NpgsqlTypes.NpgsqlPoint(x: 0.48116268501935644d, y: 0.5062952035621109d), new NpgsqlTypes.NpgsqlPoint(x: 0.18016002920521645d, y: 0.7953303349722639d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3194645973866328d, y: 0.48305580573611373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1202459751946734d, y: 0.565261348886765d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833250769427085d, y: 0.9475325637760903d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.40939368167514634d, y: 0.5068874287074625d), new NpgsqlTypes.NpgsqlPoint(x: 0.23876925841773433d, y: 0.2611686024837617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039497390284247d, y: 0.5077097599314858d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7795911403010598d, y: 0.24331352373122428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6233474074628397d, y: 0.9559209615070371d), new NpgsqlTypes.NpgsqlPoint(x: 0.4482551207328135d, y: 0.2565835058544389d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9237421019546367d, y: 0.13917483715779144d), new NpgsqlTypes.NpgsqlPoint(x: 0.01787831503414694d, y: 0.8701983144788703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121594956456101d, y: 0.6791774344130463d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7493664799574444d, y: 0.1964234208412735d), new NpgsqlTypes.NpgsqlPoint(x: 0.024311182717423274d, y: 0.9184709610255013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134699915639816d, y: 0.4517056964974083d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.42850520869550157d, y: 0.6986050159610158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884171240862815d, y: 0.48066281365379726d), new NpgsqlTypes.NpgsqlPoint(x: 0.46622845042018357d, y: 0.7559961575838796d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7229860978747759d, y: 0.811328105819702d), new NpgsqlTypes.NpgsqlPoint(x: 0.4198586860960225d, y: 0.07278558217623776d), new NpgsqlTypes.NpgsqlPoint(x: 0.11092394023423902d, y: 0.5741395219791375d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5034907087684253d, y: 0.7775289019193231d), new NpgsqlTypes.NpgsqlPoint(x: 0.0714981857265693d, y: 0.9690125055204227d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873734321316669d, y: 0.017731182023821623d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.42137316894653964d, y: 0.44345472422998145d), new NpgsqlTypes.NpgsqlPoint(x: 0.22903077523952042d, y: 0.6901160964721897d), new NpgsqlTypes.NpgsqlPoint(x: 0.007938640463673097d, y: 0.26467861461541264d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5664211649793197d, y: 0.8697502775422097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310194330178766d, y: 0.16380149094123486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9421535065397465d, y: 0.5573472043595591d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3273052883357104d, y: 0.8601357750253735d), new NpgsqlTypes.NpgsqlPoint(x: 0.19051865076537622d, y: 0.0703665805908058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7648792984096299d, y: 0.9818748188905525d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9277989616272495d, y: 0.9340280007432772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936799088087863d, y: 0.9173277879780813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9615467435259784d, y: 0.6358019915544492d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45057365761448753d, y: 0.640702169667924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9838311411976375d, y: 0.7257021131377489d), new NpgsqlTypes.NpgsqlPoint(x: 0.506835164331502d, y: 0.8628569841943992d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.14092462825205d, y: 0.6244126509957882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6157055373788115d, y: 0.058002476748735377d), new NpgsqlTypes.NpgsqlPoint(x: 0.020078680596679388d, y: 0.7663295774050546d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9097900646918715d, y: 0.07375837277934871d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106180138070521d, y: 0.9985688694797231d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568684280495898d, y: 0.049757480359308826d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5839326800407408d, y: 0.08419782786053409d), new NpgsqlTypes.NpgsqlPoint(x: 0.5748177603410257d, y: 0.942502745760701d), new NpgsqlTypes.NpgsqlPoint(x: 0.487002248712298d, y: 0.3012736465877216d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5497633922487214d, y: 0.7040283996254906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399831760315273d, y: 0.1810667640023581d), new NpgsqlTypes.NpgsqlPoint(x: 0.48157924800891705d, y: 0.8411209517918472d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.027604659479084193d, y: 0.9820438446114563d), new NpgsqlTypes.NpgsqlPoint(x: 0.2718106122709024d, y: 0.9610512267621195d), new NpgsqlTypes.NpgsqlPoint(x: 0.32649898080234563d, y: 0.2642438819994718d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.46369884904643743d, y: 0.4797256028557785d), new NpgsqlTypes.NpgsqlPoint(x: 0.45652613495547667d, y: 0.32173517689886744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6579396229528067d, y: 0.3227719342085803d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6807272424292314d, y: 0.9247198324059211d), new NpgsqlTypes.NpgsqlPoint(x: 0.19987283143501167d, y: 0.8135763169934492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236809015431429d, y: 0.43526074476201004d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32971948676445484d, y: 0.473024155547224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7345136250098548d, y: 0.7854116382773839d), new NpgsqlTypes.NpgsqlPoint(x: 0.3705375627476404d, y: 0.30005857103114d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5331341442100594d, y: 0.25404458406984853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6075771244984488d, y: 0.41916449810996614d), new NpgsqlTypes.NpgsqlPoint(x: 0.83042902527901d, y: 0.8984067341044422d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.21438820131320246d, y: 0.6354965230571494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511216645628819d, y: 0.2972021264368233d), new NpgsqlTypes.NpgsqlPoint(x: 0.25035714330527936d, y: 0.10683871402210143d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9368211272818167d, y: 0.31915917202021304d), new NpgsqlTypes.NpgsqlPoint(x: 0.23540623301587316d, y: 0.6088986397504756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539007717492852d, y: 0.27563012421083244d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.41752917120294974d, y: 0.6654517581333299d), new NpgsqlTypes.NpgsqlPoint(x: 0.06899260781990457d, y: 0.5089299013936119d), new NpgsqlTypes.NpgsqlPoint(x: 0.06609017045195997d, y: 0.3705651114113667d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.763158155540126d, y: 0.4784470273503979d), new NpgsqlTypes.NpgsqlPoint(x: 0.24011300016057213d, y: 0.10497133818522753d), new NpgsqlTypes.NpgsqlPoint(x: 0.8966368914319036d, y: 0.9291441070918321d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9117514257545136d, y: 0.2887978420000745d), new NpgsqlTypes.NpgsqlPoint(x: 0.67490136681684d, y: 0.6815987770909819d), new NpgsqlTypes.NpgsqlPoint(x: 0.38354314658224253d, y: 0.3727668501101914d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.22011762501112309d, y: 0.1576818998427778d), new NpgsqlTypes.NpgsqlPoint(x: 0.8917433375663437d, y: 0.6646340827595383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5355467669598298d, y: 0.14843624141783462d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.13862393597726608d, y: 0.12523436208142724d), new NpgsqlTypes.NpgsqlPoint(x: 0.11173586647198086d, y: 0.6953015961191704d), new NpgsqlTypes.NpgsqlPoint(x: 0.710423762236664d, y: 0.4031761263083654d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.29352486613312456d, y: 0.3942935244886261d), new NpgsqlTypes.NpgsqlPoint(x: 0.24465382795887902d, y: 0.5707076546880936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572886115579824d, y: 0.6003115932519859d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.17615965832609315d, y: 0.20358678571324607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335796570357307d, y: 0.9984114452974138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141863368756217d, y: 0.9246042952765436d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.8060903842970418d, y: 0.5875510573885133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616836124138559d, y: 0.12396367407241049d), new NpgsqlTypes.NpgsqlPoint(x: 0.962931192724646d, y: 0.46115801236439313d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5403297431245553d, y: 0.8122970441036313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6366819564477777d, y: 0.7938314608631397d), new NpgsqlTypes.NpgsqlPoint(x: 0.634758212886926d, y: 0.4856414026878657d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.814912204559864d, y: 0.3859082591891584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802555352019984d, y: 0.3691611161039008d), new NpgsqlTypes.NpgsqlPoint(x: 0.18450432689332352d, y: 0.058141740718814505d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7388094791313045d, y: 0.7968530182406183d), new NpgsqlTypes.NpgsqlPoint(x: 0.3361583569830753d, y: 0.45184468038110115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218567880994492d, y: 0.2682289249334562d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.36343509156560405d, y: 0.7768523653313659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464126554385399d, y: 0.3507511272050594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7687329925027073d, y: 0.5342005112593846d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.15318790821570039d, y: 0.38152451153958666d), new NpgsqlTypes.NpgsqlPoint(x: 0.23891507413421964d, y: 0.20967707191329588d), new NpgsqlTypes.NpgsqlPoint(x: 0.9227057377979896d, y: 0.40171837226510043d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5962866810917593d, y: 0.3796744464301629d), new NpgsqlTypes.NpgsqlPoint(x: 0.08021694525240386d, y: 0.7647613201747764d), new NpgsqlTypes.NpgsqlPoint(x: 0.25816230137613816d, y: 0.5416353885829637d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7813241074796856d, y: 0.8566514526712891d), new NpgsqlTypes.NpgsqlPoint(x: 0.3811056061859013d, y: 0.28571940307128496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528966008202034d, y: 0.2304087018122316d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8854212655705657d, y: 0.7733204675720516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9543238985106611d, y: 0.5637954286985374d), new NpgsqlTypes.NpgsqlPoint(x: 0.27102432721732206d, y: 0.3062606183360673d), }, }, },
    ModelInner = new NpgsqlPointpointMMArrayD3E1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.2066033433434783d, y: 0.6110545887424789d), new NpgsqlTypes.NpgsqlPoint(x: 0.42631122557687906d, y: 0.04271974141738888d), new NpgsqlTypes.NpgsqlPoint(x: 0.23399121960518265d, y: 0.19116551874708443d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5971604392936024d, y: 0.3425597512981513d), new NpgsqlTypes.NpgsqlPoint(x: 0.46089140587553545d, y: 0.9055958444283984d), new NpgsqlTypes.NpgsqlPoint(x: 0.903453774295001d, y: 0.1513941786100843d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.15217341252670713d, y: 0.1629718518901191d), new NpgsqlTypes.NpgsqlPoint(x: 0.29648830056413145d, y: 0.3793778175518281d), new NpgsqlTypes.NpgsqlPoint(x: 0.12014162467740552d, y: 0.060432867839433135d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.25257963092639657d, y: 0.06961502172935852d), new NpgsqlTypes.NpgsqlPoint(x: 0.29502488000397364d, y: 0.05584388418469921d), new NpgsqlTypes.NpgsqlPoint(x: 0.9319996615134741d, y: 0.899121079575408d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.041328721588567374d, y: 0.6962556135524525d), new NpgsqlTypes.NpgsqlPoint(x: 0.21055877807954315d, y: 0.8865583585458174d), new NpgsqlTypes.NpgsqlPoint(x: 0.32439348949086666d, y: 0.8786124398836553d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.19771621503775783d, y: 0.09874885548500456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9338218441577855d, y: 0.13269217169259861d), new NpgsqlTypes.NpgsqlPoint(x: 0.2547513121796887d, y: 0.9699065375258188d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.8267285978148887d, y: 0.3878702419669564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3982992349230303d, y: 0.6207976580747294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975386744364785d, y: 0.5054607637508906d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4077505323439854d, y: 0.7301444025349471d), new NpgsqlTypes.NpgsqlPoint(x: 0.0849991400076302d, y: 0.15805014876499834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768004144246209d, y: 0.5392738867456529d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.03968069974421673d, y: 0.8213871317158362d), new NpgsqlTypes.NpgsqlPoint(x: 0.06827410006167178d, y: 0.7859320505224905d), new NpgsqlTypes.NpgsqlPoint(x: 0.9110690150610177d, y: 0.5363355163605676d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9270911968324572d, y: 0.612235138814286d), new NpgsqlTypes.NpgsqlPoint(x: 0.20799541443251113d, y: 0.3977352320707388d), new NpgsqlTypes.NpgsqlPoint(x: 0.9933287880631275d, y: 0.19885395937592232d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6449674961746925d, y: 0.6619770216597538d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584952505772983d, y: 0.13182259343415126d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325874108988547d, y: 0.4394342381758022d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2544367579503053d, y: 0.35510581819496845d), new NpgsqlTypes.NpgsqlPoint(x: 0.4999550837729596d, y: 0.3938156932820245d), new NpgsqlTypes.NpgsqlPoint(x: 0.6680177272098463d, y: 0.19911769389964717d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.20816804092346575d, y: 0.3641055900055803d), new NpgsqlTypes.NpgsqlPoint(x: 0.2845176181289426d, y: 0.433155254125532d), new NpgsqlTypes.NpgsqlPoint(x: 0.858536621390004d, y: 0.40660891733075477d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5592835542629485d, y: 0.2688592945265481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228723222432385d, y: 0.8337242223722553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511927630711741d, y: 0.07235497668043389d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3975359699666422d, y: 0.28160701539453525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996418763512004d, y: 0.8474062801337354d), new NpgsqlTypes.NpgsqlPoint(x: 0.7558716924835871d, y: 0.8215723612571348d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.11363708191890487d, y: 0.7194173002203912d), new NpgsqlTypes.NpgsqlPoint(x: 0.4879827488294235d, y: 0.027214664752539086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131231755102272d, y: 0.3908675208731851d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8362612635096807d, y: 0.7472928514513948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165681306234977d, y: 0.8321725986789905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8040545388054725d, y: 0.21323228062723243d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5045219096288677d, y: 0.8991904371586625d), new NpgsqlTypes.NpgsqlPoint(x: 0.15669738036194103d, y: 0.24473423433796326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920369601207907d, y: 0.7046140122166809d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD3E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9630248382275627d, y: 0.4314686201668315d), new NpgsqlTypes.NpgsqlPoint(x: 0.5950347274627829d, y: 0.45143796305490624d), new NpgsqlTypes.NpgsqlPoint(x: 0.393756719486799d, y: 0.4004163601637588d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2853937460849112d, y: 0.8278247484730406d), new NpgsqlTypes.NpgsqlPoint(x: 0.813383667550549d, y: 0.42747179103008515d), new NpgsqlTypes.NpgsqlPoint(x: 0.2769947193000415d, y: 0.9245940571542233d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9679562895168653d, y: 0.5473206526046007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8556090436378613d, y: 0.7777486538579786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7281547674117304d, y: 0.8587333887931922d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7318286392940212d, y: 0.520223105072768d), new NpgsqlTypes.NpgsqlPoint(x: 0.23441109953648642d, y: 0.24576175736684458d), new NpgsqlTypes.NpgsqlPoint(x: 0.24741081544575005d, y: 0.6030604362911887d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2057681082611338d, y: 0.011830584947807532d), new NpgsqlTypes.NpgsqlPoint(x: 0.94160754844765d, y: 0.3948583068709913d), new NpgsqlTypes.NpgsqlPoint(x: 0.19470783947883075d, y: 0.361114521895172d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4262261103510945d, y: 0.22604741741967227d), new NpgsqlTypes.NpgsqlPoint(x: 0.061750896507175024d, y: 0.41232225049763505d), new NpgsqlTypes.NpgsqlPoint(x: 0.015600224621025283d, y: 0.05688023229234851d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7691805439401426d, y: 0.4659214827873416d), new NpgsqlTypes.NpgsqlPoint(x: 0.8543449950742152d, y: 0.36304376917118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145903643913812d, y: 0.20589782718637129d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.41056372975349564d, y: 0.9995299671166963d), new NpgsqlTypes.NpgsqlPoint(x: 0.1464892629560257d, y: 0.7643797209840447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813138271140137d, y: 0.7227744664195106d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2746580114594419d, y: 0.7522975872481072d), new NpgsqlTypes.NpgsqlPoint(x: 0.028991148353774254d, y: 0.6362952892274378d), new NpgsqlTypes.NpgsqlPoint(x: 0.4547218010206725d, y: 0.8975820571301272d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.7030246273338736d, y: 0.9311019299483478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4675902958735202d, y: 0.2560579682841181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560977090111842d, y: 0.3499614394704469d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3773081012855394d, y: 0.45935591214452476d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620122520896637d, y: 0.20067801332204382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9857480146226245d, y: 0.33741034297570327d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7312196608524428d, y: 0.5664882891378272d), new NpgsqlTypes.NpgsqlPoint(x: 0.038216950438681896d, y: 0.6431860491755856d), new NpgsqlTypes.NpgsqlPoint(x: 0.47153753951866273d, y: 0.3523446606785162d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.4509562663931068d, y: 0.11070605221380236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796967828601662d, y: 0.34870282742796377d), new NpgsqlTypes.NpgsqlPoint(x: 0.048586069253228836d, y: 0.8829199725365431d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12255501948536784d, y: 0.9536348215865335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070131368856765d, y: 0.3498111830052799d), new NpgsqlTypes.NpgsqlPoint(x: 0.18944433548290052d, y: 0.9793836996369344d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6433131510769813d, y: 0.9587955057938103d), new NpgsqlTypes.NpgsqlPoint(x: 0.06751872592777752d, y: 0.24707174391461129d), new NpgsqlTypes.NpgsqlPoint(x: 0.7982968854622974d, y: 0.6796714275093751d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.1696965510485967d, y: 0.5587396879895746d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163306995732114d, y: 0.5366554273067805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413102881549283d, y: 0.4310310317307452d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7988969293767164d, y: 0.8549555650090915d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701459403417419d, y: 0.3947676306760688d), new NpgsqlTypes.NpgsqlPoint(x: 0.029355274178702984d, y: 0.11043759873610148d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6994046884832248d, y: 0.48460706590144864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036988550201592d, y: 0.9296179611325601d), new NpgsqlTypes.NpgsqlPoint(x: 0.8966973468169438d, y: 0.1829005469894307d), }, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd3e1mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd3e1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd3e1mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd3e1mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd3e1mi_id
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
    npgsqlpointpointmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
                NpgsqlTypes.NpgsqlPoint[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.2256659644989053d, y: 0.5610128272718277d), new NpgsqlTypes.NpgsqlPoint(x: 0.40535685944085376d, y: 0.8399107555618196d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458777905390753d, y: 0.7205100576213347d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9794744399967328d, y: 0.8964123994580893d), new NpgsqlTypes.NpgsqlPoint(x: 0.15961880513197124d, y: 0.6153260200474254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9607957092553373d, y: 0.37916355484936604d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4144402501284723d, y: 0.4274732470769126d), new NpgsqlTypes.NpgsqlPoint(x: 0.46889221792781555d, y: 0.4283337547832232d), new NpgsqlTypes.NpgsqlPoint(x: 0.46811228673384586d, y: 0.6439778235278079d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9090397081668743d, y: 0.6516546024605095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826331928982035d, y: 0.0055035695509886295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001106088968881d, y: 0.609318989896616d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.35792739382841954d, y: 0.00529143234414009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564041383299335d, y: 0.7959246065392934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692957497641371d, y: 0.16993833030865513d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6448428487857775d, y: 0.42574324873231906d), new NpgsqlTypes.NpgsqlPoint(x: 0.1553627672708382d, y: 0.4574105465455919d), new NpgsqlTypes.NpgsqlPoint(x: 0.4772258004525821d, y: 0.8376534873199412d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.6162227824231362d, y: 0.7891048620843344d), new NpgsqlTypes.NpgsqlPoint(x: 0.20712604752676445d, y: 0.3192399037739253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554543308294018d, y: 0.05303449372245006d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6125048659612684d, y: 0.6885955904240462d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408589503047346d, y: 0.5314471393867111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674368893488086d, y: 0.46865695656249073d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7766340409635114d, y: 0.23070107641925897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856946072008755d, y: 0.5067432599114311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628125676619132d, y: 0.22407364630937932d), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.024488430191275445d, y: 0.5085315756614425d), new NpgsqlTypes.NpgsqlPoint(x: 0.697498819057367d, y: 0.15187100349433313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3453487187918658d, y: 0.9695058089800613d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.25643414165592016d, y: 0.8840912193464663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3244851985065015d, y: 0.6235523976998231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174029767442382d, y: 0.8202209957152744d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.013885811846383711d, y: 0.6759455310468773d), new NpgsqlTypes.NpgsqlPoint(x: 0.3532772604749137d, y: 0.5666173335703952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3274461132643359d, y: 0.3311657397971428d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.39296787532503896d, y: 0.8321474472374352d), new NpgsqlTypes.NpgsqlPoint(x: 0.061690494590753264d, y: 0.13703062270005784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5125361993832216d, y: 0.3381793965182758d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7255001091182063d, y: 0.39002514569419444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322227250689368d, y: 0.314780026290043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646723308654466d, y: 0.7536470728153444d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8123991687651023d, y: 0.552177726819113d), new NpgsqlTypes.NpgsqlPoint(x: 0.015386528975754987d, y: 0.9957485409353443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147945911455281d, y: 0.24697188989938923d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.9546109661421011d, y: 0.22539229270664363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9383199352233538d, y: 0.40053138336065885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978767119281604d, y: 0.6537674562630411d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9575857731710105d, y: 0.8149600386505922d), new NpgsqlTypes.NpgsqlPoint(x: 0.034567427437302456d, y: 0.6556580527592293d), new NpgsqlTypes.NpgsqlPoint(x: 0.05141775324316422d, y: 0.34160232971496785d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10287687953488966d, y: 0.4749945555404629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998289216440151d, y: 0.5474077284139202d), new NpgsqlTypes.NpgsqlPoint(x: 0.39518987203079103d, y: 0.5367958978319451d), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.020736946101193032d, y: 0.19599988856856454d), new NpgsqlTypes.NpgsqlPoint(x: 0.14077779435972404d, y: 0.3681704449625317d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387345241894158d, y: 0.22533552205925522d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.35469756287167686d, y: 0.32491911619668823d), new NpgsqlTypes.NpgsqlPoint(x: 0.08703222448740167d, y: 0.25372545720762885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184857754360115d, y: 0.9779935382614718d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5874424575444055d, y: 0.5315400800964394d), new NpgsqlTypes.NpgsqlPoint(x: 0.06548741611892128d, y: 0.7623958137651565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785371361465514d, y: 0.4657585080037483d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.3012330902969307d, y: 0.4663425861120932d), new NpgsqlTypes.NpgsqlPoint(x: 0.03484084497920914d, y: 0.036552958917176914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801940153558431d, y: 0.9653625759386099d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9791166909362639d, y: 0.7610633941605862d), new NpgsqlTypes.NpgsqlPoint(x: 0.22214956593229962d, y: 0.2529518918331929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075110555256804d, y: 0.8778506078005657d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8486826124403776d, y: 0.49960101624506636d), new NpgsqlTypes.NpgsqlPoint(x: 0.02779207567622821d, y: 0.6813571270421931d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795128250385362d, y: 0.4461335221103724d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.14787826230640821d, y: 0.43798447069277135d), new NpgsqlTypes.NpgsqlPoint(x: 0.17994437903530303d, y: 0.7203623220503147d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867380077042968d, y: 0.17396336325204065d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7726548389088719d, y: 0.6826292069954779d), new NpgsqlTypes.NpgsqlPoint(x: 0.15129407375452164d, y: 0.13273354671566306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4615548709824554d, y: 0.9573375400739779d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.46462343236720705d, y: 0.4234070100590581d), new NpgsqlTypes.NpgsqlPoint(x: 0.8192991039644086d, y: 0.8927264220651222d), new NpgsqlTypes.NpgsqlPoint(x: 0.475565711170321d, y: 0.45106651645525686d), }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd3e1mi_id
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
    npgsqlpointpointmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd3e1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[,,] nullable = null;
                nullable =  ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,,] { { { new NpgsqlTypes.NpgsqlPoint(x: 0.9836090744157492d, y: 0.8989303612291769d), new NpgsqlTypes.NpgsqlPoint(x: 0.30788987796961964d, y: 0.7049847529830947d), new NpgsqlTypes.NpgsqlPoint(x: 0.003746036844740175d, y: 0.17077462212570715d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8011143903945898d, y: 0.15303027370979116d), new NpgsqlTypes.NpgsqlPoint(x: 0.21114051342328977d, y: 0.3987757135802432d), new NpgsqlTypes.NpgsqlPoint(x: 0.4728687372466228d, y: 0.15659358466313944d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9694161140430188d, y: 0.29279062551406043d), new NpgsqlTypes.NpgsqlPoint(x: 0.8469004898449489d, y: 0.037662953473365235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9233998225419981d, y: 0.8945151022385474d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.7206668067219747d, y: 0.19651570015600284d), new NpgsqlTypes.NpgsqlPoint(x: 0.07531699169114892d, y: 0.23078349340387094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751577085315846d, y: 0.28902446990628583d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5921498488656544d, y: 0.19007999967909806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7800812707279777d, y: 0.2799171532619684d), new NpgsqlTypes.NpgsqlPoint(x: 0.647235222413959d, y: 0.8498773862548109d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7320006310829673d, y: 0.9508548389734619d), new NpgsqlTypes.NpgsqlPoint(x: 0.16196406698551102d, y: 0.699035175375956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884632711339123d, y: 0.9047226674804398d), }, }, { { new NpgsqlTypes.NpgsqlPoint(x: 0.5355719894443527d, y: 0.9180986248836406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473253847520701d, y: 0.8564324652320445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9381543391091676d, y: 0.9869671646398266d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7450864873255832d, y: 0.8569758611852393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662906812110654d, y: 0.663178683896888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586276180542031d, y: 0.25851215205609446d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8063764690314481d, y: 0.5808323509443256d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935577494452771d, y: 0.7074803607612267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614619690024161d, y: 0.13169875272451703d), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,,] nullable = null;
                nullable = await ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointMArraypointMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD3E1M> models = null;

                models =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD3E1M> models = null;

                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M), typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd3e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M), typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd3e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M), typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                 ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                 ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 55;
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                 ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd3e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M), typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 28, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                 ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 134, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                 ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 149, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 63, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
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
FROM public.npgsqlpointpointmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD3E1M>();
                 ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 65, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD3E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd3e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd3e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 118, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 105, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((INpgsqlPointMArraypointMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                NpgsqlPointpointMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD3E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD3E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMMArrayD3E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
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
FROM public.binary_npgsqlpointpointmmarrayd3e1m m
LEFT JOIN public.binary_npgsqlpointpointmmarrayd3e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointMArraypointMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA), typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
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
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
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
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA), typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
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
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
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
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MI), typeof(NpgsqlPointpointMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MI>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MI>();
                ((INpgsqlPointMArraypointMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA), typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD3E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD3))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

