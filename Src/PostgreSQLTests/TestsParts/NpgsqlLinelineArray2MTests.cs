

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7149876340836495d, b: 0.7230640986988879d, c: 0.3000457299402861d),

new NpgsqlTypes.NpgsqlLine(a: 0.6476580059875325d, b: 0.7904646550079052d, c: 0.26095901318018677d),

new NpgsqlTypes.NpgsqlLine(a: 0.38108035709987875d, b: 0.1757852583571522d, c: 0.054077266632136634d),

new NpgsqlTypes.NpgsqlLine(a: 0.22336639492322796d, b: 0.3874829960274746d, c: 0.7269678862225252d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4227925493789907d, b: 0.22777054851904133d, c: 0.4792020996448175d),

new NpgsqlTypes.NpgsqlLine(a: 0.343084601385661d, b: 0.7825310425090561d, c: 0.2866512040334883d),

new NpgsqlTypes.NpgsqlLine(a: 0.42664476223965797d, b: 0.13196531390727684d, c: 0.7153812460658778d),

new NpgsqlTypes.NpgsqlLine(a: 0.43888999442112164d, b: 0.4963407411265296d, c: 0.6897039247103403d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2775999306187421d, b: 0.7997531484424149d, c: 0.7687322195229309d),

new NpgsqlTypes.NpgsqlLine(a: 0.4545614961162885d, b: 0.14359091737186813d, c: 0.3314498134077528d),

new NpgsqlTypes.NpgsqlLine(a: 0.23308723297971767d, b: 0.2734519864916912d, c: 0.17899012462652764d),

new NpgsqlTypes.NpgsqlLine(a: 0.011208240335259467d, b: 0.4937104633602132d, c: 0.2375469660335363d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4488686260252328d, b: 0.6028732795944133d, c: 0.1831166422990924d),

new NpgsqlTypes.NpgsqlLine(a: 0.10702611941314422d, b: 0.8064763785684319d, c: 0.534852386346053d),

new NpgsqlTypes.NpgsqlLine(a: 0.8428651144239688d, b: 0.8020607756523969d, c: 0.3031574615480903d),

new NpgsqlTypes.NpgsqlLine(a: 0.5681028140855506d, b: 0.5642926143546938d, c: 0.39801447095382303d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8341589675240872d, b: 0.5204730858046784d, c: 0.241755174317009d),

new NpgsqlTypes.NpgsqlLine(a: 0.9299764989445148d, b: 0.7145394694605955d, c: 0.1037146107523016d),

new NpgsqlTypes.NpgsqlLine(a: 0.8006860353230613d, b: 0.6078518482251366d, c: 0.8585483046186074d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4177084769224291d, b: 0.47979063540479805d, c: 0.6633341533375445d),

new NpgsqlTypes.NpgsqlLine(a: 0.3965851405090187d, b: 0.3138106283098545d, c: 0.8348286138077721d),

new NpgsqlTypes.NpgsqlLine(a: 0.6440296110072715d, b: 0.8543624408871663d, c: 0.7453405738878731d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5584884483695272d, b: 0.14984414625544473d, c: 0.4522479529755702d),

new NpgsqlTypes.NpgsqlLine(a: 0.2666314524026304d, b: 0.25582955267155416d, c: 0.28720974316838466d),

new NpgsqlTypes.NpgsqlLine(a: 0.8014549115776711d, b: 0.15998461008483567d, c: 0.2910887548467018d),

new NpgsqlTypes.NpgsqlLine(a: 0.22681528484876434d, b: 0.5700706824457312d, c: 0.7749325164502299d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6952701422680072d, b: 0.5852550310188624d, c: 0.03435973750918042d),

new NpgsqlTypes.NpgsqlLine(a: 0.9108537328252989d, b: 0.18216871171842197d, c: 0.5361564051358032d),

new NpgsqlTypes.NpgsqlLine(a: 0.3137598569818294d, b: 0.506088388165799d, c: 0.7765816963246018d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.035917126884453476d, b: 0.5414368961376799d, c: 0.26390823313258216d),

new NpgsqlTypes.NpgsqlLine(a: 0.060551373200967595d, b: 0.5444837649317694d, c: 0.25641218993902537d),

new NpgsqlTypes.NpgsqlLine(a: 0.485222088665464d, b: 0.10417342141792696d, c: 0.973388971587149d),

new NpgsqlTypes.NpgsqlLine(a: 0.3575628083356578d, b: 0.6834365319413596d, c: 0.16248977255956853d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1807508578337509d, b: 0.19816119245797947d, c: 0.3963431863909732d),

new NpgsqlTypes.NpgsqlLine(a: 0.5320567233012767d, b: 0.7613557350333532d, c: 0.015552849311479933d),

