

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24664787332257365d, b: 0.6682785504042501d, c: 0.05700563153281257d),

new NpgsqlTypes.NpgsqlLine(a: 0.4764169343615423d, b: 0.9736132189259286d, c: 0.8595725801079638d),

new NpgsqlTypes.NpgsqlLine(a: 0.12679489595426618d, b: 0.04245905743299161d, c: 0.6667319486159048d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07238404558622602d, b: 0.11061678912447259d, c: 0.6005787151471864d),

new NpgsqlTypes.NpgsqlLine(a: 0.2857793862113105d, b: 0.691539267406219d, c: 0.8032657636523065d),

new NpgsqlTypes.NpgsqlLine(a: 0.12993948797763344d, b: 0.2936733685619274d, c: 0.011292737304542833d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17234873684602348d, b: 0.7557728339627817d, c: 0.950313300335456d),

new NpgsqlTypes.NpgsqlLine(a: 0.5961739816298788d, b: 0.01684319051571992d, c: 0.12581544934714917d),

new NpgsqlTypes.NpgsqlLine(a: 0.36610350921484835d, b: 0.9017864047080337d, c: 0.6998977453578511d),

new NpgsqlTypes.NpgsqlLine(a: 0.8807427264111356d, b: 0.3769527525803784d, c: 0.6162243054972768d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2667929646920476d, b: 0.5498368868978135d, c: 0.977381579630691d),

new NpgsqlTypes.NpgsqlLine(a: 0.9795999225658097d, b: 0.15166064335667018d, c: 0.026037600515304016d),

new NpgsqlTypes.NpgsqlLine(a: 0.03275851016126674d, b: 0.0722151055291882d, c: 0.7013263878714785d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.34754735273105963d, b: 0.7233044665950835d, c: 0.4411946743831201d),

new NpgsqlTypes.NpgsqlLine(a: 0.2936743840149111d, b: 0.8131569995158159d, c: 0.31406697896792457d),

new NpgsqlTypes.NpgsqlLine(a: 0.1994952599305665d, b: 0.5979520032686193d, c: 0.4390828030144186d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26187923680754577d, b: 0.06373077053547271d, c: 0.27885072304909053d),

new NpgsqlTypes.NpgsqlLine(a: 0.9987674715057101d, b: 0.33402817938114826d, c: 0.33058104245202447d),

new NpgsqlTypes.NpgsqlLine(a: 0.9538009841620733d, b: 0.041208156175743804d, c: 0.1119829950175989d),

new NpgsqlTypes.NpgsqlLine(a: 0.16657278965163125d, b: 0.9254910818047999d, c: 0.17623684680868879d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5583151826255573d, b: 0.1172421075820933d, c: 0.9354783141889406d),

new NpgsqlTypes.NpgsqlLine(a: 0.19654906957096263d, b: 0.11016651506456421d, c: 0.31790169757128073d),

new NpgsqlTypes.NpgsqlLine(a: 0.4589618538199769d, b: 0.10521150239786825d, c: 0.8419557255942924d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6255801233975422d, b: 0.37635426229353064d, c: 0.8716301889721729d),

new NpgsqlTypes.NpgsqlLine(a: 0.9995242066023485d, b: 0.4736351474061351d, c: 0.461664201373437d),

new NpgsqlTypes.NpgsqlLine(a: 0.43781885845123913d, b: 0.4442046902724983d, c: 0.9173080491291836d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23118135584164445d, b: 0.7186298974992954d, c: 0.2751910542949957d),

new NpgsqlTypes.NpgsqlLine(a: 0.43701429889752363d, b: 0.2255253963882623d, c: 0.49303876198835395d),

new NpgsqlTypes.NpgsqlLine(a: 0.09040011366492418d, b: 0.11508607523194203d, c: 0.7074209099430788d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4436308536502047d, b: 0.011417222799726234d, c: 0.5369278480337342d),

new NpgsqlTypes.NpgsqlLine(a: 0.5536893348568727d, b: 0.7910136250821648d, c: 0.29200088189294016d),

new NpgsqlTypes.NpgsqlLine(a: 0.8779385835223508d, b: 0.3955092032783264d, c: 0.29173779783982823d),

new NpgsqlTypes.NpgsqlLine(a: 0.5816308628491633d, b: 0.1541300180505919d, c: 0.4761924020149272d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4072231408859941d, b: 0.14728438379719322d, c: 0.012485856012171448d),

