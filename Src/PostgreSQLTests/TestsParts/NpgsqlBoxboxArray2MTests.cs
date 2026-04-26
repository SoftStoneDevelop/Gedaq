

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8170006230349028d,right: 0.9483219522267591d,bottom: 0.25084664216820496d,left: 0.15254798451666474d),

new NpgsqlTypes.NpgsqlBox(top: 0.6420190934549933d,right: 0.7090770311151116d,bottom: 0.13300740653926701d,left: 0.18240663653231304d),

new NpgsqlTypes.NpgsqlBox(top: 0.6693861448875467d,right: 0.6868768920645446d,bottom: 0.12251536867986834d,left: 0.48339497095891626d),

new NpgsqlTypes.NpgsqlBox(top: 0.7850267889675338d,right: 0.8680627487542198d,bottom: 0.010940108708117458d,left: 0.39639089493717594d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8949471759873198d,right: 0.8363063855781745d,bottom: 0.3981453934106892d,left: 0.5666154218128284d),

new NpgsqlTypes.NpgsqlBox(top: 0.7266240327004968d,right: 0.7935184207852974d,bottom: 0.34005430361976274d,left: 0.5753440039972773d),

new NpgsqlTypes.NpgsqlBox(top: 0.7311987842387099d,right: 0.5180908160879203d,bottom: 0.5915457245906965d,left: 0.051493835565116d),

new NpgsqlTypes.NpgsqlBox(top: 0.9634129814148318d,right: 0.8260783748625018d,bottom: 0.5134042858945799d,left: 0.4223677275691474d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8523631193179522d,right: 0.7611743243803043d,bottom: 0.5699296632824545d,left: 0.6534561930456512d),

new NpgsqlTypes.NpgsqlBox(top: 0.9062005292846471d,right: 0.4898307711468045d,bottom: 0.5889822510041471d,left: 0.32607391504259864d),

new NpgsqlTypes.NpgsqlBox(top: 0.7063610119735221d,right: 0.4542303459448005d,bottom: 0.10511593055968493d,left: 0.11464694600952774d),

new NpgsqlTypes.NpgsqlBox(top: 0.7919998888567511d,right: 0.8126220896337827d,bottom: 0.5784627295259367d,left: 0.27646335296056845d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.473366156114447d,right: 0.8100543964589426d,bottom: 0.1742683037477134d,left: 0.3888594229391237d),

new NpgsqlTypes.NpgsqlBox(top: 0.6147181340188125d,right: 0.7129446791468949d,bottom: 0.12983611613527313d,left: 0.11197450004815246d),

new NpgsqlTypes.NpgsqlBox(top: 0.18997871196187543d,right: 0.7013344982190426d,bottom: 0.10605724076340872d,left: 0.5479381448950724d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.60548881110273d,right: 0.8840581600848669d,bottom: 0.5690501285675521d,left: 0.5973672725897347d),

new NpgsqlTypes.NpgsqlBox(top: 0.7972103590909886d,right: 0.8889459380607929d,bottom: 0.6990551142801904d,left: 0.0674831480321173d),

new NpgsqlTypes.NpgsqlBox(top: 0.3083054903193181d,right: 0.7491658797080486d,bottom: 0.034557031121122184d,left: 0.6478672787848019d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.496929529586554d,right: 0.7873806464976225d,bottom: 0.08168698884403913d,left: 0.17756534699404924d),

new NpgsqlTypes.NpgsqlBox(top: 0.8968641695309053d,right: 0.5143742601304343d,bottom: 0.8551401385150069d,left: 0.12377073628932267d),

new NpgsqlTypes.NpgsqlBox(top: 0.9021673001493158d,right: 0.4611473108961036d,bottom: 0.6611687824536252d,left: 0.34845257046806755d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42608978338108405d,right: 0.5855927296142862d,bottom: 0.2679178208958659d,left: 0.5305370879815063d),

new NpgsqlTypes.NpgsqlBox(top: 0.7181681419158722d,right: 0.5228649502688261d,bottom: 0.2962603232565927d,left: 0.2429523911518613d),

new NpgsqlTypes.NpgsqlBox(top: 0.9552920925004794d,right: 0.43270025615178553d,bottom: 0.6693425318074282d,left: 0.2202601605111968d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6938116605629262d,right: 0.8485681104667872d,bottom: 0.023439445971546458d,left: 0.8232513356019295d),

new NpgsqlTypes.NpgsqlBox(top: 0.6291386617261059d,right: 0.8574990836171414d,bottom: 0.13136335653531517d,left: 0.364564679261315d),

new NpgsqlTypes.NpgsqlBox(top: 0.7351851806999301d,right: 0.7159185148850004d,bottom: 0.6111255467540981d,left: 0.4466859384866244d),

new NpgsqlTypes.NpgsqlBox(top: 0.7935178847635815d,right: 0.8818007464823457d,bottom: 0.11831041109004703d,left: 0.7538080889835063d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.248035592590363d,right: 0.7369309173427899d,bottom: 0.17986723987561604d,left: 0.45599681067906617d),

new NpgsqlTypes.NpgsqlBox(top: 0.5284658427006134d,right: 0.12552663462325098d,bottom: 0.029415946802040738d,left: 0.06727902001620956d),

