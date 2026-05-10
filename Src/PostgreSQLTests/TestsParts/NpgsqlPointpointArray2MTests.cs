

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9578246094178006d, y: 0.9457084949583915d),

new NpgsqlTypes.NpgsqlPoint(x: 0.01851134551658251d, y: 0.8281933643477827d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24899825358939498d, y: 0.24374245046805076d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10885841304208899d, y: 0.6354160953291754d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9079460875899601d, y: 0.04843085563384131d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9358043637512211d, y: 0.39486341241576095d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7673655273768872d, y: 0.6885164331384762d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3364352360114825d, y: 0.3825866609871026d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4020615375247808d, y: 0.6739325939893713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012102688287140229d, y: 0.3345571786340408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38965431357228975d, y: 0.39487047115493723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8550338689232019d, y: 0.7018149214185516d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6068903351060173d, y: 0.5637651750171968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7854522039385771d, y: 0.6474766512419537d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46074989805214595d, y: 0.8330802070893485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3738823677934533d, y: 0.3533908231826717d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43084750599685073d, y: 0.7001261167713765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11515783293137871d, y: 0.6513452899049d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6749427948790983d, y: 0.895584505919932d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6111284435439732d, y: 0.8402759499516238d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2876466419103787d, y: 0.690186147882247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6681620694155469d, y: 0.49950931973872625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2778944995438981d, y: 0.6978288403664941d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07494514881636083d, y: 0.198657307289274d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9489718571201693d, y: 0.04452805843794061d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5612825316592929d, y: 0.4641157761228093d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6832670753036987d, y: 0.9092804257006147d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3601591582064514d, y: 0.4127687314878121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17413070684352805d, y: 0.24360763056281032d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2384084110413185d, y: 0.8306903533580412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8674217459634747d, y: 0.25962483684481386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10722233630557887d, y: 0.6464271484819238d),

new NpgsqlTypes.NpgsqlPoint(x: 0.050709107169199075d, y: 0.1916324597058564d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4524981132536765d, y: 0.8607895606405068d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9359178594633576d, y: 0.7644164014451797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9416085410880441d, y: 0.01858226889597614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11865660398523037d, y: 0.5074900600992223d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.040850727156191646d, y: 0.735416005887713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3332804894431678d, y: 0.7298092317887273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23595693123202377d, y: 0.6534940968788162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6105213901867238d, y: 0.8327750403432829d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6754345352735895d, y: 0.8595890862342183d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44631814277295523d, y: 0.34573548439485347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2041401446425568d, y: 0.8643126651413994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.694639637061845d, y: 0.7189787634338761d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9003397666706439d, y: 0.9309616848184895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.360030399811617d, y: 0.9951579650929553d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22110699465713657d, y: 0.18101742694468814d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.485745288119385d, y: 0.14794513201559267d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5358839749554658d, y: 0.5763474170348255d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9717256833949885d, y: 0.11345583923314573d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.434577524125604d, y: 0.3991117377962211d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9617041494940052d, y: 0.7203824823809332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21193826967204754d, y: 0.6076208770026527d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8521466470795891d, y: 0.08313035877846975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6596588020407942d, y: 0.625773849189156d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4048973144964093d, y: 0.1206595923705539d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13951511462065447d, y: 0.7429229583561788d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8032434077418216d, y: 0.6667322543577349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3995219919638938d, y: 0.2753912068345946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18678501912551737d, y: 0.26337747210509743d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37376709599100666d, y: 0.7538237917407804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5544857841019618d, y: 0.07836338266330556d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7472038441914167d, y: 0.8760170605448784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.662875425716863d, y: 0.8286725886519145d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16450046135645546d, y: 0.9970072645172555d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41673001774989293d, y: 0.5019456289076403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8887261234111519d, y: 0.7342329039769029d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6828399554147677d, y: 0.6715367913005129d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1305697761245953d, y: 0.7892286343993838d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5841063722706533d, y: 0.06500420146072994d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6765931449175925d, y: 0.40021520919154463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22989507601207215d, y: 0.2582391755756904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8666580488989938d, y: 0.5817496620868065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.659547442509656d, y: 0.29914244035047266d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9298067107917405d, y: 0.36410986361297537d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5159954784221026d, y: 0.19084731014462009d),

new NpgsqlTypes.NpgsqlPoint(x: 0.767311882044552d, y: 0.3706153135442002d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21393442270768903d, y: 0.9885758154320453d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0649810106425176d, y: 0.15562276390369134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9197238600035723d, y: 0.19117288654040188d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7354250570106701d, y: 0.1982002744918624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31464176046551606d, y: 0.9057885359229174d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6836249542724017d, y: 0.14339982787639138d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22184439371793296d, y: 0.3820536476363767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2411320931020473d, y: 0.2729074135272834d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5973511015291748d, y: 0.3316988871582378d),

