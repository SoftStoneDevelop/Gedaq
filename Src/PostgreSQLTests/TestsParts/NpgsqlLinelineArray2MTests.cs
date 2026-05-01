

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7520600898340956d, b: 0.6749586571004763d, c: 0.05982396749505703d),

new NpgsqlTypes.NpgsqlLine(a: 0.6678390273985034d, b: 0.03396354896317477d, c: 0.6016956174872157d),

new NpgsqlTypes.NpgsqlLine(a: 0.7118707860407083d, b: 0.1976619279549645d, c: 0.6511766842932998d),

new NpgsqlTypes.NpgsqlLine(a: 0.4448400581757731d, b: 0.5582414389955268d, c: 0.3846426067298905d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.526027722110424d, b: 0.5685065714442895d, c: 0.8490078441093516d),

new NpgsqlTypes.NpgsqlLine(a: 0.05763882556431821d, b: 0.17784798497520138d, c: 0.24251971351724133d),

new NpgsqlTypes.NpgsqlLine(a: 0.8762969293161922d, b: 0.10766264413236892d, c: 0.3799924041085555d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9579750657285127d, b: 0.4174333111751939d, c: 0.04327085416940879d),

new NpgsqlTypes.NpgsqlLine(a: 0.16531627103532365d, b: 0.4147853860684174d, c: 0.6759968547883011d),

new NpgsqlTypes.NpgsqlLine(a: 0.74411061617468d, b: 0.07720768451998461d, c: 0.9866808357875257d),

new NpgsqlTypes.NpgsqlLine(a: 0.33633276334335294d, b: 0.15377337588098394d, c: 0.9933413167903253d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6724781349771124d, b: 0.3751258947926034d, c: 0.4259047644825579d),

new NpgsqlTypes.NpgsqlLine(a: 0.3447557157273433d, b: 0.11993423022530458d, c: 0.19459084885888323d),

new NpgsqlTypes.NpgsqlLine(a: 0.40124454541431165d, b: 0.9110830414776965d, c: 0.10368135364054898d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07265013733622361d, b: 0.8386620293431074d, c: 0.297132326184944d),

new NpgsqlTypes.NpgsqlLine(a: 0.04115396528097026d, b: 0.4915498898532026d, c: 0.1191087810869268d),

new NpgsqlTypes.NpgsqlLine(a: 0.2304336338106433d, b: 0.5380113533699374d, c: 0.8251323253962016d),

new NpgsqlTypes.NpgsqlLine(a: 0.7685175238468702d, b: 0.7341277004078225d, c: 0.27389347777184136d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5901642866265996d, b: 0.6067429172186267d, c: 0.5443893041659297d),

new NpgsqlTypes.NpgsqlLine(a: 0.2212796289322705d, b: 0.736594232431591d, c: 0.19125510887611785d),

new NpgsqlTypes.NpgsqlLine(a: 0.5453303165583162d, b: 0.7130282869676674d, c: 0.6195332862833114d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.34554067195321514d, b: 0.3321499280437681d, c: 0.47746802863507765d),

new NpgsqlTypes.NpgsqlLine(a: 0.3452204786473252d, b: 0.6766547174627026d, c: 0.942330854071375d),

new NpgsqlTypes.NpgsqlLine(a: 0.5383423258607267d, b: 0.21052903679920287d, c: 0.15855807178201775d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3439546161882404d, b: 0.9771772322331577d, c: 0.45853356153930447d),

new NpgsqlTypes.NpgsqlLine(a: 0.8231705389224058d, b: 0.9162411141831491d, c: 0.5644651082254617d),

new NpgsqlTypes.NpgsqlLine(a: 0.1910215915690292d, b: 0.7926824520513883d, c: 0.8634264895494544d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5972714122032302d, b: 0.2614255279904929d, c: 0.6814449274434473d),

new NpgsqlTypes.NpgsqlLine(a: 0.383329658892386d, b: 0.8084780615743705d, c: 0.8985383594446866d),

new NpgsqlTypes.NpgsqlLine(a: 0.6622970186610695d, b: 0.7164515533398503d, c: 0.5299543633529215d),

new NpgsqlTypes.NpgsqlLine(a: 0.6715374701047127d, b: 0.7105516647854769d, c: 0.3075486197486902d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9745735868050543d, b: 0.739498264337089d, c: 0.9439921728624839d),