new NpgsqlTypes.NpgsqlBox(top: 0.6607461150406363d,right: 0.925901162150266d,bottom: 0.28379548618429784d,left: 0.5177142139062924d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44652672684102657d,right: 0.7847075157485961d,bottom: 0.30161145929779953d,left: 0.7205581698947053d),

new NpgsqlTypes.NpgsqlBox(top: 0.7643909862754067d,right: 0.7102082733590063d,bottom: 0.18682049886440433d,left: 0.11703237632446606d),

new NpgsqlTypes.NpgsqlBox(top: 0.9369897684714369d,right: 0.6053611982515739d,bottom: 0.2718649428308956d,left: 0.3510245174216676d),

new NpgsqlTypes.NpgsqlBox(top: 0.7249000835558785d,right: 0.9881766959590769d,bottom: 0.3155130805438494d,left: 0.537343471203444d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5465204862996305d,right: 0.8860472266784265d,bottom: 0.06700998355016641d,left: 0.3265905552800087d),

new NpgsqlTypes.NpgsqlBox(top: 0.7894662602469178d,right: 0.7359397617783372d,bottom: 0.06514799655289927d,left: 0.4950888932285743d),

new NpgsqlTypes.NpgsqlBox(top: 0.370044685518263d,right: 0.4262516399842481d,bottom: 0.030212464706941056d,left: 0.1742155190506599d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9491184619398337d,right: 0.5887135124997094d,bottom: 0.04617423841552104d,left: 0.34951911019748994d),

new NpgsqlTypes.NpgsqlBox(top: 0.7211476542407874d,right: 0.7543899064389767d,bottom: 0.07294198652879325d,left: 0.3369202335229783d),

new NpgsqlTypes.NpgsqlBox(top: 0.8814257777124113d,right: 0.8182832243997751d,bottom: 0.40336474609763984d,left: 0.656500068964537d),

new NpgsqlTypes.NpgsqlBox(top: 0.6024241722936184d,right: 0.6392291587813883d,bottom: 0.1761380936464807d,left: 0.1846946631683657d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.599774329883727d,right: 0.8753638963152592d,bottom: 0.5146553341119622d,left: 0.07065270194221729d),

new NpgsqlTypes.NpgsqlBox(top: 0.3757922803876671d,right: 0.6751973136235504d,bottom: 0.19703844051946506d,left: 0.033121705462031525d),

new NpgsqlTypes.NpgsqlBox(top: 0.7996059339140574d,right: 0.7097356800549901d,bottom: 0.573634727041667d,left: 0.6144251455058305d),

new NpgsqlTypes.NpgsqlBox(top: 0.4602809746435683d,right: 0.768460198047197d,bottom: 0.2905755138843059d,left: 0.4886667917372651d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8781254153972562d,right: 0.9774194287148353d,bottom: 0.2109090692599881d,left: 0.5003672253787977d),

new NpgsqlTypes.NpgsqlBox(top: 0.6553992054641566d,right: 0.3994785686068212d,bottom: 0.3195099833722552d,left: 0.09616310069251499d),

new NpgsqlTypes.NpgsqlBox(top: 0.3272789822286083d,right: 0.8483275363064491d,bottom: 0.15981546418655646d,left: 0.8375024369670808d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6148955253101828d,right: 0.9526494871069093d,bottom: 0.09741551417053773d,left: 0.023229928281033874d),

new NpgsqlTypes.NpgsqlBox(top: 0.3358863841924199d,right: 0.7658960784076061d,bottom: 0.03671626567969388d,left: 0.018964014088775905d),

new NpgsqlTypes.NpgsqlBox(top: 0.9984889807503848d,right: 0.954519767747533d,bottom: 0.15485823444824176d,left: 0.48652734821911026d),

new NpgsqlTypes.NpgsqlBox(top: 0.48113193310870983d,right: 0.6229107248815899d,bottom: 0.0754981725610242d,left: 0.1597699095130254d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.892373876979894d,right: 0.7309052240794409d,bottom: 0.6285133602996924d,left: 0.11951602745639267d),

new NpgsqlTypes.NpgsqlBox(top: 0.4922905257257091d,right: 0.629030027126396d,bottom: 0.3101102784416587d,left: 0.2522487702207179d),

new NpgsqlTypes.NpgsqlBox(top: 0.9070735559065448d,right: 0.5658985914161184d,bottom: 0.45308031946642313d,left: 0.5124019168450176d),

new NpgsqlTypes.NpgsqlBox(top: 0.45501642102519324d,right: 0.19461919825228668d,bottom: 0.09070052765898684d,left: 0.10531705148843507d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9989107636068781d,right: 0.7841169803854533d,bottom: 0.25434272054620044d,left: 0.736057976636688d),

new NpgsqlTypes.NpgsqlBox(top: 0.8459330446954203d,right: 0.765555721239672d,bottom: 0.7632549549291229d,left: 0.04649105917168672d),

new NpgsqlTypes.NpgsqlBox(top: 0.5145986941691875d,right: 0.9246602110699057d,bottom: 0.5035737084040627d,left: 0.010235112497324783d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9240389023280701d,right: 0.9393040743410099d,bottom: 0.3892215115319385d,left: 0.8255926288407074d),

new NpgsqlTypes.NpgsqlBox(top: 0.5729996208406969d,right: 0.7566957912651086d,bottom: 0.5412056007798342d,left: 0.3875891412555461d),

