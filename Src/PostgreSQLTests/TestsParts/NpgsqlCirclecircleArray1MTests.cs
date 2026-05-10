

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38833428863705177d, y: 0.05268937964260778d), radius: 0.3882483062862444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.270065618298556d, y: 0.5245806407841862d), radius: 0.8100709295114018d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4925747391502526d, y: 0.8649112004094206d), radius: 0.4258649010979727d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12466504866732453d, y: 0.6544147029175982d), radius: 0.20012003851245552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16968440604266688d, y: 0.4339833121222183d), radius: 0.4320129767107964d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35764171212696283d, y: 0.07210217284731657d), radius: 0.6783859258134648d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46400375747437694d, y: 0.8503414471306807d), radius: 0.20736217787210587d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4781183811747953d, y: 0.18520007414761008d), radius: 0.16085374891197912d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0021334519058300305d, y: 0.28445612030072387d), radius: 0.8036558129934751d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21593259281367883d, y: 0.589137901048427d), radius: 0.750084631500024d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791808233192908d, y: 0.2651839557408654d), radius: 0.37058293047459745d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02891774152987525d, y: 0.7429139862939612d), radius: 0.09209041275388286d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3235832752728478d, y: 0.9591452778321591d), radius: 0.19886938803831866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3759214691158389d, y: 0.46024265862768576d), radius: 0.597558620987377d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.879109437280958d, y: 0.003422123208220218d), radius: 0.7787342888455197d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22202044938481047d, y: 0.19149440787951066d), radius: 0.9145115916873375d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04959810168713852d, y: 0.47592789468116403d), radius: 0.07627730711538139d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16268947110655918d, y: 0.6489144953722472d), radius: 0.9337801033313711d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18976618259570088d, y: 0.7301668062664873d), radius: 0.6356854788030176d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22208648848142576d, y: 0.8028560176532048d), radius: 0.5052174762767595d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37426433822461114d, y: 0.7442630584996169d), radius: 0.05123517787890275d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.618124084819781d, y: 0.9172753325327155d), radius: 0.00406502846495449d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3747726971889438d, y: 0.5126658956443917d), radius: 0.1330184231942707d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2504704488587479d, y: 0.538052843619591d), radius: 0.04561199910522773d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5636472946702057d, y: 0.3881900865609046d), radius: 0.3238663143569226d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43591314485754795d, y: 0.4894038386097498d), radius: 0.92997955143404d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4794068590667846d, y: 0.4740591631358506d), radius: 0.771620440956343d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8817828272507929d, y: 0.1356465764523499d), radius: 0.535529583869584d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21095454748114972d, y: 0.3302832564554954d), radius: 0.025644505970890297d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40380161083266697d, y: 0.5907338994631319d), radius: 0.6817306129157954d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.044426595668319524d, y: 0.5683934233543086d), radius: 0.04612711270056602d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5840794021833736d, y: 0.9010876679821181d), radius: 0.6473593209788276d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44646979306448265d, y: 0.266134998804062d), radius: 0.5691184133802251d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.943375867936125d, y: 0.5174601364970676d), radius: 0.7808318844841025d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13529539664437584d, y: 0.2551050066182866d), radius: 0.23735047991154234d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5906419327353067d, y: 0.3332616046263921d), radius: 0.2448725092305014d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5717113342633717d, y: 0.19782803617592726d), radius: 0.5910146725605534d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5719732125643452d, y: 0.9868126827958463d), radius: 0.800369361107166d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.095314106956636d, y: 0.5149791433567339d), radius: 0.04197160407519007d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4758950236867572d, y: 0.6720109450591809d), radius: 0.018586828544154277d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9190968647755192d, y: 0.6892474977197127d), radius: 0.5465645137789956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8003272574760066d, y: 0.8556671467446136d), radius: 0.8953475535657984d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4220768004914389d, y: 0.990258533846328d), radius: 0.7126369727252361d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9234891187002447d, y: 0.9168575294382677d), radius: 0.7453488478177577d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2083836904018943d, y: 0.720241558527209d), radius: 0.9554343646413126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48411539393590686d, y: 0.756427382546039d), radius: 0.04948125267256265d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9536551716733719d, y: 0.0624037991057218d), radius: 0.28990418148864305d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5499479512026737d, y: 0.2941498924711943d), radius: 0.924450164882606d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0431589657325655d, y: 0.9542261719991202d), radius: 0.7011366624359363d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8519056491096891d, y: 0.34443890485013406d), radius: 0.3540796496848476d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11887625025055004d, y: 0.5303341547768452d), radius: 0.7309311445419467d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5154411130251533d, y: 0.3430408107275975d), radius: 0.8073947562124741d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013751773765893538d, y: 0.7611518963605899d), radius: 0.6938604357159498d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3205435115898001d, y: 0.5151922745353763d), radius: 0.7492006937655327d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18207341047262937d, y: 0.7052087819566539d), radius: 0.17693943879974372d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23855198309708125d, y: 0.17110234538257685d), radius: 0.26063613779725725d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9788450600658805d, y: 0.9963452035970111d), radius: 0.3936636478701401d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5502766919206782d, y: 0.8966884980914899d), radius: 0.683073754523712d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9442591250265253d, y: 0.7078139503128845d), radius: 0.1702079315635291d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06066399819904067d, y: 0.9991218814255795d), radius: 0.539865348382803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9472878051869462d, y: 0.42915126953510774d), radius: 0.771130875993185d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7113909105286532d, y: 0.14885539671961023d), radius: 0.3176585770910013d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6381238019736802d, y: 0.9993073018059163d), radius: 0.9996266624792657d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5356349669281786d, y: 0.9953462972007006d), radius: 0.3865802914592925d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7537464072879633d, y: 0.4735703812004963d), radius: 0.15739330947728392d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36660272518706116d, y: 0.9919320671509664d), radius: 0.290387190246719d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7095537984442802d, y: 0.2510626897145988d), radius: 0.7226684002547517d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9454461972974011d, y: 0.32401300044859027d), radius: 0.14685636920500988d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5965122339246609d, y: 0.6891934502139947d), radius: 0.7787029357365282d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28197545156147263d, y: 0.5883299735726832d), radius: 0.6299709928809769d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5481719665426764d, y: 0.5025691821323224d), radius: 0.4600836792566073d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3387355538286624d, y: 0.481107005949275d), radius: 0.13733065566095215d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28730901162542855d, y: 0.7871394816590387d), radius: 0.13279331738256994d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10629338618506401d, y: 0.6927119924088054d), radius: 0.5840810162772554d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07881546113083726d, y: 0.7013008784732249d), radius: 0.04158824652792903d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00911186211521231d, y: 0.06673179977158794d), radius: 0.2479614418338698d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7836422617031074d, y: 0.3027494285250685d), radius: 0.747384542911686d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05094320866215407d, y: 0.3787222166625106d), radius: 0.4060789149131053d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04462160128864556d, y: 0.2751968432854215d), radius: 0.6575343601818257d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15979666609661547d, y: 0.32222599446603273d), radius: 0.598486048131105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27597541442948137d, y: 0.9079251574248842d), radius: 0.28302738105609515d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8638658056838158d, y: 0.050114248055774024d), radius: 0.3305670219111375d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13084490281137784d, y: 0.5507869836341128d), radius: 0.5924153767473874d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8698227352813521d, y: 0.4374261419862878d), radius: 0.41171506466642704d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08278762065981515d, y: 0.5405828885498349d), radius: 0.40630350085375855d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18344460108449223d, y: 0.6320083357252924d), radius: 0.7319982701201084d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8474317557568616d, y: 0.45281660490999665d), radius: 0.5273089478943073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6224401863432443d, y: 0.5774291574738655d), radius: 0.668479657675858d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4495475039421677d, y: 0.12182631724009152d), radius: 0.15963326681668533d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38292127057585224d, y: 0.7767811734372492d), radius: 0.48499016664304484d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9485553397767748d, y: 0.9236642588937665d), radius: 0.17479786313325696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.508214825058834d, y: 0.9982550991098761d), radius: 0.1821340365011509d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4612240771996856d, y: 0.25323272172486466d), radius: 0.3378694704013475d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07455696571281645d, y: 0.8148179630904868d), radius: 0.929712452646397d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7107655852466107d, y: 0.5621888693839214d), radius: 0.23968695047093036d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7006180910932855d, y: 0.09949765060806581d), radius: 0.7442411082470859d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8583405125804809d, y: 0.7194412562322998d), radius: 0.5024559660192053d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23029573304388085d, y: 0.1820954491495056d), radius: 0.5384319141193664d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9768323152295441d, y: 0.33193182550320366d), radius: 0.8530576883323486d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8603436139618131d, y: 0.7382782762408064d), radius: 0.430364877699965d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.065224950202591d, y: 0.8711417133118504d), radius: 0.7363027912406845d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16447554523780927d, y: 0.1109183911896856d), radius: 0.0978644902078708d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08651904171313596d, y: 0.5940428865195143d), radius: 0.649600244677584d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8902114629915167d, y: 0.734619850488756d), radius: 0.933556583858d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1727943493614551d, y: 0.17176765264427452d), radius: 0.743877185961135d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6403230385028935d, y: 0.3710189770289778d), radius: 0.20830011459684428d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8070146445000418d, y: 0.7102855825968468d), radius: 0.10639709304240297d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6684079563572528d, y: 0.8377179314147424d), radius: 0.41370714960651367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7528255061525692d, y: 0.24172205514969558d), radius: 0.5559950859740438d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13097422631676436d, y: 0.5902271330916548d), radius: 0.7390133881372056d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5074623510419942d, y: 0.02868562951675735d), radius: 0.03862373595984181d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0030033441068278988d, y: 0.8257151576453501d), radius: 0.7794933483836232d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22672471506141612d, y: 0.9671330062442393d), radius: 0.8460475553547474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.87077924360008d, y: 0.031502443976369365d), radius: 0.9118220313711048d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5756831838941047d, y: 0.930241286193913d), radius: 0.3309216515685012d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1495837469004525d, y: 0.9999536595811868d), radius: 0.3870201963669194d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6448956632641074d, y: 0.6547063258891294d), radius: 0.6687608803937889d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18574701422802842d, y: 0.7035059942891914d), radius: 0.10794919654621415d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39614084669045224d, y: 0.46615780779504223d), radius: 0.7177217603144107d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.619391065010073d, y: 0.4542671054645624d), radius: 0.7518482758537487d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7637158875123589d, y: 0.06970119359582583d), radius: 0.2683942355005505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35667283173503295d, y: 0.8128208548695649d), radius: 0.16035050295523223d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14307949853457935d, y: 0.4204686375750374d), radius: 0.6504461858883102d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5002410945492713d, y: 0.2901355400947243d), radius: 0.4644281113963423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3453030502527845d, y: 0.48856983106746843d), radius: 0.1839165628734657d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49517129945580063d, y: 0.04001959584469217d), radius: 0.7469515627639332d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4736893180554236d, y: 0.7196438806454947d), radius: 0.7954986952074011d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5485114568200584d, y: 0.8451813344128553d), radius: 0.6070132433709702d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17711729982349023d, y: 0.5627578647126104d), radius: 0.5009225233872219d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7914720503357479d, y: 0.6839018392177024d), radius: 0.7308766865115489d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4453129267242327d, y: 0.1046706451743834d), radius: 0.1611304833564422d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8710153681944283d, y: 0.7530944002663625d), radius: 0.854506409786227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5035511236826057d, y: 0.42741544352399374d), radius: 0.9339566233344592d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7289352148526183d, y: 0.5349344456253645d), radius: 0.6495220805562008d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16027420837985118d, y: 0.855542384827023d), radius: 0.838721855817516d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07206518164025233d, y: 0.6500201499282618d), radius: 0.4031014878010942d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9551320346584052d, y: 0.571079877666031d), radius: 0.41470920137435663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7672385160844817d, y: 0.17499918534016878d), radius: 0.9777862509502195d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7249788052625169d, y: 0.6599506145079802d), radius: 0.48211905321442916d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9388992219474875d, y: 0.7452963301232582d), radius: 0.7573638290362193d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4369242177534287d, y: 0.5833583854019584d), radius: 0.014017738273599756d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7230386329260097d, y: 0.3875413562262281d), radius: 0.17809430698387274d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16991646427497276d, y: 0.15453818484306325d), radius: 0.2528123050005663d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.512592311606007d, y: 0.975731310479427d), radius: 0.006477900941050274d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9341435301514583d, y: 0.174539404400609d), radius: 0.42453278721510235d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9166337408520728d, y: 0.40706901235883064d), radius: 0.09623915605476807d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14770464727891142d, y: 0.5882194417409922d), radius: 0.24345879868628317d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41802484020580744d, y: 0.6487833878280548d), radius: 0.9121319369156551d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.799926833164503d, y: 0.8105779195649948d), radius: 0.47893116141762804d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46718548904365653d, y: 0.4335767899638979d), radius: 0.6497573173253856d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14740645273156427d, y: 0.18874700203242212d), radius: 0.4225722150956537d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5394329770378959d, y: 0.6459851429785014d), radius: 0.8324166239085724d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020255124824217874d, y: 0.2491006480444149d), radius: 0.65264035115683d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14808171610757304d, y: 0.011996204105206854d), radius: 0.9915528416034836d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3698498297867362d, y: 0.6019767061272804d), radius: 0.10233170620517595d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2174907940808979d, y: 0.5909466076804842d), radius: 0.6155544199551664d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3045145509678794d, y: 0.9946616407840563d), radius: 0.7821963043688802d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7745632059776862d, y: 0.6535515293486704d), radius: 0.14440138643681133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09030952683777482d, y: 0.019505510286603522d), radius: 0.7174763419033644d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2957430670192228d, y: 0.865935631869275d), radius: 0.33485876701400497d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6034015420546623d, y: 0.9953503525180807d), radius: 0.7284359344057327d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2629020017436827d, y: 0.6767427052486774d), radius: 0.8157984453685476d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7839113602173458d, y: 0.7951844499657353d), radius: 0.10800315862294263d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44531435832356203d, y: 0.2814640841020988d), radius: 0.6026251833031125d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46554727743565216d, y: 0.6972673080288704d), radius: 0.7710819574737363d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13523626654201093d, y: 0.8464299694599793d), radius: 0.6970712023133288d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9537314398722414d, y: 0.9377066033099697d), radius: 0.3292186136690066d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9628371208093215d, y: 0.24204068312250104d), radius: 0.03916133145402989d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14126467284927813d, y: 0.9475565549328149d), radius: 0.6878494801702696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3485127429732704d, y: 0.08277245272704337d), radius: 0.7147330088641767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9982794164149971d, y: 0.6022103661357133d), radius: 0.7162148955432457d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.848978563427636d, y: 0.2566216791234932d), radius: 0.05239315067063943d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6882792300280893d, y: 0.7791109739596621d), radius: 0.5248680649207944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2881105640492182d, y: 0.15182875271084495d), radius: 0.7593957150036835d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16120124400548363d, y: 0.5957954971782268d), radius: 0.6773873896585583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8283219580886488d, y: 0.66594868268594d), radius: 0.835053274690563d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5505910419857983d, y: 0.9288512385799328d), radius: 0.5743997714114591d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43764026332610073d, y: 0.681388115701181d), radius: 0.39036419484330787d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3141293444772316d, y: 0.9095429185707881d), radius: 0.27947870093338567d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45595849316444326d, y: 0.10537517448228861d), radius: 0.9538338744030905d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2825434638575596d, y: 0.7778212518020137d), radius: 0.08918420820311512d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6068002031021036d, y: 0.6119895518855616d), radius: 0.11843595478884728d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03444450392057752d, y: 0.0009703430322287598d), radius: 0.08898411417354579d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4348733265690409d, y: 0.6719502462581253d), radius: 0.0006486035530877121d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17754568127825543d, y: 0.1728240811578553d), radius: 0.6949119622533754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4849770617215081d, y: 0.7536042960412087d), radius: 0.8663693360268344d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.545675096796373d, y: 0.013083078217689725d), radius: 0.287766753331686d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6730429057361281d, y: 0.24292270835540797d), radius: 0.7693288233941297d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5570508689436674d, y: 0.2384136111713624d), radius: 0.08238052804447094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0421240114354261d, y: 0.7971056334509905d), radius: 0.20742323229906734d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024372424404398796d, y: 0.6376626260773042d), radius: 0.6185631810467395d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31023377483932235d, y: 0.8466939596376923d), radius: 0.613334570538635d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8859237437862773d, y: 0.7392975673591752d), radius: 0.38263809714747365d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8054830236619352d, y: 0.7689757793835652d), radius: 0.8637122224499701d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28814630367316574d, y: 0.17804835388925122d), radius: 0.28200304497005546d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49167688319494196d, y: 0.3064184042983972d), radius: 0.021414807941187775d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9522161454467504d, y: 0.23297571008428686d), radius: 0.32497655058159813d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4454873793725186d, y: 0.09236369499173991d), radius: 0.6420198237653767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8685933478515162d, y: 0.7595235393303335d), radius: 0.480242735287307d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.302592205685175d, y: 0.1161932364807301d), radius: 0.5913031163500757d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17754199399363035d, y: 0.03471091610981214d), radius: 0.5465924542982225d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0632964709541397d, y: 0.5309118251125079d), radius: 0.4686643071720755d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4194953862934222d, y: 0.8754816153405877d), radius: 0.5451264290120278d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9455110142225873d, y: 0.4945197719209641d), radius: 0.5572913583920548d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8833876075220394d, y: 0.5214184692660934d), radius: 0.7438379606705674d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5608117164466085d, y: 0.30032458396654205d), radius: 0.9115612433141121d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9775461006585917d, y: 0.7370753981422603d), radius: 0.6622242874968366d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.605191765484546d, y: 0.555084694487453d), radius: 0.6597865775401579d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07136018827048607d, y: 0.7883568880215267d), radius: 0.43088480715444455d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8553411728761151d, y: 0.6820303712653295d), radius: 0.7541773656034425d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.744904829282317d, y: 0.8742758597242739d), radius: 0.2759555246671699d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6269975798232742d, y: 0.9462584699621065d), radius: 0.7632509326171544d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.060187426603538596d, y: 0.923634340211901d), radius: 0.8125319291616684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4779857671999084d, y: 0.8501692685912182d), radius: 0.4592145413533587d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5953289460246451d, y: 0.028740830709822696d), radius: 0.844235771967588d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07062174242953367d, y: 0.31594493835865556d), radius: 0.8065858439720581d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5953348265377993d, y: 0.957172660293359d), radius: 0.8302402685225032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2752561477315535d, y: 0.8369532660901853d), radius: 0.9230622893593445d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29247738372703824d, y: 0.08743501820171773d), radius: 0.4334277385462997d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13148639705458953d, y: 0.23085769319015526d), radius: 0.7822179029308365d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4950934980723648d, y: 0.3640058168775181d), radius: 0.0756131896152964d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7691457898772136d, y: 0.7888318569258581d), radius: 0.1922719891514918d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2307445071783344d, y: 0.7692994420966653d), radius: 0.029231178746016995d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28466078256138805d, y: 0.5035109968830902d), radius: 0.9039163810162494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2820728961893061d, y: 0.7785627901637157d), radius: 0.37528372006364896d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31684324511489437d, y: 0.4985781211504615d), radius: 0.5638576776995881d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9033739286302177d, y: 0.6398691183023945d), radius: 0.00027540182254404133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9337359052653652d, y: 0.029577511199609052d), radius: 0.5753459113065538d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.908296420133833d, y: 0.7991714014393783d), radius: 0.12054169233421741d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.835779077839347d, y: 0.8219203307495525d), radius: 0.45231577642067133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6401821775397443d, y: 0.2957289160389769d), radius: 0.49326867328950685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19777001712267273d, y: 0.781727097011477d), radius: 0.056172758757314756d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8507048235959235d, y: 0.35890200762570934d), radius: 0.13390510317026116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4804188608868535d, y: 0.5191060639185957d), radius: 0.11954012757556398d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4077929293417575d, y: 0.4080848527485309d), radius: 0.5323648386883499d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2069636459529307d, y: 0.7238349413903262d), radius: 0.05835646034536135d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7061669288293289d, y: 0.5268167361310249d), radius: 0.44663745777283315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48461024518038265d, y: 0.8692000683989498d), radius: 0.8885516458387142d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37886582700590654d, y: 0.5856030237306538d), radius: 0.8330869185987634d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8327580677684239d, y: 0.09871286740782037d), radius: 0.24099570818421368d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10502549452920662d, y: 0.5652897444903127d), radius: 0.04077342265897199d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025488478714612683d, y: 0.6588425058120281d), radius: 0.61589979703282d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13336026024657321d, y: 0.7203423584558276d), radius: 0.46206732057975775d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7897977344717697d, y: 0.586325154398419d), radius: 0.46388320348688894d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3542319309389703d, y: 0.7323436447080914d), radius: 0.7449085379528948d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.74251858639455d, y: 0.29054292208558385d), radius: 0.43979232675972924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2583778168289371d, y: 0.5743873919634326d), radius: 0.13150793386145898d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7745583188344116d, y: 0.519773102663815d), radius: 0.07345210722646678d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8707061668771493d, y: 0.1696162695911071d), radius: 0.0025985880028216446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10709185125328702d, y: 0.4887374172873523d), radius: 0.49792904263560767d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4112381950639634d, y: 0.44302498337560003d), radius: 0.81062410393795d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9366918568388279d, y: 0.44329930610613477d), radius: 0.273625759019264d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8564733586543922d, y: 0.8579643438893813d), radius: 0.539289966428012d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43326326224250755d, y: 0.7746984950665485d), radius: 0.8104406329401146d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3692500082113247d, y: 0.40748155519776574d), radius: 0.8289899527348231d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.292107270132553d, y: 0.07141270243462061d), radius: 0.251172777902798d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7087662100094788d, y: 0.42497943116298764d), radius: 0.18870506867780246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2924539639934066d, y: 0.8607586611242837d), radius: 0.7198865488823557d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12610696281216083d, y: 0.23864044901166537d), radius: 0.47762101749118846d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09901705399904592d, y: 0.21012788848463715d), radius: 0.5842201165759835d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6946279800304103d, y: 0.15657975262274149d), radius: 0.6983475941075538d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20458675950437588d, y: 0.431707996464464d), radius: 0.9471371809557676d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8395108530669422d, y: 0.3488622813127491d), radius: 0.9407889558678586d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9782990212943355d, y: 0.4256375576109074d), radius: 0.9397581448572877d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17645805542911852d, y: 0.9545949663544988d), radius: 0.7744599145924476d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10852723132021402d, y: 0.4732323415871066d), radius: 0.3483851107020538d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06859685263776627d, y: 0.26986172802540354d), radius: 0.7478074813802705d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9957162180492368d, y: 0.9847615118482005d), radius: 0.5865090910698635d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8152597635156552d, y: 0.9072460394056849d), radius: 0.5419792978203827d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9419959248477126d, y: 0.6687971357756506d), radius: 0.07154617710876288d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3689093489007842d, y: 0.3827798980769922d), radius: 0.7380841214338636d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07451953037766634d, y: 0.33919358774923314d), radius: 0.7588646469598683d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4399659424750981d, y: 0.6031935093252077d), radius: 0.857137393499656d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5837570674094527d, y: 0.07098738521541037d), radius: 0.9178974307953656d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29405805851585176d, y: 0.3535479150244236d), radius: 0.9242750164505615d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18174193855541199d, y: 0.7198941803971335d), radius: 0.11832966970832193d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21185628915732824d, y: 0.4694705687874605d), radius: 0.15868359154345135d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.698276014178031d, y: 0.29130328014542994d), radius: 0.7542173821108681d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14221071029583998d, y: 0.9713022090454841d), radius: 0.7850939099196425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050390358184356d, y: 0.312276635276059d), radius: 0.3370167149750134d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9558532104360695d, y: 0.6434926842980883d), radius: 0.3480329437467278d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5906394472343277d, y: 0.01782744247602186d), radius: 0.41148183103906855d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9079398231446416d, y: 0.24303525349292276d), radius: 0.48684805459051084d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31560630221265895d, y: 0.4485277124265349d), radius: 0.43328799079026636d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40090929632508365d, y: 0.7557265994905791d), radius: 0.9258946236532347d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15454922257218917d, y: 0.7509893180056784d), radius: 0.26273053130727675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3433828706028733d, y: 0.4405763604339191d), radius: 0.1852684852343498d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9715651566402699d, y: 0.39147263279999545d), radius: 0.10989449828149689d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430956232459612d, y: 0.7047824761201119d), radius: 0.22650097048338702d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6923436531340016d, y: 0.36870462823584094d), radius: 0.11473755236810645d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4268099864674707d, y: 0.22810293528119985d), radius: 0.4645410620768625d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1633109834367218d, y: 0.24785375002908272d), radius: 0.132224971630305d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18437536427956158d, y: 0.5757454761027284d), radius: 0.0027175824605600862d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06285489482450413d, y: 0.2173594672306246d), radius: 0.21305900851819304d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5627224331715954d, y: 0.6846491105064308d), radius: 0.18124304089804666d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 194,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8456672253797264d, y: 0.5518205706937616d), radius: 0.35768033715986525d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5708096130839051d, y: 0.1942412644984126d), radius: 0.866779654901428d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9744198560764598d, y: 0.8035921958523862d), radius: 0.9579724339278415d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0782814998618031d, y: 0.15470444799631478d), radius: 0.5978016249791537d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42108558920566663d, y: 0.1448498628881103d), radius: 0.6264016645300258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9564679784863042d, y: 0.37615794665137614d), radius: 0.016402311266238034d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4198458134230788d, y: 0.9771313986835938d), radius: 0.12052470291763018d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06391787242359026d, y: 0.8602007966932494d), radius: 0.8288475733610609d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3083874113183399d, y: 0.769366108992503d), radius: 0.016068095538951277d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 197,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5512015767716855d, y: 0.3657994130668103d), radius: 0.8215954773628936d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8297062726671549d, y: 0.7363181025918164d), radius: 0.3185601499516638d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27556920187410006d, y: 0.3847044735844647d), radius: 0.26588389754931585d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5925242214692094d, y: 0.15191973345563858d), radius: 0.7765820437872422d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18207341047262937d, y: 0.7052087819566539d), radius: 0.17693943879974372d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23855198309708125d, y: 0.17110234538257685d), radius: 0.26063613779725725d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9788450600658805d, y: 0.9963452035970111d), radius: 0.3936636478701401d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7113909105286532d, y: 0.14885539671961023d), radius: 0.3176585770910013d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6381238019736802d, y: 0.9993073018059163d), radius: 0.9996266624792657d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5356349669281786d, y: 0.9953462972007006d), radius: 0.3865802914592925d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00911186211521231d, y: 0.06673179977158794d), radius: 0.2479614418338698d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7836422617031074d, y: 0.3027494285250685d), radius: 0.747384542911686d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05094320866215407d, y: 0.3787222166625106d), radius: 0.4060789149131053d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04462160128864556d, y: 0.2751968432854215d), radius: 0.6575343601818257d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23029573304388085d, y: 0.1820954491495056d), radius: 0.5384319141193664d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9768323152295441d, y: 0.33193182550320366d), radius: 0.8530576883323486d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8603436139618131d, y: 0.7382782762408064d), radius: 0.430364877699965d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.065224950202591d, y: 0.8711417133118504d), radius: 0.7363027912406845d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 178;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 184;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[34], false);
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
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 146, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 14, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 161, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 184, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 168, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 171);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[30], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI), typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                await ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleArraycircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