new NpgsqlTypes.NpgsqlLine(a: 0.8314851228913468d, b: 0.2478235688469086d, c: 0.8604962619897828d),

new NpgsqlTypes.NpgsqlLine(a: 0.5611317994499152d, b: 0.3099654061680054d, c: 0.29893137755432997d),

new NpgsqlTypes.NpgsqlLine(a: 0.21748987788477026d, b: 0.7570075741622563d, c: 0.6441633082476264d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5446064716204168d, b: 0.7490471111526217d, c: 0.5984639885612152d),

new NpgsqlTypes.NpgsqlLine(a: 0.35101788608355555d, b: 0.4132032389454795d, c: 0.010108033699212426d),

new NpgsqlTypes.NpgsqlLine(a: 0.8688038122118494d, b: 0.34958624501708935d, c: 0.4669405769610824d),

new NpgsqlTypes.NpgsqlLine(a: 0.9526160429803257d, b: 0.41984732890347765d, c: 0.9538975930496093d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1610340370402603d, b: 0.23385701448291707d, c: 0.07482330653634994d),

new NpgsqlTypes.NpgsqlLine(a: 0.43653251042471575d, b: 0.6600360908628323d, c: 0.25227606493720856d),

new NpgsqlTypes.NpgsqlLine(a: 0.1775729311960349d, b: 0.40445045037292904d, c: 0.15372807871586747d),

new NpgsqlTypes.NpgsqlLine(a: 0.6623704951367504d, b: 0.9312288700424433d, c: 0.36962973396772125d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.518704192842056d, b: 0.9308214960834041d, c: 0.4009834030286482d),

new NpgsqlTypes.NpgsqlLine(a: 0.17992948976159306d, b: 0.01869855451538205d, c: 0.04704020194336955d),

new NpgsqlTypes.NpgsqlLine(a: 0.5832857438428993d, b: 0.0045843484453450545d, c: 0.8491551379320945d),

new NpgsqlTypes.NpgsqlLine(a: 0.4057511728069637d, b: 0.20163502069698258d, c: 0.4680725719702624d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24134956616728942d, b: 0.34308103849874616d, c: 0.3890743755268331d),

new NpgsqlTypes.NpgsqlLine(a: 0.17673567660016098d, b: 0.9636524932513189d, c: 0.6282308983450602d),

new NpgsqlTypes.NpgsqlLine(a: 0.10702336909322041d, b: 0.5462331219111316d, c: 0.08815641237373872d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35126311210970473d, b: 0.796005263459141d, c: 0.9285823461792378d),

new NpgsqlTypes.NpgsqlLine(a: 0.023987711502684084d, b: 0.7012088998801508d, c: 0.9638100680159479d),

new NpgsqlTypes.NpgsqlLine(a: 0.41687810794502844d, b: 0.6188802060218738d, c: 0.13517335565415178d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8364102395872823d, b: 0.48409770565818966d, c: 0.22587790082304038d),

new NpgsqlTypes.NpgsqlLine(a: 0.9238080050060309d, b: 0.5412264272087274d, c: 0.0015354917410400626d),

new NpgsqlTypes.NpgsqlLine(a: 0.31587463282283534d, b: 0.5562248616608757d, c: 0.9072130310010714d),

new NpgsqlTypes.NpgsqlLine(a: 0.0390553871759316d, b: 0.01691573834843685d, c: 0.171674197092889d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6154045061599043d, b: 0.5250415174375097d, c: 0.8306585008108622d),

new NpgsqlTypes.NpgsqlLine(a: 0.15807773792022783d, b: 0.8294895120566494d, c: 0.17673764273385417d),

new NpgsqlTypes.NpgsqlLine(a: 0.4600431361194153d, b: 0.5674340623371991d, c: 0.5359514395440377d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42123984917696755d, b: 0.20065322795494533d, c: 0.2864960127615984d),

new NpgsqlTypes.NpgsqlLine(a: 0.7531543082800296d, b: 0.5787765438799257d, c: 0.47128578119703124d),

new NpgsqlTypes.NpgsqlLine(a: 0.396572828299222d, b: 0.528804645931952d, c: 0.09609394560481022d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8329412846268891d, b: 0.5285447694361521d, c: 0.6836565642112767d),