new NpgsqlTypes.NpgsqlBox(top: 0.6752051153843214d,right: 0.590367933841861d,bottom: 0.3028893741006562d,left: 0.1005882452604292d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8312483358817815d,right: 0.4085103187305391d,bottom: 0.11690396022355143d,left: 0.3611659253517382d),

new NpgsqlTypes.NpgsqlBox(top: 0.22062695145730993d,right: 0.9555879140503326d,bottom: 0.1443046598758787d,left: 0.5148844934963507d),

new NpgsqlTypes.NpgsqlBox(top: 0.6430237138876772d,right: 0.3255025336926708d,bottom: 0.4727116315993679d,left: 0.3057905938188995d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6465708930488537d,right: 0.9917568639215237d,bottom: 0.3517497230732215d,left: 0.12553872815460632d),

new NpgsqlTypes.NpgsqlBox(top: 0.2806757246315358d,right: 0.9351323595085931d,bottom: 0.059468329093461114d,left: 0.775775124354648d),

new NpgsqlTypes.NpgsqlBox(top: 0.6720948260394456d,right: 0.7195037193641225d,bottom: 0.40632496263876705d,left: 0.29580878281893774d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6979691159032327d,right: 0.9604160443618817d,bottom: 0.383686537542663d,left: 0.5695604836718346d),

new NpgsqlTypes.NpgsqlBox(top: 0.5971635936426493d,right: 0.611071535104154d,bottom: 0.1961077221083144d,left: 0.35705197204277417d),

new NpgsqlTypes.NpgsqlBox(top: 0.5666066008092648d,right: 0.8632991600792934d,bottom: 0.2016825016850906d,left: 0.05540195703405415d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6052313442366083d,right: 0.1607608357028092d,bottom: 0.48218549503783614d,left: 0.07840412480735137d),

new NpgsqlTypes.NpgsqlBox(top: 0.9877932368891481d,right: 0.2231397318167877d,bottom: 0.4118083098310473d,left: 0.091010744134429d),

new NpgsqlTypes.NpgsqlBox(top: 0.9230581965141826d,right: 0.36453204053440447d,bottom: 0.5332430409449214d,left: 0.10127934507798664d),

new NpgsqlTypes.NpgsqlBox(top: 0.7278633074977023d,right: 0.3527164932250706d,bottom: 0.18756623652249493d,left: 0.24598701357623887d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8898014901447643d,right: 0.4843352155884374d,bottom: 0.7237474940920383d,left: 0.23235861882605302d),

new NpgsqlTypes.NpgsqlBox(top: 0.38674827522689226d,right: 0.42264125401453845d,bottom: 0.023431411521452783d,left: 0.3845125982600305d),

new NpgsqlTypes.NpgsqlBox(top: 0.5678065565696316d,right: 0.9658388141067361d,bottom: 0.4372635068495332d,left: 0.3359704497639141d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3236637899973257d,right: 0.12135530109473325d,bottom: 0.27126941640972746d,left: 0.12025445284890812d),

new NpgsqlTypes.NpgsqlBox(top: 0.8866122015414317d,right: 0.6384658211857063d,bottom: 0.7386147371871279d,left: 0.11179394063589387d),

new NpgsqlTypes.NpgsqlBox(top: 0.5768506360324172d,right: 0.8127596893706086d,bottom: 0.486762167250385d,left: 0.30580808703515083d),

new NpgsqlTypes.NpgsqlBox(top: 0.48984648778224715d,right: 0.6095215130872257d,bottom: 0.18079649420019717d,left: 0.34756403891436494d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9531484727046524d,right: 0.26390370532124063d,bottom: 0.7795947312826632d,left: 0.02886656990374048d),

new NpgsqlTypes.NpgsqlBox(top: 0.3108974756366991d,right: 0.8117060317985204d,bottom: 0.2264734539337805d,left: 0.31701747169134875d),

new NpgsqlTypes.NpgsqlBox(top: 0.9171016922504965d,right: 0.6383255039448801d,bottom: 0.8302521933321859d,left: 0.5694922160860671d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8399892335127832d,right: 0.6662322397773226d,bottom: 0.6720515175256263d,left: 0.319407949936219d),

new NpgsqlTypes.NpgsqlBox(top: 0.9286183262269843d,right: 0.3215824232030946d,bottom: 0.24309596411664092d,left: 0.06648003136177605d),

new NpgsqlTypes.NpgsqlBox(top: 0.25408731489840974d,right: 0.23914059081741812d,bottom: 0.0495067516909542d,left: 0.22391323187919898d),

new NpgsqlTypes.NpgsqlBox(top: 0.967495257656834d,right: 0.8617645809596611d,bottom: 0.5975533291088991d,left: 0.7974600538850768d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9425132152140152d,right: 0.7240157610709792d,bottom: 0.06097602535352531d,left: 0.46078401350907716d),

new NpgsqlTypes.NpgsqlBox(top: 0.7177680037651293d,right: 0.3206788110664718d,bottom: 0.5773434424646439d,left: 0.18295496038290382d),

new NpgsqlTypes.NpgsqlBox(top: 0.51856840084774d,right: 0.5361684271036835d,bottom: 0.1730146907865503d,left: 0.18594484278011048d),

new NpgsqlTypes.NpgsqlBox(top: 0.8611361147772909d,right: 0.9917781919860722d,bottom: 0.3456595729786497d,left: 0.4667332396830496d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8997876756378224d,right: 0.7893017360854266d,bottom: 0.6958272085025772d,left: 0.5747375395664925d),