new NpgsqlTypes.NpgsqlPoint(x: 0.01150432181893457d, y: 0.9971060713635419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.045198915895032776d, y: 0.013586439802417694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05942196856865012d, y: 0.36877459472056295d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4264832021396888d, y: 0.8543773182286729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27839450607437466d, y: 0.028290985918277056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4380383373915294d, y: 0.7778021292208707d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14880002810171933d, y: 0.9235434949702636d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47444569386653923d, y: 0.6637759971288945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013854123661200424d, y: 0.5890237753203827d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5700123524194773d, y: 0.011472208247897742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24353898703231547d, y: 0.4614128437190047d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35219604687618666d, y: 0.13566291570685685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49769261962265054d, y: 0.15047841306359477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7536136596894791d, y: 0.18588367405745487d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5488779403285734d, y: 0.6138516093053984d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43659764875949647d, y: 0.5774332190578724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9104112445656131d, y: 0.1859343257246383d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13899345945731068d, y: 0.7381395219116437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.735735056917788d, y: 0.5924908363221287d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8013181216941083d, y: 0.0413113631244153d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5169791593460217d, y: 0.524308126921556d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23314061212414838d, y: 0.17987053534351916d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5680366005084501d, y: 0.9836818073948317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12272543071553677d, y: 0.5992855511622271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39117188169857475d, y: 0.7612808814483771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3693026725120101d, y: 0.6344670691627866d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9944022476212995d, y: 0.4573070583368921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1806604529047664d, y: 0.9046707964988323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06289711775070383d, y: 0.1725698392508178d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8687287700619746d, y: 0.46077233987261323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6500635739095224d, y: 0.0055866083880103945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5733552393687517d, y: 0.8499299474962086d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5765464620779477d, y: 0.39280814512440987d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07237775351234532d, y: 0.8753727648721149d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04985935345373638d, y: 0.9939879242702798d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12482615056638469d, y: 0.5067315368021456d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.65911190182214d, y: 0.5206830820885769d),

new NpgsqlTypes.NpgsqlPoint(x: 0.006021808709320675d, y: 0.6241585389130444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19201194847212888d, y: 0.1563732038895016d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4340722031920453d, y: 0.031386976865384164d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6519836154877653d, y: 0.5200487390358306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7388339049300836d, y: 0.06339182040921898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06193911819890785d, y: 0.7616667962257845d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39584864851603085d, y: 0.7917037243983709d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49859065341067854d, y: 0.49955472688505975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6310130404166654d, y: 0.4960610465502654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8194669191205199d, y: 0.02361508515788946d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7940590065755586d, y: 0.29770064311454947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4414185871653612d, y: 0.9898202152366494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8896900415532056d, y: 0.16373782806316273d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9705412241588814d, y: 0.8953655266722759d),

new NpgsqlTypes.NpgsqlPoint(x: 0.769568610543287d, y: 0.20111548661143963d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03593907540600394d, y: 0.6456928147770604d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4957695123120782d, y: 0.3311322092896759d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6573209102626765d, y: 0.8742645739277723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12172785992239432d, y: 0.744716261678893d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8172867170748228d, y: 0.10398229319037522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.037200522977394956d, y: 0.10407080764070042d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10086595500679518d, y: 0.9943608343942933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4280264699005397d, y: 0.9739602047548859d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13966905608155133d, y: 0.9039430048660908d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5529478189855431d, y: 0.9024836484042543d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9326596454739617d, y: 0.3528772079944963d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18551266695921254d, y: 0.025918087567770254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08234476992024431d, y: 0.8357119407082549d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6669635665975117d, y: 0.377726917425396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14142121548595243d, y: 0.409280484942547d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23560276305654215d, y: 0.3511727551177293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5265226926253956d, y: 0.04517536206766992d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5101481352742527d, y: 0.47743188171728534d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07778890560012353d, y: 0.9846307945190369d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2812275451370976d, y: 0.9753294912316637d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9447659651902742d, y: 0.3358168945195307d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45960769349595276d, y: 0.7547198905339828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5639778886972991d, y: 0.10786115063300139d),

