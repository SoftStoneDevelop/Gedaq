

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
    internal partial interface INpgsqlBoxListboxListD1
    {
    }
    
    internal partial class NpgsqlBoxListboxListD1 : INpgsqlBoxListboxListD1
    {


#region TestData

        private readonly NpgsqlBoxboxListD1E2M[] _testData = new NpgsqlBoxboxListD1E2M[]
        {
            new NpgsqlBoxboxListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6974063567087617d,right: 0.6179815339965321d,bottom: 0.472165337542109d,left: 0.2598909914981433d),

new NpgsqlTypes.NpgsqlBox(top: 0.8946149667961987d,right: 0.5316420257365772d,bottom: 0.5080202444511321d,left: 0.2092960202005436d),

new NpgsqlTypes.NpgsqlBox(top: 0.8659129719587766d,right: 0.6058207266249791d,bottom: 0.3093980487554203d,left: 0.44468154104040236d),

new NpgsqlTypes.NpgsqlBox(top: 0.6377065501394489d,right: 0.8014208507462058d,bottom: 0.19839075289216057d,left: 0.44660624569278895d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8065663176953575d,right: 0.8612648741864148d,bottom: 0.7976142525276092d,left: 0.24831031057837105d),

new NpgsqlTypes.NpgsqlBox(top: 0.8756080050475745d,right: 0.95103993712156d,bottom: 0.6475393885259144d,left: 0.296030928612968d),

new NpgsqlTypes.NpgsqlBox(top: 0.6386953998504068d,right: 0.7436445222452756d,bottom: 0.31020937928869885d,left: 0.5236999405731297d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7927121315401744d,right: 0.918930615755812d,bottom: 0.7625862831783976d,left: 0.6794165994088167d),

new NpgsqlTypes.NpgsqlBox(top: 0.5844960806737841d,right: 0.9787590087603669d,bottom: 0.35460126627592925d,left: 0.7330374883057776d),

new NpgsqlTypes.NpgsqlBox(top: 0.6690720937088886d,right: 0.8378505336639729d,bottom: 0.3288768693743177d,left: 0.3380986260813309d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9549908344082954d,right: 0.9073436510083197d,bottom: 0.9086108146096247d,left: 0.7391125807676604d),

new NpgsqlTypes.NpgsqlBox(top: 0.909772967922922d,right: 0.7972999425270684d,bottom: 0.15892565120840274d,left: 0.31249705363388325d),

new NpgsqlTypes.NpgsqlBox(top: 0.9764867355543384d,right: 0.8269268546639791d,bottom: 0.652022250660735d,left: 0.02083621119765966d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.768051217007178d,right: 0.38334046634769114d,bottom: 0.010065401074565994d,left: 0.06282540705424111d),

new NpgsqlTypes.NpgsqlBox(top: 0.8814322362453553d,right: 0.7991589101598823d,bottom: 0.3410926402217561d,left: 0.3270341783195607d),

new NpgsqlTypes.NpgsqlBox(top: 0.7951273995169d,right: 0.9566964355433519d,bottom: 0.7212625817549706d,left: 0.5404211885621163d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6370952869741133d,right: 0.9127638299017375d,bottom: 0.13117037237274598d,left: 0.527351796027545d),

new NpgsqlTypes.NpgsqlBox(top: 0.8845887288764719d,right: 0.8656136711702709d,bottom: 0.6349618425669518d,left: 0.4511502873124973d),

new NpgsqlTypes.NpgsqlBox(top: 0.8453687217932405d,right: 0.8706019583375401d,bottom: 0.05344691279334346d,left: 0.5430189360771713d),

new NpgsqlTypes.NpgsqlBox(top: 0.957382935989194d,right: 0.8484615937027606d,bottom: 0.01575865481252936d,left: 0.5625610074373528d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9504692638729103d,right: 0.5089558365216597d,bottom: 0.19524768874478726d,left: 0.218144082007261d),

new NpgsqlTypes.NpgsqlBox(top: 0.5076164300404641d,right: 0.8206480580820679d,bottom: 0.262396268286997d,left: 0.5235918754320551d),

new NpgsqlTypes.NpgsqlBox(top: 0.6442598206334819d,right: 0.9325945853278391d,bottom: 0.4403023836495593d,left: 0.5736149719628613d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5337262947272957d,right: 0.4987264771166685d,bottom: 0.36372980919845355d,left: 0.21794765673865557d),

new NpgsqlTypes.NpgsqlBox(top: 0.7249563117989395d,right: 0.8383828882404759d,bottom: 0.6580608817965293d,left: 0.28318744987664946d),

new NpgsqlTypes.NpgsqlBox(top: 0.3998706224333102d,right: 0.9003189226355014d,bottom: 0.12903157598343085d,left: 0.16416676172182088d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7804397371925813d,right: 0.7177428971953749d,bottom: 0.6633995351807678d,left: 0.05363021365138565d),

new NpgsqlTypes.NpgsqlBox(top: 0.940236095502713d,right: 0.35919237271111737d,bottom: 0.9068640053828679d,left: 0.08251052074000076d),

new NpgsqlTypes.NpgsqlBox(top: 0.5026738122923271d,right: 0.8119089819493979d,bottom: 0.080396764848634d,left: 0.49770966660106986d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7813161892414227d,right: 0.8982832849721595d,bottom: 0.6484189115695761d,left: 0.5539519124838131d),

new NpgsqlTypes.NpgsqlBox(top: 0.8503042403854886d,right: 0.4729749977972447d,bottom: 0.8472989216520704d,left: 0.43662520239108094d),

new NpgsqlTypes.NpgsqlBox(top: 0.6792970332572796d,right: 0.8237897542381054d,bottom: 0.38483189442443655d,left: 0.5728532201954266d),

new NpgsqlTypes.NpgsqlBox(top: 0.9807296702273576d,right: 0.8152347481384477d,bottom: 0.29789858257674473d,left: 0.42481952012024593d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.0913464599696927d,right: 0.7506611281887213d,bottom: 0.07448772179074559d,left: 0.580709402089044d),

new NpgsqlTypes.NpgsqlBox(top: 0.5418422209486355d,right: 0.5609959528129846d,bottom: 0.15665943367049595d,left: 0.3793765344071197d),

new NpgsqlTypes.NpgsqlBox(top: 0.8421854893520486d,right: 0.5881501256726344d,bottom: 0.7698003748717943d,left: 0.28192468814170035d),

new NpgsqlTypes.NpgsqlBox(top: 0.9493934228609902d,right: 0.48329004353497995d,bottom: 0.5961767858748149d,left: 0.13892229871823925d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5442544153885741d,right: 0.9164476479386103d,bottom: 0.501496981172382d,left: 0.7526737045850943d),

new NpgsqlTypes.NpgsqlBox(top: 0.6440166107999714d,right: 0.7447536064569494d,bottom: 0.6420074766322102d,left: 0.24533443862961002d),

new NpgsqlTypes.NpgsqlBox(top: 0.3594916232755402d,right: 0.994816119831605d,bottom: 0.0595374858346841d,left: 0.3386811181292254d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37159264493713584d,right: 0.9442686595929735d,bottom: 0.3177359289496532d,left: 0.16842520599740196d),

new NpgsqlTypes.NpgsqlBox(top: 0.4700007585047772d,right: 0.610801588016662d,bottom: 0.4058174670275264d,left: 0.08437335538714363d),

new NpgsqlTypes.NpgsqlBox(top: 0.9621587679254492d,right: 0.27769082363743924d,bottom: 0.48361924474762796d,left: 0.12936045742458546d),

new NpgsqlTypes.NpgsqlBox(top: 0.7915065945278213d,right: 0.6568276701603419d,bottom: 0.6776162689979227d,left: 0.5594559559317597d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5674924828419811d,right: 0.17690917673009388d,bottom: 0.03686077468450455d,left: 0.033407747590364245d),

new NpgsqlTypes.NpgsqlBox(top: 0.3131192937532241d,right: 0.5571738168941395d,bottom: 0.18661439174063443d,left: 0.41195170980093787d),

new NpgsqlTypes.NpgsqlBox(top: 0.6554244807943287d,right: 0.9506294720508361d,bottom: 0.5954348577076356d,left: 0.24846424326664096d),

new NpgsqlTypes.NpgsqlBox(top: 0.7878830029838457d,right: 0.9050908394703476d,bottom: 0.15141416157732224d,left: 0.740665552867988d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7322932045918247d,right: 0.7589599199967432d,bottom: 0.4414199333468345d,left: 0.07082999070143092d),

new NpgsqlTypes.NpgsqlBox(top: 0.7526704175033428d,right: 0.8309555021239035d,bottom: 0.24948439065644656d,left: 0.7915576648417538d),

new NpgsqlTypes.NpgsqlBox(top: 0.7139030954507518d,right: 0.2408244910482028d,bottom: 0.32924507609528175d,left: 0.2349436166992972d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3524271404465015d,right: 0.9280454168612864d,bottom: 0.18232918205142035d,left: 0.49864386482696366d),

new NpgsqlTypes.NpgsqlBox(top: 0.320682164863311d,right: 0.594519330791584d,bottom: 0.08103672449466826d,left: 0.3115595644662841d),

new NpgsqlTypes.NpgsqlBox(top: 0.6738528992179716d,right: 0.7186444235358126d,bottom: 0.3575772938196219d,left: 0.17865492075520373d),

new NpgsqlTypes.NpgsqlBox(top: 0.6841884181553034d,right: 0.7203009392021007d,bottom: 0.38059145570192887d,left: 0.6446890526967896d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9296102417752224d,right: 0.6901333160903516d,bottom: 0.09020716781904126d,left: 0.23920981161320432d),

new NpgsqlTypes.NpgsqlBox(top: 0.6105003721835363d,right: 0.982572375070799d,bottom: 0.10358513033447225d,left: 0.7389145336447621d),

new NpgsqlTypes.NpgsqlBox(top: 0.8698845427344815d,right: 0.9939610059424028d,bottom: 0.7340689649901503d,left: 0.6976307085076772d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5799030504233228d,right: 0.562727840158197d,bottom: 0.23238612507872214d,left: 0.266242643100676d),

new NpgsqlTypes.NpgsqlBox(top: 0.9841924112111986d,right: 0.9377456738208417d,bottom: 0.21656281751310125d,left: 0.027350954957982787d),

new NpgsqlTypes.NpgsqlBox(top: 0.9480504155090682d,right: 0.8833095282489567d,bottom: 0.89389338175411d,left: 0.3851335044892469d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9176779175423224d,right: 0.9588335077898846d,bottom: 0.05968761598154837d,left: 0.38599726434613035d),

new NpgsqlTypes.NpgsqlBox(top: 0.6948032968007186d,right: 0.7443532961087888d,bottom: 0.31774453316035534d,left: 0.09299995676382122d),

new NpgsqlTypes.NpgsqlBox(top: 0.3011980138728143d,right: 0.8376438300587684d,bottom: 0.046909550151550405d,left: 0.5449385646163478d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8760358399464981d,right: 0.6546133614980034d,bottom: 0.14086140896523758d,left: 0.5404818245433058d),

new NpgsqlTypes.NpgsqlBox(top: 0.9430851629044973d,right: 0.7876564766783873d,bottom: 0.2304449633138277d,left: 0.6784367867460215d),

new NpgsqlTypes.NpgsqlBox(top: 0.8086231089691277d,right: 0.9915523660444611d,bottom: 0.29024064379594894d,left: 0.326520511072373d),

new NpgsqlTypes.NpgsqlBox(top: 0.612137502975828d,right: 0.8508521388003958d,bottom: 0.11581677229966825d,left: 0.8126115622662291d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.734264924480853d,right: 0.29255407308975045d,bottom: 0.1090016382365141d,left: 0.07402613146411541d),

new NpgsqlTypes.NpgsqlBox(top: 0.7322162151385091d,right: 0.612073809988208d,bottom: 0.5277756251130525d,left: 0.3898838048292811d),

new NpgsqlTypes.NpgsqlBox(top: 0.8652639027402667d,right: 0.8977199345815844d,bottom: 0.03183274389902546d,left: 0.7139190872486659d),

new NpgsqlTypes.NpgsqlBox(top: 0.7724814775480193d,right: 0.6883748314020329d,bottom: 0.20290763292238145d,left: 0.49131314433566875d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9306159426063433d,right: 0.9238072854456585d,bottom: 0.021911207490939444d,left: 0.7615341384083089d),

new NpgsqlTypes.NpgsqlBox(top: 0.913815720233005d,right: 0.2938116141811d,bottom: 0.7783185268065452d,left: 0.14095720860145367d),

new NpgsqlTypes.NpgsqlBox(top: 0.964697944848694d,right: 0.8807154060362151d,bottom: 0.464244070106019d,left: 0.8317682754075647d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8398816329793791d,right: 0.9774798394735827d,bottom: 0.17237909507296323d,left: 0.6709816714786045d),

new NpgsqlTypes.NpgsqlBox(top: 0.6800353765584565d,right: 0.8873028523643542d,bottom: 0.6538878524191647d,left: 0.4528895322575204d),

new NpgsqlTypes.NpgsqlBox(top: 0.44269134283063993d,right: 0.24361161338455528d,bottom: 0.10461299255025969d,left: 0.08945905166846013d),

new NpgsqlTypes.NpgsqlBox(top: 0.9607953163890677d,right: 0.7973906951043909d,bottom: 0.49130175589717573d,left: 0.5728500082684076d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6146962115855616d,right: 0.4764902473872791d,bottom: 0.3318072225677351d,left: 0.0257964732479109d),

new NpgsqlTypes.NpgsqlBox(top: 0.6200524515263637d,right: 0.5956913858634876d,bottom: 0.5590143181142647d,left: 0.19437290476778413d),

new NpgsqlTypes.NpgsqlBox(top: 0.7374026040519522d,right: 0.38577166749205394d,bottom: 0.33112106733512536d,left: 0.22925359372631227d),

new NpgsqlTypes.NpgsqlBox(top: 0.9592159838770666d,right: 0.7383327763683165d,bottom: 0.18467957719323425d,left: 0.58207806394043d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7282105952058775d,right: 0.6580948613283889d,bottom: 0.10797743314393371d,left: 0.49807688699058783d),

new NpgsqlTypes.NpgsqlBox(top: 0.4729698314526649d,right: 0.8619023026171074d,bottom: 0.037342480740856554d,left: 0.5059008024488542d),

new NpgsqlTypes.NpgsqlBox(top: 0.8350161947501857d,right: 0.23549009362237006d,bottom: 0.05323394793350711d,left: 0.06319310538706224d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9843135989339677d,right: 0.6539014535524242d,bottom: 0.06763740677204477d,left: 0.10494990718993547d),

new NpgsqlTypes.NpgsqlBox(top: 0.8711777916988109d,right: 0.8810076547246597d,bottom: 0.6642204956363854d,left: 0.11536685895364174d),

new NpgsqlTypes.NpgsqlBox(top: 0.7575213122503826d,right: 0.8073073047492527d,bottom: 0.39774413436653466d,left: 0.17959334792166515d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.966812073613218d,right: 0.28668956383602895d,bottom: 0.9589046169759583d,left: 0.07220815528621172d),

new NpgsqlTypes.NpgsqlBox(top: 0.8621295259056672d,right: 0.2981049667970016d,bottom: 0.3670412413207711d,left: 0.07860962015811712d),

new NpgsqlTypes.NpgsqlBox(top: 0.8403399079004108d,right: 0.30044663314394526d,bottom: 0.8133661281580773d,left: 0.21810052622492504d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6885798890853516d,right: 0.7423859279209784d,bottom: 0.031248650288257962d,left: 0.4897691202775284d),

new NpgsqlTypes.NpgsqlBox(top: 0.5221464066259862d,right: 0.9609835190436342d,bottom: 0.4965232786577346d,left: 0.24518419991574425d),

new NpgsqlTypes.NpgsqlBox(top: 0.9609603718282027d,right: 0.9714678843923586d,bottom: 0.2530389790230628d,left: 0.4311100463004236d),

new NpgsqlTypes.NpgsqlBox(top: 0.7951200645288687d,right: 0.546388059757084d,bottom: 0.3460733855423076d,left: 0.4617094268137095d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5739095409862819d,right: 0.9025059277141939d,bottom: 0.43502950489854664d,left: 0.7606525155412022d),

new NpgsqlTypes.NpgsqlBox(top: 0.761246009507793d,right: 0.9958123043018673d,bottom: 0.4120750776029186d,left: 0.7910835159013526d),

new NpgsqlTypes.NpgsqlBox(top: 0.68111240491009d,right: 0.9201167145547259d,bottom: 0.6292893256261678d,left: 0.5690601524513197d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.343727591333182d,right: 0.9089701031758394d,bottom: 0.2641694411118227d,left: 0.9038103920629769d),

new NpgsqlTypes.NpgsqlBox(top: 0.5659700817787525d,right: 0.2954251879723795d,bottom: 0.024433995039104595d,left: 0.1922194410569701d),

new NpgsqlTypes.NpgsqlBox(top: 0.6927000846146949d,right: 0.07502327119251717d,bottom: 0.6588584943876117d,left: 0.053746793920312674d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8429145665418507d,right: 0.8088432565793107d,bottom: 0.12862988796385522d,left: 0.4738367635830576d),

new NpgsqlTypes.NpgsqlBox(top: 0.4942085509570744d,right: 0.6685625160424884d,bottom: 0.06380386540777849d,left: 0.20417851367511597d),

new NpgsqlTypes.NpgsqlBox(top: 0.6991273218836391d,right: 0.889652801877065d,bottom: 0.698363898144401d,left: 0.7590963435407388d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9393426206595106d,right: 0.34610367094816197d,bottom: 0.17845707143274125d,left: 0.07364046688907155d),

new NpgsqlTypes.NpgsqlBox(top: 0.7098940951577952d,right: 0.679877948241816d,bottom: 0.12645685626906145d,left: 0.1299293171119963d),

new NpgsqlTypes.NpgsqlBox(top: 0.9599401173672905d,right: 0.8449311750938097d,bottom: 0.09750592160073346d,left: 0.7285888820904978d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.21019257830389693d,right: 0.8805091884861952d,bottom: 0.16028504417371758d,left: 0.2927054111895976d),

new NpgsqlTypes.NpgsqlBox(top: 0.945903277463723d,right: 0.9458331604962235d,bottom: 0.6725975022676534d,left: 0.21545148034807082d),

new NpgsqlTypes.NpgsqlBox(top: 0.7542345758932455d,right: 0.8401228704419297d,bottom: 0.28527956812520083d,left: 0.5433054275588423d),

new NpgsqlTypes.NpgsqlBox(top: 0.4867186924892374d,right: 0.8778458150785108d,bottom: 0.20620077297053996d,left: 0.33390440979966185d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5885052925543337d,right: 0.8324134220447268d,bottom: 0.15879404424412036d,left: 0.6881158046515747d),

new NpgsqlTypes.NpgsqlBox(top: 0.7439770620299107d,right: 0.7610554285938866d,bottom: 0.6935558675861958d,left: 0.45589782558623126d),

new NpgsqlTypes.NpgsqlBox(top: 0.3506087804425271d,right: 0.5378024324031252d,bottom: 0.25662229349207866d,left: 0.04009230003135189d),

new NpgsqlTypes.NpgsqlBox(top: 0.32114659330053674d,right: 0.5876608340321142d,bottom: 0.11051906659625244d,left: 0.5867860522207351d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5206027441036463d,right: 0.6762253465317376d,bottom: 0.09341967652663441d,left: 0.2187600165873671d),

new NpgsqlTypes.NpgsqlBox(top: 0.8365767615349837d,right: 0.5110584590436145d,bottom: 0.304946992268345d,left: 0.16635378408349244d),

new NpgsqlTypes.NpgsqlBox(top: 0.6120843271570168d,right: 0.23913999414126152d,bottom: 0.5886202089597575d,left: 0.1647421985521238d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9532641402991384d,right: 0.9818120287126746d,bottom: 0.46087787898971067d,left: 0.5088055742344928d),

new NpgsqlTypes.NpgsqlBox(top: 0.9142330977360262d,right: 0.8314514821738467d,bottom: 0.05747035525843314d,left: 0.6181131729651537d),

new NpgsqlTypes.NpgsqlBox(top: 0.33796992347554144d,right: 0.6738412964028746d,bottom: 0.09893944713649516d,left: 0.31729562126761324d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6579401614525007d,right: 0.43729115397038043d,bottom: 0.10224289737189907d,left: 0.20276925447541994d),

new NpgsqlTypes.NpgsqlBox(top: 0.9586659189664382d,right: 0.6458753772494139d,bottom: 0.32473898644630406d,left: 0.357080421556064d),

new NpgsqlTypes.NpgsqlBox(top: 0.6810452493503738d,right: 0.9633936379317009d,bottom: 0.5320155865584303d,left: 0.7835848880325148d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7936440191367413d,right: 0.9747478645992114d,bottom: 0.7080668143963357d,left: 0.3122346476865345d),

new NpgsqlTypes.NpgsqlBox(top: 0.39532135866818097d,right: 0.8113440471040018d,bottom: 0.014693311230049022d,left: 0.7822091131139285d),

new NpgsqlTypes.NpgsqlBox(top: 0.14077821011488956d,right: 0.6131814600190924d,bottom: 0.07930203383027534d,left: 0.2539166567418205d),

new NpgsqlTypes.NpgsqlBox(top: 0.5683747668005794d,right: 0.6359452941281648d,bottom: 0.16525184941801185d,left: 0.5814593088161247d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49472835789053027d,right: 0.8381415660075222d,bottom: 0.24481974450768984d,left: 0.5642708947883923d),

new NpgsqlTypes.NpgsqlBox(top: 0.5327586972230333d,right: 0.6837196570778244d,bottom: 0.42797439617875843d,left: 0.6822966230317211d),

new NpgsqlTypes.NpgsqlBox(top: 0.9697933381658141d,right: 0.6870352828133508d,bottom: 0.08410530355420198d,left: 0.45768965164821285d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5241479932377207d,right: 0.22792566941429937d,bottom: 0.035771449019922574d,left: 0.2230331532842088d),

new NpgsqlTypes.NpgsqlBox(top: 0.052246593721967494d,right: 0.9473415574179855d,bottom: 0.005212535242800964d,left: 0.9320538508040298d),

new NpgsqlTypes.NpgsqlBox(top: 0.7533207547171648d,right: 0.5835743585046654d,bottom: 0.7349204512185216d,left: 0.26847301563259174d),

new NpgsqlTypes.NpgsqlBox(top: 0.5782926163700061d,right: 0.03727789294416339d,bottom: 0.3492332301997172d,left: 0.003393718157508996d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.772347366420775d,right: 0.955634118284886d,bottom: 0.4046326177368862d,left: 0.09924991433018726d),

new NpgsqlTypes.NpgsqlBox(top: 0.5183718669069374d,right: 0.589728429697712d,bottom: 0.44071773142460546d,left: 0.11535593955885903d),

new NpgsqlTypes.NpgsqlBox(top: 0.7546207870679623d,right: 0.6330753515187246d,bottom: 0.06329413527946703d,left: 0.6150853214276925d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.24130378483326365d,right: 0.865423770408928d,bottom: 0.214920411953737d,left: 0.30550498301830387d),

new NpgsqlTypes.NpgsqlBox(top: 0.5084339211926203d,right: 0.8330142653506809d,bottom: 0.14758312172806487d,left: 0.12011260849237781d),

new NpgsqlTypes.NpgsqlBox(top: 0.9315772638059625d,right: 0.9579914017056469d,bottom: 0.5374892631890543d,left: 0.9510431351754907d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9007968687614755d,right: 0.6528753489904544d,bottom: 0.5074199453805581d,left: 0.039301925877387234d),

new NpgsqlTypes.NpgsqlBox(top: 0.2366239956409345d,right: 0.8490319698224656d,bottom: 0.05344864721612452d,left: 0.08160499098875595d),

new NpgsqlTypes.NpgsqlBox(top: 0.45858220110010084d,right: 0.7515810410465645d,bottom: 0.16671958688523847d,left: 0.01964864044485204d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7797530024412325d,right: 0.5656443184502109d,bottom: 0.31017010352674335d,left: 0.3052232476589034d),

new NpgsqlTypes.NpgsqlBox(top: 0.698051956614632d,right: 0.8347775149216418d,bottom: 0.28118451485205487d,left: 0.2524779152489135d),

new NpgsqlTypes.NpgsqlBox(top: 0.9742139369550739d,right: 0.5728693439871622d,bottom: 0.26213466292381304d,left: 0.10125976167573825d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.25639763387398673d,right: 0.2882659653397823d,bottom: 0.08994675082112646d,left: 0.10438402613809061d),

new NpgsqlTypes.NpgsqlBox(top: 0.8742062676127003d,right: 0.37574592853567745d,bottom: 0.0780462960436975d,left: 0.36103043826243264d),

new NpgsqlTypes.NpgsqlBox(top: 0.7346161655180595d,right: 0.9453654672157373d,bottom: 0.07333854751212876d,left: 0.5464406018706828d),

new NpgsqlTypes.NpgsqlBox(top: 0.7267126542628746d,right: 0.6611061044404826d,bottom: 0.45025779005126343d,left: 0.09053327080400853d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.08703636309058305d,right: 0.6773063327804548d,bottom: 0.06422866691372742d,left: 0.47955518613200976d),

new NpgsqlTypes.NpgsqlBox(top: 0.9675823414622147d,right: 0.8897177447631752d,bottom: 0.8489002267307182d,left: 0.7017150381008688d),

new NpgsqlTypes.NpgsqlBox(top: 0.963362290132718d,right: 0.38277672796418416d,bottom: 0.5678596754102767d,left: 0.005761890416633109d),

new NpgsqlTypes.NpgsqlBox(top: 0.9578033678158836d,right: 0.9408245057844901d,bottom: 0.576547510237443d,left: 0.9147347625170138d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8250149574200776d,right: 0.2858291802342523d,bottom: 0.5234836897637711d,left: 0.27664972349479455d),

new NpgsqlTypes.NpgsqlBox(top: 0.7535048822544921d,right: 0.6887375785442729d,bottom: 0.0005497392934502576d,left: 0.28190397782440724d),

new NpgsqlTypes.NpgsqlBox(top: 0.4698566361333968d,right: 0.8474815711967415d,bottom: 0.06697457940761198d,left: 0.45369621251818726d),

new NpgsqlTypes.NpgsqlBox(top: 0.17200927645461783d,right: 0.769415589858576d,bottom: 0.030380607222395883d,left: 0.3947054161924545d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42115284631402383d,right: 0.13374090274884443d,bottom: 0.021937531542049582d,left: 0.05382089862461048d),

new NpgsqlTypes.NpgsqlBox(top: 0.8391673670599287d,right: 0.8512226986858072d,bottom: 0.6837670721687662d,left: 0.8416281626963332d),

new NpgsqlTypes.NpgsqlBox(top: 0.9510285730760003d,right: 0.4453124029624562d,bottom: 0.259842767440839d,left: 0.3897500125155652d),

new NpgsqlTypes.NpgsqlBox(top: 0.35320768841949d,right: 0.9652980166362528d,bottom: 0.3218599686876198d,left: 0.649002837431899d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8835520240215488d,right: 0.3516148971610067d,bottom: 0.6360268355733409d,left: 0.32588149468406646d),

new NpgsqlTypes.NpgsqlBox(top: 0.862537683972408d,right: 0.9426886687353103d,bottom: 0.33797687811935917d,left: 0.6106573744893191d),

new NpgsqlTypes.NpgsqlBox(top: 0.7528073696514607d,right: 0.9767943283009047d,bottom: 0.007147843853774871d,left: 0.8681446691980552d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9462661247461912d,right: 0.7321890752359772d,bottom: 0.8612117091275341d,left: 0.0799536865783691d),

new NpgsqlTypes.NpgsqlBox(top: 0.16166760933545365d,right: 0.6877869430641679d,bottom: 0.11139072082978496d,left: 0.49715270286111446d),

new NpgsqlTypes.NpgsqlBox(top: 0.6877287994941303d,right: 0.7474388090016885d,bottom: 0.15276674827960868d,left: 0.07046479972210362d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.15144180641061977d,right: 0.6156570531227747d,bottom: 0.061862899213850575d,left: 0.16413748172877718d),

new NpgsqlTypes.NpgsqlBox(top: 0.5223470828630151d,right: 0.5950265000344033d,bottom: 0.06380172168486187d,left: 0.32320944694971354d),

new NpgsqlTypes.NpgsqlBox(top: 0.3545344836345655d,right: 0.7930916099607419d,bottom: 0.060797249053221036d,left: 0.7812237088109565d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9367506530832811d,right: 0.7731459728332918d,bottom: 0.5303825685319415d,left: 0.7551261720270239d),

new NpgsqlTypes.NpgsqlBox(top: 0.10323855224048173d,right: 0.8920606733191507d,bottom: 0.03410768989483981d,left: 0.2698980185028349d),

new NpgsqlTypes.NpgsqlBox(top: 0.6782242477590944d,right: 0.5830779323756425d,bottom: 0.23774711729056996d,left: 0.44714678840472577d),

new NpgsqlTypes.NpgsqlBox(top: 0.3492410819348658d,right: 0.9728144070760196d,bottom: 0.05682617073152363d,left: 0.9010884686045559d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.19762745081138922d,right: 0.8225192181651692d,bottom: 0.10030048357006338d,left: 0.6254217755241762d),

new NpgsqlTypes.NpgsqlBox(top: 0.19211123570112532d,right: 0.8976171338855752d,bottom: 0.09647982869654392d,left: 0.045928856221631786d),

new NpgsqlTypes.NpgsqlBox(top: 0.8711253084611554d,right: 0.5423432931414492d,bottom: 0.7723710273657606d,left: 0.21007156721318165d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8416669273126989d,right: 0.7602830068575723d,bottom: 0.6382982173939673d,left: 0.14378106485512743d),

new NpgsqlTypes.NpgsqlBox(top: 0.47594952809262725d,right: 0.32597828775860904d,bottom: 0.359381599570343d,left: 0.2090065676260663d),

new NpgsqlTypes.NpgsqlBox(top: 0.9374392359686055d,right: 0.46918126843529107d,bottom: 0.10778211287881478d,left: 0.3681986739681109d),

new NpgsqlTypes.NpgsqlBox(top: 0.8961620821743252d,right: 0.943423951191883d,bottom: 0.7359866784226856d,left: 0.7851857204356099d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41785919753116296d,right: 0.2868885826413301d,bottom: 0.17534552994647568d,left: 0.22467716031948837d),

new NpgsqlTypes.NpgsqlBox(top: 0.6741759776310365d,right: 0.8488580891625411d,bottom: 0.02321455263231298d,left: 0.08273958920473246d),

new NpgsqlTypes.NpgsqlBox(top: 0.6876038935086914d,right: 0.5351014859288152d,bottom: 0.26017268203586075d,left: 0.4151475420545938d),

new NpgsqlTypes.NpgsqlBox(top: 0.9664006054236515d,right: 0.7238568236043256d,bottom: 0.41706860815584124d,left: 0.4313830407453647d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5489887256912397d,right: 0.8040062578340339d,bottom: 0.13721333893164311d,left: 0.24863127402648166d),

new NpgsqlTypes.NpgsqlBox(top: 0.2959228362647639d,right: 0.4227568461173511d,bottom: 0.2618097766477684d,left: 0.003549923771916319d),

new NpgsqlTypes.NpgsqlBox(top: 0.19117279975239299d,right: 0.8715950860400555d,bottom: 0.03666915794200587d,left: 0.7209952090992308d),

new NpgsqlTypes.NpgsqlBox(top: 0.5520276974191438d,right: 0.8877296976102275d,bottom: 0.35217441981172015d,left: 0.5750972748305248d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8756647239792499d,right: 0.5405829469438269d,bottom: 0.05896214273719236d,left: 0.02365495046925492d),

new NpgsqlTypes.NpgsqlBox(top: 0.8654332666521867d,right: 0.9916923840991972d,bottom: 0.6043819600631691d,left: 0.9451966131798555d),

new NpgsqlTypes.NpgsqlBox(top: 0.856275460299376d,right: 0.784877299512878d,bottom: 0.5534975294510812d,left: 0.7805172365685336d),

new NpgsqlTypes.NpgsqlBox(top: 0.3359673652324442d,right: 0.9231611462003302d,bottom: 0.06950733442255619d,left: 0.2534933203869475d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.10497077687992329d,right: 0.5431897525123249d,bottom: 0.007407314018722855d,left: 0.3464893120324296d),

new NpgsqlTypes.NpgsqlBox(top: 0.7008525016218959d,right: 0.5135166317673501d,bottom: 0.03969292333487251d,left: 0.023161448075480373d),

new NpgsqlTypes.NpgsqlBox(top: 0.33524917230707274d,right: 0.8336739934058494d,bottom: 0.2402120220233106d,left: 0.21489453108877332d),

new NpgsqlTypes.NpgsqlBox(top: 0.5993651572005148d,right: 0.9230305130566518d,bottom: 0.41159526869458274d,left: 0.3255025426380034d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5871251822031417d,right: 0.7530133663286261d,bottom: 0.15633804989283595d,left: 0.0991932706731049d),

new NpgsqlTypes.NpgsqlBox(top: 0.946388071487371d,right: 0.7091485191289083d,bottom: 0.3504887107838296d,left: 0.03783165062883331d),

new NpgsqlTypes.NpgsqlBox(top: 0.6945666863531548d,right: 0.544995476189175d,bottom: 0.17986622685333653d,left: 0.3641736916214362d),

new NpgsqlTypes.NpgsqlBox(top: 0.6767757099852713d,right: 0.2202828279292024d,bottom: 0.3167898892134857d,left: 0.04354695799199959d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2751550966130065d,right: 0.5482410431458158d,bottom: 0.2292269342909855d,left: 0.26042380857171354d),

new NpgsqlTypes.NpgsqlBox(top: 0.9654938493818914d,right: 0.8645344331630408d,bottom: 0.6540944370058818d,left: 0.8229189246526935d),

new NpgsqlTypes.NpgsqlBox(top: 0.9701534699381406d,right: 0.9825789018460696d,bottom: 0.14329566488897916d,left: 0.511843868622797d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48526105368814676d,right: 0.3110850952197739d,bottom: 0.30413910747963113d,left: 0.01858021201831961d),

new NpgsqlTypes.NpgsqlBox(top: 0.8500571233069857d,right: 0.6933227685692934d,bottom: 0.6450778563600447d,left: 0.6098388938096502d),

new NpgsqlTypes.NpgsqlBox(top: 0.9023957873823178d,right: 0.481372266010368d,bottom: 0.23776323075366412d,left: 0.3138749698132389d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8281175813106753d,right: 0.5321924589935886d,bottom: 0.4135202481438013d,left: 0.34740292023149455d),

new NpgsqlTypes.NpgsqlBox(top: 0.6152753777426844d,right: 0.6881847215469801d,bottom: 0.09089926773706614d,left: 0.06296979970445293d),

new NpgsqlTypes.NpgsqlBox(top: 0.9936287448752867d,right: 0.5120678190427005d,bottom: 0.7058751045903872d,left: 0.46188428630973877d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8219011141244755d,right: 0.8553430996467332d,bottom: 0.5235371534979347d,left: 0.34397715670182816d),

new NpgsqlTypes.NpgsqlBox(top: 0.9859154876072064d,right: 0.5607577529716232d,bottom: 0.5736791273292866d,left: 0.45760660293881017d),

new NpgsqlTypes.NpgsqlBox(top: 0.7451648118733616d,right: 0.8609660603178814d,bottom: 0.6886918669635114d,left: 0.5010229199734725d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8987715294342226d,right: 0.8139699759047407d,bottom: 0.6352723151742015d,left: 0.48412310052520635d),

new NpgsqlTypes.NpgsqlBox(top: 0.620801181803258d,right: 0.6672756166861115d,bottom: 0.33474685267783866d,left: 0.2699384691765121d),

new NpgsqlTypes.NpgsqlBox(top: 0.7169497055718168d,right: 0.9204387934769168d,bottom: 0.6862337675065611d,left: 0.4187555079714683d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9722749870376292d,right: 0.46560868094557695d,bottom: 0.6596797904786232d,left: 0.1751139043292127d),

new NpgsqlTypes.NpgsqlBox(top: 0.6082891100920191d,right: 0.544830084300539d,bottom: 0.01972535048230739d,left: 0.529469671465148d),

new NpgsqlTypes.NpgsqlBox(top: 0.30738524900425324d,right: 0.8488232492607471d,bottom: 0.23630745332681113d,left: 0.39890688863722734d),

new NpgsqlTypes.NpgsqlBox(top: 0.7367749285082065d,right: 0.7604903349072104d,bottom: 0.08882786097451667d,left: 0.6243794838076479d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46258908836587664d,right: 0.7040636324060257d,bottom: 0.305657512819525d,left: 0.5035809289055622d),

new NpgsqlTypes.NpgsqlBox(top: 0.9534146533294231d,right: 0.17749370858206137d,bottom: 0.24180784650060094d,left: 0.07160108253573072d),

new NpgsqlTypes.NpgsqlBox(top: 0.7285243162128195d,right: 0.5489551970513323d,bottom: 0.2374051332233882d,left: 0.11761362253033902d),

new NpgsqlTypes.NpgsqlBox(top: 0.6047565877343515d,right: 0.9711579219545821d,bottom: 0.1382967131704791d,left: 0.45832007945856323d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5454879338669375d,right: 0.4638742113413554d,bottom: 0.2622309151200749d,left: 0.20526097716594738d),

new NpgsqlTypes.NpgsqlBox(top: 0.8960509607276291d,right: 0.7695622695723031d,bottom: 0.6109851926755973d,left: 0.31261955280462783d),

new NpgsqlTypes.NpgsqlBox(top: 0.20714026135330987d,right: 0.7238983337305042d,bottom: 0.19370365491900376d,left: 0.6141876660947179d),

new NpgsqlTypes.NpgsqlBox(top: 0.17709881556822527d,right: 0.9794510604577432d,bottom: 0.06855140472965393d,left: 0.5427168228011355d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8763652464052373d,right: 0.9692193452005007d,bottom: 0.5040681693048045d,left: 0.9115970310993504d),

new NpgsqlTypes.NpgsqlBox(top: 0.9356120822978422d,right: 0.5491592058154015d,bottom: 0.7608186207398706d,left: 0.26299522286590526d),

new NpgsqlTypes.NpgsqlBox(top: 0.7637707264704213d,right: 0.46087144977331673d,bottom: 0.33634842988364766d,left: 0.3607809439015469d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7820541126423032d,right: 0.6566733042661133d,bottom: 0.6901130183909053d,left: 0.12486731975002474d),

new NpgsqlTypes.NpgsqlBox(top: 0.8946672676916655d,right: 0.9591530293894681d,bottom: 0.6522080719664978d,left: 0.8304343304090928d),

new NpgsqlTypes.NpgsqlBox(top: 0.8141429676087639d,right: 0.7476000714901987d,bottom: 0.5591777563464243d,left: 0.46379637760170167d),

new NpgsqlTypes.NpgsqlBox(top: 0.9912329565093184d,right: 0.8581690415623389d,bottom: 0.7270257450987169d,left: 0.7386608315445262d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.602082828573238d,right: 0.8537233532767661d,bottom: 0.2690498717629558d,left: 0.6942791496236033d),

new NpgsqlTypes.NpgsqlBox(top: 0.6051860162176171d,right: 0.9999483116433298d,bottom: 0.37692400579390595d,left: 0.24192810310087443d),

new NpgsqlTypes.NpgsqlBox(top: 0.532523721195216d,right: 0.8692321472263053d,bottom: 0.3797576542095459d,left: 0.373596842694915d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5467206818304002d,right: 0.6435872085033744d,bottom: 0.22200637889935404d,left: 0.11074590572813447d),

new NpgsqlTypes.NpgsqlBox(top: 0.7378433717778052d,right: 0.43342890982431437d,bottom: 0.3322904013223065d,left: 0.27933845467745755d),

new NpgsqlTypes.NpgsqlBox(top: 0.9866071555623822d,right: 0.6111800862361196d,bottom: 0.33002654317948776d,left: 0.1648067703219097d),

new NpgsqlTypes.NpgsqlBox(top: 0.6794039915685606d,right: 0.30895655345836326d,bottom: 0.5200288036012803d,left: 0.19168310757571572d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.15641636374722168d,right: 0.9758159113565167d,bottom: 0.03306417711154275d,left: 0.9600142451098306d),

new NpgsqlTypes.NpgsqlBox(top: 0.5551783561460468d,right: 0.9830326055609295d,bottom: 0.5546042160107606d,left: 0.8035639997361955d),

new NpgsqlTypes.NpgsqlBox(top: 0.9833625293406582d,right: 0.6689473760799227d,bottom: 0.7580988647517531d,left: 0.5038243672385119d),

new NpgsqlTypes.NpgsqlBox(top: 0.823225102312001d,right: 0.14914969981248938d,bottom: 0.5598872137390579d,left: 0.14723556963291307d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.34566101716746545d,right: 0.7748400340364789d,bottom: 0.21597167572006126d,left: 0.5642946063154547d),

new NpgsqlTypes.NpgsqlBox(top: 0.2692614545985317d,right: 0.23494529412683207d,bottom: 0.21277548438809468d,left: 0.22199057797805433d),

new NpgsqlTypes.NpgsqlBox(top: 0.9399019826909681d,right: 0.9426553806821122d,bottom: 0.9083943498365308d,left: 0.9232095639377661d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8838711993478197d,right: 0.6359179186914691d,bottom: 0.6183054599208725d,left: 0.3816016856406028d),

new NpgsqlTypes.NpgsqlBox(top: 0.6409337292290159d,right: 0.9340624909334767d,bottom: 0.08335088604014307d,left: 0.7689218114360569d),

new NpgsqlTypes.NpgsqlBox(top: 0.7516576967974536d,right: 0.7503150325508378d,bottom: 0.6594798323154268d,left: 0.39262564311147363d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.29240613287077666d,right: 0.6983177391694577d,bottom: 0.014860632399131601d,left: 0.21733578336020498d),

new NpgsqlTypes.NpgsqlBox(top: 0.7407665124789883d,right: 0.03022950980942707d,bottom: 0.21363921361306837d,left: 0.02048150312760655d),

new NpgsqlTypes.NpgsqlBox(top: 0.967477423499502d,right: 0.5443280776003278d,bottom: 0.8506680829361836d,left: 0.014561481492898043d),

new NpgsqlTypes.NpgsqlBox(top: 0.9032078516091342d,right: 0.3555892228638219d,bottom: 0.8083409608492695d,left: 0.05366427749177649d),

},
    ModelInner = new NpgsqlBoxboxListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8014112201158813d,right: 0.6831870299939661d,bottom: 0.07013628657533655d,left: 0.31832237815101216d),

