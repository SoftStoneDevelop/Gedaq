

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1850673160852213d, b: 0.07493937702396591d, c: 0.7807138881033503d),

new NpgsqlTypes.NpgsqlLine(a: 0.5171572452152303d, b: 0.5958404257171155d, c: 0.7466233121827592d),

new NpgsqlTypes.NpgsqlLine(a: 0.258490196635927d, b: 0.3345582400779773d, c: 0.7293899167445981d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1943040322399453d, b: 0.6052886508660301d, c: 0.9386295722710855d),

new NpgsqlTypes.NpgsqlLine(a: 0.5360014049399777d, b: 0.5916301831727773d, c: 0.9847832305169686d),

new NpgsqlTypes.NpgsqlLine(a: 0.5223526001008724d, b: 0.7755105983009289d, c: 0.5647374804034492d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8717112709030184d, b: 0.7179704159934155d, c: 0.09496956262939982d),

new NpgsqlTypes.NpgsqlLine(a: 0.10810303072941718d, b: 0.5093649908360207d, c: 0.21580452583568588d),

new NpgsqlTypes.NpgsqlLine(a: 0.0797458882621358d, b: 0.7628122688688618d, c: 0.45919868675894493d),

new NpgsqlTypes.NpgsqlLine(a: 0.9577613463661453d, b: 0.40443368142279157d, c: 0.7244647781180739d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12801648456950088d, b: 0.8074972030959066d, c: 0.74941829249263d),

new NpgsqlTypes.NpgsqlLine(a: 0.9168878787764932d, b: 0.25775812819256105d, c: 0.6706951062175958d),

new NpgsqlTypes.NpgsqlLine(a: 0.398430877605485d, b: 0.014682766761087152d, c: 0.5330339199789897d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6175142900907287d, b: 0.8062409726092905d, c: 0.922389806346243d),

new NpgsqlTypes.NpgsqlLine(a: 0.6864838655108559d, b: 0.48441061294610743d, c: 0.4507744693595407d),

new NpgsqlTypes.NpgsqlLine(a: 0.0832724035047705d, b: 0.7714349254186519d, c: 0.0943209885502787d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7333905711830461d, b: 0.8063900128369283d, c: 0.7672706585016693d),

new NpgsqlTypes.NpgsqlLine(a: 0.7207214915233839d, b: 0.4768674753212977d, c: 0.4104506731496024d),

new NpgsqlTypes.NpgsqlLine(a: 0.18550243534966737d, b: 0.16367413879149695d, c: 0.7104345539599487d),

new NpgsqlTypes.NpgsqlLine(a: 0.19414530647956296d, b: 0.7252225460551472d, c: 0.8963934468222391d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11307598923155404d, b: 0.9812384355498016d, c: 0.4223942024546319d),

new NpgsqlTypes.NpgsqlLine(a: 0.0757998072378494d, b: 0.11804089213230196d, c: 0.004537092743865934d),

new NpgsqlTypes.NpgsqlLine(a: 0.26342747505286146d, b: 0.8676285516827422d, c: 0.43180674673554d),

new NpgsqlTypes.NpgsqlLine(a: 0.5877983122091913d, b: 0.31047650215481803d, c: 0.9059736425671098d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5102213752612952d, b: 0.38388674915982934d, c: 0.26245159863760004d),

new NpgsqlTypes.NpgsqlLine(a: 0.5252049162228702d, b: 0.6159870524925576d, c: 0.4086091831524903d),

new NpgsqlTypes.NpgsqlLine(a: 0.7005613005904882d, b: 0.3814618500553366d, c: 0.5956561797779893d),

new NpgsqlTypes.NpgsqlLine(a: 0.8508361015054836d, b: 0.39574334403900935d, c: 0.5887979014561187d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9493899357471961d, b: 0.759196552360829d, c: 0.5265444163553907d),

new NpgsqlTypes.NpgsqlLine(a: 0.6875257896888356d, b: 0.11314423810871022d, c: 0.9436733723189472d),

new NpgsqlTypes.NpgsqlLine(a: 0.1794753717468187d, b: 0.21992027786758772d, c: 0.49615636136503505d),

new NpgsqlTypes.NpgsqlLine(a: 0.39504515784253724d, b: 0.10475751396326916d, c: 0.9031930625917707d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14413609313735365d, b: 0.47018444613349497d, c: 0.042905822573936936d),