new NpgsqlTypes.NpgsqlLine(a: 0.6142383893639948d, b: 0.7303682862664937d, c: 0.8559213931054188d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48395525548396034d, b: 0.8562018633739077d, c: 0.7572379760785122d),

new NpgsqlTypes.NpgsqlLine(a: 0.6701191612424655d, b: 0.3499538591366935d, c: 0.8612953266798378d),

new NpgsqlTypes.NpgsqlLine(a: 0.308876283379664d, b: 0.08762906306806761d, c: 0.28840979498705865d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5581162239368308d, b: 0.6724074560170713d, c: 0.4329225504636135d),

new NpgsqlTypes.NpgsqlLine(a: 0.7813509323863492d, b: 0.9700489311292039d, c: 0.7873062818094241d),

new NpgsqlTypes.NpgsqlLine(a: 0.5958902252869163d, b: 0.1193226645284492d, c: 0.7510752530024252d),

new NpgsqlTypes.NpgsqlLine(a: 0.4548643200404491d, b: 0.28716561951866315d, c: 0.3971156692017076d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8768201048292862d, b: 0.7661378052443142d, c: 0.20278828019649353d),

new NpgsqlTypes.NpgsqlLine(a: 0.10670254513116728d, b: 0.3207317675669593d, c: 0.14694063259430956d),

new NpgsqlTypes.NpgsqlLine(a: 0.2503965694623165d, b: 0.34526347939013957d, c: 0.9568656786359071d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7221325346275645d, b: 0.45679983882917163d, c: 0.513081035486674d),

new NpgsqlTypes.NpgsqlLine(a: 0.7218168581872038d, b: 0.15069773133235032d, c: 0.8755728697644954d),

new NpgsqlTypes.NpgsqlLine(a: 0.8391363098999872d, b: 0.24270332723727306d, c: 0.13685774553528074d),

new NpgsqlTypes.NpgsqlLine(a: 0.8798346659216276d, b: 0.489280048667995d, c: 0.7103105094107761d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5432834807829482d, b: 0.3389862464296324d, c: 0.8917399478995404d),

new NpgsqlTypes.NpgsqlLine(a: 0.6540935149237318d, b: 0.17042422220884246d, c: 0.5917347196525099d),

new NpgsqlTypes.NpgsqlLine(a: 0.9413442053659352d, b: 0.3609273074667382d, c: 0.718320741011771d),

new NpgsqlTypes.NpgsqlLine(a: 0.3549457170389718d, b: 0.7638791309100974d, c: 0.215031197004093d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49760402121327707d, b: 0.5528821047367755d, c: 0.4420258720378034d),

new NpgsqlTypes.NpgsqlLine(a: 0.6052191759349431d, b: 0.35857499373871027d, c: 0.36332222082280186d),

new NpgsqlTypes.NpgsqlLine(a: 0.9496157878320078d, b: 0.6620595920823243d, c: 0.775584112758807d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8230159456220089d, b: 0.1429122004791683d, c: 0.1318206683211106d),

new NpgsqlTypes.NpgsqlLine(a: 0.1763477880107467d, b: 0.5013231040687612d, c: 0.019073157951866926d),

new NpgsqlTypes.NpgsqlLine(a: 0.19984236116399445d, b: 0.09396715611865614d, c: 0.11735026028158202d),

new NpgsqlTypes.NpgsqlLine(a: 0.35125435448091236d, b: 0.2346926246940032d, c: 0.019587978196580758d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7908241394600903d, b: 0.30985856818830737d, c: 0.7117313445313693d),

new NpgsqlTypes.NpgsqlLine(a: 0.5470536316032709d, b: 0.7937896305525602d, c: 0.8863178113312994d),

new NpgsqlTypes.NpgsqlLine(a: 0.7037456799310314d, b: 0.9970415354004989d, c: 0.8165594261523796d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3359021426635298d, b: 0.7385622087625106d, c: 0.4351794035060953d),

new NpgsqlTypes.NpgsqlLine(a: 0.3455928502095844d, b: 0.8705494428338669d, c: 0.7195038208059109d),

new NpgsqlTypes.NpgsqlLine(a: 0.08340855108952727d, b: 0.5443125095480253d, c: 0.9974679737333554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9927502984535391d, b: 0.025497963202373852d, c: 0.26629007553048933d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8008995218749058d, b: 0.15446984527120589d, c: 0.6972177593428767d),

new NpgsqlTypes.NpgsqlLine(a: 0.6861078791417964d, b: 0.6585592440540152d, c: 0.4078360214953477d),

new NpgsqlTypes.NpgsqlLine(a: 0.32500912816280936d, b: 0.22963663775155796d, c: 0.5448706995171796d),

new NpgsqlTypes.NpgsqlLine(a: 0.6243171639193899d, b: 0.7222647261690263d, c: 0.503927496823087d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6603955280830133d, b: 0.9597538933088084d, c: 0.6794394776777624d),