new NpgsqlTypes.NpgsqlLine(a: 0.4908647943456872d, b: 0.9320799822166679d, c: 0.7396229691309303d),

new NpgsqlTypes.NpgsqlLine(a: 0.7160980112118384d, b: 0.82897832345035d, c: 0.19147064914028555d),

new NpgsqlTypes.NpgsqlLine(a: 0.544627948760661d, b: 0.24585296278016888d, c: 0.4516410045137985d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.937906357974761d, b: 0.26846845161020216d, c: 0.3392009503976732d),

new NpgsqlTypes.NpgsqlLine(a: 0.23159281820804412d, b: 0.6608521726435339d, c: 0.5306476175107804d),

new NpgsqlTypes.NpgsqlLine(a: 0.7952072370586151d, b: 0.9470726459929506d, c: 0.9630168062116954d),

new NpgsqlTypes.NpgsqlLine(a: 0.7082492291659689d, b: 0.6249218371634115d, c: 0.6473643774470456d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06718735302456136d, b: 0.05907727871261137d, c: 0.8455651101225937d),

new NpgsqlTypes.NpgsqlLine(a: 0.8158880949950209d, b: 0.9629624804308866d, c: 0.45961733971375296d),

new NpgsqlTypes.NpgsqlLine(a: 0.3786831484375738d, b: 0.28359263401765245d, c: 0.23906881228984656d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9874549157085857d, b: 0.36737140699100923d, c: 0.9603124221721258d),

new NpgsqlTypes.NpgsqlLine(a: 0.30578559298363905d, b: 0.8460704175867274d, c: 0.43508084273053604d),

new NpgsqlTypes.NpgsqlLine(a: 0.30496070500525563d, b: 0.9141676267815768d, c: 0.6095444006007835d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5940592104064819d, b: 0.12371228591202599d, c: 0.9538503837420937d),

new NpgsqlTypes.NpgsqlLine(a: 0.13790858740642842d, b: 0.034959555992482905d, c: 0.8253253327474643d),

new NpgsqlTypes.NpgsqlLine(a: 0.7163186258267172d, b: 0.22318442973641972d, c: 0.09488740744380253d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6520101118721532d, b: 0.3383199197610547d, c: 0.4242703495603831d),

new NpgsqlTypes.NpgsqlLine(a: 0.8780593591638269d, b: 0.47059806864166775d, c: 0.6221348941717638d),

new NpgsqlTypes.NpgsqlLine(a: 0.9183405488869213d, b: 0.4883543715878884d, c: 0.20018890529859357d),

new NpgsqlTypes.NpgsqlLine(a: 0.9361779433873655d, b: 0.24217290733221963d, c: 0.5917224034445012d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5595709560329457d, b: 0.14259848469063152d, c: 0.9824861519286227d),

new NpgsqlTypes.NpgsqlLine(a: 0.14850718858068213d, b: 0.9338527818916208d, c: 0.1838020978271967d),

new NpgsqlTypes.NpgsqlLine(a: 0.44530133709282627d, b: 0.7924250251357047d, c: 0.07700468862510668d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4562322569359474d, b: 0.6755704004548718d, c: 0.9681994938607764d),

new NpgsqlTypes.NpgsqlLine(a: 0.2414284643398863d, b: 0.6836600315196042d, c: 0.8001270686247451d),

new NpgsqlTypes.NpgsqlLine(a: 0.9237702611634584d, b: 0.5660537628456547d, c: 0.6026977424790901d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30537766824188584d, b: 0.7056122087782837d, c: 0.3804962590049461d),

new NpgsqlTypes.NpgsqlLine(a: 0.6157877427728717d, b: 0.9113154678051767d, c: 0.592572685987606d),

new NpgsqlTypes.NpgsqlLine(a: 0.4964272984146262d, b: 0.7353439008986572d, c: 0.3387079215883222d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31337092577859194d, b: 0.2976730408545052d, c: 0.6964215257074258d),

new NpgsqlTypes.NpgsqlLine(a: 0.3242497108387534d, b: 0.623466630729725d, c: 0.821112256089902d),

new NpgsqlTypes.NpgsqlLine(a: 0.44738198426173814d, b: 0.7686162551911196d, c: 0.9814476217306022d),

new NpgsqlTypes.NpgsqlLine(a: 0.7825378487218423d, b: 0.3305560546035491d, c: 0.707589110017813d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26098598955112184d, b: 0.5579776526328734d, c: 0.35780716229051834d),

