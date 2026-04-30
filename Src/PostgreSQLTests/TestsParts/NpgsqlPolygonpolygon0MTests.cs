

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

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18473662506508515d, y: 0.4148617550024529d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223789169666855d, y: 0.5610355263236328d), new NpgsqlTypes.NpgsqlPoint(x: 0.2139421133864685d, y: 0.7281218589750279d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8354965912650418d, y: 0.35497601279635027d), new NpgsqlTypes.NpgsqlPoint(x: 0.0907836930258138d, y: 0.5747090921907724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261314004221476d, y: 0.07088232076996015d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41825154972036704d, y: 0.6803710577109584d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836333866673876d, y: 0.049172329158510775d), new NpgsqlTypes.NpgsqlPoint(x: 0.11455308912040463d, y: 0.4240082318897167d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3373756968630456d, y: 0.5808567752537157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621793105810856d, y: 0.8906115433090275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924147607676062d, y: 0.23678957400897094d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777121264886394d, y: 0.6892594417017501d), new NpgsqlTypes.NpgsqlPoint(x: 0.321404451601901d, y: 0.5353267269441643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5863565325646627d, y: 0.030826069349227492d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3249834692567737d, y: 0.5370929819349121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985917405213136d, y: 0.5213470982527094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613734533106232d, y: 0.3072208513003768d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28215960238201254d, y: 0.34480197912339894d), new NpgsqlTypes.NpgsqlPoint(x: 0.49041654005355784d, y: 0.8531241455008203d), new NpgsqlTypes.NpgsqlPoint(x: 0.884626641750669d, y: 0.9444404095522723d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6249634448522666d, y: 0.8823548786994062d), new NpgsqlTypes.NpgsqlPoint(x: 0.527374590585868d, y: 0.5911347595033212d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193227139115282d, y: 0.5045128488977028d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5415957106876592d, y: 0.907965752765549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511784901272139d, y: 0.06299239848972571d), new NpgsqlTypes.NpgsqlPoint(x: 0.13363857813681113d, y: 0.29970524114376385d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.755280361799853d, y: 0.9619823109630028d), new NpgsqlTypes.NpgsqlPoint(x: 0.6609486170848825d, y: 0.46969806344011056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288427390311909d, y: 0.5422001757384292d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429705417658978d, y: 0.24195896200462497d), new NpgsqlTypes.NpgsqlPoint(x: 0.967813791336795d, y: 0.2043620953403964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716661302908662d, y: 0.2547164756353001d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33108971174998914d, y: 0.34208031745983536d), new NpgsqlTypes.NpgsqlPoint(x: 0.324152437723759d, y: 0.5389607036321649d), new NpgsqlTypes.NpgsqlPoint(x: 0.47171781934382717d, y: 0.09376879921763104d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42740161688571454d, y: 0.4879908824173702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6713344183334071d, y: 0.5515515750995461d), new NpgsqlTypes.NpgsqlPoint(x: 0.48311671209958273d, y: 0.5317101825200844d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5569981921843389d, y: 0.9169878959157629d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943624621633154d, y: 0.5373705264911156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133559780203558d, y: 0.9811350019589834d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40785007433172293d, y: 0.543331250216297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235545849017892d, y: 0.03646746392217037d), new NpgsqlTypes.NpgsqlPoint(x: 0.13406410768178756d, y: 0.19370517633804463d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3138150084258722d, y: 0.45363560106549494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765066918490713d, y: 0.2762370823251017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973391210630526d, y: 0.9367597390813571d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2309409652618597d, y: 0.05519280928007131d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656398178352908d, y: 0.10098160058514338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3272983852474344d, y: 0.055191986114096814d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.620127329028452d, y: 0.4457481442149722d), new NpgsqlTypes.NpgsqlPoint(x: 0.06453183170834154d, y: 0.5721172551916289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532183142349643d, y: 0.765512208172768d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2823768752425072d, y: 0.33802135545123213d), new NpgsqlTypes.NpgsqlPoint(x: 0.31986962751606873d, y: 0.1360857590381822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459039445754183d, y: 0.5807208318724218d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14504316136937212d, y: 0.002754210245166422d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023292177222928867d, y: 0.8828059693588125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514622073374893d, y: 0.32991030961184376d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7900334127904518d, y: 0.5943624706913866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307457789354294d, y: 0.25625870590114097d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154218866313124d, y: 0.32761076813288925d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40321919166766784d, y: 0.986268453518327d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586935915371972d, y: 0.263110186530535d), new NpgsqlTypes.NpgsqlPoint(x: 0.07114619654345611d, y: 0.8316375150368727d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4309844169700042d, y: 0.5714532548325327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799600635119684d, y: 0.8671027765236091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7202983262576662d, y: 0.6549708680290119d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7911938302072671d, y: 0.517668526362711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2800855583433908d, y: 0.33819235756573784d), new NpgsqlTypes.NpgsqlPoint(x: 0.24981247629005654d, y: 0.40342751486846995d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16498387878305787d, y: 0.9063920999083611d), new NpgsqlTypes.NpgsqlPoint(x: 0.38728435163886743d, y: 0.734849763449027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788364695273788d, y: 0.12053835242410027d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8615488806322402d, y: 0.15115000653386512d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049068955341744d, y: 0.6034405747782695d), new NpgsqlTypes.NpgsqlPoint(x: 0.03482264941028557d, y: 0.08742676254829329d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9393287457003398d, y: 0.3138280474849654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661891835327607d, y: 0.554276225235058d), new NpgsqlTypes.NpgsqlPoint(x: 0.0707928721701182d, y: 0.41664218973208056d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8291006348615041d, y: 0.7989077219765127d), new NpgsqlTypes.NpgsqlPoint(x: 0.38983815123793264d, y: 0.08390968772752994d), new NpgsqlTypes.NpgsqlPoint(x: 0.16588546505849977d, y: 0.7756437817720483d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014436888472451725d, y: 0.7217400794189235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289787196535855d, y: 0.07293689236857759d), new NpgsqlTypes.NpgsqlPoint(x: 0.30078049490295955d, y: 0.5313277546283636d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1680577126222249d, y: 0.07318483996690128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912234231610775d, y: 0.8476420063781156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335894623551933d, y: 0.9221438711334768d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.794512987807886d, y: 0.8681596666475062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723163926602815d, y: 0.09059144903486738d), new NpgsqlTypes.NpgsqlPoint(x: 0.637251872016966d, y: 0.8913432691424532d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7944152027972337d, y: 0.32642560626882455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598193270152092d, y: 0.6918528571920829d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156920727922409d, y: 0.16126664431671478d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3731226347141514d, y: 0.715206235492849d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823826009365735d, y: 0.9950386331893121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481169009266872d, y: 0.7830345542446728d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9489104202817904d, y: 0.9122792598695265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342460677699345d, y: 0.8044080245149595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779700548622609d, y: 0.2342921639677753d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7715774270107741d, y: 0.3458567539511921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609448243253771d, y: 0.051753407433434595d), new NpgsqlTypes.NpgsqlPoint(x: 0.036832628956258384d, y: 0.46270061954292563d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6856328288949952d, y: 0.3205750102228234d), new NpgsqlTypes.NpgsqlPoint(x: 0.06759985454314488d, y: 0.7140960689290369d), new NpgsqlTypes.NpgsqlPoint(x: 0.591338242692177d, y: 0.5582093040945685d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4669189587082129d, y: 0.21646641896649654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423749202845978d, y: 0.7956728907948499d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223277116686145d, y: 0.5808667651285432d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3859799751029178d, y: 0.6258757863762641d), new NpgsqlTypes.NpgsqlPoint(x: 0.2272391426672603d, y: 0.10466129641216526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351321657779136d, y: 0.11879295148302804d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8572466491898106d, y: 0.47994955200828304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910835311124947d, y: 0.3031740881608809d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432253877532196d, y: 0.06805514154381209d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32575205404641194d, y: 0.13972909535687628d), new NpgsqlTypes.NpgsqlPoint(x: 0.11008334571911771d, y: 0.7898345994739175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3692201102729d, y: 0.9958058722693484d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8634232233410115d, y: 0.802920346399044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4261567294828942d, y: 0.17143031140103926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601078075791203d, y: 0.002653917639675374d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7723878487464221d, y: 0.29007972571168683d), new NpgsqlTypes.NpgsqlPoint(x: 0.25445020188587153d, y: 0.8223213691916513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872369171740966d, y: 0.875234545769655d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7154551020270971d, y: 0.7978520353323864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806810487675864d, y: 0.09337529509111031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7687018454990302d, y: 0.926351623638184d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9696703796497955d, y: 0.5809061220158397d), new NpgsqlTypes.NpgsqlPoint(x: 0.26456398620153077d, y: 0.6130676750418591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060343283383488d, y: 0.25507822469657404d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7100672763339165d, y: 0.9145588220338658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919021105214636d, y: 0.27913648705991356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9373230247748782d, y: 0.9962624308784981d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5469908841579809d, y: 0.6100490686877992d), new NpgsqlTypes.NpgsqlPoint(x: 0.13817827042434716d, y: 0.8246216602395195d), new NpgsqlTypes.NpgsqlPoint(x: 0.24893794902254107d, y: 0.5706902295532892d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35147443067869d, y: 0.6917172506767573d), new NpgsqlTypes.NpgsqlPoint(x: 0.40168993862527114d, y: 0.20292635837143824d), new NpgsqlTypes.NpgsqlPoint(x: 0.3070446524269831d, y: 0.30695374706551815d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6246070421820245d, y: 0.27738358487697357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291925204547551d, y: 0.6751117185756762d), new NpgsqlTypes.NpgsqlPoint(x: 0.642313767896222d, y: 0.52145551159169d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7218712621657553d, y: 0.3049935677404644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068979056329064d, y: 0.7739926995784175d), new NpgsqlTypes.NpgsqlPoint(x: 0.40740905867251087d, y: 0.03091468349470794d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8520769624290769d, y: 0.7550152880875061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180321422153049d, y: 0.9780577026451455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900647055309943d, y: 0.587173304706527d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8545085257709044d, y: 0.730923471804578d), new NpgsqlTypes.NpgsqlPoint(x: 0.49995702493804717d, y: 0.4029348390635613d), new NpgsqlTypes.NpgsqlPoint(x: 0.9173661594508257d, y: 0.9796265960987238d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45256779815950454d, y: 0.9025777983770743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249542775199389d, y: 0.32605307470304234d), new NpgsqlTypes.NpgsqlPoint(x: 0.16108774718443564d, y: 0.224322790679376d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21667464106822676d, y: 0.4517426593150279d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388934267280471d, y: 0.5994753480793891d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953147693535274d, y: 0.2722800504668236d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3838996885497642d, y: 0.11479484047978639d), new NpgsqlTypes.NpgsqlPoint(x: 0.25430741874165785d, y: 0.9034936601627813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9805886945356256d, y: 0.7651998011718463d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7970566233400513d, y: 0.10308546565971666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535849415677517d, y: 0.25758279582288446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410988357933618d, y: 0.7701086932824222d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7638179879300864d, y: 0.5734694578272838d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358625075976704d, y: 0.9262806710601715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004179804499621d, y: 0.8360013692307743d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9715681515693572d, y: 0.29850797501945847d), new NpgsqlTypes.NpgsqlPoint(x: 0.391276762670247d, y: 0.19782500849955165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5653200204674094d, y: 0.24455412012962763d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8647761586674706d, y: 0.9099704900088627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899467898411446d, y: 0.4378138408410194d), new NpgsqlTypes.NpgsqlPoint(x: 0.04405930953199422d, y: 0.4013979316336188d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6259314060970647d, y: 0.17174616664505127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627054753340718d, y: 0.540005284185763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356920973854038d, y: 0.6881543986123719d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7379307937208429d, y: 0.06328796898336275d), new NpgsqlTypes.NpgsqlPoint(x: 0.07013738173086015d, y: 0.5933024944768732d), new NpgsqlTypes.NpgsqlPoint(x: 0.14512585169249992d, y: 0.4586700099252433d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16072753281425745d, y: 0.9683996583390078d), new NpgsqlTypes.NpgsqlPoint(x: 0.12929927717610668d, y: 0.016469747042876404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4476243548751849d, y: 0.22527970095741268d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4609560717743897d, y: 0.9115762995448772d), new NpgsqlTypes.NpgsqlPoint(x: 0.20476053476192857d, y: 0.34528868048600425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972496079765548d, y: 0.1575062244833063d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6223625589969617d, y: 0.09636690771960899d), new NpgsqlTypes.NpgsqlPoint(x: 0.29050275357473565d, y: 0.2663167899390335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3141083924131979d, y: 0.448592704560417d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2694705585516938d, y: 0.023447402578332555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160963606128885d, y: 0.7320215616222978d), new NpgsqlTypes.NpgsqlPoint(x: 0.21576465232103348d, y: 0.08442252194096767d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4456709814955764d, y: 0.6174296677224647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602900538945803d, y: 0.2606760041623143d), new NpgsqlTypes.NpgsqlPoint(x: 0.02819410573235903d, y: 0.02604367563457577d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44224986509039277d, y: 0.8488001002382889d), new NpgsqlTypes.NpgsqlPoint(x: 0.1357936491770989d, y: 0.7935417658383505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8771775262477014d, y: 0.3756326087768831d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4651586891505437d, y: 0.46814315155843766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114571896233845d, y: 0.7455535226953448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302712555304145d, y: 0.12342325157500311d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7805793214892001d, y: 0.4999004347292404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068735595221047d, y: 0.8343583500334516d), new NpgsqlTypes.NpgsqlPoint(x: 0.12945014410729283d, y: 0.3925996295311487d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9528053812209135d, y: 0.9695724532741754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6765687649641561d, y: 0.4682911762182155d), new NpgsqlTypes.NpgsqlPoint(x: 0.04692795681885875d, y: 0.2013248869260339d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915241053827162d, y: 0.07903664088278828d), new NpgsqlTypes.NpgsqlPoint(x: 0.19640252072701636d, y: 0.06505335501704668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989756628067309d, y: 0.42173238883847763d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9521945544230911d, y: 0.6723892457856112d), new NpgsqlTypes.NpgsqlPoint(x: 0.3322675263857431d, y: 0.8147654873579075d), new NpgsqlTypes.NpgsqlPoint(x: 0.16360864206414816d, y: 0.5415132783923381d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2153357611665695d, y: 0.6670241178613816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461560608398807d, y: 0.6486641738376444d), new NpgsqlTypes.NpgsqlPoint(x: 0.31563971464347995d, y: 0.36254764914610027d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.823678992099491d, y: 0.0382927212294456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961798128077631d, y: 0.9125561385662871d), new NpgsqlTypes.NpgsqlPoint(x: 0.44432672106107896d, y: 0.5646979688685714d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8380539838836585d, y: 0.9134321654715462d), new NpgsqlTypes.NpgsqlPoint(x: 0.07515295456129045d, y: 0.8265095470974496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261167038834699d, y: 0.4232438969962333d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4858321341374089d, y: 0.5660330931391971d), new NpgsqlTypes.NpgsqlPoint(x: 0.05468406710017115d, y: 0.15617510488970043d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581462934180434d, y: 0.4218241292032687d)),
    ModelInner = null,
    NullableValue = null,
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
INSERT INTO public.npgsqlpolygonpolygon0m(
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
INSERT INTO public.npgsqlpolygonpolygon0m(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429705417658978d, y: 0.24195896200462497d), new NpgsqlTypes.NpgsqlPoint(x: 0.967813791336795d, y: 0.2043620953403964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716661302908662d, y: 0.2547164756353001d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40785007433172293d, y: 0.543331250216297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235545849017892d, y: 0.03646746392217037d), new NpgsqlTypes.NpgsqlPoint(x: 0.13406410768178756d, y: 0.19370517633804463d))));
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
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14504316136937212d, y: 0.002754210245166422d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023292177222928867d, y: 0.8828059693588125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514622073374893d, y: 0.32991030961184376d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4309844169700042d, y: 0.5714532548325327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799600635119684d, y: 0.8671027765236091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7202983262576662d, y: 0.6549708680290119d))));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9393287457003398d, y: 0.3138280474849654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661891835327607d, y: 0.554276225235058d), new NpgsqlTypes.NpgsqlPoint(x: 0.0707928721701182d, y: 0.41664218973208056d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
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
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 118;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 145;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 121;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[33],_testData[34], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 120, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 74, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 4, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 129, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[34], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 70, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18473662506508515d, y: 0.4148617550024529d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223789169666855d, y: 0.5610355263236328d), new NpgsqlTypes.NpgsqlPoint(x: 0.2139421133864685d, y: 0.7281218589750279d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8354965912650418d, y: 0.35497601279635027d), new NpgsqlTypes.NpgsqlPoint(x: 0.0907836930258138d, y: 0.5747090921907724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261314004221476d, y: 0.07088232076996015d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41825154972036704d, y: 0.6803710577109584d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836333866673876d, y: 0.049172329158510775d), new NpgsqlTypes.NpgsqlPoint(x: 0.11455308912040463d, y: 0.4240082318897167d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3373756968630456d, y: 0.5808567752537157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621793105810856d, y: 0.8906115433090275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924147607676062d, y: 0.23678957400897094d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777121264886394d, y: 0.6892594417017501d), new NpgsqlTypes.NpgsqlPoint(x: 0.321404451601901d, y: 0.5353267269441643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5863565325646627d, y: 0.030826069349227492d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3249834692567737d, y: 0.5370929819349121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985917405213136d, y: 0.5213470982527094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613734533106232d, y: 0.3072208513003768d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28215960238201254d, y: 0.34480197912339894d), new NpgsqlTypes.NpgsqlPoint(x: 0.49041654005355784d, y: 0.8531241455008203d), new NpgsqlTypes.NpgsqlPoint(x: 0.884626641750669d, y: 0.9444404095522723d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6249634448522666d, y: 0.8823548786994062d), new NpgsqlTypes.NpgsqlPoint(x: 0.527374590585868d, y: 0.5911347595033212d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193227139115282d, y: 0.5045128488977028d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5415957106876592d, y: 0.907965752765549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511784901272139d, y: 0.06299239848972571d), new NpgsqlTypes.NpgsqlPoint(x: 0.13363857813681113d, y: 0.29970524114376385d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.755280361799853d, y: 0.9619823109630028d), new NpgsqlTypes.NpgsqlPoint(x: 0.6609486170848825d, y: 0.46969806344011056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288427390311909d, y: 0.5422001757384292d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429705417658978d, y: 0.24195896200462497d), new NpgsqlTypes.NpgsqlPoint(x: 0.967813791336795d, y: 0.2043620953403964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716661302908662d, y: 0.2547164756353001d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33108971174998914d, y: 0.34208031745983536d), new NpgsqlTypes.NpgsqlPoint(x: 0.324152437723759d, y: 0.5389607036321649d), new NpgsqlTypes.NpgsqlPoint(x: 0.47171781934382717d, y: 0.09376879921763104d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42740161688571454d, y: 0.4879908824173702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6713344183334071d, y: 0.5515515750995461d), new NpgsqlTypes.NpgsqlPoint(x: 0.48311671209958273d, y: 0.5317101825200844d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5569981921843389d, y: 0.9169878959157629d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943624621633154d, y: 0.5373705264911156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133559780203558d, y: 0.9811350019589834d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40785007433172293d, y: 0.543331250216297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235545849017892d, y: 0.03646746392217037d), new NpgsqlTypes.NpgsqlPoint(x: 0.13406410768178756d, y: 0.19370517633804463d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3138150084258722d, y: 0.45363560106549494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765066918490713d, y: 0.2762370823251017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973391210630526d, y: 0.9367597390813571d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2309409652618597d, y: 0.05519280928007131d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656398178352908d, y: 0.10098160058514338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3272983852474344d, y: 0.055191986114096814d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.620127329028452d, y: 0.4457481442149722d), new NpgsqlTypes.NpgsqlPoint(x: 0.06453183170834154d, y: 0.5721172551916289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532183142349643d, y: 0.765512208172768d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2823768752425072d, y: 0.33802135545123213d), new NpgsqlTypes.NpgsqlPoint(x: 0.31986962751606873d, y: 0.1360857590381822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459039445754183d, y: 0.5807208318724218d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14504316136937212d, y: 0.002754210245166422d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023292177222928867d, y: 0.8828059693588125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514622073374893d, y: 0.32991030961184376d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7900334127904518d, y: 0.5943624706913866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307457789354294d, y: 0.25625870590114097d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154218866313124d, y: 0.32761076813288925d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40321919166766784d, y: 0.986268453518327d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586935915371972d, y: 0.263110186530535d), new NpgsqlTypes.NpgsqlPoint(x: 0.07114619654345611d, y: 0.8316375150368727d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4309844169700042d, y: 0.5714532548325327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799600635119684d, y: 0.8671027765236091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7202983262576662d, y: 0.6549708680290119d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7911938302072671d, y: 0.517668526362711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2800855583433908d, y: 0.33819235756573784d), new NpgsqlTypes.NpgsqlPoint(x: 0.24981247629005654d, y: 0.40342751486846995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16498387878305787d, y: 0.9063920999083611d), new NpgsqlTypes.NpgsqlPoint(x: 0.38728435163886743d, y: 0.734849763449027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788364695273788d, y: 0.12053835242410027d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8615488806322402d, y: 0.15115000653386512d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049068955341744d, y: 0.6034405747782695d), new NpgsqlTypes.NpgsqlPoint(x: 0.03482264941028557d, y: 0.08742676254829329d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9393287457003398d, y: 0.3138280474849654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661891835327607d, y: 0.554276225235058d), new NpgsqlTypes.NpgsqlPoint(x: 0.0707928721701182d, y: 0.41664218973208056d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8291006348615041d, y: 0.7989077219765127d), new NpgsqlTypes.NpgsqlPoint(x: 0.38983815123793264d, y: 0.08390968772752994d), new NpgsqlTypes.NpgsqlPoint(x: 0.16588546505849977d, y: 0.7756437817720483d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014436888472451725d, y: 0.7217400794189235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289787196535855d, y: 0.07293689236857759d), new NpgsqlTypes.NpgsqlPoint(x: 0.30078049490295955d, y: 0.5313277546283636d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1680577126222249d, y: 0.07318483996690128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912234231610775d, y: 0.8476420063781156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335894623551933d, y: 0.9221438711334768d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.794512987807886d, y: 0.8681596666475062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723163926602815d, y: 0.09059144903486738d), new NpgsqlTypes.NpgsqlPoint(x: 0.637251872016966d, y: 0.8913432691424532d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7944152027972337d, y: 0.32642560626882455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598193270152092d, y: 0.6918528571920829d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156920727922409d, y: 0.16126664431671478d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3731226347141514d, y: 0.715206235492849d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823826009365735d, y: 0.9950386331893121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481169009266872d, y: 0.7830345542446728d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9489104202817904d, y: 0.9122792598695265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342460677699345d, y: 0.8044080245149595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779700548622609d, y: 0.2342921639677753d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7715774270107741d, y: 0.3458567539511921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609448243253771d, y: 0.051753407433434595d), new NpgsqlTypes.NpgsqlPoint(x: 0.036832628956258384d, y: 0.46270061954292563d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6856328288949952d, y: 0.3205750102228234d), new NpgsqlTypes.NpgsqlPoint(x: 0.06759985454314488d, y: 0.7140960689290369d), new NpgsqlTypes.NpgsqlPoint(x: 0.591338242692177d, y: 0.5582093040945685d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4669189587082129d, y: 0.21646641896649654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423749202845978d, y: 0.7956728907948499d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223277116686145d, y: 0.5808667651285432d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3859799751029178d, y: 0.6258757863762641d), new NpgsqlTypes.NpgsqlPoint(x: 0.2272391426672603d, y: 0.10466129641216526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351321657779136d, y: 0.11879295148302804d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8572466491898106d, y: 0.47994955200828304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910835311124947d, y: 0.3031740881608809d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432253877532196d, y: 0.06805514154381209d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32575205404641194d, y: 0.13972909535687628d), new NpgsqlTypes.NpgsqlPoint(x: 0.11008334571911771d, y: 0.7898345994739175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3692201102729d, y: 0.9958058722693484d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8634232233410115d, y: 0.802920346399044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4261567294828942d, y: 0.17143031140103926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601078075791203d, y: 0.002653917639675374d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7723878487464221d, y: 0.29007972571168683d), new NpgsqlTypes.NpgsqlPoint(x: 0.25445020188587153d, y: 0.8223213691916513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872369171740966d, y: 0.875234545769655d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7154551020270971d, y: 0.7978520353323864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806810487675864d, y: 0.09337529509111031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7687018454990302d, y: 0.926351623638184d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9696703796497955d, y: 0.5809061220158397d), new NpgsqlTypes.NpgsqlPoint(x: 0.26456398620153077d, y: 0.6130676750418591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060343283383488d, y: 0.25507822469657404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7100672763339165d, y: 0.9145588220338658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919021105214636d, y: 0.27913648705991356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9373230247748782d, y: 0.9962624308784981d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5469908841579809d, y: 0.6100490686877992d), new NpgsqlTypes.NpgsqlPoint(x: 0.13817827042434716d, y: 0.8246216602395195d), new NpgsqlTypes.NpgsqlPoint(x: 0.24893794902254107d, y: 0.5706902295532892d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35147443067869d, y: 0.6917172506767573d), new NpgsqlTypes.NpgsqlPoint(x: 0.40168993862527114d, y: 0.20292635837143824d), new NpgsqlTypes.NpgsqlPoint(x: 0.3070446524269831d, y: 0.30695374706551815d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6246070421820245d, y: 0.27738358487697357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291925204547551d, y: 0.6751117185756762d), new NpgsqlTypes.NpgsqlPoint(x: 0.642313767896222d, y: 0.52145551159169d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7218712621657553d, y: 0.3049935677404644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068979056329064d, y: 0.7739926995784175d), new NpgsqlTypes.NpgsqlPoint(x: 0.40740905867251087d, y: 0.03091468349470794d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8520769624290769d, y: 0.7550152880875061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180321422153049d, y: 0.9780577026451455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900647055309943d, y: 0.587173304706527d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8545085257709044d, y: 0.730923471804578d), new NpgsqlTypes.NpgsqlPoint(x: 0.49995702493804717d, y: 0.4029348390635613d), new NpgsqlTypes.NpgsqlPoint(x: 0.9173661594508257d, y: 0.9796265960987238d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45256779815950454d, y: 0.9025777983770743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249542775199389d, y: 0.32605307470304234d), new NpgsqlTypes.NpgsqlPoint(x: 0.16108774718443564d, y: 0.224322790679376d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21667464106822676d, y: 0.4517426593150279d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388934267280471d, y: 0.5994753480793891d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953147693535274d, y: 0.2722800504668236d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3838996885497642d, y: 0.11479484047978639d), new NpgsqlTypes.NpgsqlPoint(x: 0.25430741874165785d, y: 0.9034936601627813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9805886945356256d, y: 0.7651998011718463d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7970566233400513d, y: 0.10308546565971666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535849415677517d, y: 0.25758279582288446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410988357933618d, y: 0.7701086932824222d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7638179879300864d, y: 0.5734694578272838d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358625075976704d, y: 0.9262806710601715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004179804499621d, y: 0.8360013692307743d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9715681515693572d, y: 0.29850797501945847d), new NpgsqlTypes.NpgsqlPoint(x: 0.391276762670247d, y: 0.19782500849955165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5653200204674094d, y: 0.24455412012962763d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8647761586674706d, y: 0.9099704900088627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899467898411446d, y: 0.4378138408410194d), new NpgsqlTypes.NpgsqlPoint(x: 0.04405930953199422d, y: 0.4013979316336188d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6259314060970647d, y: 0.17174616664505127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627054753340718d, y: 0.540005284185763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356920973854038d, y: 0.6881543986123719d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7379307937208429d, y: 0.06328796898336275d), new NpgsqlTypes.NpgsqlPoint(x: 0.07013738173086015d, y: 0.5933024944768732d), new NpgsqlTypes.NpgsqlPoint(x: 0.14512585169249992d, y: 0.4586700099252433d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16072753281425745d, y: 0.9683996583390078d), new NpgsqlTypes.NpgsqlPoint(x: 0.12929927717610668d, y: 0.016469747042876404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4476243548751849d, y: 0.22527970095741268d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4609560717743897d, y: 0.9115762995448772d), new NpgsqlTypes.NpgsqlPoint(x: 0.20476053476192857d, y: 0.34528868048600425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972496079765548d, y: 0.1575062244833063d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6223625589969617d, y: 0.09636690771960899d), new NpgsqlTypes.NpgsqlPoint(x: 0.29050275357473565d, y: 0.2663167899390335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3141083924131979d, y: 0.448592704560417d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2694705585516938d, y: 0.023447402578332555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160963606128885d, y: 0.7320215616222978d), new NpgsqlTypes.NpgsqlPoint(x: 0.21576465232103348d, y: 0.08442252194096767d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4456709814955764d, y: 0.6174296677224647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602900538945803d, y: 0.2606760041623143d), new NpgsqlTypes.NpgsqlPoint(x: 0.02819410573235903d, y: 0.02604367563457577d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44224986509039277d, y: 0.8488001002382889d), new NpgsqlTypes.NpgsqlPoint(x: 0.1357936491770989d, y: 0.7935417658383505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8771775262477014d, y: 0.3756326087768831d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4651586891505437d, y: 0.46814315155843766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114571896233845d, y: 0.7455535226953448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302712555304145d, y: 0.12342325157500311d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7805793214892001d, y: 0.4999004347292404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068735595221047d, y: 0.8343583500334516d), new NpgsqlTypes.NpgsqlPoint(x: 0.12945014410729283d, y: 0.3925996295311487d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((106)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9528053812209135d, y: 0.9695724532741754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6765687649641561d, y: 0.4682911762182155d), new NpgsqlTypes.NpgsqlPoint(x: 0.04692795681885875d, y: 0.2013248869260339d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915241053827162d, y: 0.07903664088278828d), new NpgsqlTypes.NpgsqlPoint(x: 0.19640252072701636d, y: 0.06505335501704668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989756628067309d, y: 0.42173238883847763d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9521945544230911d, y: 0.6723892457856112d), new NpgsqlTypes.NpgsqlPoint(x: 0.3322675263857431d, y: 0.8147654873579075d), new NpgsqlTypes.NpgsqlPoint(x: 0.16360864206414816d, y: 0.5415132783923381d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2153357611665695d, y: 0.6670241178613816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461560608398807d, y: 0.6486641738376444d), new NpgsqlTypes.NpgsqlPoint(x: 0.31563971464347995d, y: 0.36254764914610027d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.823678992099491d, y: 0.0382927212294456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961798128077631d, y: 0.9125561385662871d), new NpgsqlTypes.NpgsqlPoint(x: 0.44432672106107896d, y: 0.5646979688685714d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((115)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8380539838836585d, y: 0.9134321654715462d), new NpgsqlTypes.NpgsqlPoint(x: 0.07515295456129045d, y: 0.8265095470974496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261167038834699d, y: 0.4232438969962333d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4858321341374089d, y: 0.5660330931391971d), new NpgsqlTypes.NpgsqlPoint(x: 0.05468406710017115d, y: 0.15617510488970043d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581462934180434d, y: 0.4218241292032687d)))));//Value

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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18473662506508515d, y: 0.4148617550024529d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223789169666855d, y: 0.5610355263236328d), new NpgsqlTypes.NpgsqlPoint(x: 0.2139421133864685d, y: 0.7281218589750279d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8354965912650418d, y: 0.35497601279635027d), new NpgsqlTypes.NpgsqlPoint(x: 0.0907836930258138d, y: 0.5747090921907724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261314004221476d, y: 0.07088232076996015d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41825154972036704d, y: 0.6803710577109584d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836333866673876d, y: 0.049172329158510775d), new NpgsqlTypes.NpgsqlPoint(x: 0.11455308912040463d, y: 0.4240082318897167d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3373756968630456d, y: 0.5808567752537157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621793105810856d, y: 0.8906115433090275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924147607676062d, y: 0.23678957400897094d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.777121264886394d, y: 0.6892594417017501d), new NpgsqlTypes.NpgsqlPoint(x: 0.321404451601901d, y: 0.5353267269441643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5863565325646627d, y: 0.030826069349227492d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3249834692567737d, y: 0.5370929819349121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985917405213136d, y: 0.5213470982527094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613734533106232d, y: 0.3072208513003768d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28215960238201254d, y: 0.34480197912339894d), new NpgsqlTypes.NpgsqlPoint(x: 0.49041654005355784d, y: 0.8531241455008203d), new NpgsqlTypes.NpgsqlPoint(x: 0.884626641750669d, y: 0.9444404095522723d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6249634448522666d, y: 0.8823548786994062d), new NpgsqlTypes.NpgsqlPoint(x: 0.527374590585868d, y: 0.5911347595033212d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193227139115282d, y: 0.5045128488977028d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5415957106876592d, y: 0.907965752765549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511784901272139d, y: 0.06299239848972571d), new NpgsqlTypes.NpgsqlPoint(x: 0.13363857813681113d, y: 0.29970524114376385d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.755280361799853d, y: 0.9619823109630028d), new NpgsqlTypes.NpgsqlPoint(x: 0.6609486170848825d, y: 0.46969806344011056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288427390311909d, y: 0.5422001757384292d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429705417658978d, y: 0.24195896200462497d), new NpgsqlTypes.NpgsqlPoint(x: 0.967813791336795d, y: 0.2043620953403964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716661302908662d, y: 0.2547164756353001d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33108971174998914d, y: 0.34208031745983536d), new NpgsqlTypes.NpgsqlPoint(x: 0.324152437723759d, y: 0.5389607036321649d), new NpgsqlTypes.NpgsqlPoint(x: 0.47171781934382717d, y: 0.09376879921763104d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42740161688571454d, y: 0.4879908824173702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6713344183334071d, y: 0.5515515750995461d), new NpgsqlTypes.NpgsqlPoint(x: 0.48311671209958273d, y: 0.5317101825200844d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5569981921843389d, y: 0.9169878959157629d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943624621633154d, y: 0.5373705264911156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133559780203558d, y: 0.9811350019589834d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40785007433172293d, y: 0.543331250216297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235545849017892d, y: 0.03646746392217037d), new NpgsqlTypes.NpgsqlPoint(x: 0.13406410768178756d, y: 0.19370517633804463d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3138150084258722d, y: 0.45363560106549494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765066918490713d, y: 0.2762370823251017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973391210630526d, y: 0.9367597390813571d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2309409652618597d, y: 0.05519280928007131d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656398178352908d, y: 0.10098160058514338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3272983852474344d, y: 0.055191986114096814d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.620127329028452d, y: 0.4457481442149722d), new NpgsqlTypes.NpgsqlPoint(x: 0.06453183170834154d, y: 0.5721172551916289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532183142349643d, y: 0.765512208172768d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2823768752425072d, y: 0.33802135545123213d), new NpgsqlTypes.NpgsqlPoint(x: 0.31986962751606873d, y: 0.1360857590381822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459039445754183d, y: 0.5807208318724218d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14504316136937212d, y: 0.002754210245166422d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023292177222928867d, y: 0.8828059693588125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514622073374893d, y: 0.32991030961184376d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7900334127904518d, y: 0.5943624706913866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307457789354294d, y: 0.25625870590114097d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154218866313124d, y: 0.32761076813288925d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40321919166766784d, y: 0.986268453518327d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586935915371972d, y: 0.263110186530535d), new NpgsqlTypes.NpgsqlPoint(x: 0.07114619654345611d, y: 0.8316375150368727d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4309844169700042d, y: 0.5714532548325327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799600635119684d, y: 0.8671027765236091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7202983262576662d, y: 0.6549708680290119d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7911938302072671d, y: 0.517668526362711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2800855583433908d, y: 0.33819235756573784d), new NpgsqlTypes.NpgsqlPoint(x: 0.24981247629005654d, y: 0.40342751486846995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16498387878305787d, y: 0.9063920999083611d), new NpgsqlTypes.NpgsqlPoint(x: 0.38728435163886743d, y: 0.734849763449027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788364695273788d, y: 0.12053835242410027d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8615488806322402d, y: 0.15115000653386512d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049068955341744d, y: 0.6034405747782695d), new NpgsqlTypes.NpgsqlPoint(x: 0.03482264941028557d, y: 0.08742676254829329d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9393287457003398d, y: 0.3138280474849654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661891835327607d, y: 0.554276225235058d), new NpgsqlTypes.NpgsqlPoint(x: 0.0707928721701182d, y: 0.41664218973208056d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8291006348615041d, y: 0.7989077219765127d), new NpgsqlTypes.NpgsqlPoint(x: 0.38983815123793264d, y: 0.08390968772752994d), new NpgsqlTypes.NpgsqlPoint(x: 0.16588546505849977d, y: 0.7756437817720483d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014436888472451725d, y: 0.7217400794189235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289787196535855d, y: 0.07293689236857759d), new NpgsqlTypes.NpgsqlPoint(x: 0.30078049490295955d, y: 0.5313277546283636d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1680577126222249d, y: 0.07318483996690128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912234231610775d, y: 0.8476420063781156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335894623551933d, y: 0.9221438711334768d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.794512987807886d, y: 0.8681596666475062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723163926602815d, y: 0.09059144903486738d), new NpgsqlTypes.NpgsqlPoint(x: 0.637251872016966d, y: 0.8913432691424532d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7944152027972337d, y: 0.32642560626882455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598193270152092d, y: 0.6918528571920829d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156920727922409d, y: 0.16126664431671478d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3731226347141514d, y: 0.715206235492849d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823826009365735d, y: 0.9950386331893121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481169009266872d, y: 0.7830345542446728d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9489104202817904d, y: 0.9122792598695265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342460677699345d, y: 0.8044080245149595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779700548622609d, y: 0.2342921639677753d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7715774270107741d, y: 0.3458567539511921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609448243253771d, y: 0.051753407433434595d), new NpgsqlTypes.NpgsqlPoint(x: 0.036832628956258384d, y: 0.46270061954292563d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6856328288949952d, y: 0.3205750102228234d), new NpgsqlTypes.NpgsqlPoint(x: 0.06759985454314488d, y: 0.7140960689290369d), new NpgsqlTypes.NpgsqlPoint(x: 0.591338242692177d, y: 0.5582093040945685d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4669189587082129d, y: 0.21646641896649654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423749202845978d, y: 0.7956728907948499d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223277116686145d, y: 0.5808667651285432d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3859799751029178d, y: 0.6258757863762641d), new NpgsqlTypes.NpgsqlPoint(x: 0.2272391426672603d, y: 0.10466129641216526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351321657779136d, y: 0.11879295148302804d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8572466491898106d, y: 0.47994955200828304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910835311124947d, y: 0.3031740881608809d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432253877532196d, y: 0.06805514154381209d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32575205404641194d, y: 0.13972909535687628d), new NpgsqlTypes.NpgsqlPoint(x: 0.11008334571911771d, y: 0.7898345994739175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3692201102729d, y: 0.9958058722693484d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8634232233410115d, y: 0.802920346399044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4261567294828942d, y: 0.17143031140103926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601078075791203d, y: 0.002653917639675374d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7723878487464221d, y: 0.29007972571168683d), new NpgsqlTypes.NpgsqlPoint(x: 0.25445020188587153d, y: 0.8223213691916513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872369171740966d, y: 0.875234545769655d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7154551020270971d, y: 0.7978520353323864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806810487675864d, y: 0.09337529509111031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7687018454990302d, y: 0.926351623638184d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9696703796497955d, y: 0.5809061220158397d), new NpgsqlTypes.NpgsqlPoint(x: 0.26456398620153077d, y: 0.6130676750418591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060343283383488d, y: 0.25507822469657404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7100672763339165d, y: 0.9145588220338658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919021105214636d, y: 0.27913648705991356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9373230247748782d, y: 0.9962624308784981d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5469908841579809d, y: 0.6100490686877992d), new NpgsqlTypes.NpgsqlPoint(x: 0.13817827042434716d, y: 0.8246216602395195d), new NpgsqlTypes.NpgsqlPoint(x: 0.24893794902254107d, y: 0.5706902295532892d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35147443067869d, y: 0.6917172506767573d), new NpgsqlTypes.NpgsqlPoint(x: 0.40168993862527114d, y: 0.20292635837143824d), new NpgsqlTypes.NpgsqlPoint(x: 0.3070446524269831d, y: 0.30695374706551815d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6246070421820245d, y: 0.27738358487697357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291925204547551d, y: 0.6751117185756762d), new NpgsqlTypes.NpgsqlPoint(x: 0.642313767896222d, y: 0.52145551159169d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7218712621657553d, y: 0.3049935677404644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068979056329064d, y: 0.7739926995784175d), new NpgsqlTypes.NpgsqlPoint(x: 0.40740905867251087d, y: 0.03091468349470794d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8520769624290769d, y: 0.7550152880875061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180321422153049d, y: 0.9780577026451455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900647055309943d, y: 0.587173304706527d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8545085257709044d, y: 0.730923471804578d), new NpgsqlTypes.NpgsqlPoint(x: 0.49995702493804717d, y: 0.4029348390635613d), new NpgsqlTypes.NpgsqlPoint(x: 0.9173661594508257d, y: 0.9796265960987238d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45256779815950454d, y: 0.9025777983770743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249542775199389d, y: 0.32605307470304234d), new NpgsqlTypes.NpgsqlPoint(x: 0.16108774718443564d, y: 0.224322790679376d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21667464106822676d, y: 0.4517426593150279d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388934267280471d, y: 0.5994753480793891d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953147693535274d, y: 0.2722800504668236d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3838996885497642d, y: 0.11479484047978639d), new NpgsqlTypes.NpgsqlPoint(x: 0.25430741874165785d, y: 0.9034936601627813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9805886945356256d, y: 0.7651998011718463d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7970566233400513d, y: 0.10308546565971666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535849415677517d, y: 0.25758279582288446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410988357933618d, y: 0.7701086932824222d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7638179879300864d, y: 0.5734694578272838d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358625075976704d, y: 0.9262806710601715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004179804499621d, y: 0.8360013692307743d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9715681515693572d, y: 0.29850797501945847d), new NpgsqlTypes.NpgsqlPoint(x: 0.391276762670247d, y: 0.19782500849955165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5653200204674094d, y: 0.24455412012962763d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8647761586674706d, y: 0.9099704900088627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899467898411446d, y: 0.4378138408410194d), new NpgsqlTypes.NpgsqlPoint(x: 0.04405930953199422d, y: 0.4013979316336188d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6259314060970647d, y: 0.17174616664505127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627054753340718d, y: 0.540005284185763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356920973854038d, y: 0.6881543986123719d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7379307937208429d, y: 0.06328796898336275d), new NpgsqlTypes.NpgsqlPoint(x: 0.07013738173086015d, y: 0.5933024944768732d), new NpgsqlTypes.NpgsqlPoint(x: 0.14512585169249992d, y: 0.4586700099252433d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16072753281425745d, y: 0.9683996583390078d), new NpgsqlTypes.NpgsqlPoint(x: 0.12929927717610668d, y: 0.016469747042876404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4476243548751849d, y: 0.22527970095741268d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4609560717743897d, y: 0.9115762995448772d), new NpgsqlTypes.NpgsqlPoint(x: 0.20476053476192857d, y: 0.34528868048600425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972496079765548d, y: 0.1575062244833063d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6223625589969617d, y: 0.09636690771960899d), new NpgsqlTypes.NpgsqlPoint(x: 0.29050275357473565d, y: 0.2663167899390335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3141083924131979d, y: 0.448592704560417d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2694705585516938d, y: 0.023447402578332555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160963606128885d, y: 0.7320215616222978d), new NpgsqlTypes.NpgsqlPoint(x: 0.21576465232103348d, y: 0.08442252194096767d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4456709814955764d, y: 0.6174296677224647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602900538945803d, y: 0.2606760041623143d), new NpgsqlTypes.NpgsqlPoint(x: 0.02819410573235903d, y: 0.02604367563457577d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44224986509039277d, y: 0.8488001002382889d), new NpgsqlTypes.NpgsqlPoint(x: 0.1357936491770989d, y: 0.7935417658383505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8771775262477014d, y: 0.3756326087768831d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4651586891505437d, y: 0.46814315155843766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114571896233845d, y: 0.7455535226953448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302712555304145d, y: 0.12342325157500311d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7805793214892001d, y: 0.4999004347292404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068735595221047d, y: 0.8343583500334516d), new NpgsqlTypes.NpgsqlPoint(x: 0.12945014410729283d, y: 0.3925996295311487d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((106)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9528053812209135d, y: 0.9695724532741754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6765687649641561d, y: 0.4682911762182155d), new NpgsqlTypes.NpgsqlPoint(x: 0.04692795681885875d, y: 0.2013248869260339d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915241053827162d, y: 0.07903664088278828d), new NpgsqlTypes.NpgsqlPoint(x: 0.19640252072701636d, y: 0.06505335501704668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989756628067309d, y: 0.42173238883847763d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9521945544230911d, y: 0.6723892457856112d), new NpgsqlTypes.NpgsqlPoint(x: 0.3322675263857431d, y: 0.8147654873579075d), new NpgsqlTypes.NpgsqlPoint(x: 0.16360864206414816d, y: 0.5415132783923381d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2153357611665695d, y: 0.6670241178613816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461560608398807d, y: 0.6486641738376444d), new NpgsqlTypes.NpgsqlPoint(x: 0.31563971464347995d, y: 0.36254764914610027d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.823678992099491d, y: 0.0382927212294456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961798128077631d, y: 0.9125561385662871d), new NpgsqlTypes.NpgsqlPoint(x: 0.44432672106107896d, y: 0.5646979688685714d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((115)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8380539838836585d, y: 0.9134321654715462d), new NpgsqlTypes.NpgsqlPoint(x: 0.07515295456129045d, y: 0.8265095470974496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261167038834699d, y: 0.4232438969962333d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4858321341374089d, y: 0.5660330931391971d), new NpgsqlTypes.NpgsqlPoint(x: 0.05468406710017115d, y: 0.15617510488970043d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581462934180434d, y: 0.4218241292032687d)))));//Value

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
COPY public.binary_npgsqlpolygonpolygon0m
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
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
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
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
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
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