new NpgsqlTypes.NpgsqlLine(a: 0.0358360417251633d, b: 0.003909748813268332d, c: 0.12737200479215127d),

new NpgsqlTypes.NpgsqlLine(a: 0.17152746774958372d, b: 0.9417797609611348d, c: 0.040685368156687995d),

new NpgsqlTypes.NpgsqlLine(a: 0.16816356427035484d, b: 0.25642020171213653d, c: 0.17302254903335623d),

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
new NpgsqlTypes.NpgsqlLine(a: 0.521195162077818d, b: 0.6732253493040996d, c: 0.9491249540823784d),

new NpgsqlTypes.NpgsqlLine(a: 0.1259633581905799d, b: 0.8910328378507468d, c: 0.5982786389363286d),

new NpgsqlTypes.NpgsqlLine(a: 0.4262848550918652d, b: 0.8037418420893476d, c: 0.8224558325197253d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6060736910802136d, b: 0.11667996682599158d, c: 0.4092342336515845d),

new NpgsqlTypes.NpgsqlLine(a: 0.1401228669305744d, b: 0.30624809729281166d, c: 0.8987020264684129d),

new NpgsqlTypes.NpgsqlLine(a: 0.3536645717762985d, b: 0.9953197740011018d, c: 0.3004447559358957d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3090757815589801d, b: 0.17469474239037286d, c: 0.16179417953698683d),

new NpgsqlTypes.NpgsqlLine(a: 0.09231235984673469d, b: 0.4485519661110937d, c: 0.24074938537607005d),

new NpgsqlTypes.NpgsqlLine(a: 0.7575439038033205d, b: 0.3553265529831132d, c: 0.5426211479105343d),

new NpgsqlTypes.NpgsqlLine(a: 0.7229282630800511d, b: 0.9387550277569768d, c: 0.375014922534065d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3834660964673078d, b: 0.7368375430995545d, c: 0.14534765220202972d),

new NpgsqlTypes.NpgsqlLine(a: 0.4774419069264555d, b: 0.4417494812749909d, c: 0.041392469229046824d),

new NpgsqlTypes.NpgsqlLine(a: 0.8763928979034568d, b: 0.6143489679048239d, c: 0.6399153551232217d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08867155158635431d, b: 0.1612374935204851d, c: 0.24107872054915225d),

new NpgsqlTypes.NpgsqlLine(a: 0.3911049552341235d, b: 0.6763571058634021d, c: 0.14783016393761428d),

new NpgsqlTypes.NpgsqlLine(a: 0.29976850511600706d, b: 0.9167390582820086d, c: 0.7672991890267912d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6581235450492644d, b: 0.13806759804285273d, c: 0.9759027584636657d),

new NpgsqlTypes.NpgsqlLine(a: 0.9176434735998518d, b: 0.6286973225270303d, c: 0.37344498200049503d),

new NpgsqlTypes.NpgsqlLine(a: 0.07663180919328161d, b: 0.5837203482531679d, c: 0.4223163836361673d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.661011299447144d, b: 0.2429337649346477d, c: 0.7705342428423488d),

new NpgsqlTypes.NpgsqlLine(a: 0.9925859940040881d, b: 0.10414718097685416d, c: 0.7803493582798847d),

new NpgsqlTypes.NpgsqlLine(a: 0.596771593326588d, b: 0.6946418115441209d, c: 0.8958221156460868d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2636547579322388d, b: 0.5445523688957571d, c: 0.5209497294781241d),

new NpgsqlTypes.NpgsqlLine(a: 0.483980702673637d, b: 0.6099782518091227d, c: 0.44801904731882347d),

new NpgsqlTypes.NpgsqlLine(a: 0.75049655317568d, b: 0.8635536760899066d, c: 0.04856868767961575d),

new NpgsqlTypes.NpgsqlLine(a: 0.4923828270135171d, b: 0.6776611322895418d, c: 0.5427691625045582d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10805475897080397d, b: 0.07116388314129685d, c: 0.3418757526795504d),

new NpgsqlTypes.NpgsqlLine(a: 0.8646566101919084d, b: 0.5999495303486536d, c: 0.05172483479831924d),

new NpgsqlTypes.NpgsqlLine(a: 0.9482220388693094d, b: 0.5008898418718769d, c: 0.10968232880108386d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2828705361143573d, b: 0.6135856122097803d, c: 0.44277383398507475d),

new NpgsqlTypes.NpgsqlLine(a: 0.09025710615466664d, b: 0.1023689050001857d, c: 0.583253987911022d),

new NpgsqlTypes.NpgsqlLine(a: 0.4211702693053766d, b: 0.6279996703969671d, c: 0.634171880036927d),