new NpgsqlTypes.NpgsqlLine(a: 0.19339905654260037d, b: 0.20823257743938284d, c: 0.14979909168978545d),

new NpgsqlTypes.NpgsqlLine(a: 0.9581018151497024d, b: 0.9729291238304743d, c: 0.276444281375545d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8173700188778461d, b: 0.513818136976395d, c: 0.2526717608352178d),

new NpgsqlTypes.NpgsqlLine(a: 0.026655513513603846d, b: 0.5869134031747014d, c: 0.012083495150833734d),

new NpgsqlTypes.NpgsqlLine(a: 0.9887046674371729d, b: 0.25160004603056974d, c: 0.23862428016055615d),

new NpgsqlTypes.NpgsqlLine(a: 0.2820682429114947d, b: 0.4701457673510714d, c: 0.34157393842146266d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43107004543897975d, b: 0.8053781824632935d, c: 0.6768685190873042d),

new NpgsqlTypes.NpgsqlLine(a: 0.8001107919173154d, b: 0.1690839410661028d, c: 0.7340194435051521d),

new NpgsqlTypes.NpgsqlLine(a: 0.47325751680206274d, b: 0.670887726072816d, c: 0.2883460556920511d),

new NpgsqlTypes.NpgsqlLine(a: 0.6001495838583051d, b: 0.09872387487109124d, c: 0.13265139381510271d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32541305595797654d, b: 0.5696872770728937d, c: 0.2670024501736319d),

new NpgsqlTypes.NpgsqlLine(a: 0.3793178914756433d, b: 0.41580808081361176d, c: 0.21746005345915498d),

new NpgsqlTypes.NpgsqlLine(a: 0.624079990916626d, b: 0.40880635846611735d, c: 0.8807308419282323d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6544807569162207d, b: 0.9864885723048898d, c: 0.02770727486661173d),

new NpgsqlTypes.NpgsqlLine(a: 0.02372578243818757d, b: 0.43033859725028967d, c: 0.08635037761107167d),

new NpgsqlTypes.NpgsqlLine(a: 0.010739428971982878d, b: 0.24577310936113506d, c: 0.9608726552852045d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2559851001361766d, b: 0.5956253607046449d, c: 0.8181736945435661d),

new NpgsqlTypes.NpgsqlLine(a: 0.5721360134117264d, b: 0.5812196689752014d, c: 0.6925084216952448d),

new NpgsqlTypes.NpgsqlLine(a: 0.40371510777276876d, b: 0.15028711001772577d, c: 0.5466152224748937d),

new NpgsqlTypes.NpgsqlLine(a: 0.4669354579404569d, b: 0.7995578707455515d, c: 0.6957674320221365d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6781275398045178d, b: 0.7275498399073008d, c: 0.7135691586330779d),

new NpgsqlTypes.NpgsqlLine(a: 0.7675241242054208d, b: 0.08377965039953694d, c: 0.5383552466646058d),

new NpgsqlTypes.NpgsqlLine(a: 0.9232598689370082d, b: 0.03317820636860569d, c: 0.7462560814425239d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08334158152193705d, b: 0.7135401216020837d, c: 0.947944200899358d),

new NpgsqlTypes.NpgsqlLine(a: 0.6079601816448044d, b: 0.42621088582575506d, c: 0.24018400017921215d),

new NpgsqlTypes.NpgsqlLine(a: 0.05487626348971553d, b: 0.27363287627463884d, c: 0.13133148288990437d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06441231312062656d, b: 0.5521665567827619d, c: 0.3825273291037219d),

new NpgsqlTypes.NpgsqlLine(a: 0.6852196290400613d, b: 0.7278705452126722d, c: 0.3317473145091554d),

new NpgsqlTypes.NpgsqlLine(a: 0.07600551388689114d, b: 0.6440083989153081d, c: 0.27396618755552116d),

new NpgsqlTypes.NpgsqlLine(a: 0.15392504075172775d, b: 0.301792127049733d, c: 0.38657766530043103d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21033600574707412d, b: 0.3999999686204736d, c: 0.4479001866453406d),

new NpgsqlTypes.NpgsqlLine(a: 0.9682465410957315d, b: 0.3258813973836263d, c: 0.6193927812315483d),