new NpgsqlTypes.NpgsqlLine(a: 0.10028185209837837d, b: 0.6867733701074796d, c: 0.6827938840451928d),

new NpgsqlTypes.NpgsqlLine(a: 0.3706429627493847d, b: 0.9228305040672102d, c: 0.5209576092100809d),

new NpgsqlTypes.NpgsqlLine(a: 0.8358090081391196d, b: 0.5866939419035148d, c: 0.23319743471816434d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05101573985599872d, b: 0.8741883036378957d, c: 0.6554251511186207d),

new NpgsqlTypes.NpgsqlLine(a: 0.7355322076904423d, b: 0.9181114484748125d, c: 0.6409517650992708d),

new NpgsqlTypes.NpgsqlLine(a: 0.03949778597503617d, b: 0.3242666125369994d, c: 0.6152301356772277d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2324130902612075d, b: 0.7342444069964952d, c: 0.8078515974381103d),

new NpgsqlTypes.NpgsqlLine(a: 0.8846774897141086d, b: 0.3676636829008123d, c: 0.48121748224201133d),

new NpgsqlTypes.NpgsqlLine(a: 0.14403730616488153d, b: 0.9177533281174134d, c: 0.05591485281266062d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32209372599221087d, b: 0.7526015726564766d, c: 0.09838866604962848d),

new NpgsqlTypes.NpgsqlLine(a: 0.04154675295280863d, b: 0.7317274628575167d, c: 0.9075192528018602d),

new NpgsqlTypes.NpgsqlLine(a: 0.3428984680774676d, b: 0.2548018887367203d, c: 0.5284418981699918d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2732214197662749d, b: 0.8245405354232245d, c: 0.41530401183916066d),

new NpgsqlTypes.NpgsqlLine(a: 0.3859015463233215d, b: 0.5908826733124016d, c: 0.18834935091893712d),

new NpgsqlTypes.NpgsqlLine(a: 0.7373717614640952d, b: 0.04295609434727776d, c: 0.7006508472770234d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23201366522048028d, b: 0.8619950638107942d, c: 0.6863995435400545d),

new NpgsqlTypes.NpgsqlLine(a: 0.2707909399075814d, b: 0.8692410156864457d, c: 0.4991390601596133d),

new NpgsqlTypes.NpgsqlLine(a: 0.2329646715011685d, b: 0.4154689951278049d, c: 0.4911064379600756d),

new NpgsqlTypes.NpgsqlLine(a: 0.8684943197287261d, b: 0.20678251159338967d, c: 0.7619974624269583d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.030373439809355807d, b: 0.14502008738874894d, c: 0.7444273795991915d),

new NpgsqlTypes.NpgsqlLine(a: 0.917501943436537d, b: 0.7826829720143765d, c: 0.19736553637177312d),

new NpgsqlTypes.NpgsqlLine(a: 0.6187683197284835d, b: 0.08294314779068879d, c: 0.407166263632898d),

new NpgsqlTypes.NpgsqlLine(a: 0.1395906699527132d, b: 0.7501510399416167d, c: 0.8871092508287913d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32431397103321924d, b: 0.8267732093841127d, c: 0.4918593731354698d),

new NpgsqlTypes.NpgsqlLine(a: 0.37657275544511004d, b: 0.8962893584291599d, c: 0.5469009771801245d),

new NpgsqlTypes.NpgsqlLine(a: 0.10710586459039384d, b: 0.7797232953048632d, c: 0.8975872482389485d),

new NpgsqlTypes.NpgsqlLine(a: 0.1981243595547042d, b: 0.43735303259326475d, c: 0.734710048884708d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5032702199006881d, b: 0.49129949403053186d, c: 0.2683714452894663d),

new NpgsqlTypes.NpgsqlLine(a: 0.1275971119606577d, b: 0.3910854523473194d, c: 0.41946974104133117d),

new NpgsqlTypes.NpgsqlLine(a: 0.7988545709966233d, b: 0.8204393844535681d, c: 0.03366941780922261d),

new NpgsqlTypes.NpgsqlLine(a: 0.7453583474769433d, b: 0.995927079223984d, c: 0.20384415491127994d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07946884543616806d, b: 0.09034034411051983d, c: 0.9347235449207034d),