new NpgsqlTypes.NpgsqlLine(a: 0.9995413520601006d, b: 0.7507756207547056d, c: 0.9798795362013981d),

new NpgsqlTypes.NpgsqlLine(a: 0.5211661783084913d, b: 0.4490951477957247d, c: 0.973378529871321d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5119150771253369d, b: 0.8782894911926924d, c: 0.7436801784987358d),

new NpgsqlTypes.NpgsqlLine(a: 0.745346821559623d, b: 0.29592481515297264d, c: 0.5088524802984518d),

new NpgsqlTypes.NpgsqlLine(a: 0.020695089003269107d, b: 0.9621331821781173d, c: 0.5906503251307986d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5330274105732612d, b: 0.4415164068770179d, c: 0.8150798000681392d),

new NpgsqlTypes.NpgsqlLine(a: 0.24482963611090547d, b: 0.747614994566312d, c: 0.44164470261177724d),

new NpgsqlTypes.NpgsqlLine(a: 0.9013505991880825d, b: 0.1377149737861053d, c: 0.5242816944444315d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8705032443429919d, b: 0.1322567267099234d, c: 0.7387488194265316d),

new NpgsqlTypes.NpgsqlLine(a: 0.7789911463808286d, b: 0.9065460617790003d, c: 0.03762223070810167d),

new NpgsqlTypes.NpgsqlLine(a: 0.08870831599008566d, b: 0.4527768485764474d, c: 0.46835248553165854d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15641137698585694d, b: 0.669207129147094d, c: 0.4917306172281053d),

new NpgsqlTypes.NpgsqlLine(a: 0.9826889783850866d, b: 0.6143026004057552d, c: 0.2297268708210949d),

new NpgsqlTypes.NpgsqlLine(a: 0.17781613021527876d, b: 0.27236900065008984d, c: 0.8154188048217477d),

new NpgsqlTypes.NpgsqlLine(a: 0.180482255705256d, b: 0.7328511450244257d, c: 0.5522900827315881d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2619451223605337d, b: 0.4756883403152852d, c: 0.27660296847135024d),

new NpgsqlTypes.NpgsqlLine(a: 0.1555937030265414d, b: 0.2461660262888471d, c: 0.35074559583262954d),

new NpgsqlTypes.NpgsqlLine(a: 0.21285139295855238d, b: 0.7636412482271124d, c: 0.6872459651045685d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8602927614124427d, b: 0.9406731223957491d, c: 0.05069416824216755d),

new NpgsqlTypes.NpgsqlLine(a: 0.576092543713228d, b: 0.5749456432811105d, c: 0.22889523617886387d),

new NpgsqlTypes.NpgsqlLine(a: 0.9393702335054077d, b: 0.5436769675642575d, c: 0.11369250251642427d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6469190552614252d, b: 0.02994758206347392d, c: 0.35271345354230543d),

new NpgsqlTypes.NpgsqlLine(a: 0.2522775793037322d, b: 0.1854111772972522d, c: 0.32388662764242737d),

new NpgsqlTypes.NpgsqlLine(a: 0.5020571795001079d, b: 0.9135480511660872d, c: 0.5974036797110096d),

new NpgsqlTypes.NpgsqlLine(a: 0.6262175235622982d, b: 0.09540961785752433d, c: 0.15960087007755663d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1439010056973753d, b: 0.11982853895488732d, c: 0.6800860350225414d),

new NpgsqlTypes.NpgsqlLine(a: 0.5866176850402403d, b: 0.9854480747001747d, c: 0.37225320733855416d),

new NpgsqlTypes.NpgsqlLine(a: 0.6523469342186066d, b: 0.02465556208664521d, c: 0.5147732203188553d),

new NpgsqlTypes.NpgsqlLine(a: 0.891246804793575d, b: 0.9495095484851828d, c: 0.6872992230245761d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4458606586184607d, b: 0.21405230092257999d, c: 0.413648158566678d),

new NpgsqlTypes.NpgsqlLine(a: 0.9038730131765912d, b: 0.14427300233270224d, c: 0.246279317269396d),

new NpgsqlTypes.NpgsqlLine(a: 0.03409769409448982d, b: 0.08936993728433351d, c: 0.41387209960978266d),

new NpgsqlTypes.NpgsqlLine(a: 0.7594389119077897d, b: 0.5748650592901956d, c: 0.10535841856868877d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19560161902487905d, b: 0.41811338640835893d, c: 0.8823077486547002d),