new NpgsqlTypes.NpgsqlLine(a: 0.69312273455749d, b: 0.46619072892609226d, c: 0.48900013284879607d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7722160578746712d, b: 0.6224103976546413d, c: 0.09280361074512344d),

new NpgsqlTypes.NpgsqlLine(a: 0.285641834973269d, b: 0.4740612498867821d, c: 0.24415496044725782d),

new NpgsqlTypes.NpgsqlLine(a: 0.4990081349235388d, b: 0.7207013197125002d, c: 0.9149792617451667d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8122186515605166d, b: 0.7013925930653259d, c: 0.2865159675961423d),

new NpgsqlTypes.NpgsqlLine(a: 0.6950582413364241d, b: 0.021572353800654254d, c: 0.2936901778048503d),

new NpgsqlTypes.NpgsqlLine(a: 0.939027023020515d, b: 0.8459768627703094d, c: 0.5722028013941199d),

new NpgsqlTypes.NpgsqlLine(a: 0.9493259855052874d, b: 0.9615565427697107d, c: 0.5568830443897959d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9551340825325296d, b: 0.3149642538225337d, c: 0.6714230757775044d),

new NpgsqlTypes.NpgsqlLine(a: 0.6035377655984804d, b: 0.845531040535817d, c: 0.05969237506456471d),

new NpgsqlTypes.NpgsqlLine(a: 0.37408971479388486d, b: 0.5850677218416394d, c: 0.0863214763338297d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5494603542069558d, b: 0.1313292998655402d, c: 0.8008961567569144d),

new NpgsqlTypes.NpgsqlLine(a: 0.010389976808526602d, b: 0.09268977472472861d, c: 0.509204258325425d),

new NpgsqlTypes.NpgsqlLine(a: 0.8435738587643306d, b: 0.578547639661851d, c: 0.543073311020867d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4905075859521991d, b: 0.547298919471795d, c: 0.6313902135485644d),

new NpgsqlTypes.NpgsqlLine(a: 0.9197978832054239d, b: 0.07610711958254768d, c: 0.6161966446332952d),

new NpgsqlTypes.NpgsqlLine(a: 0.47068098252846957d, b: 0.03749095528754498d, c: 0.5977037973832322d),

new NpgsqlTypes.NpgsqlLine(a: 0.6686029956209475d, b: 0.0012115084983043145d, c: 0.03345613033190642d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6659173948202975d, b: 0.7866507134214489d, c: 0.6515861770451886d),

new NpgsqlTypes.NpgsqlLine(a: 0.04210797353183926d, b: 0.4535745132783827d, c: 0.8730264025466442d),

new NpgsqlTypes.NpgsqlLine(a: 0.20209853439875358d, b: 0.8622692491512114d, c: 0.6853196224851699d),

new NpgsqlTypes.NpgsqlLine(a: 0.6128515336818402d, b: 0.3822658283891128d, c: 0.25976463030873564d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6493017385900373d, b: 0.5890438877334893d, c: 0.887669734709941d),

new NpgsqlTypes.NpgsqlLine(a: 0.034348297932918936d, b: 0.241732443673069d, c: 0.03939169957363953d),

new NpgsqlTypes.NpgsqlLine(a: 0.7168081781305902d, b: 0.962095447775453d, c: 0.3076543886663464d),

new NpgsqlTypes.NpgsqlLine(a: 0.44123464906767185d, b: 0.9527926366679261d, c: 0.8596401862978724d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9666366044208548d, b: 0.290978349332462d, c: 0.708145673014534d),

new NpgsqlTypes.NpgsqlLine(a: 0.542685476588873d, b: 0.3361714854040282d, c: 0.5185969434328256d),

new NpgsqlTypes.NpgsqlLine(a: 0.07093288260147024d, b: 0.47656892584627664d, c: 0.4116643127344298d),

new NpgsqlTypes.NpgsqlLine(a: 0.8724084859148017d, b: 0.8488337232485621d, c: 0.2920763806266823d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9646719426621764d, b: 0.6439879077774723d, c: 0.00033031608997768913d),

new NpgsqlTypes.NpgsqlLine(a: 0.06663183017922159d, b: 0.6357384272211469d, c: 0.8374225811405996d),

new NpgsqlTypes.NpgsqlLine(a: 0.9058314711737758d, b: 0.6475577813332266d, c: 0.4083477207756192d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27153539723743514d, b: 0.7845640539828901d, c: 0.9995346151055123d),

new NpgsqlTypes.NpgsqlLine(a: 0.20584896377230466d, b: 0.5593948459026024d, c: 0.5895937097029246d),

new NpgsqlTypes.NpgsqlLine(a: 0.5980722195347788d, b: 0.02536243088614354d, c: 0.9171322994193577d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22821046764808717d, b: 0.6647146538179646d, c: 0.051547952845760525d),