new NpgsqlTypes.NpgsqlLine(a: 0.7819803371375271d, b: 0.3805784045415501d, c: 0.4026536769313317d),

new NpgsqlTypes.NpgsqlLine(a: 0.07470460431903558d, b: 0.27602048664587564d, c: 0.40983689118340394d),

new NpgsqlTypes.NpgsqlLine(a: 0.4023105110824259d, b: 0.1907179855554263d, c: 0.6497971120083571d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7201068053447417d, b: 0.6691225459742559d, c: 0.6471711913790208d),

new NpgsqlTypes.NpgsqlLine(a: 0.7741516555019494d, b: 0.46450711941733847d, c: 0.7938057101648277d),

new NpgsqlTypes.NpgsqlLine(a: 0.3479221531818909d, b: 0.016719584823397304d, c: 0.8772752332393295d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5800481746334958d, b: 0.8737497930004839d, c: 0.29246477314979946d),

new NpgsqlTypes.NpgsqlLine(a: 0.3110959612370786d, b: 0.5031667307245297d, c: 0.6465482068304246d),

new NpgsqlTypes.NpgsqlLine(a: 0.23108103046905637d, b: 0.9029687827783317d, c: 0.8858532243039883d),

new NpgsqlTypes.NpgsqlLine(a: 0.5732011438916074d, b: 0.8848698484060938d, c: 0.3000507761641861d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45718658756343755d, b: 0.8295480568059439d, c: 0.7494457501841469d),

new NpgsqlTypes.NpgsqlLine(a: 0.574841823744743d, b: 0.19163054311423988d, c: 0.37315689556004694d),

new NpgsqlTypes.NpgsqlLine(a: 0.28650580421794836d, b: 0.7918919718661911d, c: 0.5141330515727945d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4920464027175846d, b: 0.8072283712006583d, c: 0.05917905027732484d),

new NpgsqlTypes.NpgsqlLine(a: 0.6276899118124336d, b: 0.627611715164108d, c: 0.6500333831237238d),

new NpgsqlTypes.NpgsqlLine(a: 0.6655446442038656d, b: 0.8574979084853066d, c: 0.4063303287087203d),

new NpgsqlTypes.NpgsqlLine(a: 0.33949342690686335d, b: 0.7268787225632114d, c: 0.2595236356348932d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9499919444230523d, b: 0.9230949487018965d, c: 0.8495019599307847d),

new NpgsqlTypes.NpgsqlLine(a: 0.16094334795467158d, b: 0.12644446602202009d, c: 0.3396069194243687d),

new NpgsqlTypes.NpgsqlLine(a: 0.9581096488127758d, b: 0.2232666985275079d, c: 0.12308922601108285d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5849324366050652d, b: 0.0381571847447314d, c: 0.5469860821811985d),

new NpgsqlTypes.NpgsqlLine(a: 0.03706624135673797d, b: 0.6690732124095602d, c: 0.9921154311666286d),

new NpgsqlTypes.NpgsqlLine(a: 0.829667497600382d, b: 0.3839516360139493d, c: 0.26993016680204973d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7328857812816789d, b: 0.07543220469989698d, c: 0.17176889007868934d),

new NpgsqlTypes.NpgsqlLine(a: 0.26065425758883953d, b: 0.4408011549054701d, c: 0.31947357134664456d),

new NpgsqlTypes.NpgsqlLine(a: 0.30842633276220344d, b: 0.4921932264803709d, c: 0.7553396138474726d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08677679201541166d, b: 0.7844227868322662d, c: 0.4026280753096867d),

new NpgsqlTypes.NpgsqlLine(a: 0.2910688550373779d, b: 0.5460399845223884d, c: 0.8167739804299012d),

new NpgsqlTypes.NpgsqlLine(a: 0.07421227381836448d, b: 0.8580554204153479d, c: 0.29329987378950084d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14486735375838d, b: 0.19890538516860357d, c: 0.25132564520266754d),

new NpgsqlTypes.NpgsqlLine(a: 0.7967708984105334d, b: 0.43168123604645303d, c: 0.006633334626111598d),

new NpgsqlTypes.NpgsqlLine(a: 0.6032073655693402d, b: 0.8476831089695158d, c: 0.7700532372438413d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13803332280721947d, b: 0.7319317523001728d, c: 0.9561753778783182d),