new NpgsqlTypes.NpgsqlLine(a: 0.6943240311848108d, b: 0.7655183363339599d, c: 0.3357089175864415d),

new NpgsqlTypes.NpgsqlLine(a: 0.1112126724556437d, b: 0.6121877264236689d, c: 0.5896665247190959d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6714540360345641d, b: 0.0392012158766909d, c: 0.7262385359903195d),

new NpgsqlTypes.NpgsqlLine(a: 0.08258959978277547d, b: 0.20746644009245352d, c: 0.7873763795192879d),

new NpgsqlTypes.NpgsqlLine(a: 0.1908519024331944d, b: 0.11274705145714115d, c: 0.13603633548793792d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05011656084362004d, b: 0.6531931449781045d, c: 0.5237327007566182d),

new NpgsqlTypes.NpgsqlLine(a: 0.20097064152728683d, b: 0.8089821802384081d, c: 0.8456063949001196d),

new NpgsqlTypes.NpgsqlLine(a: 0.927494087839441d, b: 0.9294063755221567d, c: 0.037667038130519415d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0240384172037158d, b: 0.4409029696498067d, c: 0.9219929454704717d),

new NpgsqlTypes.NpgsqlLine(a: 0.08806332723561172d, b: 0.41126509737925765d, c: 0.7154306293819982d),

new NpgsqlTypes.NpgsqlLine(a: 0.9933280773792855d, b: 0.7640990130377159d, c: 0.5087204304374998d),

new NpgsqlTypes.NpgsqlLine(a: 0.8748166135738857d, b: 0.12227300849951583d, c: 0.5834730677272684d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5094863620468515d, b: 0.3066436759374245d, c: 0.19925600636368346d),

new NpgsqlTypes.NpgsqlLine(a: 0.9243492867975501d, b: 0.19585618703971208d, c: 0.4512992491119464d),

new NpgsqlTypes.NpgsqlLine(a: 0.6851412977708422d, b: 0.8063140656345804d, c: 0.35900604112347345d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37208024023782993d, b: 0.6648983498968399d, c: 0.6049886761523023d),

new NpgsqlTypes.NpgsqlLine(a: 0.6405355096836268d, b: 0.7724371209186975d, c: 0.628238432819654d),

new NpgsqlTypes.NpgsqlLine(a: 0.7418608930059807d, b: 0.9627239085237211d, c: 0.976441190960292d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26946536656249054d, b: 0.14939686744317715d, c: 0.3994323743414734d),

new NpgsqlTypes.NpgsqlLine(a: 0.08222073386360074d, b: 0.18504599426129043d, c: 0.23297882092840272d),

new NpgsqlTypes.NpgsqlLine(a: 0.7579601286161496d, b: 0.18965533402645285d, c: 0.5019896345023264d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6936443252438262d, b: 0.5867906996471132d, c: 0.2343268180011714d),

new NpgsqlTypes.NpgsqlLine(a: 0.830321810035254d, b: 0.5917501413777059d, c: 0.2295293908049244d),

new NpgsqlTypes.NpgsqlLine(a: 0.38040521711227815d, b: 0.05454921166352844d, c: 0.6300914481974322d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4675104245738828d, b: 0.5051559327442054d, c: 0.3521843730726356d),

new NpgsqlTypes.NpgsqlLine(a: 0.370897590519757d, b: 0.40218404759326043d, c: 0.31006761734173904d),

new NpgsqlTypes.NpgsqlLine(a: 0.25948349060281406d, b: 0.02250580512100575d, c: 0.005095487554737543d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3603333011042623d, b: 0.4003178062621301d, c: 0.8057679360810491d),

new NpgsqlTypes.NpgsqlLine(a: 0.2890815780510997d, b: 0.33075841839701214d, c: 0.7437812008884604d),

new NpgsqlTypes.NpgsqlLine(a: 0.18431074715685347d, b: 0.3027981418099057d, c: 0.4567213749078367d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6598145616007757d, b: 0.2608644015621111d, c: 0.08618772104139327d),

new NpgsqlTypes.NpgsqlLine(a: 0.40416899409692186d, b: 0.41216662718641994d, c: 0.12822273019993657d),

new NpgsqlTypes.NpgsqlLine(a: 0.8025447519719885d, b: 0.05610358000488491d, c: 0.2828169691416621d),