new NpgsqlTypes.NpgsqlLine(a: 0.869893706615045d, b: 0.7361623473146043d, c: 0.7625631199707501d),

new NpgsqlTypes.NpgsqlLine(a: 0.8748002142629918d, b: 0.9914746046283716d, c: 0.9357997915362408d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24855476306156976d, b: 0.2889201412083523d, c: 0.7221437121387364d),

new NpgsqlTypes.NpgsqlLine(a: 0.8560649715804973d, b: 0.9184200074955491d, c: 0.8168711256751722d),

new NpgsqlTypes.NpgsqlLine(a: 0.8052280376038347d, b: 0.9952138845266933d, c: 0.7210394151399251d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.67534405966868d, b: 0.17213690813170834d, c: 0.9559994392662766d),

new NpgsqlTypes.NpgsqlLine(a: 0.5888003999765993d, b: 0.1615318745262111d, c: 0.6427100387753084d),

new NpgsqlTypes.NpgsqlLine(a: 0.7242173738965311d, b: 0.04875858864325988d, c: 0.4328953130353028d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7866064149887864d, b: 0.2856771954145144d, c: 0.8920477487532176d),

new NpgsqlTypes.NpgsqlLine(a: 0.8369603485204442d, b: 0.18767540918311554d, c: 0.4420446403530156d),

new NpgsqlTypes.NpgsqlLine(a: 0.21131949548659856d, b: 0.3389804799694026d, c: 0.5797181253525718d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7185289959050456d, b: 0.6559817674271659d, c: 0.007807807185220339d),

new NpgsqlTypes.NpgsqlLine(a: 0.16096237925233192d, b: 0.4231338971602352d, c: 0.2547936063645154d),

new NpgsqlTypes.NpgsqlLine(a: 0.1537644142584823d, b: 0.976384355283999d, c: 0.3819642704988443d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5496123995510185d, b: 0.00038539578900254057d, c: 0.36171344474991896d),

new NpgsqlTypes.NpgsqlLine(a: 0.5013504887065192d, b: 0.10011769155704164d, c: 0.490149999768663d),

new NpgsqlTypes.NpgsqlLine(a: 0.8245555622503185d, b: 0.31803857090367726d, c: 0.45564782487413d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2915196398786568d, b: 0.46588280307717045d, c: 0.3080600911092153d),

new NpgsqlTypes.NpgsqlLine(a: 0.932785324639839d, b: 0.9429214289131767d, c: 0.27889268774783704d),

new NpgsqlTypes.NpgsqlLine(a: 0.22739734410066315d, b: 0.18751395996428544d, c: 0.9197902472866818d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5150296577205985d, b: 0.17569159910908883d, c: 0.9620358194110838d),

new NpgsqlTypes.NpgsqlLine(a: 0.044193310411529296d, b: 0.5448054543573841d, c: 0.15809465778792042d),

new NpgsqlTypes.NpgsqlLine(a: 0.5356619938171842d, b: 0.7789974894411497d, c: 0.6093190273451395d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6662749683034274d, b: 0.1800155737752318d, c: 0.055083008570198544d),

new NpgsqlTypes.NpgsqlLine(a: 0.004729358402956851d, b: 0.7579506857021562d, c: 0.267696331834096d),

new NpgsqlTypes.NpgsqlLine(a: 0.7788023594717081d, b: 0.3050745275074128d, c: 0.8975972127161904d),

new NpgsqlTypes.NpgsqlLine(a: 0.18300848277500625d, b: 0.6852690051486428d, c: 0.3627257731579159d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5923954991613831d, b: 0.6955619099614204d, c: 0.14585856229008487d),

new NpgsqlTypes.NpgsqlLine(a: 0.9990442304659968d, b: 0.9389484992401598d, c: 0.29828372924016355d),

new NpgsqlTypes.NpgsqlLine(a: 0.5765199271968399d, b: 0.3297168075222282d, c: 0.9222111889279007d),

new NpgsqlTypes.NpgsqlLine(a: 0.7742886026972168d, b: 0.7994568261113166d, c: 0.6338765331211801d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.781840138563353d, b: 0.04249014364404091d, c: 0.12707110455464565d),

new NpgsqlTypes.NpgsqlLine(a: 0.16788598502030305d, b: 0.8566077346873004d, c: 0.3403287564675821d),

new NpgsqlTypes.NpgsqlLine(a: 0.8225324510753347d, b: 0.425157211299926d, c: 0.6562220815360692d),

new NpgsqlTypes.NpgsqlLine(a: 0.12163970138149627d, b: 0.9758600405594107d, c: 0.8800079316183096d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9170621995016252d, b: 0.7580586998100463d, c: 0.36643485042519564d),

new NpgsqlTypes.NpgsqlLine(a: 0.7107936977445254d, b: 0.39805293149939425d, c: 0.3511185327471392d),