new NpgsqlTypes.NpgsqlBox(top: 0.6608436522908154d,right: 0.6942283364363528d,bottom: 0.2679018146350619d,left: 0.6009613334328084d),

new NpgsqlTypes.NpgsqlBox(top: 0.9074399461377414d,right: 0.5466513717024551d,bottom: 0.6461148386070515d,left: 0.43414650896169493d),

new NpgsqlTypes.NpgsqlBox(top: 0.33877632237183997d,right: 0.87046325588495d,bottom: 0.2974188964825105d,left: 0.6928413831735604d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9799364467607545d,right: 0.8299628787614515d,bottom: 0.42563857423484297d,left: 0.2785665365256321d),

new NpgsqlTypes.NpgsqlBox(top: 0.6786323037839402d,right: 0.7945729509528374d,bottom: 0.08630944637489146d,left: 0.3642436738124928d),

new NpgsqlTypes.NpgsqlBox(top: 0.6942737502288382d,right: 0.6981566548228092d,bottom: 0.43670171452731066d,left: 0.6277790509247957d),

new NpgsqlTypes.NpgsqlBox(top: 0.3910647715207396d,right: 0.4651980121966256d,bottom: 0.12477875996257892d,left: 0.019633624590769005d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5807541449139261d,right: 0.5432286562824732d,bottom: 0.1268910142497215d,left: 0.0697735563422085d),

