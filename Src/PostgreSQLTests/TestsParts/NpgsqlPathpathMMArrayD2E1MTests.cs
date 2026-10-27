

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
    internal partial interface INpgsqlPathMArraypathMMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD2 : INpgsqlPathMArraypathMMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD2E1M[] _testData = new NpgsqlPathpathMMArrayD2E1M[]
        {
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2398117929718041d, y: 0.16121045849382543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913661200174394d, y: 0.8601897033173717d), new NpgsqlTypes.NpgsqlPoint(x: 0.45641333699762454d, y: 0.20320161964343053d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2092201999370622d, y: 0.26977128253873617d), new NpgsqlTypes.NpgsqlPoint(x: 0.752995393273138d, y: 0.1020288888896439d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708219242206724d, y: 0.903030981160715d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07626296646649589d, y: 0.324839282322249d), new NpgsqlTypes.NpgsqlPoint(x: 0.845306498642177d, y: 0.22173642751045552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448236094024144d, y: 0.9125326765456258d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9053308921490593d, y: 0.02457738046821778d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092295274665924d, y: 0.37833685050571564d), new NpgsqlTypes.NpgsqlPoint(x: 0.19867399972521416d, y: 0.46107555015539226d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49608583705325937d, y: 0.9452194472282891d), new NpgsqlTypes.NpgsqlPoint(x: 0.5898461880443358d, y: 0.4361204174444612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7585652641171163d, y: 0.21401981646637036d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016302413013581707d, y: 0.09163238812001395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7309060198429137d, y: 0.1917035516076976d), new NpgsqlTypes.NpgsqlPoint(x: 0.09857279209015268d, y: 0.8718492365018239d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0352382536561765d, y: 0.984663265866231d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750843183066398d, y: 0.6864768197051722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117551169515058d, y: 0.43088205879846564d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229234337640405d, y: 0.27528256288981323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5329351604772945d, y: 0.5305953721376181d), new NpgsqlTypes.NpgsqlPoint(x: 0.08824454155488104d, y: 0.1778494356993633d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8880741255484207d, y: 0.36096343603105974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7386881140108876d, y: 0.7425374581685722d), new NpgsqlTypes.NpgsqlPoint(x: 0.43035893209587295d, y: 0.17904881706854536d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.921640293303945d, y: 0.10125770422923763d), new NpgsqlTypes.NpgsqlPoint(x: 0.2696208669015938d, y: 0.37457806390509063d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981666512990085d, y: 0.5923021527351928d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21659874883153718d, y: 0.46213260502950193d), new NpgsqlTypes.NpgsqlPoint(x: 0.12172920532296228d, y: 0.7841609167873761d), new NpgsqlTypes.NpgsqlPoint(x: 0.632211440024646d, y: 0.7597102790026137d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2650129713738214d, y: 0.5146636602491356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476070178490887d, y: 0.11882411495387313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4285070311813345d, y: 0.05951207944138093d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24992862120363135d, y: 0.14954675837561693d), new NpgsqlTypes.NpgsqlPoint(x: 0.1104227485581446d, y: 0.8722009969083503d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376833993666676d, y: 0.10211800981559327d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.377562318565439d, y: 0.002427328312851529d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884502221067383d, y: 0.4751998541462882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815239729453212d, y: 0.1775319983566772d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38563792831857313d, y: 0.7525966283449962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936891575192113d, y: 0.056809774597341045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231150388897501d, y: 0.5559987404184528d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8679365907769939d, y: 0.24224457298833524d), new NpgsqlTypes.NpgsqlPoint(x: 0.12372667635875712d, y: 0.8068590692273984d), new NpgsqlTypes.NpgsqlPoint(x: 0.879799098777576d, y: 0.08679718370643374d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004521623512988793d, y: 0.9718660840394612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976169700101107d, y: 0.42606495162528635d), new NpgsqlTypes.NpgsqlPoint(x: 0.701807187298381d, y: 0.24982501449486172d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8195685240611758d, y: 0.18296606740124755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3563266737842157d, y: 0.9393106518095157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793582319515905d, y: 0.6780339397514566d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059705703707081836d, y: 0.8144320955019622d), new NpgsqlTypes.NpgsqlPoint(x: 0.7125601728574418d, y: 0.10604246896445035d), new NpgsqlTypes.NpgsqlPoint(x: 0.29238662895454914d, y: 0.6265671482949143d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04504290558888746d, y: 0.9144982769600388d), new NpgsqlTypes.NpgsqlPoint(x: 0.14519972200365394d, y: 0.6373879861207368d), new NpgsqlTypes.NpgsqlPoint(x: 0.636758001643293d, y: 0.6479168149983476d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24957979487026283d, y: 0.2413690424688456d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540414880148636d, y: 0.9412580095296124d), new NpgsqlTypes.NpgsqlPoint(x: 0.15215559448964622d, y: 0.08232151487501504d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2987308091431411d, y: 0.5839547855403457d), new NpgsqlTypes.NpgsqlPoint(x: 0.64806074544144d, y: 0.7736947771183833d), new NpgsqlTypes.NpgsqlPoint(x: 0.49645242513957266d, y: 0.7000191262866349d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1410307612888596d, y: 0.4809846655783441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225862547680277d, y: 0.6755357366896002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290635665827282d, y: 0.8629147148067303d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9664989043623939d, y: 0.6026045975488795d), new NpgsqlTypes.NpgsqlPoint(x: 0.13875567759169338d, y: 0.3969240480506485d), new NpgsqlTypes.NpgsqlPoint(x: 0.15700124817009486d, y: 0.13745301183564962d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46261141371425285d, y: 0.24735788659130375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955622389039687d, y: 0.019325431247944502d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834576132427163d, y: 0.7687403626453472d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3627729803724695d, y: 0.7949789950606223d), new NpgsqlTypes.NpgsqlPoint(x: 0.15568977569969256d, y: 0.4933886407837097d), new NpgsqlTypes.NpgsqlPoint(x: 0.443742532772504d, y: 0.6297876491952002d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7305733433414445d, y: 0.5416066902226376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311966993505978d, y: 0.9628381694211086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5642193824866693d, y: 0.636860708814506d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9556910127291891d, y: 0.2733186591065221d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340813285715637d, y: 0.01856603431284154d), new NpgsqlTypes.NpgsqlPoint(x: 0.2035746533095122d, y: 0.050689187394610036d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6964692906249655d, y: 0.3552661713094857d), new NpgsqlTypes.NpgsqlPoint(x: 0.968646896816402d, y: 0.4980842666062365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3876714650237657d, y: 0.9713967942024875d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9674107321877383d, y: 0.7570828553911276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732030891056435d, y: 0.4752699118462652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516144236760826d, y: 0.32273826155708296d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3204407323123496d, y: 0.4793239987515664d), new NpgsqlTypes.NpgsqlPoint(x: 0.26134292940831183d, y: 0.044441282958902484d), new NpgsqlTypes.NpgsqlPoint(x: 0.16955114924112036d, y: 0.17841293133066793d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8051987370411077d, y: 0.3543747712961107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5385912949244019d, y: 0.5721140324736759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004625232929462d, y: 0.37201178015609015d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21987292794535984d, y: 0.8766136847738161d), new NpgsqlTypes.NpgsqlPoint(x: 0.2730777627899542d, y: 0.43511791321123916d), new NpgsqlTypes.NpgsqlPoint(x: 0.35137636532920646d, y: 0.03395386664874789d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9720853924568065d, y: 0.7648588220377158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398884703199848d, y: 0.4619548956632713d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320976261314915d, y: 0.2586301519375962d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8781984052787256d, y: 0.24244750405554827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889821741551329d, y: 0.6131213890068379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521922881494283d, y: 0.20584399637282003d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09544015320267119d, y: 0.05424218372941236d), new NpgsqlTypes.NpgsqlPoint(x: 0.07941734612441531d, y: 0.4866195141743799d), new NpgsqlTypes.NpgsqlPoint(x: 0.12416032840738322d, y: 0.25879650735619364d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.862247418281525d, y: 0.9878198105417535d), new NpgsqlTypes.NpgsqlPoint(x: 0.803834311886331d, y: 0.29693432320988045d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941369458459474d, y: 0.2234360697420239d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.366606552195332d, y: 0.8552712798907885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9920298262031609d, y: 0.5281444628526902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278807643767952d, y: 0.33025877540086057d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395125516915667d, y: 0.9244339414465382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001144209840751d, y: 0.9500959672272936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097384092546451d, y: 0.703464322495468d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045060689453375824d, y: 0.7437494890220555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964659784819483d, y: 0.18229211119198208d), new NpgsqlTypes.NpgsqlPoint(x: 0.08963471815409574d, y: 0.38542954408042474d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13074672529079712d, y: 0.938080606715236d), new NpgsqlTypes.NpgsqlPoint(x: 0.41392877737342804d, y: 0.20493210582840393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849121711408779d, y: 0.8069618048283271d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16716512072871914d, y: 0.3227644319221882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6505246977576831d, y: 0.32781881455571804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606353092678439d, y: 0.7878611895341836d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8493837709961156d, y: 0.732648030895521d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496136326866998d, y: 0.9844953618173213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9034346305806717d, y: 0.10950832865211824d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9100019267055954d, y: 0.6268848898021017d), new NpgsqlTypes.NpgsqlPoint(x: 0.00793624808286586d, y: 0.8415454928322386d), new NpgsqlTypes.NpgsqlPoint(x: 0.00019970937042712578d, y: 0.029392378725972113d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8841639940648559d, y: 0.45517668730556793d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061073015677565d, y: 0.5987246014106633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111956107530934d, y: 0.3114228521037884d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.276899599810405d, y: 0.49353721241646054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8656763317199533d, y: 0.6344648837547424d), new NpgsqlTypes.NpgsqlPoint(x: 0.07227525484071873d, y: 0.18042672945946514d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08417869135147216d, y: 0.6161675079290301d), new NpgsqlTypes.NpgsqlPoint(x: 0.4923266947504128d, y: 0.7571945713873597d), new NpgsqlTypes.NpgsqlPoint(x: 0.06574319703676279d, y: 0.47843607187789805d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2773171093966198d, y: 0.3077595904101821d), new NpgsqlTypes.NpgsqlPoint(x: 0.4755547030228173d, y: 0.18582215276914527d), new NpgsqlTypes.NpgsqlPoint(x: 0.12589834044499382d, y: 0.361331282688817d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5666034418074509d, y: 0.7229184225740853d), new NpgsqlTypes.NpgsqlPoint(x: 0.288586186383467d, y: 0.23073942234688938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961796535782396d, y: 0.8455842027184546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8544870365997268d, y: 0.9699906950324274d), new NpgsqlTypes.NpgsqlPoint(x: 0.16167452930419357d, y: 0.6754437042908354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2137867333237612d, y: 0.19475372251047895d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47570993457363775d, y: 0.04311408594446353d), new NpgsqlTypes.NpgsqlPoint(x: 0.862205164095183d, y: 0.2367160049947794d), new NpgsqlTypes.NpgsqlPoint(x: 0.46371340215742185d, y: 0.46485643227031304d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1315606859532059d, y: 0.9974754568129376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9114799670425052d, y: 0.4499763177208187d), new NpgsqlTypes.NpgsqlPoint(x: 0.4347700709742416d, y: 0.7576250325370002d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5526532387545361d, y: 0.3328932392511743d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842811462599907d, y: 0.2712700652103953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047207300165373d, y: 0.9565232995376286d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20256713381264435d, y: 0.33709127860567467d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781165104682455d, y: 0.2828756252569057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8654650637849959d, y: 0.14401512337448819d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5535443624133329d, y: 0.48434949524285087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064258185203259d, y: 0.08113236261310086d), new NpgsqlTypes.NpgsqlPoint(x: 0.40007836736036895d, y: 0.7646534104265446d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7673193925474108d, y: 0.18126747453859027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968910008276405d, y: 0.5029242498212205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9858623879116717d, y: 0.7916686628586199d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8871370618458453d, y: 0.9100317762265685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651123935558307d, y: 0.5198203639600576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268204623657746d, y: 0.181194745333074d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7756975865563817d, y: 0.28320836465016297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9643311440415144d, y: 0.9365093383190093d), new NpgsqlTypes.NpgsqlPoint(x: 0.023887623364580945d, y: 0.41709544893138983d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8708319739882304d, y: 0.15022224023745967d), new NpgsqlTypes.NpgsqlPoint(x: 0.24325563595042932d, y: 0.42833604813056947d), new NpgsqlTypes.NpgsqlPoint(x: 0.05204727144260812d, y: 0.32092506390714415d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37186922477357687d, y: 0.7125854560839074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956215329683985d, y: 0.7143778389696288d), new NpgsqlTypes.NpgsqlPoint(x: 0.2911091512555747d, y: 0.4205282299864743d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5672954436355124d, y: 0.6711805168963424d), new NpgsqlTypes.NpgsqlPoint(x: 0.15681037947577392d, y: 0.7414906602812704d), new NpgsqlTypes.NpgsqlPoint(x: 0.1261718904156699d, y: 0.8334726864613887d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2503475355690008d, y: 0.035839384277196684d), new NpgsqlTypes.NpgsqlPoint(x: 0.44287615521897816d, y: 0.1384713233851813d), new NpgsqlTypes.NpgsqlPoint(x: 0.468443239762369d, y: 0.5057147217980466d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013498475342464733d, y: 0.5335655570170775d), new NpgsqlTypes.NpgsqlPoint(x: 0.22046386142046048d, y: 0.5816029664261396d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224477761823209d, y: 0.546114277143354d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29684225954709464d, y: 0.6196339284018717d), new NpgsqlTypes.NpgsqlPoint(x: 0.10938965083082441d, y: 0.4917333332930308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376381874070844d, y: 0.8255930824523441d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21688357951924753d, y: 0.2923684556589887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4285631291813772d, y: 0.5520473207592882d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344469011105069d, y: 0.8672932740310121d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8052897954242867d, y: 0.5514353063124754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679398788718674d, y: 0.770119696219372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896917689911028d, y: 0.3211670412179225d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36730120756835816d, y: 0.11388160596985086d), new NpgsqlTypes.NpgsqlPoint(x: 0.3774033125363435d, y: 0.06518660192695935d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250613389132236d, y: 0.6686052122369305d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4816904585419267d, y: 0.5380810352316809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9674386513654109d, y: 0.013229584557013396d), new NpgsqlTypes.NpgsqlPoint(x: 0.19859332223642145d, y: 0.8230476217053126d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6428921360382754d, y: 0.095185104635371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542322344270246d, y: 0.3722717206738857d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473003274982724d, y: 0.2074185654673597d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16894491923700183d, y: 0.2085232441374102d), new NpgsqlTypes.NpgsqlPoint(x: 0.31773418897738415d, y: 0.7124724964616223d), new NpgsqlTypes.NpgsqlPoint(x: 0.28187975914923225d, y: 0.4574058342996097d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6448414329527463d, y: 0.609731566280435d), new NpgsqlTypes.NpgsqlPoint(x: 0.19690700196840893d, y: 0.669385162550707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4511400818693325d, y: 0.23271663898993267d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6485068107356221d, y: 0.3966536944972632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450137023965621d, y: 0.6562241666861593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347881481573317d, y: 0.10845095272461747d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39073569633785654d, y: 0.5870724462301059d), new NpgsqlTypes.NpgsqlPoint(x: 0.008878601512549267d, y: 0.20988450298478867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8689579808365757d, y: 0.5760901923999813d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8325401155288547d, y: 0.44344237577626044d), new NpgsqlTypes.NpgsqlPoint(x: 0.01149602788257098d, y: 0.15215888793368526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4158198410860424d, y: 0.5339504159299365d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7702540765307325d, y: 0.6029163893084166d), new NpgsqlTypes.NpgsqlPoint(x: 0.28788696853489726d, y: 0.6338949076172469d), new NpgsqlTypes.NpgsqlPoint(x: 0.42536540272922796d, y: 0.4499200789759368d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32171855777272973d, y: 0.7426853982429926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729291550329457d, y: 0.48164710041694425d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634208913720288d, y: 0.2982457539846781d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13281776216968866d, y: 0.5207421768350305d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724814308561128d, y: 0.6060084006496069d), new NpgsqlTypes.NpgsqlPoint(x: 0.0748972653297435d, y: 0.7296698597514015d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2742074944435301d, y: 0.1598825381174349d), new NpgsqlTypes.NpgsqlPoint(x: 0.02060190486807345d, y: 0.4654063407974557d), new NpgsqlTypes.NpgsqlPoint(x: 0.20656445416905456d, y: 0.8225546201739584d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6889601986955264d, y: 0.8356597549096074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629537666549847d, y: 0.09874134302521298d), new NpgsqlTypes.NpgsqlPoint(x: 0.618475853021942d, y: 0.7813273947491702d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5822377442693123d, y: 0.10281289643510905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969652298880666d, y: 0.6841292803831025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393803109292745d, y: 0.9332365371443122d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5698840244813397d, y: 0.5964324163586787d), new NpgsqlTypes.NpgsqlPoint(x: 0.03413847755084387d, y: 0.6883254439323323d), new NpgsqlTypes.NpgsqlPoint(x: 0.22879862570209442d, y: 0.9179552378974173d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385643170184516d, y: 0.9171574023911936d), new NpgsqlTypes.NpgsqlPoint(x: 0.43535035922633436d, y: 0.8485529845228112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783228491351748d, y: 0.7236779196075388d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8451154444254165d, y: 0.06827035469107556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794264443423131d, y: 0.3785198285508443d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583212953158978d, y: 0.4709442868005055d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36281712981594216d, y: 0.1814241860181396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8076770515161877d, y: 0.47951662220634295d), new NpgsqlTypes.NpgsqlPoint(x: 0.10759027524408571d, y: 0.4465544326409999d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6974497166965131d, y: 0.1207318075645073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676226563477251d, y: 0.12578897699042313d), new NpgsqlTypes.NpgsqlPoint(x: 0.26978178251581186d, y: 0.42381828947253086d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8725504583894699d, y: 0.15382963674723948d), new NpgsqlTypes.NpgsqlPoint(x: 0.78854461896958d, y: 0.8780734279410889d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998606622551151d, y: 0.3931886486589985d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35697782472488027d, y: 0.9550196943234498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8469082765704039d, y: 0.7636651001058415d), new NpgsqlTypes.NpgsqlPoint(x: 0.10889545357527375d, y: 0.20436645719610125d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09849642707736572d, y: 0.02917094334359327d), new NpgsqlTypes.NpgsqlPoint(x: 0.7967061781042892d, y: 0.9006935006668308d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363297378461484d, y: 0.7023121918003383d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3843217161502074d, y: 0.20957580628417172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6023017556031239d, y: 0.7464712445361043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375866167201575d, y: 0.47178092945674366d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2566364139125935d, y: 0.9118780215915965d), new NpgsqlTypes.NpgsqlPoint(x: 0.1001047734275381d, y: 0.43212088828651574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9756731374262148d, y: 0.965557854865632d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8245535324245576d, y: 0.4025058693675796d), new NpgsqlTypes.NpgsqlPoint(x: 0.1294280805161292d, y: 0.7335215918232251d), new NpgsqlTypes.NpgsqlPoint(x: 0.1889635253789913d, y: 0.2088405795113728d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6289600282387935d, y: 0.8428461721524951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705779636914405d, y: 0.021959247246350788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354606594131595d, y: 0.03207624329690817d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1281813493463222d, y: 0.5786044945444013d), new NpgsqlTypes.NpgsqlPoint(x: 0.23566422114181163d, y: 0.08117524312209101d), new NpgsqlTypes.NpgsqlPoint(x: 0.28702403862359405d, y: 0.2697041548951714d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6446531081046478d, y: 0.5268598453689138d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777946913643281d, y: 0.16702994181447073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629175627588068d, y: 0.06416519436037382d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.766552767999392d, y: 0.26848117918911085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844860792536513d, y: 0.06815003807143982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344574170994486d, y: 0.25333611888951957d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7870921816937997d, y: 0.8924166181485934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919544783499971d, y: 0.11874476900577757d), new NpgsqlTypes.NpgsqlPoint(x: 0.12044109566807126d, y: 0.04015304477237125d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03153767857304324d, y: 0.8942409155388326d), new NpgsqlTypes.NpgsqlPoint(x: 0.16909393748935186d, y: 0.41954270416106254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7978194009463676d, y: 0.12345012965054669d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6419416387101359d, y: 0.6928916384903548d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281972445029489d, y: 0.5233279311071491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674779982016015d, y: 0.5242415185454367d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3726504289801813d, y: 0.7028052680241625d), new NpgsqlTypes.NpgsqlPoint(x: 0.710986314152951d, y: 0.11396663606048296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437871366697552d, y: 0.8611142700527643d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11492337734027236d, y: 0.5326682005447668d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706367677630918d, y: 0.20181269711895522d), new NpgsqlTypes.NpgsqlPoint(x: 0.36997429310662355d, y: 0.39605493124782465d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11544460870466855d, y: 0.2522917211833685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967161198075986d, y: 0.17274368007265395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503839585717656d, y: 0.03174228573440252d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43659201932668057d, y: 0.27845109200328466d), new NpgsqlTypes.NpgsqlPoint(x: 0.35282389084768984d, y: 0.3823299596842402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930451712249957d, y: 0.7243332508780583d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12466881009112885d, y: 0.5153894233135609d), new NpgsqlTypes.NpgsqlPoint(x: 0.34576147855414063d, y: 0.11545234728828313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069731102360619d, y: 0.3997026845583924d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3986338999429059d, y: 0.7635585417926964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814014849043161d, y: 0.9190217312076434d), new NpgsqlTypes.NpgsqlPoint(x: 0.02330728252657377d, y: 0.29087507713692096d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025918727265271557d, y: 0.8922003803070283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570556750481447d, y: 0.17705546999188904d), new NpgsqlTypes.NpgsqlPoint(x: 0.27659914017832843d, y: 0.044412451418059495d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6253844650742306d, y: 0.3023399308108413d), new NpgsqlTypes.NpgsqlPoint(x: 0.09772126469535625d, y: 0.7694353534329765d), new NpgsqlTypes.NpgsqlPoint(x: 0.47480751758312245d, y: 0.5073845346604818d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4877587176994429d, y: 0.33250895348610676d), new NpgsqlTypes.NpgsqlPoint(x: 0.2630692344835053d, y: 0.1441876677498216d), new NpgsqlTypes.NpgsqlPoint(x: 0.4391419914080634d, y: 0.4857431165288558d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5035667483382072d, y: 0.2360269338411164d), new NpgsqlTypes.NpgsqlPoint(x: 0.35447763671555776d, y: 0.5076746026334392d), new NpgsqlTypes.NpgsqlPoint(x: 0.47595584485488196d, y: 0.6503100725303264d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7897610298064802d, y: 0.4232351033637213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905903423395486d, y: 0.9119543535688904d), new NpgsqlTypes.NpgsqlPoint(x: 0.716423490653855d, y: 0.4828268632362791d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9020480799880167d, y: 0.791688448519733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327137362160361d, y: 0.44045256427018176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714290366715165d, y: 0.7943695562532462d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9475610586215021d, y: 0.7182454216852183d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389989147227106d, y: 0.31202040761999505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489598584058974d, y: 0.3493464720563405d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.942919355014004d, y: 0.34628458753404145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990360507966891d, y: 0.9749443960052652d), new NpgsqlTypes.NpgsqlPoint(x: 0.2879416488025336d, y: 0.29068657436646406d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3420319820863018d, y: 0.30242098018196206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8076493674210335d, y: 0.465572230401612d), new NpgsqlTypes.NpgsqlPoint(x: 0.15192939819779738d, y: 0.48941596774350016d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8218531361837877d, y: 0.3627109072948803d), new NpgsqlTypes.NpgsqlPoint(x: 0.1543003376571096d, y: 0.08751691355287616d), new NpgsqlTypes.NpgsqlPoint(x: 0.28497704579350114d, y: 0.9891287317844888d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23732490558975938d, y: 0.23793235358791043d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301590661390971d, y: 0.48295179053599036d), new NpgsqlTypes.NpgsqlPoint(x: 0.23885338492045682d, y: 0.24354264256141367d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960614110474974d, y: 0.5301880696106721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796545292627847d, y: 0.2188081177485547d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068411581284185d, y: 0.32790369712503487d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9004980743317565d, y: 0.6661202997287269d), new NpgsqlTypes.NpgsqlPoint(x: 0.21479564153045994d, y: 0.9499147553238154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5883934467073672d, y: 0.574678040675158d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4437104885688544d, y: 0.23918400033053633d), new NpgsqlTypes.NpgsqlPoint(x: 0.503094185487264d, y: 0.8308697334156967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859785178623812d, y: 0.587161800458359d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14017759285405518d, y: 0.47178943489900027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6289506494030681d, y: 0.3974398858458199d), new NpgsqlTypes.NpgsqlPoint(x: 0.05381060372406876d, y: 0.35374383279297617d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30790233243986165d, y: 0.007953542633135635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832396256739937d, y: 0.9980071789798185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7912312930911863d, y: 0.9755813138040836d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6733059348722927d, y: 0.3860796732143086d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454866614511649d, y: 0.08171417771670131d), new NpgsqlTypes.NpgsqlPoint(x: 0.493412672584436d, y: 0.7279873934803722d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5603011470583661d, y: 0.9391462485971837d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013511280960581962d, y: 0.0258521048687268d), new NpgsqlTypes.NpgsqlPoint(x: 0.05328165685745245d, y: 0.2512196124203979d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7967734248053367d, y: 0.7070010425749094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8594331282817117d, y: 0.7262838064123037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7360663066007515d, y: 0.06299131289771276d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7496750125292447d, y: 0.17911072718130794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993226057396017d, y: 0.47027615048117855d), new NpgsqlTypes.NpgsqlPoint(x: 0.3853593335576615d, y: 0.08397961398518461d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6129937325829035d, y: 0.20913806291047998d), new NpgsqlTypes.NpgsqlPoint(x: 0.4310799668829115d, y: 0.36843685787962244d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518625538084588d, y: 0.6573363175213134d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9143609656861222d, y: 0.4819627264345082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637280536744479d, y: 0.8177220416520715d), new NpgsqlTypes.NpgsqlPoint(x: 0.14313727601755222d, y: 0.45904062822751845d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023393695312086793d, y: 0.442202650647732d), new NpgsqlTypes.NpgsqlPoint(x: 0.423241977006939d, y: 0.16497899317488385d), new NpgsqlTypes.NpgsqlPoint(x: 0.16776191523766293d, y: 0.26211903893586275d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11032812884527365d, y: 0.6700789855271814d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975391773804071d, y: 0.8830584810682574d), new NpgsqlTypes.NpgsqlPoint(x: 0.27956769445968455d, y: 0.12790467502439196d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6859480689432801d, y: 0.16203279379840618d), new NpgsqlTypes.NpgsqlPoint(x: 0.3465804270590529d, y: 0.5827000226606004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9564196520549049d, y: 0.8954268850770961d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3058716247747998d, y: 0.8929328771177419d), new NpgsqlTypes.NpgsqlPoint(x: 0.22280462332980078d, y: 0.6578189161537069d), new NpgsqlTypes.NpgsqlPoint(x: 0.7620322550278367d, y: 0.6158914555913717d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3614994868081354d, y: 0.7807895425509092d), new NpgsqlTypes.NpgsqlPoint(x: 0.10612034879529442d, y: 0.6555932010643208d), new NpgsqlTypes.NpgsqlPoint(x: 0.45173105798988156d, y: 0.24287963169125482d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7580144086747925d, y: 0.0858086690481854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953126350941469d, y: 0.7051191598051951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511313406661477d, y: 0.6012291996889081d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2303609004284617d, y: 0.8802905048534839d), new NpgsqlTypes.NpgsqlPoint(x: 0.45982270563678007d, y: 0.8215639860002859d), new NpgsqlTypes.NpgsqlPoint(x: 0.22076618897102385d, y: 0.2495142719226433d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6887885302271178d, y: 0.9441939441167106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887503349727498d, y: 0.7436986351175187d), new NpgsqlTypes.NpgsqlPoint(x: 0.1951550378316289d, y: 0.9169514295193422d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6273350959293406d, y: 0.5272713997390795d), new NpgsqlTypes.NpgsqlPoint(x: 0.23487490682916257d, y: 0.5808152367971701d), new NpgsqlTypes.NpgsqlPoint(x: 0.36062965552639104d, y: 0.7031366346879818d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371651347589801d, y: 0.4641357919593946d), new NpgsqlTypes.NpgsqlPoint(x: 0.30202212102484893d, y: 0.9340292202840002d), new NpgsqlTypes.NpgsqlPoint(x: 0.0609265784489077d, y: 0.7717371448775914d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29242335186929125d, y: 0.07896006514542075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6804225596702486d, y: 0.9872317436750004d), new NpgsqlTypes.NpgsqlPoint(x: 0.09820822734717394d, y: 0.3186960812058951d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07000329058849242d, y: 0.6800528706541308d), new NpgsqlTypes.NpgsqlPoint(x: 0.20934948309952228d, y: 0.9264699029061129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198150310883463d, y: 0.23133259343711154d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044513403398796d, y: 0.5850673181187435d), new NpgsqlTypes.NpgsqlPoint(x: 0.26527900822656525d, y: 0.21314088790551222d), new NpgsqlTypes.NpgsqlPoint(x: 0.170942937716142d, y: 0.23117312075855212d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45466933758439354d, y: 0.7614209016916621d), new NpgsqlTypes.NpgsqlPoint(x: 0.40272162401795975d, y: 0.7886059492210581d), new NpgsqlTypes.NpgsqlPoint(x: 0.39057485221931554d, y: 0.6852933125039399d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16719586637479655d, y: 0.042752087930318705d), new NpgsqlTypes.NpgsqlPoint(x: 0.765002592172473d, y: 0.039280008182171144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532716340839777d, y: 0.16292377537827818d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7131625460420054d, y: 0.45826887497635793d), new NpgsqlTypes.NpgsqlPoint(x: 0.46556795055676004d, y: 0.09006159150842785d), new NpgsqlTypes.NpgsqlPoint(x: 0.08683554857927323d, y: 0.21590415490948256d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7714325413034744d, y: 0.34214304949842356d), new NpgsqlTypes.NpgsqlPoint(x: 0.1792822725493305d, y: 0.887961350428578d), new NpgsqlTypes.NpgsqlPoint(x: 0.08054432243303355d, y: 0.5820595951441027d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23740346708675475d, y: 0.4937205283929136d), new NpgsqlTypes.NpgsqlPoint(x: 0.05291126045538763d, y: 0.7282336474003949d), new NpgsqlTypes.NpgsqlPoint(x: 0.15076811033880755d, y: 0.2802451578091696d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05506023202081234d, y: 0.4424245689035785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8778444993020486d, y: 0.8253263023138836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6318159603335395d, y: 0.30104340737561874d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4531907347268833d, y: 0.9524139539840456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283508996089118d, y: 0.27023703071730754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5725808764234324d, y: 0.5640170016625847d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9720099757772933d, y: 0.9293395448117954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6912658001190765d, y: 0.500899895008128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161520113882187d, y: 0.6905566829613222d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770567997573566d, y: 0.8807284283175962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6897410670913734d, y: 0.07457917504523148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041756356823323d, y: 0.21331889375579938d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34747136010031965d, y: 0.5763322694245412d), new NpgsqlTypes.NpgsqlPoint(x: 0.38865584397989394d, y: 0.406937545736783d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897067574838209d, y: 0.301758304996083d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36779590518410754d, y: 0.8241448526804811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8092437292692269d, y: 0.5887087597114011d), new NpgsqlTypes.NpgsqlPoint(x: 0.4478848139610583d, y: 0.5432756334699136d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.560753609833201d, y: 0.8286480470406967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8362026762762121d, y: 0.020617213789584143d), new NpgsqlTypes.NpgsqlPoint(x: 0.25380056123982d, y: 0.7034367546949694d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5401158215209394d, y: 0.9605378242497336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272945702707492d, y: 0.741863703692284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8676383849167439d, y: 0.8863929386661247d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4108648527394332d, y: 0.35619315408813246d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058643477385141d, y: 0.09609441975679411d), new NpgsqlTypes.NpgsqlPoint(x: 0.18347102625426648d, y: 0.8043248265139037d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8703063202705174d, y: 0.7818457542055506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8967237604226367d, y: 0.7961690505309791d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822162397744224d, y: 0.7006555654962949d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.67623522260184d, y: 0.1322411028504039d), new NpgsqlTypes.NpgsqlPoint(x: 0.7821113416764953d, y: 0.4675405481421807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9708926591449941d, y: 0.25937670777614596d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7498756113337314d, y: 0.6449733117258012d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357652900410313d, y: 0.14134768239700157d), new NpgsqlTypes.NpgsqlPoint(x: 0.06474357532468611d, y: 0.4451191474677182d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10907089253277102d, y: 0.027363047668965468d), new NpgsqlTypes.NpgsqlPoint(x: 0.18646301223045614d, y: 0.3166521086396753d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172976256170434d, y: 0.02980303116901928d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4542498572011645d, y: 0.5138084658901901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4261481272353135d, y: 0.8234645433089954d), new NpgsqlTypes.NpgsqlPoint(x: 0.19527260257677137d, y: 0.843926716435828d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48838045343642855d, y: 0.19781998087330077d), new NpgsqlTypes.NpgsqlPoint(x: 0.3506173977005753d, y: 0.3180813925994528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4273303752527464d, y: 0.29191504049490624d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30847292434385687d, y: 0.6462339938314036d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348677171304287d, y: 0.017549328623732596d), new NpgsqlTypes.NpgsqlPoint(x: 0.4305156110685453d, y: 0.5321158133945616d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08393981411598739d, y: 0.830219764853657d), new NpgsqlTypes.NpgsqlPoint(x: 0.1791575064088391d, y: 0.4331659052535455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9745933022701008d, y: 0.7054666678923094d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.894854893621305d, y: 0.6357172819825871d), new NpgsqlTypes.NpgsqlPoint(x: 0.42461943581434625d, y: 0.13168829760879253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3833183609567383d, y: 0.6841581782852395d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014904676583076037d, y: 0.23048809377064283d), new NpgsqlTypes.NpgsqlPoint(x: 0.22324751036086243d, y: 0.6938456874440033d), new NpgsqlTypes.NpgsqlPoint(x: 0.027940210857656078d, y: 0.25804817459212015d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11764765314102388d, y: 0.2712981598169615d), new NpgsqlTypes.NpgsqlPoint(x: 0.6586104154546599d, y: 0.7912320646993799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486720542129305d, y: 0.6046902479386994d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7288070436128539d, y: 0.0957431831929364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6040143308347548d, y: 0.9602533696041731d), new NpgsqlTypes.NpgsqlPoint(x: 0.40494365616867367d, y: 0.432654302990256d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4767024643502673d, y: 0.34537701056286074d), new NpgsqlTypes.NpgsqlPoint(x: 0.12592038972112274d, y: 0.5241349287703836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5739951875892995d, y: 0.5342198223234947d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05072546701311287d, y: 0.33395052928261637d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070791713002027d, y: 0.0831805686734145d), new NpgsqlTypes.NpgsqlPoint(x: 0.20343757921176642d, y: 0.11762874960255598d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7458579930851862d, y: 0.21338027377352164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895805254870578d, y: 0.4998930367218052d), new NpgsqlTypes.NpgsqlPoint(x: 0.33792544569741334d, y: 0.5850529599336335d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7068264757789787d, y: 0.9109954901813944d), new NpgsqlTypes.NpgsqlPoint(x: 0.0659440866012897d, y: 0.4954283780321266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197185896517359d, y: 0.07744190296230702d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8671586361009727d, y: 0.28626363216643436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789127653259615d, y: 0.4167657426318162d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657711065089367d, y: 0.4191595472674313d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0681939835488895d, y: 0.15439391098717659d), new NpgsqlTypes.NpgsqlPoint(x: 0.21885148868945026d, y: 0.06616812449800435d), new NpgsqlTypes.NpgsqlPoint(x: 0.013003871251900057d, y: 0.23539897988608838d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8400201910022244d, y: 0.5035374070038181d), new NpgsqlTypes.NpgsqlPoint(x: 0.2696707070154575d, y: 0.3841184318108517d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931325817602669d, y: 0.9917711976534984d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6491367351235452d, y: 0.8173801458490196d), new NpgsqlTypes.NpgsqlPoint(x: 0.38304944603397917d, y: 0.026827607845404278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7539238704596064d, y: 0.8260972349838206d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2552410811868282d, y: 0.5528326683588224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245914335918422d, y: 0.25129528330086215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056572950762236d, y: 0.6832161864270512d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3417846533464758d, y: 0.21638103092423844d), new NpgsqlTypes.NpgsqlPoint(x: 0.2210884045297593d, y: 0.2468757856694611d), new NpgsqlTypes.NpgsqlPoint(x: 0.23208917099196036d, y: 0.7035330141745568d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8183738552436458d, y: 0.1560345219038476d), new NpgsqlTypes.NpgsqlPoint(x: 0.4234252902130591d, y: 0.2806711085434759d), new NpgsqlTypes.NpgsqlPoint(x: 0.985936912854843d, y: 0.7341580255268205d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8166234123434253d, y: 0.09487914546383791d), new NpgsqlTypes.NpgsqlPoint(x: 0.9170476201382392d, y: 0.07167557171239947d), new NpgsqlTypes.NpgsqlPoint(x: 0.2998336423577259d, y: 0.5535307360412804d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.165477948137978d, y: 0.19286487528775176d), new NpgsqlTypes.NpgsqlPoint(x: 0.36074669266515325d, y: 0.9972132606149295d), new NpgsqlTypes.NpgsqlPoint(x: 0.43425346484477423d, y: 0.8529983431729097d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22313744843905514d, y: 0.7919556458228078d), new NpgsqlTypes.NpgsqlPoint(x: 0.3076332627057392d, y: 0.5445466103153768d), new NpgsqlTypes.NpgsqlPoint(x: 0.5119755829543153d, y: 0.6306698289607737d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9905088437659708d, y: 0.44127957193437173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8889401652184136d, y: 0.3246260646815734d), new NpgsqlTypes.NpgsqlPoint(x: 0.32943708204936817d, y: 0.12167642232669962d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7718919469475183d, y: 0.47823122590592393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765152394847129d, y: 0.6673504271972442d), new NpgsqlTypes.NpgsqlPoint(x: 0.08268612933660469d, y: 0.1542505564488883d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.907717903937003d, y: 0.6415403649336321d), new NpgsqlTypes.NpgsqlPoint(x: 0.1735665542612227d, y: 0.21052445036787804d), new NpgsqlTypes.NpgsqlPoint(x: 0.023514323319783537d, y: 0.7253172000517177d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3946599669091214d, y: 0.690704673731293d), new NpgsqlTypes.NpgsqlPoint(x: 0.021218103030864688d, y: 0.7637976666165973d), new NpgsqlTypes.NpgsqlPoint(x: 0.9505686118424318d, y: 0.42229338903443525d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7243985183647877d, y: 0.43833246873668863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269124205504073d, y: 0.33696568863516774d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142918854962492d, y: 0.21123728011692244d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9209661528735351d, y: 0.17038150821398523d), new NpgsqlTypes.NpgsqlPoint(x: 0.14160605802570692d, y: 0.308571859550298d), new NpgsqlTypes.NpgsqlPoint(x: 0.004376148858638351d, y: 0.021108924255146655d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12846262898209393d, y: 0.9242001399295379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6295718231653767d, y: 0.7039716237893321d), new NpgsqlTypes.NpgsqlPoint(x: 0.4147386651822771d, y: 0.027901040135749233d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1863581040229394d, y: 0.8870564069525634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189200895372334d, y: 0.4456387049249798d), new NpgsqlTypes.NpgsqlPoint(x: 0.779172426101968d, y: 0.4578836541070602d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9668412806987582d, y: 0.43082995466718255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9245176312260113d, y: 0.8014120450510213d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017376410156294542d, y: 0.9564555201687392d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5366207677569568d, y: 0.1592248090203986d), new NpgsqlTypes.NpgsqlPoint(x: 0.27678685412525583d, y: 0.14851372692179743d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682589214646336d, y: 0.9471079897660586d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7294888188108157d, y: 0.6953607928880939d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612283280310296d, y: 0.13086229099763824d), new NpgsqlTypes.NpgsqlPoint(x: 0.3045143923501702d, y: 0.7314854679959885d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32139438179607693d, y: 0.02997337314763404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759137618035356d, y: 0.043956249628137045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6692092195578344d, y: 0.5357885648020547d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5863140838993678d, y: 0.894951197016274d), new NpgsqlTypes.NpgsqlPoint(x: 0.41334693082860163d, y: 0.8033842689613956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413041388499373d, y: 0.892029341987546d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.508250966472959d, y: 0.8334260151491308d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688172770956122d, y: 0.4004025791301371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426703633024444d, y: 0.8266400420072733d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06819352515351096d, y: 0.7517930491347914d), new NpgsqlTypes.NpgsqlPoint(x: 0.17490603231071533d, y: 0.5040032386024438d), new NpgsqlTypes.NpgsqlPoint(x: 0.42715057907350085d, y: 0.6283445460997167d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.942456766221368d, y: 0.28252552635588624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3274650206237245d, y: 0.12577952546544524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486006114497878d, y: 0.2894721652563035d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9190616228080247d, y: 0.5106790928495581d), new NpgsqlTypes.NpgsqlPoint(x: 0.2306384807001618d, y: 0.18435859504691676d), new NpgsqlTypes.NpgsqlPoint(x: 0.43066523217227903d, y: 0.09915749061196755d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8974919450497748d, y: 0.8476254314345039d), new NpgsqlTypes.NpgsqlPoint(x: 0.2836737224392871d, y: 0.6496043309715741d), new NpgsqlTypes.NpgsqlPoint(x: 0.34693565793798076d, y: 0.9982572655412024d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3786131002038402d, y: 0.8032261457277335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4507506834560284d, y: 0.4875912157048832d), new NpgsqlTypes.NpgsqlPoint(x: 0.2725361552475941d, y: 0.6870880735068223d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45266889956796563d, y: 0.2947353831752474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168708045011423d, y: 0.5556741760123273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8792588198256239d, y: 0.9321566572394886d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07234565769648016d, y: 0.6115095636545232d), new NpgsqlTypes.NpgsqlPoint(x: 0.17828387687232383d, y: 0.41039326646986996d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163979752819477d, y: 0.5878141582865539d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17504682291644502d, y: 0.1308144628564275d), new NpgsqlTypes.NpgsqlPoint(x: 0.4071833243291715d, y: 0.2513646374456838d), new NpgsqlTypes.NpgsqlPoint(x: 0.015639701842629083d, y: 0.9364553575072683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2537492383151482d, y: 0.9818540066286503d), new NpgsqlTypes.NpgsqlPoint(x: 0.42620252467421416d, y: 0.5364098691303986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3365106638556259d, y: 0.5276542984175815d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6911132733534545d, y: 0.5605362544611663d), new NpgsqlTypes.NpgsqlPoint(x: 0.17457373019050815d, y: 0.04374263471993667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9990764892827455d, y: 0.8861211390777882d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8240541442010423d, y: 0.5982160519384683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533661185409896d, y: 0.8335699999148376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9654300519387379d, y: 0.1710063221759064d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020309509736935127d, y: 0.01005056938751625d), new NpgsqlTypes.NpgsqlPoint(x: 0.41849194967689995d, y: 0.249167973530107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906992618859642d, y: 0.19913050818458244d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8289365832272733d, y: 0.4444056814518521d), new NpgsqlTypes.NpgsqlPoint(x: 0.8563287706850582d, y: 0.31558554161776764d), new NpgsqlTypes.NpgsqlPoint(x: 0.09538933518170423d, y: 0.722365892292823d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24101051662399597d, y: 0.45984494205956117d), new NpgsqlTypes.NpgsqlPoint(x: 0.38040561043788534d, y: 0.4704393431279499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267033902679558d, y: 0.2897881196547457d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8043888301399672d, y: 0.8617959161051792d), new NpgsqlTypes.NpgsqlPoint(x: 0.35968605278818777d, y: 0.00040862583548173514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981654357792795d, y: 0.5240754625483206d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35329774667373204d, y: 0.496680731223464d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672121973926892d, y: 0.12595696903461717d), new NpgsqlTypes.NpgsqlPoint(x: 0.3538634837396396d, y: 0.32200899753349166d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8060386522048353d, y: 0.39032350918783487d), new NpgsqlTypes.NpgsqlPoint(x: 0.7008416113502947d, y: 0.025946734162069718d), new NpgsqlTypes.NpgsqlPoint(x: 0.701439099403194d, y: 0.7427514698698517d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9256919203021624d, y: 0.8236403870925674d), new NpgsqlTypes.NpgsqlPoint(x: 0.12420899938492458d, y: 0.18845900152387007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923808290148449d, y: 0.2734779687143637d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8326504558526684d, y: 0.8657612502236972d), new NpgsqlTypes.NpgsqlPoint(x: 0.1341724671217891d, y: 0.1073418279931011d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276223364632026d, y: 0.4408479490769186d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27794441775045564d, y: 0.10215068634925928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6025975633673292d, y: 0.7002051528672918d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983604441964514d, y: 0.5278489458774671d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01202203179389072d, y: 0.8925829860499986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918633285854818d, y: 0.12892492701745506d), new NpgsqlTypes.NpgsqlPoint(x: 0.671562983772635d, y: 0.1431197441247809d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7820454602643971d, y: 0.9319638917737851d), new NpgsqlTypes.NpgsqlPoint(x: 0.10919773189065063d, y: 0.6808775953401462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158934991358221d, y: 0.2823342047091928d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24851010261622086d, y: 0.7990277477831147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4298783904463739d, y: 0.049307656708412084d), new NpgsqlTypes.NpgsqlPoint(x: 0.875709336288401d, y: 0.438082002358238d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5703725219326224d, y: 0.9496403530538907d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425701924834038d, y: 0.9459109380753612d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347433778361656d, y: 0.5756740782261226d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2075742788978061d, y: 0.38324455956643966d), new NpgsqlTypes.NpgsqlPoint(x: 0.47550809087205426d, y: 0.7549232238368585d), new NpgsqlTypes.NpgsqlPoint(x: 0.1520982860403054d, y: 0.7606102660193285d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8854189018459969d, y: 0.9107644460857597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994665827880483d, y: 0.04401629443980726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9189525230184997d, y: 0.544745061406668d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9145546992465634d, y: 0.6505580704484385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754129051445772d, y: 0.5962435639539302d), new NpgsqlTypes.NpgsqlPoint(x: 0.26403993446201457d, y: 0.4829665614442822d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11384374927097807d, y: 0.5135323655806634d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789102656574633d, y: 0.6544397616868292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888160387127497d, y: 0.8938574995237871d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3215524821049921d, y: 0.7741755171511137d), new NpgsqlTypes.NpgsqlPoint(x: 0.633178323247052d, y: 0.8529816618720871d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617296121432071d, y: 0.6833596818587606d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5586286321844077d, y: 0.21911481103100783d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793905132687108d, y: 0.859884240015397d), new NpgsqlTypes.NpgsqlPoint(x: 0.10820131205671524d, y: 0.3140106846681757d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9816694726348416d, y: 0.6869377851523076d), new NpgsqlTypes.NpgsqlPoint(x: 0.47442461732344876d, y: 0.5048567537695002d), new NpgsqlTypes.NpgsqlPoint(x: 0.6734700284028534d, y: 0.5205610876268019d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5905358461560829d, y: 0.9909143000852629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5756892055293051d, y: 0.48244740363767535d), new NpgsqlTypes.NpgsqlPoint(x: 0.48052151780130736d, y: 0.9340881191266769d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35677930284375836d, y: 0.011758937587215468d), new NpgsqlTypes.NpgsqlPoint(x: 0.38154859845498035d, y: 0.4440926668729125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356432686368421d, y: 0.955634936926556d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9123738016319523d, y: 0.4467738472146152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5663445841702542d, y: 0.010030409523763328d), new NpgsqlTypes.NpgsqlPoint(x: 0.4016310601105473d, y: 0.5267049116104855d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5887655073221549d, y: 0.3373509374945327d), new NpgsqlTypes.NpgsqlPoint(x: 0.10760772921177197d, y: 0.006067362365480111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8620924982739461d, y: 0.1741129081787487d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39571727075258734d, y: 0.9176615881491376d), new NpgsqlTypes.NpgsqlPoint(x: 0.47531118190621413d, y: 0.07880416495463616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9479382172088398d, y: 0.8966131142628548d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9287330821862119d, y: 0.7856774393777802d), new NpgsqlTypes.NpgsqlPoint(x: 0.5584343295258216d, y: 0.8681897909418734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337141947553118d, y: 0.7118587743172491d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7895263557332888d, y: 0.1743222846954252d), new NpgsqlTypes.NpgsqlPoint(x: 0.5545370865636117d, y: 0.6557914836929224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8165109879167551d, y: 0.8885775612910439d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4872817622513559d, y: 0.9674562821662854d), new NpgsqlTypes.NpgsqlPoint(x: 0.04097538529053224d, y: 0.13382446794402714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9980575125971072d, y: 0.394695201670733d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5125806681001656d, y: 0.22466944222138663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8417010026483029d, y: 0.09970257363081947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814200811959269d, y: 0.041606658172188116d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5192417903815463d, y: 0.9681189796687997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499661871605701d, y: 0.6666543056141306d), new NpgsqlTypes.NpgsqlPoint(x: 0.833218360610703d, y: 0.06257648499907198d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3878487583060939d, y: 0.27131779832025715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6401023314565732d, y: 0.8647522954505958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180671980000077d, y: 0.8839105658836589d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8045610087599844d, y: 0.3613171337546245d), new NpgsqlTypes.NpgsqlPoint(x: 0.029419705024718246d, y: 0.06951468814678508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891189835876164d, y: 0.6773444347875608d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00018536764810062056d, y: 0.2879918808439881d), new NpgsqlTypes.NpgsqlPoint(x: 0.37323239999207236d, y: 0.464076669331524d), new NpgsqlTypes.NpgsqlPoint(x: 0.2722520173280869d, y: 0.1122497105232817d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5246246693204905d, y: 0.4160943473199742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7701402388734767d, y: 0.15659226104845736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005756278966526d, y: 0.9790534077624231d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6622702720511265d, y: 0.13396787924617726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9983668635532964d, y: 0.3514045903882671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521856778920558d, y: 0.7312843627171786d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3483205649097313d, y: 0.09590565916637828d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822482448953948d, y: 0.31986217894602886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772812359788501d, y: 0.9419970863787062d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3330607221588352d, y: 0.5242472966185475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6527206598809074d, y: 0.755710658320293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5858387526979d, y: 0.1394031929377907d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3130594421113835d, y: 0.2533505656010526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888576427132673d, y: 0.05111477204491233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8594423857780586d, y: 0.8842444852115195d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26583569397085116d, y: 0.2840822363108507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339447317591798d, y: 0.23977220757058149d), new NpgsqlTypes.NpgsqlPoint(x: 0.2684279402435277d, y: 0.5930315455323925d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09971154308649566d, y: 0.4890698743490939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204855105398956d, y: 0.2949655139137033d), new NpgsqlTypes.NpgsqlPoint(x: 0.03796635029218354d, y: 0.7987107483565816d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7696830926931939d, y: 0.5720112768465119d), new NpgsqlTypes.NpgsqlPoint(x: 0.3710111142816124d, y: 0.14979748596488318d), new NpgsqlTypes.NpgsqlPoint(x: 0.29786663635397914d, y: 0.24375311903362296d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1151716288440513d, y: 0.6847613313669431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482749022449102d, y: 0.10740699891607941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301518109477922d, y: 0.349074338680048d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.391298118793898d, y: 0.5362734799394343d), new NpgsqlTypes.NpgsqlPoint(x: 0.44775534992321375d, y: 0.6679152393839661d), new NpgsqlTypes.NpgsqlPoint(x: 0.38438002986152353d, y: 0.7939094119324855d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9001619125640844d, y: 0.07223689814040668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581940522897218d, y: 0.9799862011217814d), new NpgsqlTypes.NpgsqlPoint(x: 0.1863470616586348d, y: 0.2525614294643145d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3186524446913137d, y: 0.40359441542822727d), new NpgsqlTypes.NpgsqlPoint(x: 0.45514710621664756d, y: 0.8513081102588801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9092264759149334d, y: 0.6789420914652895d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8071964669674802d, y: 0.43845720840999236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867139063531776d, y: 0.28112819136276035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155169535293971d, y: 0.6981955151976744d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021761544194709548d, y: 0.20155708327192579d), new NpgsqlTypes.NpgsqlPoint(x: 0.4441544240293086d, y: 0.791416439601399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222726410072895d, y: 0.04643164974858105d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4224989313343487d, y: 0.9571470473156033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9865139135109893d, y: 0.9337107871819915d), new NpgsqlTypes.NpgsqlPoint(x: 0.28573844120405945d, y: 0.4707305526022063d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4824597448127811d, y: 0.10263331472097625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373464708867578d, y: 0.29776561486822306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8887756331252764d, y: 0.9831154816691088d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1881375856905505d, y: 0.8670263017222106d), new NpgsqlTypes.NpgsqlPoint(x: 0.0067472174182540146d, y: 0.6318546893933678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7871859257834911d, y: 0.43410125844615033d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7591830549661016d, y: 0.45531450686983854d), new NpgsqlTypes.NpgsqlPoint(x: 0.3941053733232528d, y: 0.12748531718730038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5259084706242992d, y: 0.039911903947789096d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271840720433242d, y: 0.9034693443047612d), new NpgsqlTypes.NpgsqlPoint(x: 0.716874503653586d, y: 0.48405392078340537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409761280589123d, y: 0.8907630464364762d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7169851800076485d, y: 0.2071482743504074d), new NpgsqlTypes.NpgsqlPoint(x: 0.43603388958344513d, y: 0.9137465991647846d), new NpgsqlTypes.NpgsqlPoint(x: 0.019234217745605853d, y: 0.2241947145786678d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04071578662729447d, y: 0.932278898325584d), new NpgsqlTypes.NpgsqlPoint(x: 0.813186899056512d, y: 0.0025161834012807915d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254215922315584d, y: 0.6628324230327881d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9584861387171939d, y: 0.5068296545545393d), new NpgsqlTypes.NpgsqlPoint(x: 0.01009234996948094d, y: 0.865806072579543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747236333960187d, y: 0.38957751204280056d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5082763235061056d, y: 0.1601490915160283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3925646471409565d, y: 0.5138468981408348d), new NpgsqlTypes.NpgsqlPoint(x: 0.2871020971965167d, y: 0.9072764337335761d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5415959334926578d, y: 0.7162550158388932d), new NpgsqlTypes.NpgsqlPoint(x: 0.30495685800604333d, y: 0.45894561044389814d), new NpgsqlTypes.NpgsqlPoint(x: 0.101828116608911d, y: 0.7869789683027515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35519830990986867d, y: 0.5765982766732809d), new NpgsqlTypes.NpgsqlPoint(x: 0.41397677531620447d, y: 0.8395887624315592d), new NpgsqlTypes.NpgsqlPoint(x: 0.42978368058889127d, y: 0.5695629746115881d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7550461152655279d, y: 0.4037467368264748d), new NpgsqlTypes.NpgsqlPoint(x: 0.30795601127005034d, y: 0.15548641279644748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516470175485878d, y: 0.8049695899118852d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49742046744617974d, y: 0.3961031639177397d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849500268558125d, y: 0.8847166679494656d), new NpgsqlTypes.NpgsqlPoint(x: 0.041746123073207464d, y: 0.6767352311160886d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41750795346536074d, y: 0.621415638536356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9114903202277d, y: 0.010654208814418031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9205963374234383d, y: 0.26415014387792757d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2052937849775699d, y: 0.14269626324253026d), new NpgsqlTypes.NpgsqlPoint(x: 0.602863731841341d, y: 0.315845345330394d), new NpgsqlTypes.NpgsqlPoint(x: 0.545179079039805d, y: 0.12823117489946034d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29067535952864065d, y: 0.6935670400778294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6473431450751874d, y: 0.06286072448737523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906124094786405d, y: 0.45656933130355015d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3735680850278914d, y: 0.6658129529838331d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376971345381989d, y: 0.9025309607911666d), new NpgsqlTypes.NpgsqlPoint(x: 0.32356809166009803d, y: 0.7535665212964093d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21803924244657447d, y: 0.9618160423462704d), new NpgsqlTypes.NpgsqlPoint(x: 0.09839070458840915d, y: 0.28635129620397914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9650443415538542d, y: 0.05993252855935427d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9607394911928764d, y: 0.6339932811975156d), new NpgsqlTypes.NpgsqlPoint(x: 0.20074416664624994d, y: 0.7101699813351102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906616524383279d, y: 0.7091852303578537d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7150579595717395d, y: 0.8501592551595609d), new NpgsqlTypes.NpgsqlPoint(x: 0.579687239744297d, y: 0.015573354791177052d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550803574397213d, y: 0.8614445601187144d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7611707169117087d, y: 0.030788547483985074d), new NpgsqlTypes.NpgsqlPoint(x: 0.18829803750678598d, y: 0.030391802977104865d), new NpgsqlTypes.NpgsqlPoint(x: 0.7463583626060483d, y: 0.7194366942445252d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8629226869917432d, y: 0.4048225280230099d), new NpgsqlTypes.NpgsqlPoint(x: 0.16782449085809092d, y: 0.6938298899621552d), new NpgsqlTypes.NpgsqlPoint(x: 0.6503587274239265d, y: 0.9219473217268715d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6582956660866158d, y: 0.20966977149336607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218974881034146d, y: 0.8488400308866138d), new NpgsqlTypes.NpgsqlPoint(x: 0.47467338262009595d, y: 0.43199053325799464d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6226551901553785d, y: 0.7187354902907443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972432840186546d, y: 0.6324599605269171d), new NpgsqlTypes.NpgsqlPoint(x: 0.25450110850292273d, y: 0.3048738662834928d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39130655733074193d, y: 0.1766729392177382d), new NpgsqlTypes.NpgsqlPoint(x: 0.49172197634682d, y: 0.38893571466682286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6444593462223827d, y: 0.8040461630968645d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10814957912176881d, y: 0.6100639798176993d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680242279417393d, y: 0.3686446983407554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9581142640291229d, y: 0.40060280582574204d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04757619971585059d, y: 0.28757529620322786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764497616801705d, y: 0.31076087227884797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7461827400721924d, y: 0.3295202207946477d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6625290206603924d, y: 0.9142271794295084d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295065048340844d, y: 0.13592531490991888d), new NpgsqlTypes.NpgsqlPoint(x: 0.24615838456262362d, y: 0.7173122306230759d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.781479658045553d, y: 0.06923558029768195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457413100395489d, y: 0.34945335075242845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8667327600819925d, y: 0.9743845978046289d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21015585629975042d, y: 0.34618991874667526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035725039669993d, y: 0.5595533695283512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9571281222977099d, y: 0.32179487433342946d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012567372817164801d, y: 0.3082854712047318d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848182070128823d, y: 0.1601040248003759d), new NpgsqlTypes.NpgsqlPoint(x: 0.036450930569439155d, y: 0.3071638676284755d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31544446202528775d, y: 0.06698223972115758d), new NpgsqlTypes.NpgsqlPoint(x: 0.560850531002647d, y: 0.6677497959889926d), new NpgsqlTypes.NpgsqlPoint(x: 0.03540106280475486d, y: 0.4411491625640773d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.692720480010817d, y: 0.5244553138466471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859200024495713d, y: 0.6333250016449096d), new NpgsqlTypes.NpgsqlPoint(x: 0.07243112229475168d, y: 0.9687231397728016d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8213195921041572d, y: 0.739242963024767d), new NpgsqlTypes.NpgsqlPoint(x: 0.44216014166308804d, y: 0.6514478823227173d), new NpgsqlTypes.NpgsqlPoint(x: 0.652615818325865d, y: 0.9416475187251456d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3971917640961813d, y: 0.7956477627586152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924656423003327d, y: 0.3663634235216532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251946275546273d, y: 0.41166341108405613d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07002678533286089d, y: 0.00784945367667822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207631102464798d, y: 0.8809536140072016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7139773778981596d, y: 0.2365372223522798d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4752521994896197d, y: 0.30189422527921306d), new NpgsqlTypes.NpgsqlPoint(x: 0.05879704924276585d, y: 0.05171897714616769d), new NpgsqlTypes.NpgsqlPoint(x: 0.12103462084236116d, y: 0.9718722538080937d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28285152856196305d, y: 0.15049362222135032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186884505354592d, y: 0.9590546428060919d), new NpgsqlTypes.NpgsqlPoint(x: 0.021979822212017885d, y: 0.11989820082922586d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48172459452879324d, y: 0.8168149395491942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550723397287957d, y: 0.7143359161833228d), new NpgsqlTypes.NpgsqlPoint(x: 0.628408483611147d, y: 0.5070118952211592d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6351772566441913d, y: 0.8274532657591152d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341671377822975d, y: 0.619765884253446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707739385429611d, y: 0.9595473361430154d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4319160895395924d, y: 0.5998113069711117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6768213583969303d, y: 0.5382127583177122d), new NpgsqlTypes.NpgsqlPoint(x: 0.42993988955557705d, y: 0.18189463208755952d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6914410757840543d, y: 0.045507670434646874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532643337254641d, y: 0.2709635630448839d), new NpgsqlTypes.NpgsqlPoint(x: 0.26152734951468637d, y: 0.0854361120239675d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6543097155269622d, y: 0.5993214508731871d), new NpgsqlTypes.NpgsqlPoint(x: 0.147113931551498d, y: 0.9260279008923894d), new NpgsqlTypes.NpgsqlPoint(x: 0.08798233432953517d, y: 0.8116238641357431d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5781264726655337d, y: 0.35188470538810235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9900323998765019d, y: 0.3254110203635018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6736927591143307d, y: 0.45047324065486993d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2910027957133745d, y: 0.9958152643020212d), new NpgsqlTypes.NpgsqlPoint(x: 0.9824483028798929d, y: 0.2434551066665832d), new NpgsqlTypes.NpgsqlPoint(x: 0.619734131782798d, y: 0.1231893582535778d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1868821554043506d, y: 0.9309423287048842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4194093613442287d, y: 0.7529923997267168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221401245695334d, y: 0.9446046310304881d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3256302321377378d, y: 0.3368344435506324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421788467434979d, y: 0.043435366463294045d), new NpgsqlTypes.NpgsqlPoint(x: 0.12158985704747771d, y: 0.7729770749844125d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40697613306740343d, y: 0.21450113195185017d), new NpgsqlTypes.NpgsqlPoint(x: 0.12784566585681478d, y: 0.8249817244764329d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088002908345502d, y: 0.8387088994335913d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3190938702172751d, y: 0.37186777103896773d), new NpgsqlTypes.NpgsqlPoint(x: 0.01043274399513383d, y: 0.2007281986278615d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419603670400588d, y: 0.8184503354482989d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840977432253504d, y: 0.3372602279750746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7544552159506812d, y: 0.054364790500908255d), new NpgsqlTypes.NpgsqlPoint(x: 0.17113917450025062d, y: 0.860368995422845d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16388919892258969d, y: 0.39715618821395493d), new NpgsqlTypes.NpgsqlPoint(x: 0.749450928929102d, y: 0.5248442685231881d), new NpgsqlTypes.NpgsqlPoint(x: 0.30839532458462726d, y: 0.595282780853043d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5711529982991409d, y: 0.11390391871480665d), new NpgsqlTypes.NpgsqlPoint(x: 0.1517093377059605d, y: 0.9752297779186011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557849010838998d, y: 0.6447122415846642d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6038743334712146d, y: 0.38297959075763066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432009224365876d, y: 0.8735279085500972d), new NpgsqlTypes.NpgsqlPoint(x: 0.398808441687555d, y: 0.713784551438298d)), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.862247418281525d, y: 0.9878198105417535d), new NpgsqlTypes.NpgsqlPoint(x: 0.803834311886331d, y: 0.29693432320988045d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941369458459474d, y: 0.2234360697420239d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.366606552195332d, y: 0.8552712798907885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9920298262031609d, y: 0.5281444628526902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278807643767952d, y: 0.33025877540086057d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395125516915667d, y: 0.9244339414465382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001144209840751d, y: 0.9500959672272936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097384092546451d, y: 0.703464322495468d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045060689453375824d, y: 0.7437494890220555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964659784819483d, y: 0.18229211119198208d), new NpgsqlTypes.NpgsqlPoint(x: 0.08963471815409574d, y: 0.38542954408042474d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5666034418074509d, y: 0.7229184225740853d), new NpgsqlTypes.NpgsqlPoint(x: 0.288586186383467d, y: 0.23073942234688938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961796535782396d, y: 0.8455842027184546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8544870365997268d, y: 0.9699906950324274d), new NpgsqlTypes.NpgsqlPoint(x: 0.16167452930419357d, y: 0.6754437042908354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2137867333237612d, y: 0.19475372251047895d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47570993457363775d, y: 0.04311408594446353d), new NpgsqlTypes.NpgsqlPoint(x: 0.862205164095183d, y: 0.2367160049947794d), new NpgsqlTypes.NpgsqlPoint(x: 0.46371340215742185d, y: 0.46485643227031304d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1315606859532059d, y: 0.9974754568129376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9114799670425052d, y: 0.4499763177208187d), new NpgsqlTypes.NpgsqlPoint(x: 0.4347700709742416d, y: 0.7576250325370002d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8871370618458453d, y: 0.9100317762265685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651123935558307d, y: 0.5198203639600576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268204623657746d, y: 0.181194745333074d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7756975865563817d, y: 0.28320836465016297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9643311440415144d, y: 0.9365093383190093d), new NpgsqlTypes.NpgsqlPoint(x: 0.023887623364580945d, y: 0.41709544893138983d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8708319739882304d, y: 0.15022224023745967d), new NpgsqlTypes.NpgsqlPoint(x: 0.24325563595042932d, y: 0.42833604813056947d), new NpgsqlTypes.NpgsqlPoint(x: 0.05204727144260812d, y: 0.32092506390714415d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37186922477357687d, y: 0.7125854560839074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956215329683985d, y: 0.7143778389696288d), new NpgsqlTypes.NpgsqlPoint(x: 0.2911091512555747d, y: 0.4205282299864743d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39073569633785654d, y: 0.5870724462301059d), new NpgsqlTypes.NpgsqlPoint(x: 0.008878601512549267d, y: 0.20988450298478867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8689579808365757d, y: 0.5760901923999813d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8325401155288547d, y: 0.44344237577626044d), new NpgsqlTypes.NpgsqlPoint(x: 0.01149602788257098d, y: 0.15215888793368526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4158198410860424d, y: 0.5339504159299365d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7702540765307325d, y: 0.6029163893084166d), new NpgsqlTypes.NpgsqlPoint(x: 0.28788696853489726d, y: 0.6338949076172469d), new NpgsqlTypes.NpgsqlPoint(x: 0.42536540272922796d, y: 0.4499200789759368d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32171855777272973d, y: 0.7426853982429926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729291550329457d, y: 0.48164710041694425d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634208913720288d, y: 0.2982457539846781d)), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7897610298064802d, y: 0.4232351033637213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905903423395486d, y: 0.9119543535688904d), new NpgsqlTypes.NpgsqlPoint(x: 0.716423490653855d, y: 0.4828268632362791d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9020480799880167d, y: 0.791688448519733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327137362160361d, y: 0.44045256427018176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714290366715165d, y: 0.7943695562532462d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9475610586215021d, y: 0.7182454216852183d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389989147227106d, y: 0.31202040761999505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489598584058974d, y: 0.3493464720563405d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.942919355014004d, y: 0.34628458753404145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990360507966891d, y: 0.9749443960052652d), new NpgsqlTypes.NpgsqlPoint(x: 0.2879416488025336d, y: 0.29068657436646406d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 29, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 130, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 114, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 165, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 88, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 29, query1, 165, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 59, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
FROM public.binary_npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI), typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

