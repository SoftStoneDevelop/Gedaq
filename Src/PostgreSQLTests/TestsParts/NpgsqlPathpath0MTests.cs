

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795948777100559d, y: 0.24494200155820578d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077133840260434d, y: 0.22881326648400158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348649720435426d, y: 0.21061651521179958d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015106817113470394d, y: 0.5601265174095299d), new NpgsqlTypes.NpgsqlPoint(x: 0.15389667106253502d, y: 0.8599309410456887d), new NpgsqlTypes.NpgsqlPoint(x: 0.12516320325157304d, y: 0.6417095710189704d)),
},
            new NpgsqlPathpath0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955955180746293d, y: 0.27277156556587767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277869484259156d, y: 0.09346889446092022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314885779709513d, y: 0.16896813291908286d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8157266955277187d, y: 0.1731200617431321d), new NpgsqlTypes.NpgsqlPoint(x: 0.37467585258898384d, y: 0.5063471715380935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168028845129539d, y: 0.5244082868262159d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.816293771006589d, y: 0.33958686740679667d), new NpgsqlTypes.NpgsqlPoint(x: 0.45389864619657316d, y: 0.4648293096534951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22095478572872207d, y: 0.11048134796554443d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8345675930729826d, y: 0.00463794554141761d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830722173581065d, y: 0.5784590296454428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249746597995814d, y: 0.16993552246413746d)),
},
            new NpgsqlPathpath0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7079916884065032d, y: 0.42253773860328236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327313463122954d, y: 0.49606208352224146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442215210196286d, y: 0.1012260841150503d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7090684131957181d, y: 0.36306071353794955d), new NpgsqlTypes.NpgsqlPoint(x: 0.040486258936714314d, y: 0.037629479500148943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322854262760464d, y: 0.8403608892777209d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10233637095250825d, y: 0.5773865282868157d), new NpgsqlTypes.NpgsqlPoint(x: 0.784794696612511d, y: 0.8724467554207029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266981639319041d, y: 0.36206916546089685d)),
},
            new NpgsqlPathpath0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7471512489527309d, y: 0.0579172301473625d), new NpgsqlTypes.NpgsqlPoint(x: 0.3060900617441812d, y: 0.18871504624590663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2219140740693979d, y: 0.12530337892708898d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5804151630670106d, y: 0.9068951283859988d), new NpgsqlTypes.NpgsqlPoint(x: 0.32116811492829334d, y: 0.968108396589616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101463146918835d, y: 0.9825355812079649d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4042838382610068d, y: 0.25662152811388117d), new NpgsqlTypes.NpgsqlPoint(x: 0.01277150430490881d, y: 0.3394433258736619d), new NpgsqlTypes.NpgsqlPoint(x: 0.37532088894096416d, y: 0.41160038208574923d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7389579996211187d, y: 0.4950005281397918d), new NpgsqlTypes.NpgsqlPoint(x: 0.743784796959358d, y: 0.8961297444751398d), new NpgsqlTypes.NpgsqlPoint(x: 0.44365396984514394d, y: 0.5256695456295177d)),
},
            new NpgsqlPathpath0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.707317693122359d, y: 0.3362247165783151d), new NpgsqlTypes.NpgsqlPoint(x: 0.29656658853125417d, y: 0.8433063982457278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624245501808477d, y: 0.7684478218872242d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03195417602878414d, y: 0.40496304594660437d), new NpgsqlTypes.NpgsqlPoint(x: 0.0294584721792297d, y: 0.31107360497960046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156680191056145d, y: 0.45465334718910855d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4150607174460438d, y: 0.3754370498938123d), new NpgsqlTypes.NpgsqlPoint(x: 0.032787392673755966d, y: 0.2498363537224303d), new NpgsqlTypes.NpgsqlPoint(x: 0.130908465633645d, y: 0.09871322328152321d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9184900292297807d, y: 0.9491097721504096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052294314663586d, y: 0.41087914588412666d), new NpgsqlTypes.NpgsqlPoint(x: 0.46440818788250193d, y: 0.5345950653752258d)),
},
            new NpgsqlPathpath0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8349552045470386d, y: 0.4446171522534863d), new NpgsqlTypes.NpgsqlPoint(x: 0.13839945147843813d, y: 0.1263926511394623d), new NpgsqlTypes.NpgsqlPoint(x: 0.05671754865657963d, y: 0.3110396189455803d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8439651666043734d, y: 0.34816213374702554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078414901443376d, y: 0.20409341812895043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455464065401048d, y: 0.02978659406824602d)),
},
            new NpgsqlPathpath0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.383585342072846d, y: 0.4228405024110967d), new NpgsqlTypes.NpgsqlPoint(x: 0.25636769165538575d, y: 0.7053556663398386d), new NpgsqlTypes.NpgsqlPoint(x: 0.0870301141977079d, y: 0.9280405285483967d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935558208261223d, y: 0.20041058836075443d), new NpgsqlTypes.NpgsqlPoint(x: 0.03765072207506559d, y: 0.8930723979630654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357861129945669d, y: 0.6000969750214317d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22506069850481147d, y: 0.49150114881824225d), new NpgsqlTypes.NpgsqlPoint(x: 0.49939303709515803d, y: 0.9865319933882033d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024685824799159928d, y: 0.06750048846082446d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5501877976709959d, y: 0.1468433545769312d), new NpgsqlTypes.NpgsqlPoint(x: 0.1892606198004213d, y: 0.4154255176341084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8978471094249116d, y: 0.49953383596270196d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4799573108884677d, y: 0.8884860742305016d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795405638110397d, y: 0.7781283539065161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423239748975533d, y: 0.7950305426648884d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8366498102909786d, y: 0.2335302461578712d), new NpgsqlTypes.NpgsqlPoint(x: 0.43959748090139383d, y: 0.4097452272581996d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372105773564155d, y: 0.8346929818829981d)),
},
            new NpgsqlPathpath0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111242609421687d, y: 0.510093960197078d), new NpgsqlTypes.NpgsqlPoint(x: 0.17925520628969793d, y: 0.7866835424465128d), new NpgsqlTypes.NpgsqlPoint(x: 0.05170615959083191d, y: 0.8030040652617272d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13607630043022878d, y: 0.882173175073912d), new NpgsqlTypes.NpgsqlPoint(x: 0.402661897295577d, y: 0.8462289472867176d), new NpgsqlTypes.NpgsqlPoint(x: 0.34492300418762d, y: 0.9892747340471079d)),
},
            new NpgsqlPathpath0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.638353892780443d, y: 0.35702609594759116d), new NpgsqlTypes.NpgsqlPoint(x: 0.39994045511349496d, y: 0.25641914146055245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591091679638d, y: 0.6578979138598158d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38834457103371356d, y: 0.1820054704948526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603255842431958d, y: 0.8539410769577284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2548810278388516d, y: 0.24278438952414438d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09010995594121873d, y: 0.5863869957604797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445847468765561d, y: 0.8339266288749169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052850410438102d, y: 0.8990287974205534d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1451045691392735d, y: 0.8838025851314385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156899766613699d, y: 0.4602208800707731d), new NpgsqlTypes.NpgsqlPoint(x: 0.24067362999070108d, y: 0.45745711337630623d)),
},
            new NpgsqlPathpath0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29787204504413933d, y: 0.4890925985370931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246856141832825d, y: 0.3938952725419774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2506667600986845d, y: 0.25741188306346463d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7228922977752664d, y: 0.580511099147524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272695338511236d, y: 0.5506592986317936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920865591947052d, y: 0.9642617006687588d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9292076361916687d, y: 0.8576598373576929d), new NpgsqlTypes.NpgsqlPoint(x: 0.11494344296047321d, y: 0.4449673656473099d), new NpgsqlTypes.NpgsqlPoint(x: 0.37414119266743706d, y: 0.5732952382591454d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49963238275799016d, y: 0.10103126583729027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243660996529665d, y: 0.01742718538317467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584780183119012d, y: 0.1849180229892421d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6030234454419947d, y: 0.9299534764545696d), new NpgsqlTypes.NpgsqlPoint(x: 0.47196740270736137d, y: 0.29632300096448283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7260346861080426d, y: 0.9549156408007456d)),
},
            new NpgsqlPathpath0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6541856832092926d, y: 0.1330121751269293d), new NpgsqlTypes.NpgsqlPoint(x: 0.44980815942664554d, y: 0.5240075444080721d), new NpgsqlTypes.NpgsqlPoint(x: 0.23322507643545665d, y: 0.3718444692695584d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.699781282976509d, y: 0.06405848177656692d), new NpgsqlTypes.NpgsqlPoint(x: 0.12999442603789357d, y: 0.6169618685860371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499951649729227d, y: 0.8717984414195775d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03695871549109098d, y: 0.1667909398484404d), new NpgsqlTypes.NpgsqlPoint(x: 0.026250432210321417d, y: 0.27430616114962525d), new NpgsqlTypes.NpgsqlPoint(x: 0.2627966916584519d, y: 0.6588104970438505d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6450139765151491d, y: 0.2692944106869932d), new NpgsqlTypes.NpgsqlPoint(x: 0.978318901908066d, y: 0.5445310123159199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475917392913801d, y: 0.11581658317750665d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5018328631311532d, y: 0.193138703938331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105186647381872d, y: 0.41357107843688523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768066063828452d, y: 0.9633429790728819d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20915304448944627d, y: 0.17220166229859812d), new NpgsqlTypes.NpgsqlPoint(x: 0.49181759301285277d, y: 0.9326229938270565d), new NpgsqlTypes.NpgsqlPoint(x: 0.2193575591924556d, y: 0.8889444248805942d)),
},
            new NpgsqlPathpath0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2827138615561291d, y: 0.10789557566189945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737627896326351d, y: 0.9021731677432845d), new NpgsqlTypes.NpgsqlPoint(x: 0.21977697840381472d, y: 0.09387892529773534d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9992563822756555d, y: 0.6144406477372559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4143380175124144d, y: 0.21295360486242776d), new NpgsqlTypes.NpgsqlPoint(x: 0.2712282261107767d, y: 0.3993959685396351d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9251159235154397d, y: 0.6542659578306143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2235516620039545d, y: 0.5402088720111018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577042099842002d, y: 0.562284576246444d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768912735092042d, y: 0.6170996880193937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7959855482592222d, y: 0.41195614226250743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418119232804508d, y: 0.7703333243972894d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1664195254805575d, y: 0.21963133739520535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354573373918922d, y: 0.7301531442806569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955486616291073d, y: 0.6494369613864395d)),
},
            new NpgsqlPathpath0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9969299789846074d, y: 0.8386535792351129d), new NpgsqlTypes.NpgsqlPoint(x: 0.01705769215971964d, y: 0.11119160554746221d), new NpgsqlTypes.NpgsqlPoint(x: 0.19275389594416903d, y: 0.7450224011154774d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8056432886964929d, y: 0.3445551883525637d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689761875795442d, y: 0.9608702131747155d), new NpgsqlTypes.NpgsqlPoint(x: 0.806091782069586d, y: 0.6441382761869004d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8240769173241966d, y: 0.886475557608633d), new NpgsqlTypes.NpgsqlPoint(x: 0.44776079167900507d, y: 0.154292623438956d), new NpgsqlTypes.NpgsqlPoint(x: 0.17958781943899604d, y: 0.1183368978184729d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12248370540043474d, y: 0.6285745081259411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3884725924549114d, y: 0.5863936236015603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7598530116572526d, y: 0.4348528789021886d)),
},
            new NpgsqlPathpath0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10783669032538712d, y: 0.3938190142879635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5732160536780394d, y: 0.9397955551010231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888983341523654d, y: 0.3902070032160936d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5879285482186477d, y: 0.01719821581444614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567614774308056d, y: 0.8744803692308817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3451825655370969d, y: 0.6136360934355864d)),
},
            new NpgsqlPathpath0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050695276707874d, y: 0.9062782487467006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033635248746139d, y: 0.18617938691584424d), new NpgsqlTypes.NpgsqlPoint(x: 0.43002108673484973d, y: 0.9808862133304721d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874510295445018d, y: 0.4141130816505352d), new NpgsqlTypes.NpgsqlPoint(x: 0.3335509443604723d, y: 0.0722540378595462d), new NpgsqlTypes.NpgsqlPoint(x: 0.14337805321184216d, y: 0.7978877355272663d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01730343777622534d, y: 0.790214559054871d), new NpgsqlTypes.NpgsqlPoint(x: 0.043355247316348766d, y: 0.638854461687721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510954660089783d, y: 0.0869043934691921d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8338259434969422d, y: 0.29651788145370295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515557088318797d, y: 0.628117456381131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954101388341601d, y: 0.594152705382025d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7356888808834885d, y: 0.11432637139940871d), new NpgsqlTypes.NpgsqlPoint(x: 0.027984626983193817d, y: 0.883490582159101d), new NpgsqlTypes.NpgsqlPoint(x: 0.361659402018333d, y: 0.4331572438435676d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29403894694436084d, y: 0.40180368630182195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3178743285860576d, y: 0.153096327270428d), new NpgsqlTypes.NpgsqlPoint(x: 0.29610495940230075d, y: 0.7502401054021579d)),
},
            new NpgsqlPathpath0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24529670707441598d, y: 0.5980744408781963d), new NpgsqlTypes.NpgsqlPoint(x: 0.24681578366302714d, y: 0.6958176049960657d), new NpgsqlTypes.NpgsqlPoint(x: 0.824831479446027d, y: 0.2702433755490621d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9712095439884101d, y: 0.7760030160962612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507775861610031d, y: 0.873589814442291d), new NpgsqlTypes.NpgsqlPoint(x: 0.3149573665863755d, y: 0.034087251789882145d)),
},
            new NpgsqlPathpath0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4024729319373179d, y: 0.3938729038080405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848336393896177d, y: 0.3706811668541413d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139452643521159d, y: 0.5707174164214251d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6972559458329761d, y: 0.07303814858828772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570295474607084d, y: 0.4605588911159655d), new NpgsqlTypes.NpgsqlPoint(x: 0.24196444081972213d, y: 0.6950093510319219d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6364744071536126d, y: 0.5319769205981835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957937653160966d, y: 0.8951178539145205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438429011877418d, y: 0.3662801856949315d)),
},
            new NpgsqlPathpath0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044655152382003d, y: 0.3702759800629444d), new NpgsqlTypes.NpgsqlPoint(x: 0.16055610243757856d, y: 0.6158143042871252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296255812718079d, y: 0.37300285852948445d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8322806603086708d, y: 0.1758642721790128d), new NpgsqlTypes.NpgsqlPoint(x: 0.11847150886337376d, y: 0.7140864613291475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978591860742507d, y: 0.5143438207517226d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7694758338669766d, y: 0.5279019192949403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646270751180059d, y: 0.7936588475326557d), new NpgsqlTypes.NpgsqlPoint(x: 0.31614668658964584d, y: 0.3455009814490083d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8406339268096104d, y: 0.5101954552503477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608618186166973d, y: 0.9813890507995479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495046391299781d, y: 0.17927112087828034d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09308033790946324d, y: 0.7175217469120756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460356247955683d, y: 0.8994653908675424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301256869975177d, y: 0.3742760856255749d)),
},
            new NpgsqlPathpath0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14404471918074824d, y: 0.47436203490815765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372802892465188d, y: 0.5790341376250215d), new NpgsqlTypes.NpgsqlPoint(x: 0.26752325727300064d, y: 0.6921588434159743d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 175,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7332477491965553d, y: 0.21816021140655817d), new NpgsqlTypes.NpgsqlPoint(x: 0.024607061978443423d, y: 0.2229576744206786d), new NpgsqlTypes.NpgsqlPoint(x: 0.028029490746602992d, y: 0.6761626709710139d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5834729765255158d, y: 0.07457457781423538d), new NpgsqlTypes.NpgsqlPoint(x: 0.45186297571769196d, y: 0.8341529321480197d), new NpgsqlTypes.NpgsqlPoint(x: 0.01097778137443084d, y: 0.9136426919029893d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4298528980659011d, y: 0.7398705757189467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8553516748930418d, y: 0.00489941851831277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835423895607271d, y: 0.5939257713140635d)),
},
            new NpgsqlPathpath0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22087946238863454d, y: 0.8135454643239002d), new NpgsqlTypes.NpgsqlPoint(x: 0.18436343280197376d, y: 0.6946044645830699d), new NpgsqlTypes.NpgsqlPoint(x: 0.11482236061360518d, y: 0.02830553840537231d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06529777093865352d, y: 0.12321799637632513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3596828523114932d, y: 0.21768870393578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529112525077667d, y: 0.7807822631550586d)),
},
            new NpgsqlPathpath0M
{
    Id = 182,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13126722115866796d, y: 0.18052859728914172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6416276172402801d, y: 0.05696372228437585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183714328814642d, y: 0.8083487864628675d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5704636291017421d, y: 0.09273759460582198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321603968761276d, y: 0.9008457677778225d), new NpgsqlTypes.NpgsqlPoint(x: 0.506228995392915d, y: 0.8122596615660278d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30996696888001307d, y: 0.5057321027849654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581442541678389d, y: 0.935195954686247d), new NpgsqlTypes.NpgsqlPoint(x: 0.1952080730007688d, y: 0.48953856854561817d)),
},
            new NpgsqlPathpath0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9818712744550926d, y: 0.01752989668634153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848546255351717d, y: 0.5215546929308864d), new NpgsqlTypes.NpgsqlPoint(x: 0.47650193355613646d, y: 0.6619013636791566d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7389579996211187d, y: 0.4950005281397918d), new NpgsqlTypes.NpgsqlPoint(x: 0.743784796959358d, y: 0.8961297444751398d), new NpgsqlTypes.NpgsqlPoint(x: 0.44365396984514394d, y: 0.5256695456295177d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9184900292297807d, y: 0.9491097721504096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052294314663586d, y: 0.41087914588412666d), new NpgsqlTypes.NpgsqlPoint(x: 0.46440818788250193d, y: 0.5345950653752258d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8439651666043734d, y: 0.34816213374702554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078414901443376d, y: 0.20409341812895043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455464065401048d, y: 0.02978659406824602d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8366498102909786d, y: 0.2335302461578712d), new NpgsqlTypes.NpgsqlPoint(x: 0.43959748090139383d, y: 0.4097452272581996d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372105773564155d, y: 0.8346929818829981d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 86, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 138, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 151, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 56, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 9, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 112, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795948777100559d, y: 0.24494200155820578d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077133840260434d, y: 0.22881326648400158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348649720435426d, y: 0.21061651521179958d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015106817113470394d, y: 0.5601265174095299d), new NpgsqlTypes.NpgsqlPoint(x: 0.15389667106253502d, y: 0.8599309410456887d), new NpgsqlTypes.NpgsqlPoint(x: 0.12516320325157304d, y: 0.6417095710189704d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955955180746293d, y: 0.27277156556587767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277869484259156d, y: 0.09346889446092022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314885779709513d, y: 0.16896813291908286d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8157266955277187d, y: 0.1731200617431321d), new NpgsqlTypes.NpgsqlPoint(x: 0.37467585258898384d, y: 0.5063471715380935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168028845129539d, y: 0.5244082868262159d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.816293771006589d, y: 0.33958686740679667d), new NpgsqlTypes.NpgsqlPoint(x: 0.45389864619657316d, y: 0.4648293096534951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22095478572872207d, y: 0.11048134796554443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8345675930729826d, y: 0.00463794554141761d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830722173581065d, y: 0.5784590296454428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249746597995814d, y: 0.16993552246413746d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7079916884065032d, y: 0.42253773860328236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327313463122954d, y: 0.49606208352224146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442215210196286d, y: 0.1012260841150503d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7090684131957181d, y: 0.36306071353794955d), new NpgsqlTypes.NpgsqlPoint(x: 0.040486258936714314d, y: 0.037629479500148943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322854262760464d, y: 0.8403608892777209d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10233637095250825d, y: 0.5773865282868157d), new NpgsqlTypes.NpgsqlPoint(x: 0.784794696612511d, y: 0.8724467554207029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266981639319041d, y: 0.36206916546089685d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7471512489527309d, y: 0.0579172301473625d), new NpgsqlTypes.NpgsqlPoint(x: 0.3060900617441812d, y: 0.18871504624590663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2219140740693979d, y: 0.12530337892708898d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5804151630670106d, y: 0.9068951283859988d), new NpgsqlTypes.NpgsqlPoint(x: 0.32116811492829334d, y: 0.968108396589616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101463146918835d, y: 0.9825355812079649d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4042838382610068d, y: 0.25662152811388117d), new NpgsqlTypes.NpgsqlPoint(x: 0.01277150430490881d, y: 0.3394433258736619d), new NpgsqlTypes.NpgsqlPoint(x: 0.37532088894096416d, y: 0.41160038208574923d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7389579996211187d, y: 0.4950005281397918d), new NpgsqlTypes.NpgsqlPoint(x: 0.743784796959358d, y: 0.8961297444751398d), new NpgsqlTypes.NpgsqlPoint(x: 0.44365396984514394d, y: 0.5256695456295177d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.707317693122359d, y: 0.3362247165783151d), new NpgsqlTypes.NpgsqlPoint(x: 0.29656658853125417d, y: 0.8433063982457278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624245501808477d, y: 0.7684478218872242d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03195417602878414d, y: 0.40496304594660437d), new NpgsqlTypes.NpgsqlPoint(x: 0.0294584721792297d, y: 0.31107360497960046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156680191056145d, y: 0.45465334718910855d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4150607174460438d, y: 0.3754370498938123d), new NpgsqlTypes.NpgsqlPoint(x: 0.032787392673755966d, y: 0.2498363537224303d), new NpgsqlTypes.NpgsqlPoint(x: 0.130908465633645d, y: 0.09871322328152321d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9184900292297807d, y: 0.9491097721504096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052294314663586d, y: 0.41087914588412666d), new NpgsqlTypes.NpgsqlPoint(x: 0.46440818788250193d, y: 0.5345950653752258d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8349552045470386d, y: 0.4446171522534863d), new NpgsqlTypes.NpgsqlPoint(x: 0.13839945147843813d, y: 0.1263926511394623d), new NpgsqlTypes.NpgsqlPoint(x: 0.05671754865657963d, y: 0.3110396189455803d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8439651666043734d, y: 0.34816213374702554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078414901443376d, y: 0.20409341812895043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455464065401048d, y: 0.02978659406824602d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.383585342072846d, y: 0.4228405024110967d), new NpgsqlTypes.NpgsqlPoint(x: 0.25636769165538575d, y: 0.7053556663398386d), new NpgsqlTypes.NpgsqlPoint(x: 0.0870301141977079d, y: 0.9280405285483967d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935558208261223d, y: 0.20041058836075443d), new NpgsqlTypes.NpgsqlPoint(x: 0.03765072207506559d, y: 0.8930723979630654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357861129945669d, y: 0.6000969750214317d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22506069850481147d, y: 0.49150114881824225d), new NpgsqlTypes.NpgsqlPoint(x: 0.49939303709515803d, y: 0.9865319933882033d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024685824799159928d, y: 0.06750048846082446d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5501877976709959d, y: 0.1468433545769312d), new NpgsqlTypes.NpgsqlPoint(x: 0.1892606198004213d, y: 0.4154255176341084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8978471094249116d, y: 0.49953383596270196d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4799573108884677d, y: 0.8884860742305016d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795405638110397d, y: 0.7781283539065161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423239748975533d, y: 0.7950305426648884d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8366498102909786d, y: 0.2335302461578712d), new NpgsqlTypes.NpgsqlPoint(x: 0.43959748090139383d, y: 0.4097452272581996d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372105773564155d, y: 0.8346929818829981d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111242609421687d, y: 0.510093960197078d), new NpgsqlTypes.NpgsqlPoint(x: 0.17925520628969793d, y: 0.7866835424465128d), new NpgsqlTypes.NpgsqlPoint(x: 0.05170615959083191d, y: 0.8030040652617272d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13607630043022878d, y: 0.882173175073912d), new NpgsqlTypes.NpgsqlPoint(x: 0.402661897295577d, y: 0.8462289472867176d), new NpgsqlTypes.NpgsqlPoint(x: 0.34492300418762d, y: 0.9892747340471079d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.638353892780443d, y: 0.35702609594759116d), new NpgsqlTypes.NpgsqlPoint(x: 0.39994045511349496d, y: 0.25641914146055245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591091679638d, y: 0.6578979138598158d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38834457103371356d, y: 0.1820054704948526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603255842431958d, y: 0.8539410769577284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2548810278388516d, y: 0.24278438952414438d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09010995594121873d, y: 0.5863869957604797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445847468765561d, y: 0.8339266288749169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052850410438102d, y: 0.8990287974205534d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1451045691392735d, y: 0.8838025851314385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156899766613699d, y: 0.4602208800707731d), new NpgsqlTypes.NpgsqlPoint(x: 0.24067362999070108d, y: 0.45745711337630623d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29787204504413933d, y: 0.4890925985370931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246856141832825d, y: 0.3938952725419774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2506667600986845d, y: 0.25741188306346463d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7228922977752664d, y: 0.580511099147524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272695338511236d, y: 0.5506592986317936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920865591947052d, y: 0.9642617006687588d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9292076361916687d, y: 0.8576598373576929d), new NpgsqlTypes.NpgsqlPoint(x: 0.11494344296047321d, y: 0.4449673656473099d), new NpgsqlTypes.NpgsqlPoint(x: 0.37414119266743706d, y: 0.5732952382591454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49963238275799016d, y: 0.10103126583729027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243660996529665d, y: 0.01742718538317467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584780183119012d, y: 0.1849180229892421d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6030234454419947d, y: 0.9299534764545696d), new NpgsqlTypes.NpgsqlPoint(x: 0.47196740270736137d, y: 0.29632300096448283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7260346861080426d, y: 0.9549156408007456d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6541856832092926d, y: 0.1330121751269293d), new NpgsqlTypes.NpgsqlPoint(x: 0.44980815942664554d, y: 0.5240075444080721d), new NpgsqlTypes.NpgsqlPoint(x: 0.23322507643545665d, y: 0.3718444692695584d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.699781282976509d, y: 0.06405848177656692d), new NpgsqlTypes.NpgsqlPoint(x: 0.12999442603789357d, y: 0.6169618685860371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499951649729227d, y: 0.8717984414195775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03695871549109098d, y: 0.1667909398484404d), new NpgsqlTypes.NpgsqlPoint(x: 0.026250432210321417d, y: 0.27430616114962525d), new NpgsqlTypes.NpgsqlPoint(x: 0.2627966916584519d, y: 0.6588104970438505d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6450139765151491d, y: 0.2692944106869932d), new NpgsqlTypes.NpgsqlPoint(x: 0.978318901908066d, y: 0.5445310123159199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475917392913801d, y: 0.11581658317750665d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5018328631311532d, y: 0.193138703938331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105186647381872d, y: 0.41357107843688523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768066063828452d, y: 0.9633429790728819d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20915304448944627d, y: 0.17220166229859812d), new NpgsqlTypes.NpgsqlPoint(x: 0.49181759301285277d, y: 0.9326229938270565d), new NpgsqlTypes.NpgsqlPoint(x: 0.2193575591924556d, y: 0.8889444248805942d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2827138615561291d, y: 0.10789557566189945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737627896326351d, y: 0.9021731677432845d), new NpgsqlTypes.NpgsqlPoint(x: 0.21977697840381472d, y: 0.09387892529773534d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9992563822756555d, y: 0.6144406477372559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4143380175124144d, y: 0.21295360486242776d), new NpgsqlTypes.NpgsqlPoint(x: 0.2712282261107767d, y: 0.3993959685396351d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9251159235154397d, y: 0.6542659578306143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2235516620039545d, y: 0.5402088720111018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577042099842002d, y: 0.562284576246444d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768912735092042d, y: 0.6170996880193937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7959855482592222d, y: 0.41195614226250743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418119232804508d, y: 0.7703333243972894d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1664195254805575d, y: 0.21963133739520535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354573373918922d, y: 0.7301531442806569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955486616291073d, y: 0.6494369613864395d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9969299789846074d, y: 0.8386535792351129d), new NpgsqlTypes.NpgsqlPoint(x: 0.01705769215971964d, y: 0.11119160554746221d), new NpgsqlTypes.NpgsqlPoint(x: 0.19275389594416903d, y: 0.7450224011154774d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8056432886964929d, y: 0.3445551883525637d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689761875795442d, y: 0.9608702131747155d), new NpgsqlTypes.NpgsqlPoint(x: 0.806091782069586d, y: 0.6441382761869004d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8240769173241966d, y: 0.886475557608633d), new NpgsqlTypes.NpgsqlPoint(x: 0.44776079167900507d, y: 0.154292623438956d), new NpgsqlTypes.NpgsqlPoint(x: 0.17958781943899604d, y: 0.1183368978184729d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12248370540043474d, y: 0.6285745081259411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3884725924549114d, y: 0.5863936236015603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7598530116572526d, y: 0.4348528789021886d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10783669032538712d, y: 0.3938190142879635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5732160536780394d, y: 0.9397955551010231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888983341523654d, y: 0.3902070032160936d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5879285482186477d, y: 0.01719821581444614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567614774308056d, y: 0.8744803692308817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3451825655370969d, y: 0.6136360934355864d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050695276707874d, y: 0.9062782487467006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033635248746139d, y: 0.18617938691584424d), new NpgsqlTypes.NpgsqlPoint(x: 0.43002108673484973d, y: 0.9808862133304721d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874510295445018d, y: 0.4141130816505352d), new NpgsqlTypes.NpgsqlPoint(x: 0.3335509443604723d, y: 0.0722540378595462d), new NpgsqlTypes.NpgsqlPoint(x: 0.14337805321184216d, y: 0.7978877355272663d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01730343777622534d, y: 0.790214559054871d), new NpgsqlTypes.NpgsqlPoint(x: 0.043355247316348766d, y: 0.638854461687721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510954660089783d, y: 0.0869043934691921d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8338259434969422d, y: 0.29651788145370295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515557088318797d, y: 0.628117456381131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954101388341601d, y: 0.594152705382025d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7356888808834885d, y: 0.11432637139940871d), new NpgsqlTypes.NpgsqlPoint(x: 0.027984626983193817d, y: 0.883490582159101d), new NpgsqlTypes.NpgsqlPoint(x: 0.361659402018333d, y: 0.4331572438435676d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29403894694436084d, y: 0.40180368630182195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3178743285860576d, y: 0.153096327270428d), new NpgsqlTypes.NpgsqlPoint(x: 0.29610495940230075d, y: 0.7502401054021579d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24529670707441598d, y: 0.5980744408781963d), new NpgsqlTypes.NpgsqlPoint(x: 0.24681578366302714d, y: 0.6958176049960657d), new NpgsqlTypes.NpgsqlPoint(x: 0.824831479446027d, y: 0.2702433755490621d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9712095439884101d, y: 0.7760030160962612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507775861610031d, y: 0.873589814442291d), new NpgsqlTypes.NpgsqlPoint(x: 0.3149573665863755d, y: 0.034087251789882145d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4024729319373179d, y: 0.3938729038080405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848336393896177d, y: 0.3706811668541413d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139452643521159d, y: 0.5707174164214251d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6972559458329761d, y: 0.07303814858828772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570295474607084d, y: 0.4605588911159655d), new NpgsqlTypes.NpgsqlPoint(x: 0.24196444081972213d, y: 0.6950093510319219d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6364744071536126d, y: 0.5319769205981835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957937653160966d, y: 0.8951178539145205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438429011877418d, y: 0.3662801856949315d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044655152382003d, y: 0.3702759800629444d), new NpgsqlTypes.NpgsqlPoint(x: 0.16055610243757856d, y: 0.6158143042871252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296255812718079d, y: 0.37300285852948445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8322806603086708d, y: 0.1758642721790128d), new NpgsqlTypes.NpgsqlPoint(x: 0.11847150886337376d, y: 0.7140864613291475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978591860742507d, y: 0.5143438207517226d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7694758338669766d, y: 0.5279019192949403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646270751180059d, y: 0.7936588475326557d), new NpgsqlTypes.NpgsqlPoint(x: 0.31614668658964584d, y: 0.3455009814490083d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8406339268096104d, y: 0.5101954552503477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608618186166973d, y: 0.9813890507995479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495046391299781d, y: 0.17927112087828034d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09308033790946324d, y: 0.7175217469120756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460356247955683d, y: 0.8994653908675424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301256869975177d, y: 0.3742760856255749d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14404471918074824d, y: 0.47436203490815765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372802892465188d, y: 0.5790341376250215d), new NpgsqlTypes.NpgsqlPoint(x: 0.26752325727300064d, y: 0.6921588434159743d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7332477491965553d, y: 0.21816021140655817d), new NpgsqlTypes.NpgsqlPoint(x: 0.024607061978443423d, y: 0.2229576744206786d), new NpgsqlTypes.NpgsqlPoint(x: 0.028029490746602992d, y: 0.6761626709710139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5834729765255158d, y: 0.07457457781423538d), new NpgsqlTypes.NpgsqlPoint(x: 0.45186297571769196d, y: 0.8341529321480197d), new NpgsqlTypes.NpgsqlPoint(x: 0.01097778137443084d, y: 0.9136426919029893d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4298528980659011d, y: 0.7398705757189467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8553516748930418d, y: 0.00489941851831277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835423895607271d, y: 0.5939257713140635d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22087946238863454d, y: 0.8135454643239002d), new NpgsqlTypes.NpgsqlPoint(x: 0.18436343280197376d, y: 0.6946044645830699d), new NpgsqlTypes.NpgsqlPoint(x: 0.11482236061360518d, y: 0.02830553840537231d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06529777093865352d, y: 0.12321799637632513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3596828523114932d, y: 0.21768870393578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529112525077667d, y: 0.7807822631550586d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13126722115866796d, y: 0.18052859728914172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6416276172402801d, y: 0.05696372228437585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183714328814642d, y: 0.8083487864628675d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5704636291017421d, y: 0.09273759460582198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321603968761276d, y: 0.9008457677778225d), new NpgsqlTypes.NpgsqlPoint(x: 0.506228995392915d, y: 0.8122596615660278d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30996696888001307d, y: 0.5057321027849654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581442541678389d, y: 0.935195954686247d), new NpgsqlTypes.NpgsqlPoint(x: 0.1952080730007688d, y: 0.48953856854561817d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9818712744550926d, y: 0.01752989668634153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848546255351717d, y: 0.5215546929308864d), new NpgsqlTypes.NpgsqlPoint(x: 0.47650193355613646d, y: 0.6619013636791566d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795948777100559d, y: 0.24494200155820578d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077133840260434d, y: 0.22881326648400158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348649720435426d, y: 0.21061651521179958d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015106817113470394d, y: 0.5601265174095299d), new NpgsqlTypes.NpgsqlPoint(x: 0.15389667106253502d, y: 0.8599309410456887d), new NpgsqlTypes.NpgsqlPoint(x: 0.12516320325157304d, y: 0.6417095710189704d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955955180746293d, y: 0.27277156556587767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277869484259156d, y: 0.09346889446092022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314885779709513d, y: 0.16896813291908286d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8157266955277187d, y: 0.1731200617431321d), new NpgsqlTypes.NpgsqlPoint(x: 0.37467585258898384d, y: 0.5063471715380935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168028845129539d, y: 0.5244082868262159d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.816293771006589d, y: 0.33958686740679667d), new NpgsqlTypes.NpgsqlPoint(x: 0.45389864619657316d, y: 0.4648293096534951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22095478572872207d, y: 0.11048134796554443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8345675930729826d, y: 0.00463794554141761d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830722173581065d, y: 0.5784590296454428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249746597995814d, y: 0.16993552246413746d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7079916884065032d, y: 0.42253773860328236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327313463122954d, y: 0.49606208352224146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442215210196286d, y: 0.1012260841150503d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7090684131957181d, y: 0.36306071353794955d), new NpgsqlTypes.NpgsqlPoint(x: 0.040486258936714314d, y: 0.037629479500148943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322854262760464d, y: 0.8403608892777209d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10233637095250825d, y: 0.5773865282868157d), new NpgsqlTypes.NpgsqlPoint(x: 0.784794696612511d, y: 0.8724467554207029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266981639319041d, y: 0.36206916546089685d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7471512489527309d, y: 0.0579172301473625d), new NpgsqlTypes.NpgsqlPoint(x: 0.3060900617441812d, y: 0.18871504624590663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2219140740693979d, y: 0.12530337892708898d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5804151630670106d, y: 0.9068951283859988d), new NpgsqlTypes.NpgsqlPoint(x: 0.32116811492829334d, y: 0.968108396589616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101463146918835d, y: 0.9825355812079649d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4042838382610068d, y: 0.25662152811388117d), new NpgsqlTypes.NpgsqlPoint(x: 0.01277150430490881d, y: 0.3394433258736619d), new NpgsqlTypes.NpgsqlPoint(x: 0.37532088894096416d, y: 0.41160038208574923d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7389579996211187d, y: 0.4950005281397918d), new NpgsqlTypes.NpgsqlPoint(x: 0.743784796959358d, y: 0.8961297444751398d), new NpgsqlTypes.NpgsqlPoint(x: 0.44365396984514394d, y: 0.5256695456295177d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.707317693122359d, y: 0.3362247165783151d), new NpgsqlTypes.NpgsqlPoint(x: 0.29656658853125417d, y: 0.8433063982457278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624245501808477d, y: 0.7684478218872242d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03195417602878414d, y: 0.40496304594660437d), new NpgsqlTypes.NpgsqlPoint(x: 0.0294584721792297d, y: 0.31107360497960046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156680191056145d, y: 0.45465334718910855d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4150607174460438d, y: 0.3754370498938123d), new NpgsqlTypes.NpgsqlPoint(x: 0.032787392673755966d, y: 0.2498363537224303d), new NpgsqlTypes.NpgsqlPoint(x: 0.130908465633645d, y: 0.09871322328152321d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9184900292297807d, y: 0.9491097721504096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052294314663586d, y: 0.41087914588412666d), new NpgsqlTypes.NpgsqlPoint(x: 0.46440818788250193d, y: 0.5345950653752258d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8349552045470386d, y: 0.4446171522534863d), new NpgsqlTypes.NpgsqlPoint(x: 0.13839945147843813d, y: 0.1263926511394623d), new NpgsqlTypes.NpgsqlPoint(x: 0.05671754865657963d, y: 0.3110396189455803d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8439651666043734d, y: 0.34816213374702554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078414901443376d, y: 0.20409341812895043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455464065401048d, y: 0.02978659406824602d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.383585342072846d, y: 0.4228405024110967d), new NpgsqlTypes.NpgsqlPoint(x: 0.25636769165538575d, y: 0.7053556663398386d), new NpgsqlTypes.NpgsqlPoint(x: 0.0870301141977079d, y: 0.9280405285483967d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935558208261223d, y: 0.20041058836075443d), new NpgsqlTypes.NpgsqlPoint(x: 0.03765072207506559d, y: 0.8930723979630654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357861129945669d, y: 0.6000969750214317d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22506069850481147d, y: 0.49150114881824225d), new NpgsqlTypes.NpgsqlPoint(x: 0.49939303709515803d, y: 0.9865319933882033d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024685824799159928d, y: 0.06750048846082446d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5501877976709959d, y: 0.1468433545769312d), new NpgsqlTypes.NpgsqlPoint(x: 0.1892606198004213d, y: 0.4154255176341084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8978471094249116d, y: 0.49953383596270196d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4799573108884677d, y: 0.8884860742305016d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795405638110397d, y: 0.7781283539065161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423239748975533d, y: 0.7950305426648884d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8366498102909786d, y: 0.2335302461578712d), new NpgsqlTypes.NpgsqlPoint(x: 0.43959748090139383d, y: 0.4097452272581996d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372105773564155d, y: 0.8346929818829981d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111242609421687d, y: 0.510093960197078d), new NpgsqlTypes.NpgsqlPoint(x: 0.17925520628969793d, y: 0.7866835424465128d), new NpgsqlTypes.NpgsqlPoint(x: 0.05170615959083191d, y: 0.8030040652617272d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13607630043022878d, y: 0.882173175073912d), new NpgsqlTypes.NpgsqlPoint(x: 0.402661897295577d, y: 0.8462289472867176d), new NpgsqlTypes.NpgsqlPoint(x: 0.34492300418762d, y: 0.9892747340471079d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.638353892780443d, y: 0.35702609594759116d), new NpgsqlTypes.NpgsqlPoint(x: 0.39994045511349496d, y: 0.25641914146055245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591091679638d, y: 0.6578979138598158d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38834457103371356d, y: 0.1820054704948526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603255842431958d, y: 0.8539410769577284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2548810278388516d, y: 0.24278438952414438d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09010995594121873d, y: 0.5863869957604797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445847468765561d, y: 0.8339266288749169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052850410438102d, y: 0.8990287974205534d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1451045691392735d, y: 0.8838025851314385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156899766613699d, y: 0.4602208800707731d), new NpgsqlTypes.NpgsqlPoint(x: 0.24067362999070108d, y: 0.45745711337630623d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29787204504413933d, y: 0.4890925985370931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246856141832825d, y: 0.3938952725419774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2506667600986845d, y: 0.25741188306346463d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7228922977752664d, y: 0.580511099147524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272695338511236d, y: 0.5506592986317936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920865591947052d, y: 0.9642617006687588d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9292076361916687d, y: 0.8576598373576929d), new NpgsqlTypes.NpgsqlPoint(x: 0.11494344296047321d, y: 0.4449673656473099d), new NpgsqlTypes.NpgsqlPoint(x: 0.37414119266743706d, y: 0.5732952382591454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49963238275799016d, y: 0.10103126583729027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243660996529665d, y: 0.01742718538317467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584780183119012d, y: 0.1849180229892421d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6030234454419947d, y: 0.9299534764545696d), new NpgsqlTypes.NpgsqlPoint(x: 0.47196740270736137d, y: 0.29632300096448283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7260346861080426d, y: 0.9549156408007456d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6541856832092926d, y: 0.1330121751269293d), new NpgsqlTypes.NpgsqlPoint(x: 0.44980815942664554d, y: 0.5240075444080721d), new NpgsqlTypes.NpgsqlPoint(x: 0.23322507643545665d, y: 0.3718444692695584d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.699781282976509d, y: 0.06405848177656692d), new NpgsqlTypes.NpgsqlPoint(x: 0.12999442603789357d, y: 0.6169618685860371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499951649729227d, y: 0.8717984414195775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03695871549109098d, y: 0.1667909398484404d), new NpgsqlTypes.NpgsqlPoint(x: 0.026250432210321417d, y: 0.27430616114962525d), new NpgsqlTypes.NpgsqlPoint(x: 0.2627966916584519d, y: 0.6588104970438505d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6450139765151491d, y: 0.2692944106869932d), new NpgsqlTypes.NpgsqlPoint(x: 0.978318901908066d, y: 0.5445310123159199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475917392913801d, y: 0.11581658317750665d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5018328631311532d, y: 0.193138703938331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105186647381872d, y: 0.41357107843688523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768066063828452d, y: 0.9633429790728819d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20915304448944627d, y: 0.17220166229859812d), new NpgsqlTypes.NpgsqlPoint(x: 0.49181759301285277d, y: 0.9326229938270565d), new NpgsqlTypes.NpgsqlPoint(x: 0.2193575591924556d, y: 0.8889444248805942d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2827138615561291d, y: 0.10789557566189945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737627896326351d, y: 0.9021731677432845d), new NpgsqlTypes.NpgsqlPoint(x: 0.21977697840381472d, y: 0.09387892529773534d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9992563822756555d, y: 0.6144406477372559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4143380175124144d, y: 0.21295360486242776d), new NpgsqlTypes.NpgsqlPoint(x: 0.2712282261107767d, y: 0.3993959685396351d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9251159235154397d, y: 0.6542659578306143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2235516620039545d, y: 0.5402088720111018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577042099842002d, y: 0.562284576246444d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768912735092042d, y: 0.6170996880193937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7959855482592222d, y: 0.41195614226250743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418119232804508d, y: 0.7703333243972894d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1664195254805575d, y: 0.21963133739520535d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354573373918922d, y: 0.7301531442806569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955486616291073d, y: 0.6494369613864395d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9969299789846074d, y: 0.8386535792351129d), new NpgsqlTypes.NpgsqlPoint(x: 0.01705769215971964d, y: 0.11119160554746221d), new NpgsqlTypes.NpgsqlPoint(x: 0.19275389594416903d, y: 0.7450224011154774d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8056432886964929d, y: 0.3445551883525637d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689761875795442d, y: 0.9608702131747155d), new NpgsqlTypes.NpgsqlPoint(x: 0.806091782069586d, y: 0.6441382761869004d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8240769173241966d, y: 0.886475557608633d), new NpgsqlTypes.NpgsqlPoint(x: 0.44776079167900507d, y: 0.154292623438956d), new NpgsqlTypes.NpgsqlPoint(x: 0.17958781943899604d, y: 0.1183368978184729d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12248370540043474d, y: 0.6285745081259411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3884725924549114d, y: 0.5863936236015603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7598530116572526d, y: 0.4348528789021886d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10783669032538712d, y: 0.3938190142879635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5732160536780394d, y: 0.9397955551010231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888983341523654d, y: 0.3902070032160936d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5879285482186477d, y: 0.01719821581444614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567614774308056d, y: 0.8744803692308817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3451825655370969d, y: 0.6136360934355864d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050695276707874d, y: 0.9062782487467006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033635248746139d, y: 0.18617938691584424d), new NpgsqlTypes.NpgsqlPoint(x: 0.43002108673484973d, y: 0.9808862133304721d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874510295445018d, y: 0.4141130816505352d), new NpgsqlTypes.NpgsqlPoint(x: 0.3335509443604723d, y: 0.0722540378595462d), new NpgsqlTypes.NpgsqlPoint(x: 0.14337805321184216d, y: 0.7978877355272663d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01730343777622534d, y: 0.790214559054871d), new NpgsqlTypes.NpgsqlPoint(x: 0.043355247316348766d, y: 0.638854461687721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510954660089783d, y: 0.0869043934691921d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8338259434969422d, y: 0.29651788145370295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515557088318797d, y: 0.628117456381131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954101388341601d, y: 0.594152705382025d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7356888808834885d, y: 0.11432637139940871d), new NpgsqlTypes.NpgsqlPoint(x: 0.027984626983193817d, y: 0.883490582159101d), new NpgsqlTypes.NpgsqlPoint(x: 0.361659402018333d, y: 0.4331572438435676d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29403894694436084d, y: 0.40180368630182195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3178743285860576d, y: 0.153096327270428d), new NpgsqlTypes.NpgsqlPoint(x: 0.29610495940230075d, y: 0.7502401054021579d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24529670707441598d, y: 0.5980744408781963d), new NpgsqlTypes.NpgsqlPoint(x: 0.24681578366302714d, y: 0.6958176049960657d), new NpgsqlTypes.NpgsqlPoint(x: 0.824831479446027d, y: 0.2702433755490621d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9712095439884101d, y: 0.7760030160962612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507775861610031d, y: 0.873589814442291d), new NpgsqlTypes.NpgsqlPoint(x: 0.3149573665863755d, y: 0.034087251789882145d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4024729319373179d, y: 0.3938729038080405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848336393896177d, y: 0.3706811668541413d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139452643521159d, y: 0.5707174164214251d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6972559458329761d, y: 0.07303814858828772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570295474607084d, y: 0.4605588911159655d), new NpgsqlTypes.NpgsqlPoint(x: 0.24196444081972213d, y: 0.6950093510319219d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6364744071536126d, y: 0.5319769205981835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957937653160966d, y: 0.8951178539145205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438429011877418d, y: 0.3662801856949315d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044655152382003d, y: 0.3702759800629444d), new NpgsqlTypes.NpgsqlPoint(x: 0.16055610243757856d, y: 0.6158143042871252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296255812718079d, y: 0.37300285852948445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8322806603086708d, y: 0.1758642721790128d), new NpgsqlTypes.NpgsqlPoint(x: 0.11847150886337376d, y: 0.7140864613291475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978591860742507d, y: 0.5143438207517226d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7694758338669766d, y: 0.5279019192949403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646270751180059d, y: 0.7936588475326557d), new NpgsqlTypes.NpgsqlPoint(x: 0.31614668658964584d, y: 0.3455009814490083d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8406339268096104d, y: 0.5101954552503477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608618186166973d, y: 0.9813890507995479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495046391299781d, y: 0.17927112087828034d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09308033790946324d, y: 0.7175217469120756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460356247955683d, y: 0.8994653908675424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301256869975177d, y: 0.3742760856255749d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14404471918074824d, y: 0.47436203490815765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372802892465188d, y: 0.5790341376250215d), new NpgsqlTypes.NpgsqlPoint(x: 0.26752325727300064d, y: 0.6921588434159743d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7332477491965553d, y: 0.21816021140655817d), new NpgsqlTypes.NpgsqlPoint(x: 0.024607061978443423d, y: 0.2229576744206786d), new NpgsqlTypes.NpgsqlPoint(x: 0.028029490746602992d, y: 0.6761626709710139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5834729765255158d, y: 0.07457457781423538d), new NpgsqlTypes.NpgsqlPoint(x: 0.45186297571769196d, y: 0.8341529321480197d), new NpgsqlTypes.NpgsqlPoint(x: 0.01097778137443084d, y: 0.9136426919029893d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4298528980659011d, y: 0.7398705757189467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8553516748930418d, y: 0.00489941851831277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835423895607271d, y: 0.5939257713140635d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22087946238863454d, y: 0.8135454643239002d), new NpgsqlTypes.NpgsqlPoint(x: 0.18436343280197376d, y: 0.6946044645830699d), new NpgsqlTypes.NpgsqlPoint(x: 0.11482236061360518d, y: 0.02830553840537231d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06529777093865352d, y: 0.12321799637632513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3596828523114932d, y: 0.21768870393578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529112525077667d, y: 0.7807822631550586d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13126722115866796d, y: 0.18052859728914172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6416276172402801d, y: 0.05696372228437585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183714328814642d, y: 0.8083487864628675d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5704636291017421d, y: 0.09273759460582198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321603968761276d, y: 0.9008457677778225d), new NpgsqlTypes.NpgsqlPoint(x: 0.506228995392915d, y: 0.8122596615660278d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30996696888001307d, y: 0.5057321027849654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581442541678389d, y: 0.935195954686247d), new NpgsqlTypes.NpgsqlPoint(x: 0.1952080730007688d, y: 0.48953856854561817d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9818712744550926d, y: 0.01752989668634153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848546255351717d, y: 0.5215546929308864d), new NpgsqlTypes.NpgsqlPoint(x: 0.47650193355613646d, y: 0.6619013636791566d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpath0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI), typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