new NpgsqlTypes.NpgsqlLine(a: 0.9455900373402508d, b: 0.928151693664225d, c: 0.5480753654497146d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11399378753661915d, b: 0.3153489120861668d, c: 0.9542981738656523d),

new NpgsqlTypes.NpgsqlLine(a: 0.1865174638359115d, b: 0.3627762384410832d, c: 0.9820587407033101d),

new NpgsqlTypes.NpgsqlLine(a: 0.97962669763209d, b: 0.1479876677342412d, c: 0.9583748332157365d),

new NpgsqlTypes.NpgsqlLine(a: 0.15334980310066904d, b: 0.44705215789460695d, c: 0.4105610071506992d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7551128636348806d, b: 0.7238299821169266d, c: 0.7882552803571078d),

new NpgsqlTypes.NpgsqlLine(a: 0.4881926960444126d, b: 0.8681220799219016d, c: 0.3284598325507898d),

new NpgsqlTypes.NpgsqlLine(a: 0.4436733389823736d, b: 0.09173742534198037d, c: 0.9778999740164507d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15488026399296062d, b: 0.20590403814402813d, c: 0.3247427794425114d),

new NpgsqlTypes.NpgsqlLine(a: 0.9047686364587723d, b: 0.13933159901495384d, c: 0.10493634353238024d),

new NpgsqlTypes.NpgsqlLine(a: 0.10137916054030871d, b: 0.3821340815176203d, c: 0.17896278790049813d),

new NpgsqlTypes.NpgsqlLine(a: 0.051168747275234905d, b: 0.2540050481682332d, c: 0.5932126571218128d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8783610655807008d, b: 0.6596972416838448d, c: 0.25538713548340997d),

new NpgsqlTypes.NpgsqlLine(a: 0.9201984677525734d, b: 0.19125014483877723d, c: 0.5315733276474535d),

new NpgsqlTypes.NpgsqlLine(a: 0.04937440321582631d, b: 0.15708364093580585d, c: 0.6764566017164547d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45545531806255124d, b: 0.01327819211225889d, c: 0.5652351827416364d),

new NpgsqlTypes.NpgsqlLine(a: 0.0665977175302056d, b: 0.5322701198047296d, c: 0.38844037636092354d),

new NpgsqlTypes.NpgsqlLine(a: 0.3206588708427127d, b: 0.8436908082359066d, c: 0.5989712510126973d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6643151325406641d, b: 0.21060846346451478d, c: 0.6342450789076213d),

new NpgsqlTypes.NpgsqlLine(a: 0.6371654968132864d, b: 0.3965784339524464d, c: 0.786978066897844d),

new NpgsqlTypes.NpgsqlLine(a: 0.4491869720845181d, b: 0.38441634170615635d, c: 0.6999415566102948d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8763462160539455d, b: 0.7526834055545153d, c: 0.5225862240722126d),

new NpgsqlTypes.NpgsqlLine(a: 0.3057417752490733d, b: 0.3771887259323552d, c: 0.38228212024372166d),

new NpgsqlTypes.NpgsqlLine(a: 0.08788139243714754d, b: 0.4278452517432083d, c: 0.23914027019731698d),

new NpgsqlTypes.NpgsqlLine(a: 0.7041477387660139d, b: 0.9031473030329796d, c: 0.3807562821847785d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46416574005352906d, b: 0.00400125354449854d, c: 0.7031760116193428d),

new NpgsqlTypes.NpgsqlLine(a: 0.7758761415946602d, b: 0.6025781093402224d, c: 0.8945107671935097d),

new NpgsqlTypes.NpgsqlLine(a: 0.9437203438421006d, b: 0.2749982261735623d, c: 0.12833085348963125d),

new NpgsqlTypes.NpgsqlLine(a: 0.06430455066281426d, b: 0.48506670962738263d, c: 0.5360192377607448d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5897964297632774d, b: 0.1453673350067548d, c: 0.12281044086565929d),

new NpgsqlTypes.NpgsqlLine(a: 0.728770217918775d, b: 0.01006513274094667d, c: 0.293543210510794d),

new NpgsqlTypes.NpgsqlLine(a: 0.9772851635343246d, b: 0.013944708009568485d, c: 0.42261608256978234d),

new NpgsqlTypes.NpgsqlLine(a: 0.3375352907528314d, b: 0.5644142315574969d, c: 0.3262556461195988d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44588071757454506d, b: 0.7731631421232431d, c: 0.35283588325143556d),