new NpgsqlTypes.NpgsqlLine(a: 0.4064138821537815d, b: 0.7730315380323606d, c: 0.41887342527103766d),

new NpgsqlTypes.NpgsqlLine(a: 0.1795857523219786d, b: 0.9848349624969025d, c: 0.5905403977500264d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8777421768098683d, b: 0.3458304114476065d, c: 0.0736604405459319d),

new NpgsqlTypes.NpgsqlLine(a: 0.8053585381125676d, b: 0.609498286711035d, c: 0.4512171886497095d),

new NpgsqlTypes.NpgsqlLine(a: 0.6608280217234208d, b: 0.7074095388474853d, c: 0.11336195941881733d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4141605897823172d, b: 0.5536324427123255d, c: 0.18346993070091566d),

new NpgsqlTypes.NpgsqlLine(a: 0.36823254178507814d, b: 0.36278785866253327d, c: 0.9245401940353231d),

new NpgsqlTypes.NpgsqlLine(a: 0.3415007807447742d, b: 0.24269472359095212d, c: 0.9284776560052271d),

new NpgsqlTypes.NpgsqlLine(a: 0.2979349830417396d, b: 0.8363349556115358d, c: 0.3537224009713763d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4478570611993187d, b: 0.6123229152011707d, c: 0.769945068972576d),

new NpgsqlTypes.NpgsqlLine(a: 0.8443696290065666d, b: 0.2749490372258149d, c: 0.5970432010391723d),

new NpgsqlTypes.NpgsqlLine(a: 0.3195952437402737d, b: 0.5233732759480807d, c: 0.9875871922169644d),

new NpgsqlTypes.NpgsqlLine(a: 0.278554537143649d, b: 0.6584933301892593d, c: 0.20220555594269918d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6667554217487601d, b: 0.6985998082367658d, c: 0.7458347851439329d),

new NpgsqlTypes.NpgsqlLine(a: 0.20761011806669183d, b: 0.07115099363250432d, c: 0.13609130182197415d),

new NpgsqlTypes.NpgsqlLine(a: 0.2501822340358051d, b: 0.7267333912535919d, c: 0.1581128093824593d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.024321962302708444d, b: 0.29009945925681146d, c: 0.6932269056751261d),

new NpgsqlTypes.NpgsqlLine(a: 0.09715974177562858d, b: 0.48990411750937424d, c: 0.7816845445390994d),

new NpgsqlTypes.NpgsqlLine(a: 0.4964347311582694d, b: 0.9027241588407876d, c: 0.5123158128957196d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21039505306330575d, b: 0.9757965601526145d, c: 0.6510771138623898d),

new NpgsqlTypes.NpgsqlLine(a: 0.3361062910473229d, b: 0.09045587792810994d, c: 0.16896824046555314d),

new NpgsqlTypes.NpgsqlLine(a: 0.08786782301534735d, b: 0.2170402539548728d, c: 0.9532452796193792d),

new NpgsqlTypes.NpgsqlLine(a: 0.2903006366441616d, b: 0.10677996941287471d, c: 0.11126978571117174d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9545481017917902d, b: 0.3951134981784514d, c: 0.5851953232446743d),

new NpgsqlTypes.NpgsqlLine(a: 0.4446909838130858d, b: 0.9702020133725695d, c: 0.9209914987676175d),

new NpgsqlTypes.NpgsqlLine(a: 0.6933187256491997d, b: 0.15096242452634523d, c: 0.346328090587391d),

new NpgsqlTypes.NpgsqlLine(a: 0.3893576827081816d, b: 0.9134305474072844d, c: 0.8032115064108711d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35628140068456027d, b: 0.6704325281666189d, c: 0.4535099613062785d),

new NpgsqlTypes.NpgsqlLine(a: 0.6125833860134041d, b: 0.18874861693616252d, c: 0.033420269168901506d),

new NpgsqlTypes.NpgsqlLine(a: 0.8946914520904233d, b: 0.17597511204712424d, c: 0.8759024275532744d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7993482350437321d, b: 0.447682894808083d, c: 0.620855500573592d),

