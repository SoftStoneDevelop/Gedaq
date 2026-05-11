

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygonE0M[] _testData = new NpgsqlPolygonpolygonE0M[]
        {
            new NpgsqlPolygonpolygonE0M
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.860667033777785d, y: 0.15827039082645322d), new NpgsqlTypes.NpgsqlPoint(x: 0.04215093025337868d, y: 0.8620032108208774d), new NpgsqlTypes.NpgsqlPoint(x: 0.003525918551865237d, y: 0.9191429923735149d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8856366149100965d, y: 0.7111550370906679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850282026991466d, y: 0.9066540642436831d), new NpgsqlTypes.NpgsqlPoint(x: 0.40172127112389966d, y: 0.47541649398661034d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7885365424081695d, y: 0.5306604217150505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631771439705486d, y: 0.22368656595913472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149022409194692d, y: 0.6191523436667136d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3853484292211481d, y: 0.528679313214265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769495917269304d, y: 0.5865411629469044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966105010287968d, y: 0.7795748631342706d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2590352068403913d, y: 0.6402829153640184d), new NpgsqlTypes.NpgsqlPoint(x: 0.2356282497926777d, y: 0.9470017773923345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829002534656689d, y: 0.08942441131217149d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7157810324391163d, y: 0.39492137831895724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192923557080516d, y: 0.8505583595290064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428999963852302d, y: 0.27576239400501d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7617713210194196d, y: 0.03131733223243538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246944333958574d, y: 0.13378991863603562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128919182154188d, y: 0.7114604730938422d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8488207307595923d, y: 0.8152423920402292d), new NpgsqlTypes.NpgsqlPoint(x: 0.20989859126149946d, y: 0.26084821146710635d), new NpgsqlTypes.NpgsqlPoint(x: 0.642899724022087d, y: 0.25991802204542325d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44909196125935746d, y: 0.3616588397984888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366205107626338d, y: 0.9300219612182328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114494522008937d, y: 0.4310773716876718d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31243949995932674d, y: 0.20586337828495072d), new NpgsqlTypes.NpgsqlPoint(x: 0.818021450835617d, y: 0.975314395832313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375837411134936d, y: 0.8024062557298848d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.757906466934978d, y: 0.595017479463285d), new NpgsqlTypes.NpgsqlPoint(x: 0.3237447090974561d, y: 0.4676279752588539d), new NpgsqlTypes.NpgsqlPoint(x: 0.9423805689301205d, y: 0.32026544276393565d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24945143612491105d, y: 0.777238215425845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786933780834172d, y: 0.3803024544095489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7422949291741165d, y: 0.001435656977356703d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20742981494769608d, y: 0.929711748894219d), new NpgsqlTypes.NpgsqlPoint(x: 0.12893278068881464d, y: 0.6789247230296734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481508595781668d, y: 0.8446313497505595d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15426636991946885d, y: 0.10597618435050282d), new NpgsqlTypes.NpgsqlPoint(x: 0.771619035697118d, y: 0.9941826926330927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262376091644767d, y: 0.8060711073361094d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2919346248176098d, y: 0.8543739426258644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733041922254961d, y: 0.4580965825331136d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672817723223453d, y: 0.808991713884517d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5210484885260098d, y: 0.40518415573682287d), new NpgsqlTypes.NpgsqlPoint(x: 0.1679741238112873d, y: 0.4966831534778854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864326380666219d, y: 0.7091628554464273d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17201608578900252d, y: 0.05589681147040315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462663322947992d, y: 0.7558574384018941d), new NpgsqlTypes.NpgsqlPoint(x: 0.36501055432365515d, y: 0.6009187919005264d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06325955299992458d, y: 0.6779251998828336d), new NpgsqlTypes.NpgsqlPoint(x: 0.939269156266494d, y: 0.21448434896532964d), new NpgsqlTypes.NpgsqlPoint(x: 0.07639514620638599d, y: 0.025934245406724066d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25206423407075496d, y: 0.35693694875564563d), new NpgsqlTypes.NpgsqlPoint(x: 0.22858248480908627d, y: 0.7176410870540002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449677855998227d, y: 0.4094013642418681d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1275698175274963d, y: 0.766838317424375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092689316757149d, y: 0.04710782735754104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719871233723811d, y: 0.36184799271339096d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9091071626899441d, y: 0.6186751626343134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019215199147087d, y: 0.19566277825893763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1640940125752247d, y: 0.507990729802439d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9555463977361468d, y: 0.19719753889021885d), new NpgsqlTypes.NpgsqlPoint(x: 0.059750350568457344d, y: 0.39489055292293473d), new NpgsqlTypes.NpgsqlPoint(x: 0.23388128556354792d, y: 0.1707399649197593d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8587059479782572d, y: 0.4378428843508261d), new NpgsqlTypes.NpgsqlPoint(x: 0.09054424184451149d, y: 0.4144401774211467d), new NpgsqlTypes.NpgsqlPoint(x: 0.06417756670232055d, y: 0.5719946482351698d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16541180134381195d, y: 0.2510885609037298d), new NpgsqlTypes.NpgsqlPoint(x: 0.49596768212837294d, y: 0.6695942896583703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246039034970749d, y: 0.2367391160304123d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4574463682560094d, y: 0.9833849625695176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526103636871522d, y: 0.17963969773914878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045836574511074d, y: 0.8071388994646471d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2015071927633113d, y: 0.3295625802661437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562417922039479d, y: 0.41289489664393386d), new NpgsqlTypes.NpgsqlPoint(x: 0.15178999926002334d, y: 0.3600568079291314d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9833162938979989d, y: 0.5174564274030401d), new NpgsqlTypes.NpgsqlPoint(x: 0.45550603332213613d, y: 0.7070277354283196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506281748340384d, y: 0.2822662170579987d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6747137404998826d, y: 0.7102787059802903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832737095013914d, y: 0.4111876201656596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328032001699971d, y: 0.06222844606244138d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08458191977101936d, y: 0.3614203257740791d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529273524996267d, y: 0.8782511782159788d), new NpgsqlTypes.NpgsqlPoint(x: 0.4382076534156022d, y: 0.6794880322102427d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8648749740415375d, y: 0.016485604094621742d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005364363185799d, y: 0.696691559782995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859434616081578d, y: 0.26672674779167116d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8725405230708662d, y: 0.4438689694875908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733378637213844d, y: 0.34845918016152044d), new NpgsqlTypes.NpgsqlPoint(x: 2.234009734125575E-05d, y: 0.38174021836970784d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34448018147752146d, y: 0.6104670565318091d), new NpgsqlTypes.NpgsqlPoint(x: 0.49577136236050734d, y: 0.4685513317581044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512177033341438d, y: 0.6483330385436452d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.036854265182680535d, y: 0.04672140194237073d), new NpgsqlTypes.NpgsqlPoint(x: 0.35610396888044127d, y: 0.2991935978767116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846016219867064d, y: 0.03613840424076853d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817026062416026d, y: 0.6242759662065199d), new NpgsqlTypes.NpgsqlPoint(x: 0.45623084487969656d, y: 0.635118669411018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945453316775529d, y: 0.4175481174553549d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8743449050694175d, y: 0.6723696049459603d), new NpgsqlTypes.NpgsqlPoint(x: 0.21165508927718635d, y: 0.9371213885220226d), new NpgsqlTypes.NpgsqlPoint(x: 0.31028456632070944d, y: 0.14787527520490906d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042035544639760114d, y: 0.6279313661596438d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962041641327726d, y: 0.8106205948853266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4768504045206001d, y: 0.07633302772548722d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044655343765176d, y: 0.2741613563352573d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699839674262708d, y: 0.116447515493601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673331840034779d, y: 0.13524251494831807d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5088610527257103d, y: 0.017321146358317496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7692318794843882d, y: 0.14950958609556786d), new NpgsqlTypes.NpgsqlPoint(x: 0.21760114761137428d, y: 0.6352708640364801d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43792111733813266d, y: 0.21218949943862564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089970780993583d, y: 0.3979045531129325d), new NpgsqlTypes.NpgsqlPoint(x: 0.17434378791419414d, y: 0.9108311066614341d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9828942786703349d, y: 0.8832791091693706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881560298935174d, y: 0.38406963409516937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569181690175319d, y: 0.49148011926249413d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6529010142720741d, y: 0.2766669453544681d), new NpgsqlTypes.NpgsqlPoint(x: 0.21374937252348825d, y: 0.2685155595267189d), new NpgsqlTypes.NpgsqlPoint(x: 0.06684192314704362d, y: 0.7504845542334597d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7176113685978237d, y: 0.2167872783920345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125808585193097d, y: 0.04042318275497403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8746807859491855d, y: 0.1346205725474433d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6744327310718758d, y: 0.23368339608906274d), new NpgsqlTypes.NpgsqlPoint(x: 0.05355342105034744d, y: 0.022409524857960328d), new NpgsqlTypes.NpgsqlPoint(x: 0.965981440036902d, y: 0.01979514023969209d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09161307378969685d, y: 0.8061798134813777d), new NpgsqlTypes.NpgsqlPoint(x: 0.013876156745381008d, y: 0.958559347808631d), new NpgsqlTypes.NpgsqlPoint(x: 0.09902590187411109d, y: 0.17515754395533756d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1074549677118416d, y: 0.2776630815625667d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799286962701102d, y: 0.15657000087074324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185773102164105d, y: 0.9860765954837798d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12834617800718873d, y: 0.425655846487515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479502184738151d, y: 0.9717714176828157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7709705181311585d, y: 0.7716268689376844d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018130172805071676d, y: 0.386185622993491d), new NpgsqlTypes.NpgsqlPoint(x: 0.07793700487420285d, y: 0.594659652780223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1779058394560269d, y: 0.12951329820814328d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14760120004184407d, y: 0.7853984409446455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457821954130117d, y: 0.6180431962032292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7434708673314611d, y: 0.21842279252107177d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4522625686257381d, y: 0.25628906099317916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495323754122606d, y: 0.46317969338779097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142380024764069d, y: 0.6690407438457638d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10990713406608765d, y: 0.7035977251753757d), new NpgsqlTypes.NpgsqlPoint(x: 0.41918371323716364d, y: 0.833358922758353d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583118154843239d, y: 0.8094493847902342d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.548774026557678d, y: 0.008562694092290268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5042934932427833d, y: 0.7268336558930618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644150834186367d, y: 0.1850001438036981d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14755776422927014d, y: 0.34296058321439715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183297771734847d, y: 0.3791718088986602d), new NpgsqlTypes.NpgsqlPoint(x: 0.095222708256965d, y: 0.7050418005474931d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46301917261181413d, y: 0.9001903443988426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722430325438847d, y: 0.9754341031376873d), new NpgsqlTypes.NpgsqlPoint(x: 0.38730558348120836d, y: 0.42514135285214416d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23907786160688926d, y: 0.44015981488318745d), new NpgsqlTypes.NpgsqlPoint(x: 0.04775548275232633d, y: 0.637887264678525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169153939694833d, y: 0.36871041410910455d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45760872486913895d, y: 0.5042073291039355d), new NpgsqlTypes.NpgsqlPoint(x: 0.021810146466046842d, y: 0.060386503731723495d), new NpgsqlTypes.NpgsqlPoint(x: 0.02137677006846206d, y: 0.9872027339302073d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07805301115019281d, y: 0.5951519946305289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550472676946635d, y: 0.6002681255273119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566721572245451d, y: 0.29875707610178015d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6875945644452296d, y: 0.4112367311598184d), new NpgsqlTypes.NpgsqlPoint(x: 0.0398059652532291d, y: 0.36168001327835386d), new NpgsqlTypes.NpgsqlPoint(x: 0.558380041134694d, y: 0.7317248204737717d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03521351609386725d, y: 0.8539198305737418d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940206619254412d, y: 0.08225834699912293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6857923931168586d, y: 0.2539414006398669d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6286697998145689d, y: 0.6866685496342556d), new NpgsqlTypes.NpgsqlPoint(x: 0.29337033121114287d, y: 0.7868382753883324d), new NpgsqlTypes.NpgsqlPoint(x: 0.20197918660941283d, y: 0.4994112832388117d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8787966135969303d, y: 0.37779190137013097d), new NpgsqlTypes.NpgsqlPoint(x: 0.14734482125905024d, y: 0.19209456793314672d), new NpgsqlTypes.NpgsqlPoint(x: 0.42126368958304383d, y: 0.629344680777149d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5616952745401489d, y: 0.7149945302155847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7917811881626048d, y: 0.9412137080090931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5682131989587561d, y: 0.36808933304474645d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24006232914301195d, y: 0.6475357268523556d), new NpgsqlTypes.NpgsqlPoint(x: 0.23714059507925656d, y: 0.28472798033882907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401816175640466d, y: 0.31437939295527806d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12454305773655905d, y: 0.05318553798308612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667780943091198d, y: 0.8622879520291732d), new NpgsqlTypes.NpgsqlPoint(x: 0.3876576026721208d, y: 0.762442065225159d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45639874115271795d, y: 0.551175358202867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3403081200166811d, y: 0.6062347598481517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477735405243384d, y: 0.4554811287553445d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44218635872289225d, y: 0.6855688461395483d), new NpgsqlTypes.NpgsqlPoint(x: 0.402955818676638d, y: 0.6041213382060211d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798650468151118d, y: 0.8578681630244613d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5292403601483089d, y: 0.9010095924865424d), new NpgsqlTypes.NpgsqlPoint(x: 0.18748414808929836d, y: 0.15377086058532108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8194186596784195d, y: 0.5708977691399488d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44588753683204885d, y: 0.47867900794379004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657253265011477d, y: 0.9239635175069077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612310041973614d, y: 0.9163238680105747d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20775831856488158d, y: 0.46288127341048435d), new NpgsqlTypes.NpgsqlPoint(x: 0.577300088057304d, y: 0.06755759604158185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493883874537294d, y: 0.20260382190928095d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6637440739053889d, y: 0.2567968429009879d), new NpgsqlTypes.NpgsqlPoint(x: 0.10374400860437893d, y: 0.6192712254796957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379193137415623d, y: 0.43883077503233425d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8752162186368537d, y: 0.37577161950995086d), new NpgsqlTypes.NpgsqlPoint(x: 0.08816485538552443d, y: 0.8489322527256338d), new NpgsqlTypes.NpgsqlPoint(x: 0.02581253598269939d, y: 0.23094242422601352d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5708822693876916d, y: 0.9009536489409592d), new NpgsqlTypes.NpgsqlPoint(x: 0.40123966952652423d, y: 0.2846038166312872d), new NpgsqlTypes.NpgsqlPoint(x: 0.12110336114154818d, y: 0.6962749650402247d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6722485008915391d, y: 0.0018749844156213946d), new NpgsqlTypes.NpgsqlPoint(x: 0.0022054049041759782d, y: 0.08498728833709546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897596215385982d, y: 0.8875396754365821d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18301916725973055d, y: 0.8112309806521455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411267165125912d, y: 0.7466829563972662d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267436091774767d, y: 0.05724357423042892d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4742962078166425d, y: 0.750179639850587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3418396891537613d, y: 0.9572285695133299d), new NpgsqlTypes.NpgsqlPoint(x: 0.2963481736464014d, y: 0.2824939969447743d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989894913049381d, y: 0.9073229814524243d), new NpgsqlTypes.NpgsqlPoint(x: 0.13368772116147054d, y: 0.5691662869246783d), new NpgsqlTypes.NpgsqlPoint(x: 0.23918022288174412d, y: 0.8122556674376367d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3390986117370587d, y: 0.10390330380519497d), new NpgsqlTypes.NpgsqlPoint(x: 0.275400855224499d, y: 0.6246912224780466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860326468235647d, y: 0.9530206501540276d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42389606214075803d, y: 0.7729485058458516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547118359991885d, y: 0.055541248316037684d), new NpgsqlTypes.NpgsqlPoint(x: 0.24258119547563428d, y: 0.3190728626177711d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5624021923243806d, y: 0.9850867904603511d), new NpgsqlTypes.NpgsqlPoint(x: 0.1770251010374274d, y: 0.2917877391749796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468923647173702d, y: 0.8704794173243094d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.740842681651666d, y: 0.9444318960040754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909522554932157d, y: 0.12277699906226613d), new NpgsqlTypes.NpgsqlPoint(x: 0.25773427739749677d, y: 0.751280185996536d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3436097470012296d, y: 0.7685217936466265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568692558645027d, y: 0.9438471014359147d), new NpgsqlTypes.NpgsqlPoint(x: 0.013808220914276026d, y: 0.3896698280126032d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3151521448697946d, y: 0.38949754481072285d), new NpgsqlTypes.NpgsqlPoint(x: 0.38544423662676386d, y: 0.30666358311797015d), new NpgsqlTypes.NpgsqlPoint(x: 0.020958533770717103d, y: 0.13479008841242257d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 165,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.440210377415749d, y: 0.6099867487223255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052359286738362d, y: 0.036181958028759564d), new NpgsqlTypes.NpgsqlPoint(x: 0.15994294785013918d, y: 0.6686550062569894d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5877340330830522d, y: 0.08895001076234899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7023224171971362d, y: 0.41685723600874813d), new NpgsqlTypes.NpgsqlPoint(x: 0.31179636544326084d, y: 0.9540315038900679d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33092456204298826d, y: 0.03480732526941044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5908454346186093d, y: 0.8513757918395853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081456646789851d, y: 0.1594227305963385d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09036716762182417d, y: 0.1876931104814057d), new NpgsqlTypes.NpgsqlPoint(x: 0.10843599127745018d, y: 0.7199130018566068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997159194227974d, y: 0.20053679513336198d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016724810099608578d, y: 0.21372991583534406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239560491724939d, y: 0.0885982229792307d), new NpgsqlTypes.NpgsqlPoint(x: 0.43952849122725224d, y: 0.813467458546997d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05347452910335371d, y: 0.8258653249465975d), new NpgsqlTypes.NpgsqlPoint(x: 0.4912144001038734d, y: 0.516737405422409d), new NpgsqlTypes.NpgsqlPoint(x: 0.4169386562960421d, y: 0.5949220493175498d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.757906466934978d, y: 0.595017479463285d), new NpgsqlTypes.NpgsqlPoint(x: 0.3237447090974561d, y: 0.4676279752588539d), new NpgsqlTypes.NpgsqlPoint(x: 0.9423805689301205d, y: 0.32026544276393565d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2919346248176098d, y: 0.8543739426258644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733041922254961d, y: 0.4580965825331136d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672817723223453d, y: 0.808991713884517d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17201608578900252d, y: 0.05589681147040315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462663322947992d, y: 0.7558574384018941d), new NpgsqlTypes.NpgsqlPoint(x: 0.36501055432365515d, y: 0.6009187919005264d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1275698175274963d, y: 0.766838317424375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092689316757149d, y: 0.04710782735754104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719871233723811d, y: 0.36184799271339096d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4574463682560094d, y: 0.9833849625695176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526103636871522d, y: 0.17963969773914878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045836574511074d, y: 0.8071388994646471d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9833162938979989d, y: 0.5174564274030401d), new NpgsqlTypes.NpgsqlPoint(x: 0.45550603332213613d, y: 0.7070277354283196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506281748340384d, y: 0.2822662170579987d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8725405230708662d, y: 0.4438689694875908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733378637213844d, y: 0.34845918016152044d), new NpgsqlTypes.NpgsqlPoint(x: 2.234009734125575E-05d, y: 0.38174021836970784d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 98;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 47, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 85, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 117, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 125, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 99, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[14], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[15], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[16], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.860667033777785d, y: 0.15827039082645322d), new NpgsqlTypes.NpgsqlPoint(x: 0.04215093025337868d, y: 0.8620032108208774d), new NpgsqlTypes.NpgsqlPoint(x: 0.003525918551865237d, y: 0.9191429923735149d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8856366149100965d, y: 0.7111550370906679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850282026991466d, y: 0.9066540642436831d), new NpgsqlTypes.NpgsqlPoint(x: 0.40172127112389966d, y: 0.47541649398661034d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7885365424081695d, y: 0.5306604217150505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631771439705486d, y: 0.22368656595913472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149022409194692d, y: 0.6191523436667136d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3853484292211481d, y: 0.528679313214265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769495917269304d, y: 0.5865411629469044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966105010287968d, y: 0.7795748631342706d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2590352068403913d, y: 0.6402829153640184d), new NpgsqlTypes.NpgsqlPoint(x: 0.2356282497926777d, y: 0.9470017773923345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829002534656689d, y: 0.08942441131217149d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7157810324391163d, y: 0.39492137831895724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192923557080516d, y: 0.8505583595290064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428999963852302d, y: 0.27576239400501d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7617713210194196d, y: 0.03131733223243538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246944333958574d, y: 0.13378991863603562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128919182154188d, y: 0.7114604730938422d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8488207307595923d, y: 0.8152423920402292d), new NpgsqlTypes.NpgsqlPoint(x: 0.20989859126149946d, y: 0.26084821146710635d), new NpgsqlTypes.NpgsqlPoint(x: 0.642899724022087d, y: 0.25991802204542325d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44909196125935746d, y: 0.3616588397984888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366205107626338d, y: 0.9300219612182328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114494522008937d, y: 0.4310773716876718d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31243949995932674d, y: 0.20586337828495072d), new NpgsqlTypes.NpgsqlPoint(x: 0.818021450835617d, y: 0.975314395832313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375837411134936d, y: 0.8024062557298848d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.757906466934978d, y: 0.595017479463285d), new NpgsqlTypes.NpgsqlPoint(x: 0.3237447090974561d, y: 0.4676279752588539d), new NpgsqlTypes.NpgsqlPoint(x: 0.9423805689301205d, y: 0.32026544276393565d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24945143612491105d, y: 0.777238215425845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786933780834172d, y: 0.3803024544095489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7422949291741165d, y: 0.001435656977356703d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20742981494769608d, y: 0.929711748894219d), new NpgsqlTypes.NpgsqlPoint(x: 0.12893278068881464d, y: 0.6789247230296734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481508595781668d, y: 0.8446313497505595d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15426636991946885d, y: 0.10597618435050282d), new NpgsqlTypes.NpgsqlPoint(x: 0.771619035697118d, y: 0.9941826926330927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262376091644767d, y: 0.8060711073361094d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2919346248176098d, y: 0.8543739426258644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733041922254961d, y: 0.4580965825331136d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672817723223453d, y: 0.808991713884517d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5210484885260098d, y: 0.40518415573682287d), new NpgsqlTypes.NpgsqlPoint(x: 0.1679741238112873d, y: 0.4966831534778854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864326380666219d, y: 0.7091628554464273d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17201608578900252d, y: 0.05589681147040315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462663322947992d, y: 0.7558574384018941d), new NpgsqlTypes.NpgsqlPoint(x: 0.36501055432365515d, y: 0.6009187919005264d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06325955299992458d, y: 0.6779251998828336d), new NpgsqlTypes.NpgsqlPoint(x: 0.939269156266494d, y: 0.21448434896532964d), new NpgsqlTypes.NpgsqlPoint(x: 0.07639514620638599d, y: 0.025934245406724066d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25206423407075496d, y: 0.35693694875564563d), new NpgsqlTypes.NpgsqlPoint(x: 0.22858248480908627d, y: 0.7176410870540002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449677855998227d, y: 0.4094013642418681d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1275698175274963d, y: 0.766838317424375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092689316757149d, y: 0.04710782735754104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719871233723811d, y: 0.36184799271339096d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9091071626899441d, y: 0.6186751626343134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019215199147087d, y: 0.19566277825893763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1640940125752247d, y: 0.507990729802439d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9555463977361468d, y: 0.19719753889021885d), new NpgsqlTypes.NpgsqlPoint(x: 0.059750350568457344d, y: 0.39489055292293473d), new NpgsqlTypes.NpgsqlPoint(x: 0.23388128556354792d, y: 0.1707399649197593d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8587059479782572d, y: 0.4378428843508261d), new NpgsqlTypes.NpgsqlPoint(x: 0.09054424184451149d, y: 0.4144401774211467d), new NpgsqlTypes.NpgsqlPoint(x: 0.06417756670232055d, y: 0.5719946482351698d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16541180134381195d, y: 0.2510885609037298d), new NpgsqlTypes.NpgsqlPoint(x: 0.49596768212837294d, y: 0.6695942896583703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246039034970749d, y: 0.2367391160304123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4574463682560094d, y: 0.9833849625695176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526103636871522d, y: 0.17963969773914878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045836574511074d, y: 0.8071388994646471d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2015071927633113d, y: 0.3295625802661437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562417922039479d, y: 0.41289489664393386d), new NpgsqlTypes.NpgsqlPoint(x: 0.15178999926002334d, y: 0.3600568079291314d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9833162938979989d, y: 0.5174564274030401d), new NpgsqlTypes.NpgsqlPoint(x: 0.45550603332213613d, y: 0.7070277354283196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506281748340384d, y: 0.2822662170579987d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6747137404998826d, y: 0.7102787059802903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832737095013914d, y: 0.4111876201656596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328032001699971d, y: 0.06222844606244138d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08458191977101936d, y: 0.3614203257740791d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529273524996267d, y: 0.8782511782159788d), new NpgsqlTypes.NpgsqlPoint(x: 0.4382076534156022d, y: 0.6794880322102427d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8648749740415375d, y: 0.016485604094621742d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005364363185799d, y: 0.696691559782995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859434616081578d, y: 0.26672674779167116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8725405230708662d, y: 0.4438689694875908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733378637213844d, y: 0.34845918016152044d), new NpgsqlTypes.NpgsqlPoint(x: 2.234009734125575E-05d, y: 0.38174021836970784d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34448018147752146d, y: 0.6104670565318091d), new NpgsqlTypes.NpgsqlPoint(x: 0.49577136236050734d, y: 0.4685513317581044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512177033341438d, y: 0.6483330385436452d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.036854265182680535d, y: 0.04672140194237073d), new NpgsqlTypes.NpgsqlPoint(x: 0.35610396888044127d, y: 0.2991935978767116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846016219867064d, y: 0.03613840424076853d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817026062416026d, y: 0.6242759662065199d), new NpgsqlTypes.NpgsqlPoint(x: 0.45623084487969656d, y: 0.635118669411018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945453316775529d, y: 0.4175481174553549d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8743449050694175d, y: 0.6723696049459603d), new NpgsqlTypes.NpgsqlPoint(x: 0.21165508927718635d, y: 0.9371213885220226d), new NpgsqlTypes.NpgsqlPoint(x: 0.31028456632070944d, y: 0.14787527520490906d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042035544639760114d, y: 0.6279313661596438d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962041641327726d, y: 0.8106205948853266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4768504045206001d, y: 0.07633302772548722d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044655343765176d, y: 0.2741613563352573d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699839674262708d, y: 0.116447515493601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673331840034779d, y: 0.13524251494831807d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5088610527257103d, y: 0.017321146358317496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7692318794843882d, y: 0.14950958609556786d), new NpgsqlTypes.NpgsqlPoint(x: 0.21760114761137428d, y: 0.6352708640364801d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43792111733813266d, y: 0.21218949943862564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089970780993583d, y: 0.3979045531129325d), new NpgsqlTypes.NpgsqlPoint(x: 0.17434378791419414d, y: 0.9108311066614341d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9828942786703349d, y: 0.8832791091693706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881560298935174d, y: 0.38406963409516937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569181690175319d, y: 0.49148011926249413d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6529010142720741d, y: 0.2766669453544681d), new NpgsqlTypes.NpgsqlPoint(x: 0.21374937252348825d, y: 0.2685155595267189d), new NpgsqlTypes.NpgsqlPoint(x: 0.06684192314704362d, y: 0.7504845542334597d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7176113685978237d, y: 0.2167872783920345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125808585193097d, y: 0.04042318275497403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8746807859491855d, y: 0.1346205725474433d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6744327310718758d, y: 0.23368339608906274d), new NpgsqlTypes.NpgsqlPoint(x: 0.05355342105034744d, y: 0.022409524857960328d), new NpgsqlTypes.NpgsqlPoint(x: 0.965981440036902d, y: 0.01979514023969209d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09161307378969685d, y: 0.8061798134813777d), new NpgsqlTypes.NpgsqlPoint(x: 0.013876156745381008d, y: 0.958559347808631d), new NpgsqlTypes.NpgsqlPoint(x: 0.09902590187411109d, y: 0.17515754395533756d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1074549677118416d, y: 0.2776630815625667d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799286962701102d, y: 0.15657000087074324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185773102164105d, y: 0.9860765954837798d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12834617800718873d, y: 0.425655846487515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479502184738151d, y: 0.9717714176828157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7709705181311585d, y: 0.7716268689376844d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018130172805071676d, y: 0.386185622993491d), new NpgsqlTypes.NpgsqlPoint(x: 0.07793700487420285d, y: 0.594659652780223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1779058394560269d, y: 0.12951329820814328d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14760120004184407d, y: 0.7853984409446455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457821954130117d, y: 0.6180431962032292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7434708673314611d, y: 0.21842279252107177d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4522625686257381d, y: 0.25628906099317916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495323754122606d, y: 0.46317969338779097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142380024764069d, y: 0.6690407438457638d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10990713406608765d, y: 0.7035977251753757d), new NpgsqlTypes.NpgsqlPoint(x: 0.41918371323716364d, y: 0.833358922758353d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583118154843239d, y: 0.8094493847902342d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.548774026557678d, y: 0.008562694092290268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5042934932427833d, y: 0.7268336558930618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644150834186367d, y: 0.1850001438036981d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14755776422927014d, y: 0.34296058321439715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183297771734847d, y: 0.3791718088986602d), new NpgsqlTypes.NpgsqlPoint(x: 0.095222708256965d, y: 0.7050418005474931d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46301917261181413d, y: 0.9001903443988426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722430325438847d, y: 0.9754341031376873d), new NpgsqlTypes.NpgsqlPoint(x: 0.38730558348120836d, y: 0.42514135285214416d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23907786160688926d, y: 0.44015981488318745d), new NpgsqlTypes.NpgsqlPoint(x: 0.04775548275232633d, y: 0.637887264678525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169153939694833d, y: 0.36871041410910455d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45760872486913895d, y: 0.5042073291039355d), new NpgsqlTypes.NpgsqlPoint(x: 0.021810146466046842d, y: 0.060386503731723495d), new NpgsqlTypes.NpgsqlPoint(x: 0.02137677006846206d, y: 0.9872027339302073d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07805301115019281d, y: 0.5951519946305289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550472676946635d, y: 0.6002681255273119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566721572245451d, y: 0.29875707610178015d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6875945644452296d, y: 0.4112367311598184d), new NpgsqlTypes.NpgsqlPoint(x: 0.0398059652532291d, y: 0.36168001327835386d), new NpgsqlTypes.NpgsqlPoint(x: 0.558380041134694d, y: 0.7317248204737717d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03521351609386725d, y: 0.8539198305737418d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940206619254412d, y: 0.08225834699912293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6857923931168586d, y: 0.2539414006398669d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6286697998145689d, y: 0.6866685496342556d), new NpgsqlTypes.NpgsqlPoint(x: 0.29337033121114287d, y: 0.7868382753883324d), new NpgsqlTypes.NpgsqlPoint(x: 0.20197918660941283d, y: 0.4994112832388117d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8787966135969303d, y: 0.37779190137013097d), new NpgsqlTypes.NpgsqlPoint(x: 0.14734482125905024d, y: 0.19209456793314672d), new NpgsqlTypes.NpgsqlPoint(x: 0.42126368958304383d, y: 0.629344680777149d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5616952745401489d, y: 0.7149945302155847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7917811881626048d, y: 0.9412137080090931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5682131989587561d, y: 0.36808933304474645d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24006232914301195d, y: 0.6475357268523556d), new NpgsqlTypes.NpgsqlPoint(x: 0.23714059507925656d, y: 0.28472798033882907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401816175640466d, y: 0.31437939295527806d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12454305773655905d, y: 0.05318553798308612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667780943091198d, y: 0.8622879520291732d), new NpgsqlTypes.NpgsqlPoint(x: 0.3876576026721208d, y: 0.762442065225159d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45639874115271795d, y: 0.551175358202867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3403081200166811d, y: 0.6062347598481517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477735405243384d, y: 0.4554811287553445d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44218635872289225d, y: 0.6855688461395483d), new NpgsqlTypes.NpgsqlPoint(x: 0.402955818676638d, y: 0.6041213382060211d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798650468151118d, y: 0.8578681630244613d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5292403601483089d, y: 0.9010095924865424d), new NpgsqlTypes.NpgsqlPoint(x: 0.18748414808929836d, y: 0.15377086058532108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8194186596784195d, y: 0.5708977691399488d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44588753683204885d, y: 0.47867900794379004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657253265011477d, y: 0.9239635175069077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612310041973614d, y: 0.9163238680105747d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20775831856488158d, y: 0.46288127341048435d), new NpgsqlTypes.NpgsqlPoint(x: 0.577300088057304d, y: 0.06755759604158185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493883874537294d, y: 0.20260382190928095d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6637440739053889d, y: 0.2567968429009879d), new NpgsqlTypes.NpgsqlPoint(x: 0.10374400860437893d, y: 0.6192712254796957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379193137415623d, y: 0.43883077503233425d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8752162186368537d, y: 0.37577161950995086d), new NpgsqlTypes.NpgsqlPoint(x: 0.08816485538552443d, y: 0.8489322527256338d), new NpgsqlTypes.NpgsqlPoint(x: 0.02581253598269939d, y: 0.23094242422601352d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5708822693876916d, y: 0.9009536489409592d), new NpgsqlTypes.NpgsqlPoint(x: 0.40123966952652423d, y: 0.2846038166312872d), new NpgsqlTypes.NpgsqlPoint(x: 0.12110336114154818d, y: 0.6962749650402247d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6722485008915391d, y: 0.0018749844156213946d), new NpgsqlTypes.NpgsqlPoint(x: 0.0022054049041759782d, y: 0.08498728833709546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897596215385982d, y: 0.8875396754365821d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18301916725973055d, y: 0.8112309806521455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411267165125912d, y: 0.7466829563972662d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267436091774767d, y: 0.05724357423042892d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4742962078166425d, y: 0.750179639850587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3418396891537613d, y: 0.9572285695133299d), new NpgsqlTypes.NpgsqlPoint(x: 0.2963481736464014d, y: 0.2824939969447743d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989894913049381d, y: 0.9073229814524243d), new NpgsqlTypes.NpgsqlPoint(x: 0.13368772116147054d, y: 0.5691662869246783d), new NpgsqlTypes.NpgsqlPoint(x: 0.23918022288174412d, y: 0.8122556674376367d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3390986117370587d, y: 0.10390330380519497d), new NpgsqlTypes.NpgsqlPoint(x: 0.275400855224499d, y: 0.6246912224780466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860326468235647d, y: 0.9530206501540276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42389606214075803d, y: 0.7729485058458516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547118359991885d, y: 0.055541248316037684d), new NpgsqlTypes.NpgsqlPoint(x: 0.24258119547563428d, y: 0.3190728626177711d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5624021923243806d, y: 0.9850867904603511d), new NpgsqlTypes.NpgsqlPoint(x: 0.1770251010374274d, y: 0.2917877391749796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468923647173702d, y: 0.8704794173243094d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.740842681651666d, y: 0.9444318960040754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909522554932157d, y: 0.12277699906226613d), new NpgsqlTypes.NpgsqlPoint(x: 0.25773427739749677d, y: 0.751280185996536d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3436097470012296d, y: 0.7685217936466265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568692558645027d, y: 0.9438471014359147d), new NpgsqlTypes.NpgsqlPoint(x: 0.013808220914276026d, y: 0.3896698280126032d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3151521448697946d, y: 0.38949754481072285d), new NpgsqlTypes.NpgsqlPoint(x: 0.38544423662676386d, y: 0.30666358311797015d), new NpgsqlTypes.NpgsqlPoint(x: 0.020958533770717103d, y: 0.13479008841242257d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.440210377415749d, y: 0.6099867487223255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052359286738362d, y: 0.036181958028759564d), new NpgsqlTypes.NpgsqlPoint(x: 0.15994294785013918d, y: 0.6686550062569894d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5877340330830522d, y: 0.08895001076234899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7023224171971362d, y: 0.41685723600874813d), new NpgsqlTypes.NpgsqlPoint(x: 0.31179636544326084d, y: 0.9540315038900679d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33092456204298826d, y: 0.03480732526941044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5908454346186093d, y: 0.8513757918395853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081456646789851d, y: 0.1594227305963385d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09036716762182417d, y: 0.1876931104814057d), new NpgsqlTypes.NpgsqlPoint(x: 0.10843599127745018d, y: 0.7199130018566068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997159194227974d, y: 0.20053679513336198d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016724810099608578d, y: 0.21372991583534406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239560491724939d, y: 0.0885982229792307d), new NpgsqlTypes.NpgsqlPoint(x: 0.43952849122725224d, y: 0.813467458546997d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05347452910335371d, y: 0.8258653249465975d), new NpgsqlTypes.NpgsqlPoint(x: 0.4912144001038734d, y: 0.516737405422409d), new NpgsqlTypes.NpgsqlPoint(x: 0.4169386562960421d, y: 0.5949220493175498d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.860667033777785d, y: 0.15827039082645322d), new NpgsqlTypes.NpgsqlPoint(x: 0.04215093025337868d, y: 0.8620032108208774d), new NpgsqlTypes.NpgsqlPoint(x: 0.003525918551865237d, y: 0.9191429923735149d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8856366149100965d, y: 0.7111550370906679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850282026991466d, y: 0.9066540642436831d), new NpgsqlTypes.NpgsqlPoint(x: 0.40172127112389966d, y: 0.47541649398661034d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7885365424081695d, y: 0.5306604217150505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631771439705486d, y: 0.22368656595913472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149022409194692d, y: 0.6191523436667136d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3853484292211481d, y: 0.528679313214265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769495917269304d, y: 0.5865411629469044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966105010287968d, y: 0.7795748631342706d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2590352068403913d, y: 0.6402829153640184d), new NpgsqlTypes.NpgsqlPoint(x: 0.2356282497926777d, y: 0.9470017773923345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829002534656689d, y: 0.08942441131217149d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7157810324391163d, y: 0.39492137831895724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192923557080516d, y: 0.8505583595290064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428999963852302d, y: 0.27576239400501d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7617713210194196d, y: 0.03131733223243538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246944333958574d, y: 0.13378991863603562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128919182154188d, y: 0.7114604730938422d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8488207307595923d, y: 0.8152423920402292d), new NpgsqlTypes.NpgsqlPoint(x: 0.20989859126149946d, y: 0.26084821146710635d), new NpgsqlTypes.NpgsqlPoint(x: 0.642899724022087d, y: 0.25991802204542325d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44909196125935746d, y: 0.3616588397984888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366205107626338d, y: 0.9300219612182328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114494522008937d, y: 0.4310773716876718d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31243949995932674d, y: 0.20586337828495072d), new NpgsqlTypes.NpgsqlPoint(x: 0.818021450835617d, y: 0.975314395832313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375837411134936d, y: 0.8024062557298848d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.757906466934978d, y: 0.595017479463285d), new NpgsqlTypes.NpgsqlPoint(x: 0.3237447090974561d, y: 0.4676279752588539d), new NpgsqlTypes.NpgsqlPoint(x: 0.9423805689301205d, y: 0.32026544276393565d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24945143612491105d, y: 0.777238215425845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786933780834172d, y: 0.3803024544095489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7422949291741165d, y: 0.001435656977356703d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20742981494769608d, y: 0.929711748894219d), new NpgsqlTypes.NpgsqlPoint(x: 0.12893278068881464d, y: 0.6789247230296734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481508595781668d, y: 0.8446313497505595d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15426636991946885d, y: 0.10597618435050282d), new NpgsqlTypes.NpgsqlPoint(x: 0.771619035697118d, y: 0.9941826926330927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262376091644767d, y: 0.8060711073361094d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2919346248176098d, y: 0.8543739426258644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733041922254961d, y: 0.4580965825331136d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672817723223453d, y: 0.808991713884517d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5210484885260098d, y: 0.40518415573682287d), new NpgsqlTypes.NpgsqlPoint(x: 0.1679741238112873d, y: 0.4966831534778854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864326380666219d, y: 0.7091628554464273d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17201608578900252d, y: 0.05589681147040315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462663322947992d, y: 0.7558574384018941d), new NpgsqlTypes.NpgsqlPoint(x: 0.36501055432365515d, y: 0.6009187919005264d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06325955299992458d, y: 0.6779251998828336d), new NpgsqlTypes.NpgsqlPoint(x: 0.939269156266494d, y: 0.21448434896532964d), new NpgsqlTypes.NpgsqlPoint(x: 0.07639514620638599d, y: 0.025934245406724066d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25206423407075496d, y: 0.35693694875564563d), new NpgsqlTypes.NpgsqlPoint(x: 0.22858248480908627d, y: 0.7176410870540002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449677855998227d, y: 0.4094013642418681d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1275698175274963d, y: 0.766838317424375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092689316757149d, y: 0.04710782735754104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719871233723811d, y: 0.36184799271339096d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9091071626899441d, y: 0.6186751626343134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019215199147087d, y: 0.19566277825893763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1640940125752247d, y: 0.507990729802439d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9555463977361468d, y: 0.19719753889021885d), new NpgsqlTypes.NpgsqlPoint(x: 0.059750350568457344d, y: 0.39489055292293473d), new NpgsqlTypes.NpgsqlPoint(x: 0.23388128556354792d, y: 0.1707399649197593d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8587059479782572d, y: 0.4378428843508261d), new NpgsqlTypes.NpgsqlPoint(x: 0.09054424184451149d, y: 0.4144401774211467d), new NpgsqlTypes.NpgsqlPoint(x: 0.06417756670232055d, y: 0.5719946482351698d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16541180134381195d, y: 0.2510885609037298d), new NpgsqlTypes.NpgsqlPoint(x: 0.49596768212837294d, y: 0.6695942896583703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246039034970749d, y: 0.2367391160304123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4574463682560094d, y: 0.9833849625695176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526103636871522d, y: 0.17963969773914878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045836574511074d, y: 0.8071388994646471d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2015071927633113d, y: 0.3295625802661437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562417922039479d, y: 0.41289489664393386d), new NpgsqlTypes.NpgsqlPoint(x: 0.15178999926002334d, y: 0.3600568079291314d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9833162938979989d, y: 0.5174564274030401d), new NpgsqlTypes.NpgsqlPoint(x: 0.45550603332213613d, y: 0.7070277354283196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506281748340384d, y: 0.2822662170579987d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6747137404998826d, y: 0.7102787059802903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832737095013914d, y: 0.4111876201656596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328032001699971d, y: 0.06222844606244138d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08458191977101936d, y: 0.3614203257740791d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529273524996267d, y: 0.8782511782159788d), new NpgsqlTypes.NpgsqlPoint(x: 0.4382076534156022d, y: 0.6794880322102427d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8648749740415375d, y: 0.016485604094621742d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005364363185799d, y: 0.696691559782995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859434616081578d, y: 0.26672674779167116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8725405230708662d, y: 0.4438689694875908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733378637213844d, y: 0.34845918016152044d), new NpgsqlTypes.NpgsqlPoint(x: 2.234009734125575E-05d, y: 0.38174021836970784d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34448018147752146d, y: 0.6104670565318091d), new NpgsqlTypes.NpgsqlPoint(x: 0.49577136236050734d, y: 0.4685513317581044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512177033341438d, y: 0.6483330385436452d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.036854265182680535d, y: 0.04672140194237073d), new NpgsqlTypes.NpgsqlPoint(x: 0.35610396888044127d, y: 0.2991935978767116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846016219867064d, y: 0.03613840424076853d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817026062416026d, y: 0.6242759662065199d), new NpgsqlTypes.NpgsqlPoint(x: 0.45623084487969656d, y: 0.635118669411018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945453316775529d, y: 0.4175481174553549d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8743449050694175d, y: 0.6723696049459603d), new NpgsqlTypes.NpgsqlPoint(x: 0.21165508927718635d, y: 0.9371213885220226d), new NpgsqlTypes.NpgsqlPoint(x: 0.31028456632070944d, y: 0.14787527520490906d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042035544639760114d, y: 0.6279313661596438d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962041641327726d, y: 0.8106205948853266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4768504045206001d, y: 0.07633302772548722d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044655343765176d, y: 0.2741613563352573d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699839674262708d, y: 0.116447515493601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673331840034779d, y: 0.13524251494831807d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5088610527257103d, y: 0.017321146358317496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7692318794843882d, y: 0.14950958609556786d), new NpgsqlTypes.NpgsqlPoint(x: 0.21760114761137428d, y: 0.6352708640364801d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43792111733813266d, y: 0.21218949943862564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089970780993583d, y: 0.3979045531129325d), new NpgsqlTypes.NpgsqlPoint(x: 0.17434378791419414d, y: 0.9108311066614341d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9828942786703349d, y: 0.8832791091693706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881560298935174d, y: 0.38406963409516937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569181690175319d, y: 0.49148011926249413d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6529010142720741d, y: 0.2766669453544681d), new NpgsqlTypes.NpgsqlPoint(x: 0.21374937252348825d, y: 0.2685155595267189d), new NpgsqlTypes.NpgsqlPoint(x: 0.06684192314704362d, y: 0.7504845542334597d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7176113685978237d, y: 0.2167872783920345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125808585193097d, y: 0.04042318275497403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8746807859491855d, y: 0.1346205725474433d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6744327310718758d, y: 0.23368339608906274d), new NpgsqlTypes.NpgsqlPoint(x: 0.05355342105034744d, y: 0.022409524857960328d), new NpgsqlTypes.NpgsqlPoint(x: 0.965981440036902d, y: 0.01979514023969209d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09161307378969685d, y: 0.8061798134813777d), new NpgsqlTypes.NpgsqlPoint(x: 0.013876156745381008d, y: 0.958559347808631d), new NpgsqlTypes.NpgsqlPoint(x: 0.09902590187411109d, y: 0.17515754395533756d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1074549677118416d, y: 0.2776630815625667d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799286962701102d, y: 0.15657000087074324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185773102164105d, y: 0.9860765954837798d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12834617800718873d, y: 0.425655846487515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479502184738151d, y: 0.9717714176828157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7709705181311585d, y: 0.7716268689376844d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018130172805071676d, y: 0.386185622993491d), new NpgsqlTypes.NpgsqlPoint(x: 0.07793700487420285d, y: 0.594659652780223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1779058394560269d, y: 0.12951329820814328d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14760120004184407d, y: 0.7853984409446455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457821954130117d, y: 0.6180431962032292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7434708673314611d, y: 0.21842279252107177d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4522625686257381d, y: 0.25628906099317916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495323754122606d, y: 0.46317969338779097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142380024764069d, y: 0.6690407438457638d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10990713406608765d, y: 0.7035977251753757d), new NpgsqlTypes.NpgsqlPoint(x: 0.41918371323716364d, y: 0.833358922758353d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583118154843239d, y: 0.8094493847902342d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.548774026557678d, y: 0.008562694092290268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5042934932427833d, y: 0.7268336558930618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644150834186367d, y: 0.1850001438036981d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14755776422927014d, y: 0.34296058321439715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183297771734847d, y: 0.3791718088986602d), new NpgsqlTypes.NpgsqlPoint(x: 0.095222708256965d, y: 0.7050418005474931d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46301917261181413d, y: 0.9001903443988426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722430325438847d, y: 0.9754341031376873d), new NpgsqlTypes.NpgsqlPoint(x: 0.38730558348120836d, y: 0.42514135285214416d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23907786160688926d, y: 0.44015981488318745d), new NpgsqlTypes.NpgsqlPoint(x: 0.04775548275232633d, y: 0.637887264678525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169153939694833d, y: 0.36871041410910455d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45760872486913895d, y: 0.5042073291039355d), new NpgsqlTypes.NpgsqlPoint(x: 0.021810146466046842d, y: 0.060386503731723495d), new NpgsqlTypes.NpgsqlPoint(x: 0.02137677006846206d, y: 0.9872027339302073d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07805301115019281d, y: 0.5951519946305289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550472676946635d, y: 0.6002681255273119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566721572245451d, y: 0.29875707610178015d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6875945644452296d, y: 0.4112367311598184d), new NpgsqlTypes.NpgsqlPoint(x: 0.0398059652532291d, y: 0.36168001327835386d), new NpgsqlTypes.NpgsqlPoint(x: 0.558380041134694d, y: 0.7317248204737717d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03521351609386725d, y: 0.8539198305737418d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940206619254412d, y: 0.08225834699912293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6857923931168586d, y: 0.2539414006398669d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6286697998145689d, y: 0.6866685496342556d), new NpgsqlTypes.NpgsqlPoint(x: 0.29337033121114287d, y: 0.7868382753883324d), new NpgsqlTypes.NpgsqlPoint(x: 0.20197918660941283d, y: 0.4994112832388117d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8787966135969303d, y: 0.37779190137013097d), new NpgsqlTypes.NpgsqlPoint(x: 0.14734482125905024d, y: 0.19209456793314672d), new NpgsqlTypes.NpgsqlPoint(x: 0.42126368958304383d, y: 0.629344680777149d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5616952745401489d, y: 0.7149945302155847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7917811881626048d, y: 0.9412137080090931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5682131989587561d, y: 0.36808933304474645d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24006232914301195d, y: 0.6475357268523556d), new NpgsqlTypes.NpgsqlPoint(x: 0.23714059507925656d, y: 0.28472798033882907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401816175640466d, y: 0.31437939295527806d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12454305773655905d, y: 0.05318553798308612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667780943091198d, y: 0.8622879520291732d), new NpgsqlTypes.NpgsqlPoint(x: 0.3876576026721208d, y: 0.762442065225159d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45639874115271795d, y: 0.551175358202867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3403081200166811d, y: 0.6062347598481517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477735405243384d, y: 0.4554811287553445d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44218635872289225d, y: 0.6855688461395483d), new NpgsqlTypes.NpgsqlPoint(x: 0.402955818676638d, y: 0.6041213382060211d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798650468151118d, y: 0.8578681630244613d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5292403601483089d, y: 0.9010095924865424d), new NpgsqlTypes.NpgsqlPoint(x: 0.18748414808929836d, y: 0.15377086058532108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8194186596784195d, y: 0.5708977691399488d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44588753683204885d, y: 0.47867900794379004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657253265011477d, y: 0.9239635175069077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612310041973614d, y: 0.9163238680105747d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20775831856488158d, y: 0.46288127341048435d), new NpgsqlTypes.NpgsqlPoint(x: 0.577300088057304d, y: 0.06755759604158185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493883874537294d, y: 0.20260382190928095d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6637440739053889d, y: 0.2567968429009879d), new NpgsqlTypes.NpgsqlPoint(x: 0.10374400860437893d, y: 0.6192712254796957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379193137415623d, y: 0.43883077503233425d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8752162186368537d, y: 0.37577161950995086d), new NpgsqlTypes.NpgsqlPoint(x: 0.08816485538552443d, y: 0.8489322527256338d), new NpgsqlTypes.NpgsqlPoint(x: 0.02581253598269939d, y: 0.23094242422601352d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5708822693876916d, y: 0.9009536489409592d), new NpgsqlTypes.NpgsqlPoint(x: 0.40123966952652423d, y: 0.2846038166312872d), new NpgsqlTypes.NpgsqlPoint(x: 0.12110336114154818d, y: 0.6962749650402247d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6722485008915391d, y: 0.0018749844156213946d), new NpgsqlTypes.NpgsqlPoint(x: 0.0022054049041759782d, y: 0.08498728833709546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897596215385982d, y: 0.8875396754365821d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18301916725973055d, y: 0.8112309806521455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411267165125912d, y: 0.7466829563972662d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267436091774767d, y: 0.05724357423042892d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4742962078166425d, y: 0.750179639850587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3418396891537613d, y: 0.9572285695133299d), new NpgsqlTypes.NpgsqlPoint(x: 0.2963481736464014d, y: 0.2824939969447743d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989894913049381d, y: 0.9073229814524243d), new NpgsqlTypes.NpgsqlPoint(x: 0.13368772116147054d, y: 0.5691662869246783d), new NpgsqlTypes.NpgsqlPoint(x: 0.23918022288174412d, y: 0.8122556674376367d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3390986117370587d, y: 0.10390330380519497d), new NpgsqlTypes.NpgsqlPoint(x: 0.275400855224499d, y: 0.6246912224780466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7860326468235647d, y: 0.9530206501540276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42389606214075803d, y: 0.7729485058458516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547118359991885d, y: 0.055541248316037684d), new NpgsqlTypes.NpgsqlPoint(x: 0.24258119547563428d, y: 0.3190728626177711d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5624021923243806d, y: 0.9850867904603511d), new NpgsqlTypes.NpgsqlPoint(x: 0.1770251010374274d, y: 0.2917877391749796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468923647173702d, y: 0.8704794173243094d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.740842681651666d, y: 0.9444318960040754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909522554932157d, y: 0.12277699906226613d), new NpgsqlTypes.NpgsqlPoint(x: 0.25773427739749677d, y: 0.751280185996536d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3436097470012296d, y: 0.7685217936466265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568692558645027d, y: 0.9438471014359147d), new NpgsqlTypes.NpgsqlPoint(x: 0.013808220914276026d, y: 0.3896698280126032d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3151521448697946d, y: 0.38949754481072285d), new NpgsqlTypes.NpgsqlPoint(x: 0.38544423662676386d, y: 0.30666358311797015d), new NpgsqlTypes.NpgsqlPoint(x: 0.020958533770717103d, y: 0.13479008841242257d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.440210377415749d, y: 0.6099867487223255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052359286738362d, y: 0.036181958028759564d), new NpgsqlTypes.NpgsqlPoint(x: 0.15994294785013918d, y: 0.6686550062569894d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5877340330830522d, y: 0.08895001076234899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7023224171971362d, y: 0.41685723600874813d), new NpgsqlTypes.NpgsqlPoint(x: 0.31179636544326084d, y: 0.9540315038900679d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33092456204298826d, y: 0.03480732526941044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5908454346186093d, y: 0.8513757918395853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081456646789851d, y: 0.1594227305963385d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09036716762182417d, y: 0.1876931104814057d), new NpgsqlTypes.NpgsqlPoint(x: 0.10843599127745018d, y: 0.7199130018566068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997159194227974d, y: 0.20053679513336198d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016724810099608578d, y: 0.21372991583534406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239560491724939d, y: 0.0885982229792307d), new NpgsqlTypes.NpgsqlPoint(x: 0.43952849122725224d, y: 0.813467458546997d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05347452910335371d, y: 0.8258653249465975d), new NpgsqlTypes.NpgsqlPoint(x: 0.4912144001038734d, y: 0.516737405422409d), new NpgsqlTypes.NpgsqlPoint(x: 0.4169386562960421d, y: 0.5949220493175498d)))));

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygone0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

