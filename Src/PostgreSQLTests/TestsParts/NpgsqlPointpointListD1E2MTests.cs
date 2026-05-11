

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
    internal partial interface INpgsqlPointListpointListD1
    {
    }
    
    internal partial class NpgsqlPointListpointListD1 : INpgsqlPointListpointListD1
    {


#region TestData

        private readonly NpgsqlPointpointListD1E2M[] _testData = new NpgsqlPointpointListD1E2M[]
        {
            new NpgsqlPointpointListD1E2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.981062088998387d, y: 0.02941846607890275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38596322991668586d, y: 0.6932096049242469d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10634907849168573d, y: 0.906972696530032d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06449337909201847d, y: 0.32929001272996206d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7449632161956233d, y: 0.3992408632047192d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37587535666807104d, y: 0.32401553941884254d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16586378437242344d, y: 0.6360649457367893d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43632124039085796d, y: 0.549737205464525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9189442424781854d, y: 0.2732024268438106d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18262699835600527d, y: 0.8194024312221718d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2809118007144311d, y: 0.3342011375992612d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8910801792265757d, y: 0.4567325294423489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5061252700040885d, y: 0.8019296044636305d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34106928086988764d, y: 0.7883282731180857d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6579157512505556d, y: 0.619956040285804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6939173504406642d, y: 0.6414033022316671d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5515184821616869d, y: 0.241003702517116d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21683553740959338d, y: 0.6442035289420323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6734196421207455d, y: 0.5263267647174863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24646552763134078d, y: 0.9224399491064023d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6805024418589953d, y: 0.040353327704440334d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24127653479346245d, y: 0.5643492775516198d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07797127378728563d, y: 0.3983511802762718d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7101176672334062d, y: 0.8868744048304791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15021954695282635d, y: 0.03473409382142256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2561958994331117d, y: 0.6042796590554691d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7071448250817651d, y: 0.4135251974307479d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029950006142453578d, y: 0.9623565821422561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05407817078083932d, y: 0.9738349557379449d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9613772444247288d, y: 0.7720565149241079d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6357141030198579d, y: 0.187342318601742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32636629955781804d, y: 0.9849527137993312d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7949786110055636d, y: 0.05314900335620498d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4784355502355828d, y: 0.7944050424044254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3147419822933418d, y: 0.012607483344897474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17174209895179238d, y: 0.9265507754832807d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5439752263221587d, y: 0.8531550438631398d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6699946650045685d, y: 0.9315223646617569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.487288878678111d, y: 0.8004925264522893d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32352481415138634d, y: 0.07076447944343434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8946263978493744d, y: 0.6924472401044953d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8759755850967377d, y: 0.05054840158171359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11851073207755658d, y: 0.2519883709097491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3504204925917791d, y: 0.7478720831981751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8159770599804317d, y: 0.8987662032637053d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31633301104713984d, y: 0.5506939916711862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.590127626732116d, y: 0.7167138654573986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44851947992648955d, y: 0.36957418131416675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1761383992802621d, y: 0.6930909548810461d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42427969184811276d, y: 0.050855161776768965d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8448671153100045d, y: 0.19243083165492791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19807140083055075d, y: 0.3199754493455842d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5462455461390668d, y: 0.08091458102345417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9154122054753909d, y: 0.9287412267986707d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5199537581564534d, y: 0.013795591380898808d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7163833060226661d, y: 0.6941474927288788d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4601283592709212d, y: 0.8228174357677938d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3356413789422281d, y: 0.2874039981080394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9305719006663792d, y: 0.6738504365537321d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12835279184295378d, y: 0.7415914487467579d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9108043251644959d, y: 0.88273840840434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.810618231835771d, y: 0.13979345502775287d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7803307747518788d, y: 0.790030471171767d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.011621327252240632d, y: 0.6399193858554755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04472128588968749d, y: 0.9998312450052841d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7222866617692135d, y: 0.2396888272089489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8094941408099301d, y: 0.20172929498258563d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31009059249510273d, y: 0.7598056286887251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9408728230356687d, y: 0.9735714123183608d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29531653622086274d, y: 0.038278167520891526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6691740943215603d, y: 0.24810999903782238d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3802106152247142d, y: 0.6565098544082085d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8357805050532501d, y: 0.08762949731976877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4064327809577516d, y: 0.6159266598661995d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1046082811925868d, y: 0.4966431010573791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9771135697890617d, y: 0.485049254095395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5936867737121411d, y: 0.6158125406856766d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4242081700031509d, y: 0.6958693164688683d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9896210638200882d, y: 0.32046701092079644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6217974659201116d, y: 0.8175755988589644d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5092500591069504d, y: 0.9971167915147042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.060046373029867484d, y: 0.8837402866651343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5843093665874031d, y: 0.99054341431073d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4784770024910363d, y: 0.68352433293665d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06584484880538632d, y: 0.09284874396704357d),

new NpgsqlTypes.NpgsqlPoint(x: 0.019528500919576586d, y: 0.15918280840280807d),

new NpgsqlTypes.NpgsqlPoint(x: 0.77736126414711d, y: 0.7406873929112794d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6637581974326581d, y: 0.4347698981499727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17233932793435403d, y: 0.49939656058826964d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1874827685649647d, y: 0.8121597349625677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23709666190970413d, y: 0.7374105131604928d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4017166242067344d, y: 0.8385564767027244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14789800322158253d, y: 0.5339877210906236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9507069403199679d, y: 0.23076292295863243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18957490768586704d, y: 0.5063863627841876d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7911720673648439d, y: 0.1007664991198699d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7959244979401042d, y: 0.4230232248665643d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34850044736235863d, y: 0.8186490573429767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2506254850569375d, y: 0.03850947113342651d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.911284365762647d, y: 0.6001673095763067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31003244443400446d, y: 0.1595220657492945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4682970648623078d, y: 0.12024616968035307d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1622272172422322d, y: 0.3854918073701368d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6613305916872287d, y: 0.6796174803405588d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3088049801376632d, y: 0.835062891814995d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6075071293727329d, y: 0.8345825055453511d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9551284675474833d, y: 0.7405371837878488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.677875943482497d, y: 0.5224347266653852d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8357447349756996d, y: 0.8706762367880172d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9520934349343282d, y: 0.5929846201461878d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2611326648175085d, y: 0.9766760184283585d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03728554670105566d, y: 0.9510064298639845d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8623247864683835d, y: 0.14318104269404286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5465219280311064d, y: 0.11585477634979968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.034185738027845414d, y: 0.5077128677917155d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5368932942695769d, y: 0.5393567971779496d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.763156612339545d, y: 0.5160575546976031d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27451005276756724d, y: 0.8850013187814062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37741844938383995d, y: 0.17330430713423195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7832045306157837d, y: 0.49395282920544425d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7305257920261531d, y: 0.10345967093473629d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18358555269603527d, y: 0.5651302770151793d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9939423683304782d, y: 0.14393967538449615d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6755140435016046d, y: 0.5342838129462324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5975200311515977d, y: 0.40280008838454306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8502797983490354d, y: 0.21106881335878502d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8477330174873697d, y: 0.7586287497301851d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33551832955892213d, y: 0.04874227170401879d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4299052890140235d, y: 0.7274896887530079d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5407880685384004d, y: 0.14338415929728998d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7118001186508965d, y: 0.8643272428731354d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27518776115288945d, y: 0.8670476816811674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.639045004037057d, y: 0.588823694050943d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8473671713853017d, y: 0.784842495980446d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11217489722942997d, y: 0.20439812764587184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9332456650293848d, y: 0.8582360265288786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27311974698824626d, y: 0.15990717629913598d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07788614640548042d, y: 0.8709159275566372d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36350967267566847d, y: 0.028820723528755976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9099015167165037d, y: 0.945025484728956d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1807089147434815d, y: 0.9143209868620898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5575274803028452d, y: 0.7577903462728225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7723975040694704d, y: 0.4972372635841803d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31707351303562026d, y: 0.6564837112667571d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5514593764403212d, y: 0.82871560189371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2749259556900091d, y: 0.42867049776949495d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2583642872160472d, y: 0.01568688997882972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4817651651628533d, y: 0.5463918271949623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3646695546759464d, y: 0.8460650971596013d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2172656515421647d, y: 0.6100300864168239d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34119026179513556d, y: 0.442109389031077d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6564352658741345d, y: 0.061131731576160475d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6740028583715233d, y: 0.32311891711749785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0022365416334795274d, y: 0.31422685989642196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5597694677124068d, y: 0.7974099081652399d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5153605801725955d, y: 0.0629492957662644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22659188233847338d, y: 0.23420206590596981d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7447026541206698d, y: 0.7113599536176488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7461722287931989d, y: 0.2533988227120819d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42148203372474224d, y: 0.3907925392252516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6540056490053809d, y: 0.6919872990792603d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6288753338480059d, y: 0.6893897602236232d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6997274924315012d, y: 0.37936868247278943d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6155336846487074d, y: 0.712366539852295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25759777876981416d, y: 0.40817022319917484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.054742088812357315d, y: 0.4687769610480029d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16989134886510282d, y: 0.6839089840050342d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4335607958614264d, y: 0.9752373100958485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8723488063525974d, y: 0.6395007164206985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06394559637613839d, y: 0.7413586637601015d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5738152370637798d, y: 0.04804963390282435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9500933434811366d, y: 0.9061511598921451d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9985696901974542d, y: 0.2034354676789063d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7876685037014831d, y: 0.5692319670209418d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3094553446529562d, y: 0.7125252374952162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7541309421675841d, y: 0.10280338924722776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2295038986120348d, y: 0.24568420870604757d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4519124585907789d, y: 0.3564759955070045d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8207647193034511d, y: 0.785736763773854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8452717186652788d, y: 0.9247794694179851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9138748664497695d, y: 0.4191338612511871d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9363896466875682d, y: 0.9747302183012422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8355511530216694d, y: 0.8530065173200688d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9504078578440073d, y: 0.23076926994487335d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05180924903612527d, y: 0.4189289974355306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3149456094834955d, y: 0.9689896268518323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.506139825806131d, y: 0.8698966268476476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.019823061584476553d, y: 0.07564375296981629d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4048808421264135d, y: 0.15815193353280854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9683354352385524d, y: 0.4195870387424956d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16543144564528556d, y: 0.7621815551113581d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6400449518642344d, y: 0.0027560850729391184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2014086566199671d, y: 0.27561689993065475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28260138788855504d, y: 0.7232619764737913d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21119333947132113d, y: 0.6490984540472337d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5670858356770253d, y: 0.6716935138339022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8870613454974952d, y: 0.8287469432105903d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17529247534691283d, y: 0.030458716467271496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7306278495038858d, y: 0.6154883205123517d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6851520641440284d, y: 0.18498431996844777d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9745898540560954d, y: 0.18025735803675969d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7134146594218235d, y: 0.4234716032587392d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9021207059802688d, y: 0.31453352933209466d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26199433799864924d, y: 0.8728716639191524d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1554216139822746d, y: 0.33504836093553203d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33464072848944804d, y: 0.11482520730540291d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9331949010206709d, y: 0.3213734618346975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9006622500528155d, y: 0.8173497340114453d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26097972129753555d, y: 0.6580185233079513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40039287967016945d, y: 0.11423673296211401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.799765703856153d, y: 0.7546208792944673d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9045978743151986d, y: 0.9527591392895792d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5696141684099927d, y: 0.17092865725746698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6863993443741032d, y: 0.9724764249051234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5616299876067846d, y: 0.2056708077061542d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21473667051106748d, y: 0.9819490698064653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04189774391710055d, y: 0.8100199171418172d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11770304144043475d, y: 0.8073759209350263d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6403081230906379d, y: 0.7484322420306782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4089462810371578d, y: 0.2937587007493243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17550188930302912d, y: 0.7369351813570578d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9144574193454537d, y: 0.8502342456097645d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1471172880100069d, y: 0.2614922599136419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29350405487362785d, y: 0.07708093854188014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36754341512785293d, y: 0.23311398291571428d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1917888719190497d, y: 0.7097777244561939d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32301156647166995d, y: 0.7504344266946524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49795130859031056d, y: 0.4925381028812694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9532615661892206d, y: 0.1100029814430884d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2723067797039258d, y: 0.2930953332874322d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9030609143312882d, y: 0.42075868615768375d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9505357756396835d, y: 0.7213088876951196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6068438183505795d, y: 0.5999665119526171d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.749676113021841d, y: 0.5221038918129766d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5024184411858963d, y: 0.452288907983627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21537387581727663d, y: 0.1169683342432487d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04275728171588111d, y: 0.6072399548539856d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9927833892093851d, y: 0.4014811029615021d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9737216811425722d, y: 0.8374811003670372d),

new NpgsqlTypes.NpgsqlPoint(x: 0.696862915092649d, y: 0.4338401946367031d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26264914415102636d, y: 0.11149862681896139d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5119714117572937d, y: 0.06137580160821843d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8036047916018411d, y: 0.04162014261708147d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3007430167875653d, y: 0.6490410020177867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.983259249670598d, y: 0.05663571929028122d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06603375532733546d, y: 0.832820706346634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19734019280496706d, y: 0.059066479724101395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7798390750898584d, y: 0.6892327316022049d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6250637070832783d, y: 0.6643477271893536d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6577652416074947d, y: 0.8556388466801759d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5867789938173822d, y: 0.8124676077684047d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6298593363312358d, y: 0.9844237604328573d),

new NpgsqlTypes.NpgsqlPoint(x: 0.822287190336966d, y: 0.5882144127865128d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5535220467514085d, y: 0.5041465204828572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35753624714290877d, y: 0.16969300246189478d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39909448384882584d, y: 0.22023009439382935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19594526657199873d, y: 0.41405732227584735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6077381238007611d, y: 0.2872810268282756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5434978644987133d, y: 0.24853629109606168d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20481179227308466d, y: 0.6462737119481177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42242488864766614d, y: 0.9615202982016462d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7063524914972041d, y: 0.9679065906571243d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15949826629984487d, y: 0.4927448776846305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31299933274298586d, y: 0.3468967164728185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9444137876353373d, y: 0.36728260494397014d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6712952711529395d, y: 0.16433130088357073d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3456101104022611d, y: 0.1647334853548167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.542741326133998d, y: 0.2736650982159665d),

new NpgsqlTypes.NpgsqlPoint(x: 0.445096456558693d, y: 0.6069123013088579d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5321856603487617d, y: 0.3023447776251559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8982150402402738d, y: 0.8259079220670654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6306979159463846d, y: 0.13417764986277103d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                List<NpgsqlPointpointListD1E2M> models = null;

                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointListD1E2M> models = null;

                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 111, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 134, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 139, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 131, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 71, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 80, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[14], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[15], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[16], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointListD1E2M),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
FROM public.binary_npgsqlpointpointlistd1e2m m
LEFT JOIN public.binary_npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models =  ((INpgsqlPointListpointListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI), typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                await ((INpgsqlPointListpointListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                ((INpgsqlPointListpointListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