new NpgsqlTypes.NpgsqlLine(a: 0.03254151175239528d, b: 0.8306418274851937d, c: 0.7253580255480733d),

new NpgsqlTypes.NpgsqlLine(a: 0.20960456485249745d, b: 0.05051807370476169d, c: 0.8757917271606253d),

new NpgsqlTypes.NpgsqlLine(a: 0.5608710249476917d, b: 0.0452193201096015d, c: 0.6253055937447106d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6801361728920235d, b: 0.8217460194711395d, c: 0.9292615985295699d),

new NpgsqlTypes.NpgsqlLine(a: 0.4425248805242683d, b: 0.4052134003039224d, c: 0.3159761150858975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4109845982167155d, b: 0.37604124327418675d, c: 0.3541753192963135d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48229910846822044d, b: 0.7802554406278357d, c: 0.4136638664016319d),

new NpgsqlTypes.NpgsqlLine(a: 0.2447078175555505d, b: 0.23326914842432434d, c: 0.4439882896934284d),

new NpgsqlTypes.NpgsqlLine(a: 0.33203139853283503d, b: 0.10814294509195843d, c: 0.6650086554655096d),

new NpgsqlTypes.NpgsqlLine(a: 0.327858431955922d, b: 0.3272816187347367d, c: 0.7714036475437126d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4062093365829136d, b: 0.35913786990553853d, c: 0.7557423447835092d),

new NpgsqlTypes.NpgsqlLine(a: 0.3873777347074109d, b: 0.057987646823774996d, c: 0.8547242211084823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5577411530521116d, b: 0.6874006758801378d, c: 0.8204809436555645d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04519508193660593d, b: 0.3155365904181573d, c: 0.4359902844567338d),

new NpgsqlTypes.NpgsqlLine(a: 0.5896149481288169d, b: 0.5741141581930431d, c: 0.5898366043553233d),

new NpgsqlTypes.NpgsqlLine(a: 0.6610999664523476d, b: 0.713061411373601d, c: 0.6442148563030583d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.29353935276939125d, b: 0.8593905446199783d, c: 0.21947348685408308d),

new NpgsqlTypes.NpgsqlLine(a: 0.4334332797853826d, b: 0.7285670756219127d, c: 0.7925009473334867d),

new NpgsqlTypes.NpgsqlLine(a: 0.03143538073512053d, b: 0.09384420910835767d, c: 0.3080471950082939d),

new NpgsqlTypes.NpgsqlLine(a: 0.014312650228100132d, b: 0.23701069052132584d, c: 0.3233140553765884d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7421383329574982d, b: 0.2984319441862211d, c: 0.7393801888027497d),

new NpgsqlTypes.NpgsqlLine(a: 0.8437581520377823d, b: 0.9632133847334173d, c: 0.10433830071366057d),

new NpgsqlTypes.NpgsqlLine(a: 0.6922281315471136d, b: 0.8612652642438532d, c: 0.6121807880997441d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5238068287597254d, b: 0.4218059464779498d, c: 0.5378748437468674d),

new NpgsqlTypes.NpgsqlLine(a: 0.6806713066935266d, b: 0.2577855206179518d, c: 0.3166154249329507d),

new NpgsqlTypes.NpgsqlLine(a: 0.0967471618631448d, b: 0.1336698326052408d, c: 0.6813133010086376d),

new NpgsqlTypes.NpgsqlLine(a: 0.5553348585920874d, b: 0.8969202805930456d, c: 0.9372986815747827d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3840261614504741d, b: 0.3933511569780821d, c: 0.30769313855097546d),

new NpgsqlTypes.NpgsqlLine(a: 0.4172027619557479d, b: 0.2796631642150105d, c: 0.7176682317901993d),

new NpgsqlTypes.NpgsqlLine(a: 0.8070702389986633d, b: 0.03577352294079428d, c: 0.3486338203332169d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7777835261129407d, b: 0.9245217741712225d, c: 0.8200190511148621d),

new NpgsqlTypes.NpgsqlLine(a: 0.9940143240199899d, b: 0.44895086703819875d, c: 0.6017421595215916d),

new NpgsqlTypes.NpgsqlLine(a: 0.8765921156207255d, b: 0.8889148026398503d, c: 0.9886326495309922d),