new NpgsqlTypes.NpgsqlLine(a: 0.5270553915475735d, b: 0.25657290881464023d, c: 0.43349395198283336d),

new NpgsqlTypes.NpgsqlLine(a: 0.5544131664594799d, b: 0.3680562239181471d, c: 0.6481692532992374d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7412952750999869d, b: 0.9882394461020012d, c: 0.7239582443238758d),

new NpgsqlTypes.NpgsqlLine(a: 0.5657585558304582d, b: 0.042429116093665065d, c: 0.8796240499405141d),

new NpgsqlTypes.NpgsqlLine(a: 0.23513966368824513d, b: 0.08780113939700507d, c: 0.22019165977374988d),

new NpgsqlTypes.NpgsqlLine(a: 0.13563755493348395d, b: 0.1572040904873666d, c: 0.9279668862760228d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5309714781030371d, b: 0.7441768828269734d, c: 0.8071533478936922d),

new NpgsqlTypes.NpgsqlLine(a: 0.6527709128415765d, b: 0.6800268559648598d, c: 0.8455853532694061d),

new NpgsqlTypes.NpgsqlLine(a: 0.02717639647986847d, b: 0.9399995464197973d, c: 0.262085499897419d),

new NpgsqlTypes.NpgsqlLine(a: 0.7309011127265415d, b: 0.4914489442969818d, c: 0.9836126082541319d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8863396569856979d, b: 0.5078156664983137d, c: 0.9973010227991044d),

new NpgsqlTypes.NpgsqlLine(a: 0.8247291495515702d, b: 0.3826325507879187d, c: 0.7738321309671813d),

new NpgsqlTypes.NpgsqlLine(a: 0.9192571766856056d, b: 0.4725924165190719d, c: 0.6739296811597586d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2690716858127423d, b: 0.9542762706235048d, c: 0.7804594735264855d),

new NpgsqlTypes.NpgsqlLine(a: 0.6598535125429046d, b: 0.8766397418833524d, c: 0.13687430716777005d),

new NpgsqlTypes.NpgsqlLine(a: 0.09795573822554937d, b: 0.4393536593185293d, c: 0.8644342921178523d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9392704619183257d, b: 0.1191569767679157d, c: 0.7843398018222593d),

new NpgsqlTypes.NpgsqlLine(a: 0.9254631573300295d, b: 0.7012034804589864d, c: 0.5277655575921637d),

new NpgsqlTypes.NpgsqlLine(a: 0.7757801279860533d, b: 0.050121617786179296d, c: 0.15250107420900272d),

new NpgsqlTypes.NpgsqlLine(a: 0.1421196207704264d, b: 0.9064113901340376d, c: 0.8318580001350713d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7698842448349176d, b: 0.21164752604405823d, c: 0.024966740735112847d),

new NpgsqlTypes.NpgsqlLine(a: 0.2500220489913675d, b: 0.2146447788775071d, c: 0.7675502059271003d),

new NpgsqlTypes.NpgsqlLine(a: 0.3306414784619024d, b: 0.4419367321740718d, c: 0.029936560924114564d),

new NpgsqlTypes.NpgsqlLine(a: 0.857986893400657d, b: 0.03594271830150919d, c: 0.8382212636043815d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10981658987583331d, b: 0.9183783273116671d, c: 0.4443790681737506d),

new NpgsqlTypes.NpgsqlLine(a: 0.9892629693570492d, b: 0.01193750949455108d, c: 0.36571545571260633d),

new NpgsqlTypes.NpgsqlLine(a: 0.43696585572667956d, b: 0.1383097741773034d, c: 0.602350753942269d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9543883094498307d, b: 0.7427236603455696d, c: 0.9269065311562614d),

new NpgsqlTypes.NpgsqlLine(a: 0.5942968755107904d, b: 0.021085124393603438d, c: 0.13383366220571846d),

new NpgsqlTypes.NpgsqlLine(a: 0.6935829282387994d, b: 0.9322166174233729d, c: 0.6061736297284634d),

new NpgsqlTypes.NpgsqlLine(a: 0.11869385204394989d, b: 0.8942991688370603d, c: 0.5155096223798735d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3907560025863118d, b: 0.08428991126429031d, c: 0.44688701706014866d),

new NpgsqlTypes.NpgsqlLine(a: 0.21823409517892145d, b: 0.6773572790782588d, c: 0.7899030879564778d),