new NpgsqlTypes.NpgsqlBox(top: 0.5279955691259254d,right: 0.8840420602745966d,bottom: 0.16594743429738734d,left: 0.546683500021094d),

new NpgsqlTypes.NpgsqlBox(top: 0.9525415704457725d,right: 0.9596566259571634d,bottom: 0.9411426786614472d,left: 0.35562928595686727d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5079860282756965d,right: 0.8303788513377536d,bottom: 0.3676396555480653d,left: 0.04130006572142486d),

new NpgsqlTypes.NpgsqlBox(top: 0.3245763965080495d,right: 0.609638996567126d,bottom: 0.24729190558916103d,left: 0.08592693668600193d),

new NpgsqlTypes.NpgsqlBox(top: 0.7762260361726174d,right: 0.4557399126860041d,bottom: 0.12341645856871075d,left: 0.36572721897579363d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3985302322517862d,right: 0.8253938189989308d,bottom: 0.3459188171254336d,left: 0.39777443741390994d),

new NpgsqlTypes.NpgsqlBox(top: 0.6711782868882324d,right: 0.9603637608139263d,bottom: 0.36051578802777196d,left: 0.4319962787913978d),

new NpgsqlTypes.NpgsqlBox(top: 0.7442074220290502d,right: 0.8806579733788373d,bottom: 0.5185825395307683d,left: 0.23999921839438143d),

new NpgsqlTypes.NpgsqlBox(top: 0.4536128140971425d,right: 0.830363909881869d,bottom: 0.3677457725834412d,left: 0.7640902122491111d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39710491451663243d,right: 0.80328048467518d,bottom: 0.19232946635059434d,left: 0.08426751671148969d),

new NpgsqlTypes.NpgsqlBox(top: 0.6844764732381519d,right: 0.8701480936903796d,bottom: 0.6414758081755044d,left: 0.6314079783052834d),

new NpgsqlTypes.NpgsqlBox(top: 0.7517618156406561d,right: 0.4781954507106154d,bottom: 0.3653124263402462d,left: 0.27100193055521493d),

new NpgsqlTypes.NpgsqlBox(top: 0.4802202837132217d,right: 0.6400164583907597d,bottom: 0.3919062849856151d,left: 0.4095712902467148d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9911490622174599d,right: 0.8771554722568538d,bottom: 0.3007004404862227d,left: 0.4893944802627913d),

new NpgsqlTypes.NpgsqlBox(top: 0.3860289781337628d,right: 0.8148503063846149d,bottom: 0.12118621062756774d,left: 0.041308851707259175d),

new NpgsqlTypes.NpgsqlBox(top: 0.9627877594252499d,right: 0.8448705123542751d,bottom: 0.563999108787794d,left: 0.3549573298859088d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5220696711453927d,right: 0.6637687424861999d,bottom: 0.4466880476200419d,left: 0.0436016592574735d),

new NpgsqlTypes.NpgsqlBox(top: 0.4311517778458631d,right: 0.1976147615118624d,bottom: 0.09682730768631587d,left: 0.005157242045426003d),

new NpgsqlTypes.NpgsqlBox(top: 0.8677937943415742d,right: 0.47359776240633944d,bottom: 0.02316726513170808d,left: 0.25312267657933263d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9603634958121067d,right: 0.7969218159940589d,bottom: 0.6972589750707886d,left: 0.0034716875272594594d),

new NpgsqlTypes.NpgsqlBox(top: 0.7771566953136771d,right: 0.5865795916841938d,bottom: 0.5373216835626938d,left: 0.12435057540948713d),

new NpgsqlTypes.NpgsqlBox(top: 0.8319191336342493d,right: 0.7641929700610928d,bottom: 0.6739933277463825d,left: 0.431779689196803d),

new NpgsqlTypes.NpgsqlBox(top: 0.7764800358996666d,right: 0.7419991064910492d,bottom: 0.7071148288796366d,left: 0.5016735165021559d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5569137002999478d,right: 0.5923256004477129d,bottom: 0.20050195658259928d,left: 0.4145416090608659d),

new NpgsqlTypes.NpgsqlBox(top: 0.3990256367188971d,right: 0.5725095439805248d,bottom: 0.29708185714209434d,left: 0.4499290600808409d),

new NpgsqlTypes.NpgsqlBox(top: 0.7339415642325344d,right: 0.9153663543567171d,bottom: 0.7038858346972312d,left: 0.3512084972298074d),

new NpgsqlTypes.NpgsqlBox(top: 0.9240895304338175d,right: 0.8189881153520947d,bottom: 0.7128176478155112d,left: 0.57093493528491d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6779790943271294d,right: 0.160705029540249d,bottom: 0.3419980275568726d,left: 0.07934777401518311d),

new NpgsqlTypes.NpgsqlBox(top: 0.27743549545796387d,right: 0.5732313371277641d,bottom: 0.04408429141958459d,left: 0.10199717113073081d),

new NpgsqlTypes.NpgsqlBox(top: 0.6129121910923832d,right: 0.7683563720147594d,bottom: 0.25548473835971686d,left: 0.4014970803345055d),