new NpgsqlTypes.NpgsqlLine(a: 0.22168207136294482d, b: 0.13483231558908182d, c: 0.6181915268451765d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7594821637389512d, b: 0.5256456431715529d, c: 0.8956262794633006d),

new NpgsqlTypes.NpgsqlLine(a: 0.9597750473364188d, b: 0.1751982348879011d, c: 0.01688438500613243d),

new NpgsqlTypes.NpgsqlLine(a: 0.9587872849153696d, b: 0.4317231133167211d, c: 0.36139168603881355d),

new NpgsqlTypes.NpgsqlLine(a: 0.7890359733095436d, b: 0.8423359362992354d, c: 0.6063533835687571d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7832914226100204d, b: 0.9783218861842936d, c: 0.11405410091928636d),

new NpgsqlTypes.NpgsqlLine(a: 0.8614476539644093d, b: 0.023687774956935304d, c: 0.68494346393751d),

new NpgsqlTypes.NpgsqlLine(a: 0.1266734905090794d, b: 0.277903083476843d, c: 0.8329185314046262d),

new NpgsqlTypes.NpgsqlLine(a: 0.7380637718713845d, b: 0.9112952108186827d, c: 0.7944901424906782d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7474212960523711d, b: 0.8365375583595651d, c: 0.5059725326052773d),

new NpgsqlTypes.NpgsqlLine(a: 0.1733250663788003d, b: 0.8713611127218696d, c: 0.4178203612717444d),

new NpgsqlTypes.NpgsqlLine(a: 0.7944186890703792d, b: 0.7363812885112391d, c: 0.2463075282065088d),

new NpgsqlTypes.NpgsqlLine(a: 0.3962760970286837d, b: 0.08221735981383338d, c: 0.4542776163522777d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8288340160594241d, b: 0.8410490509814428d, c: 0.31156905470653207d),

new NpgsqlTypes.NpgsqlLine(a: 0.9160056526983282d, b: 0.3202480794709094d, c: 0.3918918687706805d),

new NpgsqlTypes.NpgsqlLine(a: 0.043060550166932776d, b: 0.6097879128899538d, c: 0.5721577209654353d),

new NpgsqlTypes.NpgsqlLine(a: 0.9440683287845002d, b: 0.16346700576438444d, c: 0.4322959400426527d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2729807513601872d, b: 0.02013634131417763d, c: 0.6720719983077962d),

new NpgsqlTypes.NpgsqlLine(a: 0.31383046121388736d, b: 0.8904199090904061d, c: 0.6526050996921663d),

new NpgsqlTypes.NpgsqlLine(a: 0.6052082303246947d, b: 0.550276278515772d, c: 0.8234099643071104d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4741851934167496d, b: 0.519719152337522d, c: 0.6272077066670844d),

new NpgsqlTypes.NpgsqlLine(a: 0.3889082676629798d, b: 0.2808587516883828d, c: 0.6766645672284942d),

new NpgsqlTypes.NpgsqlLine(a: 0.7734898261592386d, b: 0.5773980734006003d, c: 0.705930637586214d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26990132759461605d, b: 0.38594788856774787d, c: 0.6253732994166926d),

new NpgsqlTypes.NpgsqlLine(a: 0.23785200246852334d, b: 0.8842946170246304d, c: 0.5910644734502326d),

new NpgsqlTypes.NpgsqlLine(a: 0.28830054931840643d, b: 0.9151489497481535d, c: 0.7688773295201164d),

new NpgsqlTypes.NpgsqlLine(a: 0.8189684445549229d, b: 0.8522222996009979d, c: 0.6447242709745798d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02816682325506914d, b: 0.8406341887648049d, c: 0.3213066064309028d),

new NpgsqlTypes.NpgsqlLine(a: 0.4924862962410619d, b: 0.6842564678867725d, c: 0.7297365032449298d),

new NpgsqlTypes.NpgsqlLine(a: 0.26785603157364324d, b: 0.06956239492621119d, c: 0.05740179111230925d),

new NpgsqlTypes.NpgsqlLine(a: 0.358012621721694d, b: 0.4666228283332955d, c: 0.5582469745966757d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12628308479821448d, b: 0.09585209414260487d, c: 0.6232928612362159d),

new NpgsqlTypes.NpgsqlLine(a: 0.6707025025334745d, b: 0.07125615845311317d, c: 0.3140069929202588d),

new NpgsqlTypes.NpgsqlLine(a: 0.16300639060237432d, b: 0.8738015547498156d, c: 0.6366180775781429d),

new NpgsqlTypes.NpgsqlLine(a: 0.5818207356462775d, b: 0.44815729162120843d, c: 0.6833751981787356d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7240044001771926d, b: 0.13854258506109696d, c: 0.25478787747816056d),