new NpgsqlTypes.NpgsqlLine(a: 0.5160707327216992d, b: 0.7532967728791089d, c: 0.38421210246831816d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9970628923217455d, b: 0.24744673497007663d, c: 0.9644434936410023d),

new NpgsqlTypes.NpgsqlLine(a: 0.8637857905800587d, b: 0.24706472681474445d, c: 0.2988111179650804d),

new NpgsqlTypes.NpgsqlLine(a: 0.29937136335766634d, b: 0.1113839167288535d, c: 0.386180831453933d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7163357298108979d, b: 0.851845770112392d, c: 0.639961724084481d),

new NpgsqlTypes.NpgsqlLine(a: 0.7124458611383198d, b: 0.5105474263887695d, c: 0.9628621554683837d),

new NpgsqlTypes.NpgsqlLine(a: 0.3894464379379212d, b: 0.25138110264214497d, c: 0.7825834568776315d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7841135855086895d, b: 0.09052127594764214d, c: 0.7239807352207145d),

new NpgsqlTypes.NpgsqlLine(a: 0.29634447674327813d, b: 0.48582081949632383d, c: 0.2006820208068767d),

new NpgsqlTypes.NpgsqlLine(a: 0.9536283389096106d, b: 0.8077978451992605d, c: 0.8992526742236587d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8208559278712104d, b: 0.5862639995825562d, c: 0.13857975528752908d),

new NpgsqlTypes.NpgsqlLine(a: 0.3897350661359159d, b: 0.15861163567695402d, c: 0.1570602772335371d),

new NpgsqlTypes.NpgsqlLine(a: 0.03632456646351878d, b: 0.9339183096186845d, c: 0.6654199390584432d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11387222190064206d, b: 0.5313962206108492d, c: 0.9945252806662146d),

new NpgsqlTypes.NpgsqlLine(a: 0.5354818298006918d, b: 0.9633234734977741d, c: 0.5014496007251206d),

new NpgsqlTypes.NpgsqlLine(a: 0.1849939917811959d, b: 0.6613991124516583d, c: 0.722422479497433d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5873675945294564d, b: 0.6157824460513973d, c: 0.5874923414309584d),

new NpgsqlTypes.NpgsqlLine(a: 0.24221225259191292d, b: 0.9307813650377753d, c: 0.1997868417190708d),

new NpgsqlTypes.NpgsqlLine(a: 0.6815502845898795d, b: 0.7723981468951239d, c: 0.979200723029981d),

new NpgsqlTypes.NpgsqlLine(a: 0.8934361498100405d, b: 0.17089602689355077d, c: 0.33747369663231763d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39458730187875624d, b: 0.5205790078864048d, c: 0.024945158542231227d),

new NpgsqlTypes.NpgsqlLine(a: 0.5348924060116528d, b: 0.49638257968292643d, c: 0.1711404176459751d),

new NpgsqlTypes.NpgsqlLine(a: 0.6385630820898214d, b: 0.9483177784174228d, c: 0.3747001507518166d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24113726181396544d, b: 0.5445592874153758d, c: 0.39137806074685555d),

new NpgsqlTypes.NpgsqlLine(a: 0.7483706294254557d, b: 0.1387709310661187d, c: 0.0639494881457291d),

new NpgsqlTypes.NpgsqlLine(a: 0.49474091581938673d, b: 0.783417232814455d, c: 0.8034718599276807d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5906670903601013d, b: 0.6736849350327274d, c: 0.15784779628214662d),

new NpgsqlTypes.NpgsqlLine(a: 0.4179891252968351d, b: 0.5034933117266693d, c: 0.12979274160695198d),

new NpgsqlTypes.NpgsqlLine(a: 0.8430462920360924d, b: 0.5457798893511222d, c: 0.5639891290363616d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5646850965373961d, b: 0.5350326508902606d, c: 0.5140634509715936d),

new NpgsqlTypes.NpgsqlLine(a: 0.050478520882760725d, b: 0.5017547219083163d, c: 0.23812364632549887d),

new NpgsqlTypes.NpgsqlLine(a: 0.3143758042067587d, b: 0.3737947651272493d, c: 0.49835668242207287d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1355493941506689d, b: 0.7276008176328621d, c: 0.15035452875040367d),

new NpgsqlTypes.NpgsqlLine(a: 0.6174564309741061d, b: 0.21373330191297735d, c: 0.8083555139925855d),

new NpgsqlTypes.NpgsqlLine(a: 0.8995027459393268d, b: 0.7078275585498549d, c: 0.14880518582244828d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9163676683453568d, b: 0.9200880709155388d, c: 0.9033269050772094d),