new NpgsqlTypes.NpgsqlLine(a: 0.7090478041927134d, b: 0.18966875522455073d, c: 0.035582470931208476d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8255170202042185d, b: 0.8374697150941404d, c: 0.6654523156690036d),

new NpgsqlTypes.NpgsqlLine(a: 0.8992688511610758d, b: 0.460152430342172d, c: 0.3463207487750938d),

new NpgsqlTypes.NpgsqlLine(a: 0.7696934244341695d, b: 0.042092029411082366d, c: 0.7881047778225099d),

new NpgsqlTypes.NpgsqlLine(a: 0.9177289993318405d, b: 0.17694676447585067d, c: 0.10762344980406802d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11612390608713818d, b: 0.8215333724454364d, c: 0.8795019656684708d),

new NpgsqlTypes.NpgsqlLine(a: 0.20034612997835355d, b: 0.5251151340333564d, c: 0.5797901617625599d),

new NpgsqlTypes.NpgsqlLine(a: 0.39866035531643207d, b: 0.5689311753982128d, c: 0.013416685098711856d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3215554467876217d, b: 0.8691575319413463d, c: 0.3151194348158788d),

new NpgsqlTypes.NpgsqlLine(a: 0.1593289318551181d, b: 0.6021635008748633d, c: 0.03396376035082682d),

new NpgsqlTypes.NpgsqlLine(a: 0.1858949799453068d, b: 0.6084965898350246d, c: 0.19185906674741737d),

new NpgsqlTypes.NpgsqlLine(a: 0.41651809401905404d, b: 0.8371174037556076d, c: 0.915878477177083d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6216368953230001d, b: 0.5294150960307787d, c: 0.9433555274123636d),

new NpgsqlTypes.NpgsqlLine(a: 0.992251275856364d, b: 0.8286111791427152d, c: 0.5270007760403149d),

new NpgsqlTypes.NpgsqlLine(a: 0.14717707469227137d, b: 0.22932457194270672d, c: 0.8638948743135595d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19739475425993835d, b: 0.8660932109443465d, c: 0.4619742891708636d),

new NpgsqlTypes.NpgsqlLine(a: 0.19374429943268745d, b: 0.14562188532354514d, c: 0.6172372159090386d),

new NpgsqlTypes.NpgsqlLine(a: 0.3310627453186502d, b: 0.6047354667210608d, c: 0.6791736926799024d),

new NpgsqlTypes.NpgsqlLine(a: 0.12036789730741537d, b: 0.24498842580902458d, c: 0.714153113208743d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9661244793155036d, b: 0.9828668949661691d, c: 0.821954894010838d),

new NpgsqlTypes.NpgsqlLine(a: 0.4850009622784599d, b: 0.7807380483799651d, c: 0.8428813205391675d),

new NpgsqlTypes.NpgsqlLine(a: 0.08067437070414363d, b: 0.3232616231555202d, c: 0.5653444334247436d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3970876998428772d, b: 0.24715966277356138d, c: 0.7891938613279885d),

new NpgsqlTypes.NpgsqlLine(a: 0.3896262941313692d, b: 0.14116885403969415d, c: 0.44628764416860356d),

new NpgsqlTypes.NpgsqlLine(a: 0.35907265412703815d, b: 0.38125931163526083d, c: 0.40246469973496923d),

new NpgsqlTypes.NpgsqlLine(a: 0.09660394412980566d, b: 0.3185051836527696d, c: 0.9073492954033826d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.012097774255042992d, b: 0.5825770206440708d, c: 0.09780664180276188d),

new NpgsqlTypes.NpgsqlLine(a: 0.7519025589847136d, b: 0.8241329701766449d, c: 0.6660760402394433d),

new NpgsqlTypes.NpgsqlLine(a: 0.9458151410450362d, b: 0.0002189292742862392d, c: 0.07879744270869438d),

new NpgsqlTypes.NpgsqlLine(a: 0.278452300049693d, b: 0.6887767526429678d, c: 0.3532743606517351d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4390406648002402d, b: 0.05079520810558069d, c: 0.007681563772046096d),

new NpgsqlTypes.NpgsqlLine(a: 0.11380155714342988d, b: 0.6893977210255262d, c: 0.9854843800002379d),

new NpgsqlTypes.NpgsqlLine(a: 0.06824612182030476d, b: 0.7884303350527866d, c: 0.8641587479059591d),