new NpgsqlTypes.NpgsqlLine(a: 0.29672576291285835d, b: 0.8315546296095567d, c: 0.029093824443807148d),

new NpgsqlTypes.NpgsqlLine(a: 0.14550546642254558d, b: 0.15118881746845791d, c: 0.8130778274848101d),

new NpgsqlTypes.NpgsqlLine(a: 0.3918821729674794d, b: 0.6875577473021041d, c: 0.7304787375150289d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2273505554906481d, b: 0.018926293797061455d, c: 0.43694168568599867d),

new NpgsqlTypes.NpgsqlLine(a: 0.20342773207274556d, b: 0.6495647861014203d, c: 0.31490668905230257d),

new NpgsqlTypes.NpgsqlLine(a: 0.8187005928744965d, b: 0.7656436974727581d, c: 0.29610252798459624d),

new NpgsqlTypes.NpgsqlLine(a: 0.30473277613109007d, b: 0.619850876578472d, c: 0.9297405407232087d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5992156082289802d, b: 0.42398713855728865d, c: 0.6337644670003815d),

new NpgsqlTypes.NpgsqlLine(a: 0.47170033460820404d, b: 0.12948268997884427d, c: 0.5378723171656578d),

new NpgsqlTypes.NpgsqlLine(a: 0.9773406282429712d, b: 0.44336240929011406d, c: 0.0029863337106648125d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12118121433372797d, b: 0.7897423838962416d, c: 0.7358552697260892d),

new NpgsqlTypes.NpgsqlLine(a: 0.2388358824252803d, b: 0.13199069473193414d, c: 0.06043448954391528d),

new NpgsqlTypes.NpgsqlLine(a: 0.2084194654980105d, b: 0.3589110075175148d, c: 0.46779722910540433d),

new NpgsqlTypes.NpgsqlLine(a: 0.6875612825488329d, b: 0.5168414943875304d, c: 0.08945065329984259d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16791786302187872d, b: 0.653153378338101d, c: 0.43757432438426636d),

new NpgsqlTypes.NpgsqlLine(a: 0.42267222067036114d, b: 0.003141216178507822d, c: 0.921829434669988d),

new NpgsqlTypes.NpgsqlLine(a: 0.6777624079804594d, b: 0.11496238308398266d, c: 0.9490902907369793d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6227092627660755d, b: 0.9264640796212863d, c: 0.3260221690412214d),

new NpgsqlTypes.NpgsqlLine(a: 0.9236613162395517d, b: 0.3434766541075266d, c: 0.3016101153104902d),

new NpgsqlTypes.NpgsqlLine(a: 0.18485570837265608d, b: 0.07636598588259214d, c: 0.4839552921110889d),

new NpgsqlTypes.NpgsqlLine(a: 0.29269077166547774d, b: 0.20692269870948943d, c: 0.23586208165519507d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06798183045071371d, b: 0.5546070015542826d, c: 0.15292044428824403d),

new NpgsqlTypes.NpgsqlLine(a: 0.3551390204736061d, b: 0.8238035419773885d, c: 0.43615142287783015d),

new NpgsqlTypes.NpgsqlLine(a: 0.1707907583458067d, b: 0.13553108227255228d, c: 0.9599316206024499d),

new NpgsqlTypes.NpgsqlLine(a: 0.9227796276983887d, b: 0.7751474605468385d, c: 0.7501205878779877d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8783609509946535d, b: 0.7375701628730539d, c: 0.9997575577209953d),

new NpgsqlTypes.NpgsqlLine(a: 0.46887558043852173d, b: 0.9434500728879283d, c: 0.7562073463238587d),

new NpgsqlTypes.NpgsqlLine(a: 0.9760036876232273d, b: 0.3808875777338192d, c: 0.265566084005626d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.833304981005987d, b: 0.7455972525374481d, c: 0.8988039755028169d),

new NpgsqlTypes.NpgsqlLine(a: 0.18494456738119613d, b: 0.7688485102857401d, c: 0.831880770537831d),

new NpgsqlTypes.NpgsqlLine(a: 0.9926899904743949d, b: 0.21069984377467765d, c: 0.03232398494657074d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31106511002232484d, b: 0.7525226900137046d, c: 0.4324883387851899d),

new NpgsqlTypes.NpgsqlLine(a: 0.3134840648860565d, b: 0.10459814588413363d, c: 0.8806732737603399d),

new NpgsqlTypes.NpgsqlLine(a: 0.8568106046910601d, b: 0.16302011962576435d, c: 0.14793014325211518d),

new NpgsqlTypes.NpgsqlLine(a: 0.37560467587177937d, b: 0.3590988666685232d, c: 0.2610886035416078d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6421863933233464d, b: 0.5137522111507534d, c: 0.6699529853322589d),