new NpgsqlTypes.NpgsqlLine(a: 0.6097920005463958d, b: 0.5124884281139426d, c: 0.7030305602877912d),

new NpgsqlTypes.NpgsqlLine(a: 0.7648210419857908d, b: 0.9574496267603788d, c: 0.9946296891672439d),

new NpgsqlTypes.NpgsqlLine(a: 0.9803488037075635d, b: 0.962817950952919d, c: 0.06835326036625267d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7431807383675437d, b: 0.1336436383396501d, c: 0.705437780574758d),

new NpgsqlTypes.NpgsqlLine(a: 0.8604565805424905d, b: 0.038465235817829346d, c: 0.6947029765968957d),

new NpgsqlTypes.NpgsqlLine(a: 0.22870344642805496d, b: 0.6194603419181599d, c: 0.7514362515265076d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6865457166286658d, b: 0.20010940068673921d, c: 0.9924946659695637d),

new NpgsqlTypes.NpgsqlLine(a: 0.22998870338654331d, b: 0.691690823700218d, c: 0.929889193007168d),

new NpgsqlTypes.NpgsqlLine(a: 0.4841769688568438d, b: 0.5993260019359485d, c: 0.412002873108399d),

new NpgsqlTypes.NpgsqlLine(a: 0.5928232426908259d, b: 0.1720525927472506d, c: 0.4564116607490708d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.706910036278998d, b: 0.5464883452013864d, c: 0.1722519628826309d),

new NpgsqlTypes.NpgsqlLine(a: 0.049450997659707396d, b: 0.009150987351063455d, c: 0.6144847753610336d),

new NpgsqlTypes.NpgsqlLine(a: 0.12444199126844457d, b: 0.157436533563309d, c: 0.8998534219528485d),

new NpgsqlTypes.NpgsqlLine(a: 0.646175898124913d, b: 0.3808237804317737d, c: 0.7863642554463844d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6087579809890823d, b: 0.9970346141663889d, c: 0.06769135026657347d),

new NpgsqlTypes.NpgsqlLine(a: 0.3248725098495241d, b: 0.16213612602908956d, c: 0.07552207221290363d),

new NpgsqlTypes.NpgsqlLine(a: 0.6285989524072594d, b: 0.49929747391972057d, c: 0.4515911994448909d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9946881487044298d, b: 0.4452980584552819d, c: 0.21180013434017353d),

new NpgsqlTypes.NpgsqlLine(a: 0.5320563394761435d, b: 0.6450106755208064d, c: 0.5747905325655005d),

new NpgsqlTypes.NpgsqlLine(a: 0.8818733319648601d, b: 0.23039599951587553d, c: 0.21770123833934052d),

new NpgsqlTypes.NpgsqlLine(a: 0.4750364965539947d, b: 0.5669155746966832d, c: 0.7197864749524543d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1950207510020443d, b: 0.08097813831557821d, c: 0.5486173601161681d),

new NpgsqlTypes.NpgsqlLine(a: 0.9164267878401225d, b: 0.03216162999978345d, c: 0.9223358108964994d),

new NpgsqlTypes.NpgsqlLine(a: 0.10999801710617196d, b: 0.11183502214852992d, c: 0.679249856041442d),

new NpgsqlTypes.NpgsqlLine(a: 0.4434405200996958d, b: 0.8332822199769294d, c: 0.1226209279741215d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04593706290857724d, b: 0.7052225876475442d, c: 0.9381113064515454d),

new NpgsqlTypes.NpgsqlLine(a: 0.35148635597392586d, b: 0.9195529814975854d, c: 0.4698382823912399d),

new NpgsqlTypes.NpgsqlLine(a: 0.016451035079900755d, b: 0.8579083023421611d, c: 0.45750490849729575d),

new NpgsqlTypes.NpgsqlLine(a: 0.1786783528633049d, b: 0.7859903381593972d, c: 0.9513098228668699d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35212020896221974d, b: 0.3531174041107421d, c: 0.14739149552518271d),

new NpgsqlTypes.NpgsqlLine(a: 0.3354129624722515d, b: 0.09643272089709387d, c: 0.09621832022130872d),

new NpgsqlTypes.NpgsqlLine(a: 0.4336139528931662d, b: 0.419347241232886d, c: 0.6471120936330789d),

