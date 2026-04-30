

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
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32187743729051466d, y: 0.9837123616815743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608659072745059d, y: 0.8580409059373132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5401137762548912d, y: 0.9720284678422745d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6387911057188764d, y: 0.4792398367483184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3225675678268459d, y: 0.27717389895811695d), new NpgsqlTypes.NpgsqlPoint(x: 0.914774380987572d, y: 0.17205047127864548d)),
},
            new NpgsqlPathpath0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0939036211468176d, y: 0.17795064789924242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874797702644124d, y: 0.22070502453294227d), new NpgsqlTypes.NpgsqlPoint(x: 0.31118957101708455d, y: 0.90023920215019d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4863638441836249d, y: 0.8482623849486046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5966094098957083d, y: 0.8637278493451856d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616830618402752d, y: 0.9211039763566239d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48752894163016514d, y: 0.1561211880592681d), new NpgsqlTypes.NpgsqlPoint(x: 0.545058139868356d, y: 0.42660168801615417d), new NpgsqlTypes.NpgsqlPoint(x: 0.0980490995959481d, y: 0.5231413245324888d)),
},
            new NpgsqlPathpath0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012385770688188247d, y: 0.9437023511167454d), new NpgsqlTypes.NpgsqlPoint(x: 0.34097005594487806d, y: 0.06614710279617386d), new NpgsqlTypes.NpgsqlPoint(x: 0.17728727297540414d, y: 0.9203863738209981d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6316952100893283d, y: 0.7317146399508008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4163002546818575d, y: 0.8049110448143588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664498937186545d, y: 0.4518567303355444d)),
},
            new NpgsqlPathpath0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16272340320911327d, y: 0.38562829527075404d), new NpgsqlTypes.NpgsqlPoint(x: 0.3086470561795589d, y: 0.13928490183395525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999601204849794d, y: 0.8235962409985872d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3112107803757652d, y: 0.4581029672646054d), new NpgsqlTypes.NpgsqlPoint(x: 0.777669991637431d, y: 0.7667838313809824d), new NpgsqlTypes.NpgsqlPoint(x: 0.14114031234793278d, y: 0.7149143704456629d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06744746259369239d, y: 0.47078467809915026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3856479841035565d, y: 0.23532992617590442d), new NpgsqlTypes.NpgsqlPoint(x: 0.03957907366091562d, y: 0.12550508700727403d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.730284620690524d, y: 0.7239856198996987d), new NpgsqlTypes.NpgsqlPoint(x: 0.4889520089700292d, y: 0.25259560319519847d), new NpgsqlTypes.NpgsqlPoint(x: 0.561406529327117d, y: 0.9768415354266972d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08605797352399336d, y: 0.5038100801519455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733646952180582d, y: 0.33493821668546775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8595782329964408d, y: 0.7493066429047205d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2634362702230457d, y: 0.3310970517630163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473226894982894d, y: 0.47417194406756036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5897076051997622d, y: 0.9093924960600663d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49740550989580423d, y: 0.8235062006576792d), new NpgsqlTypes.NpgsqlPoint(x: 0.11140315134854029d, y: 0.640754417363561d), new NpgsqlTypes.NpgsqlPoint(x: 0.10607311661910435d, y: 0.8748515895381915d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10259815134186012d, y: 0.021433531863827904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343275942821939d, y: 0.3042099067836479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730309047833058d, y: 0.07583052288701209d)),
},
            new NpgsqlPathpath0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184307028356268d, y: 0.1660565877144905d), new NpgsqlTypes.NpgsqlPoint(x: 0.23689673694747349d, y: 0.6724133777108979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3391900929635604d, y: 0.3302034923142202d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1042341413579968d, y: 0.6208102099767836d), new NpgsqlTypes.NpgsqlPoint(x: 0.10013324476451191d, y: 0.9395063366033806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6097391795758189d, y: 0.04457116443736453d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773868720961987d, y: 0.4161056755091842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474959073462752d, y: 0.19407984817202195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3739995178533223d, y: 0.33409833683789814d)),
},
            new NpgsqlPathpath0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2985727553130755d, y: 0.16973040069023726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424403982845325d, y: 0.5125629459060828d), new NpgsqlTypes.NpgsqlPoint(x: 0.44800776254877916d, y: 0.612042310628433d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778081066584271d, y: 0.03704702541639415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468307008132023d, y: 0.6151042620486146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4560903759375522d, y: 0.3192479890654626d)),
},
            new NpgsqlPathpath0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.156866842363502d, y: 0.28173895099889035d), new NpgsqlTypes.NpgsqlPoint(x: 0.047590697508536284d, y: 0.13179571860578065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766834398831902d, y: 0.21411249004520505d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8138630578068515d, y: 0.11795865241411263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6830300212272239d, y: 0.572731389353938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678871331460612d, y: 0.2853566853578522d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024194576889528085d, y: 0.33696606627341463d), new NpgsqlTypes.NpgsqlPoint(x: 0.03410943936884514d, y: 0.074372588386165d), new NpgsqlTypes.NpgsqlPoint(x: 0.2034494929902383d, y: 0.44399091913399147d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6548378670200548d, y: 0.4134149856174837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441803125431862d, y: 0.6041844204099742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676762202524333d, y: 0.6196702338238622d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9417392653058971d, y: 0.21307016416138702d), new NpgsqlTypes.NpgsqlPoint(x: 0.28137811343522967d, y: 0.7514802682718026d), new NpgsqlTypes.NpgsqlPoint(x: 0.2877197752158349d, y: 0.9988707797949911d)),
},
            new NpgsqlPathpath0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1045669181267298d, y: 0.3621015270329473d), new NpgsqlTypes.NpgsqlPoint(x: 0.1148991801903616d, y: 0.2274872363619651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6195581343644281d, y: 0.05852231426075505d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46651592067116554d, y: 0.9703842408976944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555044982759686d, y: 0.3531551377273596d), new NpgsqlTypes.NpgsqlPoint(x: 0.903603128248657d, y: 0.3312499882257993d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0038502321229445524d, y: 0.03186137077263995d), new NpgsqlTypes.NpgsqlPoint(x: 0.02481559125789079d, y: 0.6441180045191767d), new NpgsqlTypes.NpgsqlPoint(x: 0.825722060372456d, y: 0.30205269466085016d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3243021342438145d, y: 0.6985757330535691d), new NpgsqlTypes.NpgsqlPoint(x: 0.681517693694453d, y: 0.19008600048182978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036240712075639d, y: 0.6716466481216589d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6639155914636087d, y: 0.918229505220105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5331528945403387d, y: 0.9088218275195418d), new NpgsqlTypes.NpgsqlPoint(x: 0.12332528303783508d, y: 0.047632533288568535d)),
},
            new NpgsqlPathpath0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8931224580364109d, y: 0.6894651451343579d), new NpgsqlTypes.NpgsqlPoint(x: 0.16849952854063943d, y: 0.9230078111959203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757882071627066d, y: 0.39325959366156704d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021867406759001673d, y: 0.6988350765221099d), new NpgsqlTypes.NpgsqlPoint(x: 0.985350449782381d, y: 0.01140251091606126d), new NpgsqlTypes.NpgsqlPoint(x: 0.02979062045817049d, y: 0.48271015812932816d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08029222752339271d, y: 0.5445785969702944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508227244529064d, y: 0.5549330333969313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077586018036229d, y: 0.16078436493012638d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5059880541605064d, y: 0.9595463808598307d), new NpgsqlTypes.NpgsqlPoint(x: 0.43639035766372714d, y: 0.2126660311079015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737412273624952d, y: 0.9671959938129648d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3109021456846234d, y: 0.23809653458447977d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296418337521448d, y: 0.16262641966178404d), new NpgsqlTypes.NpgsqlPoint(x: 0.1730036966191978d, y: 0.7186117261747179d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013100062742008367d, y: 0.11391362279310846d), new NpgsqlTypes.NpgsqlPoint(x: 0.39100676214688757d, y: 0.5995163176893243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433823891664345d, y: 0.06308450455986347d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.317133099940322d, y: 0.8155406557417567d), new NpgsqlTypes.NpgsqlPoint(x: 0.03796155685013092d, y: 0.6782319333715429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904483504288442d, y: 0.4804453324918271d)),
},
            new NpgsqlPathpath0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4737793868734428d, y: 0.21364087268455512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278895481132945d, y: 0.3322734753572889d), new NpgsqlTypes.NpgsqlPoint(x: 0.22119108403358367d, y: 0.6672133964156873d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03783783343908653d, y: 0.5484874823795984d), new NpgsqlTypes.NpgsqlPoint(x: 0.05555007011940982d, y: 0.0769130547450445d), new NpgsqlTypes.NpgsqlPoint(x: 0.0735963717296817d, y: 0.011558037814198618d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9281344318613908d, y: 0.29203756015625115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502449758842861d, y: 0.9839887271579368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046341479981677d, y: 0.00996623118848261d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3045220568507464d, y: 0.9792511962388112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348363169876699d, y: 0.9295248478895424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231976499814332d, y: 0.9928401781487364d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7436922987726727d, y: 0.8394710280241601d), new NpgsqlTypes.NpgsqlPoint(x: 0.12958717458957847d, y: 0.18075150222694336d), new NpgsqlTypes.NpgsqlPoint(x: 0.40437231345846525d, y: 0.3746577716601003d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6248644711489609d, y: 0.228316813394827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3171851727655902d, y: 0.6099097192194964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448921399392807d, y: 0.23056540269162173d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5949619677775516d, y: 0.9331336781587192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641401299069047d, y: 0.5201082312205062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900675974816662d, y: 0.20037443128834476d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5681894337857288d, y: 0.257888851592193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905333429749269d, y: 0.4846164444182488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781766966978918d, y: 0.8905906167843954d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4330522143219857d, y: 0.9704629371929534d), new NpgsqlTypes.NpgsqlPoint(x: 0.887163328486663d, y: 0.5320328572099878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2951237421453612d, y: 0.10181739967770576d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34836043025650787d, y: 0.35548126653930145d), new NpgsqlTypes.NpgsqlPoint(x: 0.16365885910310762d, y: 0.12540463235764565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861537382629299d, y: 0.4695097541916041d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1578158219428557d, y: 0.580502109191045d), new NpgsqlTypes.NpgsqlPoint(x: 0.36667248834448063d, y: 0.1568505716384353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9963555727258999d, y: 0.77563836899814d)),
},
            new NpgsqlPathpath0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6561724763752362d, y: 0.7314684626019561d), new NpgsqlTypes.NpgsqlPoint(x: 0.36361240861749133d, y: 0.8834122394606564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3802803048373804d, y: 0.7750834802771153d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9337676746759398d, y: 0.18596555208387722d), new NpgsqlTypes.NpgsqlPoint(x: 0.14647680072657332d, y: 0.8507435395878575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407757927849911d, y: 0.34121591680390406d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24386406887763512d, y: 0.15554392757693525d), new NpgsqlTypes.NpgsqlPoint(x: 0.14269638613583235d, y: 0.20552489001558827d), new NpgsqlTypes.NpgsqlPoint(x: 0.37136191471395297d, y: 0.9200879311093739d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.582667979074717d, y: 0.034248231379889305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112680891764618d, y: 0.5567763976394428d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358655892625889d, y: 0.7444919986647325d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4039079185868969d, y: 0.5491194555060888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4691837933336964d, y: 0.10531096038076315d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806713629464981d, y: 0.18866002989871555d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005276284262268671d, y: 0.29249059440197334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859913765403376d, y: 0.1078901984028241d), new NpgsqlTypes.NpgsqlPoint(x: 0.1854661948930716d, y: 0.4194405057288677d)),
},
            new NpgsqlPathpath0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.832685816352704d, y: 0.5601483299516479d), new NpgsqlTypes.NpgsqlPoint(x: 0.3674868057159424d, y: 0.7805694530223134d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517999302927911d, y: 0.7294649615379795d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37421525349877127d, y: 0.3123672359841997d), new NpgsqlTypes.NpgsqlPoint(x: 0.1090936783864559d, y: 0.13422102071667064d), new NpgsqlTypes.NpgsqlPoint(x: 0.41761128033972916d, y: 0.7873280889168898d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4207872452109743d, y: 0.015290441140708322d), new NpgsqlTypes.NpgsqlPoint(x: 0.547981454246913d, y: 0.5666423206592524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466467512784893d, y: 0.6933640857384799d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6360682050378027d, y: 0.9043463876664724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5297010172371073d, y: 0.806018909424035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781275014059875d, y: 0.4428814594912075d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5958284560371019d, y: 0.4798974060874024d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575568587668421d, y: 0.31450602028481d), new NpgsqlTypes.NpgsqlPoint(x: 0.10439299418237269d, y: 0.2954556396731678d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46895897576833934d, y: 0.4198918679081898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3324783261400912d, y: 0.4321632140967655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431715753228715d, y: 0.6381927114889016d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723203505864855d, y: 0.2769218847243651d), new NpgsqlTypes.NpgsqlPoint(x: 0.42716926824020374d, y: 0.8501134655709022d), new NpgsqlTypes.NpgsqlPoint(x: 0.25967014597117866d, y: 0.6934885408973642d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9824778374695037d, y: 0.06835529945255214d), new NpgsqlTypes.NpgsqlPoint(x: 0.12757013990860433d, y: 0.4035120978271448d), new NpgsqlTypes.NpgsqlPoint(x: 0.24368417654179308d, y: 0.5000377704579807d)),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10259815134186012d, y: 0.021433531863827904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343275942821939d, y: 0.3042099067836479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730309047833058d, y: 0.07583052288701209d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773868720961987d, y: 0.4161056755091842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474959073462752d, y: 0.19407984817202195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3739995178533223d, y: 0.33409833683789814d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778081066584271d, y: 0.03704702541639415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468307008132023d, y: 0.6151042620486146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4560903759375522d, y: 0.3192479890654626d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9417392653058971d, y: 0.21307016416138702d), new NpgsqlTypes.NpgsqlPoint(x: 0.28137811343522967d, y: 0.7514802682718026d), new NpgsqlTypes.NpgsqlPoint(x: 0.2877197752158349d, y: 0.9988707797949911d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 28, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[29], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 89, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 53, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 123, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 19, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32187743729051466d, y: 0.9837123616815743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608659072745059d, y: 0.8580409059373132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5401137762548912d, y: 0.9720284678422745d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6387911057188764d, y: 0.4792398367483184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3225675678268459d, y: 0.27717389895811695d), new NpgsqlTypes.NpgsqlPoint(x: 0.914774380987572d, y: 0.17205047127864548d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0939036211468176d, y: 0.17795064789924242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874797702644124d, y: 0.22070502453294227d), new NpgsqlTypes.NpgsqlPoint(x: 0.31118957101708455d, y: 0.90023920215019d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4863638441836249d, y: 0.8482623849486046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5966094098957083d, y: 0.8637278493451856d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616830618402752d, y: 0.9211039763566239d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48752894163016514d, y: 0.1561211880592681d), new NpgsqlTypes.NpgsqlPoint(x: 0.545058139868356d, y: 0.42660168801615417d), new NpgsqlTypes.NpgsqlPoint(x: 0.0980490995959481d, y: 0.5231413245324888d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012385770688188247d, y: 0.9437023511167454d), new NpgsqlTypes.NpgsqlPoint(x: 0.34097005594487806d, y: 0.06614710279617386d), new NpgsqlTypes.NpgsqlPoint(x: 0.17728727297540414d, y: 0.9203863738209981d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6316952100893283d, y: 0.7317146399508008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4163002546818575d, y: 0.8049110448143588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664498937186545d, y: 0.4518567303355444d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16272340320911327d, y: 0.38562829527075404d), new NpgsqlTypes.NpgsqlPoint(x: 0.3086470561795589d, y: 0.13928490183395525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999601204849794d, y: 0.8235962409985872d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3112107803757652d, y: 0.4581029672646054d), new NpgsqlTypes.NpgsqlPoint(x: 0.777669991637431d, y: 0.7667838313809824d), new NpgsqlTypes.NpgsqlPoint(x: 0.14114031234793278d, y: 0.7149143704456629d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06744746259369239d, y: 0.47078467809915026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3856479841035565d, y: 0.23532992617590442d), new NpgsqlTypes.NpgsqlPoint(x: 0.03957907366091562d, y: 0.12550508700727403d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.730284620690524d, y: 0.7239856198996987d), new NpgsqlTypes.NpgsqlPoint(x: 0.4889520089700292d, y: 0.25259560319519847d), new NpgsqlTypes.NpgsqlPoint(x: 0.561406529327117d, y: 0.9768415354266972d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08605797352399336d, y: 0.5038100801519455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733646952180582d, y: 0.33493821668546775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8595782329964408d, y: 0.7493066429047205d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2634362702230457d, y: 0.3310970517630163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473226894982894d, y: 0.47417194406756036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5897076051997622d, y: 0.9093924960600663d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49740550989580423d, y: 0.8235062006576792d), new NpgsqlTypes.NpgsqlPoint(x: 0.11140315134854029d, y: 0.640754417363561d), new NpgsqlTypes.NpgsqlPoint(x: 0.10607311661910435d, y: 0.8748515895381915d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10259815134186012d, y: 0.021433531863827904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343275942821939d, y: 0.3042099067836479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730309047833058d, y: 0.07583052288701209d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184307028356268d, y: 0.1660565877144905d), new NpgsqlTypes.NpgsqlPoint(x: 0.23689673694747349d, y: 0.6724133777108979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3391900929635604d, y: 0.3302034923142202d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1042341413579968d, y: 0.6208102099767836d), new NpgsqlTypes.NpgsqlPoint(x: 0.10013324476451191d, y: 0.9395063366033806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6097391795758189d, y: 0.04457116443736453d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773868720961987d, y: 0.4161056755091842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474959073462752d, y: 0.19407984817202195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3739995178533223d, y: 0.33409833683789814d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2985727553130755d, y: 0.16973040069023726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424403982845325d, y: 0.5125629459060828d), new NpgsqlTypes.NpgsqlPoint(x: 0.44800776254877916d, y: 0.612042310628433d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778081066584271d, y: 0.03704702541639415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468307008132023d, y: 0.6151042620486146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4560903759375522d, y: 0.3192479890654626d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.156866842363502d, y: 0.28173895099889035d), new NpgsqlTypes.NpgsqlPoint(x: 0.047590697508536284d, y: 0.13179571860578065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766834398831902d, y: 0.21411249004520505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8138630578068515d, y: 0.11795865241411263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6830300212272239d, y: 0.572731389353938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678871331460612d, y: 0.2853566853578522d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024194576889528085d, y: 0.33696606627341463d), new NpgsqlTypes.NpgsqlPoint(x: 0.03410943936884514d, y: 0.074372588386165d), new NpgsqlTypes.NpgsqlPoint(x: 0.2034494929902383d, y: 0.44399091913399147d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6548378670200548d, y: 0.4134149856174837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441803125431862d, y: 0.6041844204099742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676762202524333d, y: 0.6196702338238622d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9417392653058971d, y: 0.21307016416138702d), new NpgsqlTypes.NpgsqlPoint(x: 0.28137811343522967d, y: 0.7514802682718026d), new NpgsqlTypes.NpgsqlPoint(x: 0.2877197752158349d, y: 0.9988707797949911d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1045669181267298d, y: 0.3621015270329473d), new NpgsqlTypes.NpgsqlPoint(x: 0.1148991801903616d, y: 0.2274872363619651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6195581343644281d, y: 0.05852231426075505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46651592067116554d, y: 0.9703842408976944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555044982759686d, y: 0.3531551377273596d), new NpgsqlTypes.NpgsqlPoint(x: 0.903603128248657d, y: 0.3312499882257993d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0038502321229445524d, y: 0.03186137077263995d), new NpgsqlTypes.NpgsqlPoint(x: 0.02481559125789079d, y: 0.6441180045191767d), new NpgsqlTypes.NpgsqlPoint(x: 0.825722060372456d, y: 0.30205269466085016d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3243021342438145d, y: 0.6985757330535691d), new NpgsqlTypes.NpgsqlPoint(x: 0.681517693694453d, y: 0.19008600048182978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036240712075639d, y: 0.6716466481216589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6639155914636087d, y: 0.918229505220105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5331528945403387d, y: 0.9088218275195418d), new NpgsqlTypes.NpgsqlPoint(x: 0.12332528303783508d, y: 0.047632533288568535d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8931224580364109d, y: 0.6894651451343579d), new NpgsqlTypes.NpgsqlPoint(x: 0.16849952854063943d, y: 0.9230078111959203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757882071627066d, y: 0.39325959366156704d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021867406759001673d, y: 0.6988350765221099d), new NpgsqlTypes.NpgsqlPoint(x: 0.985350449782381d, y: 0.01140251091606126d), new NpgsqlTypes.NpgsqlPoint(x: 0.02979062045817049d, y: 0.48271015812932816d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08029222752339271d, y: 0.5445785969702944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508227244529064d, y: 0.5549330333969313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077586018036229d, y: 0.16078436493012638d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5059880541605064d, y: 0.9595463808598307d), new NpgsqlTypes.NpgsqlPoint(x: 0.43639035766372714d, y: 0.2126660311079015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737412273624952d, y: 0.9671959938129648d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3109021456846234d, y: 0.23809653458447977d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296418337521448d, y: 0.16262641966178404d), new NpgsqlTypes.NpgsqlPoint(x: 0.1730036966191978d, y: 0.7186117261747179d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013100062742008367d, y: 0.11391362279310846d), new NpgsqlTypes.NpgsqlPoint(x: 0.39100676214688757d, y: 0.5995163176893243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433823891664345d, y: 0.06308450455986347d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.317133099940322d, y: 0.8155406557417567d), new NpgsqlTypes.NpgsqlPoint(x: 0.03796155685013092d, y: 0.6782319333715429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904483504288442d, y: 0.4804453324918271d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4737793868734428d, y: 0.21364087268455512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278895481132945d, y: 0.3322734753572889d), new NpgsqlTypes.NpgsqlPoint(x: 0.22119108403358367d, y: 0.6672133964156873d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03783783343908653d, y: 0.5484874823795984d), new NpgsqlTypes.NpgsqlPoint(x: 0.05555007011940982d, y: 0.0769130547450445d), new NpgsqlTypes.NpgsqlPoint(x: 0.0735963717296817d, y: 0.011558037814198618d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9281344318613908d, y: 0.29203756015625115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502449758842861d, y: 0.9839887271579368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046341479981677d, y: 0.00996623118848261d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3045220568507464d, y: 0.9792511962388112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348363169876699d, y: 0.9295248478895424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231976499814332d, y: 0.9928401781487364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7436922987726727d, y: 0.8394710280241601d), new NpgsqlTypes.NpgsqlPoint(x: 0.12958717458957847d, y: 0.18075150222694336d), new NpgsqlTypes.NpgsqlPoint(x: 0.40437231345846525d, y: 0.3746577716601003d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6248644711489609d, y: 0.228316813394827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3171851727655902d, y: 0.6099097192194964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448921399392807d, y: 0.23056540269162173d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5949619677775516d, y: 0.9331336781587192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641401299069047d, y: 0.5201082312205062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900675974816662d, y: 0.20037443128834476d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5681894337857288d, y: 0.257888851592193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905333429749269d, y: 0.4846164444182488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781766966978918d, y: 0.8905906167843954d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4330522143219857d, y: 0.9704629371929534d), new NpgsqlTypes.NpgsqlPoint(x: 0.887163328486663d, y: 0.5320328572099878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2951237421453612d, y: 0.10181739967770576d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34836043025650787d, y: 0.35548126653930145d), new NpgsqlTypes.NpgsqlPoint(x: 0.16365885910310762d, y: 0.12540463235764565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861537382629299d, y: 0.4695097541916041d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1578158219428557d, y: 0.580502109191045d), new NpgsqlTypes.NpgsqlPoint(x: 0.36667248834448063d, y: 0.1568505716384353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9963555727258999d, y: 0.77563836899814d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6561724763752362d, y: 0.7314684626019561d), new NpgsqlTypes.NpgsqlPoint(x: 0.36361240861749133d, y: 0.8834122394606564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3802803048373804d, y: 0.7750834802771153d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9337676746759398d, y: 0.18596555208387722d), new NpgsqlTypes.NpgsqlPoint(x: 0.14647680072657332d, y: 0.8507435395878575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407757927849911d, y: 0.34121591680390406d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24386406887763512d, y: 0.15554392757693525d), new NpgsqlTypes.NpgsqlPoint(x: 0.14269638613583235d, y: 0.20552489001558827d), new NpgsqlTypes.NpgsqlPoint(x: 0.37136191471395297d, y: 0.9200879311093739d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.582667979074717d, y: 0.034248231379889305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112680891764618d, y: 0.5567763976394428d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358655892625889d, y: 0.7444919986647325d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4039079185868969d, y: 0.5491194555060888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4691837933336964d, y: 0.10531096038076315d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806713629464981d, y: 0.18866002989871555d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005276284262268671d, y: 0.29249059440197334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859913765403376d, y: 0.1078901984028241d), new NpgsqlTypes.NpgsqlPoint(x: 0.1854661948930716d, y: 0.4194405057288677d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.832685816352704d, y: 0.5601483299516479d), new NpgsqlTypes.NpgsqlPoint(x: 0.3674868057159424d, y: 0.7805694530223134d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517999302927911d, y: 0.7294649615379795d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37421525349877127d, y: 0.3123672359841997d), new NpgsqlTypes.NpgsqlPoint(x: 0.1090936783864559d, y: 0.13422102071667064d), new NpgsqlTypes.NpgsqlPoint(x: 0.41761128033972916d, y: 0.7873280889168898d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4207872452109743d, y: 0.015290441140708322d), new NpgsqlTypes.NpgsqlPoint(x: 0.547981454246913d, y: 0.5666423206592524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466467512784893d, y: 0.6933640857384799d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6360682050378027d, y: 0.9043463876664724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5297010172371073d, y: 0.806018909424035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781275014059875d, y: 0.4428814594912075d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5958284560371019d, y: 0.4798974060874024d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575568587668421d, y: 0.31450602028481d), new NpgsqlTypes.NpgsqlPoint(x: 0.10439299418237269d, y: 0.2954556396731678d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46895897576833934d, y: 0.4198918679081898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3324783261400912d, y: 0.4321632140967655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431715753228715d, y: 0.6381927114889016d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723203505864855d, y: 0.2769218847243651d), new NpgsqlTypes.NpgsqlPoint(x: 0.42716926824020374d, y: 0.8501134655709022d), new NpgsqlTypes.NpgsqlPoint(x: 0.25967014597117866d, y: 0.6934885408973642d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9824778374695037d, y: 0.06835529945255214d), new NpgsqlTypes.NpgsqlPoint(x: 0.12757013990860433d, y: 0.4035120978271448d), new NpgsqlTypes.NpgsqlPoint(x: 0.24368417654179308d, y: 0.5000377704579807d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32187743729051466d, y: 0.9837123616815743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608659072745059d, y: 0.8580409059373132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5401137762548912d, y: 0.9720284678422745d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6387911057188764d, y: 0.4792398367483184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3225675678268459d, y: 0.27717389895811695d), new NpgsqlTypes.NpgsqlPoint(x: 0.914774380987572d, y: 0.17205047127864548d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0939036211468176d, y: 0.17795064789924242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874797702644124d, y: 0.22070502453294227d), new NpgsqlTypes.NpgsqlPoint(x: 0.31118957101708455d, y: 0.90023920215019d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4863638441836249d, y: 0.8482623849486046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5966094098957083d, y: 0.8637278493451856d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616830618402752d, y: 0.9211039763566239d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48752894163016514d, y: 0.1561211880592681d), new NpgsqlTypes.NpgsqlPoint(x: 0.545058139868356d, y: 0.42660168801615417d), new NpgsqlTypes.NpgsqlPoint(x: 0.0980490995959481d, y: 0.5231413245324888d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012385770688188247d, y: 0.9437023511167454d), new NpgsqlTypes.NpgsqlPoint(x: 0.34097005594487806d, y: 0.06614710279617386d), new NpgsqlTypes.NpgsqlPoint(x: 0.17728727297540414d, y: 0.9203863738209981d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6316952100893283d, y: 0.7317146399508008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4163002546818575d, y: 0.8049110448143588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664498937186545d, y: 0.4518567303355444d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16272340320911327d, y: 0.38562829527075404d), new NpgsqlTypes.NpgsqlPoint(x: 0.3086470561795589d, y: 0.13928490183395525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999601204849794d, y: 0.8235962409985872d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3112107803757652d, y: 0.4581029672646054d), new NpgsqlTypes.NpgsqlPoint(x: 0.777669991637431d, y: 0.7667838313809824d), new NpgsqlTypes.NpgsqlPoint(x: 0.14114031234793278d, y: 0.7149143704456629d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06744746259369239d, y: 0.47078467809915026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3856479841035565d, y: 0.23532992617590442d), new NpgsqlTypes.NpgsqlPoint(x: 0.03957907366091562d, y: 0.12550508700727403d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.730284620690524d, y: 0.7239856198996987d), new NpgsqlTypes.NpgsqlPoint(x: 0.4889520089700292d, y: 0.25259560319519847d), new NpgsqlTypes.NpgsqlPoint(x: 0.561406529327117d, y: 0.9768415354266972d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08605797352399336d, y: 0.5038100801519455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733646952180582d, y: 0.33493821668546775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8595782329964408d, y: 0.7493066429047205d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2634362702230457d, y: 0.3310970517630163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473226894982894d, y: 0.47417194406756036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5897076051997622d, y: 0.9093924960600663d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49740550989580423d, y: 0.8235062006576792d), new NpgsqlTypes.NpgsqlPoint(x: 0.11140315134854029d, y: 0.640754417363561d), new NpgsqlTypes.NpgsqlPoint(x: 0.10607311661910435d, y: 0.8748515895381915d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10259815134186012d, y: 0.021433531863827904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343275942821939d, y: 0.3042099067836479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730309047833058d, y: 0.07583052288701209d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184307028356268d, y: 0.1660565877144905d), new NpgsqlTypes.NpgsqlPoint(x: 0.23689673694747349d, y: 0.6724133777108979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3391900929635604d, y: 0.3302034923142202d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1042341413579968d, y: 0.6208102099767836d), new NpgsqlTypes.NpgsqlPoint(x: 0.10013324476451191d, y: 0.9395063366033806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6097391795758189d, y: 0.04457116443736453d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773868720961987d, y: 0.4161056755091842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474959073462752d, y: 0.19407984817202195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3739995178533223d, y: 0.33409833683789814d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2985727553130755d, y: 0.16973040069023726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424403982845325d, y: 0.5125629459060828d), new NpgsqlTypes.NpgsqlPoint(x: 0.44800776254877916d, y: 0.612042310628433d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778081066584271d, y: 0.03704702541639415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468307008132023d, y: 0.6151042620486146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4560903759375522d, y: 0.3192479890654626d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.156866842363502d, y: 0.28173895099889035d), new NpgsqlTypes.NpgsqlPoint(x: 0.047590697508536284d, y: 0.13179571860578065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766834398831902d, y: 0.21411249004520505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8138630578068515d, y: 0.11795865241411263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6830300212272239d, y: 0.572731389353938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678871331460612d, y: 0.2853566853578522d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024194576889528085d, y: 0.33696606627341463d), new NpgsqlTypes.NpgsqlPoint(x: 0.03410943936884514d, y: 0.074372588386165d), new NpgsqlTypes.NpgsqlPoint(x: 0.2034494929902383d, y: 0.44399091913399147d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6548378670200548d, y: 0.4134149856174837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441803125431862d, y: 0.6041844204099742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676762202524333d, y: 0.6196702338238622d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9417392653058971d, y: 0.21307016416138702d), new NpgsqlTypes.NpgsqlPoint(x: 0.28137811343522967d, y: 0.7514802682718026d), new NpgsqlTypes.NpgsqlPoint(x: 0.2877197752158349d, y: 0.9988707797949911d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1045669181267298d, y: 0.3621015270329473d), new NpgsqlTypes.NpgsqlPoint(x: 0.1148991801903616d, y: 0.2274872363619651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6195581343644281d, y: 0.05852231426075505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46651592067116554d, y: 0.9703842408976944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555044982759686d, y: 0.3531551377273596d), new NpgsqlTypes.NpgsqlPoint(x: 0.903603128248657d, y: 0.3312499882257993d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0038502321229445524d, y: 0.03186137077263995d), new NpgsqlTypes.NpgsqlPoint(x: 0.02481559125789079d, y: 0.6441180045191767d), new NpgsqlTypes.NpgsqlPoint(x: 0.825722060372456d, y: 0.30205269466085016d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3243021342438145d, y: 0.6985757330535691d), new NpgsqlTypes.NpgsqlPoint(x: 0.681517693694453d, y: 0.19008600048182978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036240712075639d, y: 0.6716466481216589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6639155914636087d, y: 0.918229505220105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5331528945403387d, y: 0.9088218275195418d), new NpgsqlTypes.NpgsqlPoint(x: 0.12332528303783508d, y: 0.047632533288568535d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8931224580364109d, y: 0.6894651451343579d), new NpgsqlTypes.NpgsqlPoint(x: 0.16849952854063943d, y: 0.9230078111959203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757882071627066d, y: 0.39325959366156704d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021867406759001673d, y: 0.6988350765221099d), new NpgsqlTypes.NpgsqlPoint(x: 0.985350449782381d, y: 0.01140251091606126d), new NpgsqlTypes.NpgsqlPoint(x: 0.02979062045817049d, y: 0.48271015812932816d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08029222752339271d, y: 0.5445785969702944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508227244529064d, y: 0.5549330333969313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077586018036229d, y: 0.16078436493012638d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5059880541605064d, y: 0.9595463808598307d), new NpgsqlTypes.NpgsqlPoint(x: 0.43639035766372714d, y: 0.2126660311079015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737412273624952d, y: 0.9671959938129648d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3109021456846234d, y: 0.23809653458447977d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296418337521448d, y: 0.16262641966178404d), new NpgsqlTypes.NpgsqlPoint(x: 0.1730036966191978d, y: 0.7186117261747179d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013100062742008367d, y: 0.11391362279310846d), new NpgsqlTypes.NpgsqlPoint(x: 0.39100676214688757d, y: 0.5995163176893243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433823891664345d, y: 0.06308450455986347d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.317133099940322d, y: 0.8155406557417567d), new NpgsqlTypes.NpgsqlPoint(x: 0.03796155685013092d, y: 0.6782319333715429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904483504288442d, y: 0.4804453324918271d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4737793868734428d, y: 0.21364087268455512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278895481132945d, y: 0.3322734753572889d), new NpgsqlTypes.NpgsqlPoint(x: 0.22119108403358367d, y: 0.6672133964156873d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03783783343908653d, y: 0.5484874823795984d), new NpgsqlTypes.NpgsqlPoint(x: 0.05555007011940982d, y: 0.0769130547450445d), new NpgsqlTypes.NpgsqlPoint(x: 0.0735963717296817d, y: 0.011558037814198618d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9281344318613908d, y: 0.29203756015625115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502449758842861d, y: 0.9839887271579368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046341479981677d, y: 0.00996623118848261d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3045220568507464d, y: 0.9792511962388112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348363169876699d, y: 0.9295248478895424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231976499814332d, y: 0.9928401781487364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7436922987726727d, y: 0.8394710280241601d), new NpgsqlTypes.NpgsqlPoint(x: 0.12958717458957847d, y: 0.18075150222694336d), new NpgsqlTypes.NpgsqlPoint(x: 0.40437231345846525d, y: 0.3746577716601003d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6248644711489609d, y: 0.228316813394827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3171851727655902d, y: 0.6099097192194964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448921399392807d, y: 0.23056540269162173d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5949619677775516d, y: 0.9331336781587192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641401299069047d, y: 0.5201082312205062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900675974816662d, y: 0.20037443128834476d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5681894337857288d, y: 0.257888851592193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905333429749269d, y: 0.4846164444182488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781766966978918d, y: 0.8905906167843954d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4330522143219857d, y: 0.9704629371929534d), new NpgsqlTypes.NpgsqlPoint(x: 0.887163328486663d, y: 0.5320328572099878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2951237421453612d, y: 0.10181739967770576d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34836043025650787d, y: 0.35548126653930145d), new NpgsqlTypes.NpgsqlPoint(x: 0.16365885910310762d, y: 0.12540463235764565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861537382629299d, y: 0.4695097541916041d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1578158219428557d, y: 0.580502109191045d), new NpgsqlTypes.NpgsqlPoint(x: 0.36667248834448063d, y: 0.1568505716384353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9963555727258999d, y: 0.77563836899814d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6561724763752362d, y: 0.7314684626019561d), new NpgsqlTypes.NpgsqlPoint(x: 0.36361240861749133d, y: 0.8834122394606564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3802803048373804d, y: 0.7750834802771153d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9337676746759398d, y: 0.18596555208387722d), new NpgsqlTypes.NpgsqlPoint(x: 0.14647680072657332d, y: 0.8507435395878575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407757927849911d, y: 0.34121591680390406d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24386406887763512d, y: 0.15554392757693525d), new NpgsqlTypes.NpgsqlPoint(x: 0.14269638613583235d, y: 0.20552489001558827d), new NpgsqlTypes.NpgsqlPoint(x: 0.37136191471395297d, y: 0.9200879311093739d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.582667979074717d, y: 0.034248231379889305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112680891764618d, y: 0.5567763976394428d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358655892625889d, y: 0.7444919986647325d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4039079185868969d, y: 0.5491194555060888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4691837933336964d, y: 0.10531096038076315d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806713629464981d, y: 0.18866002989871555d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005276284262268671d, y: 0.29249059440197334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859913765403376d, y: 0.1078901984028241d), new NpgsqlTypes.NpgsqlPoint(x: 0.1854661948930716d, y: 0.4194405057288677d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.832685816352704d, y: 0.5601483299516479d), new NpgsqlTypes.NpgsqlPoint(x: 0.3674868057159424d, y: 0.7805694530223134d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517999302927911d, y: 0.7294649615379795d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37421525349877127d, y: 0.3123672359841997d), new NpgsqlTypes.NpgsqlPoint(x: 0.1090936783864559d, y: 0.13422102071667064d), new NpgsqlTypes.NpgsqlPoint(x: 0.41761128033972916d, y: 0.7873280889168898d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4207872452109743d, y: 0.015290441140708322d), new NpgsqlTypes.NpgsqlPoint(x: 0.547981454246913d, y: 0.5666423206592524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466467512784893d, y: 0.6933640857384799d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6360682050378027d, y: 0.9043463876664724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5297010172371073d, y: 0.806018909424035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781275014059875d, y: 0.4428814594912075d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5958284560371019d, y: 0.4798974060874024d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575568587668421d, y: 0.31450602028481d), new NpgsqlTypes.NpgsqlPoint(x: 0.10439299418237269d, y: 0.2954556396731678d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46895897576833934d, y: 0.4198918679081898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3324783261400912d, y: 0.4321632140967655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431715753228715d, y: 0.6381927114889016d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723203505864855d, y: 0.2769218847243651d), new NpgsqlTypes.NpgsqlPoint(x: 0.42716926824020374d, y: 0.8501134655709022d), new NpgsqlTypes.NpgsqlPoint(x: 0.25967014597117866d, y: 0.6934885408973642d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9824778374695037d, y: 0.06835529945255214d), new NpgsqlTypes.NpgsqlPoint(x: 0.12757013990860433d, y: 0.4035120978271448d), new NpgsqlTypes.NpgsqlPoint(x: 0.24368417654179308d, y: 0.5000377704579807d)))));

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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