new NpgsqlTypes.NpgsqlLine(a: 0.8674279987331002d, b: 0.43846796716298786d, c: 0.42878481690299675d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02422773135770473d, b: 0.34494537491914823d, c: 0.883427107325001d),

new NpgsqlTypes.NpgsqlLine(a: 0.42770635566956927d, b: 0.12570116085433802d, c: 0.7443920580635907d),

new NpgsqlTypes.NpgsqlLine(a: 0.09608605923411084d, b: 0.6362780864822855d, c: 0.3690465684515567d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9020651136710461d, b: 0.1759785881156728d, c: 0.20381983719678165d),

new NpgsqlTypes.NpgsqlLine(a: 0.7815160112692682d, b: 0.33099661989601126d, c: 0.8326201471125555d),

new NpgsqlTypes.NpgsqlLine(a: 0.03477376461119175d, b: 0.5104080146128831d, c: 0.8162561898842511d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.046739881102462744d, b: 0.4246565899895284d, c: 0.5442389989527245d),

new NpgsqlTypes.NpgsqlLine(a: 0.9304651465832275d, b: 0.9956410853645583d, c: 0.4232763028296598d),

new NpgsqlTypes.NpgsqlLine(a: 0.6248356821268628d, b: 0.9687271395205164d, c: 0.49548128506689504d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1847077338201475d, b: 0.48942489065812134d, c: 0.8467200630698146d),

new NpgsqlTypes.NpgsqlLine(a: 0.10475224120474191d, b: 0.311050907734555d, c: 0.2534117164829941d),

new NpgsqlTypes.NpgsqlLine(a: 0.8756661875211463d, b: 0.7050599482302033d, c: 0.06319099585179455d),

new NpgsqlTypes.NpgsqlLine(a: 0.30757605106681785d, b: 0.5786054927020237d, c: 0.9856968829338375d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8545538953843482d, b: 0.6000357608322632d, c: 0.7271403645222011d),

new NpgsqlTypes.NpgsqlLine(a: 0.18469349996285378d, b: 0.5959642278743166d, c: 0.8019297198867208d),

new NpgsqlTypes.NpgsqlLine(a: 0.8272014232452376d, b: 0.6357837166891125d, c: 0.07021006708772148d),

new NpgsqlTypes.NpgsqlLine(a: 0.7158292604234932d, b: 0.2086414340821926d, c: 0.09349035132803118d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7091767158044904d, b: 0.09514610761575004d, c: 0.3752081958216077d),

new NpgsqlTypes.NpgsqlLine(a: 0.31697115589219627d, b: 0.40606780851164015d, c: 0.197460481335772d),

new NpgsqlTypes.NpgsqlLine(a: 0.7333773510048858d, b: 0.57339090812092d, c: 0.5070944038830774d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5897501121505863d, b: 0.2057502436801164d, c: 0.12546095110998579d),

new NpgsqlTypes.NpgsqlLine(a: 0.17012224530324616d, b: 0.2796502416106845d, c: 0.7584830457082885d),

new NpgsqlTypes.NpgsqlLine(a: 0.703247983663898d, b: 0.9038752825116849d, c: 0.9772258010045541d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5426373559392628d, b: 0.10912027661541723d, c: 0.05101184581968654d),

new NpgsqlTypes.NpgsqlLine(a: 0.05673585718331842d, b: 0.8620246847373634d, c: 0.08082822413566848d),

new NpgsqlTypes.NpgsqlLine(a: 0.22084466344934373d, b: 0.5742896215603968d, c: 0.5751387430689219d),

new NpgsqlTypes.NpgsqlLine(a: 0.05928656369815144d, b: 0.3762441408732521d, c: 0.28993706769629635d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5793492147168638d, b: 0.7054779383259517d, c: 0.21520159097193003d),

new NpgsqlTypes.NpgsqlLine(a: 0.34688736779538754d, b: 0.989225619910773d, c: 0.6097104171567951d),

new NpgsqlTypes.NpgsqlLine(a: 0.7384481226001464d, b: 0.09311790052578928d, c: 0.9044768152343815d),

new NpgsqlTypes.NpgsqlLine(a: 0.02131522717590606d, b: 0.2782451636487875d, c: 0.5763939053292603d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3725272202412281d, b: 0.7881155253918216d, c: 0.022560023966747278d),