new NpgsqlTypes.NpgsqlBox(top: 0.5516880855886559d,right: 0.7515525538623742d,bottom: 0.40171288574947284d,left: 0.7332356621546374d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8451561536248202d,right: 0.8191800641191029d,bottom: 0.37047010940404457d,left: 0.6246574438730892d),

new NpgsqlTypes.NpgsqlBox(top: 0.6612295397726189d,right: 0.39384299654456734d,bottom: 0.3362680022536394d,left: 0.19866925398149826d),

new NpgsqlTypes.NpgsqlBox(top: 0.7455299177414785d,right: 0.8261850429780448d,bottom: 0.21758236423496768d,left: 0.5726372180416115d),

new NpgsqlTypes.NpgsqlBox(top: 0.460119167256288d,right: 0.2076318598439031d,bottom: 0.34150555195392696d,left: 0.12649288235260403d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3309535736008018d,right: 0.76670416764892d,bottom: 0.08740854078582161d,left: 0.5803851174105599d),

new NpgsqlTypes.NpgsqlBox(top: 0.509889043946378d,right: 0.42794216638295735d,bottom: 0.16542198813041542d,left: 0.04937831944705062d),

new NpgsqlTypes.NpgsqlBox(top: 0.5694148410814399d,right: 0.40920172253902964d,bottom: 0.26625851125872335d,left: 0.23359043681246905d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8409032184181867d,right: 0.46857460037282983d,bottom: 0.6198496333696841d,left: 0.4437645693142589d),

new NpgsqlTypes.NpgsqlBox(top: 0.6228047865191663d,right: 0.5246433380504345d,bottom: 0.04054145476425075d,left: 0.03166936480118954d),

new NpgsqlTypes.NpgsqlBox(top: 0.8913540807450204d,right: 0.5517152779310552d,bottom: 0.6481752838801339d,left: 0.49640898948379475d),

new NpgsqlTypes.NpgsqlBox(top: 0.2734109693309693d,right: 0.4865920405542916d,bottom: 0.016955164920384846d,left: 0.0015821557336450631d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42514697538335156d,right: 0.43892175974205383d,bottom: 0.02440742357510539d,left: 0.27152977289909375d),

new NpgsqlTypes.NpgsqlBox(top: 0.9222934986403863d,right: 0.8440882347888102d,bottom: 0.09773341482722453d,left: 0.7431298383576884d),

new NpgsqlTypes.NpgsqlBox(top: 0.5720714519434891d,right: 0.6503916196266163d,bottom: 0.36845843850457327d,left: 0.40671222963385734d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6710342144642504d,right: 0.8086306971502859d,bottom: 0.17989667412389698d,left: 0.22572605794295086d),

new NpgsqlTypes.NpgsqlBox(top: 0.47566234416796604d,right: 0.5183297043440618d,bottom: 0.1124128714328585d,left: 0.01565643641013914d),

new NpgsqlTypes.NpgsqlBox(top: 0.7889518848191523d,right: 0.7330852908468705d,bottom: 0.37321721908975003d,left: 0.21611029107684376d),

new NpgsqlTypes.NpgsqlBox(top: 0.4570538818102722d,right: 0.7047651401917044d,bottom: 0.2465341215258966d,left: 0.3426528182721963d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9738327677669103d,right: 0.721186842140253d,bottom: 0.8908499858685431d,left: 0.31149241689252594d),

new NpgsqlTypes.NpgsqlBox(top: 0.9190883716910543d,right: 0.985364123935962d,bottom: 0.46721207768471673d,left: 0.013736430846153058d),

new NpgsqlTypes.NpgsqlBox(top: 0.7711727499233884d,right: 0.4985571485720126d,bottom: 0.5241943108295374d,left: 0.3142413017664125d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3462080713155805d,right: 0.8686164460463285d,bottom: 0.23622790048123588d,left: 0.3033692333034187d),

new NpgsqlTypes.NpgsqlBox(top: 0.7638888733634472d,right: 0.6926438786816566d,bottom: 0.5407845898806577d,left: 0.5463434108457128d),

new NpgsqlTypes.NpgsqlBox(top: 0.9408296701529812d,right: 0.22851990706116787d,bottom: 0.6356034839276833d,left: 0.21590734330173855d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9817782222350963d,right: 0.2717335875658362d,bottom: 0.3591030339728205d,left: 0.13948652749801982d),

new NpgsqlTypes.NpgsqlBox(top: 0.5225644097709796d,right: 0.362281757068575d,bottom: 0.3873327991055825d,left: 0.2861304062100909d),

new NpgsqlTypes.NpgsqlBox(top: 0.6708030376600529d,right: 0.6781418103403961d,bottom: 0.4387102758698542d,left: 0.4696036546413186d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5845285291634613d,right: 0.9320595604982579d,bottom: 0.31862687859370376d,left: 0.6403217623606413d),

new NpgsqlTypes.NpgsqlBox(top: 0.291346575855443d,right: 0.8492287367544453d,bottom: 0.1840839734945544d,left: 0.5335366138403188d),

new NpgsqlTypes.NpgsqlBox(top: 0.5716368882640268d,right: 0.6602837425373119d,bottom: 0.10129939316790293d,left: 0.38418615464587047d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.509890259558572d,right: 0.1829963946177925d,bottom: 0.19339480988985103d,left: 0.05426820452009873d),

new NpgsqlTypes.NpgsqlBox(top: 0.9478497213671618d,right: 0.369689124641454d,bottom: 0.2676505613685368d,left: 0.19815082228491d),