new NpgsqlTypes.NpgsqlLine(a: 0.37297696694546223d, b: 0.6084221590685336d, c: 0.974048069102529d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08643180778445181d, b: 0.5456195735294584d, c: 0.90044170399828d),

new NpgsqlTypes.NpgsqlLine(a: 0.5439578118947296d, b: 0.738145540289512d, c: 0.2473520173834809d),

new NpgsqlTypes.NpgsqlLine(a: 0.2536182910519761d, b: 0.715365701666323d, c: 0.6633463581383092d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23198540051984984d, b: 0.2942329948362983d, c: 0.5970607683042338d),

new NpgsqlTypes.NpgsqlLine(a: 0.788092264053719d, b: 0.8729948827162575d, c: 0.6522325261515416d),

new NpgsqlTypes.NpgsqlLine(a: 0.339711280578861d, b: 0.7613018096364662d, c: 0.9435543149554235d),

new NpgsqlTypes.NpgsqlLine(a: 0.32343409796659084d, b: 0.20382000077737317d, c: 0.6145653814501022d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1436522473607843d, b: 0.971270550010339d, c: 0.8425323352643765d),

new NpgsqlTypes.NpgsqlLine(a: 0.638947449423714d, b: 0.8054036608457612d, c: 0.39857283341368555d),

new NpgsqlTypes.NpgsqlLine(a: 0.5354839927054338d, b: 0.14213658756434577d, c: 0.28120449345724274d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8497854691683501d, b: 0.19613023306683985d, c: 0.38062767601599523d),

new NpgsqlTypes.NpgsqlLine(a: 0.6016539523390627d, b: 0.06862935284069827d, c: 0.17722242704252422d),

new NpgsqlTypes.NpgsqlLine(a: 0.05944062289769836d, b: 0.908000161203491d, c: 0.4346885060836505d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6289280111918615d, b: 0.7130628799033405d, c: 0.9910513503702968d),

new NpgsqlTypes.NpgsqlLine(a: 0.8072345370827524d, b: 0.12726829793846806d, c: 0.1707392560499278d),

new NpgsqlTypes.NpgsqlLine(a: 0.21953622098585124d, b: 0.1829338905440282d, c: 0.8974515749703987d),

new NpgsqlTypes.NpgsqlLine(a: 0.5652753642952061d, b: 0.8505307981500986d, c: 0.3046546835419479d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2502348058763779d, b: 0.8678046532743463d, c: 0.24469908239214422d),

new NpgsqlTypes.NpgsqlLine(a: 0.7000416097292941d, b: 0.030300246021297328d, c: 0.03001251580884534d),

new NpgsqlTypes.NpgsqlLine(a: 0.689212679312059d, b: 0.2237241130793326d, c: 0.22362080611302326d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16313982803308968d, b: 0.9136242045459115d, c: 0.23029409778346965d),

new NpgsqlTypes.NpgsqlLine(a: 0.18647889136615614d, b: 0.1789410926593129d, c: 0.6535666487387015d),

new NpgsqlTypes.NpgsqlLine(a: 0.34178393774918236d, b: 0.47489324548707657d, c: 0.18389378277323654d),

new NpgsqlTypes.NpgsqlLine(a: 0.1677987687553837d, b: 0.37973544035806994d, c: 0.6358460779804619d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9909378906064773d, b: 0.7865527582972655d, c: 0.9449549973837451d),

new NpgsqlTypes.NpgsqlLine(a: 0.3824520725370203d, b: 0.4569094404996593d, c: 0.7702210226606625d),

new NpgsqlTypes.NpgsqlLine(a: 0.5386340027758912d, b: 0.5641821763259391d, c: 0.1665003493700894d),

new NpgsqlTypes.NpgsqlLine(a: 0.0015471147251002737d, b: 0.5332588784249223d, c: 0.2732471068553123d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08113807552494978d, b: 0.3224854794048809d, c: 0.22175692227187926d),

new NpgsqlTypes.NpgsqlLine(a: 0.08553419485721503d, b: 0.43566767805051354d, c: 0.9647541710421297d),

new NpgsqlTypes.NpgsqlLine(a: 0.19472744764570427d, b: 0.020955359753651148d, c: 0.8240140567292281d),

