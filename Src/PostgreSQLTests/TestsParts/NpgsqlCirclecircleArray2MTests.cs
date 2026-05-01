

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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0008532345081260218d, y: 0.1419383792580211d), radius: 0.5703464462308198d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4638388886342133d, y: 0.28426700994888854d), radius: 0.013422417850305957d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17779270015188664d, y: 0.8548890222596826d), radius: 0.639532935068492d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8746583022544961d, y: 0.22162972168758088d), radius: 0.2689024662000794d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20611935902221734d, y: 0.23371434171500083d), radius: 0.13543560745409466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33229199101710594d, y: 0.02525550363022755d), radius: 0.4325720246932938d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4479813574029593d, y: 0.44314816430641923d), radius: 0.7308211359259016d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8295081994082573d, y: 0.2910183360597798d), radius: 0.28767611033517804d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46434849668398714d, y: 0.4160769231063193d), radius: 0.25125998158918705d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10406422940580173d, y: 0.4610631261444348d), radius: 0.028317405685670982d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5216123678014032d, y: 0.47250071434528973d), radius: 0.9841807217011644d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6083105552942187d, y: 0.802182912507916d), radius: 0.7021248023707111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.757496368106756d, y: 0.6638611493053904d), radius: 0.592942651850895d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12529258532732734d, y: 0.7845902543409528d), radius: 0.8813072389467239d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37212690301569173d, y: 0.1757659522479722d), radius: 0.45637671512649436d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43214768825758176d, y: 0.09939418850066872d), radius: 0.23541109023254492d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4384137079038666d, y: 0.6682182780010889d), radius: 0.24305637642243716d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06782192084771099d, y: 0.6668819043854024d), radius: 0.09870801503603155d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20476688548127664d, y: 0.9881435046537943d), radius: 0.6331750556955824d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7330725351401276d, y: 0.647193356707335d), radius: 0.4665091907871226d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46003445134866705d, y: 0.15002653553767686d), radius: 0.11421752305804622d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26246202559659326d, y: 0.6267475931337708d), radius: 0.7648186660661477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23255511028818543d, y: 0.08836816229696842d), radius: 0.1995851469025004d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43690176841026407d, y: 0.15154262313139544d), radius: 0.6167709713825386d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11032290128199007d, y: 0.7957884310137773d), radius: 0.9173450099401084d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3716790971184022d, y: 0.49890867169966124d), radius: 0.5663156822240604d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49564941283646347d, y: 0.7433481793378817d), radius: 0.4757088735988859d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7301927142955055d, y: 0.4828258309921797d), radius: 0.051063858040498955d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6600690478775433d, y: 0.10046799620995273d), radius: 0.2523859854742946d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7653278327224833d, y: 0.41882933084133656d), radius: 0.793066010278209d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.211616255693992d, y: 0.4802818615360722d), radius: 0.39032778259601286d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06267462927317446d, y: 0.3319614752224954d), radius: 0.8827258555392441d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42280433681992025d, y: 0.5749081964495946d), radius: 0.8663579113735859d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3374930072955207d, y: 0.9708156503390184d), radius: 0.3585473066281297d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09232362483392875d, y: 0.1304352889263407d), radius: 0.36789097473763166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6074745137474203d, y: 0.15410241758086263d), radius: 0.9596101109418236d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7403007515426749d, y: 0.2082380620158225d), radius: 0.08204324555423859d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05436644310193328d, y: 0.8727719367661105d), radius: 0.09899919280119374d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47911727391456205d, y: 0.5355293305328426d), radius: 0.21442808778597433d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38586852212084644d, y: 0.6999381516347475d), radius: 0.7038727379162226d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3944616718211902d, y: 0.734057722583402d), radius: 0.5822794026434543d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3452464948113193d, y: 0.8319976026661998d), radius: 0.8695594042977701d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.607369425716461d, y: 0.7654080182609434d), radius: 0.7903602152475424d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2642292370803079d, y: 0.6957220459445563d), radius: 0.3250068171805325d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9765638669305726d, y: 0.7568460276525756d), radius: 0.3769949074529757d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8353516371470644d, y: 0.3823842437388306d), radius: 0.26058976079291307d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40000436315960164d, y: 0.27267666110705735d), radius: 0.005019327385390238d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06276816160510101d, y: 0.3469678581076353d), radius: 0.7595294787698851d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8236155564266121d, y: 0.9467467900666363d), radius: 0.9516225137347705d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7231339400630881d, y: 0.543180790303142d), radius: 0.5599921987656112d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5027756642240299d, y: 0.788954579693514d), radius: 0.8579843086039106d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8841799494236865d, y: 0.9447357686909384d), radius: 0.5192313596491718d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9324580395986836d, y: 0.9893464920831923d), radius: 0.3910742796252932d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2187403179250792d, y: 0.7998036932363681d), radius: 0.48296592762675417d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.937818021568448d, y: 0.27741386637631493d), radius: 0.06995978052915308d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05592205468158562d, y: 0.6152340019341545d), radius: 0.5102963004905413d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.266466559665236d, y: 0.9890885929709008d), radius: 0.10599558726526503d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5010933598615226d, y: 0.49065640586415615d), radius: 0.5853995811919516d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9536960920697322d, y: 0.29452909941742733d), radius: 0.7430113892045339d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7661117840051611d, y: 0.4436367717806361d), radius: 0.8458941961031153d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7495057914170568d, y: 0.857514220871783d), radius: 0.1969929191575155d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9559907832307819d, y: 0.7103005259644496d), radius: 0.82973392750337d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32113855149568205d, y: 0.23483493871994654d), radius: 0.7432140227169534d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6349655792323602d, y: 0.4903565796774977d), radius: 0.05863769031155042d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9960079947605186d, y: 0.9743567592621312d), radius: 0.6465854052235767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06173013115463455d, y: 0.4407080775662783d), radius: 0.44414876552545646d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38161996960970557d, y: 0.084949120718389d), radius: 0.767454652980952d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7179749260507747d, y: 0.6392898246914804d), radius: 0.07802813350929227d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7909066512589762d, y: 0.6596565902312366d), radius: 0.745747106053201d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2912514048786907d, y: 0.8344576137204827d), radius: 0.48171561616385095d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2130812370255698d, y: 0.5299205172063775d), radius: 0.7007585752582899d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7960224377182735d, y: 0.5535161770910805d), radius: 0.4946002683954187d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47598946142745213d, y: 0.22820484636409533d), radius: 0.6169459339814839d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3752256830714723d, y: 0.8477270273563952d), radius: 0.7070160897764929d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6415497813594646d, y: 0.8695775684465331d), radius: 0.6480508309695954d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1010411489515941d, y: 0.24994084878828848d), radius: 0.5874519168936432d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5502574261737094d, y: 0.8705166833806804d), radius: 0.27339722399739275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4341337031355095d, y: 0.7314838822301704d), radius: 0.48463646426567863d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3715351450736084d, y: 0.017954191779660955d), radius: 0.8395386018283615d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8820361728548084d, y: 0.96421133931891d), radius: 0.468410147506392d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6838766667384232d, y: 0.6565839517954882d), radius: 0.1284166046583839d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5801011321596751d, y: 0.39108034914334344d), radius: 0.6718429379021283d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0952198597869488d, y: 0.585602837423432d), radius: 0.07850884325761787d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22581067991029014d, y: 0.6801235992475325d), radius: 0.7648313728232683d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15107647758726261d, y: 0.8475594742617844d), radius: 0.9186968704517813d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.348257782594775d, y: 0.44949899593535414d), radius: 0.2744974501312779d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2985619717749932d, y: 0.19140824907204534d), radius: 0.9795853767698014d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.264226381856707d, y: 0.51298057248549d), radius: 0.1796988518744086d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8347061893690895d, y: 0.7321205502161311d), radius: 0.8575439344430998d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19568985838781172d, y: 0.3152142393695231d), radius: 0.16457383853607044d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7790934906525636d, y: 0.9597959536347453d), radius: 0.16941124470323665d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7746145610917384d, y: 0.3904604674265838d), radius: 0.8251660636685216d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23049845889580833d, y: 0.029927814649971962d), radius: 0.7191097601854144d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5966058974500835d, y: 0.8863532060318209d), radius: 0.7062908493364447d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5482097509639633d, y: 0.9128460440905348d), radius: 0.7982268733894827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.607378299187466d, y: 0.2191389078107957d), radius: 0.9408741241446849d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08397972884833016d, y: 0.7408416746934646d), radius: 0.25738778832221054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27251489581882027d, y: 0.02723931922849754d), radius: 0.43590181254555926d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31085841154028804d, y: 0.7982643162633021d), radius: 0.7572429486937607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6644152549643183d, y: 0.6623941498819059d), radius: 0.7811957270260304d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09074200909096475d, y: 0.044684906490472964d), radius: 0.8901403989982984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5127817650438089d, y: 0.4525035449925612d), radius: 0.39613962908104083d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5049919552924858d, y: 0.2266833187499797d), radius: 0.409460735020334d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8085557640520789d, y: 0.06571383327235558d), radius: 0.4398082108734839d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7996851888690768d, y: 0.43288862199964884d), radius: 0.5314334051891834d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4278540169215439d, y: 0.9258667850979582d), radius: 0.14046896943888088d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2461724530903142d, y: 0.15389570701131083d), radius: 0.17437703221881629d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8616018466829892d, y: 0.8060027917442579d), radius: 0.8208703159248693d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7867841328776793d, y: 0.54569796837748d), radius: 0.707381839148714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7343130764171709d, y: 0.8322582720963635d), radius: 0.6787624108635282d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9426449348407907d, y: 0.4434381688303999d), radius: 0.0005007664447209681d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06284023428101526d, y: 0.15852177938012169d), radius: 0.8752000901787333d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6514833954605056d, y: 0.3224990278028519d), radius: 0.895435559705965d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3830262960376939d, y: 0.22715627928527493d), radius: 0.16808030427273735d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46307333854156507d, y: 0.7055038807461923d), radius: 0.6672085865705604d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8409825784790886d, y: 0.922035253038123d), radius: 0.9274923816395872d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4562682807601255d, y: 0.9984222330653403d), radius: 0.20106139236665532d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46628830477347494d, y: 0.577321706943887d), radius: 0.5809159857484909d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45219142297161796d, y: 0.6239961981025197d), radius: 0.2443694021810635d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09022819439647156d, y: 0.13596671536105276d), radius: 0.025907033862737516d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47538958730345604d, y: 0.67188882223411d), radius: 0.1307837382085626d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13744725434696248d, y: 0.9326875142045302d), radius: 0.9565591923055318d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8134716132754712d, y: 0.5366374110120928d), radius: 0.8235091764203241d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6247946504572227d, y: 0.5192011523345864d), radius: 0.9259707947096458d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5116419675480154d, y: 0.4192410332313268d), radius: 0.16051770036130264d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10092051513202949d, y: 0.22852397125756385d), radius: 0.2984367645367414d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27017023794710215d, y: 0.5717162090813946d), radius: 0.07746758539657983d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6517633655512527d, y: 0.9003366483589409d), radius: 0.24663199816142045d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6274986990578785d, y: 0.7725121044248544d), radius: 0.3407525804786071d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0891532383358401d, y: 0.08898471431046617d), radius: 0.4383117182267856d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8734286963484886d, y: 0.052410105333018264d), radius: 0.25281131795184053d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7111315621611998d, y: 0.4390958781419104d), radius: 0.43515830596544347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06813973441503363d, y: 0.5810197571871927d), radius: 0.7123915574418728d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25230745195479287d, y: 0.5662167123392129d), radius: 0.47295403460575025d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9010485113637214d, y: 0.020908588938979178d), radius: 0.3461952850287954d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23781637745277262d, y: 0.23317951902474032d), radius: 0.8130968626603877d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16489882600901662d, y: 0.08807211291513439d), radius: 0.33446134253910065d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6191740125337338d, y: 0.5210690025122657d), radius: 0.6088041187649301d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.938157804963628d, y: 0.9640411608947616d), radius: 0.6760777754842411d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12182679868934243d, y: 0.9506710959157202d), radius: 0.24880138445641564d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2569255517627005d, y: 0.29516711991202016d), radius: 0.3475331237872631d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08828219037494123d, y: 0.03482859883195144d), radius: 0.024449288997154484d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28642392848027953d, y: 0.4721667897217866d), radius: 0.8197299326088547d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8366993199333759d, y: 0.09042878807474575d), radius: 0.6539146710619255d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.502027149729285d, y: 0.004949444623311816d), radius: 0.4087515917715051d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5980613402877378d, y: 0.850857564701983d), radius: 0.9633183772540421d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06438711305192868d, y: 0.44133150610747507d), radius: 0.06998039511003273d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.702008987943741d, y: 0.20305574291225648d), radius: 0.1435869445642325d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6346459058910698d, y: 0.3224660100415653d), radius: 0.2509066853604718d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7740470088623124d, y: 0.7987957382890698d), radius: 0.2414921558673636d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20907938401849646d, y: 0.9799156848588623d), radius: 0.026239604292462526d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.409017647652973d, y: 0.6524293683332377d), radius: 0.03163092767246323d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6920782695910873d, y: 0.17385212592658583d), radius: 0.541373097556907d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6372786890544497d, y: 0.9369191345305008d), radius: 0.408709639761093d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1593693176947374d, y: 0.30618683893667886d), radius: 0.69585241730116d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5643199999750379d, y: 0.48458313893518545d), radius: 0.7789064969140731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23574137017192875d, y: 0.8296324090090486d), radius: 0.6628298593968933d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46514310345257537d, y: 0.13456810879131986d), radius: 0.13453203237960087d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5225409236573213d, y: 0.7433396684624829d), radius: 0.1074395754426799d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4252711012187279d, y: 0.930231926425901d), radius: 0.6843738445558545d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19934564258171217d, y: 0.673330386940838d), radius: 0.6816676987464798d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21838742743272865d, y: 0.9851295963099602d), radius: 0.11110358158464195d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10110058659932453d, y: 0.9899052696215818d), radius: 0.766427524957533d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19777516815667695d, y: 0.9082310257001808d), radius: 0.21759482268407349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8985381751652896d, y: 0.5457832984974824d), radius: 0.10329721790633195d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3310517169259275d, y: 0.5030534586970771d), radius: 0.05864597716054931d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8271502706927468d, y: 0.975290344512809d), radius: 0.4812067841787978d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.966884123015026d, y: 0.15936866892051726d), radius: 0.9746756743947905d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17629058647453122d, y: 0.39816187462874486d), radius: 0.1875351823998651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15426922162975976d, y: 0.10384355181168314d), radius: 0.1846700189452044d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5367430876005383d, y: 0.08117120645515963d), radius: 0.5496150868031663d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46541904513379273d, y: 0.19131612429008993d), radius: 0.9558088887437144d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6931341541950589d, y: 0.6813458352269468d), radius: 0.5174086666963963d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917107340533566d, y: 0.5035366635311053d), radius: 0.42344872641444875d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39920366724022205d, y: 0.9460623935362764d), radius: 0.52732851839071d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5229078181431277d, y: 0.188156973060997d), radius: 0.9129867092859558d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30013716815759817d, y: 0.5946323178291211d), radius: 0.6871392647794683d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10715656830375098d, y: 0.7368903916570072d), radius: 0.23342721228948338d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2849268032369535d, y: 0.6862565755944882d), radius: 0.6250687246337214d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8909388661241764d, y: 0.0452805158084445d), radius: 0.12039759443126752d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7711754070440443d, y: 0.046362015028022174d), radius: 0.4383114574333188d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9514292083530844d, y: 0.9523316333429438d), radius: 0.2149859238021321d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06512183524879578d, y: 0.204464584360169d), radius: 0.9109048789930146d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4441200796864049d, y: 0.4911101967887649d), radius: 0.3915650855529007d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2805700342597053d, y: 0.346126847192462d), radius: 0.020982865232319625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13146597765991153d, y: 0.38124517710979355d), radius: 0.3307140563256742d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9553009642488813d, y: 0.06475220418702776d), radius: 0.7452788915438102d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5978379169161195d, y: 0.9324612768074886d), radius: 0.8148158824899676d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14890819958681334d, y: 0.6510928276543589d), radius: 0.8411641407447815d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49467040090464687d, y: 0.37774981803675856d), radius: 0.23021482731182574d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8941331309928542d, y: 0.15775947190906725d), radius: 0.5250871512996337d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7535019911652987d, y: 0.9198719475760974d), radius: 0.6576179211900841d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7456355828841501d, y: 0.9421459147178827d), radius: 0.8752110602912118d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06967660841604739d, y: 0.07970780812792644d), radius: 0.7130216215462596d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8000308295276564d, y: 0.26834978831832623d), radius: 0.5184126954331079d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10195370423441963d, y: 0.15276973302841368d), radius: 0.548462210602432d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0896834551738277d, y: 0.04112932841194661d), radius: 0.4052626527682227d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.432080661318612d, y: 0.4959407741689039d), radius: 0.5573873453239249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8280322320057777d, y: 0.36803422271380215d), radius: 0.9664169693437263d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6949656489374743d, y: 0.7784106660345967d), radius: 0.8082419886290795d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5104603467152707d, y: 0.015386693704780185d), radius: 0.7122009994804807d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08880428276652819d, y: 0.2848404370360075d), radius: 0.8759386702343686d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38302054592562074d, y: 0.7628200848513933d), radius: 0.45300534012138105d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17681108683548352d, y: 0.9592870779729218d), radius: 0.8809024605853029d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06972197791565082d, y: 0.6626527410842699d), radius: 0.27625229723220657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.739846023595966d, y: 0.6522056743858101d), radius: 0.2790625430219813d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5569039273999423d, y: 0.6853861560868597d), radius: 0.8927546156457377d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.399173534452683d, y: 0.4952137935985884d), radius: 0.8607228877503125d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19665746424864183d, y: 0.00046235439157360503d), radius: 0.8549470537048587d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.037618423732074135d, y: 0.5131944262156071d), radius: 0.0657295308884207d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7856228967600359d, y: 0.3055553324839214d), radius: 0.9859208532521195d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004607653550163904d, y: 0.6439084014239491d), radius: 0.6304294052328169d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2894248851737923d, y: 0.8831926857081382d), radius: 0.828718168673683d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18866486039796515d, y: 0.187011089940745d), radius: 0.4982176215957692d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7347432230569718d, y: 0.045946310220529196d), radius: 0.1921666312029432d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5934824654255059d, y: 0.009570444747311058d), radius: 0.017445450530398254d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5569884386003527d, y: 0.8163525092780254d), radius: 0.27187615134719434d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8268874173983926d, y: 0.542636399321997d), radius: 0.7961165236882264d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8089917872467096d, y: 0.9717214204784302d), radius: 0.9388890345986067d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02292380008990169d, y: 0.5485676736936191d), radius: 0.2650107276257898d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9348304201882968d, y: 0.9089342383763609d), radius: 0.00824789103040291d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15425320423624322d, y: 0.04954913899043145d), radius: 0.06317276681953798d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22299125564971045d, y: 0.7015096635901846d), radius: 0.4579186828279931d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8412705939642933d, y: 0.9917065437313004d), radius: 0.3410289933371392d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4384286019616971d, y: 0.8674162849719584d), radius: 0.17240043091896107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9295681892605275d, y: 0.045477285110458565d), radius: 0.5867158803811882d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07708021952911859d, y: 0.7595712758960006d), radius: 0.2440413034174045d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4550671736011084d, y: 0.38386536464027043d), radius: 0.09016801050540557d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5154537276950424d, y: 0.04237891562999496d), radius: 0.027717611750364912d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2651602318730325d, y: 0.5436091831877421d), radius: 0.5808344472265398d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5488765322868931d, y: 0.6267951265925457d), radius: 0.6164439284255272d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.373188709962357d, y: 0.6114583633563297d), radius: 0.4892654685842217d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.909013988870589d, y: 0.2070575250279909d), radius: 0.46438205316581904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2718242798912798d, y: 0.3667536378214107d), radius: 0.47853569560592735d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7983691886780386d, y: 0.7289895690748696d), radius: 0.7350627547320112d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.585322136951494d, y: 0.8150948203248478d), radius: 0.6988323798847691d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7661463592511566d, y: 0.8673095634976503d), radius: 0.7246435210359868d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6362250923397925d, y: 0.5494120630226709d), radius: 0.20913307557017202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.230846632898841d, y: 0.8032032052949938d), radius: 0.5740665383057628d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5725668933438403d, y: 0.7163005865787828d), radius: 0.49388269362723747d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9789924689559791d, y: 0.9307545625255497d), radius: 0.8351623794104026d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5416959245494377d, y: 0.3324881080530353d), radius: 0.6380823584794867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1907663098483876d, y: 0.7718355613254931d), radius: 0.6535692081443483d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8782159301445739d, y: 0.33192583000549847d), radius: 0.13595375722129432d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7479856940353576d, y: 0.8742318592521077d), radius: 0.5002108945485108d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6067511155516729d, y: 0.54860194044284d), radius: 0.17275275957888714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03195007425154428d, y: 0.23966583220179338d), radius: 0.2378844800908657d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12742041094888923d, y: 0.6568551603261316d), radius: 0.315391167025886d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5563315818219494d, y: 0.28097927895703345d), radius: 0.2785954079754114d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7436405313829658d, y: 0.05035024144087874d), radius: 0.5139917439120124d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1609829951188917d, y: 0.46293925464783103d), radius: 0.9676959959810206d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.831653964725175d, y: 0.9684781235888276d), radius: 0.4219843984791487d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6853961947606574d, y: 0.5853281764935349d), radius: 0.3001863050500636d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10961912716293609d, y: 0.5103757033794817d), radius: 0.07485351226637182d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9349920232572894d, y: 0.6960831315999715d), radius: 0.11802363978743957d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3145714799308823d, y: 0.9374328387049472d), radius: 0.009366550099329962d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8740467102663808d, y: 0.6430094168176534d), radius: 0.44458793378562433d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.803204148534345d, y: 0.3204675075282287d), radius: 0.8896618068258207d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8860988112931308d, y: 0.3196758585727705d), radius: 0.1594938044711839d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3226980639397955d, y: 0.5674055361781224d), radius: 0.42958014785467513d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26296854319757956d, y: 0.807483655106643d), radius: 0.3928613857130737d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6375977148530456d, y: 0.4867322115095154d), radius: 0.31526111763877784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7977456780233378d, y: 0.5087988965182765d), radius: 0.07180143205690503d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47541184754647436d, y: 0.3943035463311477d), radius: 0.624291979689947d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10065652686086746d, y: 0.6824034168599965d), radius: 0.008000684938417324d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27901647040578215d, y: 0.9728288590885753d), radius: 0.7008641133259469d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7127462295596125d, y: 0.8013800449249665d), radius: 0.8932864289512449d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6583918620632437d, y: 0.7813439082166199d), radius: 0.6311899355074225d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3333123598863489d, y: 0.2900096087484232d), radius: 0.7224666146839133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8641517948553936d, y: 0.8113116141419818d), radius: 0.11750318428778483d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7694452270880178d, y: 0.5030137196935828d), radius: 0.13230730614329467d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9416870251560079d, y: 0.3402715832078591d), radius: 0.7099648870161328d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09883386530851124d, y: 0.46098601193920496d), radius: 0.8226652780557779d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9200981519334435d, y: 0.9806291383535802d), radius: 0.322416414974677d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4645140719721227d, y: 0.1539816319223517d), radius: 0.5536620934060421d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7171273303455867d, y: 0.006387977631799768d), radius: 0.27763888449489227d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2942987681015813d, y: 0.9690977148842446d), radius: 0.03466929312397049d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43232534138310486d, y: 0.8002197829780756d), radius: 0.41865859511578674d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26971561818876444d, y: 0.2334203134515761d), radius: 0.019691074048528878d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4787790856650841d, y: 0.2274240470813068d), radius: 0.2651392939560516d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11288360065804792d, y: 0.514215479125899d), radius: 0.9465949265194383d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1327322485319663d, y: 0.256961692998776d), radius: 0.4068946949076856d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5227176285438858d, y: 0.4134079146860721d), radius: 0.9244732588857976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3271718501226384d, y: 0.5128030330914783d), radius: 0.5233306152710889d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24009569356076932d, y: 0.5475888149861058d), radius: 0.4828952628610689d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.365047675650054d, y: 0.24557873866605084d), radius: 0.5750200516376943d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24712604014177297d, y: 0.018287190124329555d), radius: 0.790599204622032d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6272495040108576d, y: 0.1737346204849849d), radius: 0.34016080277486715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9924142838272092d, y: 0.22914692155765803d), radius: 0.21000577241355367d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.724786818347893d, y: 0.7209075227043545d), radius: 0.3347302889691932d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9866500450739775d, y: 0.3808815704570887d), radius: 0.7957921417921704d),

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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 74;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 103;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 89;
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 38, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 34, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 160, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 97, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 111, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[34], false);
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
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[30], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[31], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[32], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[33], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[30], false);NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[31], false);NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[32], false);NpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[33], false);NpgsqlCirclecircleArray2M.AssertModel(models[33],_testData[34], false);
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