new NpgsqlTypes.NpgsqlPoint(x: 0.535575824514883d, y: 0.3673817725977483d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0022066729412786312d, y: 0.4443022140023414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7214209190295312d, y: 0.5416313326346628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9139491669335935d, y: 0.5598233833371172d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3187527636709926d, y: 0.8515642461989068d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46724188971267444d, y: 0.3660387349508565d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2917296127755069d, y: 0.46405281549888067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35024906761383323d, y: 0.8740323854255307d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24574111433301904d, y: 0.7990829101199252d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07041684224892164d, y: 0.9911654790649497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6556887522880671d, y: 0.6094954928002583d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6651005466910956d, y: 0.12659979910984231d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9181290377036649d, y: 0.6425317519825959d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6683081391763593d, y: 0.40691513083751896d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6229341064945939d, y: 0.8270996274376259d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4288678131988456d, y: 0.91023375805887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9271706200029927d, y: 0.17214638596149745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3121666521685632d, y: 0.6513820716598301d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7975721162811937d, y: 0.932983953054332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9638009164359984d, y: 0.8955635741161692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4326344435924d, y: 0.8474750400953631d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35585546024518844d, y: 0.3878207868631195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5360846002524565d, y: 0.8570533887268734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6158809073463539d, y: 0.719346694998052d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6238619927779091d, y: 0.464416920505075d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7102986773385885d, y: 0.6241564432252809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6847886993357503d, y: 0.5752318137809769d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4459041902043904d, y: 0.04058020603921619d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49165156783985564d, y: 0.4447392725698086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49356220810248375d, y: 0.1811950773101626d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7875567896766676d, y: 0.7860085710460836d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8589902965483289d, y: 0.6399284157590182d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11944925726327416d, y: 0.3020301757721827d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6130140872630918d, y: 0.07538512133742559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5612352843824299d, y: 0.3542650598624252d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12465677067102399d, y: 0.6344601690347959d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43297864645412976d, y: 0.31861308285112067d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3839198774604289d, y: 0.28820536065740676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6986541640972008d, y: 0.4052333136366192d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30022165070705054d, y: 0.43627905473042583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03379473622242424d, y: 0.48057523581757067d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45017005880861016d, y: 0.46940115869166776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.008570875069048522d, y: 0.2285074637754445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5124599127137257d, y: 0.31377848018664756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6142498100562221d, y: 0.24251968064859897d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.544150751525345d, y: 0.4912486910469508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6975776430411078d, y: 0.9997229072878425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.011184129907618301d, y: 0.06377413656205333d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09615034726471572d, y: 0.6430675584780007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6662521347397896d, y: 0.9735359855131265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40026273534906054d, y: 0.7828682482087617d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33647400229561575d, y: 0.21362296072298992d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21420487206377692d, y: 0.5098661392581402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2629709767634508d, y: 0.42697885403040736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45082779332785783d, y: 0.36229154120282236d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9156865821452512d, y: 0.8655011335177859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8712753837106818d, y: 0.9785119648253887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9913442456662811d, y: 0.7448551600653811d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16193396282042838d, y: 0.5448759694220866d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9017235480295639d, y: 0.7665408823323933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12278283199925233d, y: 0.5533927301818188d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20289865670665796d, y: 0.5055508594600826d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8368027403459364d, y: 0.6789841902117721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1357929697436322d, y: 0.8597278267934811d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5539192158663916d, y: 0.5057678275644715d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42174777990310564d, y: 0.26365558631460606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09205902923608522d, y: 0.43073387234877614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3693881454178637d, y: 0.30348819039044317d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3109447440667491d, y: 0.7070964952056455d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8111179617985472d, y: 0.09378782460311674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5092041809307023d, y: 0.13467396707023516d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7234246847030358d, y: 0.8087594658750175d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16826395665337024d, y: 0.39435333771430736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6447926593389711d, y: 0.632334822970482d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31154757880151607d, y: 0.1277415056229254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9511486599912278d, y: 0.3367998389889745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8150034686713389d, y: 0.23503253919972344d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6665115756891864d, y: 0.9124143851031653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11047462166071431d, y: 0.3567181822976565d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3852332346507137d, y: 0.6623097049828269d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11954067515006994d, y: 0.3045201370909425d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9361110156089357d, y: 0.9496112396721267d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9185775778414162d, y: 0.042475257784034604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.768035333837697d, y: 0.3373636790653073d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8046132482650022d, y: 0.1031079555169685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1245696876486575d, y: 0.9716646592182878d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6615667659946278d, y: 0.827423127871547d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1338952506891713d, y: 0.9363407982218221d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.922577121688169d, y: 0.3011997244541672d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9484894041112402d, y: 0.6603972538648264d),

new NpgsqlTypes.NpgsqlPoint(x: 0.140993242016068d, y: 0.6794732286939851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2803778823991484d, y: 0.7095461410469036d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5795909998400902d, y: 0.7747658961892956d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05980840619175787d, y: 0.13928665171659182d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6157209524943561d, y: 0.8148257485067134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8214356318337136d, y: 0.9543940885929735d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
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
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 150, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 108, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 76, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 66, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 150, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 58, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