new NpgsqlTypes.NpgsqlLine(a: 0.4794854515048361d, b: 0.41621313254841086d, c: 0.7757458132529171d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.031132437064156693d, b: 0.11102429483014742d, c: 0.403246184581854d),

new NpgsqlTypes.NpgsqlLine(a: 0.04425443289704767d, b: 0.4764989955760034d, c: 0.24310202792186286d),

new NpgsqlTypes.NpgsqlLine(a: 0.990159166789382d, b: 0.5939196437089295d, c: 0.7811561666257095d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8312379649216411d, b: 0.10222924781428022d, c: 0.22752936842450122d),

new NpgsqlTypes.NpgsqlLine(a: 0.2465882290027247d, b: 0.422566499394756d, c: 0.37065127861921376d),

new NpgsqlTypes.NpgsqlLine(a: 0.28792067231857355d, b: 0.9275457561651235d, c: 0.8376996566198334d),

new NpgsqlTypes.NpgsqlLine(a: 0.9956069655833056d, b: 0.9090970738288537d, c: 0.7273137259336614d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7591676358487164d, b: 0.13506540326134941d, c: 0.5247182499439611d),

new NpgsqlTypes.NpgsqlLine(a: 0.413843430894445d, b: 0.9902891119250393d, c: 0.5837587010443523d),

new NpgsqlTypes.NpgsqlLine(a: 0.909990551777998d, b: 0.1742165685356979d, c: 0.47564190373633053d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04531886533070084d, b: 0.2601670377039794d, c: 0.9931606216379278d),

new NpgsqlTypes.NpgsqlLine(a: 0.25939126745069696d, b: 0.12810531658018642d, c: 0.4099109375502332d),

new NpgsqlTypes.NpgsqlLine(a: 0.04377176076831102d, b: 0.18697390419008508d, c: 0.008244116238357968d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17676896554344257d, b: 0.9113976747091969d, c: 0.16195270495756497d),

new NpgsqlTypes.NpgsqlLine(a: 0.7880092122363014d, b: 0.9228928713408432d, c: 0.7574635820683153d),

new NpgsqlTypes.NpgsqlLine(a: 0.8671381486000553d, b: 0.39857190049368385d, c: 0.5488860751328674d),

new NpgsqlTypes.NpgsqlLine(a: 0.8513098448897823d, b: 0.885136920790505d, c: 0.22605206042855763d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9499052315988082d, b: 0.8234437378352043d, c: 0.7381668163693871d),

new NpgsqlTypes.NpgsqlLine(a: 0.26873612788494783d, b: 0.8193528471572732d, c: 0.8457525757057464d),

new NpgsqlTypes.NpgsqlLine(a: 0.34422676378478034d, b: 0.47706668403383035d, c: 0.6531503143638552d),

new NpgsqlTypes.NpgsqlLine(a: 0.14527465053897126d, b: 0.03546153034735677d, c: 0.5049092802339682d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.060869721674112975d, b: 0.9390420282412844d, c: 0.2135602693000852d),

new NpgsqlTypes.NpgsqlLine(a: 0.8484866337442099d, b: 0.8710027754598718d, c: 0.8472798817358884d),

new NpgsqlTypes.NpgsqlLine(a: 0.5402146886457214d, b: 0.32134756756976657d, c: 0.03490881614741559d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7718438222018689d, b: 0.9932798270290984d, c: 0.6523394584293584d),

new NpgsqlTypes.NpgsqlLine(a: 0.2280887133914301d, b: 0.5943591936663806d, c: 0.449348642260183d),

new NpgsqlTypes.NpgsqlLine(a: 0.9839654574114525d, b: 0.8180935296904062d, c: 0.650490743484535d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22426374039877206d, b: 0.87162070282245d, c: 0.2797812084801361d),

new NpgsqlTypes.NpgsqlLine(a: 0.09333152138212042d, b: 0.9300070581009301d, c: 0.10880883697770127d),

new NpgsqlTypes.NpgsqlLine(a: 0.07190381835674453d, b: 0.777818387062316d, c: 0.9883554908586586d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12556047700613293d, b: 0.7209590719251908d, c: 0.5394666194929175d),

new NpgsqlTypes.NpgsqlLine(a: 0.13026320199259278d, b: 0.4560391054045576d, c: 0.7670203838699787d),

new NpgsqlTypes.NpgsqlLine(a: 0.663525930502527d, b: 0.1292838775310179d, c: 0.6760167046403587d),