new NpgsqlTypes.NpgsqlLine(a: 0.8083009850334187d, b: 0.49409815959064707d, c: 0.9331723488094438d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8807531700703805d, b: 0.1598998726371772d, c: 0.9995314636870322d),

new NpgsqlTypes.NpgsqlLine(a: 0.7071184445920276d, b: 0.7690087017895763d, c: 0.23381588218864446d),

new NpgsqlTypes.NpgsqlLine(a: 0.942490251807233d, b: 0.0917741257960778d, c: 0.08649012549941648d),

new NpgsqlTypes.NpgsqlLine(a: 0.9166344173929483d, b: 0.3528883366036272d, c: 0.08666939027490694d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21255171622182567d, b: 0.6000275017448918d, c: 0.7166827116161044d),

new NpgsqlTypes.NpgsqlLine(a: 0.8696224242908759d, b: 0.45424873453443104d, c: 0.7770081132528891d),

new NpgsqlTypes.NpgsqlLine(a: 0.30448321055354144d, b: 0.4803217546421551d, c: 0.5494579261724701d),

new NpgsqlTypes.NpgsqlLine(a: 0.6257983126852449d, b: 0.2420328001866514d, c: 0.30928610189951167d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20714046326546587d, b: 0.5088971122146209d, c: 0.16724562259389053d),

new NpgsqlTypes.NpgsqlLine(a: 0.8768109685581214d, b: 0.3085814098283547d, c: 0.17685080100435335d),

new NpgsqlTypes.NpgsqlLine(a: 0.756788813185702d, b: 0.19109818318880634d, c: 0.6901017954602369d),

new NpgsqlTypes.NpgsqlLine(a: 0.8901846339142298d, b: 0.5937269931363234d, c: 0.8556021309252321d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6845004886298143d, b: 0.4472426991476557d, c: 0.9030339575760495d),

new NpgsqlTypes.NpgsqlLine(a: 0.6387546193805929d, b: 0.7619039883964195d, c: 0.5217285019253186d),

new NpgsqlTypes.NpgsqlLine(a: 0.6150200760246456d, b: 0.7762016631935573d, c: 0.020934725090182238d),

new NpgsqlTypes.NpgsqlLine(a: 0.07901302971894852d, b: 0.6926300704740654d, c: 0.8643366605360748d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31889862823824733d, b: 0.6938740733414923d, c: 0.6582820319691862d),

new NpgsqlTypes.NpgsqlLine(a: 0.9240587065164138d, b: 0.856555793850909d, c: 0.5072798632430998d),

new NpgsqlTypes.NpgsqlLine(a: 0.5752773976369526d, b: 0.25537105076975897d, c: 0.899880340779041d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9822970137377042d, b: 0.3360983710235499d, c: 0.36904893878402445d),

new NpgsqlTypes.NpgsqlLine(a: 0.9811380268019115d, b: 0.40814929498573094d, c: 0.42868080793508123d),

new NpgsqlTypes.NpgsqlLine(a: 0.42094371791420926d, b: 0.7491883238914318d, c: 0.12365546355555346d),

new NpgsqlTypes.NpgsqlLine(a: 0.0035602127945055795d, b: 0.781550973289881d, c: 0.6709591294290631d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6750842104424568d, b: 0.9962479131446927d, c: 0.7318211011374298d),

new NpgsqlTypes.NpgsqlLine(a: 0.39762341716552463d, b: 0.03515891488472578d, c: 0.6909708774488658d),

new NpgsqlTypes.NpgsqlLine(a: 0.2580771839088175d, b: 0.20785881453363353d, c: 0.5256857799997942d),

new NpgsqlTypes.NpgsqlLine(a: 0.2887479061831364d, b: 0.8829063749446484d, c: 0.0355978343869795d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 201,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7355766628811496d, b: 0.22748214500201347d, c: 0.07598375738473973d),

new NpgsqlTypes.NpgsqlLine(a: 0.2420523129319716d, b: 0.4673985521695576d, c: 0.5115815028658008d),

new NpgsqlTypes.NpgsqlLine(a: 0.4003678423571606d, b: 0.2607190861953985d, c: 0.23616718376912083d),

new NpgsqlTypes.NpgsqlLine(a: 0.3840402849205016d, b: 0.19789151566635532d, c: 0.32464033336898457d),

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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 174, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 174, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 188, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 174, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 128, query2))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 78, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 188, query2))
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
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 156, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 168, 181))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 158, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[34], false);
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