new NpgsqlTypes.NpgsqlLine(a: 0.9870172007268156d, b: 0.34170426973552825d, c: 0.5461828268508577d),

new NpgsqlTypes.NpgsqlLine(a: 0.8914862293585424d, b: 0.39580685928544557d, c: 0.32396249292665724d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5085960925993953d, b: 0.6609467220073811d, c: 0.9960323507219242d),

new NpgsqlTypes.NpgsqlLine(a: 0.8753437074609479d, b: 0.48683593172397444d, c: 0.06917782553515173d),

new NpgsqlTypes.NpgsqlLine(a: 0.11930164111662789d, b: 0.5403257586767742d, c: 0.7237768493892089d),

new NpgsqlTypes.NpgsqlLine(a: 0.9368947146805349d, b: 0.716698518700703d, c: 0.8890580901475943d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8276035854162911d, b: 0.797610001153799d, c: 0.7963604089992571d),

new NpgsqlTypes.NpgsqlLine(a: 0.7426485678483661d, b: 0.7493859256334818d, c: 0.7552774562336031d),

new NpgsqlTypes.NpgsqlLine(a: 0.024805623611971805d, b: 0.284370733664318d, c: 0.9359173229160251d),

new NpgsqlTypes.NpgsqlLine(a: 0.6581150466964598d, b: 0.1470020204200786d, c: 0.33305857133919636d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15933585750703005d, b: 0.9161462768820161d, c: 0.8274636563068181d),

new NpgsqlTypes.NpgsqlLine(a: 0.9948040473104535d, b: 0.6329996455133131d, c: 0.26317766914294827d),

new NpgsqlTypes.NpgsqlLine(a: 0.6023665841592013d, b: 0.37437776071666407d, c: 0.7565015050933548d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1570602610013646d, b: 0.6782315451339747d, c: 0.7297245242968052d),

new NpgsqlTypes.NpgsqlLine(a: 0.3492764449326975d, b: 0.8160440608937916d, c: 0.424265759145915d),

new NpgsqlTypes.NpgsqlLine(a: 0.9083290718766772d, b: 0.23528799347921248d, c: 0.6528545117187077d),

new NpgsqlTypes.NpgsqlLine(a: 0.2613222027145783d, b: 0.28725632823401404d, c: 0.166199213014105d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9642474953085743d, b: 0.9616555847639732d, c: 0.9450681688157829d),

new NpgsqlTypes.NpgsqlLine(a: 0.18928075007763034d, b: 0.26208080288474533d, c: 0.641886340033429d),

new NpgsqlTypes.NpgsqlLine(a: 0.09830414695056822d, b: 0.37899941134891457d, c: 0.9980929791154672d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44446182004257073d, b: 0.8288332714197651d, c: 0.7087843187495854d),

new NpgsqlTypes.NpgsqlLine(a: 0.22293999147081212d, b: 0.741622230796299d, c: 0.16169496313652665d),

new NpgsqlTypes.NpgsqlLine(a: 0.9684051707217683d, b: 0.2852354470176359d, c: 0.49617822909903286d),

new NpgsqlTypes.NpgsqlLine(a: 0.9695744557921518d, b: 0.6449719616343804d, c: 0.43969743391720384d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25104865271191534d, b: 0.19630397287538903d, c: 0.10111303093333956d),

new NpgsqlTypes.NpgsqlLine(a: 0.15932231640396533d, b: 0.7892460325285662d, c: 0.6122300074786561d),

new NpgsqlTypes.NpgsqlLine(a: 0.8126971639650953d, b: 0.2026287685453454d, c: 0.8031992454633017d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2592576423099562d, b: 0.5540662762598231d, c: 0.16740935233818166d),

new NpgsqlTypes.NpgsqlLine(a: 0.3938967313130076d, b: 0.6203401625601088d, c: 0.8630468723178771d),

new NpgsqlTypes.NpgsqlLine(a: 0.3538014173673466d, b: 0.3723452600845626d, c: 0.6345656353006554d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5447565552057043d, b: 0.9220040342853445d, c: 0.2355561514261445d),

new NpgsqlTypes.NpgsqlLine(a: 0.13416208695450038d, b: 0.3589422930646019d, c: 0.589802598061869d),

new NpgsqlTypes.NpgsqlLine(a: 0.2736908554219286d, b: 0.42858826721318877d, c: 0.9625933492634581d),

