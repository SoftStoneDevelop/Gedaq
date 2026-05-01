

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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11415213925303302d, y: 0.057784342588274806d), radius: 0.7696380404857103d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4068890170336237d, y: 0.40474608106883625d), radius: 0.9677359178745369d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9516132106923196d, y: 0.4814097059157316d), radius: 0.9790925352908532d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3363615835240019d, y: 0.175528064231799d), radius: 0.72770808346486d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3945995848064423d, y: 0.32573221865481095d), radius: 0.8852763789300577d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4644287176453661d, y: 0.7722231643374197d), radius: 0.709696711716558d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9838081107467301d, y: 0.1917252598359408d), radius: 0.9009978112967968d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04703186289944483d, y: 0.7938425008641173d), radius: 0.724840141322942d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3440689033553046d, y: 0.18033711670814778d), radius: 0.9240848281481341d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2013435018902363d, y: 0.49904477845194317d), radius: 0.617336022156706d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37407841651109053d, y: 0.03570613776693665d), radius: 0.6597744390070458d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9693025235183073d, y: 0.1564726792853225d), radius: 0.16069499714350877d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37274019535631087d, y: 0.2757223159492105d), radius: 0.6720889573897496d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8725165448925417d, y: 0.19969570323909736d), radius: 0.6990091675691213d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4125721638488262d, y: 0.5609531053183664d), radius: 0.34421768358704397d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048359795293637764d, y: 0.817014155754421d), radius: 0.7493177129398394d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5654597100211811d, y: 0.6240088965034514d), radius: 0.058814119403121645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11758723793844417d, y: 0.6273266187719334d), radius: 0.7296353810725003d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47443844042842476d, y: 0.24557936146564574d), radius: 0.802361044047289d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8712591604435458d, y: 0.7127211042978929d), radius: 0.0002481419591754408d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6965340616230363d, y: 0.4539052213865368d), radius: 0.5724693129156004d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.653366392136742d, y: 0.20404010048162546d), radius: 0.42473625368950774d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19544478520978126d, y: 0.3318062899301679d), radius: 0.26386289782264916d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.306891790387369d, y: 0.5860369593861963d), radius: 0.7343077700381317d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00736624011830489d, y: 0.08147597557571307d), radius: 0.7616403515005791d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7146438795945582d, y: 0.3631532345917353d), radius: 0.4154077168902055d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4407904303800724d, y: 0.5710561572754422d), radius: 0.4444219774425294d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6164843099762215d, y: 0.5750742792804117d), radius: 0.2686812307622862d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683980448245394d, y: 0.6997987280060806d), radius: 0.682476460777752d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8379643269139114d, y: 0.23200632183994885d), radius: 0.8756856263204591d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2591900440193654d, y: 0.3473664125290057d), radius: 0.9930349785165585d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.911623762197075d, y: 0.9435737105855854d), radius: 0.5704370768234487d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986061186475613d, y: 0.09138618822377276d), radius: 0.3535329559323981d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8247660092562542d, y: 0.8095649551060409d), radius: 0.5297726170858998d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39127369383801647d, y: 0.5377511656763097d), radius: 0.7538915066910522d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5943978014500668d, y: 0.0770878088523631d), radius: 0.6121312723493488d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7652817703115984d, y: 0.21165133061441754d), radius: 0.19211194594627234d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8291589037169318d, y: 0.5882159963241352d), radius: 0.1762752145617934d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44032292767083303d, y: 0.6113424023036582d), radius: 0.4802387808889268d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7428382587327784d, y: 0.017161908605346388d), radius: 0.0027190388533484544d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6330916768867093d, y: 0.311254888487974d), radius: 0.8567144633435312d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9761596850047544d, y: 0.3072521808194254d), radius: 0.23828625220714816d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6765543602233186d, y: 0.2263462537476253d), radius: 0.2898859863428531d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6464626912331185d, y: 0.1378227643878227d), radius: 0.09587848895170448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42863897165334786d, y: 0.27523494745553856d), radius: 0.28988682672711463d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06758597830757218d, y: 0.21504870164774903d), radius: 0.7441790090635098d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5024423134153159d, y: 0.14597645939379622d), radius: 0.5010374007380896d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9191959838514897d, y: 0.8910359296177739d), radius: 0.8280808701965463d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9739729825086241d, y: 0.8106561520649443d), radius: 0.49170201040893147d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6044931308963406d, y: 0.7171857925854516d), radius: 0.7044500828650466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21830942901263184d, y: 0.7009152732759408d), radius: 0.7428756468963809d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5952253062621787d, y: 0.7828932588562395d), radius: 0.26660796523800523d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5112412705070102d, y: 0.09662718123808345d), radius: 0.23409856303957144d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14354632133009027d, y: 0.9258232259817761d), radius: 0.5990295002474517d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.190661021395386d, y: 0.44320606768232085d), radius: 0.11577841654734111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.911906182879315d, y: 0.49793471471877593d), radius: 0.5041622528709896d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7566785618434452d, y: 0.4952093321585487d), radius: 0.196037640279478d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4111677765390461d, y: 0.371417088496092d), radius: 0.03841324579368499d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45694042311888783d, y: 0.2685593209687086d), radius: 0.6873083081265697d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5006133352071684d, y: 0.7060221026629491d), radius: 0.3191388021187842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47567538035134815d, y: 0.41569361648561554d), radius: 0.5699275807264776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.332733584821977d, y: 0.016976410725308644d), radius: 0.9685227143717203d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8975419049919835d, y: 0.3190351564392374d), radius: 0.40864997173618467d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6284785535550156d, y: 0.5256408552231997d), radius: 0.9717029403130061d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8540259355513414d, y: 0.9552159147344418d), radius: 0.7554999460897217d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39748835089476797d, y: 0.9181710196490616d), radius: 0.0894816758852226d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9094483116295776d, y: 0.5707744117912971d), radius: 0.31578844383170324d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.034170344492862936d, y: 0.44911138688561925d), radius: 0.45551467036652904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7111650439948578d, y: 0.3122110597281591d), radius: 0.608372683504196d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3973419563073197d, y: 0.2829467347702649d), radius: 0.24058431247392031d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3027928344625598d, y: 0.7905039930547927d), radius: 0.014659555564673687d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.017174258518409147d, y: 0.2646891363198812d), radius: 0.045964037690299d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21179314196324084d, y: 0.17126828003555183d), radius: 0.24851623723773364d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19391916628570227d, y: 0.9139023024100194d), radius: 0.9550877886598035d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5297150052553217d, y: 0.34887578225849913d), radius: 0.5137993593679411d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43057328277643514d, y: 0.38478530912084674d), radius: 0.4620028369312744d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5650215918705641d, y: 0.3997934505865388d), radius: 0.35764969345078423d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6028618725507473d, y: 0.9038099441460149d), radius: 0.9680881807088236d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22903500638600582d, y: 0.6431394913140923d), radius: 0.6868461967772396d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35388432217667887d, y: 0.35022590584498403d), radius: 0.8949326454381343d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.061402794507311675d, y: 0.636957533888294d), radius: 0.20460773759609285d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35025277747484607d, y: 0.30411129469268683d), radius: 0.8506561367205454d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7716426857463862d, y: 0.09224523228765014d), radius: 0.09566109398931721d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4695616581962243d, y: 0.8170477541317278d), radius: 0.11253448676415267d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2172579689252272d, y: 0.2468794427651828d), radius: 0.1518502569830965d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5110457646924318d, y: 0.8753601330805366d), radius: 0.5223100571378776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8341457151681666d, y: 0.930485029704633d), radius: 0.7826899532555718d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40419794535701015d, y: 0.37726898678766674d), radius: 0.21967380461382602d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8803334637250702d, y: 0.20181389873145206d), radius: 0.12587858373052085d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9055790569007703d, y: 0.6958634516276595d), radius: 0.7529580856611273d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3337686144315938d, y: 0.2665326786855363d), radius: 0.639571573313078d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8535643753921278d, y: 0.2671163114993955d), radius: 0.14178323196034914d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7587991266082056d, y: 0.1303672832938373d), radius: 0.29141260216192766d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46138297892989066d, y: 0.9245102185303783d), radius: 0.496721246156531d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.642006734829868d, y: 0.18942947528413834d), radius: 0.6729487701469713d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2837947962561901d, y: 0.9011842094748744d), radius: 0.7377274265737324d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7560957362051063d, y: 0.8396207293367005d), radius: 0.16221261320377167d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7415134755914305d, y: 0.984798130058831d), radius: 0.8394338433424778d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16218925957978658d, y: 0.380517095860298d), radius: 0.5201424950269785d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6805171839890551d, y: 0.840180211418891d), radius: 0.2901274464425323d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5983565883459743d, y: 0.19828426707367564d), radius: 0.30314194752097035d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2794468675009426d, y: 0.5772657307396748d), radius: 0.09004271462459279d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21202250347348128d, y: 0.1826045235942616d), radius: 0.9481468597695709d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1467857592652423d, y: 0.14605486875401663d), radius: 0.4915217594418527d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4368054945044332d, y: 0.3915353677810942d), radius: 0.5893103522331131d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6448279176319259d, y: 0.40191377653146976d), radius: 0.8545346677794814d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11438144990130183d, y: 0.024332121821442176d), radius: 0.17465287271834773d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4476411070092545d, y: 0.07095167614398612d), radius: 0.23127891060669126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9131501627351629d, y: 0.2844861185853885d), radius: 0.6435112402932849d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6323781811377198d, y: 0.45472939916573785d), radius: 0.6870337925701309d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7280777339923223d, y: 0.6021784840867228d), radius: 0.5018493982390698d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.713971825355588d, y: 0.8854602973258198d), radius: 0.33390543776967474d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6957948063367623d, y: 0.9072180393045536d), radius: 0.917427632782275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6591417176381513d, y: 0.8455173195713375d), radius: 0.21393664724421424d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27493547758372394d, y: 0.9587338773457502d), radius: 0.23192588399285397d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5447945495069408d, y: 0.7714309970113765d), radius: 0.07296154539291477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6954485730578043d, y: 0.2607262334579885d), radius: 0.2462460677839451d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2878590630451736d, y: 0.9022423022964368d), radius: 0.061392062525101765d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9021009345001246d, y: 0.5205795466264455d), radius: 0.22302284715331944d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.584431579157191d, y: 0.5778914125768088d), radius: 0.3763593570348506d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5902853562208604d, y: 0.4935180526424464d), radius: 0.9881504658234201d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10804959114206036d, y: 0.8940149423620243d), radius: 0.23329848963437538d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0918565707895056d, y: 0.9955349041430888d), radius: 0.2592131714746453d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10248613638422466d, y: 0.9639217450398626d), radius: 0.5494388027261133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2676640904074047d, y: 0.23869053492136316d), radius: 0.45673732210239915d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6939178657887d, y: 0.25333238735013264d), radius: 0.27978932950524404d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40754438893706135d, y: 0.9834915700138659d), radius: 0.3962420142261691d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7186205723431174d, y: 0.4597146842011116d), radius: 0.5781562900713842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15774047545952807d, y: 0.11593287680184805d), radius: 0.6057192533885106d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6648268101112834d, y: 0.38139488777171915d), radius: 0.0486048761175244d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3464733549510687d, y: 0.36849035265595764d), radius: 0.00892632477169275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2801008788722391d, y: 0.4063590341978176d), radius: 0.9602642870983773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6232647714872852d, y: 0.6403694048450205d), radius: 0.4532145058018868d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33396416932723083d, y: 0.0546919300721066d), radius: 0.4253909370072352d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19887725350918672d, y: 0.0684692790433622d), radius: 0.933802840533852d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7518437033976657d, y: 0.5271667942669266d), radius: 0.36902679908876646d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9426109222615018d, y: 0.7126273811856317d), radius: 0.2573018079935966d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058225372877381d, y: 0.8565038305444276d), radius: 0.05535283838088534d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4270793337263322d, y: 0.7774202267010518d), radius: 0.5718589926274142d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03377239438594404d, y: 0.23141303163395255d), radius: 0.14930063699670004d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39949374562895223d, y: 0.353283122139628d), radius: 0.8417690572811145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6673540745609428d, y: 0.0884552366035406d), radius: 0.5397012532789506d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8899602295285048d, y: 0.008237331550824845d), radius: 0.44313372515590754d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9027756904492076d, y: 0.1763983866775517d), radius: 0.9213560168949328d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7092341772525828d, y: 0.24006427643943928d), radius: 0.4993114974434657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20131195359616705d, y: 0.7837422902705939d), radius: 0.020339699306256787d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5556792292562929d, y: 0.5444572021050478d), radius: 0.6036470576225701d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5974166859080393d, y: 0.7723491941938455d), radius: 0.7210158114852842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29457145032051d, y: 0.6643509076763682d), radius: 0.5590269499426623d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03175823132874078d, y: 0.12811021909900766d), radius: 0.3086914820383798d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14665191365819075d, y: 0.5401872210450456d), radius: 0.9277157180850142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7832012528067062d, y: 0.18980861296597695d), radius: 0.6992163278508186d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42777430980368414d, y: 0.9021261396354101d), radius: 0.9383333653047528d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05715335079888362d, y: 0.9067648354827083d), radius: 0.2605803608955921d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02662150641549954d, y: 0.26335912593117883d), radius: 0.44626106589989645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.515281496787713d, y: 0.17807126980507104d), radius: 0.7569283348422611d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8497586022514265d, y: 0.5484649336017071d), radius: 0.37404479831960213d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09548624944824913d, y: 0.7073722107528685d), radius: 0.3981331629832281d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8438560015082626d, y: 0.2287174492776296d), radius: 0.7095242298739892d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24536981740868669d, y: 0.2732602032104272d), radius: 0.41744963412933833d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0492907251664616d, y: 0.9353940488784781d), radius: 0.13403223308401657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6380096617286124d, y: 0.9651237592452264d), radius: 0.6416884894523083d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47429072663802707d, y: 0.5780816067631243d), radius: 0.3321071632251833d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09615006855943709d, y: 0.7900376338144979d), radius: 0.038766498662343274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24488621342343786d, y: 0.43085620665645985d), radius: 0.7853659439146976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2555928138351258d, y: 0.9775146730937299d), radius: 0.10940683783656668d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11338376420171292d, y: 0.8541046060414167d), radius: 0.32743629230507965d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.060006241440174524d, y: 0.9964185593770299d), radius: 0.3730014259819301d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1586304005949838d, y: 0.7386833606653311d), radius: 0.4756600740972349d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22199413706617255d, y: 0.535376214727449d), radius: 0.28455166758882755d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5091846751233229d, y: 0.3145747412416774d), radius: 0.8842724180069423d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.820355484800387d, y: 0.5806994111179221d), radius: 0.12578819057043678d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4993095333154558d, y: 0.24116298164061645d), radius: 0.8855110059145797d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3068489501992667d, y: 0.08274242039845725d), radius: 0.06709201691145983d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.763028448967286d, y: 0.3119406023805874d), radius: 0.027149971304978204d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.933570828131756d, y: 0.3241309268504615d), radius: 0.9634940429846433d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8145293405679305d, y: 0.9169547098318701d), radius: 0.05735135259039925d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5974201919737244d, y: 0.44645409773327094d), radius: 0.9077331921030676d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9464624004692215d, y: 0.9344503779041632d), radius: 0.6101160819428545d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3642301893057529d, y: 0.46035523545407064d), radius: 0.7563400589542572d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20639242188740448d, y: 0.3332361397941457d), radius: 0.028899964546569845d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2466425428064376d, y: 0.09268729564836675d), radius: 0.624301891234171d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9129964958849095d, y: 0.7720770679110271d), radius: 0.41848561837385667d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20648834323446397d, y: 0.6334571609834216d), radius: 0.255089713657616d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8871237616898392d, y: 0.29694208474588735d), radius: 0.7930961981525211d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8377712485111023d, y: 0.03444349823413684d), radius: 0.9288859536881714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46898655566234315d, y: 0.0829888703936047d), radius: 0.2227547684821587d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.839234131507063d, y: 0.38361131821976435d), radius: 0.9708614520552921d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.561082138124232d, y: 0.6112111158002197d), radius: 0.20665791317047977d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03192509358461504d, y: 0.6519200513858907d), radius: 0.7109858567704629d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08427357424496407d, y: 0.4656279451426827d), radius: 0.1470394416639128d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.898852903396425d, y: 0.9987468919898428d), radius: 0.12070551732309032d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09282341663085936d, y: 0.21267097134899016d), radius: 0.099425558845192d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4810642243388873d, y: 0.7226667737182816d), radius: 0.6445821144706736d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3202156537476848d, y: 0.17382642433743756d), radius: 0.9578901527096632d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13767447004258526d, y: 0.9007562017549292d), radius: 0.18628799444747857d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9971170845684512d, y: 0.4312588374176034d), radius: 0.3499462999172216d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10237940833507797d, y: 0.3015872176182822d), radius: 0.3254446171975326d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45597455394088915d, y: 0.8711918144208596d), radius: 0.38939250088634725d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6360592860185221d, y: 0.11523131470453607d), radius: 0.1962802779726689d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9827183592028748d, y: 0.44460192175269786d), radius: 0.1829574230534785d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5112083837739069d, y: 0.38440890838475383d), radius: 0.19806486197912854d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3483300238206286d, y: 0.8015068754399782d), radius: 0.3389719167855739d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14956532592155924d, y: 0.861406256406872d), radius: 0.17959973017318953d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25387661346567947d, y: 0.9306748067041632d), radius: 0.42103171566030984d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05814119213799096d, y: 0.060400822631555995d), radius: 0.4686134091271139d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07381972393981528d, y: 0.0003007081454089455d), radius: 0.37111601992515464d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7085387199610901d, y: 0.6152983426189144d), radius: 0.7540567119545792d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31368154587398855d, y: 0.9635578365818632d), radius: 0.03390253771235008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6134399826885142d, y: 0.8815904995962455d), radius: 0.538927280655764d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11576452275648474d, y: 0.9044429032942045d), radius: 0.27621355141773996d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6464344833528508d, y: 0.057532838534260056d), radius: 0.7705684755382678d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5031169908980532d, y: 0.4680306281906137d), radius: 0.9528593007543755d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4219281080615974d, y: 0.7472442745763227d), radius: 0.7234978208874157d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.904260197657002d, y: 0.44364672524632787d), radius: 0.8894713966460713d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24687221047503904d, y: 0.4325848624058425d), radius: 0.7098326583156808d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8063440043377668d, y: 0.9372334704525856d), radius: 0.6069351738363546d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5041572351922202d, y: 0.4945523917629623d), radius: 0.46353741551328587d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12957435546046303d, y: 0.15176737983908062d), radius: 0.5940863514349128d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2343180679173772d, y: 0.2570541984061655d), radius: 0.10639065828390049d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6150299372081086d, y: 0.37816986229667515d), radius: 0.7383503255334053d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7207846863041888d, y: 0.34722827126156375d), radius: 0.6200159455620244d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20849589741140184d, y: 0.0019168628802758159d), radius: 0.1553920029628144d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10139307061287128d, y: 0.651672009140234d), radius: 0.0033805260354391464d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3294516675234701d, y: 0.7915923919419731d), radius: 0.4634385982981294d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07561002878606515d, y: 0.8795318801326298d), radius: 0.5552382715543732d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2253981163647768d, y: 0.13759146287033464d), radius: 0.19075415082259384d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3713711495152271d, y: 0.9651311657069901d), radius: 0.2862686162628564d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23211563237599264d, y: 0.8829417328542074d), radius: 0.061749253575306806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1884837273169686d, y: 0.9293999487074455d), radius: 0.8198087665759448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27616800276235154d, y: 0.1382879375135656d), radius: 0.45034035606423894d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9378413079008567d, y: 0.0322168661761153d), radius: 0.9618645291326997d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7957444906786926d, y: 0.23854047513642151d), radius: 0.897421249839707d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27808882780988653d, y: 0.5127764845711065d), radius: 0.8265167727430575d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32593007161892573d, y: 0.44932210874690937d), radius: 0.8551463699224024d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5820223102218589d, y: 0.7454116983335745d), radius: 0.8335074454256234d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7240881150023607d, y: 0.28580924933009266d), radius: 0.8011779044829527d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6534661661071257d, y: 0.9425781132942062d), radius: 0.07063295414300019d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7581091393001852d, y: 0.8269106278515368d), radius: 0.8247418932568011d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7481734979021173d, y: 0.19329535737066483d), radius: 0.5538270200844714d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6997596489847357d, y: 0.628616613126087d), radius: 0.7736604762553209d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04742479511413933d, y: 0.24750384308945572d), radius: 0.006256770125741107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7299194892936417d, y: 0.5731368587915443d), radius: 0.8614087063900678d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6599678946778489d, y: 0.32528480307869834d), radius: 0.582574740147927d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9040784080999564d, y: 0.5031646858317025d), radius: 0.2562007957212372d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11962613287505386d, y: 0.41100156422809375d), radius: 0.552300269598179d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028563567273875767d, y: 0.4305554409268929d), radius: 0.40407040313853304d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26240378062722514d, y: 0.4610107678264084d), radius: 0.6413261202889589d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8295454419363493d, y: 0.9447021964432297d), radius: 0.5198563009165125d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40985518035405d, y: 0.9861214896819893d), radius: 0.8882129188633281d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29765628631696395d, y: 0.8293208960295174d), radius: 0.8038224335349919d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5769572223228002d, y: 0.35341545064917823d), radius: 0.5476670484592172d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4893160159418546d, y: 0.8192214479441053d), radius: 0.5857594903188854d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026504037331246733d, y: 0.027434173651374794d), radius: 0.7413575426641951d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49353960044373923d, y: 0.6344488656404045d), radius: 0.12145232620751856d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4865811510617417d, y: 0.8691919178712494d), radius: 0.502472955494936d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17177521354115965d, y: 0.4770470801644463d), radius: 0.33221013785317166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7705519351105014d, y: 0.5612110395366711d), radius: 0.23977052600457616d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1272117896609355d, y: 0.33904086190019145d), radius: 0.8277471734166709d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.234249214506827d, y: 0.7986107459278833d), radius: 0.3968326519280828d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7606943634875194d, y: 0.03825652510678257d), radius: 0.8235383144468146d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6378309147341963d, y: 0.49040507891826035d), radius: 0.10161910482342185d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15996779999195532d, y: 0.41680519892312573d), radius: 0.755747043656813d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5057899552279006d, y: 0.8088008538250705d), radius: 0.42677233401541526d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8441203344468257d, y: 0.1843414412180867d), radius: 0.42343008237533386d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.820851713734294d, y: 0.9794324107436688d), radius: 0.9929391506879779d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6650037490728566d, y: 0.718076880021667d), radius: 0.08993011365284409d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5541528114935237d, y: 0.8372547592233079d), radius: 0.43979087699349073d),

},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 124, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 39, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 27, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 145, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 36, query1, 159, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 95, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[34], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 69, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 20, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 14, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[34], false);
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
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 153);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI), typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                await ((INpgsqlCircleListcircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                ((INpgsqlCircleListcircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