new NpgsqlTypes.NpgsqlBox(top: 0.7355182379966632d,right: 0.7819928346123535d,bottom: 0.030625586928929027d,left: 0.5452481149178042d),

new NpgsqlTypes.NpgsqlBox(top: 0.45810927094833864d,right: 0.9603424011605283d,bottom: 0.2510951660232197d,left: 0.4697296741821452d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5610318151665684d,right: 0.6579483261846453d,bottom: 0.05135648630310441d,left: 0.021981164688614996d),

new NpgsqlTypes.NpgsqlBox(top: 0.8747732817012736d,right: 0.8932081990354992d,bottom: 0.3938840966038909d,left: 0.8669099685908466d),

new NpgsqlTypes.NpgsqlBox(top: 0.7431645183014474d,right: 0.9562130947147405d,bottom: 0.33244901891448664d,left: 0.3185500125030508d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4428959723104212d,right: 0.4403207123964421d,bottom: 0.0006168606076190075d,left: 0.2127673036352291d),

new NpgsqlTypes.NpgsqlBox(top: 0.9470361309744949d,right: 0.9415295868223956d,bottom: 0.1942483026969184d,left: 0.8845690034800879d),

new NpgsqlTypes.NpgsqlBox(top: 0.6669724499352393d,right: 0.604199053112006d,bottom: 0.47628262344551897d,left: 0.5824567641273461d),

new NpgsqlTypes.NpgsqlBox(top: 0.9495386412474499d,right: 0.8863901864114889d,bottom: 0.7980565065973552d,left: 0.6071447504447061d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6137721557934368d,right: 0.9284846586170904d,bottom: 0.14530099754486658d,left: 0.6153364356699884d),

new NpgsqlTypes.NpgsqlBox(top: 0.8730102423905916d,right: 0.9378805652079018d,bottom: 0.12117094512259718d,left: 0.22660407289069384d),

new NpgsqlTypes.NpgsqlBox(top: 0.3675760345939346d,right: 0.9747824394922715d,bottom: 0.0649731655672875d,left: 0.6455232855938456d),

new NpgsqlTypes.NpgsqlBox(top: 0.7978305641012382d,right: 0.7655074648707939d,bottom: 0.03833827612463092d,left: 0.1417569220195084d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4098383548069414d,right: 0.16574411688177848d,bottom: 0.30903892624367213d,left: 0.010305687056640367d),

new NpgsqlTypes.NpgsqlBox(top: 0.8522561572174366d,right: 0.6414894852300327d,bottom: 0.39556146079938237d,left: 0.27927767274297444d),

new NpgsqlTypes.NpgsqlBox(top: 0.9059326559181363d,right: 0.3535153090675348d,bottom: 0.7497906328769189d,left: 0.17676301396469551d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.984465277201489d,right: 0.7996068763206956d,bottom: 0.44196182050453037d,left: 0.7678396760792823d),

new NpgsqlTypes.NpgsqlBox(top: 0.6734871451550466d,right: 0.6263117923284973d,bottom: 0.6319266825757159d,left: 0.18087314536391197d),

new NpgsqlTypes.NpgsqlBox(top: 0.9599015612475404d,right: 0.4514715150926155d,bottom: 0.3717422792699667d,left: 0.05489172215400673d),

new NpgsqlTypes.NpgsqlBox(top: 0.5557499513405231d,right: 0.64636267154835d,bottom: 0.13922396552826322d,left: 0.2034390980037013d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.45813133775464865d,right: 0.8167563618598644d,bottom: 0.22609788071380033d,left: 0.5343951641396183d),

new NpgsqlTypes.NpgsqlBox(top: 0.8414145468342746d,right: 0.6609018233628996d,bottom: 5.846781431573245E-05d,left: 0.5384494768881017d),

new NpgsqlTypes.NpgsqlBox(top: 0.44947708253386864d,right: 0.6398166050297682d,bottom: 0.2022913609999908d,left: 0.5918480175115091d),

new NpgsqlTypes.NpgsqlBox(top: 0.9941349993349982d,right: 0.7668584178818538d,bottom: 0.9382780028586291d,left: 0.010840566386232986d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5808871493697808d,right: 0.9080115072604771d,bottom: 0.021250493910348167d,left: 0.4320797347967932d),

new NpgsqlTypes.NpgsqlBox(top: 0.9795772383188817d,right: 0.30867935032575666d,bottom: 0.2776309547953716d,left: 0.15652638773267713d),

new NpgsqlTypes.NpgsqlBox(top: 0.8963819419786435d,right: 0.9694627396012552d,bottom: 0.7674070341349956d,left: 0.5685712365507595d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.13394091077772252d,right: 0.14820669237249506d,bottom: 0.1314785612589613d,left: 0.08642763537486464d),

new NpgsqlTypes.NpgsqlBox(top: 0.49891638574145736d,right: 0.9511358412372516d,bottom: 0.33126067925230085d,left: 0.12985699891846825d),

new NpgsqlTypes.NpgsqlBox(top: 0.22965242413270914d,right: 0.102784404462271d,bottom: 0.20244331472454202d,left: 0.016757319955398753d),

