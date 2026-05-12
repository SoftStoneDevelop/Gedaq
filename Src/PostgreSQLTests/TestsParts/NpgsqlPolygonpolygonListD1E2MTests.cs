

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
    internal partial interface INpgsqlPolygonListpolygonListD1
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonListD1 : INpgsqlPolygonListpolygonListD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonListD1E2M[] _testData = new NpgsqlPolygonpolygonListD1E2M[]
        {
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7441364073394183d, y: 0.0027951806208265095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484744810052903d, y: 0.9476909210917485d), new NpgsqlTypes.NpgsqlPoint(x: 0.35190629337253354d, y: 0.14772674278348663d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5475082924298877d, y: 0.4910692418819286d), new NpgsqlTypes.NpgsqlPoint(x: 0.04617332108801009d, y: 0.1563943557867633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904219278663766d, y: 0.26726232821877405d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09437086568366226d, y: 0.4852826239527973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036542957610245d, y: 0.8013144739932425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242789767715938d, y: 0.7542767663369249d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17938215723125195d, y: 0.8047093753175872d), new NpgsqlTypes.NpgsqlPoint(x: 0.36962157226377323d, y: 0.7723599388107327d), new NpgsqlTypes.NpgsqlPoint(x: 0.4039385789512582d, y: 0.1896319996443715d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5499354648919217d, y: 0.40081767458399065d), new NpgsqlTypes.NpgsqlPoint(x: 0.28250935975362523d, y: 0.3482853447888785d), new NpgsqlTypes.NpgsqlPoint(x: 0.702760341200697d, y: 0.7567068716869493d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7411497102863809d, y: 0.9352884081683318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5728297157359691d, y: 0.783290453523231d), new NpgsqlTypes.NpgsqlPoint(x: 0.6097536511566027d, y: 0.16729285838104335d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05233262172543229d, y: 0.10049936312262864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708492973632296d, y: 0.162191447102203d), new NpgsqlTypes.NpgsqlPoint(x: 0.45975079513438966d, y: 0.21783460088988382d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.061700343221474996d, y: 0.4478581674485853d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793656837655857d, y: 0.46748308612869593d), new NpgsqlTypes.NpgsqlPoint(x: 0.4090479126744916d, y: 0.41634500819467846d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9646020504042261d, y: 0.35140333613099395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141782261214304d, y: 0.33269823761097683d), new NpgsqlTypes.NpgsqlPoint(x: 0.4655193265455676d, y: 0.27163034656277185d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20985069298637804d, y: 0.5025077513285252d), new NpgsqlTypes.NpgsqlPoint(x: 0.45301591065326297d, y: 0.9976726723937224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366129978858399d, y: 0.066514036610405d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3364796851434493d, y: 0.46945536030849155d), new NpgsqlTypes.NpgsqlPoint(x: 0.71268309521654d, y: 0.5082968537194608d), new NpgsqlTypes.NpgsqlPoint(x: 0.27833311358751867d, y: 0.7971615534280311d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8032638853957125d, y: 0.9252402955694465d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431598540714565d, y: 0.44411532152524014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938953691959635d, y: 0.8927821255948765d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3112286744277142d, y: 0.8408391033146692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429112260777414d, y: 0.8591926307306181d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987758631918569d, y: 0.2500543449261514d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02645049134294719d, y: 0.702061359461647d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850762633239213d, y: 0.018487663656922337d), new NpgsqlTypes.NpgsqlPoint(x: 0.811541731872268d, y: 0.3985064298962283d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5067713765135862d, y: 0.17002604086053352d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686007080837831d, y: 0.7779294041605256d), new NpgsqlTypes.NpgsqlPoint(x: 0.023404958729820513d, y: 0.12905802051831594d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9328195437821419d, y: 0.10223193450186119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8104051231418679d, y: 0.7952241682598692d), new NpgsqlTypes.NpgsqlPoint(x: 0.533723059015522d, y: 0.25118885971073035d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00139117261782018d, y: 0.8455395264238119d), new NpgsqlTypes.NpgsqlPoint(x: 0.3573564806798408d, y: 0.3549673958874703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5042786036040743d, y: 0.3548445189175008d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20359783823677913d, y: 0.7065707773958295d), new NpgsqlTypes.NpgsqlPoint(x: 0.23472653455497983d, y: 0.7422928844808776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046190582865377d, y: 0.37489213142817046d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8093160796205422d, y: 0.1983346500294373d), new NpgsqlTypes.NpgsqlPoint(x: 0.851013144386147d, y: 0.8178958987055873d), new NpgsqlTypes.NpgsqlPoint(x: 0.3272156048612074d, y: 0.0788451184166763d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45472940305790444d, y: 0.08344654462669565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561080638959786d, y: 0.5661168357319483d), new NpgsqlTypes.NpgsqlPoint(x: 0.24726249786782417d, y: 0.05287774308007154d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38542113611999784d, y: 0.6570460322604703d), new NpgsqlTypes.NpgsqlPoint(x: 0.35694878840303335d, y: 0.6935340511407666d), new NpgsqlTypes.NpgsqlPoint(x: 0.21381171161215717d, y: 0.29294084305390944d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6996142510928648d, y: 0.5484679043488557d), new NpgsqlTypes.NpgsqlPoint(x: 0.884891802469624d, y: 0.8216191860890005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7063435596077965d, y: 0.6547128378347667d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7060337559924276d, y: 0.6915989318541611d), new NpgsqlTypes.NpgsqlPoint(x: 0.0036787718513734413d, y: 0.37403218956959006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9526113471527796d, y: 0.49591776410774024d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5845139511670575d, y: 0.022184079890225306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4299070305916243d, y: 0.3210941113094561d), new NpgsqlTypes.NpgsqlPoint(x: 0.4297612448627339d, y: 0.4674130265457612d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7038121086319179d, y: 0.061592618393188414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5513793464891491d, y: 0.7812945440227768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9543898876130082d, y: 0.09757631236262043d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.939605796406615d, y: 0.5302239432952653d), new NpgsqlTypes.NpgsqlPoint(x: 0.04958736781058615d, y: 0.6306100141516553d), new NpgsqlTypes.NpgsqlPoint(x: 0.2525066824803055d, y: 0.6688157350720031d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34567398667225546d, y: 0.5386150612141788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7785757991350789d, y: 0.19523858459997367d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203350215858149d, y: 0.6541868369488485d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7838273283888226d, y: 0.30008710933452565d), new NpgsqlTypes.NpgsqlPoint(x: 0.009515565865873987d, y: 0.40221736974284905d), new NpgsqlTypes.NpgsqlPoint(x: 0.31312089539270693d, y: 0.7284275140012966d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7092976341880767d, y: 0.41515687659943223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5482896329027394d, y: 0.465565923655326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2319074981767416d, y: 0.5480908007994736d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8062567398020266d, y: 0.5169903289492505d), new NpgsqlTypes.NpgsqlPoint(x: 0.848636072936088d, y: 0.6757990733189079d), new NpgsqlTypes.NpgsqlPoint(x: 0.637624469196658d, y: 0.5769214758445856d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29205327064404496d, y: 0.9909413896260053d), new NpgsqlTypes.NpgsqlPoint(x: 0.8186764260801708d, y: 0.09110712950676714d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418636498783943d, y: 0.20401994437940807d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.602370316534112d, y: 0.034770830303734734d), new NpgsqlTypes.NpgsqlPoint(x: 0.27465042228152436d, y: 0.9466706867207756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5737659589977885d, y: 0.6159447165745137d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44068863116386525d, y: 0.6911800437545144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111162249032024d, y: 0.9273914505252925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8248423341010425d, y: 0.4585116622041d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.946056784846564d, y: 0.07642566441192666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653575368162755d, y: 0.5595741065402872d), new NpgsqlTypes.NpgsqlPoint(x: 0.28029405153450804d, y: 0.36855492995038075d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5778900893913422d, y: 0.8520553089131184d), new NpgsqlTypes.NpgsqlPoint(x: 0.1779086817462031d, y: 0.6976687370816859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791054202011859d, y: 0.5632738206677154d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.621864085142196d, y: 0.9192742530191307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8336714861472504d, y: 0.7401100584559199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321467891757479d, y: 0.30356461743322016d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09675589005683649d, y: 0.7455389329469146d), new NpgsqlTypes.NpgsqlPoint(x: 0.537625815589058d, y: 0.986525437980158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9109882945146166d, y: 0.6534806810020135d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22173773308272782d, y: 0.35694142919251115d), new NpgsqlTypes.NpgsqlPoint(x: 0.1657922518941256d, y: 0.5029134164651801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685437863655858d, y: 0.48131565529233d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.431986948064661d, y: 0.2944709382681302d), new NpgsqlTypes.NpgsqlPoint(x: 0.23238514266148935d, y: 0.8740222920359265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767517519685383d, y: 0.8729910645720134d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3377448087640347d, y: 0.9049743941659271d), new NpgsqlTypes.NpgsqlPoint(x: 0.1180383551723051d, y: 0.5884824346668486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058808806720526d, y: 0.3859094901247633d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29636481387922264d, y: 0.5228460683771109d), new NpgsqlTypes.NpgsqlPoint(x: 0.2314431900548597d, y: 0.013807789161063178d), new NpgsqlTypes.NpgsqlPoint(x: 0.20891685352325584d, y: 0.6387832999879552d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6958884681434505d, y: 0.7255554403558394d), new NpgsqlTypes.NpgsqlPoint(x: 0.4723448533169412d, y: 0.8167514014427291d), new NpgsqlTypes.NpgsqlPoint(x: 0.9627459115529329d, y: 0.48308495355572334d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31887969242560643d, y: 0.7679351221440568d), new NpgsqlTypes.NpgsqlPoint(x: 0.4444226855593827d, y: 0.414693068248258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8591409861945615d, y: 0.3392035777709633d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8499862518291653d, y: 0.5903543450352627d), new NpgsqlTypes.NpgsqlPoint(x: 0.13847828964229958d, y: 0.988491769082318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4183187245523543d, y: 0.3088637360648073d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9058346088024509d, y: 0.17756482609010893d), new NpgsqlTypes.NpgsqlPoint(x: 0.052510569130472695d, y: 0.6107236974838695d), new NpgsqlTypes.NpgsqlPoint(x: 0.900016683177239d, y: 0.6248589718882134d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9766755167680505d, y: 0.808900658111857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974692295196269d, y: 0.43381609385438036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2878952939565418d, y: 0.9023285021218348d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33644428173267327d, y: 0.8026400718231471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832161136142591d, y: 0.46191121715248173d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860531043294824d, y: 0.9045393932382225d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.609456040250733d, y: 0.9276467703784724d), new NpgsqlTypes.NpgsqlPoint(x: 0.135703728908533d, y: 0.17499876820827498d), new NpgsqlTypes.NpgsqlPoint(x: 0.957355717550368d, y: 0.6498594859642804d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5375269317502882d, y: 0.1841595925128886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7154873815432536d, y: 0.8744016042350734d), new NpgsqlTypes.NpgsqlPoint(x: 0.28983708241710016d, y: 0.1938891516137271d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6796342001615753d, y: 0.7837194078190063d), new NpgsqlTypes.NpgsqlPoint(x: 0.33061374245358743d, y: 0.7667014875106325d), new NpgsqlTypes.NpgsqlPoint(x: 0.16019460355712678d, y: 0.33742137894581026d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2774534592175607d, y: 0.7325647712064771d), new NpgsqlTypes.NpgsqlPoint(x: 0.37372631791008093d, y: 0.691872444379979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682951635831873d, y: 0.6289261092504135d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4910816845593863d, y: 0.9066335463240585d), new NpgsqlTypes.NpgsqlPoint(x: 0.03380659625847349d, y: 0.6816657341446475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005685831680367d, y: 0.43734334166409206d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6804915388947194d, y: 0.2109928256570589d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016142349948319d, y: 0.23999891888233638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471511454631702d, y: 0.36607242148223396d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6492089732890562d, y: 0.04985058790470642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235684819610493d, y: 0.43889044486864404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6952602259506278d, y: 0.5218868755687976d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20048140547300286d, y: 0.4842089486855423d), new NpgsqlTypes.NpgsqlPoint(x: 0.158097214459352d, y: 0.8514971643104916d), new NpgsqlTypes.NpgsqlPoint(x: 0.09503274800821249d, y: 0.7924716952258426d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19080538116651224d, y: 0.2633007336225791d), new NpgsqlTypes.NpgsqlPoint(x: 0.37913835775618887d, y: 0.0750959459991386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155003520505574d, y: 0.1411622600609147d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5849524611774113d, y: 0.6955729395063025d), new NpgsqlTypes.NpgsqlPoint(x: 0.13846987604972505d, y: 0.5269256380075219d), new NpgsqlTypes.NpgsqlPoint(x: 0.2455082769245418d, y: 0.8856005488095496d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7183119280009901d, y: 0.04264181515222243d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852641445020807d, y: 0.60514685354486d), new NpgsqlTypes.NpgsqlPoint(x: 0.26649680160223965d, y: 0.17368183515379942d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8507169887076633d, y: 0.5019553878944021d), new NpgsqlTypes.NpgsqlPoint(x: 0.642310236780306d, y: 0.32209260688224284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250137990140227d, y: 0.6682024930486093d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6687220388109416d, y: 0.37265163411207125d), new NpgsqlTypes.NpgsqlPoint(x: 0.28234022260014546d, y: 0.5425496772871694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666850495948242d, y: 0.9491947544695364d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9614956203780937d, y: 0.9917989614239672d), new NpgsqlTypes.NpgsqlPoint(x: 0.43295246658436126d, y: 0.7640899150864137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467513978602861d, y: 0.4314400612635174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5608844847348674d, y: 0.07046018668172138d), new NpgsqlTypes.NpgsqlPoint(x: 0.25092661403339267d, y: 0.23753641509771206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574194604378784d, y: 0.8088995862574246d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.189742623107237d, y: 0.7462906324363618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362713985929834d, y: 0.6589901662366402d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129983409772461d, y: 0.1567521616776687d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0126889425754948d, y: 0.47749434505693245d), new NpgsqlTypes.NpgsqlPoint(x: 0.808098692512004d, y: 0.7573351011012003d), new NpgsqlTypes.NpgsqlPoint(x: 0.860960705469753d, y: 0.5536278163885447d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8506604149354181d, y: 0.8448059471517896d), new NpgsqlTypes.NpgsqlPoint(x: 0.970720284607686d, y: 0.31392681189620775d), new NpgsqlTypes.NpgsqlPoint(x: 0.39758849659295714d, y: 0.42849015555440384d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021885592001675058d, y: 0.6485579402047417d), new NpgsqlTypes.NpgsqlPoint(x: 0.31843560044923425d, y: 0.6621336135391798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4513175564276487d, y: 0.5487207466716687d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.465226066649456d, y: 0.17968392167840352d), new NpgsqlTypes.NpgsqlPoint(x: 0.18415192219449739d, y: 0.053764522497059763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8001226950565152d, y: 0.8840267811437205d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5797323180416534d, y: 0.10811073413816841d), new NpgsqlTypes.NpgsqlPoint(x: 0.3052882421901614d, y: 0.3780538237018859d), new NpgsqlTypes.NpgsqlPoint(x: 0.23616115700245066d, y: 0.8367380811175288d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9302672144318275d, y: 0.9539670261201068d), new NpgsqlTypes.NpgsqlPoint(x: 0.2512039152354404d, y: 0.4249869826649133d), new NpgsqlTypes.NpgsqlPoint(x: 0.26793781021602725d, y: 0.5703027622554895d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013834184843518949d, y: 0.5820702210255689d), new NpgsqlTypes.NpgsqlPoint(x: 0.4216289578732313d, y: 0.9856448324571493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050912553962587d, y: 0.3592959206559003d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008435885364093565d, y: 0.8688041404630966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275971822299199d, y: 0.22362934168004012d), new NpgsqlTypes.NpgsqlPoint(x: 0.1555701471416634d, y: 0.7290586941982209d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.935412858819049d, y: 0.9834582789711622d), new NpgsqlTypes.NpgsqlPoint(x: 0.28107937736131416d, y: 0.034479525006884115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701648047805927d, y: 0.3844219337848087d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9625409105088197d, y: 0.04047189399031803d), new NpgsqlTypes.NpgsqlPoint(x: 0.3312201905594685d, y: 0.28496202579995966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3142087949073097d, y: 0.9238003158388378d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7866836971396047d, y: 0.025023971338377415d), new NpgsqlTypes.NpgsqlPoint(x: 0.014567617654677067d, y: 0.16672152017268171d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856455382267325d, y: 0.3840121391225373d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10199004889790708d, y: 0.229382954812273d), new NpgsqlTypes.NpgsqlPoint(x: 0.047661436517802525d, y: 0.9420106607694188d), new NpgsqlTypes.NpgsqlPoint(x: 0.7176171560733515d, y: 0.4683875644438077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3846397877698482d, y: 0.3112616792139865d), new NpgsqlTypes.NpgsqlPoint(x: 0.595757737817456d, y: 0.6628170428623356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5185835735051647d, y: 0.5627149011503296d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08812864020430766d, y: 0.246749781016805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8354898180005705d, y: 0.938183028545869d), new NpgsqlTypes.NpgsqlPoint(x: 0.30460754158679815d, y: 0.8469894340243201d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9493893487486311d, y: 0.842767433033253d), new NpgsqlTypes.NpgsqlPoint(x: 0.503960321076651d, y: 0.6319261824625316d), new NpgsqlTypes.NpgsqlPoint(x: 0.20098992341375055d, y: 0.09814148862504868d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007462748777425143d, y: 0.37318115692030007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564914702711856d, y: 0.9642594122402057d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013415799169722d, y: 0.9245838781008507d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2392355402160914d, y: 0.4365067254305818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263287867079935d, y: 0.6342415728522003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304675311312121d, y: 0.6835769125821436d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1754169427240817d, y: 0.22764351978567177d), new NpgsqlTypes.NpgsqlPoint(x: 0.20017302151006577d, y: 0.908243603147519d), new NpgsqlTypes.NpgsqlPoint(x: 0.533917903376961d, y: 0.0725884471169761d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11787765973576991d, y: 0.45872203613308227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401538806322426d, y: 0.6778245185347974d), new NpgsqlTypes.NpgsqlPoint(x: 0.1722275901237782d, y: 0.9408178935980847d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33621608626676525d, y: 0.7788821927628752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840589482475651d, y: 0.46458136222197477d), new NpgsqlTypes.NpgsqlPoint(x: 0.23727625674042074d, y: 0.30013094622952907d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09412669375677918d, y: 0.22903941498140257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9027459346554342d, y: 0.6580283524337646d), new NpgsqlTypes.NpgsqlPoint(x: 0.12429477058257354d, y: 0.8521503704794834d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44112306035238924d, y: 0.23696075779116d), new NpgsqlTypes.NpgsqlPoint(x: 0.3278280198952359d, y: 0.3892233171490286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535005510133831d, y: 0.5905929516227635d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5658403007952951d, y: 0.4201366917824356d), new NpgsqlTypes.NpgsqlPoint(x: 0.1373400040474716d, y: 0.9216437959628975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7041811354227189d, y: 0.856311732500936d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2086018833500688d, y: 0.9756424814414029d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178606856052459d, y: 0.21403193417721367d), new NpgsqlTypes.NpgsqlPoint(x: 0.624000152946281d, y: 0.2438202289370387d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.670891999814408d, y: 0.30014464379864625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324905943766273d, y: 0.19092374543498347d), new NpgsqlTypes.NpgsqlPoint(x: 0.011965867280229303d, y: 0.6318066887422937d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4374616781210453d, y: 0.978213386481694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748450931540415d, y: 0.03844176053837811d), new NpgsqlTypes.NpgsqlPoint(x: 0.06518386166504608d, y: 0.12427714415679991d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3120010822378485d, y: 0.7045259033129991d), new NpgsqlTypes.NpgsqlPoint(x: 0.24402707835067938d, y: 0.7780307177861677d), new NpgsqlTypes.NpgsqlPoint(x: 0.3223417716301219d, y: 0.7402513015577544d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14287509527978992d, y: 0.30936845096899335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051277576109857d, y: 0.218724292775331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227727434788441d, y: 0.759920365028259d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.687045481077556d, y: 0.39785180477473114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4087062255592916d, y: 0.33828291166651736d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645108835180896d, y: 0.5663931908343323d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04204371666298923d, y: 0.25272789157566233d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943596162730004d, y: 0.6728353745349047d), new NpgsqlTypes.NpgsqlPoint(x: 0.571859689652428d, y: 0.5973921547825195d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4328896119886668d, y: 0.24211005259733576d), new NpgsqlTypes.NpgsqlPoint(x: 0.28243779876348285d, y: 0.11564836412259727d), new NpgsqlTypes.NpgsqlPoint(x: 0.907739262392607d, y: 0.8850240725532567d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3946503846201226d, y: 0.9349648751199551d), new NpgsqlTypes.NpgsqlPoint(x: 0.8662130820119036d, y: 0.5872696922143619d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710069687093154d, y: 0.31342827447850385d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40335568111518316d, y: 0.35496928502266323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7544262146810852d, y: 0.8110802830209475d), new NpgsqlTypes.NpgsqlPoint(x: 0.40811000200683434d, y: 0.806007810364765d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6979971130083718d, y: 0.5466221396933548d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836822868087049d, y: 0.3048509915170068d), new NpgsqlTypes.NpgsqlPoint(x: 0.010468272415320112d, y: 0.7810913631235135d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8912507892008744d, y: 0.5052655999950966d), new NpgsqlTypes.NpgsqlPoint(x: 0.32247808235090114d, y: 0.8923619937891565d), new NpgsqlTypes.NpgsqlPoint(x: 0.14360412334036288d, y: 0.8141362363261779d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6638641507710503d, y: 0.8009778359879495d), new NpgsqlTypes.NpgsqlPoint(x: 0.4929910543392998d, y: 0.4327760267568198d), new NpgsqlTypes.NpgsqlPoint(x: 0.18200706297965796d, y: 0.03394826684067598d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27139627254908094d, y: 0.7611524405735764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429179683903092d, y: 0.5656381841256644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7875958564557971d, y: 0.05540230901948995d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2933824265390781d, y: 0.12895537997473538d), new NpgsqlTypes.NpgsqlPoint(x: 0.47961746329319543d, y: 0.9195098346952334d), new NpgsqlTypes.NpgsqlPoint(x: 0.18060268086170894d, y: 0.22059493042597433d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7113782860898054d, y: 0.6979229725523948d), new NpgsqlTypes.NpgsqlPoint(x: 0.634824300888647d, y: 0.2078218595707001d), new NpgsqlTypes.NpgsqlPoint(x: 0.09533168716976315d, y: 0.564268344641303d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8282961455151225d, y: 0.21437924412395948d), new NpgsqlTypes.NpgsqlPoint(x: 0.20219241226791274d, y: 0.5606813474229243d), new NpgsqlTypes.NpgsqlPoint(x: 0.11226698420694037d, y: 0.8766155438372476d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.299209616591641d, y: 0.08124049490523355d), new NpgsqlTypes.NpgsqlPoint(x: 0.0642006690391802d, y: 0.09632387934617159d), new NpgsqlTypes.NpgsqlPoint(x: 0.137319677508418d, y: 0.20145691134790955d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31119831058709346d, y: 0.3042141342428385d), new NpgsqlTypes.NpgsqlPoint(x: 0.19522923344702614d, y: 0.012875097787642398d), new NpgsqlTypes.NpgsqlPoint(x: 0.3830244037678714d, y: 0.16317385962747577d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03815683285522109d, y: 0.0708478184487239d), new NpgsqlTypes.NpgsqlPoint(x: 0.11091748137679036d, y: 0.21150771589809247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2824474914574805d, y: 0.3077045466126742d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9695896750236495d, y: 0.19816015659399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056817849158425d, y: 0.3842658798416244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334731112114912d, y: 0.7697859025360873d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9095527227731418d, y: 0.8578934372233621d), new NpgsqlTypes.NpgsqlPoint(x: 0.569726913528401d, y: 0.7550704452080783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894483378806846d, y: 0.1643976423528506d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22506356711515263d, y: 0.26313210453008773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707128663409986d, y: 0.7809029432233867d), new NpgsqlTypes.NpgsqlPoint(x: 0.12828511557832611d, y: 0.45244559009535024d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03337680945503063d, y: 0.08754375703375583d), new NpgsqlTypes.NpgsqlPoint(x: 0.43676524134587713d, y: 0.8211155043175464d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555274664280887d, y: 0.6981562228906988d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5642590414313907d, y: 0.07929948161612377d), new NpgsqlTypes.NpgsqlPoint(x: 0.2485431470812297d, y: 0.22128540887508785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423361671480465d, y: 0.1787712370502036d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24727102044248328d, y: 0.3174508121071957d), new NpgsqlTypes.NpgsqlPoint(x: 0.7706866696218894d, y: 0.758705224432221d), new NpgsqlTypes.NpgsqlPoint(x: 0.14063373276627944d, y: 0.7158683276316539d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0038775022201831266d, y: 0.3180926662988517d), new NpgsqlTypes.NpgsqlPoint(x: 0.8099248858233321d, y: 0.1849959727932572d), new NpgsqlTypes.NpgsqlPoint(x: 0.4692563217607989d, y: 0.5134272948914222d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.558341748096491d, y: 0.8057950449820339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108183237714983d, y: 0.9042396011547081d), new NpgsqlTypes.NpgsqlPoint(x: 0.13726376153728537d, y: 0.5935636966188357d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40941743539653264d, y: 0.28979805140493964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528135303584717d, y: 0.8075250494980684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6685649819753532d, y: 0.9788330853650078d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6421851494439375d, y: 0.520244432598936d), new NpgsqlTypes.NpgsqlPoint(x: 0.14429520601526558d, y: 0.27176961799173105d), new NpgsqlTypes.NpgsqlPoint(x: 0.12096136538829028d, y: 0.568243270174304d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4781719161200121d, y: 0.13280660812788658d), new NpgsqlTypes.NpgsqlPoint(x: 0.5548964444467461d, y: 0.18861578506789223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116440408189717d, y: 0.49661535233942733d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24396325857386636d, y: 0.9800778072288588d), new NpgsqlTypes.NpgsqlPoint(x: 0.880112030307201d, y: 0.7794554217618874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255737684110388d, y: 0.13096137485571546d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6008158538199435d, y: 0.43744995132667897d), new NpgsqlTypes.NpgsqlPoint(x: 0.4266948005512692d, y: 0.5622098150185258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759521264685259d, y: 0.3425896095232487d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4556874620910042d, y: 0.7979160776345751d), new NpgsqlTypes.NpgsqlPoint(x: 0.4820200269743923d, y: 0.5477715357056813d), new NpgsqlTypes.NpgsqlPoint(x: 0.33310683802799324d, y: 0.8173594337054174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24193329665492147d, y: 0.5111910869640942d), new NpgsqlTypes.NpgsqlPoint(x: 0.895282143757848d, y: 0.9814733301099545d), new NpgsqlTypes.NpgsqlPoint(x: 0.16005746019836864d, y: 0.8037916518423727d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0956006658842099d, y: 0.6353706962408091d), new NpgsqlTypes.NpgsqlPoint(x: 0.07890947437759266d, y: 0.0921185531999884d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011753158154046428d, y: 0.37095495511773546d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7734663082990539d, y: 0.7096480761221496d), new NpgsqlTypes.NpgsqlPoint(x: 0.28386254914966524d, y: 0.3623551364391522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993295104946067d, y: 0.9755194178343866d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4608722131783859d, y: 0.6385749457408108d), new NpgsqlTypes.NpgsqlPoint(x: 0.988482642353218d, y: 0.647722594930528d), new NpgsqlTypes.NpgsqlPoint(x: 0.8434790304752756d, y: 0.8870460357916138d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8801897794416225d, y: 0.4800365358627814d), new NpgsqlTypes.NpgsqlPoint(x: 0.825360533798111d, y: 0.874222731665944d), new NpgsqlTypes.NpgsqlPoint(x: 0.1009252464699375d, y: 0.001563127246930196d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8067267880944183d, y: 0.8741048418037063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231342577132135d, y: 0.7623482016773659d), new NpgsqlTypes.NpgsqlPoint(x: 0.45058295017691186d, y: 0.0990965930826534d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8714671457175059d, y: 0.2587673887506615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650390397954024d, y: 0.7875618373729053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853556946036213d, y: 0.7475759199869222d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27788123147318433d, y: 0.7001103072828397d), new NpgsqlTypes.NpgsqlPoint(x: 0.686253532036832d, y: 0.45659521170088635d), new NpgsqlTypes.NpgsqlPoint(x: 0.40307592689197413d, y: 0.92176390682013d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.343710344037121d, y: 0.8585276946710079d), new NpgsqlTypes.NpgsqlPoint(x: 0.4643062062827432d, y: 0.6347678930574416d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741766873489625d, y: 0.9947852439058473d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36601267606318055d, y: 0.7636182320188375d), new NpgsqlTypes.NpgsqlPoint(x: 0.19631869278477487d, y: 0.04369364536552878d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832221820291726d, y: 0.6254018564886904d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3168500809098571d, y: 0.6962144529919689d), new NpgsqlTypes.NpgsqlPoint(x: 0.28476829187256236d, y: 0.9903058816718627d), new NpgsqlTypes.NpgsqlPoint(x: 0.626283816671516d, y: 0.3541824260455354d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9280381078348873d, y: 0.6263261150678648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5490221054812933d, y: 0.4828753950722483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9858822513607416d, y: 0.924494154350483d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9625553162513617d, y: 0.6586783071592287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194393038673817d, y: 0.1271776099457863d), new NpgsqlTypes.NpgsqlPoint(x: 0.12970867491375604d, y: 0.9422289765499777d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6069404034123874d, y: 0.026807056473388546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456795032618457d, y: 0.8127544349450738d), new NpgsqlTypes.NpgsqlPoint(x: 0.802605283563632d, y: 0.24461794851572205d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6869338011353952d, y: 0.7858806162911784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6169383139062847d, y: 0.1067790269325265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8510757289011446d, y: 0.1685122004955868d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6116050882032232d, y: 0.46815199382027783d), new NpgsqlTypes.NpgsqlPoint(x: 0.1500590736005042d, y: 0.09437554305140572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8382325994640641d, y: 0.8496416234629848d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1681035336604677d, y: 0.6889030260243479d), new NpgsqlTypes.NpgsqlPoint(x: 0.08680721412148795d, y: 0.1685367083090108d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727557983782116d, y: 0.46439344987247433d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03125473417893654d, y: 0.623578758515347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5391146207457297d, y: 0.24442969095105327d), new NpgsqlTypes.NpgsqlPoint(x: 0.43436130769866177d, y: 0.03933721768774456d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8727211157155715d, y: 0.122738728813241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272084140809447d, y: 0.8920201653893355d), new NpgsqlTypes.NpgsqlPoint(x: 0.88207583270056d, y: 0.07649288727741677d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5116950363156018d, y: 0.011743677472838221d), new NpgsqlTypes.NpgsqlPoint(x: 0.12374362779566228d, y: 0.6753133645313152d), new NpgsqlTypes.NpgsqlPoint(x: 0.019406785220167144d, y: 0.38101457302505326d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5646374065700093d, y: 0.16206550450344104d), new NpgsqlTypes.NpgsqlPoint(x: 0.1354083715271147d, y: 0.9017757292481666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878987270477551d, y: 0.23385709172166091d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9451803972021964d, y: 0.42411624534047354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471599388272424d, y: 0.8867771008122224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315537908338739d, y: 0.10821751192742346d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.162858072668707d, y: 0.444956239374964d), new NpgsqlTypes.NpgsqlPoint(x: 0.764020265350779d, y: 0.014996598215394452d), new NpgsqlTypes.NpgsqlPoint(x: 0.036923811912449866d, y: 0.7690419655624053d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6631966204308256d, y: 0.2319166270880978d), new NpgsqlTypes.NpgsqlPoint(x: 0.28397145456726725d, y: 0.420654356621859d), new NpgsqlTypes.NpgsqlPoint(x: 0.32221053990421844d, y: 0.40433812164752236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24520902006468825d, y: 0.5723216825398509d), new NpgsqlTypes.NpgsqlPoint(x: 0.015093037827171085d, y: 0.07524263510481355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531808117758371d, y: 0.30472585390843177d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1876363501199475d, y: 0.8937834746536112d), new NpgsqlTypes.NpgsqlPoint(x: 0.618050808391771d, y: 0.12369724197164822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6247111874395198d, y: 0.0805957532717152d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8006767200942829d, y: 0.5139082086151323d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162837262151369d, y: 0.43055377782796356d), new NpgsqlTypes.NpgsqlPoint(x: 0.10853616465643778d, y: 0.5108123067701037d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06277320241980344d, y: 0.7292743828571137d), new NpgsqlTypes.NpgsqlPoint(x: 0.46297812790863d, y: 0.5436315560766921d), new NpgsqlTypes.NpgsqlPoint(x: 0.013168158176663725d, y: 0.4967591219993184d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3394756258970758d, y: 0.6185415470432112d), new NpgsqlTypes.NpgsqlPoint(x: 0.28431295045872673d, y: 0.035809124658064406d), new NpgsqlTypes.NpgsqlPoint(x: 0.06092212324307211d, y: 0.9923155089320402d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6486800159123373d, y: 0.6425790603575512d), new NpgsqlTypes.NpgsqlPoint(x: 0.27690485519428343d, y: 0.545913982510907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7047046828829772d, y: 0.6929580097652397d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6102141886330361d, y: 0.4092477342480876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346131113366791d, y: 0.1318248759736942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5898385949684836d, y: 0.20302177242118302d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.487538489047426d, y: 0.3563688237993107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3807466583116923d, y: 0.409342880568484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121315825708993d, y: 0.6141725352009038d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8680609826072447d, y: 0.8842547679137365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913891455688498d, y: 0.599363997501326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6558001870996283d, y: 0.7143720602448413d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3551223767011895d, y: 0.7377940569427222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363637403816171d, y: 0.05551907034197523d), new NpgsqlTypes.NpgsqlPoint(x: 0.2159011305145766d, y: 0.1741084365494323d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5571458525311861d, y: 0.3321079102257678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038853863915295d, y: 0.2786371458580186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2302239806046179d, y: 0.7947951619292181d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48962485907617836d, y: 0.13896767878489402d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727316218228805d, y: 0.47366730042935623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388742726491726d, y: 0.3664906295617075d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6106502681762718d, y: 0.9807199048799028d), new NpgsqlTypes.NpgsqlPoint(x: 0.10279125445432613d, y: 0.2261194993878004d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048424453647809d, y: 0.8815961335088437d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6710500584798492d, y: 0.8956133106019438d), new NpgsqlTypes.NpgsqlPoint(x: 0.05684310232893652d, y: 0.6127492588079058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6142984176805486d, y: 0.12472301042116252d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12762779235590116d, y: 0.22268396548006764d), new NpgsqlTypes.NpgsqlPoint(x: 0.3828068093692093d, y: 0.4996554920491184d), new NpgsqlTypes.NpgsqlPoint(x: 0.06999314456448558d, y: 0.7938914549389928d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2966863805149482d, y: 0.7889532200957244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5989921740566082d, y: 0.43310032443080726d), new NpgsqlTypes.NpgsqlPoint(x: 0.879739107597202d, y: 0.2423425189866243d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7242344426867368d, y: 0.998626276433782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5590679232236573d, y: 0.8998829472001912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880782541041198d, y: 0.28756641825572316d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06811647274674204d, y: 0.3581608885390354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4012198087963471d, y: 0.8856018318593212d), new NpgsqlTypes.NpgsqlPoint(x: 0.2302009348741877d, y: 0.7946013968110215d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6603500118141444d, y: 0.3099764835143085d), new NpgsqlTypes.NpgsqlPoint(x: 0.1029815412528512d, y: 0.6329055952189016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4020052866663425d, y: 0.4528661871570774d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9931055732793026d, y: 0.8977290367204817d), new NpgsqlTypes.NpgsqlPoint(x: 0.018139216753854104d, y: 0.2885430736847583d), new NpgsqlTypes.NpgsqlPoint(x: 0.9069725425551334d, y: 0.9857740336724771d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7988886902193221d, y: 0.6156948116123826d), new NpgsqlTypes.NpgsqlPoint(x: 0.36011987142640867d, y: 0.20721457479384753d), new NpgsqlTypes.NpgsqlPoint(x: 0.0655559061347799d, y: 0.28500761614750614d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4872423736752378d, y: 0.45866824450763455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010796692444403d, y: 0.2487177105201026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732042590770052d, y: 0.7028684008658814d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6499502931789869d, y: 0.09006655585684886d), new NpgsqlTypes.NpgsqlPoint(x: 0.19868336012451604d, y: 0.1889007165972313d), new NpgsqlTypes.NpgsqlPoint(x: 0.052371029086349496d, y: 0.9352209480611302d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5298623935446565d, y: 0.008435498029664257d), new NpgsqlTypes.NpgsqlPoint(x: 0.24083085446808483d, y: 0.459217128914464d), new NpgsqlTypes.NpgsqlPoint(x: 0.13777659213006066d, y: 0.9271896355488047d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5292954792700743d, y: 0.13717798943792048d), new NpgsqlTypes.NpgsqlPoint(x: 0.22663953282134786d, y: 0.31913017194941695d), new NpgsqlTypes.NpgsqlPoint(x: 0.21690990820633949d, y: 0.3372983877412279d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6316212940740565d, y: 0.11093890167781872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453305019983858d, y: 0.6859662106769241d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454368153611511d, y: 0.869325132395691d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9550147353667547d, y: 0.07765850298274246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8831587046259485d, y: 0.3860642158356302d), new NpgsqlTypes.NpgsqlPoint(x: 0.16474640688755604d, y: 0.7086165716840377d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00600683663181234d, y: 0.9798690676841639d), new NpgsqlTypes.NpgsqlPoint(x: 0.1790361576276429d, y: 0.8450431926592129d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900246868881232d, y: 0.4266812077225417d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44606355446707613d, y: 0.014644546610096287d), new NpgsqlTypes.NpgsqlPoint(x: 0.06966139675456895d, y: 0.4961188886737644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7083314795196121d, y: 0.445533255455573d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9299453485434802d, y: 0.6467181559955848d), new NpgsqlTypes.NpgsqlPoint(x: 0.30709082982782565d, y: 0.3788242064199513d), new NpgsqlTypes.NpgsqlPoint(x: 0.32673445414994684d, y: 0.7392091019189869d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7816111781305097d, y: 0.30749910876250064d), new NpgsqlTypes.NpgsqlPoint(x: 0.048029893006176105d, y: 0.5164297447475097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766185470859305d, y: 0.6550944739725911d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3728373053181714d, y: 0.15325552992520874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5125821004192643d, y: 0.7344412977431605d), new NpgsqlTypes.NpgsqlPoint(x: 0.6533851976440589d, y: 0.2606628332769819d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32633849891273414d, y: 0.24505737860506904d), new NpgsqlTypes.NpgsqlPoint(x: 0.3358789177559479d, y: 0.9500772911861298d), new NpgsqlTypes.NpgsqlPoint(x: 0.937925806335826d, y: 0.9242755045402105d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02858810923201205d, y: 0.828794307493404d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403364414531498d, y: 0.39908372819752147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203451806640761d, y: 0.5203605461680678d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5969778879419807d, y: 0.15613829402290003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5058161102791169d, y: 0.3894004942285644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720019253043937d, y: 0.2683305481063053d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6628411227789264d, y: 0.011875939181410389d), new NpgsqlTypes.NpgsqlPoint(x: 0.3503957962775681d, y: 0.4279608573137206d), new NpgsqlTypes.NpgsqlPoint(x: 0.25077957137141915d, y: 0.19795149802691403d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7644978008821051d, y: 0.7024031885007593d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998910620957342d, y: 0.18120310643891446d), new NpgsqlTypes.NpgsqlPoint(x: 0.679951842261415d, y: 0.225731060311115d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9681554094409431d, y: 0.8175537637038299d), new NpgsqlTypes.NpgsqlPoint(x: 0.12770621516635083d, y: 0.1229948541631184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4456858544788953d, y: 0.6479582030210993d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5431594946448992d, y: 0.28568228551672326d), new NpgsqlTypes.NpgsqlPoint(x: 0.46317982300072713d, y: 0.0008825671380628952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3770768078538551d, y: 0.8305142469512223d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9184170793599178d, y: 0.4860822758225293d), new NpgsqlTypes.NpgsqlPoint(x: 0.27104392195100224d, y: 0.6187834767359407d), new NpgsqlTypes.NpgsqlPoint(x: 0.42428237045413875d, y: 0.7001834660538027d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.442784720331562d, y: 0.807019708652792d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354929160043772d, y: 0.9516866194791941d), new NpgsqlTypes.NpgsqlPoint(x: 0.12478989429006515d, y: 0.48301851340252d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6910536912327188d, y: 0.9086532757182489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250490889109801d, y: 0.5991856653787275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753613903282896d, y: 0.007477578209579727d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9596440306629379d, y: 0.5862717445581149d), new NpgsqlTypes.NpgsqlPoint(x: 0.27489526403665854d, y: 0.05029460310789302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274340038755692d, y: 0.7771311380081914d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10178793185266999d, y: 0.018422436857508107d), new NpgsqlTypes.NpgsqlPoint(x: 0.989496674486485d, y: 0.15013085027294304d), new NpgsqlTypes.NpgsqlPoint(x: 0.732590643221746d, y: 0.05640904722516915d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3479608118661588d, y: 0.07942046796892932d), new NpgsqlTypes.NpgsqlPoint(x: 0.020714802653765907d, y: 0.21628649692223278d), new NpgsqlTypes.NpgsqlPoint(x: 0.15864415800055398d, y: 0.7078512777886974d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6364768662571659d, y: 0.06906510628663642d), new NpgsqlTypes.NpgsqlPoint(x: 0.593986080203162d, y: 0.5892685014660453d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896813908463766d, y: 0.8690495223486261d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7970519150585029d, y: 0.05086047145536865d), new NpgsqlTypes.NpgsqlPoint(x: 0.45054164668466856d, y: 0.5210607474278819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190287649398027d, y: 0.426211152943061d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8654643413355977d, y: 0.3923128271810211d), new NpgsqlTypes.NpgsqlPoint(x: 0.05743353726090161d, y: 0.6720177019724518d), new NpgsqlTypes.NpgsqlPoint(x: 0.41972229363073454d, y: 0.20216088822453615d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9018482750672744d, y: 0.5457905876809811d), new NpgsqlTypes.NpgsqlPoint(x: 0.15784498259268442d, y: 0.1183788187041479d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736183103200067d, y: 0.7177609643456456d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24296654670812756d, y: 0.5125157567359521d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807926366378235d, y: 0.6929439521490839d), new NpgsqlTypes.NpgsqlPoint(x: 0.39438148500821735d, y: 0.14669704730452238d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9679886194403459d, y: 0.7323862058693819d), new NpgsqlTypes.NpgsqlPoint(x: 0.05964822758686472d, y: 0.830219963049357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8077701585621357d, y: 0.5363268647120341d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.113748944175322d, y: 0.2962384725938946d), new NpgsqlTypes.NpgsqlPoint(x: 0.014182810015829994d, y: 0.12106889159022782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8815047273082841d, y: 0.465897772777513d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8690693694395619d, y: 0.48647770035007576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757218660243072d, y: 0.37132731764885163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061856891207879d, y: 0.9087030728017542d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0731637019653183d, y: 0.6577542874553646d), new NpgsqlTypes.NpgsqlPoint(x: 0.248741674927332d, y: 0.7032536312968072d), new NpgsqlTypes.NpgsqlPoint(x: 0.4156289805433748d, y: 0.2565647561536307d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35070646085045254d, y: 0.9870487564753405d), new NpgsqlTypes.NpgsqlPoint(x: 0.4952543416482075d, y: 0.7503577536843172d), new NpgsqlTypes.NpgsqlPoint(x: 0.939941088065577d, y: 0.6059621454455538d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4845245577289804d, y: 0.11191269275549509d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025957148347397d, y: 0.596976625649082d), new NpgsqlTypes.NpgsqlPoint(x: 0.870162081220319d, y: 0.14680682358585906d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32956432651685486d, y: 0.0759252328470158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023055742825788d, y: 0.5922555482778132d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313202842083359d, y: 0.6636997769734484d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7793126697364345d, y: 0.7436768143685281d), new NpgsqlTypes.NpgsqlPoint(x: 0.08174389631583379d, y: 0.18563945649874047d), new NpgsqlTypes.NpgsqlPoint(x: 0.20155135521184164d, y: 0.15767229489856704d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9394658645857178d, y: 0.25889951131760724d), new NpgsqlTypes.NpgsqlPoint(x: 0.2947550388836607d, y: 0.8355630384906867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3248029378267836d, y: 0.7872445389181874d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8049308919706925d, y: 0.940674470813515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413576942742467d, y: 0.25700732702828233d), new NpgsqlTypes.NpgsqlPoint(x: 0.07839246047853132d, y: 0.9914908498842168d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.829972810345376d, y: 0.2926754104257876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7691507334881623d, y: 0.8575670964350578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819574557315264d, y: 0.006421407320087225d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5605008128298281d, y: 0.7695844293330132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6762413044763624d, y: 0.7624643176759672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958735931779859d, y: 0.6885929038941861d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45621734457091956d, y: 0.9548607497619362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165039537669048d, y: 0.9977294579227403d), new NpgsqlTypes.NpgsqlPoint(x: 0.42643273079463084d, y: 0.33948232921686095d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5375721815519032d, y: 0.8113803065234927d), new NpgsqlTypes.NpgsqlPoint(x: 0.333950015016622d, y: 0.837682167181979d), new NpgsqlTypes.NpgsqlPoint(x: 0.5377658432521583d, y: 0.5838545931145359d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.458767807300248d, y: 0.13742953079102838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705184213703801d, y: 0.5164483607289809d), new NpgsqlTypes.NpgsqlPoint(x: 0.918240674043452d, y: 0.04643970986089918d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8627807741771925d, y: 0.6795474136451799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151638967255475d, y: 0.4927159511736282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045357105253196d, y: 0.5657394306056786d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7017747143373955d, y: 0.2939026002793098d), new NpgsqlTypes.NpgsqlPoint(x: 0.6773570921987261d, y: 0.9010957621059666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3630718919503968d, y: 0.4949291930554417d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00614453053057562d, y: 0.07521969800713035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5200223772746865d, y: 0.5580335725837954d), new NpgsqlTypes.NpgsqlPoint(x: 0.524371656108112d, y: 0.5119422039248372d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6743099912016964d, y: 0.7140397014383617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184058353009787d, y: 0.37968716072683684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184795446987055d, y: 0.5952983152623181d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41155445512882927d, y: 0.5204522961663088d), new NpgsqlTypes.NpgsqlPoint(x: 0.787676469353151d, y: 0.43390967345069886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022278087619463d, y: 0.83437115084155d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5579429252593648d, y: 0.6618310599790629d), new NpgsqlTypes.NpgsqlPoint(x: 0.31602389505010997d, y: 0.5948141954751127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022963969714734d, y: 0.5570592066126052d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8858411944040574d, y: 0.065482217853302d), new NpgsqlTypes.NpgsqlPoint(x: 0.25601529805958234d, y: 0.11464496464909268d), new NpgsqlTypes.NpgsqlPoint(x: 0.38037384253857554d, y: 0.691653836976069d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777831635177075d, y: 0.27438155344681947d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124405087901099d, y: 0.9005719187924144d), new NpgsqlTypes.NpgsqlPoint(x: 0.21765447497012902d, y: 0.12200141096006345d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46074611199578275d, y: 0.6050314540623576d), new NpgsqlTypes.NpgsqlPoint(x: 0.26199037427936744d, y: 0.3331916408729081d), new NpgsqlTypes.NpgsqlPoint(x: 0.10526968871673992d, y: 0.5450354022304473d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6507211439114214d, y: 0.7713976151273437d), new NpgsqlTypes.NpgsqlPoint(x: 0.007603231771418195d, y: 0.24931430922329256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744943298480245d, y: 0.8677409182253621d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29782939755793014d, y: 0.9161121596205772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499918794025433d, y: 0.7460622827380546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6976391977421846d, y: 0.6899432093702363d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8456166024039568d, y: 0.17355281780589038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5726536572535061d, y: 0.7725479633514717d), new NpgsqlTypes.NpgsqlPoint(x: 0.2021755147218166d, y: 0.6936496075511464d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8363500464419696d, y: 0.31693026930083246d), new NpgsqlTypes.NpgsqlPoint(x: 0.006706086836851033d, y: 0.6850177210534705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364940713768718d, y: 0.5851716105728538d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7961904091530773d, y: 0.6895710938908789d), new NpgsqlTypes.NpgsqlPoint(x: 0.0893130053623864d, y: 0.7731579525273419d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278912126570677d, y: 0.07943290467274311d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2653948422987841d, y: 0.2835873861142285d), new NpgsqlTypes.NpgsqlPoint(x: 0.3961963777458273d, y: 0.7819360738331105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289583792214827d, y: 0.2687821083804276d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3647111442238009d, y: 0.1538756330732297d), new NpgsqlTypes.NpgsqlPoint(x: 0.980578570190858d, y: 0.2518059538728813d), new NpgsqlTypes.NpgsqlPoint(x: 0.4591455254996766d, y: 0.4427158919692724d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38136852113193176d, y: 0.28853412528070954d), new NpgsqlTypes.NpgsqlPoint(x: 0.26447720912434036d, y: 0.9062792073719661d), new NpgsqlTypes.NpgsqlPoint(x: 0.3306051774144805d, y: 0.6365304433673075d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2969212876340227d, y: 0.47171576438890406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204025757488555d, y: 0.33697880652168144d), new NpgsqlTypes.NpgsqlPoint(x: 0.19708749394391922d, y: 0.6758728621999142d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7141813586427241d, y: 0.9611416933213218d), new NpgsqlTypes.NpgsqlPoint(x: 0.012541223361459686d, y: 0.48327274601146486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685338965930267d, y: 0.3878306932817446d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4090774916457076d, y: 0.7452067368203881d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003094620391059d, y: 0.19997010630708667d), new NpgsqlTypes.NpgsqlPoint(x: 0.26152628834651204d, y: 0.933935605674836d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.701471288130153d, y: 0.15121679545827627d), new NpgsqlTypes.NpgsqlPoint(x: 0.21555798515670288d, y: 0.42131692821361233d), new NpgsqlTypes.NpgsqlPoint(x: 0.18699589464315403d, y: 0.973382860791313d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8652373384123232d, y: 0.8383090220408321d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830754922647945d, y: 0.3648233502094772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5326072470079837d, y: 0.5917005316546452d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7992036439128233d, y: 0.730137915606071d), new NpgsqlTypes.NpgsqlPoint(x: 0.7409985318548884d, y: 0.7269759661904001d), new NpgsqlTypes.NpgsqlPoint(x: 0.672410930656379d, y: 0.8875919236642426d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1616574169280346d, y: 0.6007110674344266d), new NpgsqlTypes.NpgsqlPoint(x: 0.8840680332755002d, y: 0.6525904242903753d), new NpgsqlTypes.NpgsqlPoint(x: 0.14651226216716062d, y: 0.7990767818808122d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.835472035063059d, y: 0.4046632871516118d), new NpgsqlTypes.NpgsqlPoint(x: 0.19658799278015515d, y: 0.7954426570501184d), new NpgsqlTypes.NpgsqlPoint(x: 0.44653336628525586d, y: 0.7737238072265981d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37877001355343354d, y: 0.02739991498374894d), new NpgsqlTypes.NpgsqlPoint(x: 0.761161232639388d, y: 0.3216358340756573d), new NpgsqlTypes.NpgsqlPoint(x: 0.2832751123146432d, y: 0.2123196633335851d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1786151811533605d, y: 0.5489101231181734d), new NpgsqlTypes.NpgsqlPoint(x: 0.39398821104209725d, y: 0.33499062904177523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7480507141073017d, y: 0.9527211209966361d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33592900951532423d, y: 0.6093599136226938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9987765729697597d, y: 0.9976337922949039d), new NpgsqlTypes.NpgsqlPoint(x: 0.574776075744673d, y: 0.6504548761473253d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9444851218813308d, y: 0.43748045286734016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103102953489995d, y: 0.2632697227053624d), new NpgsqlTypes.NpgsqlPoint(x: 0.4225710808790667d, y: 0.303185168447192d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.769080276345995d, y: 0.3674766162398452d), new NpgsqlTypes.NpgsqlPoint(x: 0.31262474103826243d, y: 0.21275589138176365d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477802491306625d, y: 0.29853688589084926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7433619303589647d, y: 0.6611840794538482d), new NpgsqlTypes.NpgsqlPoint(x: 0.10000152334132861d, y: 0.9630003890190588d), new NpgsqlTypes.NpgsqlPoint(x: 0.6926338219131077d, y: 0.31173090375146373d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19856035669510386d, y: 0.0680816859635004d), new NpgsqlTypes.NpgsqlPoint(x: 0.14866464870972418d, y: 0.5437655364281376d), new NpgsqlTypes.NpgsqlPoint(x: 0.23283138015386595d, y: 0.06245059314614565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4640341292390068d, y: 0.9901192145315034d), new NpgsqlTypes.NpgsqlPoint(x: 0.030590123331311725d, y: 0.32758139368493144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9830602878868112d, y: 0.9559471522354783d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4713282719376315d, y: 0.9152234340962473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9723870364169929d, y: 0.6553181358299958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7257056981391553d, y: 0.9164791458671245d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3653190090965559d, y: 0.18718792595949074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6775151268690104d, y: 0.48064051091133964d), new NpgsqlTypes.NpgsqlPoint(x: 0.48411073932326754d, y: 0.04145818754266761d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4588104328214282d, y: 0.4086780533367448d), new NpgsqlTypes.NpgsqlPoint(x: 0.21714934363228d, y: 0.2433810392895147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714424774904356d, y: 0.30102240341344133d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6285210312028054d, y: 0.2502291500934244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051541060056234d, y: 0.8014553757900267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962224851131823d, y: 0.6117837453396846d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7415599879002265d, y: 0.68182588171637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801341936178089d, y: 0.5560530195680455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645334087706433d, y: 0.8534566572466554d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3055314499779016d, y: 0.31113401228786d), new NpgsqlTypes.NpgsqlPoint(x: 0.28851420691870455d, y: 0.6269269082057572d), new NpgsqlTypes.NpgsqlPoint(x: 0.035683943165107035d, y: 0.5635783211822669d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6541800955738754d, y: 0.07767656951117319d), new NpgsqlTypes.NpgsqlPoint(x: 0.2348281170562757d, y: 0.7403409221968116d), new NpgsqlTypes.NpgsqlPoint(x: 0.2555518332835407d, y: 0.6402280225763068d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8667001055071467d, y: 0.9243913884275639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348004345764429d, y: 0.24324058919309144d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961967802504757d, y: 0.09833333655767096d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6774299288476511d, y: 0.7630064794177408d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935174183039395d, y: 0.49316789209104483d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553213889124337d, y: 0.3748365930188535d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.820387614783808d, y: 0.21976531406967026d), new NpgsqlTypes.NpgsqlPoint(x: 0.49702253129734875d, y: 0.9055810264242594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317013858960768d, y: 0.3341119375508823d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26876547452177324d, y: 0.7996100774086289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570882617436218d, y: 0.05873408059605967d), new NpgsqlTypes.NpgsqlPoint(x: 0.29633432082114786d, y: 0.2528209335724759d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7673844635033916d, y: 0.6683795522364945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148871045493528d, y: 0.10887922305928477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978891002060594d, y: 0.6815181254622809d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12038040341937617d, y: 0.947456225429866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541566244727124d, y: 0.689979182020647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6523820191509011d, y: 0.8015868380233127d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4046315053795918d, y: 0.8737382637360206d), new NpgsqlTypes.NpgsqlPoint(x: 0.13559058909012145d, y: 0.9788597081970262d), new NpgsqlTypes.NpgsqlPoint(x: 0.16646815111576996d, y: 0.19119559354244076d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8032903853060851d, y: 0.8324702158085264d), new NpgsqlTypes.NpgsqlPoint(x: 0.0852025488247724d, y: 0.26636991704017965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116948161659735d, y: 0.3159969592365457d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27179696317033564d, y: 0.16706601053902537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169301448667164d, y: 0.5390424386264505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4732744403366881d, y: 0.46104840243306333d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8721523397978415d, y: 0.33411247737954597d), new NpgsqlTypes.NpgsqlPoint(x: 0.49797235313811805d, y: 0.8269189384746182d), new NpgsqlTypes.NpgsqlPoint(x: 0.021199365288403715d, y: 0.1300638025385692d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4283440337554685d, y: 0.7764826365964069d), new NpgsqlTypes.NpgsqlPoint(x: 0.05353918152647463d, y: 0.5117699482317537d), new NpgsqlTypes.NpgsqlPoint(x: 0.26877170672474193d, y: 0.9203820411662654d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5257808473758562d, y: 0.3708823666909754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5230054770963568d, y: 0.31216187038167875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085142203984881d, y: 0.4003319790072887d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4793768208144539d, y: 0.9041927932717221d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166111605464587d, y: 0.11950161252890956d), new NpgsqlTypes.NpgsqlPoint(x: 0.04135771754018047d, y: 0.036783911351418896d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7323954624362574d, y: 0.7709041628448741d), new NpgsqlTypes.NpgsqlPoint(x: 0.70206670323326d, y: 0.05648466628717996d), new NpgsqlTypes.NpgsqlPoint(x: 0.02235086950733345d, y: 0.7671737304251743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6118975339606773d, y: 0.4351647760437799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129515940933993d, y: 0.992362158029781d), new NpgsqlTypes.NpgsqlPoint(x: 0.8349474986076353d, y: 0.930161074501954d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.002181891549249859d, y: 0.6516425827095131d), new NpgsqlTypes.NpgsqlPoint(x: 0.28444216636465647d, y: 0.19030912972826985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237287069997161d, y: 0.2515888985024223d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5396069407021213d, y: 0.5292286993495734d), new NpgsqlTypes.NpgsqlPoint(x: 0.2736701780191153d, y: 0.3346153437257017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664484067465508d, y: 0.39969294795866617d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.668981274352273d, y: 0.7029459616757076d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709416696780495d, y: 0.004598294084367849d), new NpgsqlTypes.NpgsqlPoint(x: 0.7233275111813398d, y: 0.7065618338896299d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33076456970763557d, y: 0.8733246954731713d), new NpgsqlTypes.NpgsqlPoint(x: 0.6053411187965607d, y: 0.8439779840746828d), new NpgsqlTypes.NpgsqlPoint(x: 0.29092843343665475d, y: 0.9314653091761843d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5062715983373576d, y: 0.5597649307786053d), new NpgsqlTypes.NpgsqlPoint(x: 0.7519505550318492d, y: 0.5027251204660065d), new NpgsqlTypes.NpgsqlPoint(x: 0.7830017532675732d, y: 0.7531810218783701d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17688620021862222d, y: 0.6413591338597259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618968413975558d, y: 0.10967841341837115d), new NpgsqlTypes.NpgsqlPoint(x: 0.10594426249414557d, y: 0.05881419410757882d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5119523356532429d, y: 0.07088499223194134d), new NpgsqlTypes.NpgsqlPoint(x: 0.12676101239680748d, y: 0.2142543184204202d), new NpgsqlTypes.NpgsqlPoint(x: 0.1658109301510573d, y: 0.4856101507480649d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3172358554532896d, y: 0.5790545569859517d), new NpgsqlTypes.NpgsqlPoint(x: 0.8904784871354503d, y: 0.9495000428536707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6781480411990013d, y: 0.18906706720969846d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08556196573113628d, y: 0.14496297338901332d), new NpgsqlTypes.NpgsqlPoint(x: 0.1665989263995743d, y: 0.13611644282735325d), new NpgsqlTypes.NpgsqlPoint(x: 0.371777584203842d, y: 0.6224994844030136d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7638791828602157d, y: 0.4502567348736014d), new NpgsqlTypes.NpgsqlPoint(x: 0.3512507609129185d, y: 0.6240199607442647d), new NpgsqlTypes.NpgsqlPoint(x: 0.18549573517472562d, y: 0.34254508378200377d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7276608543582309d, y: 0.6035204047807208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599875065035715d, y: 0.14897724724333572d), new NpgsqlTypes.NpgsqlPoint(x: 0.21990861343230983d, y: 0.25873008743665626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15190995137619678d, y: 0.9928479714728283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3305157989810137d, y: 0.05694505169020658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184548058494724d, y: 0.22796890627339284d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13779338129166574d, y: 0.09742702863825992d), new NpgsqlTypes.NpgsqlPoint(x: 0.802819162561645d, y: 0.035717604066332065d), new NpgsqlTypes.NpgsqlPoint(x: 0.3591141373345439d, y: 0.37372667904250956d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011796057979874264d, y: 0.7620427151010993d), new NpgsqlTypes.NpgsqlPoint(x: 0.034883744235063574d, y: 0.3566802791077368d), new NpgsqlTypes.NpgsqlPoint(x: 0.4755420969991938d, y: 0.1658835442788812d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6024869697110027d, y: 0.808035481360824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859738514384031d, y: 0.2744007198195084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3391771020209652d, y: 0.20424479966362963d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 126;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 122;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 127, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 2, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 36, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 16, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 73, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 8, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 58, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatch(connection, 166, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[14], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[15], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[16], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[17], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[18], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[19], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[20], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[21], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[22], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[23], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[24], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[25], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[26], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[27], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[28], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI), typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