new NpgsqlTypes.NpgsqlLine(a: 0.46788073224037574d, b: 0.7888525555108118d, c: 0.62247627998915d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4966326823231244d, b: 0.9977822339897672d, c: 0.20877268188488074d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736927274586271d, b: 0.8763432661721622d, c: 0.835040679838844d),

new NpgsqlTypes.NpgsqlLine(a: 0.5768547546946854d, b: 0.051485395507329335d, c: 0.507464799617891d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13532545937738538d, b: 0.7705766621262798d, c: 0.3436642599421006d),

new NpgsqlTypes.NpgsqlLine(a: 0.509196707012327d, b: 0.9316113440390806d, c: 0.05752118456997268d),

new NpgsqlTypes.NpgsqlLine(a: 0.9564000933021387d, b: 0.7966471781422515d, c: 0.44969349625132315d),

new NpgsqlTypes.NpgsqlLine(a: 0.5034227978184879d, b: 0.9550400207078537d, c: 0.18615086909715173d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9314183325289219d, b: 0.18049318093565225d, c: 0.19727726288578296d),

new NpgsqlTypes.NpgsqlLine(a: 0.5998919626570971d, b: 0.7521792099260415d, c: 0.8490499924945051d),

new NpgsqlTypes.NpgsqlLine(a: 0.9968616875587039d, b: 0.09625883384731693d, c: 0.8098678371254096d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40825153066328945d, b: 0.9391800867809201d, c: 0.8819160086831175d),

new NpgsqlTypes.NpgsqlLine(a: 0.4218365969949157d, b: 0.31923458411375993d, c: 0.1799917578030602d),

new NpgsqlTypes.NpgsqlLine(a: 0.7554128777228213d, b: 0.4633329716856537d, c: 0.3380459912305267d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6955350852630664d, b: 0.3476352092314493d, c: 0.6958554713570391d),

new NpgsqlTypes.NpgsqlLine(a: 0.8118458757961675d, b: 0.592883108186694d, c: 0.44174441682752186d),

new NpgsqlTypes.NpgsqlLine(a: 0.19873541761860913d, b: 0.8222083357452592d, c: 0.8278683206025751d),

new NpgsqlTypes.NpgsqlLine(a: 0.5182029253747239d, b: 0.03855194677611884d, c: 0.6053921448730375d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8208781711851545d, b: 0.23611876297686996d, c: 0.7789539620311373d),

new NpgsqlTypes.NpgsqlLine(a: 0.35497077021228274d, b: 0.47912456454901453d, c: 0.834058717424968d),

new NpgsqlTypes.NpgsqlLine(a: 0.29928071689202573d, b: 0.6986339882691628d, c: 0.05195078660859831d),

new NpgsqlTypes.NpgsqlLine(a: 0.532296655987647d, b: 0.9586369485976705d, c: 0.4580605301610682d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18434896985544436d, b: 0.15953448847818819d, c: 0.3935378524598113d),

new NpgsqlTypes.NpgsqlLine(a: 0.9831754536914512d, b: 0.4008120368670901d, c: 0.0010058424097724172d),

new NpgsqlTypes.NpgsqlLine(a: 0.48906695232159014d, b: 0.2465459080707697d, c: 0.2580543166996263d),

new NpgsqlTypes.NpgsqlLine(a: 0.8077080490697741d, b: 0.2122110896802366d, c: 0.926740055328816d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6725783044617916d, b: 0.14840473693534117d, c: 0.11663366956722421d),

new NpgsqlTypes.NpgsqlLine(a: 0.37205622581083875d, b: 0.20506616379165932d, c: 0.8771788755216984d),

new NpgsqlTypes.NpgsqlLine(a: 0.24685160145342555d, b: 0.9671439409360055d, c: 0.7834891306228442d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21249045217135487d, b: 0.28372203810349494d, c: 0.265360950689288d),

new NpgsqlTypes.NpgsqlLine(a: 0.20085784371228088d, b: 0.7623612750413609d, c: 0.4547883516068134d),

new NpgsqlTypes.NpgsqlLine(a: 0.36976571953145265d, b: 0.7250574589847334d, c: 0.33118791739531217d),

},
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[34], false);
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
                parametr1.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 122, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 124, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 158, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 77, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 68, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 66, query1, 45, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 166))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 19, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