new NpgsqlTypes.NpgsqlBox(top: 0.8156209540277536d,right: 0.5821316789153865d,bottom: 0.03858109743700444d,left: 0.3883482444773547d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7656231422824488d,right: 0.9741495414922419d,bottom: 0.46593965968658724d,left: 0.5160485509354893d),

new NpgsqlTypes.NpgsqlBox(top: 0.9941232572949982d,right: 0.6129992990487754d,bottom: 0.8791665357706425d,left: 0.23904486898072208d),

new NpgsqlTypes.NpgsqlBox(top: 0.552068529061997d,right: 0.9669107904578259d,bottom: 0.12896126148470866d,left: 0.26669136513953073d),

new NpgsqlTypes.NpgsqlBox(top: 0.5282690226237993d,right: 0.6534676230715967d,bottom: 0.44732053217957d,left: 0.2145087311895033d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.987646102271754d,right: 0.44282840587606165d,bottom: 0.361214876500366d,left: 0.23597366271502362d),

new NpgsqlTypes.NpgsqlBox(top: 0.6349536970453714d,right: 0.4887438807518627d,bottom: 0.2714329797844589d,left: 0.003617632756775735d),

new NpgsqlTypes.NpgsqlBox(top: 0.15064280133104924d,right: 0.851965788967593d,bottom: 0.11385490524957709d,left: 0.40951204294015164d),

new NpgsqlTypes.NpgsqlBox(top: 0.5843667622912297d,right: 0.9772521171403271d,bottom: 0.39816457928909954d,left: 0.27779500706886484d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2899777339112847d,right: 0.6979282464383113d,bottom: 0.08635534984430193d,left: 0.44024815308985255d),

new NpgsqlTypes.NpgsqlBox(top: 0.9936305952389836d,right: 0.5811263286200271d,bottom: 0.5055824985013435d,left: 0.23167289094275556d),

new NpgsqlTypes.NpgsqlBox(top: 0.3991976491825433d,right: 0.47449691961970997d,bottom: 0.1604062223580477d,left: 0.36775312998780796d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2538835446162965d,right: 0.6631547731732574d,bottom: 0.1612901605965147d,left: 0.23022555572070358d),

new NpgsqlTypes.NpgsqlBox(top: 0.1152193352086972d,right: 0.35314943371586704d,bottom: 0.07928569860059509d,left: 0.0781776268037967d),

new NpgsqlTypes.NpgsqlBox(top: 0.4467172068322791d,right: 0.9473520294458012d,bottom: 0.31593745964585607d,left: 0.7366791661058563d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5770407734440611d,right: 0.39586346402169215d,bottom: 0.5200141958050336d,left: 0.08299094944824614d),

new NpgsqlTypes.NpgsqlBox(top: 0.9504910270404435d,right: 0.5663569581535892d,bottom: 0.34483078121047694d,left: 0.2667137914097665d),

new NpgsqlTypes.NpgsqlBox(top: 0.7649431097824596d,right: 0.8962822545327005d,bottom: 0.3204914534796405d,left: 0.409441804354127d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46123743479843704d,right: 0.7256024016201313d,bottom: 0.3949493942225524d,left: 0.5180634061638767d),

new NpgsqlTypes.NpgsqlBox(top: 0.9854902120379453d,right: 0.7509788946182908d,bottom: 0.09662645965523509d,left: 0.06761623953690787d),

new NpgsqlTypes.NpgsqlBox(top: 0.8248145548410722d,right: 0.3523912444279713d,bottom: 0.28968613652140995d,left: 0.011791159211967717d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8369687855339439d,right: 0.5832351946907297d,bottom: 0.2764438573970148d,left: 0.12269387831111767d),

new NpgsqlTypes.NpgsqlBox(top: 0.37470254218801724d,right: 0.6756661403094055d,bottom: 0.02086857367092232d,left: 0.6553773400487449d),

new NpgsqlTypes.NpgsqlBox(top: 0.4143767390769225d,right: 0.6723665250285661d,bottom: 0.11326290259413851d,left: 0.42647251270289344d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8479856837407644d,right: 0.3006420759964412d,bottom: 0.3054952542691467d,left: 0.2912968347021737d),

new NpgsqlTypes.NpgsqlBox(top: 0.6385489820732964d,right: 0.8130637062898062d,bottom: 0.609135611842418d,left: 0.7956674053736472d),

new NpgsqlTypes.NpgsqlBox(top: 0.9311495479277715d,right: 0.715408729896874d,bottom: 0.8323316214966247d,left: 0.12554543934241802d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5634373588030934d,right: 0.9455417572991928d,bottom: 0.17128079132263585d,left: 0.27019514675965917d),

new NpgsqlTypes.NpgsqlBox(top: 0.6140127966034843d,right: 0.8604930826450509d,bottom: 0.27647654773284047d,left: 0.5520852822481044d),

new NpgsqlTypes.NpgsqlBox(top: 0.4071925956298702d,right: 0.7903097217182011d,bottom: 0.044630644316574375d,left: 0.22276354484945327d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8631962116667803d,right: 0.29107970545987505d,bottom: 0.571053406727973d,left: 0.03927539456215323d),

new NpgsqlTypes.NpgsqlBox(top: 0.4689675923058588d,right: 0.4501684636502209d,bottom: 0.4209660864657261d,left: 0.18207021759475595d),

new NpgsqlTypes.NpgsqlBox(top: 0.7846029025891976d,right: 0.9229348351189742d,bottom: 0.21656380289426225d,left: 0.8311547362741502d),

