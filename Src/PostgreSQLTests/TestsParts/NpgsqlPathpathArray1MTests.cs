

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49272776270828356d, y: 0.7959425195614674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015520146933276d, y: 0.4935234599215792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5576720040942873d, y: 0.8322657978827037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8061178494618441d, y: 0.6821053500371911d), new NpgsqlTypes.NpgsqlPoint(x: 0.26392154250351896d, y: 0.06560301353391662d), new NpgsqlTypes.NpgsqlPoint(x: 0.2509491122058831d, y: 0.9451819379672882d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.70027305576682d, y: 0.06861402635935898d), new NpgsqlTypes.NpgsqlPoint(x: 0.547072199029608d, y: 0.07287632662844112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963766761865263d, y: 0.17270465971831228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.902381739622152d, y: 0.29229999352487124d), new NpgsqlTypes.NpgsqlPoint(x: 0.26463454759216976d, y: 0.3380871696062363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6142554951812363d, y: 0.19909864016028134d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2639580694303504d, y: 0.0824333885021653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487849894303154d, y: 0.3126692779144665d), new NpgsqlTypes.NpgsqlPoint(x: 0.730327822188931d, y: 0.7317830528350037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9503726224783465d, y: 0.9467210726247365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278805248731337d, y: 0.7015543669182734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4812383626630926d, y: 0.6624558499915258d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26974148558575006d, y: 0.7739303128634644d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540794926571459d, y: 0.1064257866726781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4498577838536596d, y: 0.5618184365633455d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1913196256879055d, y: 0.003813546801215928d), new NpgsqlTypes.NpgsqlPoint(x: 0.11389821189378602d, y: 0.06423306989370703d), new NpgsqlTypes.NpgsqlPoint(x: 0.07522309578132569d, y: 0.18151704069531815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4625379853768329d, y: 0.9288661319352468d), new NpgsqlTypes.NpgsqlPoint(x: 0.836091645230038d, y: 0.4021716256591217d), new NpgsqlTypes.NpgsqlPoint(x: 0.058519868415027654d, y: 0.17005749580155916d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5639169088561047d, y: 0.9011418117141694d), new NpgsqlTypes.NpgsqlPoint(x: 0.899454253087984d, y: 0.6397641444061202d), new NpgsqlTypes.NpgsqlPoint(x: 0.33639538018498905d, y: 0.5018087698254076d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24411315060059846d, y: 0.6189173416835508d), new NpgsqlTypes.NpgsqlPoint(x: 0.47799956940190946d, y: 0.2613505204236575d), new NpgsqlTypes.NpgsqlPoint(x: 0.3160042633701423d, y: 0.5337726289513757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3441710892380704d, y: 0.043541406514514436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022615536127105d, y: 0.9666457907467938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827664714319244d, y: 0.5449777383928462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4755911926890136d, y: 0.4060138641215112d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886588174494454d, y: 0.43604140166084127d), new NpgsqlTypes.NpgsqlPoint(x: 0.2968281680904461d, y: 0.21528080011522122d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9738006252683314d, y: 0.7099336855459114d), new NpgsqlTypes.NpgsqlPoint(x: 0.3135899849070636d, y: 0.31208632389495017d), new NpgsqlTypes.NpgsqlPoint(x: 0.9986799509088178d, y: 0.1498953006944217d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2594701842961661d, y: 0.07603776055376643d), new NpgsqlTypes.NpgsqlPoint(x: 0.40378069421401563d, y: 0.13545239832895084d), new NpgsqlTypes.NpgsqlPoint(x: 0.1409576522635918d, y: 0.8834423098924103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5388077831514971d, y: 0.6806357793078058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112908586583857d, y: 0.721533049789677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640738168219248d, y: 0.31151594104796154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42317302411351787d, y: 0.2000733676253067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516046180427153d, y: 0.508398652539085d), new NpgsqlTypes.NpgsqlPoint(x: 0.13863221126974345d, y: 0.42114174893186485d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9206054688403967d, y: 0.6800655601423506d), new NpgsqlTypes.NpgsqlPoint(x: 0.020548375271935426d, y: 0.913657750693774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801059170298286d, y: 0.6433768902869993d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9868394708396259d, y: 0.41409079619778333d), new NpgsqlTypes.NpgsqlPoint(x: 0.46236162041419115d, y: 0.44741268207415874d), new NpgsqlTypes.NpgsqlPoint(x: 0.44760003013483984d, y: 0.9811184870506101d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6978790781498525d, y: 0.6491223677713479d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373684443892686d, y: 0.41667841687703855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359254891464024d, y: 0.7425757229800584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611377933364645d, y: 0.7379730056648119d), new NpgsqlTypes.NpgsqlPoint(x: 0.41533291731336297d, y: 0.5530201983230881d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177611137196179d, y: 0.4178813423580756d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9982882883886461d, y: 0.6401257902097536d), new NpgsqlTypes.NpgsqlPoint(x: 0.08422270537766163d, y: 0.8165212508762554d), new NpgsqlTypes.NpgsqlPoint(x: 0.46805908275412245d, y: 0.5767026053874056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.950529876525804d, y: 0.03751224474063419d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471510925801879d, y: 0.23079989405109547d), new NpgsqlTypes.NpgsqlPoint(x: 0.42028271050390276d, y: 0.9475745458622218d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4757834266474825d, y: 0.2739109881172934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9607540697040722d, y: 0.5088370241909665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072744168547384d, y: 0.08282322131097275d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9603306459522953d, y: 0.3965026607468951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5970006789208219d, y: 0.4878553221612527d), new NpgsqlTypes.NpgsqlPoint(x: 0.15497684958974223d, y: 0.2470677676990507d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48496590041944565d, y: 0.4224751835960766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173647662605897d, y: 0.016323904656100563d), new NpgsqlTypes.NpgsqlPoint(x: 0.26209151380503115d, y: 0.38224492612094807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.864758863238799d, y: 0.960036207716516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1573120561160054d, y: 0.36222030439915254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7139910982995746d, y: 0.6840030593508338d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42500458613659675d, y: 0.5958862087466599d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601083012517492d, y: 0.7757444285209001d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390060434178009d, y: 0.05729386116804214d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5200668397823976d, y: 0.6517459983699393d), new NpgsqlTypes.NpgsqlPoint(x: 0.9479831904485343d, y: 0.29328495912319763d), new NpgsqlTypes.NpgsqlPoint(x: 0.19678896169449422d, y: 0.19481130839645455d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17695493900614245d, y: 0.6418425758761105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5632687632668539d, y: 0.6182929319471204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677911977287922d, y: 0.9158704739931727d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19221563290310606d, y: 0.4402885704383883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226792179971291d, y: 0.9150686209514292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978630268538042d, y: 0.6997789498112092d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06331970785966012d, y: 0.31622109825891787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490252705557707d, y: 0.0826004401178787d), new NpgsqlTypes.NpgsqlPoint(x: 0.17886469318860443d, y: 0.2141258389353098d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30872243093374563d, y: 0.8401390405198498d), new NpgsqlTypes.NpgsqlPoint(x: 0.7472609807250256d, y: 0.9199553627183323d), new NpgsqlTypes.NpgsqlPoint(x: 0.4800431184674513d, y: 0.5443849068442451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32416638611503623d, y: 0.02142089285101989d), new NpgsqlTypes.NpgsqlPoint(x: 0.4478316598736102d, y: 0.12960869106054362d), new NpgsqlTypes.NpgsqlPoint(x: 0.20105109118083153d, y: 0.6429420822392511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7588264050013288d, y: 0.5671232048616346d), new NpgsqlTypes.NpgsqlPoint(x: 0.5790677563629654d, y: 0.6202066821066927d), new NpgsqlTypes.NpgsqlPoint(x: 0.23141752804686488d, y: 0.09473400390713949d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6833969228071672d, y: 0.9531936685818292d), new NpgsqlTypes.NpgsqlPoint(x: 0.776099095196049d, y: 0.07804244040844976d), new NpgsqlTypes.NpgsqlPoint(x: 0.3718987880789736d, y: 0.9077247251836649d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21843648719109998d, y: 0.07719423978368689d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055080855108294d, y: 0.27765073070758683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9500619096720936d, y: 0.7166933091338087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.545801350123165d, y: 0.6318741619085801d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418806430912712d, y: 0.5444676999327609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631789649719723d, y: 0.8267316588833871d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3355198127639225d, y: 0.12284234073661526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175451072078078d, y: 0.4021435971425391d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091177212949382d, y: 0.6903629060114668d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9244209944154423d, y: 0.7462585042311309d), new NpgsqlTypes.NpgsqlPoint(x: 0.034045807500657554d, y: 0.757290449443899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9378421150412531d, y: 0.3862695728162625d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40855286950967884d, y: 0.7708057820154103d), new NpgsqlTypes.NpgsqlPoint(x: 0.13106921192291432d, y: 0.15804150029363284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556565258453312d, y: 0.6752220834519661d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030202631674930425d, y: 0.37671664539164595d), new NpgsqlTypes.NpgsqlPoint(x: 0.2901048483861176d, y: 0.15135227376167537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722689944267288d, y: 0.49085488179115433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5996332089634202d, y: 0.3630301946345248d), new NpgsqlTypes.NpgsqlPoint(x: 0.05469196960036504d, y: 0.08118844772851996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862167234134645d, y: 0.041677709702452104d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17683712199466817d, y: 0.13299253046661152d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576588765946741d, y: 0.8514552629545057d), new NpgsqlTypes.NpgsqlPoint(x: 0.14389518489559827d, y: 0.8116450964044964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9515302455287503d, y: 0.7154219743369394d), new NpgsqlTypes.NpgsqlPoint(x: 0.28060286529475054d, y: 0.295547156263126d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872826091411318d, y: 0.4992830199732782d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8637031706215831d, y: 0.5924764221697518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540911718494197d, y: 0.5732920139937799d), new NpgsqlTypes.NpgsqlPoint(x: 0.3542311506749075d, y: 0.0002111044190749034d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8356873032305656d, y: 0.9754763106446521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7162271978957264d, y: 0.268657960166348d), new NpgsqlTypes.NpgsqlPoint(x: 0.4519747074046727d, y: 0.2003049645093311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8628367880409066d, y: 0.7474089828651654d), new NpgsqlTypes.NpgsqlPoint(x: 0.15687975100952511d, y: 0.264563653731413d), new NpgsqlTypes.NpgsqlPoint(x: 0.22261683822355016d, y: 0.17222680524893963d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9848550812873965d, y: 0.0960770175638751d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225504031465181d, y: 0.3597080634763774d), new NpgsqlTypes.NpgsqlPoint(x: 0.08346490122029748d, y: 0.5904853423618494d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11848523833213442d, y: 0.2538665436400537d), new NpgsqlTypes.NpgsqlPoint(x: 0.253164851175838d, y: 0.41801493174359716d), new NpgsqlTypes.NpgsqlPoint(x: 0.29417295864500737d, y: 0.42750045056322594d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.918890456874722d, y: 0.8370610406000998d), new NpgsqlTypes.NpgsqlPoint(x: 0.051587051601453604d, y: 0.35571215458360617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7695724574299267d, y: 0.5349339745853077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8002501701190134d, y: 0.9890060936918054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983590244821073d, y: 0.9958617919153946d), new NpgsqlTypes.NpgsqlPoint(x: 0.17101885348993362d, y: 0.17084367761963792d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7376248991340735d, y: 0.9889548457984845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288994209140558d, y: 0.17188001972252742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825636949513824d, y: 0.9920731378799625d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44636113786827647d, y: 0.3965040648382836d), new NpgsqlTypes.NpgsqlPoint(x: 0.2372799879223928d, y: 0.7740742681633451d), new NpgsqlTypes.NpgsqlPoint(x: 0.27328491081418904d, y: 0.9151652096010722d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4162746331531102d, y: 0.7442636010171867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085401089900179d, y: 0.07769083391940668d), new NpgsqlTypes.NpgsqlPoint(x: 0.05096370347112289d, y: 0.14731073543841866d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26352499659543394d, y: 0.579376850776214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200940287065968d, y: 0.3349666081572338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8723071553770442d, y: 0.5333606393271325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9249794105861844d, y: 0.7334542311639722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8786877506856486d, y: 0.5068936800282686d), new NpgsqlTypes.NpgsqlPoint(x: 0.2280152718754822d, y: 0.8837397764200138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5086242592728597d, y: 0.3667913022099206d), new NpgsqlTypes.NpgsqlPoint(x: 0.22593987623117717d, y: 0.9803472168690783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402249609753194d, y: 0.43682047879095165d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03988501219328733d, y: 0.38895389012477155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333968528281113d, y: 0.4381068305063264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3522460601994649d, y: 0.48415325469873427d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22055184933830507d, y: 0.07385660408895167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948034413569858d, y: 0.9624000798496329d), new NpgsqlTypes.NpgsqlPoint(x: 0.05932163600590057d, y: 0.22953812350355773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08539484334626346d, y: 0.9226687553238538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279735301467503d, y: 0.009131877404385369d), new NpgsqlTypes.NpgsqlPoint(x: 0.5467315367417631d, y: 0.19371275444326796d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8610196370571547d, y: 0.9314268747877165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114967177721206d, y: 0.24286058541860023d), new NpgsqlTypes.NpgsqlPoint(x: 0.38909260853256633d, y: 0.01630547150427919d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2111123112791483d, y: 0.226511664930101d), new NpgsqlTypes.NpgsqlPoint(x: 0.1823615571067555d, y: 0.8808516486643708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884419140981585d, y: 0.6225485946213052d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0686434967658418d, y: 0.0655070466016503d), new NpgsqlTypes.NpgsqlPoint(x: 0.35243665196963003d, y: 0.03076476760636848d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070311494218293d, y: 0.6530390559303647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7287411345976367d, y: 0.878742330938418d), new NpgsqlTypes.NpgsqlPoint(x: 0.77832038613961d, y: 0.5501900505728627d), new NpgsqlTypes.NpgsqlPoint(x: 0.09710425899781117d, y: 0.4711725867118126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2518804756244851d, y: 0.6689203253241884d), new NpgsqlTypes.NpgsqlPoint(x: 0.15432773131087896d, y: 0.9703161399803155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8318867242156182d, y: 0.7567441745672275d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44761537641075244d, y: 0.985376072311625d), new NpgsqlTypes.NpgsqlPoint(x: 0.12777091277232222d, y: 0.47685590837460945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551946249575081d, y: 0.3395157704992092d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8359357687017103d, y: 0.1187000839568827d), new NpgsqlTypes.NpgsqlPoint(x: 0.48054542797857736d, y: 0.6624398382962297d), new NpgsqlTypes.NpgsqlPoint(x: 0.7119410511677735d, y: 0.28320760530163336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4058531254362481d, y: 0.5950935243024515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538653065744313d, y: 0.2472368987987772d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221929002633369d, y: 0.8545057849239892d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8866864194819595d, y: 0.4712889740817455d), new NpgsqlTypes.NpgsqlPoint(x: 0.1415844002687271d, y: 0.6452185528574559d), new NpgsqlTypes.NpgsqlPoint(x: 0.9627683455701462d, y: 0.4915505002507944d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09242730053312509d, y: 0.39369241649579867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7145875972740099d, y: 0.7605336218787407d), new NpgsqlTypes.NpgsqlPoint(x: 0.14819130376055956d, y: 0.9906144928085974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9986324456927173d, y: 0.2754213643116026d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594615445335316d, y: 0.4578106447735363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617109324719751d, y: 0.3100846483548433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6207641800659366d, y: 0.9657602901380251d), new NpgsqlTypes.NpgsqlPoint(x: 0.44211633733540256d, y: 0.6138499881389564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976897775775399d, y: 0.7924143806364354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016532018448726316d, y: 0.23888544171595605d), new NpgsqlTypes.NpgsqlPoint(x: 0.4791324882297654d, y: 0.4043318060600224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9196985532056932d, y: 0.6954117044353851d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022891170734865907d, y: 0.9650176190197965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806121303400481d, y: 0.2221040663990732d), new NpgsqlTypes.NpgsqlPoint(x: 0.18432684966063972d, y: 0.09467086050220097d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6370318571293299d, y: 0.6636631799473649d), new NpgsqlTypes.NpgsqlPoint(x: 0.20267143430454848d, y: 0.7623479024993756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7377375704959697d, y: 0.19196230256142044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10228473444650732d, y: 0.7365273633462812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3384706521995656d, y: 0.3491578376244757d), new NpgsqlTypes.NpgsqlPoint(x: 0.5216571573698976d, y: 0.8417449974314106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42725208174696616d, y: 0.09334748595841424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279067847171376d, y: 0.043383943107730194d), new NpgsqlTypes.NpgsqlPoint(x: 0.22026647024589274d, y: 0.9693292046781884d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7181300945009956d, y: 0.9243068525977542d), new NpgsqlTypes.NpgsqlPoint(x: 0.744730938834645d, y: 0.12643054715015078d), new NpgsqlTypes.NpgsqlPoint(x: 0.701918830617128d, y: 0.842766029263556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6679469000867775d, y: 0.28342152044538393d), new NpgsqlTypes.NpgsqlPoint(x: 0.009372011626197496d, y: 0.2755230932023677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407433424269494d, y: 0.3768513638642639d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20191542124264006d, y: 0.05969127705572641d), new NpgsqlTypes.NpgsqlPoint(x: 0.6400842414438126d, y: 0.7053930958229807d), new NpgsqlTypes.NpgsqlPoint(x: 0.5271459207430462d, y: 0.7403064892410577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6600373130736189d, y: 0.01908302375637183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5941335042816437d, y: 0.40995326474645377d), new NpgsqlTypes.NpgsqlPoint(x: 0.3648124302195286d, y: 0.5228074366797584d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3542196197568097d, y: 0.21090222303684414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7578638534418954d, y: 0.9579268476253058d), new NpgsqlTypes.NpgsqlPoint(x: 0.011792749251586354d, y: 0.6473751358933204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38219531592343803d, y: 0.6349991089300624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653235240739415d, y: 0.05871954118810285d), new NpgsqlTypes.NpgsqlPoint(x: 0.6333791102116187d, y: 0.6651378857407444d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.675729395575207d, y: 0.6440772413906454d), new NpgsqlTypes.NpgsqlPoint(x: 0.13665649956536496d, y: 0.03185378575782216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8676941353510871d, y: 0.08182852291461207d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6747817263228019d, y: 0.974985039093612d), new NpgsqlTypes.NpgsqlPoint(x: 0.021611020122464963d, y: 0.7487203615936608d), new NpgsqlTypes.NpgsqlPoint(x: 0.65988803693609d, y: 0.7011942599501773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01353990418026585d, y: 0.9795108336009678d), new NpgsqlTypes.NpgsqlPoint(x: 0.28761056037730703d, y: 0.7945103283655149d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156214053390792d, y: 0.19662460555949113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5016572425159607d, y: 0.5080743232450455d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102310788860105d, y: 0.09511653476314086d), new NpgsqlTypes.NpgsqlPoint(x: 0.12951591020959952d, y: 0.3998233750637108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11763179467020168d, y: 0.5240075697500056d), new NpgsqlTypes.NpgsqlPoint(x: 0.36038063745659876d, y: 0.8297378372582374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4736623766139815d, y: 0.5908739401497435d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2834805935897151d, y: 0.2777126780394641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462070473170217d, y: 0.041770588631509065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854262485478454d, y: 0.9726346274819987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.524589286186586d, y: 0.4282065719306595d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357511026721807d, y: 0.08942747814218233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800399895919593d, y: 0.10658353638400231d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8705203323158991d, y: 0.19974232224496413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8354589026391386d, y: 0.24678453432407166d), new NpgsqlTypes.NpgsqlPoint(x: 0.4946768917755372d, y: 0.4949566404425255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6130798604582147d, y: 0.1503585039646831d), new NpgsqlTypes.NpgsqlPoint(x: 0.11697931365066849d, y: 0.6419895448524695d), new NpgsqlTypes.NpgsqlPoint(x: 0.56365720067751d, y: 0.229929417936532d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16527950512222267d, y: 0.6413754179678409d), new NpgsqlTypes.NpgsqlPoint(x: 0.1311621194157332d, y: 0.7653520859813592d), new NpgsqlTypes.NpgsqlPoint(x: 0.02749976650596464d, y: 0.017233341981265804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9524285797563524d, y: 0.6928092231891714d), new NpgsqlTypes.NpgsqlPoint(x: 0.09108933521400886d, y: 0.10021465175335809d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742589984731045d, y: 0.34480219953493296d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7592154805927054d, y: 0.2989108408958715d), new NpgsqlTypes.NpgsqlPoint(x: 0.928194661521243d, y: 0.46192635145651273d), new NpgsqlTypes.NpgsqlPoint(x: 0.21424257903615773d, y: 0.4104334384832793d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26218546924642494d, y: 0.12985113624660216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331678381041187d, y: 0.9547293747342608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981259352670696d, y: 0.8856624080251451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6612309281464186d, y: 0.15111069152650614d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231401094661378d, y: 0.11751093872912022d), new NpgsqlTypes.NpgsqlPoint(x: 0.6895128193448294d, y: 0.3041868856308063d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6453091460274402d, y: 0.7277485392088107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860113012552131d, y: 0.8894982499978125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9225312242731603d, y: 0.5813124283067316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22501771280263083d, y: 0.835949018118809d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524165450744956d, y: 0.9748129819175307d), new NpgsqlTypes.NpgsqlPoint(x: 0.03566831470507836d, y: 0.7958450120276893d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8110300329401697d, y: 0.830492973094913d), new NpgsqlTypes.NpgsqlPoint(x: 0.49585074248737104d, y: 0.5629493304497037d), new NpgsqlTypes.NpgsqlPoint(x: 0.0757054014462355d, y: 0.7360245658102383d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6558895429266993d, y: 0.977554038729759d), new NpgsqlTypes.NpgsqlPoint(x: 0.10549814443327432d, y: 0.37670809528505755d), new NpgsqlTypes.NpgsqlPoint(x: 0.03350515333097459d, y: 0.9031552028918992d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9683556005805127d, y: 0.794981415962192d), new NpgsqlTypes.NpgsqlPoint(x: 0.810556795540689d, y: 0.7507166714586618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999534062082573d, y: 0.34783159809102604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34969040052880274d, y: 0.434683823092886d), new NpgsqlTypes.NpgsqlPoint(x: 0.353320497511326d, y: 0.8079523968655056d), new NpgsqlTypes.NpgsqlPoint(x: 0.9542550083364215d, y: 0.22034594794408047d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7546888323692955d, y: 0.9458910558872559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4839615276009047d, y: 0.12339123869821533d), new NpgsqlTypes.NpgsqlPoint(x: 0.01662229437165741d, y: 0.9913637745675077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6379240107575628d, y: 0.9648178148280468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4174740937344912d, y: 0.3881761730403782d), new NpgsqlTypes.NpgsqlPoint(x: 0.47548386139508947d, y: 0.5646168924170308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9685262217324951d, y: 0.30339632989975285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9924866509283189d, y: 0.007613627371836462d), new NpgsqlTypes.NpgsqlPoint(x: 0.02338285716293742d, y: 0.04731863571943107d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45956016698456514d, y: 0.9607302702356593d), new NpgsqlTypes.NpgsqlPoint(x: 0.6976633944410994d, y: 0.32612165873905985d), new NpgsqlTypes.NpgsqlPoint(x: 0.4016320247378812d, y: 0.9565144540959521d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18877098199182285d, y: 0.340382297917332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440149445595072d, y: 0.8345169504113714d), new NpgsqlTypes.NpgsqlPoint(x: 0.13686753697344634d, y: 0.5273565222045089d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06385618704344243d, y: 0.44743759339581535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9398901018334878d, y: 0.5907845755832039d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729036408305735d, y: 0.18019155543308507d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1643152803770206d, y: 0.4319183164331173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848994007192906d, y: 0.4653994295551833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4465201657845862d, y: 0.39431761063538195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2057385326493245d, y: 0.7704157221903091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4073577388243612d, y: 0.5034595291069838d), new NpgsqlTypes.NpgsqlPoint(x: 0.1870996684604398d, y: 0.776309336031135d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05103156105424622d, y: 0.5371935619013243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370810117402892d, y: 0.3123030397154911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8210319932471337d, y: 0.34934465086991384d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4943649767833843d, y: 0.009606808063289285d), new NpgsqlTypes.NpgsqlPoint(x: 0.31053567890847356d, y: 0.4517306263782914d), new NpgsqlTypes.NpgsqlPoint(x: 0.041624398206837165d, y: 0.09413643067522603d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7586485435898302d, y: 0.24239464650969123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080738529131236d, y: 0.09681427060198877d), new NpgsqlTypes.NpgsqlPoint(x: 0.4775354498542348d, y: 0.0872286927926722d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5890446077299963d, y: 0.662531378523869d), new NpgsqlTypes.NpgsqlPoint(x: 0.13745695830656857d, y: 0.20547291854959304d), new NpgsqlTypes.NpgsqlPoint(x: 0.1363718642713163d, y: 0.009418217899532899d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3451498723862716d, y: 0.9075856452901818d), new NpgsqlTypes.NpgsqlPoint(x: 0.06942935210334389d, y: 0.1242345671713404d), new NpgsqlTypes.NpgsqlPoint(x: 0.15760371312406574d, y: 0.29373295985549963d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5162585686546374d, y: 0.6798413086493718d), new NpgsqlTypes.NpgsqlPoint(x: 0.794456321632027d, y: 0.9137841039697254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633705854529339d, y: 0.8513162146778076d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7875627177201605d, y: 0.6601203865315316d), new NpgsqlTypes.NpgsqlPoint(x: 0.732808732942361d, y: 0.38190278980093884d), new NpgsqlTypes.NpgsqlPoint(x: 0.43976193989778634d, y: 0.18913833382706924d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2564430261468924d, y: 0.8159190369582898d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016009649118294d, y: 0.09209808131350805d), new NpgsqlTypes.NpgsqlPoint(x: 0.29649505533888354d, y: 0.394044916010593d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25894797897382027d, y: 0.6490352055877493d), new NpgsqlTypes.NpgsqlPoint(x: 0.41770581313006183d, y: 0.08028905494533656d), new NpgsqlTypes.NpgsqlPoint(x: 0.18492905478714683d, y: 0.8516825505274d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6328086053502058d, y: 0.432794876241939d), new NpgsqlTypes.NpgsqlPoint(x: 0.5904553687425218d, y: 0.7372637309833855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296755014778887d, y: 0.07735325773808277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3334286802462628d, y: 0.6105672806068833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6616540405085047d, y: 0.8819650679714239d), new NpgsqlTypes.NpgsqlPoint(x: 0.4493216764159409d, y: 0.9501377144549717d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31698782209284926d, y: 0.5499939180901584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777367733706512d, y: 0.11820878507899946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387423025784869d, y: 0.2909218539386491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16525234601626526d, y: 0.6002201113278625d), new NpgsqlTypes.NpgsqlPoint(x: 0.42435037209049775d, y: 0.7422593052764969d), new NpgsqlTypes.NpgsqlPoint(x: 0.38958650464398736d, y: 0.6624109147730468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01884687958884823d, y: 0.14564631224420144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3226500137505357d, y: 0.8902569387845881d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006202516446097706d, y: 0.9502552546103354d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2682765641280104d, y: 0.7396850310959961d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274450661960725d, y: 0.18844379838283476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9611956385023389d, y: 0.6090646812285587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6120914395352669d, y: 0.22569357358373776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7989970491098041d, y: 0.35623208726811806d), new NpgsqlTypes.NpgsqlPoint(x: 0.14782473605044133d, y: 0.0367257638466405d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4713767041972373d, y: 0.5988607374176715d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018763032941437885d, y: 0.6818729559269854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9803898756204725d, y: 0.42524949334015905d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7201279801155303d, y: 0.05759332225191194d), new NpgsqlTypes.NpgsqlPoint(x: 0.10485865984683629d, y: 0.7887765090783393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889489468714569d, y: 0.026250579391753903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4703831218271637d, y: 0.11783314491107044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898506893180928d, y: 0.47555201966649674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962386490165499d, y: 0.80514865106131d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32953183842456135d, y: 0.2497891956647853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084466663323135d, y: 0.8749185861320808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850163541656044d, y: 0.03377818809129185d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8865287704504796d, y: 0.9017933918004375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162043685384696d, y: 0.8014255082360344d), new NpgsqlTypes.NpgsqlPoint(x: 0.09139272894558681d, y: 0.15333568862765112d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7691750235183566d, y: 0.37217423057696986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891244324139766d, y: 0.5631390803121856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424410878929152d, y: 0.4565890733348219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5972330002546398d, y: 0.7630696231880263d), new NpgsqlTypes.NpgsqlPoint(x: 0.932722240894368d, y: 0.9298897462416386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7533658893721017d, y: 0.13791846354827575d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4167174499919888d, y: 0.024682287108453993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6084768268239676d, y: 0.9022110490377496d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977006616580645d, y: 0.7416323595649956d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7415697894392759d, y: 0.28978088773110144d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960353193759583d, y: 0.39432400430564507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024228280846467d, y: 0.7801141985261363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6296672637107874d, y: 0.03573153189703082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207104635373882d, y: 0.9024494177240763d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371005076533693d, y: 0.8243346302151614d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0015274505183213716d, y: 0.8949742786460778d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524602022607088d, y: 0.07721912060264269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432744252149818d, y: 0.4493415861562655d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.677129740497637d, y: 0.6014431761551434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942732958737209d, y: 0.8897731982840643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5771107743766615d, y: 0.9722648539203663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20939436245852827d, y: 0.14046757651346742d), new NpgsqlTypes.NpgsqlPoint(x: 0.648438391104964d, y: 0.5324531610810233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379650445863849d, y: 0.9634699318844988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3636194578864408d, y: 0.04931349408287411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3019446576189566d, y: 0.13819834078883675d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962626161433476d, y: 0.6214719680410379d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04671115383836166d, y: 0.5657001020661357d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786893769321912d, y: 0.6261298492929279d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665695027065194d, y: 0.9582387684605619d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8360369315188814d, y: 0.019098759443617386d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333168345293681d, y: 0.30140922561181727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8895636756844661d, y: 0.3120946109042134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2091013641218834d, y: 0.8139397305980415d), new NpgsqlTypes.NpgsqlPoint(x: 0.993177664348714d, y: 0.2530124907107365d), new NpgsqlTypes.NpgsqlPoint(x: 0.02944891914046832d, y: 0.2996601925647231d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5003855662909933d, y: 0.897156262189812d), new NpgsqlTypes.NpgsqlPoint(x: 0.06012815632914248d, y: 0.7053550426302386d), new NpgsqlTypes.NpgsqlPoint(x: 0.2037255697414434d, y: 0.6143957888468375d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32866916011348335d, y: 0.7422241842009646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729425793677067d, y: 0.42569994397758604d), new NpgsqlTypes.NpgsqlPoint(x: 0.31329171194221606d, y: 0.1753624915890888d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5087369346183844d, y: 0.3312978183358526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936345848455187d, y: 0.7106858575920777d), new NpgsqlTypes.NpgsqlPoint(x: 0.34916942402907514d, y: 0.5736211495251322d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10532627860080046d, y: 0.7924149013977586d), new NpgsqlTypes.NpgsqlPoint(x: 0.930212099083926d, y: 0.09835389811023532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5590030345784467d, y: 0.7002271639564481d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2110535649564632d, y: 0.755683099209638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243271879672943d, y: 0.9081820199596923d), new NpgsqlTypes.NpgsqlPoint(x: 0.14589336894195593d, y: 0.38027887362679624d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334191315794103d, y: 0.8495474260270494d), new NpgsqlTypes.NpgsqlPoint(x: 0.26264881816752894d, y: 0.9135099599607627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9730490567524386d, y: 0.05455185748397595d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31058657260104916d, y: 0.27641222786584707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744453471099156d, y: 0.571890649964881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313303940527081d, y: 0.006537305958521533d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7614786564481566d, y: 0.2362469530172252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8110191731286538d, y: 0.5496701609717075d), new NpgsqlTypes.NpgsqlPoint(x: 0.5447339054362802d, y: 0.4593061321961823d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9337160737200172d, y: 0.9198746219860167d), new NpgsqlTypes.NpgsqlPoint(x: 0.5389924109595908d, y: 0.49914750845743205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6672866677013315d, y: 0.9247443055869847d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0103365615481682d, y: 0.8119396870741982d), new NpgsqlTypes.NpgsqlPoint(x: 0.3225282945969211d, y: 0.6409722991681965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554831215918404d, y: 0.29950966570576043d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05753058901743635d, y: 0.7013271656590851d), new NpgsqlTypes.NpgsqlPoint(x: 0.6813580456380918d, y: 0.8415985190833455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5241207706732515d, y: 0.9609350991430707d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2585529287036874d, y: 0.5990685052358257d), new NpgsqlTypes.NpgsqlPoint(x: 0.2488112017219397d, y: 0.39292819371717336d), new NpgsqlTypes.NpgsqlPoint(x: 0.1240401309453224d, y: 0.6811677015018408d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9718530812809921d, y: 0.7885748360126765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176464357638743d, y: 0.4942412608877078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8283010635077841d, y: 0.7414531460856411d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8270120887577368d, y: 0.7330110946816172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8620252994823691d, y: 0.6546913121322275d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984518537049512d, y: 0.5419884053357183d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2978046592475291d, y: 0.3546905943510624d), new NpgsqlTypes.NpgsqlPoint(x: 0.24801834273898504d, y: 0.6975592173869631d), new NpgsqlTypes.NpgsqlPoint(x: 0.06631333307375653d, y: 0.7077180608261788d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8810976669708989d, y: 0.5480760861785092d), new NpgsqlTypes.NpgsqlPoint(x: 0.04600459909500032d, y: 0.13358389811202942d), new NpgsqlTypes.NpgsqlPoint(x: 0.6193328257104048d, y: 0.3991430320415752d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6554427724169505d, y: 0.007074815740749529d), new NpgsqlTypes.NpgsqlPoint(x: 0.09243564926708725d, y: 0.9048661806159132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021440352866603d, y: 0.7372408440176349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8241722106347317d, y: 0.9353661491956083d), new NpgsqlTypes.NpgsqlPoint(x: 0.1514088744226273d, y: 0.3745316049933679d), new NpgsqlTypes.NpgsqlPoint(x: 0.437400819041587d, y: 0.8146927362896195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7598227394894524d, y: 0.17706451331601347d), new NpgsqlTypes.NpgsqlPoint(x: 0.50665621559609d, y: 0.8252856271981132d), new NpgsqlTypes.NpgsqlPoint(x: 0.750285965471197d, y: 0.9289035514638418d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7310267772745644d, y: 0.03441115039480247d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531582573963192d, y: 0.7922471262616906d), new NpgsqlTypes.NpgsqlPoint(x: 0.268562832737429d, y: 0.015351255312100687d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6056930522695746d, y: 0.8336979379485716d), new NpgsqlTypes.NpgsqlPoint(x: 0.48395304901626235d, y: 0.6771105567178014d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518672962022669d, y: 0.3500730860975034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9785586223848299d, y: 0.13799256803200521d), new NpgsqlTypes.NpgsqlPoint(x: 0.499681536683957d, y: 0.6500226835022217d), new NpgsqlTypes.NpgsqlPoint(x: 0.31294112348710046d, y: 0.9707233997107289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05551708645743236d, y: 0.7177376711708723d), new NpgsqlTypes.NpgsqlPoint(x: 0.49140319785560826d, y: 0.19323817837258705d), new NpgsqlTypes.NpgsqlPoint(x: 0.09176997761343553d, y: 0.4178545166816303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7465073529925567d, y: 0.13799427896223593d), new NpgsqlTypes.NpgsqlPoint(x: 0.47240261393808347d, y: 0.2378750940303197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024547142114105d, y: 0.9805156595705105d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7676744622555177d, y: 0.6101724739175042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6272976999944513d, y: 0.09246412350522715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868253819740259d, y: 0.7088181865876327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22669865549098744d, y: 0.4794708465231804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5925470618706192d, y: 0.9703932640733424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957376939609363d, y: 0.12114754345914958d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9175155867839977d, y: 0.2919601627035525d), new NpgsqlTypes.NpgsqlPoint(x: 0.08891435606930298d, y: 0.796536610378355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467276367111076d, y: 0.6359625257113523d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13281856157696548d, y: 0.5207544115460829d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777802179195124d, y: 0.5188941914867706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646092208013683d, y: 0.4732515899183941d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.476693606441827d, y: 0.6930579253183181d), new NpgsqlTypes.NpgsqlPoint(x: 0.2735528170167929d, y: 0.27292715462980255d), new NpgsqlTypes.NpgsqlPoint(x: 0.046140927511157837d, y: 0.7455067064645213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045183379595301276d, y: 0.17637638318848425d), new NpgsqlTypes.NpgsqlPoint(x: 0.32642621586590925d, y: 0.159367871500101d), new NpgsqlTypes.NpgsqlPoint(x: 0.2263875383080156d, y: 0.23535318613685696d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2703898355759221d, y: 0.9822363946452265d), new NpgsqlTypes.NpgsqlPoint(x: 0.38019111873907885d, y: 0.7270826642685208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6659204128683449d, y: 0.9103563408896479d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35641375077799853d, y: 0.23752753801382376d), new NpgsqlTypes.NpgsqlPoint(x: 0.3948819039115712d, y: 0.5793282073557915d), new NpgsqlTypes.NpgsqlPoint(x: 0.3893669180178022d, y: 0.603410260944632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08829411750418337d, y: 0.37190815374816955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899362984222168d, y: 0.7653186676832942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530143422629246d, y: 0.1530370270197251d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3119846012100437d, y: 0.34473758229024754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920235575754977d, y: 0.8164757944732448d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499998001903501d, y: 0.057927770105652865d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48111702546952984d, y: 0.9413396511718013d), new NpgsqlTypes.NpgsqlPoint(x: 0.520331547730779d, y: 0.5428166025022403d), new NpgsqlTypes.NpgsqlPoint(x: 0.2995210860917601d, y: 0.10035863747282281d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23203184073361738d, y: 0.1312050489206773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166467850663692d, y: 0.21426109200888788d), new NpgsqlTypes.NpgsqlPoint(x: 0.020858634874140414d, y: 0.8404807029091009d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39997545329098816d, y: 0.8610307891357456d), new NpgsqlTypes.NpgsqlPoint(x: 0.07410169431265068d, y: 0.544896876229696d), new NpgsqlTypes.NpgsqlPoint(x: 0.5012237304646718d, y: 0.612678967716781d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6305265485364d, y: 0.5500062559374533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023879833972715d, y: 0.05113695951953734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6630001656397406d, y: 0.7610598222650572d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04290504152539576d, y: 0.5547847584434802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17673419369461307d, y: 0.34874384088485955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9437289933029583d, y: 0.1741738665913033d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3942004103443665d, y: 0.7243387725634751d), new NpgsqlTypes.NpgsqlPoint(x: 0.29062799583865206d, y: 0.4589154941750365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088735577978593d, y: 0.6995712686016382d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23683773070686565d, y: 0.9363231512233191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626982721054238d, y: 0.58511549309862d), new NpgsqlTypes.NpgsqlPoint(x: 0.5427594829434793d, y: 0.8750577489517033d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02405303468889297d, y: 0.9195012826586639d), new NpgsqlTypes.NpgsqlPoint(x: 0.08080902568244486d, y: 0.5542024169807905d), new NpgsqlTypes.NpgsqlPoint(x: 0.13025465436318773d, y: 0.10553142892158096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9123071639889129d, y: 0.8391851438845254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826724492545085d, y: 0.04062627638445404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641847512825035d, y: 0.06326462437652203d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2956905933916193d, y: 0.8334063549387924d), new NpgsqlTypes.NpgsqlPoint(x: 0.722300603970516d, y: 0.4120016002081912d), new NpgsqlTypes.NpgsqlPoint(x: 0.011257068774438994d, y: 0.41842046661339627d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26599755795696656d, y: 0.08079980562027311d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442001226119388d, y: 0.47421674710631556d), new NpgsqlTypes.NpgsqlPoint(x: 0.08049891196183989d, y: 0.17544333650926414d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9248733417360493d, y: 0.7128550052655953d), new NpgsqlTypes.NpgsqlPoint(x: 0.13503017637021952d, y: 0.6619341321194496d), new NpgsqlTypes.NpgsqlPoint(x: 0.30730705359796806d, y: 0.9144262903703373d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.942577031096919d, y: 0.8881496713999157d), new NpgsqlTypes.NpgsqlPoint(x: 0.49627679040892314d, y: 0.9484983534980509d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927791332437884d, y: 0.17789859313445877d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.887511661253214d, y: 0.5449647003208696d), new NpgsqlTypes.NpgsqlPoint(x: 0.46537997822900334d, y: 0.1888006368379771d), new NpgsqlTypes.NpgsqlPoint(x: 0.4256701081803448d, y: 0.6485475182257688d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20525068532197743d, y: 0.9959640078957864d), new NpgsqlTypes.NpgsqlPoint(x: 0.2483939911273475d, y: 0.38353580427451994d), new NpgsqlTypes.NpgsqlPoint(x: 0.05959370031689082d, y: 0.6967945759413454d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9166815288646378d, y: 0.7674866769804124d), new NpgsqlTypes.NpgsqlPoint(x: 0.112841517980102d, y: 0.9078347405347891d), new NpgsqlTypes.NpgsqlPoint(x: 0.43796731227186925d, y: 0.5558790098581782d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10282217389256432d, y: 0.13874668352794828d), new NpgsqlTypes.NpgsqlPoint(x: 0.5375271907096475d, y: 0.9633290299228771d), new NpgsqlTypes.NpgsqlPoint(x: 0.4229757589147568d, y: 0.4089219267170032d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8595265450576733d, y: 0.3007383531235279d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600174783072053d, y: 0.9335890129417391d), new NpgsqlTypes.NpgsqlPoint(x: 0.361046750220107d, y: 0.3769810539112096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.652552855466269d, y: 0.1481572447128765d), new NpgsqlTypes.NpgsqlPoint(x: 0.4391878282359314d, y: 0.5229748282019392d), new NpgsqlTypes.NpgsqlPoint(x: 0.22734729347801264d, y: 0.9521358885574726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3052393781238467d, y: 0.5668341570949216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7650285646707452d, y: 0.6006387140288125d), new NpgsqlTypes.NpgsqlPoint(x: 0.8985363384553713d, y: 0.42526077727094647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06392115033573498d, y: 0.5909647636977549d), new NpgsqlTypes.NpgsqlPoint(x: 0.4012545582309355d, y: 0.8073782339359237d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962955074694013d, y: 0.12930329560123544d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.242750064236404d, y: 0.34291297272281807d), new NpgsqlTypes.NpgsqlPoint(x: 0.42938434548829063d, y: 0.6517380663635918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520928904398472d, y: 0.33902697885378685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5818092462194977d, y: 0.9603070570466054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8593457925740803d, y: 0.8160583486732025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7712728656253667d, y: 0.9899222980515213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9398848379580144d, y: 0.9842847301464829d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617891992803011d, y: 0.8843195192638799d), new NpgsqlTypes.NpgsqlPoint(x: 0.494878898324862d, y: 0.42231963709940357d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0585211845100756d, y: 0.23460896942500642d), new NpgsqlTypes.NpgsqlPoint(x: 0.13592740489110067d, y: 0.8980874501579799d), new NpgsqlTypes.NpgsqlPoint(x: 0.8160795210760661d, y: 0.24357249694189353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057828219410058335d, y: 0.08762313982217407d), new NpgsqlTypes.NpgsqlPoint(x: 0.03141050330846429d, y: 0.2300542490112405d), new NpgsqlTypes.NpgsqlPoint(x: 0.19069159001052405d, y: 0.8201619917355129d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1757226563500527d, y: 0.20056767036497214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810055187191207d, y: 0.45871624942642664d), new NpgsqlTypes.NpgsqlPoint(x: 0.18679066720744664d, y: 0.9620256074819117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06538607532337581d, y: 0.014519820124215488d), new NpgsqlTypes.NpgsqlPoint(x: 0.5597276072383172d, y: 0.1849967478610134d), new NpgsqlTypes.NpgsqlPoint(x: 0.22007513580708504d, y: 0.20086222703489431d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5292256864396184d, y: 0.4558497567320514d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201567571431388d, y: 0.930613548942166d), new NpgsqlTypes.NpgsqlPoint(x: 0.05007223553437157d, y: 0.7384467030888686d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6720013423579838d, y: 0.7435827971964633d), new NpgsqlTypes.NpgsqlPoint(x: 0.39272138670660184d, y: 0.41148282722813345d), new NpgsqlTypes.NpgsqlPoint(x: 0.286132772764635d, y: 0.7674303794326424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5109374528852688d, y: 0.021326847740486432d), new NpgsqlTypes.NpgsqlPoint(x: 0.0047914060957818805d, y: 0.0650298993638474d), new NpgsqlTypes.NpgsqlPoint(x: 0.13586841212706002d, y: 0.34665055703758585d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8551604445801156d, y: 0.291560530225787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9296157544016617d, y: 0.7934221862122179d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201015126333121d, y: 0.7558102616752546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6102719540368233d, y: 0.3452894108431711d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542351763176983d, y: 0.2188500216501894d), new NpgsqlTypes.NpgsqlPoint(x: 0.24730488345658608d, y: 0.4261133144880944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8483136172737765d, y: 0.8982639563910108d), new NpgsqlTypes.NpgsqlPoint(x: 0.42677679169461424d, y: 0.3405569689052663d), new NpgsqlTypes.NpgsqlPoint(x: 0.17920122857792076d, y: 0.5645897887405247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6413616823911807d, y: 0.310599898933698d), new NpgsqlTypes.NpgsqlPoint(x: 0.36955607669447654d, y: 0.15140801161189876d), new NpgsqlTypes.NpgsqlPoint(x: 0.014931977974442012d, y: 0.8406857477605765d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8955897990489354d, y: 0.2660695362335066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613100194551698d, y: 0.4564812290760927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804447500216297d, y: 0.1099873473986881d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32450267818487044d, y: 0.8920299841770205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934421441502387d, y: 0.48164911088250684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905184442461066d, y: 0.07099491983478956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8088047366268597d, y: 0.1767336917710619d), new NpgsqlTypes.NpgsqlPoint(x: 0.2126981519759067d, y: 0.24411117257235904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7297977044870416d, y: 0.166667865127483d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4290600739395962d, y: 0.8856702710342724d), new NpgsqlTypes.NpgsqlPoint(x: 0.2503846802007794d, y: 0.0004941709267183292d), new NpgsqlTypes.NpgsqlPoint(x: 0.844267898188356d, y: 0.12112140462086929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4358202695155684d, y: 0.9482528482427726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807263067260066d, y: 0.1978442568157115d), new NpgsqlTypes.NpgsqlPoint(x: 0.1105637334052012d, y: 0.3268579786725727d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8055722674055035d, y: 0.35550001984139645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9683728778916985d, y: 0.8538693171345408d), new NpgsqlTypes.NpgsqlPoint(x: 0.758991291093046d, y: 0.14340385903590147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7979447028742694d, y: 0.18646947066045094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348117432511786d, y: 0.03852940219337364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547166031744324d, y: 0.8595861448626521d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8874640331324202d, y: 0.5557486613672524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853370033555629d, y: 0.635409976601093d), new NpgsqlTypes.NpgsqlPoint(x: 0.3406086936409858d, y: 0.7171774877892017d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3489183465346759d, y: 0.7048570619678783d), new NpgsqlTypes.NpgsqlPoint(x: 0.21778988368521268d, y: 0.3413894212789502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7090056586493266d, y: 0.8231258251503588d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4389514387349306d, y: 0.4581678869400406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8817533413027584d, y: 0.5942613447922999d), new NpgsqlTypes.NpgsqlPoint(x: 0.777111142759538d, y: 0.9411327125626388d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03310573192187094d, y: 0.009723105856957903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036875969906557d, y: 0.19120841675248068d), new NpgsqlTypes.NpgsqlPoint(x: 0.21065591384289817d, y: 0.07621760592508009d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.035844288799711466d, y: 0.8429469231099741d), new NpgsqlTypes.NpgsqlPoint(x: 0.089256640919405d, y: 0.35396227231936495d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518583524416462d, y: 0.966258613429449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7895217065047676d, y: 0.08977676249830657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923577175474955d, y: 0.7251155178239277d), new NpgsqlTypes.NpgsqlPoint(x: 0.1324893491360406d, y: 0.5615819857029736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012320246272720325d, y: 0.5165014311512989d), new NpgsqlTypes.NpgsqlPoint(x: 0.8714536950205557d, y: 0.46552649950899194d), new NpgsqlTypes.NpgsqlPoint(x: 0.653152088581061d, y: 0.804964264382486d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8298550250221907d, y: 0.7471936534814979d), new NpgsqlTypes.NpgsqlPoint(x: 0.05354647232926646d, y: 0.2848540062078d), new NpgsqlTypes.NpgsqlPoint(x: 0.07414788332964095d, y: 0.7944003123931626d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5041580272914706d, y: 0.2364304100483785d), new NpgsqlTypes.NpgsqlPoint(x: 0.30593188071998056d, y: 0.2209601743197661d), new NpgsqlTypes.NpgsqlPoint(x: 0.47041980362730773d, y: 0.12133099614535103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.798409462677873d, y: 0.3150680885676441d), new NpgsqlTypes.NpgsqlPoint(x: 0.42242029059697683d, y: 0.6518290350518388d), new NpgsqlTypes.NpgsqlPoint(x: 0.09119117925861853d, y: 0.10411554720994254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5792146815933862d, y: 0.21059522778829842d), new NpgsqlTypes.NpgsqlPoint(x: 0.3952986815493823d, y: 0.9447041474141913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8574443355570794d, y: 0.6472032891227147d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3761901277461591d, y: 0.33599946971447325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063062166209365d, y: 0.08768659266201739d), new NpgsqlTypes.NpgsqlPoint(x: 0.4609487447677052d, y: 0.965140967212553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11633281963219799d, y: 0.7439470961100211d), new NpgsqlTypes.NpgsqlPoint(x: 0.5030828966991089d, y: 0.14008700919916783d), new NpgsqlTypes.NpgsqlPoint(x: 0.436394906709509d, y: 0.6246100814338735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.601809320554103d, y: 0.37762809553773946d), new NpgsqlTypes.NpgsqlPoint(x: 0.012574046785941873d, y: 0.5816073256884554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456936778620492d, y: 0.6316242533608798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4480587944567601d, y: 0.6782737880316453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6329257557219476d, y: 0.1321860641407444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5900216617827765d, y: 0.5340393431582574d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6845842200466336d, y: 0.7114110914529168d), new NpgsqlTypes.NpgsqlPoint(x: 0.0695096083565031d, y: 0.7851961484013169d), new NpgsqlTypes.NpgsqlPoint(x: 0.24246195053724906d, y: 0.18433466627084893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5424883621490681d, y: 0.9246651422837326d), new NpgsqlTypes.NpgsqlPoint(x: 0.3919949342249214d, y: 0.11730355791097646d), new NpgsqlTypes.NpgsqlPoint(x: 0.04491051674133195d, y: 0.3689480980359596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884424799503697d, y: 0.022365741554661422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342723642359496d, y: 0.5233395500963595d), new NpgsqlTypes.NpgsqlPoint(x: 0.36983203222014605d, y: 0.6188734465289403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6078468304075157d, y: 0.8927321232092812d), new NpgsqlTypes.NpgsqlPoint(x: 0.638692783786075d, y: 0.30126924311991676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974826548529043d, y: 0.9258346694217763d)),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17683712199466817d, y: 0.13299253046661152d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576588765946741d, y: 0.8514552629545057d), new NpgsqlTypes.NpgsqlPoint(x: 0.14389518489559827d, y: 0.8116450964044964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9515302455287503d, y: 0.7154219743369394d), new NpgsqlTypes.NpgsqlPoint(x: 0.28060286529475054d, y: 0.295547156263126d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872826091411318d, y: 0.4992830199732782d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8637031706215831d, y: 0.5924764221697518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540911718494197d, y: 0.5732920139937799d), new NpgsqlTypes.NpgsqlPoint(x: 0.3542311506749075d, y: 0.0002111044190749034d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26352499659543394d, y: 0.579376850776214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200940287065968d, y: 0.3349666081572338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8723071553770442d, y: 0.5333606393271325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9249794105861844d, y: 0.7334542311639722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8786877506856486d, y: 0.5068936800282686d), new NpgsqlTypes.NpgsqlPoint(x: 0.2280152718754822d, y: 0.8837397764200138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5086242592728597d, y: 0.3667913022099206d), new NpgsqlTypes.NpgsqlPoint(x: 0.22593987623117717d, y: 0.9803472168690783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402249609753194d, y: 0.43682047879095165d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03988501219328733d, y: 0.38895389012477155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333968528281113d, y: 0.4381068305063264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3522460601994649d, y: 0.48415325469873427d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09242730053312509d, y: 0.39369241649579867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7145875972740099d, y: 0.7605336218787407d), new NpgsqlTypes.NpgsqlPoint(x: 0.14819130376055956d, y: 0.9906144928085974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9986324456927173d, y: 0.2754213643116026d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594615445335316d, y: 0.4578106447735363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617109324719751d, y: 0.3100846483548433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6207641800659366d, y: 0.9657602901380251d), new NpgsqlTypes.NpgsqlPoint(x: 0.44211633733540256d, y: 0.6138499881389564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976897775775399d, y: 0.7924143806364354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016532018448726316d, y: 0.23888544171595605d), new NpgsqlTypes.NpgsqlPoint(x: 0.4791324882297654d, y: 0.4043318060600224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9196985532056932d, y: 0.6954117044353851d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8110300329401697d, y: 0.830492973094913d), new NpgsqlTypes.NpgsqlPoint(x: 0.49585074248737104d, y: 0.5629493304497037d), new NpgsqlTypes.NpgsqlPoint(x: 0.0757054014462355d, y: 0.7360245658102383d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6558895429266993d, y: 0.977554038729759d), new NpgsqlTypes.NpgsqlPoint(x: 0.10549814443327432d, y: 0.37670809528505755d), new NpgsqlTypes.NpgsqlPoint(x: 0.03350515333097459d, y: 0.9031552028918992d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9683556005805127d, y: 0.794981415962192d), new NpgsqlTypes.NpgsqlPoint(x: 0.810556795540689d, y: 0.7507166714586618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999534062082573d, y: 0.34783159809102604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34969040052880274d, y: 0.434683823092886d), new NpgsqlTypes.NpgsqlPoint(x: 0.353320497511326d, y: 0.8079523968655056d), new NpgsqlTypes.NpgsqlPoint(x: 0.9542550083364215d, y: 0.22034594794408047d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[30], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 108, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 69, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 28, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 4, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 57, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[30], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[30], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 25, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 60, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

