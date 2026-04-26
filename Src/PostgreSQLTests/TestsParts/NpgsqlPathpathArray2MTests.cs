

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8155330266892288d, y: 0.426995327373222d), new NpgsqlTypes.NpgsqlPoint(x: 0.3448008448930959d, y: 0.5091694568316334d), new NpgsqlTypes.NpgsqlPoint(x: 0.4647697090982911d, y: 0.5686936937045837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.563654588037479d, y: 0.14860253447163363d), new NpgsqlTypes.NpgsqlPoint(x: 0.09265163446552105d, y: 0.11232328228557553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213231823637137d, y: 0.8045868246359602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07602042596100411d, y: 0.4567236349799565d), new NpgsqlTypes.NpgsqlPoint(x: 0.12335004262250582d, y: 0.6240699843252768d), new NpgsqlTypes.NpgsqlPoint(x: 0.4424107034302014d, y: 0.7821486882876506d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019098086291820637d, y: 0.9538931136374355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9987589442203112d, y: 0.14236126506622537d), new NpgsqlTypes.NpgsqlPoint(x: 0.10369018969915411d, y: 0.7171177682849502d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8092291352878744d, y: 0.5936016257560214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474320278114766d, y: 0.48707246511610924d), new NpgsqlTypes.NpgsqlPoint(x: 0.24395286402224714d, y: 0.37917846100846464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7261608601332662d, y: 0.5463338601468061d), new NpgsqlTypes.NpgsqlPoint(x: 0.12808877006184471d, y: 0.31840164095058543d), new NpgsqlTypes.NpgsqlPoint(x: 0.3013425266719525d, y: 0.3614903046559724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30464122321153d, y: 0.12062305855923161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8534983051836408d, y: 0.07570664918458903d), new NpgsqlTypes.NpgsqlPoint(x: 0.13345079494741519d, y: 0.885719367259268d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04574546061936058d, y: 0.13882735350808928d), new NpgsqlTypes.NpgsqlPoint(x: 0.39705077925550936d, y: 0.20167839464378867d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530325270813048d, y: 0.7122683453634527d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.098591870897212d, y: 0.5846886757025396d), new NpgsqlTypes.NpgsqlPoint(x: 0.09937274592582657d, y: 0.12488688364659217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392118961915431d, y: 0.14815900878626465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9092501920025782d, y: 0.31892345832918834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5510890773090686d, y: 0.7907210885124326d), new NpgsqlTypes.NpgsqlPoint(x: 0.38099887017708634d, y: 0.22172611606769532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8537689819832133d, y: 0.5734232450765164d), new NpgsqlTypes.NpgsqlPoint(x: 0.2101345186874175d, y: 0.22059684085611997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470339139331062d, y: 0.6448369970041863d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057142542978105504d, y: 0.6111833648165703d), new NpgsqlTypes.NpgsqlPoint(x: 0.33597228630848874d, y: 0.42496596981170986d), new NpgsqlTypes.NpgsqlPoint(x: 0.43644820912020066d, y: 0.6414168945231068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6512780967149404d, y: 0.9039371545621099d), new NpgsqlTypes.NpgsqlPoint(x: 0.0765693563801545d, y: 0.7574874112753072d), new NpgsqlTypes.NpgsqlPoint(x: 0.20631799559703679d, y: 0.740737791396819d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9794095909052385d, y: 0.9463472641221219d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780508723855511d, y: 0.653384657180166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218341685731712d, y: 0.06651875184176359d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31698772683433774d, y: 0.06937782433531203d), new NpgsqlTypes.NpgsqlPoint(x: 0.04238111799954536d, y: 0.47029479468160895d), new NpgsqlTypes.NpgsqlPoint(x: 0.23104126304124994d, y: 0.09553436099430612d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18956774858208425d, y: 0.483066642086475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271256316369658d, y: 0.6228448391784115d), new NpgsqlTypes.NpgsqlPoint(x: 0.36296376530974117d, y: 0.11872485854301384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4560101724520895d, y: 0.8885357534344676d), new NpgsqlTypes.NpgsqlPoint(x: 0.536511742014467d, y: 0.11328634024087991d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397907440372185d, y: 0.6737107609227714d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5090987114668452d, y: 0.044512269555690764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6976431136808008d, y: 0.0985152650921346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060245125300268d, y: 0.03033559639969685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8974761462911255d, y: 0.8416547735819587d), new NpgsqlTypes.NpgsqlPoint(x: 0.4368267110455951d, y: 0.622318551812038d), new NpgsqlTypes.NpgsqlPoint(x: 0.3687913218712493d, y: 0.7003110097895097d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9699515027893046d, y: 0.8129406437833155d), new NpgsqlTypes.NpgsqlPoint(x: 0.26278897347128893d, y: 0.0467694349907426d), new NpgsqlTypes.NpgsqlPoint(x: 0.0155164811267694d, y: 0.23243649645766262d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14761403828755149d, y: 0.05061654055019249d), new NpgsqlTypes.NpgsqlPoint(x: 0.3359267118839666d, y: 0.06208491467940713d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809411115974888d, y: 0.5133565755598871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1858046166120907d, y: 0.5731052926229938d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674471207733113d, y: 0.22925592050645216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471596246850838d, y: 0.26471459530003383d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9613479317617336d, y: 0.2813347991894274d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202717945545628d, y: 0.24042686984946748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4644557078407128d, y: 0.8722998153945298d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37403419713207076d, y: 0.7710900016651685d), new NpgsqlTypes.NpgsqlPoint(x: 0.616667759483001d, y: 0.22425500683216004d), new NpgsqlTypes.NpgsqlPoint(x: 0.22980590111948773d, y: 0.5792725115130372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37782927276158573d, y: 0.3139276081206791d), new NpgsqlTypes.NpgsqlPoint(x: 0.117114931617599d, y: 0.5056693490621673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422344918409906d, y: 0.960162813837487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8027341120650076d, y: 0.8297781180889884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825382802216264d, y: 0.44714502402724066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125108609737087d, y: 0.3344982245331569d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3702882213702974d, y: 0.8603904737977819d), new NpgsqlTypes.NpgsqlPoint(x: 0.3973826906084723d, y: 0.8172156919557158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4796301296997627d, y: 0.25109887711393764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45822706163334714d, y: 0.07218688723880595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8289734066984977d, y: 0.8429944785886866d), new NpgsqlTypes.NpgsqlPoint(x: 0.00903617872100082d, y: 0.3077266830963291d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07310700389610947d, y: 0.3820397374141856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5810256372127985d, y: 0.5915658086259353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261859347973302d, y: 0.31153184143070856d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.707924712255903d, y: 0.49664900528382516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313933733199683d, y: 0.10551564963911542d), new NpgsqlTypes.NpgsqlPoint(x: 0.4988613259709922d, y: 0.02499577882266546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34259701236896123d, y: 0.7060892378509811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6218517288650407d, y: 0.3812899501902719d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338756989472363d, y: 0.17434361384631636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1921733164493672d, y: 0.7570563688256594d), new NpgsqlTypes.NpgsqlPoint(x: 0.761316256565316d, y: 0.3621874121024913d), new NpgsqlTypes.NpgsqlPoint(x: 0.2397528736744874d, y: 0.8095876070592134d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590733183795546d, y: 0.470855050849766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618458619215109d, y: 0.04643875611731052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217644352435474d, y: 0.855930851862563d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8278438384434d, y: 0.6177997748187666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010794933588807d, y: 0.8854527883523254d), new NpgsqlTypes.NpgsqlPoint(x: 0.24845599294280196d, y: 0.7345703719130824d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8453002656953443d, y: 0.5315748907754275d), new NpgsqlTypes.NpgsqlPoint(x: 0.2914842323615462d, y: 0.13415291356131753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863253478408077d, y: 0.2933849533636358d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38598500662336355d, y: 0.946187904028281d), new NpgsqlTypes.NpgsqlPoint(x: 0.38810689055642633d, y: 0.4525193180982986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724736300761039d, y: 0.9981443999629026d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47699173167259556d, y: 0.9765990951677005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507061610629873d, y: 0.8278234045361131d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410409748657304d, y: 0.058506892875886174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8488408370502654d, y: 0.57356486618106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8247720531973078d, y: 0.862611105164994d), new NpgsqlTypes.NpgsqlPoint(x: 0.12408640449112318d, y: 0.4427449545194284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8233447956405848d, y: 0.6620267770344471d), new NpgsqlTypes.NpgsqlPoint(x: 0.22445720785857337d, y: 0.31691989439226553d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670173929828497d, y: 0.6713858577449745d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7572432230190256d, y: 0.1487383544304518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159249018826515d, y: 0.8252545023638139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264068052611883d, y: 0.271491310846641d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10640615548085741d, y: 0.740586837443125d), new NpgsqlTypes.NpgsqlPoint(x: 0.21103466005259175d, y: 0.7897724859654838d), new NpgsqlTypes.NpgsqlPoint(x: 0.019623017209557503d, y: 0.2810405276023903d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33513155138971074d, y: 0.6204354442250845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5098344485789694d, y: 0.529620553714822d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464853025048866d, y: 0.3880873088861695d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7131546975671426d, y: 0.8308756784591523d), new NpgsqlTypes.NpgsqlPoint(x: 0.26082511989265333d, y: 0.7477782141989536d), new NpgsqlTypes.NpgsqlPoint(x: 0.05804614447073053d, y: 0.32835085636150096d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04578622053317205d, y: 0.2370295439677892d), new NpgsqlTypes.NpgsqlPoint(x: 0.25984350486551877d, y: 0.7670034145056681d), new NpgsqlTypes.NpgsqlPoint(x: 0.12873391571728998d, y: 0.45073577328220016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.124653865724762d, y: 0.4209063859208648d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361655676313285d, y: 0.921517599928679d), new NpgsqlTypes.NpgsqlPoint(x: 0.12507717695366527d, y: 0.8071483213255783d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6487020224933508d, y: 0.7071914251496451d), new NpgsqlTypes.NpgsqlPoint(x: 0.9125566885130139d, y: 0.9564838642184986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9553923221094284d, y: 0.959294033090914d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2479517435623132d, y: 0.7295709508802063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016220307442056d, y: 0.41719160341241623d), new NpgsqlTypes.NpgsqlPoint(x: 0.9265685387791842d, y: 0.057204929524983905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5485041096612697d, y: 0.06544514639088783d), new NpgsqlTypes.NpgsqlPoint(x: 0.09175286295886387d, y: 0.9875702049033591d), new NpgsqlTypes.NpgsqlPoint(x: 0.5417121952194031d, y: 0.7305124074695021d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18455437732580438d, y: 0.846237687257645d), new NpgsqlTypes.NpgsqlPoint(x: 0.2663401059637688d, y: 0.884625668649897d), new NpgsqlTypes.NpgsqlPoint(x: 0.05199811543594268d, y: 0.8129161042702442d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7434143247647489d, y: 0.2765449667600639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906707690946936d, y: 0.6546366104872012d), new NpgsqlTypes.NpgsqlPoint(x: 0.2874020863462916d, y: 0.15109691575403106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7972981701881201d, y: 0.4496722322758928d), new NpgsqlTypes.NpgsqlPoint(x: 0.43143271908046d, y: 0.08635306014272182d), new NpgsqlTypes.NpgsqlPoint(x: 0.4232011157197235d, y: 0.04781186255988046d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8095226356899723d, y: 0.6726849295414479d), new NpgsqlTypes.NpgsqlPoint(x: 0.14891689187960777d, y: 0.8885299376584148d), new NpgsqlTypes.NpgsqlPoint(x: 0.47783372021737935d, y: 0.1785501642084537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3332325309020746d, y: 0.4938050193100789d), new NpgsqlTypes.NpgsqlPoint(x: 0.7392812777522819d, y: 0.6179520329761294d), new NpgsqlTypes.NpgsqlPoint(x: 0.525249737720032d, y: 0.1512560723452292d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35188193914723986d, y: 0.946818756203871d), new NpgsqlTypes.NpgsqlPoint(x: 0.4999640451964329d, y: 0.7822508800565818d), new NpgsqlTypes.NpgsqlPoint(x: 0.9189367596244872d, y: 0.20404152402045328d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45853636537797526d, y: 0.7399232302016978d), new NpgsqlTypes.NpgsqlPoint(x: 0.39662887418436066d, y: 0.22369408150666337d), new NpgsqlTypes.NpgsqlPoint(x: 0.823221478977464d, y: 0.4873811232717312d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.478519235297689d, y: 0.29926324355222345d), new NpgsqlTypes.NpgsqlPoint(x: 0.049850162043782564d, y: 0.8984887339382257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981232411052137d, y: 0.9107232691905384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5312801972097403d, y: 0.9592104587093806d), new NpgsqlTypes.NpgsqlPoint(x: 0.008096880717740285d, y: 0.8652485705493087d), new NpgsqlTypes.NpgsqlPoint(x: 0.40263420151804075d, y: 0.572287705641179d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5775758987426777d, y: 0.41844751079298403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256331182161261d, y: 0.1568259008216013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769776292655245d, y: 0.9610032817380061d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3382956531802024d, y: 0.8350085329751622d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149641756556747d, y: 0.39351664439202516d), new NpgsqlTypes.NpgsqlPoint(x: 0.41953234663160965d, y: 0.9218636968715667d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3317716628115063d, y: 0.256551712767908d), new NpgsqlTypes.NpgsqlPoint(x: 0.3263572927121108d, y: 0.06861306962047331d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465629042740874d, y: 0.20162629137701005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9651418519740746d, y: 0.4016994708911785d), new NpgsqlTypes.NpgsqlPoint(x: 0.04772315417323225d, y: 0.5942391964621468d), new NpgsqlTypes.NpgsqlPoint(x: 0.47638370091839766d, y: 0.07909705166505476d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18602584224919716d, y: 0.1004869908286562d), new NpgsqlTypes.NpgsqlPoint(x: 0.1243239907902185d, y: 0.534724190163298d), new NpgsqlTypes.NpgsqlPoint(x: 0.19577741149561478d, y: 0.39129557675398097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6804361324207276d, y: 0.6401555145434225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146821468835717d, y: 0.047828122486593516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8631318493339384d, y: 0.17492453643435257d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4902390638347398d, y: 0.9760307267349767d), new NpgsqlTypes.NpgsqlPoint(x: 0.756959292519056d, y: 0.43339358984382015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6076443671810137d, y: 0.18847877836632432d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2508038575435546d, y: 0.8432315669058701d), new NpgsqlTypes.NpgsqlPoint(x: 0.1600618700075651d, y: 0.2677842521777415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522440678377328d, y: 0.6061670447362308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26449299398766335d, y: 0.9763624953650011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5915664119261234d, y: 0.26883679288832696d), new NpgsqlTypes.NpgsqlPoint(x: 0.453441848733925d, y: 0.7597573589060815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6572064051720653d, y: 0.41093627513854647d), new NpgsqlTypes.NpgsqlPoint(x: 0.260744865145371d, y: 0.8678727842056231d), new NpgsqlTypes.NpgsqlPoint(x: 0.45662313009828104d, y: 0.1072214364062184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9281680620929017d, y: 0.8203440914190511d), new NpgsqlTypes.NpgsqlPoint(x: 0.27246741221892035d, y: 0.8188220732238121d), new NpgsqlTypes.NpgsqlPoint(x: 0.22927744371059255d, y: 0.16340111997995566d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17110329796438895d, y: 0.9848176868402722d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535232591430227d, y: 0.20240116525468888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8293021286327251d, y: 0.05341317256095168d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18809696689551858d, y: 0.14120485859839793d), new NpgsqlTypes.NpgsqlPoint(x: 0.24782122764156544d, y: 0.4198423552036932d), new NpgsqlTypes.NpgsqlPoint(x: 0.029591036285816275d, y: 0.5902974501525389d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21617074562620076d, y: 0.16009351170850794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013289388806506d, y: 0.24358050732983205d), new NpgsqlTypes.NpgsqlPoint(x: 0.4576317817050066d, y: 0.7080560083100266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16487938039137473d, y: 0.708877470563972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888587823174458d, y: 0.30304785544028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747516838094822d, y: 0.33255540630110025d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5700955235653575d, y: 0.9835008253229605d), new NpgsqlTypes.NpgsqlPoint(x: 0.07129151062836336d, y: 0.5488995760684772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9610713840947078d, y: 0.8156278132645781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8192089285424907d, y: 0.42238539075303283d), new NpgsqlTypes.NpgsqlPoint(x: 0.20485044573774536d, y: 0.5902463534584774d), new NpgsqlTypes.NpgsqlPoint(x: 0.10938476833707889d, y: 0.8530091083180028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4262850379130474d, y: 0.6603392261765351d), new NpgsqlTypes.NpgsqlPoint(x: 0.016919462125519424d, y: 0.12727088348043225d), new NpgsqlTypes.NpgsqlPoint(x: 0.211666575427376d, y: 0.2581308368046633d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9328330785476399d, y: 0.48676316611160864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420898093576585d, y: 0.8076262848234813d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943960939658024d, y: 0.25400743163662565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47218775929520407d, y: 0.929893230491118d), new NpgsqlTypes.NpgsqlPoint(x: 0.47690931206592513d, y: 0.3207436511293338d), new NpgsqlTypes.NpgsqlPoint(x: 0.536384943445018d, y: 0.3320204788329211d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2911743166762689d, y: 0.7637926331637234d), new NpgsqlTypes.NpgsqlPoint(x: 0.45378842618783455d, y: 0.5764543898248227d), new NpgsqlTypes.NpgsqlPoint(x: 0.05469533181375197d, y: 0.3678368314567455d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0011886899603972267d, y: 0.5846215357192523d), new NpgsqlTypes.NpgsqlPoint(x: 0.31797470671523187d, y: 0.36892111157856133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8466484145862776d, y: 0.4710856202005015d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7493079649570699d, y: 0.37573580211775415d), new NpgsqlTypes.NpgsqlPoint(x: 0.2877443602343792d, y: 0.3966912551014111d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746112485847307d, y: 0.2653255737306516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32628697755212377d, y: 0.6331206741117783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5336895682822096d, y: 0.42828423634892854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009385312677994d, y: 0.493301961655924d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2802390203256975d, y: 0.6605735993051656d), new NpgsqlTypes.NpgsqlPoint(x: 0.29701366844440635d, y: 0.3269148365229163d), new NpgsqlTypes.NpgsqlPoint(x: 0.18086160588423938d, y: 0.7290956556183827d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7100861042231984d, y: 0.15626147320435368d), new NpgsqlTypes.NpgsqlPoint(x: 0.786116898252884d, y: 0.7066837814989662d), new NpgsqlTypes.NpgsqlPoint(x: 0.18577874083297852d, y: 0.4327781247307846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7854583148776847d, y: 0.19123443922683592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021244633000117d, y: 0.5158933273151628d), new NpgsqlTypes.NpgsqlPoint(x: 0.6736680634797186d, y: 0.6206145293490621d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28976195424208717d, y: 0.13994466823526786d), new NpgsqlTypes.NpgsqlPoint(x: 0.07929010166692996d, y: 0.1560960990497683d), new NpgsqlTypes.NpgsqlPoint(x: 0.06649710697279954d, y: 0.6964287087046923d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7245936750082823d, y: 0.8100085744652108d), new NpgsqlTypes.NpgsqlPoint(x: 0.08511566713214336d, y: 0.39185399304623336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177490664267881d, y: 0.1971872738135464d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8194204000681697d, y: 0.8214640381961184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465654054761663d, y: 0.348745825392867d), new NpgsqlTypes.NpgsqlPoint(x: 0.43712162501615925d, y: 0.4260255541485405d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8416889992917032d, y: 0.4319108768082076d), new NpgsqlTypes.NpgsqlPoint(x: 0.2862923975052277d, y: 0.43318109328947474d), new NpgsqlTypes.NpgsqlPoint(x: 0.40629657564867827d, y: 0.40600278845757065d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32902662349581413d, y: 0.8039115253412632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8995951104253546d, y: 0.5595137963755233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7087464629920617d, y: 0.3041639994542177d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3136011342062801d, y: 0.6988684006664734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060687870886846d, y: 0.8482644005046446d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513276343407005d, y: 0.3248721037650467d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7179324396352271d, y: 0.7333537263918707d), new NpgsqlTypes.NpgsqlPoint(x: 0.03854476541603269d, y: 0.23620550159575593d), new NpgsqlTypes.NpgsqlPoint(x: 0.9985116162875127d, y: 0.15303932963243538d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9907740061319994d, y: 0.9000764560451554d), new NpgsqlTypes.NpgsqlPoint(x: 0.5745886682425051d, y: 0.5851088826153349d), new NpgsqlTypes.NpgsqlPoint(x: 0.17713164896794642d, y: 0.049610050285852414d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9616068366729463d, y: 0.0608280362288407d), new NpgsqlTypes.NpgsqlPoint(x: 0.21215345340777114d, y: 0.11550246333722713d), new NpgsqlTypes.NpgsqlPoint(x: 0.43988475905430013d, y: 0.36634020092870456d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05346977797181429d, y: 0.4837192026214985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394485055077825d, y: 0.40555386965564666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7414716903418928d, y: 0.9229296608149484d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4914077554052374d, y: 0.5078934451898249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291975929015219d, y: 0.2042174533508022d), new NpgsqlTypes.NpgsqlPoint(x: 0.940716432404713d, y: 0.1159094371171493d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2592020648727721d, y: 0.8508832269396447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399799683780303d, y: 0.011131465836739074d), new NpgsqlTypes.NpgsqlPoint(x: 0.08492791215188278d, y: 0.24565091660029625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31369299769881764d, y: 0.795305581111705d), new NpgsqlTypes.NpgsqlPoint(x: 0.2078924559545654d, y: 0.8319910083387312d), new NpgsqlTypes.NpgsqlPoint(x: 0.2664743358353955d, y: 0.6760610585577387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9259492088507222d, y: 0.3436170210604308d), new NpgsqlTypes.NpgsqlPoint(x: 0.060594723223921454d, y: 0.7188104039539012d), new NpgsqlTypes.NpgsqlPoint(x: 0.1251088170549851d, y: 0.8450984542685323d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7540382986665498d, y: 0.8821375259142762d), new NpgsqlTypes.NpgsqlPoint(x: 0.67179707515915d, y: 0.45050374175453867d), new NpgsqlTypes.NpgsqlPoint(x: 0.653818865576557d, y: 0.9401513636443359d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17453715798521474d, y: 0.6236145947701057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8054062036181288d, y: 0.5025147607950724d), new NpgsqlTypes.NpgsqlPoint(x: 0.18923482618038845d, y: 0.6623355369044797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06894554324307467d, y: 0.6033164162589991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245980839879905d, y: 0.5620000491160494d), new NpgsqlTypes.NpgsqlPoint(x: 0.12157283394095475d, y: 0.4062683174202455d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10133122665305028d, y: 0.35958941916484044d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394756285543564d, y: 0.8513907545232557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6154424213296718d, y: 0.6840303633589718d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7921244362409057d, y: 0.397819843380009d), new NpgsqlTypes.NpgsqlPoint(x: 0.996961113943d, y: 0.16181090802631004d), new NpgsqlTypes.NpgsqlPoint(x: 0.22968876492313572d, y: 0.2666509470934063d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19407008689578986d, y: 0.25666302929532847d), new NpgsqlTypes.NpgsqlPoint(x: 0.40399010190107154d, y: 0.4125713049233396d), new NpgsqlTypes.NpgsqlPoint(x: 0.04983216747557584d, y: 0.5426373434738674d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5301013402325958d, y: 0.9265460348435796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6553251967302733d, y: 0.6535695275914151d), new NpgsqlTypes.NpgsqlPoint(x: 0.06077246267422032d, y: 0.13689476973458425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38270484459504694d, y: 0.011912403009257777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9916111835331055d, y: 0.4030649233253335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078985997671983d, y: 0.7518837464957216d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8918054739395148d, y: 0.4975467664600234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6571448421887748d, y: 0.2345899814485386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134159264350046d, y: 0.6969150495819508d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30174901343574867d, y: 0.6361814519153892d), new NpgsqlTypes.NpgsqlPoint(x: 0.06385484803530861d, y: 0.061231199934854375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464167612537397d, y: 0.41701766736362433d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08284235341994828d, y: 0.37146160018763463d), new NpgsqlTypes.NpgsqlPoint(x: 0.36955920847666945d, y: 0.835031716514457d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850543363497898d, y: 0.40116818114477426d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15082619252817253d, y: 0.4227648749449091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8597239702619078d, y: 0.9440408961427802d), new NpgsqlTypes.NpgsqlPoint(x: 0.01068940490935244d, y: 0.8772000090072088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39970687624900036d, y: 0.4978497616329599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943131853728894d, y: 0.5059373476433431d), new NpgsqlTypes.NpgsqlPoint(x: 0.08096790518776054d, y: 0.18330411419683745d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4749736307828404d, y: 0.5572131517357483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9368734609548895d, y: 0.49865298452037443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978991243998236d, y: 0.6846981198351781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8375998904438546d, y: 0.25224077448849236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493792485779343d, y: 0.4906210549259904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257206438507132d, y: 0.8646628922507333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08342957472466617d, y: 0.3658596594384208d), new NpgsqlTypes.NpgsqlPoint(x: 0.18377997967208037d, y: 0.4776442047811017d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666795686352079d, y: 0.09439870754991353d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2209881100852379d, y: 0.37662165238498657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5941402128847193d, y: 0.9481234189327461d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414126343962899d, y: 0.25070996994746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6578840528538397d, y: 0.4586655328878557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4949440222601228d, y: 0.9061004464871423d), new NpgsqlTypes.NpgsqlPoint(x: 0.24927895116593568d, y: 0.2851679109270441d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18904603326709457d, y: 0.019008351785844257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303433706978656d, y: 0.9870703408108106d), new NpgsqlTypes.NpgsqlPoint(x: 0.3415800667467662d, y: 0.015057662129849714d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.321365594711d, y: 0.637273674663646d), new NpgsqlTypes.NpgsqlPoint(x: 0.07976712687574428d, y: 0.884540154360148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8541221514216851d, y: 0.5730663465520944d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.719502922571656d, y: 0.8319905374323613d), new NpgsqlTypes.NpgsqlPoint(x: 0.3289877570953105d, y: 0.5363545673024733d), new NpgsqlTypes.NpgsqlPoint(x: 0.39869959709588176d, y: 0.5821759811536533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7780648145215315d, y: 0.6665306653121765d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529862950729733d, y: 0.7222543854891715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3418019833290421d, y: 0.45095443022418125d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1801515334907533d, y: 0.9349362477165307d), new NpgsqlTypes.NpgsqlPoint(x: 0.20867032812443753d, y: 0.9161460960257031d), new NpgsqlTypes.NpgsqlPoint(x: 0.842152683684331d, y: 0.8205399881191482d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10915438845734293d, y: 0.21619264993447862d), new NpgsqlTypes.NpgsqlPoint(x: 0.0563850338580999d, y: 0.5712767339344177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449474663930151d, y: 0.928609333186146d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03326677078586904d, y: 0.9254442655296462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105559690312d, y: 0.303906751161497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567239315507228d, y: 0.5719129755459683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33247122242822d, y: 0.9047510739564357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5475535348579232d, y: 0.5587638903432961d), new NpgsqlTypes.NpgsqlPoint(x: 0.10338788668055243d, y: 0.10963032614993107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9085816372343125d, y: 0.1969614256901303d), new NpgsqlTypes.NpgsqlPoint(x: 0.006744792509114639d, y: 0.2463318071191376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5833440677424909d, y: 0.2530750117974938d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5921991800381693d, y: 0.9133070269943646d), new NpgsqlTypes.NpgsqlPoint(x: 0.759012986244603d, y: 0.9101079946134897d), new NpgsqlTypes.NpgsqlPoint(x: 0.874400606835954d, y: 0.1616489139727204d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2542632128721982d, y: 0.6493946938043845d), new NpgsqlTypes.NpgsqlPoint(x: 0.04815630777304747d, y: 0.8688895328262574d), new NpgsqlTypes.NpgsqlPoint(x: 0.39973457177614113d, y: 0.8619447510173033d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35581777265646863d, y: 0.7897140402548815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8858869788345701d, y: 0.7864877586748563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388349560132376d, y: 0.9137107268374153d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3698175568811499d, y: 0.3675093349084365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6234159435520724d, y: 0.7671702356990139d), new NpgsqlTypes.NpgsqlPoint(x: 0.4968707553285945d, y: 0.31622863098261145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31396812514814787d, y: 0.8859177811364164d), new NpgsqlTypes.NpgsqlPoint(x: 0.5769317290000192d, y: 0.635898597206482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884459691438605d, y: 0.7862579298127181d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.842719445375124d, y: 0.7014556333529942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875224505200564d, y: 0.5872668180878432d), new NpgsqlTypes.NpgsqlPoint(x: 0.5588838797174654d, y: 0.11325690399191535d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.477656384918694d, y: 0.613808825404194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198566896883756d, y: 0.45857567211695804d), new NpgsqlTypes.NpgsqlPoint(x: 0.4966650457329703d, y: 0.6938315386041728d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2070982838937031d, y: 0.8922263514390655d), new NpgsqlTypes.NpgsqlPoint(x: 0.1456272861542629d, y: 0.6939114390343952d), new NpgsqlTypes.NpgsqlPoint(x: 0.11261236894520732d, y: 0.6044697736368054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2269989332176494d, y: 0.15690161425601412d), new NpgsqlTypes.NpgsqlPoint(x: 0.37274825353514585d, y: 0.4247306125696567d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880649978803984d, y: 0.7081537479775931d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3218736095375234d, y: 0.22221564018513285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032213885756998d, y: 0.05031108928794459d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155503921095768d, y: 0.9938835652007523d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5752254706538544d, y: 0.7964857017727238d), new NpgsqlTypes.NpgsqlPoint(x: 0.776719676486003d, y: 0.041132748355560134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7174729771242174d, y: 0.34096890269228497d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8350929325094439d, y: 0.42894294885713147d), new NpgsqlTypes.NpgsqlPoint(x: 0.1442777602597347d, y: 0.46581504531621587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179611166122237d, y: 0.5330108396256273d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1425238552345608d, y: 0.7753013588479881d), new NpgsqlTypes.NpgsqlPoint(x: 0.45402786818367535d, y: 0.5825928668974785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230379684387779d, y: 0.8137971652452035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023117350773016354d, y: 0.2206858600863536d), new NpgsqlTypes.NpgsqlPoint(x: 0.4792141688662316d, y: 0.9901474369217992d), new NpgsqlTypes.NpgsqlPoint(x: 0.20063709580271705d, y: 0.849459429185635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14636411030677088d, y: 0.8899414984317064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358694262266796d, y: 0.06373836131419808d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017339663419813078d, y: 0.9005444828320426d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054677576534249206d, y: 0.40291026502683613d), new NpgsqlTypes.NpgsqlPoint(x: 0.0946710705764583d, y: 0.79008150715644d), new NpgsqlTypes.NpgsqlPoint(x: 0.35259016197402204d, y: 0.09629631381282955d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06455335211058388d, y: 0.15827149624575032d), new NpgsqlTypes.NpgsqlPoint(x: 0.21451494916036606d, y: 0.967032945996444d), new NpgsqlTypes.NpgsqlPoint(x: 0.3539645742669367d, y: 0.9562348731721909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9538701599516568d, y: 0.12480615857011357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242545335350415d, y: 0.0394608306159292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6784614633779257d, y: 0.40892921533283566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17303719023514108d, y: 0.8866171397760764d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360037104181731d, y: 0.6856477349010034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8563231043269944d, y: 0.1724366246837885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8771473624611782d, y: 0.3226357896732358d), new NpgsqlTypes.NpgsqlPoint(x: 0.9809051528938559d, y: 0.7231609664959393d), new NpgsqlTypes.NpgsqlPoint(x: 0.931722828261147d, y: 0.1975516122104921d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21458553821087367d, y: 0.6784845417923832d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477689889783496d, y: 0.5228643772898827d), new NpgsqlTypes.NpgsqlPoint(x: 0.2873302018340739d, y: 0.24659784342268531d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3389634134819953d, y: 0.6039714289019597d), new NpgsqlTypes.NpgsqlPoint(x: 0.052246530565390414d, y: 0.7320208936665845d), new NpgsqlTypes.NpgsqlPoint(x: 0.004685741980834601d, y: 0.1993436999249305d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012891938208343d, y: 0.7064787258349302d), new NpgsqlTypes.NpgsqlPoint(x: 0.22208516360675745d, y: 0.8747068013119993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6558466392143699d, y: 0.8752135347149956d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43550429883167074d, y: 0.3356865751959951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914301892267411d, y: 0.3382139341653192d), new NpgsqlTypes.NpgsqlPoint(x: 0.09630773185989872d, y: 0.3569084993106676d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08049821546413116d, y: 0.7484717655527583d), new NpgsqlTypes.NpgsqlPoint(x: 0.2495685931840168d, y: 0.510462229038724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3046685298274181d, y: 0.2662142528294753d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.262260035827533d, y: 0.9574251826443366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557342865678842d, y: 0.9349703343186337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965557335202809d, y: 0.31520646407114283d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09567979758207401d, y: 0.4226239319639553d), new NpgsqlTypes.NpgsqlPoint(x: 0.6659422629009939d, y: 0.39363869387324024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5202880118291755d, y: 0.41321122039869085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5561122495512699d, y: 0.39207686046698d), new NpgsqlTypes.NpgsqlPoint(x: 0.25837934422077624d, y: 0.2701823027204846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118966769045569d, y: 0.1557466041061354d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8240276454465402d, y: 0.12639191789652704d), new NpgsqlTypes.NpgsqlPoint(x: 0.21880819253739892d, y: 0.49965547250694975d), new NpgsqlTypes.NpgsqlPoint(x: 0.1693846625136235d, y: 0.8133326652340619d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12948273202575644d, y: 0.7582778735051862d), new NpgsqlTypes.NpgsqlPoint(x: 0.857249904988234d, y: 0.8352518775936603d), new NpgsqlTypes.NpgsqlPoint(x: 0.09477224252151428d, y: 0.32165009468638184d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4783238756195818d, y: 0.817211741479536d), new NpgsqlTypes.NpgsqlPoint(x: 0.12875526146609673d, y: 0.7039962363860718d), new NpgsqlTypes.NpgsqlPoint(x: 0.2298855256470872d, y: 0.4403066241499507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.382710818793237d, y: 0.436449533965493d), new NpgsqlTypes.NpgsqlPoint(x: 0.9743159175800628d, y: 0.8369835702946736d), new NpgsqlTypes.NpgsqlPoint(x: 0.07810366437911953d, y: 0.027329617482709567d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.689665289740603d, y: 0.9845583175350145d), new NpgsqlTypes.NpgsqlPoint(x: 0.16431390404900426d, y: 0.5884677172654644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021226229406211d, y: 0.8357615073716501d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1758416778364572d, y: 0.47168950864530723d), new NpgsqlTypes.NpgsqlPoint(x: 0.28505109775308046d, y: 0.5105290742939586d), new NpgsqlTypes.NpgsqlPoint(x: 0.21565204109275993d, y: 0.15416946773600737d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9721209722203159d, y: 0.283565622960836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255672339767786d, y: 0.38682140962449796d), new NpgsqlTypes.NpgsqlPoint(x: 0.39756786898995256d, y: 0.5050451868674323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16320542951599593d, y: 0.9918445497470625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4293522074740743d, y: 0.3769557366290345d), new NpgsqlTypes.NpgsqlPoint(x: 0.6579762952411966d, y: 0.8554753762518018d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8778817269910058d, y: 0.5459974926622954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815350555374713d, y: 0.10220587866625586d), new NpgsqlTypes.NpgsqlPoint(x: 0.6794385574383526d, y: 0.3416582154669796d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04244292955661d, y: 0.35939293534859085d), new NpgsqlTypes.NpgsqlPoint(x: 0.874566940948821d, y: 0.47857184965791977d), new NpgsqlTypes.NpgsqlPoint(x: 0.19550997090093603d, y: 0.7510753169181538d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42347847342982936d, y: 0.7525000398911695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4374243234336189d, y: 0.997720233509488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882545319827745d, y: 0.6990539972053964d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5442229082711889d, y: 0.7542532090690784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6780412637224418d, y: 0.6748778536776472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6335022270382643d, y: 0.8738359626760235d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.993945848005383d, y: 0.6543958373368423d), new NpgsqlTypes.NpgsqlPoint(x: 0.32270316014033074d, y: 0.683224016734284d), new NpgsqlTypes.NpgsqlPoint(x: 0.025091245535119322d, y: 0.9445183110673023d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7840574143006191d, y: 0.2234864820121406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6042888422207768d, y: 0.10474648090864525d), new NpgsqlTypes.NpgsqlPoint(x: 0.14709811101045533d, y: 0.2374308443718448d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1730268558488004d, y: 0.23095829124672473d), new NpgsqlTypes.NpgsqlPoint(x: 0.413615400630186d, y: 0.7461853811952445d), new NpgsqlTypes.NpgsqlPoint(x: 0.26106072942215786d, y: 0.41559812614830227d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6446134296931046d, y: 0.06095510564612405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867049904892156d, y: 0.32285571171050886d), new NpgsqlTypes.NpgsqlPoint(x: 0.21043106140097567d, y: 0.69066102872258d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8528364194487252d, y: 0.4280219628416976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547453320940878d, y: 0.07077897887081863d), new NpgsqlTypes.NpgsqlPoint(x: 0.22542005604736703d, y: 0.11611129573967849d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.413573219062752d, y: 0.09821746231984996d), new NpgsqlTypes.NpgsqlPoint(x: 0.19188543628703225d, y: 0.9988928449109105d), new NpgsqlTypes.NpgsqlPoint(x: 0.569547015359764d, y: 0.39075352834832233d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7287084814543753d, y: 0.6688117263840081d), new NpgsqlTypes.NpgsqlPoint(x: 0.49244833840584323d, y: 0.434228358161974d), new NpgsqlTypes.NpgsqlPoint(x: 0.49612692909773437d, y: 0.147910587242721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13161770786156657d, y: 0.8189543181258631d), new NpgsqlTypes.NpgsqlPoint(x: 0.24994539746151057d, y: 0.32768299074806806d), new NpgsqlTypes.NpgsqlPoint(x: 0.029918999479695896d, y: 0.04512400679278816d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6336919079029951d, y: 0.15765768124362034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077639569551806d, y: 0.945633027624391d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624548078950797d, y: 0.720850662676908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2682541248412449d, y: 0.9823118307122796d), new NpgsqlTypes.NpgsqlPoint(x: 0.1464759882891833d, y: 0.031676440093256875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7815249053202823d, y: 0.7564417069037825d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7913272928885032d, y: 0.2672202642409194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632090497018104d, y: 0.4515364648055218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9318907491351216d, y: 0.9608168721266568d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.865825915601194d, y: 0.08328133772466928d), new NpgsqlTypes.NpgsqlPoint(x: 0.06244180976869007d, y: 0.3028208220631281d), new NpgsqlTypes.NpgsqlPoint(x: 0.11504149780732309d, y: 0.12291644528440793d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3553680349980637d, y: 0.6226300483228296d), new NpgsqlTypes.NpgsqlPoint(x: 0.1296545709566007d, y: 0.3367963244473825d), new NpgsqlTypes.NpgsqlPoint(x: 0.48462638923757795d, y: 0.8935711544193504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32152308247123884d, y: 0.056032772359300265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560465719160862d, y: 0.34784994678091885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921627030674798d, y: 0.3576820177569068d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.495829677587624d, y: 0.9973230349074282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6340132204724033d, y: 0.23463337504591708d), new NpgsqlTypes.NpgsqlPoint(x: 0.38446206409777495d, y: 0.8871221851172784d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5617877258538783d, y: 0.30512836037800584d), new NpgsqlTypes.NpgsqlPoint(x: 0.798139130048714d, y: 0.47549001092540144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368520340599365d, y: 0.30248442479272153d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3535023571417313d, y: 0.9409149410962719d), new NpgsqlTypes.NpgsqlPoint(x: 0.15648202441349857d, y: 0.91117477006145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598397726503575d, y: 0.6049571429188977d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6062727721420191d, y: 0.6449525191809793d), new NpgsqlTypes.NpgsqlPoint(x: 0.40655359653373113d, y: 0.6113726063045549d), new NpgsqlTypes.NpgsqlPoint(x: 0.4934914156253878d, y: 0.1178522451884898d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8820270915375159d, y: 0.495434892394769d), new NpgsqlTypes.NpgsqlPoint(x: 0.23893618352401935d, y: 0.2267586357757414d), new NpgsqlTypes.NpgsqlPoint(x: 0.1452886994702962d, y: 0.27875125702027503d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6976108731490412d, y: 0.5275452626993964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4308769816960326d, y: 0.8362368555473638d), new NpgsqlTypes.NpgsqlPoint(x: 0.3552852048088011d, y: 0.12378843250967497d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5672160917198722d, y: 0.8656562528335774d), new NpgsqlTypes.NpgsqlPoint(x: 0.4137236663891485d, y: 0.0015786952123318931d), new NpgsqlTypes.NpgsqlPoint(x: 0.2189009200379025d, y: 0.8752934955713249d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4455632171711216d, y: 0.7106932322896052d), new NpgsqlTypes.NpgsqlPoint(x: 0.40297821234141007d, y: 0.6238988284048856d), new NpgsqlTypes.NpgsqlPoint(x: 0.3452229833663074d, y: 0.45700907077445496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5554257631060966d, y: 0.11610571432065608d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314997698814253d, y: 0.24424947686193288d), new NpgsqlTypes.NpgsqlPoint(x: 0.31528914280941045d, y: 0.08454916324464967d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1148188008860993d, y: 0.4481899541852995d), new NpgsqlTypes.NpgsqlPoint(x: 0.05671313975642467d, y: 0.06610136580904091d), new NpgsqlTypes.NpgsqlPoint(x: 0.43867424815594d, y: 0.6685308488023243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.425604903145553d, y: 0.8628499206429543d), new NpgsqlTypes.NpgsqlPoint(x: 0.014317732060406652d, y: 0.13999850427356886d), new NpgsqlTypes.NpgsqlPoint(x: 0.28240816981540096d, y: 0.1261700206794979d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7594206608396804d, y: 0.6353182862639529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2045266567326629d, y: 0.35953219407909165d), new NpgsqlTypes.NpgsqlPoint(x: 0.574161984653685d, y: 0.1613774066539203d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21950851686890938d, y: 0.0357826603453012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842173947022341d, y: 0.17305380232275736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6584366858661853d, y: 0.21001574540741585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6538670065787406d, y: 0.3189392449264197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833979711229502d, y: 0.5881553362499986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413724224398052d, y: 0.8768821361410978d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.691207030107704d, y: 0.3003794715588609d), new NpgsqlTypes.NpgsqlPoint(x: 0.18033823304414487d, y: 0.22820177827448274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6170187074709554d, y: 0.6291985293300884d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4830904637785719d, y: 0.7451012492897728d), new NpgsqlTypes.NpgsqlPoint(x: 0.15729429999081546d, y: 0.025651693670092013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561631881263764d, y: 0.04826857573132348d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34389579053777175d, y: 0.4372957831410751d), new NpgsqlTypes.NpgsqlPoint(x: 0.03149849183488518d, y: 0.3129973577851177d), new NpgsqlTypes.NpgsqlPoint(x: 0.08232825444734648d, y: 0.5028982604592777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7745607714643851d, y: 0.44513943101451336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9226109861610434d, y: 0.1609454950229523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7931322631729225d, y: 0.07539209542228376d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6803703014312619d, y: 0.9458295919500769d), new NpgsqlTypes.NpgsqlPoint(x: 0.11408469398281196d, y: 0.8990079374521976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397842562468284d, y: 0.0203914374672034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24904961205858445d, y: 0.4570882537147596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6534640575149193d, y: 0.589871349693532d), new NpgsqlTypes.NpgsqlPoint(x: 0.032355772954760664d, y: 0.09429313329988565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8999829640886005d, y: 0.4866029504074988d), new NpgsqlTypes.NpgsqlPoint(x: 0.37066923739754665d, y: 0.9273573635428093d), new NpgsqlTypes.NpgsqlPoint(x: 0.12128288700757084d, y: 0.7185015883436023d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7163494747720937d, y: 0.8047610475879158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4847478827937898d, y: 0.3300901056518406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8452601629163091d, y: 0.2920403788055136d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35248186728836295d, y: 0.40496012546238147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432443545341118d, y: 0.25741839206476236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2556337535275601d, y: 0.5407493797353464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8198695063680336d, y: 0.7399589768374032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116138790836373d, y: 0.6589740461829694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680002315157393d, y: 0.17618104256233313d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4350777408863499d, y: 0.3151624566795017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531737714948137d, y: 0.9357349614108837d), new NpgsqlTypes.NpgsqlPoint(x: 0.1261594310633274d, y: 0.37277942601732994d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805013799641092d, y: 0.9425575595706471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895859427626976d, y: 0.1244829902561948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9696512506068881d, y: 0.2610721725679551d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5189880935583814d, y: 0.18571164099541415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171296673580601d, y: 0.9125023865564539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511731362294537d, y: 0.23842139836452014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7575136832452662d, y: 0.2708778129771078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371477009347023d, y: 0.6137247928827662d), new NpgsqlTypes.NpgsqlPoint(x: 0.31902704850169983d, y: 0.196106150641159d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2482075320014251d, y: 0.2766250131952508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234755080801818d, y: 0.5168362508818473d), new NpgsqlTypes.NpgsqlPoint(x: 0.23602404078577366d, y: 0.9342651147504978d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14869792150829575d, y: 0.5252407583943868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5441730870695373d, y: 0.3664210818382392d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601818571503828d, y: 0.8563273561048164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48533267002880687d, y: 0.19711650966972394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707026334052153d, y: 0.5181154092317809d), new NpgsqlTypes.NpgsqlPoint(x: 0.39173617437592545d, y: 0.43081204561508857d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.591002326760235d, y: 0.8351757206497605d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675993224204423d, y: 0.7091242800395149d), new NpgsqlTypes.NpgsqlPoint(x: 0.3329785535491232d, y: 0.30614286631946197d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48880031471751484d, y: 0.6688682878708347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138614739504615d, y: 0.9785089859129729d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731100766890505d, y: 0.4653364388828545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3142840485651568d, y: 0.6691750775451901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639639456795467d, y: 0.9695238728014827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3986989243308715d, y: 0.006700394593090797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9278242028712308d, y: 0.5552292141046242d), new NpgsqlTypes.NpgsqlPoint(x: 0.38204400955316564d, y: 0.5495339067343217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263990246937179d, y: 0.755909623735371d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05357702414009213d, y: 0.04466336948201277d), new NpgsqlTypes.NpgsqlPoint(x: 0.3553881324445112d, y: 0.642009843559163d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426589799236702d, y: 0.7390700094446357d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06109180231951228d, y: 0.24903136141636872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5638712872663978d, y: 0.5263750793596418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8709738414472016d, y: 0.496606020737008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24041304097210703d, y: 0.16162259654656097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5318381980615117d, y: 0.004475160659978439d), new NpgsqlTypes.NpgsqlPoint(x: 0.09613764475082398d, y: 0.2050670999600942d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0785442333501829d, y: 0.9049264670973765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9081647325890513d, y: 0.9441081215937428d), new NpgsqlTypes.NpgsqlPoint(x: 0.044028676338778494d, y: 0.6173387655688912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4066695331799166d, y: 0.40494100152278d), new NpgsqlTypes.NpgsqlPoint(x: 0.039701540537626645d, y: 0.059508198582629124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5518127016100811d, y: 0.010460530231646281d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1910717714935134d, y: 0.9446242531639245d), new NpgsqlTypes.NpgsqlPoint(x: 0.08591745379386384d, y: 0.5045082097092307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170324117794167d, y: 0.045209671439210286d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10571159429540089d, y: 0.8146407973864109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7783146464917691d, y: 0.2743004541656401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961207062958173d, y: 0.5502718205010021d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17883508515531643d, y: 0.3198730792260207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184651514567074d, y: 0.03752221935386435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8412881670472828d, y: 0.19400399328089868d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5404502370562366d, y: 0.6563803993925839d), new NpgsqlTypes.NpgsqlPoint(x: 0.660703222158821d, y: 0.19825939392386172d), new NpgsqlTypes.NpgsqlPoint(x: 0.41758649552955396d, y: 0.15673179500505563d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0917944340693998d, y: 0.29531075830371567d), new NpgsqlTypes.NpgsqlPoint(x: 0.383519831436807d, y: 0.6735987289257405d), new NpgsqlTypes.NpgsqlPoint(x: 0.42586319455464794d, y: 0.5413225249208702d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28702313419667325d, y: 0.9214378825300884d), new NpgsqlTypes.NpgsqlPoint(x: 0.04500179181457176d, y: 0.20443245637454832d), new NpgsqlTypes.NpgsqlPoint(x: 0.19958673050548725d, y: 0.07959306379321662d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9919929361719851d, y: 0.6721482222889787d), new NpgsqlTypes.NpgsqlPoint(x: 0.43567040641158916d, y: 0.24281475569698985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5525949771288837d, y: 0.7504996310370421d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5174689819155212d, y: 0.10341567909794336d), new NpgsqlTypes.NpgsqlPoint(x: 0.16219335787192724d, y: 0.7462729361731373d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920946068203609d, y: 0.5173821934285302d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9350881740322403d, y: 0.8666656950902811d), new NpgsqlTypes.NpgsqlPoint(x: 0.47266002445769517d, y: 0.8881795352339378d), new NpgsqlTypes.NpgsqlPoint(x: 0.46577221802804136d, y: 0.3190774067231996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28693947758111327d, y: 0.2502855201178096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078007080547765d, y: 0.8267758628432139d), new NpgsqlTypes.NpgsqlPoint(x: 0.011425581903048099d, y: 0.9886676650189176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8201138576262997d, y: 0.7046006112318686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4029075239876404d, y: 0.7451760494988715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8825624210408691d, y: 0.4721348729298761d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5367287813767655d, y: 0.80913430397121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5491799045160844d, y: 0.22263175382174138d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907218843564089d, y: 0.9004929149835234d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03792830349223664d, y: 0.6382321012275831d), new NpgsqlTypes.NpgsqlPoint(x: 0.354730031736994d, y: 0.7280328408849848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682167845818433d, y: 0.6720938522423574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47989247779896393d, y: 0.8123867812232898d), new NpgsqlTypes.NpgsqlPoint(x: 0.36528420834731024d, y: 0.37089972297062423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891329638546107d, y: 0.9317171647476492d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2647418778493683d, y: 0.42970735765599943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5181862278983914d, y: 0.1763429589253046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742275519201351d, y: 0.48356636984384627d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597476127996551d, y: 0.811068517791349d), new NpgsqlTypes.NpgsqlPoint(x: 0.09376268049211478d, y: 0.9206878924639668d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610964822094708d, y: 0.23109128173443172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10390090804030572d, y: 0.8782280478057426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9368451423850437d, y: 0.12081239737213423d), new NpgsqlTypes.NpgsqlPoint(x: 0.1327213349461287d, y: 0.8059564690298693d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0999329487495414d, y: 0.6768671604884208d), new NpgsqlTypes.NpgsqlPoint(x: 0.3743139392967977d, y: 0.03438458390561261d), new NpgsqlTypes.NpgsqlPoint(x: 0.37612420467510244d, y: 0.18798954866264928d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3271089796991028d, y: 0.16129805814025266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404794052464021d, y: 0.34627527896299715d), new NpgsqlTypes.NpgsqlPoint(x: 0.613268603382687d, y: 0.1562681462208816d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10100007580949433d, y: 0.9877516347046639d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874929802193084d, y: 0.2291315215548514d), new NpgsqlTypes.NpgsqlPoint(x: 0.3879532775134009d, y: 0.8437188693488754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.056875047510180576d, y: 0.7114152463091662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5670593380599738d, y: 0.2879081436312957d), new NpgsqlTypes.NpgsqlPoint(x: 0.46310592412019724d, y: 0.42621456450516426d)),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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

                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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

                var models = await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
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

                var models =  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 95, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatchAsync(connection, 34, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
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
                var models =  ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatch(connection, 34, 67))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 10);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