new NpgsqlTypes.NpgsqlBox(top: 0.6523001183015797d,right: 0.8121635918487456d,bottom: 0.04795807727284318d,left: 0.34393938358394016d),

new NpgsqlTypes.NpgsqlBox(top: 0.6273906847413533d,right: 0.6336027508870112d,bottom: 0.2969268646262909d,left: 0.5314173430436422d),

new NpgsqlTypes.NpgsqlBox(top: 0.16044454482197557d,right: 0.4970545834582891d,bottom: 0.15870074153412295d,left: 0.24979352726474735d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
INSERT INTO public.npgsqlboxboxlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)), 
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
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd1e2mi_id
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
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                methodParametrName: "npgsqlboxboxlistd1e2mi_id", 
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
                List<NpgsqlBoxboxListD1E2M> models = null;

                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxListD1E2M> models = null;

                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 171, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 158, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 16, query1, 155, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 48, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 16, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 8, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 107, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatch(connection, 84, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[8], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[9], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[10], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[11], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[12], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[13], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[14], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[15], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[16], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[17], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[18], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[19], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[20], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[21], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[22], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[23], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[24], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[25], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[26], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[27], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxListD1E2M),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
FROM public.binary_npgsqlboxboxlistd1e2m m
LEFT JOIN public.binary_npgsqlboxboxlistd1e2mi mi ON mi.id = m.npgsqlboxboxlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxListboxListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd1e2mi
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
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI), typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                await ((INpgsqlBoxListboxListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MI>();
                var models2 = new List<NpgsqlBoxboxListD1E2MI>();
                ((INpgsqlBoxListboxListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA), typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD1E2MIWA>();
                var models2 = new List<NpgsqlBoxboxListD1E2MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