new NpgsqlTypes.NpgsqlLine(a: 0.41602803726125825d, b: 0.3019298670408307d, c: 0.6397201534140178d),

new NpgsqlTypes.NpgsqlLine(a: 0.9590234207963347d, b: 0.44817366383212587d, c: 0.667078892663452d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5242196759706022d, b: 0.5813760991695659d, c: 0.11719219173288387d),

new NpgsqlTypes.NpgsqlLine(a: 0.4018343986444429d, b: 0.4299167753860862d, c: 0.8916891742632229d),

new NpgsqlTypes.NpgsqlLine(a: 0.40102381990663527d, b: 0.07961549170673454d, c: 0.8503780775604461d),

new NpgsqlTypes.NpgsqlLine(a: 0.8846793319757158d, b: 0.8034119731088489d, c: 0.8202724747851101d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.962511601723884d, b: 0.5232478926125474d, c: 0.8907476589080702d),

new NpgsqlTypes.NpgsqlLine(a: 0.9630961903864306d, b: 0.9978037642814518d, c: 0.8753884366804635d),

new NpgsqlTypes.NpgsqlLine(a: 0.3356686040798489d, b: 0.2515132246654376d, c: 0.7073759488030568d),

new NpgsqlTypes.NpgsqlLine(a: 0.9141120458439495d, b: 0.7233949592072394d, c: 0.989540137513412d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05460261550855683d, b: 0.8689589463915522d, c: 0.3547945327319436d),

new NpgsqlTypes.NpgsqlLine(a: 0.33891871582575894d, b: 0.970457925344697d, c: 0.4118321557102581d),

new NpgsqlTypes.NpgsqlLine(a: 0.43731316783309804d, b: 0.16200358074971744d, c: 0.4434341446566741d),

new NpgsqlTypes.NpgsqlLine(a: 0.5287531242194115d, b: 0.5901396793128967d, c: 0.9580198364393445d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.00892269166431181d, b: 0.5248102571265468d, c: 0.5970047930463361d),

new NpgsqlTypes.NpgsqlLine(a: 0.8662392823605177d, b: 0.977941959127113d, c: 0.17447913041797924d),

new NpgsqlTypes.NpgsqlLine(a: 0.23874472619855203d, b: 0.5144134467892139d, c: 0.7328296646308223d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28984204375824363d, b: 0.2679705739893785d, c: 0.14325596544182628d),

new NpgsqlTypes.NpgsqlLine(a: 0.23231615720989196d, b: 0.4850194457270427d, c: 0.16681996315771364d),

new NpgsqlTypes.NpgsqlLine(a: 0.08089941021510982d, b: 0.1438674254670148d, c: 0.9688935525746983d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5914084247801237d, b: 0.05759484892995115d, c: 0.6917293277813112d),

new NpgsqlTypes.NpgsqlLine(a: 0.6246273249955229d, b: 0.4183833791832344d, c: 0.6451229466405108d),

new NpgsqlTypes.NpgsqlLine(a: 0.5560142407267904d, b: 0.7927624793835374d, c: 0.03577813595017176d),

new NpgsqlTypes.NpgsqlLine(a: 0.6750708077470082d, b: 0.8234417794581688d, c: 0.13449156467732704d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8008915615192436d, b: 0.33901457227793386d, c: 0.3975258427735643d),

new NpgsqlTypes.NpgsqlLine(a: 0.45957248647703464d, b: 0.2996603037970408d, c: 0.6071470565063359d),

new NpgsqlTypes.NpgsqlLine(a: 0.4426553736153176d, b: 0.38998731313363044d, c: 0.1969638888160713d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.350337841703492d, b: 0.9357838975383395d, c: 0.5252624331277436d),

new NpgsqlTypes.NpgsqlLine(a: 0.17476806396709677d, b: 0.0012656263770065568d, c: 0.8917513659342298d),

new NpgsqlTypes.NpgsqlLine(a: 0.07156113180610901d, b: 0.23131001123043438d, c: 0.613157529024839d),

new NpgsqlTypes.NpgsqlLine(a: 0.007901044381124822d, b: 0.4616942917728115d, c: 0.43775996902281944d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03626426131210181d, b: 0.10850591500477202d, c: 0.5746039269074772d),

new NpgsqlTypes.NpgsqlLine(a: 0.053862811648511366d, b: 0.6641395798031787d, c: 0.9823734744032661d),

new NpgsqlTypes.NpgsqlLine(a: 0.8381518106684066d, b: 0.9947643576892538d, c: 0.2329855259030975d),

new NpgsqlTypes.NpgsqlLine(a: 0.8060099361922435d, b: 0.21465009075050545d, c: 0.4026696196378541d),

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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 49;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 109, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 137, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 167, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 161, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 156, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 35, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 137, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 75, 27))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[34], false);
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