new NpgsqlTypes.NpgsqlLine(a: 0.48429991400086336d, b: 0.32450515526865675d, c: 0.018869000153509785d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6734209124541244d, b: 0.10083589535465198d, c: 0.9796938969966748d),

new NpgsqlTypes.NpgsqlLine(a: 0.4670162644642676d, b: 0.47561717035360507d, c: 0.30522974351088494d),

new NpgsqlTypes.NpgsqlLine(a: 0.5619516891814111d, b: 0.9479779400404625d, c: 0.43065845780207446d),

new NpgsqlTypes.NpgsqlLine(a: 0.23943921459269413d, b: 0.368302289508722d, c: 0.5236999472005087d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16452657193223064d, b: 0.717452707084596d, c: 0.5957051467447791d),

new NpgsqlTypes.NpgsqlLine(a: 0.37270236373704935d, b: 0.13241989644932162d, c: 0.7576519529778373d),

new NpgsqlTypes.NpgsqlLine(a: 0.9657265400301949d, b: 0.3167124969805889d, c: 0.6572082547884822d),

new NpgsqlTypes.NpgsqlLine(a: 0.20116562589901676d, b: 0.14091587981281994d, c: 0.42354270470360056d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9562437784728876d, b: 0.15618300345803016d, c: 0.9617165839246233d),

new NpgsqlTypes.NpgsqlLine(a: 0.06350994674168042d, b: 0.7089238137951446d, c: 0.5715284141028417d),

new NpgsqlTypes.NpgsqlLine(a: 0.3097287549284884d, b: 0.9837966955881615d, c: 0.7414401184799749d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20505798679018494d, b: 0.28490446334215835d, c: 0.479557691567558d),

new NpgsqlTypes.NpgsqlLine(a: 0.8982206783487445d, b: 0.00944979771434773d, c: 0.13376007022087522d),

new NpgsqlTypes.NpgsqlLine(a: 0.4335790795955904d, b: 0.3488329991711585d, c: 0.7185819183144608d),

new NpgsqlTypes.NpgsqlLine(a: 0.02599336242589989d, b: 0.33216466916930765d, c: 0.1657975524884462d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.018311714470828577d, b: 0.7506498338093919d, c: 0.8594146008714575d),

new NpgsqlTypes.NpgsqlLine(a: 0.3282606326600094d, b: 0.8293979752906455d, c: 0.3558195863209448d),

new NpgsqlTypes.NpgsqlLine(a: 0.19960968573790006d, b: 0.7641492394236312d, c: 0.2953763776360462d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9307141322411767d, b: 0.3679310917273797d, c: 0.144813646259342d),

new NpgsqlTypes.NpgsqlLine(a: 0.5670010096177783d, b: 0.721236911078239d, c: 0.42671564139949314d),

new NpgsqlTypes.NpgsqlLine(a: 0.47611664776868357d, b: 0.07257746753704586d, c: 0.10508891067718629d),

new NpgsqlTypes.NpgsqlLine(a: 0.5189308942243279d, b: 0.3283452724742081d, c: 0.10500333886392832d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5112248457914712d, b: 0.7319731324958154d, c: 0.07330156353325235d),

new NpgsqlTypes.NpgsqlLine(a: 0.21593121826544626d, b: 0.9779306247803548d, c: 0.9089712412827401d),

new NpgsqlTypes.NpgsqlLine(a: 0.7842586239546921d, b: 0.5848560945875889d, c: 0.5945805726892258d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25376696293315915d, b: 0.946831695425274d, c: 0.894453930418086d),

new NpgsqlTypes.NpgsqlLine(a: 0.6200247221035792d, b: 0.2101026389471733d, c: 0.26375220541038746d),

new NpgsqlTypes.NpgsqlLine(a: 0.38183495239753873d, b: 0.7826855001178691d, c: 0.9451746614944664d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 60, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 95, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 146, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 117, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 6, query1, 146, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 6, query1, 173, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 146, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[30], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[31], false);NpgsqlLinelineArray2M.AssertModel(models[27],_testData[32], false);NpgsqlLinelineArray2M.AssertModel(models[28],_testData[33], false);NpgsqlLinelineArray2M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[30], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[31], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[32], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[33], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