new NpgsqlTypes.NpgsqlBox(top: 0.6855416671256358d,right: 0.9383481475352063d,bottom: 0.03277395753380552d,left: 0.22811388951071465d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7275828028571433d,right: 0.8336706652687129d,bottom: 0.21465222759671854d,left: 0.6770762066919294d),

new NpgsqlTypes.NpgsqlBox(top: 0.2878829378669734d,right: 0.9939593589227608d,bottom: 0.15258017161578197d,left: 0.9590483458898397d),

new NpgsqlTypes.NpgsqlBox(top: 0.8762262852157044d,right: 0.7924613001855845d,bottom: 0.4976974319538755d,left: 0.040299905586922424d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6471473446624054d,right: 0.6017088529389503d,bottom: 0.44073895295894194d,left: 0.20628230664059388d),

new NpgsqlTypes.NpgsqlBox(top: 0.45320458765563243d,right: 0.8509974164052926d,bottom: 0.22341224409267757d,left: 0.2605745115141065d),

new NpgsqlTypes.NpgsqlBox(top: 0.6177353504232505d,right: 0.6861918746442942d,bottom: 0.05400773097867384d,left: 0.39854695624311043d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5728696578259832d,right: 0.8808323602344259d,bottom: 0.09808604008951372d,left: 0.4781277362275821d),

new NpgsqlTypes.NpgsqlBox(top: 0.42684585640938044d,right: 0.8899721481759124d,bottom: 0.3042929525783341d,left: 0.05608745843598828d),

new NpgsqlTypes.NpgsqlBox(top: 0.6100062640378243d,right: 0.8542640637224207d,bottom: 0.040063156624758234d,left: 0.09247731563709716d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5149522030179744d,right: 0.14883907302033972d,bottom: 0.3220795176084671d,left: 0.010825965779495905d),

new NpgsqlTypes.NpgsqlBox(top: 0.37666865175073405d,right: 0.19959660639234256d,bottom: 0.14781115786565557d,left: 0.05912286924553456d),

new NpgsqlTypes.NpgsqlBox(top: 0.591292569393616d,right: 0.8934344909188857d,bottom: 0.49673226077183164d,left: 0.862103015354977d),

new NpgsqlTypes.NpgsqlBox(top: 0.6813764453408655d,right: 0.8519257548506906d,bottom: 0.197805555530006d,left: 0.23387242739505776d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6242388006675945d,right: 0.7288602320992907d,bottom: 0.24588103677342887d,left: 0.7276058620712106d),

new NpgsqlTypes.NpgsqlBox(top: 0.3559255718821013d,right: 0.6924723966362573d,bottom: 0.2798151277465396d,left: 0.4107926611317788d),

new NpgsqlTypes.NpgsqlBox(top: 0.8103831127185587d,right: 0.6622379152178726d,bottom: 0.7527132525477175d,left: 0.021587464730771333d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8031526187782775d,right: 0.9849776189323729d,bottom: 0.4601368327004064d,left: 0.348422941057298d),

new NpgsqlTypes.NpgsqlBox(top: 0.4895847024666192d,right: 0.4364029028547747d,bottom: 0.2216701730134154d,left: 0.1285478507553205d),

new NpgsqlTypes.NpgsqlBox(top: 0.9028493365475464d,right: 0.6946723460717071d,bottom: 0.14433385743313054d,left: 0.3561901677992889d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8045225545226252d,right: 0.09968872049687616d,bottom: 0.6383104884189494d,left: 0.014292160222838524d),

new NpgsqlTypes.NpgsqlBox(top: 0.5182962482652513d,right: 0.8512580813319706d,bottom: 0.4834644279354925d,left: 0.41012980729757764d),

new NpgsqlTypes.NpgsqlBox(top: 0.6360963706319425d,right: 0.9153635247302949d,bottom: 0.6064919785803112d,left: 0.12377056382274199d),

new NpgsqlTypes.NpgsqlBox(top: 0.6362317641980734d,right: 0.9944434032500049d,bottom: 0.3482049737086582d,left: 0.9071739853795087d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9091452808554095d,right: 0.5764653699440839d,bottom: 0.09157848042206429d,left: 0.10793980750159715d),

new NpgsqlTypes.NpgsqlBox(top: 0.9284994840707d,right: 0.7735608968094662d,bottom: 0.42288038144935947d,left: 0.23552645120521265d),

new NpgsqlTypes.NpgsqlBox(top: 0.6834146677701599d,right: 0.7965156116019836d,bottom: 0.5953316354247147d,left: 0.19279411181731154d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.708436544307163d,right: 0.9996623591496546d,bottom: 0.6453358679411605d,left: 0.7292260646388601d),

new NpgsqlTypes.NpgsqlBox(top: 0.6541500439477423d,right: 0.5128029675395287d,bottom: 0.5803663680672035d,left: 0.22569550286022677d),

new NpgsqlTypes.NpgsqlBox(top: 0.8959427446553685d,right: 0.8471550093204305d,bottom: 0.8340926279150197d,left: 0.14560268142779764d),

new NpgsqlTypes.NpgsqlBox(top: 0.4711400452114315d,right: 0.8460076345284707d,bottom: 0.05993357033122226d,left: 0.2583150850104893d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatchAsync(connection, 64, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatch(connection, 32, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

