

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8082135479242858d, y: 0.5717672254185167d), radius: 0.7660108565618798d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7735950366244003d, y: 0.8828745977093896d), radius: 0.399449741996158d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10880135455538242d, y: 0.7838636640128593d), radius: 0.14608928152507128d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6120177840805172d, y: 0.6823249976043184d), radius: 0.8241019704274568d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34463823342002353d, y: 0.4900040346582225d), radius: 0.6313719411954801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7104464099965025d, y: 0.39126065121535414d), radius: 0.6343773975943403d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9014436643160216d, y: 0.6289117137336744d), radius: 0.8262458981804995d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7639275825772276d, y: 0.08373009813763177d), radius: 0.9353900252085633d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.409379503902342d, y: 0.8508544150787476d), radius: 0.7905867063256465d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.798994344734103d, y: 0.04615408293941925d), radius: 0.010937823746992259d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5762695596008857d, y: 0.3276134476494147d), radius: 0.32358655712375817d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22236710686543015d, y: 0.87194446960245d), radius: 0.6932282534532112d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9398589036477333d, y: 0.7952892430289362d), radius: 0.43370530957089937d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39941477507560996d, y: 0.04634473079043855d), radius: 0.018862205832973933d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4646955254303471d, y: 0.17814369251209095d), radius: 0.5472371607651971d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6835387462969273d, y: 0.4171434539380332d), radius: 0.11578397758214598d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5566143637809402d, y: 0.09674757737978124d), radius: 0.6721870236705569d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10691551953631573d, y: 0.9895943270886298d), radius: 0.7608663830234239d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5587056569746766d, y: 0.5307592067942161d), radius: 0.7375763927184862d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1741137644674442d, y: 0.9317740918734336d), radius: 0.5593355328371492d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8038374290042298d, y: 0.26118523955953565d), radius: 0.0368749300662109d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8479168487915482d, y: 0.49528652840471177d), radius: 0.21204851287484472d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5932827947709679d, y: 0.2842920191691394d), radius: 0.027148274414023676d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9482649441492713d, y: 0.2735175249709437d), radius: 0.04215881411242339d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3595834894406833d, y: 0.2986242753019017d), radius: 0.4618892509035568d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47606768879974104d, y: 0.4638077234950132d), radius: 0.5205003103659173d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4168806871050069d, y: 0.938146410161953d), radius: 0.42654151659135353d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47507718591691783d, y: 0.5637765091473612d), radius: 0.8254078121424531d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05151159016415641d, y: 0.036425691609726196d), radius: 0.5214842976005756d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38595106505402643d, y: 0.24305200939748373d), radius: 0.30219519266564565d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3161648487106803d, y: 0.7985121033138777d), radius: 0.7046359079217834d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4987079226303168d, y: 0.07048817701664878d), radius: 0.9363497709219802d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6626747072269606d, y: 0.04125568425643844d), radius: 0.14721673428324644d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7991957751931591d, y: 0.8535057364660043d), radius: 0.53528640860463d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5708806920550552d, y: 0.5690829505592204d), radius: 0.0017248264369147392d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00794048296604799d, y: 0.0883185725841179d), radius: 0.6859565101039202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5295241538602853d, y: 0.18298417798257205d), radius: 0.8076257574550517d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14010788008543917d, y: 0.6541376838902283d), radius: 0.5777824426416132d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08656066223493475d, y: 0.4221998525760977d), radius: 0.9848610610041314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46424987894586967d, y: 0.748994760894399d), radius: 0.14091854699469997d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9734140294508808d, y: 0.05500892603715779d), radius: 0.4525571244090629d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6536628025630044d, y: 0.15425367006871205d), radius: 0.5449585500598494d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011020053848472822d, y: 0.1693048231827129d), radius: 0.4543888105326176d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14590894206592775d, y: 0.8558466087742241d), radius: 0.5237274887675205d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16378635790774987d, y: 0.2706846144823819d), radius: 0.9473026016841829d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43136379746302456d, y: 0.1610355863138131d), radius: 0.48817967940267293d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.574782537088765d, y: 0.9602961864846323d), radius: 0.03253907099313502d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6593286362045603d, y: 0.6324500421624951d), radius: 0.44603870102370147d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12045025896809092d, y: 0.5150868431155129d), radius: 0.6302849550445497d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05043477424397147d, y: 0.2290074890359547d), radius: 0.5041709394553401d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8923119582126778d, y: 0.8252509243895209d), radius: 0.7220246273004849d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2746136217052768d, y: 0.5708058684722047d), radius: 0.5351469996639987d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45205253609879825d, y: 0.7090267653723761d), radius: 0.23481560042673444d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32231592314677415d, y: 0.08964129115657093d), radius: 0.674503445237145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9428657607341281d, y: 0.04370077818997242d), radius: 0.0011241288677387162d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6772196056487183d, y: 0.13555254436990427d), radius: 0.010125083423821457d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3352779246224581d, y: 0.0011077779745886085d), radius: 0.24092339049651468d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8422603719648898d, y: 0.5277864588939962d), radius: 0.7162433744554827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7424323288368828d, y: 0.5201985149844645d), radius: 0.7524683099098457d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4243967540399808d, y: 0.4355847526741369d), radius: 0.012646863431751476d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32915903349019193d, y: 0.14341844561510497d), radius: 0.7250899021578873d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3528028558503079d, y: 0.5009285817381418d), radius: 0.05724913945497201d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15383931058722644d, y: 0.9638501178095613d), radius: 0.6740115037967501d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7106292216656801d, y: 0.650515675168722d), radius: 0.8708182544838604d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4473278556431408d, y: 0.3344714039477037d), radius: 0.44839958703481697d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7620714687388694d, y: 0.9939271391828424d), radius: 0.33629659055565475d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18104478389017453d, y: 0.948109388797075d), radius: 0.3166235390202434d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3737486768396612d, y: 0.29463653206408946d), radius: 0.9483256383408906d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6760345969122259d, y: 0.6639788736418779d), radius: 0.00506493100663874d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7421411664733271d, y: 0.4143264628601321d), radius: 0.20416705776591715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7865298316428608d, y: 0.43368681501579365d), radius: 0.3695159739982916d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6074027994939076d, y: 0.43084105175824094d), radius: 0.8554820340666418d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28692337465184714d, y: 0.9156065879550497d), radius: 0.7298061622510575d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386634967847012d, y: 0.07267554431171774d), radius: 0.38402030570920387d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6443761287561826d, y: 0.9645898704266459d), radius: 0.41781111534629767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7095562589652947d, y: 0.9994404098426204d), radius: 0.017881088656686916d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8696569907690355d, y: 0.250705527080183d), radius: 0.44446615021821945d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3593324702728279d, y: 0.4951660789691239d), radius: 0.5293569015001699d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.919274444988202d, y: 0.37415168403362364d), radius: 0.15163576921898536d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6126671613470267d, y: 0.4236411630637946d), radius: 0.7225860431906004d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025828155172829104d, y: 0.3954077639271505d), radius: 0.20562559902095356d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8480321410988035d, y: 0.08796897006559545d), radius: 0.4572415991811055d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08456904516325225d, y: 0.7587516969627445d), radius: 0.24779217080299132d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8754978173614129d, y: 0.191717286842234d), radius: 0.9469942450801803d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6743931964189317d, y: 0.9624329043201891d), radius: 0.9687707718695827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7655894330760383d, y: 0.3114903679636506d), radius: 0.669146046774734d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8891673832408952d, y: 0.29091030039596255d), radius: 0.8105654465929897d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13237138160812267d, y: 0.3821500033581884d), radius: 0.6123878763391134d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3533642142898792d, y: 0.6921502188519321d), radius: 0.1499241617693846d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16073656738412267d, y: 0.7069482070585376d), radius: 0.4599572736970785d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8362716256375836d, y: 0.18432275570124212d), radius: 0.8231262158574115d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3747471292130924d, y: 0.7498413920917085d), radius: 0.41861016989359046d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13946721739875512d, y: 0.39217541136157075d), radius: 0.7036841453378465d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.960607763796489d, y: 0.20849557536570995d), radius: 0.9757238582584422d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7914346410262509d, y: 0.7587479648943136d), radius: 0.26150713880517085d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7663786875893186d, y: 0.7920941859958543d), radius: 0.9829382841841245d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.344481279991642d, y: 0.26573442484897036d), radius: 0.7189173689355559d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22895703418340108d, y: 0.6462102946671291d), radius: 0.12488818510927213d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06502440871418591d, y: 0.9673115599200167d), radius: 0.36535730277966905d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42576572389546974d, y: 0.35604226743339584d), radius: 0.5588331511982205d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23929620690920406d, y: 0.9539184432834674d), radius: 0.8317125582157401d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9707295089279062d, y: 0.29763772774432906d), radius: 0.3760692299366707d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.056251133415364585d, y: 0.08942490973470696d), radius: 0.5874800413364456d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13368206463374932d, y: 0.9093808506699989d), radius: 0.46299123625633d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3529096947177145d, y: 0.0037887460199257372d), radius: 0.21240928430080452d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9063526740891765d, y: 0.020166461472118313d), radius: 0.7111563809835776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9203483784610594d, y: 0.5094038292828532d), radius: 0.9305863961167568d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4806535764508646d, y: 0.9738323756192229d), radius: 0.8229666232305518d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6077860084120948d, y: 0.11609443973197053d), radius: 0.843682365751394d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46715005649704233d, y: 0.3337437792726934d), radius: 0.17517226244281903d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5165404996446891d, y: 0.3610144821779241d), radius: 0.2653912550917211d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7189298645353609d, y: 0.33536956685146846d), radius: 0.2462427352100922d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.502682251873041d, y: 0.4280294389285466d), radius: 0.377654700698008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45226675506887604d, y: 0.923290878648681d), radius: 0.13783728827117137d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6633588925794108d, y: 0.3898553226122258d), radius: 0.5385595800787657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8694833386921716d, y: 0.7608977311819258d), radius: 0.748884945274225d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03352196407094021d, y: 0.946957282772165d), radius: 0.7657702359553497d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5974025375562426d, y: 0.6501578356740807d), radius: 0.9078779247526652d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9280657203536056d, y: 0.27817684832542655d), radius: 0.28714925334602626d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7226137028606633d, y: 0.9314325014369218d), radius: 0.7714615459351202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5438990880016658d, y: 0.151161916683892d), radius: 0.08075603351549943d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31880494545915916d, y: 0.06341084550662579d), radius: 0.32150529084457447d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7246895673793706d, y: 0.08298047853044965d), radius: 0.1120635711268998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33805939819593966d, y: 0.27931496915654985d), radius: 0.6321965608290336d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6124051935672625d, y: 0.6507676120776735d), radius: 0.5362092646040002d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9562832969943478d, y: 0.0731481311945581d), radius: 0.9941874830063991d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29668077286120986d, y: 0.9592927079903545d), radius: 0.5247462521092264d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12844551745107358d, y: 0.27638408576404816d), radius: 0.5090470441299249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.052552365952382885d, y: 0.7478623537568654d), radius: 0.7375311374412746d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9757978013889056d, y: 0.03382800821584364d), radius: 0.9138646119607721d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2929381538779976d, y: 0.5856356563577603d), radius: 0.8648355359209539d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.061549627665138607d, y: 0.39582420332293267d), radius: 0.45642959937829464d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7804193614351681d, y: 0.49184305340690204d), radius: 0.5259302455435074d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.758207164097998d, y: 0.7091658914337431d), radius: 0.9588787748789892d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43140276967772684d, y: 0.7106989251367525d), radius: 0.9762922787026688d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20578911460368476d, y: 0.5810245266003098d), radius: 0.03805647772529508d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25599493498220716d, y: 0.4912376501991791d), radius: 0.1630352598542295d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3703845719751132d, y: 0.8351405935769259d), radius: 0.30035848531147746d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7445891423278603d, y: 0.3473050026805178d), radius: 0.7225475814112073d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015010963512410824d, y: 0.6437796446763904d), radius: 0.9094491610748536d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15856178310792846d, y: 0.19094408142860608d), radius: 0.9184452969002163d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1954348613827851d, y: 0.8496719560228129d), radius: 0.41894832010857674d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5374606509223617d, y: 0.7253820981535363d), radius: 0.7962509145569426d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3114225050240451d, y: 0.3120683687777658d), radius: 0.4427221096658319d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7417928635342876d, y: 0.06500802950631146d), radius: 0.40450450950891015d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08531683696193415d, y: 0.0010574663000975093d), radius: 0.9010841864288568d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4451699660979458d, y: 0.550606899046866d), radius: 0.5236919952892908d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8981101222065383d, y: 0.21384844180510343d), radius: 0.45644571437309256d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6680199016446002d, y: 0.31858705244673524d), radius: 0.5539598226266125d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.952031803006193d, y: 0.2756741042254778d), radius: 0.5170734431255531d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7682133737559762d, y: 0.5157795572836831d), radius: 0.44079004429896473d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5699108657516194d, y: 0.3908891438933172d), radius: 0.023560617612084056d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8188943751359251d, y: 0.23500654177008307d), radius: 0.558529032078553d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13628172181065545d, y: 0.17148164041422642d), radius: 0.5202089179470302d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7080753569799211d, y: 0.8127634676955969d), radius: 0.8660242944401846d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027293851346744225d, y: 0.4036677753263477d), radius: 0.18838618814921482d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9249585163388425d, y: 0.12282460986167609d), radius: 0.6601154703633499d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834265843511976d, y: 0.10044125268997417d), radius: 0.8463677039653763d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5262066519944529d, y: 0.19456973276914402d), radius: 0.31484269740383286d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7138009872709521d, y: 0.9250714499230736d), radius: 0.181195603367448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08375093770719888d, y: 0.49421251217367623d), radius: 0.09880162377306723d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6797930901422535d, y: 0.85176938803241d), radius: 0.6296643464613626d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19746881936691374d, y: 0.9098140229870535d), radius: 0.3413425068184306d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1349755718893224d, y: 0.13054144498096532d), radius: 0.9084664097283114d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03056279442803167d, y: 0.9128360154896945d), radius: 0.8976463628141794d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5160222721219492d, y: 0.22968116495344715d), radius: 0.3553875836364615d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9980141410233603d, y: 0.14724630133360095d), radius: 0.524169373802371d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6115686922652644d, y: 0.28396240816839746d), radius: 0.7163225146465017d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7009688897251939d, y: 0.12035488092652613d), radius: 0.22300646983140493d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6261776794386041d, y: 0.9660280143458939d), radius: 0.7303720100415888d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9934068916836674d, y: 0.5854561258690698d), radius: 0.6572588656812186d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6181600519415712d, y: 0.6510765854903225d), radius: 0.6085231744826352d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7179408200059242d, y: 0.1430145610376823d), radius: 0.8326449702828029d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3834261387019514d, y: 0.4964507801254132d), radius: 0.2116843750611258d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5898937812688321d, y: 0.16963161249785508d), radius: 0.830615343270379d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6498428494131452d, y: 0.22410632095582605d), radius: 0.04525484255670342d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7395788383794052d, y: 0.8949608290075991d), radius: 0.8586157454584596d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9666235445101229d, y: 0.13070037690983005d), radius: 0.9436495399380211d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9206712815338314d, y: 0.1869668493770913d), radius: 0.9089687331858525d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.053805255938960794d, y: 0.4177967286994313d), radius: 0.06986881026623659d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757176552810395d, y: 0.18430281754393452d), radius: 0.26688211904342773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9092623629898463d, y: 0.13499884958533848d), radius: 0.9746809766068788d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6946763761201452d, y: 0.19623096227155534d), radius: 0.24380953804685646d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7294750115384655d, y: 0.5739264984757658d), radius: 0.03843062143475362d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8386280294823317d, y: 0.3996438567112879d), radius: 0.5592903747802259d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3108870971971882d, y: 0.214769194477765d), radius: 0.30482925775898684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9334145260746021d, y: 0.5568020691919314d), radius: 0.22151461685100204d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6215761065025135d, y: 0.27074221044577595d), radius: 0.13485347289203886d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022153190550133095d, y: 0.9223547120819366d), radius: 0.001497101450363969d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4725150792584153d, y: 0.7359724823821036d), radius: 0.14762514091709378d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9327130037394443d, y: 0.9472906729419048d), radius: 0.9454178330620957d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2954807046151131d, y: 0.7408857390991823d), radius: 0.41987844724742485d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6962148822128723d, y: 0.7176632228015564d), radius: 0.7544662186546199d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7682110168230802d, y: 0.3963350117612773d), radius: 0.88708790785038d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4764340310644405d, y: 0.2950884642024202d), radius: 0.5450431889020821d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5745508440314802d, y: 0.5023414797067979d), radius: 0.803273612301326d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2914141994848921d, y: 0.8083994096109612d), radius: 0.8129129157197904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12399176344028284d, y: 0.919335537021364d), radius: 0.8797087510380998d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2760328803640253d, y: 0.7614809154536384d), radius: 0.24205277039093087d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.51837541010279d, y: 0.041356934836724535d), radius: 0.9492001984022304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09574383824646437d, y: 0.9427787934482822d), radius: 0.06066313625853381d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.953090115206373d, y: 0.5927480443265558d), radius: 0.4614901484790137d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9694517423242307d, y: 0.40047412523677484d), radius: 0.04083328730506541d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011679789816422148d, y: 0.5016196947695899d), radius: 0.09447326454905469d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1748371427244313d, y: 0.16891576715105527d), radius: 0.1658512738272877d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6198084810224025d, y: 0.7652774037893081d), radius: 0.27752609347186374d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026638803712247805d, y: 0.07208957540066185d), radius: 0.03657602269046045d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38643397179346695d, y: 0.3842723600030725d), radius: 0.019410357483550245d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6008334472071382d, y: 0.057984260238266305d), radius: 0.6461730936424205d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02917942683210184d, y: 0.0032985890651539007d), radius: 0.29776876855316736d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.756434413314151d, y: 0.9746946205578708d), radius: 0.14560383494326024d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8182734476458582d, y: 0.18332054520791985d), radius: 0.04296002976910018d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16962722315847256d, y: 0.6252661386154064d), radius: 0.4451593413877596d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5178307571653724d, y: 0.9517337564083024d), radius: 0.01699424864978394d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5001912209039359d, y: 0.2888309830963989d), radius: 0.28204727298347976d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8747144315840426d, y: 0.6412329216503951d), radius: 0.752291330032591d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17467306430115448d, y: 0.23037385960159207d), radius: 0.1450987972728941d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.944816057770982d, y: 0.5835890513355269d), radius: 0.5583340193111854d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.605663318275504d, y: 0.7456797347900567d), radius: 0.989521984429083d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5788540374539819d, y: 0.4646426214342232d), radius: 0.977425902870667d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5014588686764422d, y: 0.7855821942249618d), radius: 0.3986392777507607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4281448240755722d, y: 0.4606377086981672d), radius: 0.6122431039834734d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5123384699387026d, y: 0.8751620742556241d), radius: 0.8463045932219457d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6897615489617059d, y: 0.19775031410924104d), radius: 0.3089773029368795d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019802707827318966d, y: 0.5410432518631322d), radius: 0.9457451935378736d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3482149961625035d, y: 0.14983819055418846d), radius: 0.6611396239592928d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3549736118115059d, y: 0.8689289170073363d), radius: 0.31323505259611006d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19188200145218748d, y: 0.8132715185405119d), radius: 0.21485491987819183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7125138177582527d, y: 0.49637190000960907d), radius: 0.43845279914014235d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31195021444276605d, y: 0.7932365373222366d), radius: 0.7477077539269623d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4398522140371134d, y: 0.7036182476062722d), radius: 0.8686063919126675d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9795361086871869d, y: 0.4591885825939058d), radius: 0.23324610283399505d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23209851860164288d, y: 0.3681320947068949d), radius: 0.22443540300510134d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19178810864362683d, y: 0.2881201407984926d), radius: 0.898578073796934d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.909671122026016d, y: 0.634068328516847d), radius: 0.9201240122864879d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4197630468754957d, y: 0.3010838013972982d), radius: 0.11854758171155422d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33443773679215816d, y: 0.1723545935493106d), radius: 0.2432687242130781d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5549788353993428d, y: 0.10372924826003249d), radius: 0.04795842859626853d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3737301152990359d, y: 0.7420284812775823d), radius: 0.13451966939023852d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8801110457212185d, y: 0.2029700802241824d), radius: 0.5577214449647783d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1343536585657653d, y: 0.8811024360317677d), radius: 0.3527486565396769d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4241453848722545d, y: 0.0325099870693224d), radius: 0.3851475467074499d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10685537151080038d, y: 0.4239735983548262d), radius: 0.7874454507619836d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5842700718721375d, y: 0.339706288775512d), radius: 0.398947532627831d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8853172142431446d, y: 0.27980005672883335d), radius: 0.4786987789611318d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9968458953494485d, y: 0.9812671251020815d), radius: 0.8470922545827408d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8054946657380359d, y: 0.2624317210556413d), radius: 0.3290660960602755d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8707224553523629d, y: 0.6607512429252174d), radius: 0.4747573874745248d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3436988567460594d, y: 0.32544775425666983d), radius: 0.35145863334567007d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5301034367488511d, y: 0.7913023329913379d), radius: 0.7290864022822632d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9232329814170572d, y: 0.21057894811905253d), radius: 0.8671641414500266d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3831797530913468d, y: 0.39998490388725805d), radius: 0.38221228264817053d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9134014121678748d, y: 0.3538233227146842d), radius: 0.023449963281248265d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8234727368254171d, y: 0.7119516151389522d), radius: 0.6427329827495234d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1292256233470126d, y: 0.8484871862613165d), radius: 0.907712496878801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19509046739788294d, y: 0.47349256380529536d), radius: 0.04429453018459939d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13259569832134221d, y: 0.756785816784147d), radius: 0.9680003566795865d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34204311972512336d, y: 0.008229658403039908d), radius: 0.30524087076666095d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016457942122792835d, y: 0.7769203499702741d), radius: 0.2660127459052878d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3902180304844579d, y: 0.009824539733380155d), radius: 0.07407474713026962d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9947005187043231d, y: 0.588401451314396d), radius: 0.9451060267076545d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3098299296489859d, y: 0.6851738912302101d), radius: 0.33408156131299904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8890011726904252d, y: 0.40882898586164385d), radius: 0.9503844004043112d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21485771238147233d, y: 0.974330790419715d), radius: 0.8397375546881856d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6445515831935796d, y: 0.06000317541267974d), radius: 0.26676024386531205d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5042914955274392d, y: 0.9507633729942132d), radius: 0.9818853191788355d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 36, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 128, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 23, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 21, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 50, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 109, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 144, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 61, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 31, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray2M),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2M>(15);

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
                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

