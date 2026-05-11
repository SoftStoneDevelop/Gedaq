

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
    internal partial interface INpgsqlCircleMArraycircleMMArrayD3
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMMArrayD3 : INpgsqlCircleMArraycircleMMArrayD3
    {


#region TestData

        private readonly NpgsqlCirclecircleMMArrayD3E1M[] _testData = new NpgsqlCirclecircleMMArrayD3E1M[]
        {
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07885875828009259d, y: 0.7501882141232596d), radius: 0.8974430410076898d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16934394464054914d, y: 0.32889111027685347d), radius: 0.44002664030124283d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22527135654011132d, y: 0.5377324038270214d), radius: 0.6699509594214568d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29781933596737875d, y: 0.03890644994651782d), radius: 0.2236185496923786d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7601710156665666d, y: 0.9512385309630909d), radius: 0.011842977080118278d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8087401459381739d, y: 0.7122522749244795d), radius: 0.33878495530226704d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13303443791142966d, y: 0.16412166488864932d), radius: 0.1136336748831348d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42653675423696624d, y: 0.8376183599134096d), radius: 0.1380304540342907d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4475151934525703d, y: 0.6404872660056307d), radius: 0.23644892504567538d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8657267369593231d, y: 0.6390773443025005d), radius: 0.8604146515018758d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6786556132791607d, y: 0.3292079576925896d), radius: 0.37749208722519223d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7466955159086063d, y: 0.7949156419916771d), radius: 0.3621436034805454d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32289243975557613d, y: 0.48713290927738495d), radius: 0.1745720782277238d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9908468775687321d, y: 0.8709175977187545d), radius: 0.30149886274742166d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2936117078377485d, y: 0.8657175194847664d), radius: 0.7627451828851921d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05700031517563786d, y: 0.9041161322153138d), radius: 0.3709242794193882d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8158827948432877d, y: 0.3851656914369759d), radius: 0.02885804406017123d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25032659720756045d, y: 0.9490716265003919d), radius: 0.9267150524974886d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1531417691095489d, y: 0.7324529428091163d), radius: 0.49180690223942236d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21945255238435502d, y: 0.4752384052115066d), radius: 0.48492787105791424d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8733245856623534d, y: 0.9483261266479049d), radius: 0.46531478509885227d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.397593252617352d, y: 0.1997736587489629d), radius: 0.20033895731573947d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24705058868945473d, y: 0.1866058775871725d), radius: 0.002808544208568131d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4270913317296021d, y: 0.2109220877329544d), radius: 0.9274185045637657d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6521601171614482d, y: 0.7910039806846696d), radius: 0.9973912674687049d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27497496811871847d, y: 0.4226321005129703d), radius: 0.5991501691133886d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6797569755068252d, y: 0.5067103293102244d), radius: 0.9976623390026591d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7301803756565154d, y: 0.7325567101299547d), radius: 0.43310421324172044d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8368936597574201d, y: 0.9824449218004293d), radius: 0.47905607923075866d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.97276242045268d, y: 0.16774399131635054d), radius: 0.6668175348345166d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9731016394687187d, y: 0.009329060607598638d), radius: 0.7375442019014687d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30135324053151247d, y: 0.8114772790270687d), radius: 0.451891812562087d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4176852466287486d, y: 0.10491865055192784d), radius: 0.18126706782278812d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4777921495573121d, y: 0.6307321480463733d), radius: 0.7107485938851711d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4998919345510592d, y: 0.617624444106073d), radius: 0.931199314251544d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6018103250239595d, y: 0.10335580245461451d), radius: 0.21032643317317545d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6201009472916816d, y: 0.07205467639685859d), radius: 0.173345172315708d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6309726219302344d, y: 0.6883109133072892d), radius: 0.18517949551549417d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8001000204959349d, y: 0.305876264425162d), radius: 0.7010470388271667d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8042509727462653d, y: 0.6605102350878733d), radius: 0.20783766644042956d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2482318994067526d, y: 0.08607506447154278d), radius: 0.7246803414994386d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9520833843495898d, y: 0.6755641034732995d), radius: 0.6381390618144833d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.037559451235544605d, y: 0.7589816888710414d), radius: 0.8348942744023171d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5286077745515911d, y: 0.514935984755275d), radius: 0.6474872142543212d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5087729509202444d, y: 0.6774008206007884d), radius: 0.44088917547399686d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.753959440996316d, y: 0.38526975396527297d), radius: 0.8327168565263482d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14954480112133794d, y: 0.9585094704286229d), radius: 0.014016170286987872d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3246672205764305d, y: 0.6305139288578445d), radius: 0.4543022520635728d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.705186110930161d, y: 0.7578433939279057d), radius: 0.24851633975473064d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6588803390693109d, y: 0.5409487242827588d), radius: 0.6623818873987187d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.037431803449847534d, y: 0.4661762168762126d), radius: 0.3903255398974598d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10323979992080856d, y: 0.834207279897066d), radius: 0.4377791715764713d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9334902821978099d, y: 0.8833878074644246d), radius: 0.09916419288902367d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.991969120833318d, y: 0.7937026016095241d), radius: 0.551831320141788d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7483306086353133d, y: 0.4658238347899806d), radius: 0.3909602202354515d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39772409908142214d, y: 0.5065525387810484d), radius: 0.11156744540713626d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7735257799268984d, y: 0.6745139126052494d), radius: 0.035074879249955004d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.983070835015112d, y: 0.984664877653626d), radius: 0.8969928326046049d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05936301390867238d, y: 0.5003439053085784d), radius: 0.330398997518478d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6617650793657676d, y: 0.503226603533259d), radius: 0.37094436820100285d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7869296405092217d, y: 0.808499078062203d), radius: 0.5712558779175636d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5361145699321248d, y: 0.12542704786346037d), radius: 0.03938293214512867d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.492841955732648d, y: 0.6876465874130615d), radius: 0.6139411124972294d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.300626638069464d, y: 0.5715244950879683d), radius: 0.5560248984116329d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33041227413710783d, y: 0.8616096331640781d), radius: 0.009882867240018745d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6240420639189685d, y: 0.32015260346033314d), radius: 0.8634145495662358d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39308687655809416d, y: 0.6475897244966473d), radius: 0.8288533213267653d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6708904370211871d, y: 0.5073350419823293d), radius: 0.7916785430197558d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.251155114610492d, y: 0.19021298210541326d), radius: 0.8380695069903844d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7565654955942566d, y: 0.686911060837924d), radius: 0.6645420232426417d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8913130061487776d, y: 0.3121367814006495d), radius: 0.8553664275838214d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2872622576806524d, y: 0.6215328781677917d), radius: 0.3725471924554069d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5921669758013869d, y: 0.7632825586774191d), radius: 0.5983486619265049d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2750435623332387d, y: 0.4871306978912946d), radius: 0.8235729760061733d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6571616793501067d, y: 0.7832402221652021d), radius: 0.5936010089837241d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11389288950461862d, y: 0.6977477997038963d), radius: 0.435368874290323d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47953377396619346d, y: 0.13307822773391742d), radius: 0.9602658624132127d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9442415349704266d, y: 0.347201252531816d), radius: 0.8411568018824189d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.881901064222385d, y: 0.9571630127211448d), radius: 0.31924743843406234d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11036813892012465d, y: 0.7655254908021487d), radius: 0.7512064232977955d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8181339194178023d, y: 0.5019821899680501d), radius: 0.9242092303782733d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26478017105447504d, y: 0.25714870229919917d), radius: 0.48868422761419383d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48929369197175543d, y: 0.5640391370006452d), radius: 0.3698767716462855d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12212457952945088d, y: 0.6583587296309833d), radius: 0.5493577038521607d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.619961032275722d, y: 0.6760118411431607d), radius: 0.9092463884994705d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11309687856615114d, y: 0.2652163030466643d), radius: 0.221839114105293d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7282380366138772d, y: 0.29439462699607377d), radius: 0.5216751310013445d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.965023035757302d, y: 0.6479275983161258d), radius: 0.4766916017637274d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5690449952599971d, y: 0.030935932520130383d), radius: 0.6705090721014139d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9875407545288741d, y: 0.5319083649215688d), radius: 0.6772181288084125d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39636094074267547d, y: 0.27490474072792104d), radius: 0.7697548981248982d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7685122716668576d, y: 0.23808705523749285d), radius: 0.6220401088433869d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23929860358028487d, y: 0.6545017343739736d), radius: 0.6535292565190259d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7379522231858134d, y: 0.6193313010391442d), radius: 0.39544629625288197d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4771813288721576d, y: 0.6665672798061906d), radius: 0.8582148708414822d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5502241206487627d, y: 0.7189385334765145d), radius: 0.42673109424422917d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4405695671436136d, y: 0.28104348001010004d), radius: 0.08597645288634892d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05104752874773788d, y: 0.20843854010443985d), radius: 0.5294980485122879d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09195281747740558d, y: 0.7905732759416927d), radius: 0.43610501071310837d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9070821738924442d, y: 0.15035938032500284d), radius: 0.8887209500710509d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9210529378701485d, y: 0.4336180594758011d), radius: 0.9030708968948415d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11257711991052899d, y: 0.8796171418480925d), radius: 0.22882597863414367d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41321746529080683d, y: 0.4390689059621222d), radius: 0.05839800958111885d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7024848427288835d, y: 0.5027919341098124d), radius: 0.31772318853993087d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9350643833363323d, y: 0.9594605372913174d), radius: 0.4237949445840137d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08047309171606298d, y: 0.8677574282560665d), radius: 0.6841324741555269d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.591535901823754d, y: 0.9303258444175848d), radius: 0.2362030975304127d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07704671851880951d, y: 0.6654786774063722d), radius: 0.2540771269249428d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.659138012980836d, y: 0.26313431492972883d), radius: 0.21943720760754748d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9262028404794832d, y: 0.5421383375734088d), radius: 0.6991907185058661d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11009777592249981d, y: 0.6583755928891544d), radius: 0.44942224432035294d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29138464410463305d, y: 0.9127404261494431d), radius: 0.4693250836443269d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.308620447076836d, y: 0.27635887244806245d), radius: 0.2813957635836941d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3210305974962063d, y: 0.5032353269649003d), radius: 0.4018972714018232d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29568558960956637d, y: 0.5951521022930812d), radius: 0.5134122573038606d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18972780141093315d, y: 0.4390704501838142d), radius: 0.42766687012574034d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3541227854531306d, y: 0.3010276486730643d), radius: 0.01977925013209747d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3326619629730192d, y: 0.6906318833828162d), radius: 0.8177339677315479d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2201004769336523d, y: 0.4870729494274936d), radius: 0.9329182259197244d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9584855158123291d, y: 0.7018104070756911d), radius: 0.6576521235783959d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12784560586085336d, y: 0.45896072792794773d), radius: 0.7109639913852583d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3811616803461605d, y: 0.11467104125107341d), radius: 0.474996691579626d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.978903951441491d, y: 0.05065759948253423d), radius: 0.16705723179995113d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33847687208893085d, y: 0.3514069174792457d), radius: 0.4824785460382045d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3240290054248701d, y: 0.5316945988936459d), radius: 0.3461996525707489d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1557108975964938d, y: 0.31790631443844586d), radius: 0.9357897735584652d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08279612181593221d, y: 0.28840117517259745d), radius: 0.24585866815189616d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5039936958691413d, y: 0.906276038629466d), radius: 0.6069630933934757d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14893899392005128d, y: 0.16666768687206224d), radius: 0.0773437282105871d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4398983566775345d, y: 0.7019265011199911d), radius: 0.915569041020458d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6366047110502111d, y: 0.9785915896096529d), radius: 0.048223402846999d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6077721976493597d, y: 0.9323887092910277d), radius: 0.34878050997463417d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7184710394618067d, y: 0.6558681114120972d), radius: 0.7032470169331249d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09742447820584244d, y: 0.003804009225712668d), radius: 0.6445193096127262d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.714297385442034d, y: 0.2023057634831812d), radius: 0.13713448642546655d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44520501878719776d, y: 0.2050622441256511d), radius: 0.9380266201523646d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.520049637078213d, y: 0.8598639692741525d), radius: 0.8153603054479999d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34342561206932165d, y: 0.6345196993260334d), radius: 0.7339667467597485d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0068804319450359586d, y: 0.7764910892717417d), radius: 0.2899006957739637d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6049324453254051d, y: 0.2087319648319812d), radius: 0.00037827390260336546d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22086129733228155d, y: 0.15498668869331855d), radius: 0.879387134242105d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4166102047634187d, y: 0.674837475556963d), radius: 0.6920541053798211d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06922836397120835d, y: 0.7862060197074591d), radius: 0.3771188547318739d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.754502322832612d, y: 0.24882606523774298d), radius: 0.27095737331968717d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.744772340016856d, y: 0.9059374415830115d), radius: 0.7451927542394855d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38058753446741245d, y: 0.4056858188090897d), radius: 0.45960818089443745d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10976546315411151d, y: 0.8883517815369976d), radius: 0.35136499489192563d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.142159597896668d, y: 0.5428287126978671d), radius: 0.3196184151134327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47313758223643976d, y: 0.18705274602759925d), radius: 0.35575752535048266d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32715566077903835d, y: 0.5872086406952515d), radius: 0.19765399047326215d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8239621980566092d, y: 0.22322857696532605d), radius: 0.7982210011094243d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3442996268903913d, y: 0.037119743970761565d), radius: 0.30925688675268026d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28120002463398897d, y: 0.16747147473527202d), radius: 0.39191294475398075d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06016134350838831d, y: 0.687196834842637d), radius: 0.8122914584492886d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22890352917510093d, y: 0.2884392731697568d), radius: 0.33606284752452664d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10988831720285774d, y: 0.26642528796771414d), radius: 0.7869484831169324d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07906755067038984d, y: 0.7806908564779277d), radius: 0.11419512503205531d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6099518163165744d, y: 0.0793774977639613d), radius: 0.36124688537777494d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5332251625247241d, y: 0.5370204377807074d), radius: 0.1565856103275568d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9198051787807979d, y: 0.4238179366425293d), radius: 0.7649269168548154d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5406623124206533d, y: 0.670553225312199d), radius: 0.2839755073245458d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2574401101520062d, y: 0.9217782566717816d), radius: 0.47120016907435547d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8055611662541493d, y: 0.7092498651355983d), radius: 0.9700355478954243d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30788533634312554d, y: 0.677012384000492d), radius: 0.9004081516155964d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2995530062633711d, y: 0.3433966060379332d), radius: 0.3965222701040978d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1392202386130439d, y: 0.7337346232250421d), radius: 0.7786011437299332d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24127799987969434d, y: 0.773052310089037d), radius: 0.28909512680202754d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12803487478230835d, y: 0.055546514305628736d), radius: 0.08806570131026115d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47830579992937294d, y: 0.9932405229094843d), radius: 0.5524993995189399d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8531204002425034d, y: 0.9678946714461428d), radius: 0.672147726812193d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8488633049641512d, y: 0.3189592756720986d), radius: 0.1620157820092718d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7013458360886364d, y: 0.032760432328599376d), radius: 0.5708795061387696d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18855504917817123d, y: 0.9930372227167743d), radius: 0.8999560450603189d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29681201063450446d, y: 0.7256871611000076d), radius: 0.7014268914128018d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.368403802580222d, y: 0.7564764750968398d), radius: 0.014952713432494935d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9402375598608227d, y: 0.06895608153900545d), radius: 0.4963466927038843d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6303659758999114d, y: 0.2300961425414363d), radius: 0.4652724031517995d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22077362510453225d, y: 0.9153489555910885d), radius: 0.5438132497640908d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36739200386249515d, y: 0.9161559160215108d), radius: 0.7992593725793022d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3315837137685995d, y: 0.33243854702742437d), radius: 0.517119659657295d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06676218104236009d, y: 0.03975334542262465d), radius: 0.993999793971922d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7049978832779463d, y: 0.23276588603830806d), radius: 0.6349913415218252d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4410059075575039d, y: 0.03671501374312236d), radius: 0.7753705935219009d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3352917042440742d, y: 0.8512461370326817d), radius: 0.18806398610948383d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3702963086009784d, y: 0.9176388104782068d), radius: 0.084013752253143d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6774628012880288d, y: 0.991935920785472d), radius: 0.34007045683523884d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47087363038896124d, y: 0.07098745390509331d), radius: 0.5213502910464114d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38625376548681045d, y: 0.4615366596242494d), radius: 0.44994394883017497d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.002663231594177917d, y: 0.5887311126569725d), radius: 0.4939731084001283d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8248621956349068d, y: 0.8324869652225098d), radius: 0.8394799684450506d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5015109551681504d, y: 0.787619064652388d), radius: 0.5606010633326045d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39703979640891596d, y: 0.4304856203756243d), radius: 0.3890028153581736d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25695885693330844d, y: 0.9091099857369944d), radius: 0.27597127742041017d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9588418991601436d, y: 0.2871286311134389d), radius: 0.9524763621690332d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8592525543080264d, y: 0.46610642029250016d), radius: 0.2884476806648353d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19412996837867313d, y: 0.32189526506848565d), radius: 0.8850933087555138d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2145625784653563d, y: 0.8942005274395907d), radius: 0.39426076952620714d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28744662917880703d, y: 0.3315438388668108d), radius: 0.6438277897708499d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7677928992493355d, y: 0.9950577713936171d), radius: 0.17549543451756322d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38059601654899367d, y: 0.2819864558044374d), radius: 0.777498234265182d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.047619479127073205d, y: 0.1577353857825955d), radius: 0.949508525481546d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8455368907716169d, y: 0.1277618932117962d), radius: 0.5932634775675925d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0921434469785265d, y: 0.26673709567295d), radius: 0.8216466084083844d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6882382573609948d, y: 0.5193799419924741d), radius: 0.085184893607405d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02163490197266127d, y: 0.5532703946859285d), radius: 0.537457737865763d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4601727719993959d, y: 0.778663719497551d), radius: 0.9446496433589954d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.485391829292124d, y: 0.2869362498264809d), radius: 0.680501418412014d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7731418185126612d, y: 0.9190119977125634d), radius: 0.5879320471538313d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030787315291477824d, y: 0.8808420031659553d), radius: 0.544248900684219d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30097599257587937d, y: 0.6634770200736053d), radius: 0.6341648223449854d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46295412200231734d, y: 0.6757788670281848d), radius: 0.6334832167555798d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4517427878283936d, y: 0.047350812125113495d), radius: 0.07064953896434978d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7199969792423682d, y: 0.08167770429614252d), radius: 0.6929918513031809d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21879370794016306d, y: 0.4099229762336002d), radius: 0.11614877860473527d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3386954185866634d, y: 0.8982252354943112d), radius: 0.515833599670697d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3858300364143903d, y: 0.8533459997807366d), radius: 0.3228402598040482d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09522114736854781d, y: 0.3565651361383243d), radius: 0.32384759042811795d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8857311754307036d, y: 0.6905211361470327d), radius: 0.7252934375757705d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4705129722714664d, y: 0.6299903279293664d), radius: 0.4760798036949395d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6352188191186633d, y: 0.04113499929308928d), radius: 0.035088840074968486d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17000078829202003d, y: 0.16660819943709693d), radius: 0.14275391785904368d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9684253456300257d, y: 0.6808165460637875d), radius: 0.7561801449859459d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7902946762768283d, y: 0.94777395045051d), radius: 0.6914284818995993d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027335498490484555d, y: 0.9030025488385932d), radius: 0.8046913244185154d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5709183481803973d, y: 0.44075855429695165d), radius: 0.23085773254761077d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7331857367022064d, y: 0.6371416263366567d), radius: 0.5238939795980854d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6058506323856044d, y: 0.32905859316864194d), radius: 0.6216415587833609d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14553278889168952d, y: 0.5883236874113114d), radius: 0.45471370139263323d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.844784258588441d, y: 0.07244385243011964d), radius: 0.04944468974609828d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9996069312088861d, y: 0.589460705331236d), radius: 0.8007732652928509d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17315982254204487d, y: 0.5391953054474167d), radius: 0.2822663414337677d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25897480412791807d, y: 0.9244034533983937d), radius: 0.3596001063608213d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3520357550866362d, y: 0.7901082684892637d), radius: 0.32580301623817876d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027541395001858593d, y: 0.852267584337229d), radius: 0.6650706848007872d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3887678335065763d, y: 0.8724016614595639d), radius: 0.3778403207235782d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31238916974749986d, y: 0.4267501889084516d), radius: 0.8781303831483005d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024776425613778463d, y: 0.927137813876982d), radius: 0.2458852756728802d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13319215176727972d, y: 0.3374626828022135d), radius: 0.41062470284280483d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47422379749063026d, y: 0.6080117251959997d), radius: 0.9582762344223477d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.674079413995522d, y: 0.5626233475159345d), radius: 0.9599276227595547d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22876827196651972d, y: 0.36054092884959843d), radius: 0.7189619056511166d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7348551838989589d, y: 0.9224299212145434d), radius: 0.8380087913570023d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5424315424680489d, y: 0.22639329810254705d), radius: 0.9438739594411883d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7195032229774927d, y: 0.6163549198232011d), radius: 0.9183743662625955d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9895756693616639d, y: 0.5228636150876136d), radius: 0.3481284602605226d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5930566473752367d, y: 0.11834957119499134d), radius: 0.9848224440769183d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.60268809687203d, y: 0.8031020840408146d), radius: 0.08628415321729721d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7359187305612259d, y: 0.8629898777515054d), radius: 0.7023432613449936d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4581395162624037d, y: 0.003848430622248822d), radius: 0.775164641607727d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46332519528312066d, y: 0.2930472129309384d), radius: 0.8756243891775418d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3961172031389615d, y: 0.14370272499706427d), radius: 0.8959084887703339d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49395360282363476d, y: 0.6955850445591832d), radius: 0.45667666955430075d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9241560711251168d, y: 0.9694690948476677d), radius: 0.15456796685321916d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20519270999259043d, y: 0.8424007484258584d), radius: 0.11252630630591265d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3627720035654701d, y: 0.07691243592198582d), radius: 0.9048167562404601d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.325719557745513d, y: 0.5497235874890288d), radius: 0.15136638667883917d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7675421103939896d, y: 0.16327062914784407d), radius: 0.5044942842168094d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7212685357154853d, y: 0.8373425831776843d), radius: 0.5206879896018302d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26246442439262385d, y: 0.8064677075717213d), radius: 0.9316131577172956d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8639546935553167d, y: 0.6473315015901234d), radius: 0.8420209879543172d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9411335293170006d, y: 0.6966905707275227d), radius: 0.22220135048700973d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5503145917131861d, y: 0.37675137100519474d), radius: 0.5864396803309493d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06245647821906419d, y: 0.7552717623446903d), radius: 0.26863883025848645d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38019067890015534d, y: 0.36390373518147034d), radius: 0.613656384322512d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02592502341190972d, y: 0.3509447140267341d), radius: 0.9041479351134027d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6000277388564427d, y: 0.2294169411454956d), radius: 0.36464886585349077d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9039286027623403d, y: 0.7571452730377639d), radius: 0.9989974255019191d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04056173722089007d, y: 0.4443212360038157d), radius: 0.07127823508346465d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.950555914207801d, y: 0.3035918897022041d), radius: 0.23793238682403883d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26565324060910556d, y: 0.8802864083325893d), radius: 0.13211412537160838d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5136302020092935d, y: 0.18206019664298978d), radius: 0.8517126353350375d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6663709124048975d, y: 0.6631989051128209d), radius: 0.508346631543754d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8232826292760609d, y: 0.9077193037416033d), radius: 0.3406394173087014d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18477228539470725d, y: 0.0961006547974681d), radius: 0.9060130900616248d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09394714500781443d, y: 0.3059156864485596d), radius: 0.8897887791168587d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.989007976466945d, y: 0.8782190216633743d), radius: 0.5790336701839767d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7751462056948998d, y: 0.9394758229207083d), radius: 0.23802861908495343d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.732954576672714d, y: 0.7800323779762871d), radius: 0.2632358789714614d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3856347862783758d, y: 0.10666075046039736d), radius: 0.029226392442415983d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5133779022888684d, y: 0.027725646459080933d), radius: 0.5055938448795563d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9244840357789003d, y: 0.23279963299856887d), radius: 0.9647806308010598d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21834787903845754d, y: 0.5685949388024348d), radius: 0.4233286193645084d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8727653291882407d, y: 0.7991458793818342d), radius: 0.07469030616566474d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10128249785923338d, y: 0.6435759247220261d), radius: 0.029810233836249478d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9585503603032812d, y: 0.3339140685265293d), radius: 0.5994095702696253d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05298052254813357d, y: 0.9086786921715202d), radius: 0.10560297185824463d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16492734503522521d, y: 0.4824277133539082d), radius: 0.7075221537980315d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.927917004967003d, y: 0.7372609243189294d), radius: 0.3034120819645574d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.507885240862624d, y: 0.32477900809948956d), radius: 0.3067891941885398d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21100836568306602d, y: 0.8126405337979562d), radius: 0.5683483268039249d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24652247806968486d, y: 0.5535692724793106d), radius: 0.7483282707550799d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3372109551235827d, y: 0.1991308008240985d), radius: 0.38291382951470176d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46171642511341005d, y: 0.3118311689183979d), radius: 0.5944175747759508d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1657923766383611d, y: 0.3831997687979851d), radius: 0.7918686357601978d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.332883930908786d, y: 0.029691059405875575d), radius: 0.23668444034821468d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06380156511325397d, y: 0.19694434616364564d), radius: 0.6517783955877602d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21388730556947577d, y: 0.5033228181475878d), radius: 0.3971950806518253d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14792244798403686d, y: 0.4547104507162675d), radius: 0.445079594679738d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6449961859071665d, y: 0.5111418976223014d), radius: 0.08207606979652537d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19031862091941765d, y: 0.4154785484129221d), radius: 0.8137241295759549d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8181609664717207d, y: 0.22368914850741572d), radius: 0.48772073298751795d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9802620491297303d, y: 0.5097786089801143d), radius: 0.9636038068196002d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069056234380342d, y: 0.9740842313165369d), radius: 0.3597944561329245d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6149331370853921d, y: 0.853830091502055d), radius: 0.3786660101022996d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8500350920850862d, y: 0.3818695433494407d), radius: 0.5547964677978693d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8905274684605763d, y: 0.016218164163410376d), radius: 0.643772800009013d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9991931476957473d, y: 0.5061116884786492d), radius: 0.6695187333650117d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3280201965318986d, y: 0.41653990900461546d), radius: 0.1308141204762584d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24385976655269848d, y: 0.5829281653123318d), radius: 0.9529735943228064d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6235833881423344d, y: 0.7443556968098584d), radius: 0.7796116725156157d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05916887648224989d, y: 0.840448821146629d), radius: 0.3375011094314727d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4671006521490967d, y: 0.6932488383817169d), radius: 0.6187187239961477d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6476696703288878d, y: 0.5102671745044165d), radius: 0.974204269582723d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.261045885336473d, y: 0.6058570191757185d), radius: 0.43643700544855113d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7607967302967621d, y: 0.6741695510954555d), radius: 0.11822573961228655d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9411780757064265d, y: 0.47858244804445726d), radius: 0.6562007522425863d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2237793059499642d, y: 0.3413291798205772d), radius: 0.03916321194149164d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9442812412662926d, y: 0.2899845019825035d), radius: 0.6603561174759845d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6760452499160132d, y: 0.5978665852642557d), radius: 0.48914564695977236d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24704667643236722d, y: 0.8724240206351824d), radius: 0.7906051383403103d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8497177112672032d, y: 0.20573119392909556d), radius: 0.886029228470359d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8252141401806549d, y: 0.3548292002538689d), radius: 0.9537009125582916d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7075808853922881d, y: 0.7915671850679041d), radius: 0.025305447747504317d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9329971781476949d, y: 0.046088679596543725d), radius: 0.276607056205167d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9650837694300838d, y: 0.3870770444098893d), radius: 0.3107496654965981d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5932662496631113d, y: 0.17778803060608017d), radius: 0.7980724298618721d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9476729557551214d, y: 0.17615827383946525d), radius: 0.3813970078576634d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.870433550489745d, y: 0.31744675021316415d), radius: 0.8997122700232514d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3587941952011985d, y: 0.04915006438244829d), radius: 0.14349820849840922d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6887306811274752d, y: 0.28563456958816724d), radius: 0.363976160774102d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.470637752668832d, y: 0.3164084473572061d), radius: 0.31633417831433674d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9420824903210312d, y: 0.8769518044577664d), radius: 0.24384280280472947d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38907291605139305d, y: 0.7486553999087423d), radius: 0.20686199462442512d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6518637022714802d, y: 0.7948982189297544d), radius: 0.926319421863473d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020721245497312246d, y: 0.533925328563914d), radius: 0.4473317569085362d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10816423609770609d, y: 0.6696741780139699d), radius: 0.2553757131482626d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5119304315214199d, y: 0.1902140013839727d), radius: 0.4864237029045996d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.799783950503034d, y: 0.6055129291623637d), radius: 0.20900982398510493d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6925964442988745d, y: 0.020586912514637068d), radius: 0.42303669037330993d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3203117182175944d, y: 0.8227577238297947d), radius: 0.8076344878690801d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9336721144461331d, y: 0.5083494434263537d), radius: 0.8102972828836792d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9573693379681892d, y: 0.33959755753625787d), radius: 0.5897163335220357d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6131632951945929d, y: 0.6060893234663625d), radius: 0.5230549940999424d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986004133657254d, y: 0.2127725971933072d), radius: 0.34849802222937565d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3203862138671997d, y: 0.9861513414714114d), radius: 0.4245821211784522d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6903704492279751d, y: 0.6527167879753291d), radius: 0.12053001855256285d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6848092011852989d, y: 0.5523864164575367d), radius: 0.6943630586942885d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4493652145704591d, y: 0.028389866188417434d), radius: 0.4261285077181475d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2630318917603518d, y: 0.5479351329094317d), radius: 0.3228883544908161d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8600891041982167d, y: 0.03718173779206435d), radius: 0.8608306814554968d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31346346202296815d, y: 0.3323168482999953d), radius: 0.34959639268567333d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018704727961764922d, y: 0.14126413633972734d), radius: 0.4327572910958798d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4567491494479954d, y: 0.30001006997893886d), radius: 0.4506624792293762d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012978226010269656d, y: 0.054318325217429186d), radius: 0.8945631732634539d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8267380050037715d, y: 0.6051713123300921d), radius: 0.6620982080357477d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2398435567428514d, y: 0.26233079558262673d), radius: 0.26269615244703115d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8029512429349814d, y: 0.25825734787910437d), radius: 0.1286727998687729d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9181357109891531d, y: 0.9455155984420548d), radius: 0.9129291016235181d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7865786995671841d, y: 0.18263388693631288d), radius: 0.7345816368741681d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4742463684837549d, y: 0.8892352441783036d), radius: 0.2707161671842724d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0077979933431450155d, y: 0.6155579319301884d), radius: 0.278050452139755d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0439711764080587d, y: 0.859107381588902d), radius: 0.2741237915885364d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05842219084341771d, y: 0.28413038642411037d), radius: 0.19553704271468397d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7955041355578831d, y: 0.7699044571832837d), radius: 0.20030873438431063d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5846287427293222d, y: 0.6168444094373247d), radius: 0.02547996585900736d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26943080251823603d, y: 0.39843279990478486d), radius: 0.13035866517493744d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16350299145891922d, y: 0.7606510125915221d), radius: 0.7155948807868224d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04853837867533961d, y: 0.3475777574075998d), radius: 0.9239710961286074d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6222645966740156d, y: 0.36209384280383095d), radius: 0.36018529706218594d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02845910230641413d, y: 0.34313821795643196d), radius: 0.08554880432752843d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43356039394161383d, y: 0.07067953783186409d), radius: 0.18934534301120565d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7750504659968015d, y: 0.22117778647197173d), radius: 0.39422687950464896d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13712890710737713d, y: 0.4427249534093407d), radius: 0.7222377641398325d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8019758667855442d, y: 0.44739100499725803d), radius: 0.7855434852903421d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.515277936155284d, y: 0.756939095584458d), radius: 0.14653798554237407d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5958847465931996d, y: 0.13829815960604075d), radius: 0.5587399338122923d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6824701637820771d, y: 0.9738983995619799d), radius: 0.517540840203973d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1610705443289987d, y: 0.309143925499063d), radius: 0.009854981548536368d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5882956176710676d, y: 0.9894842256649289d), radius: 0.5229790299314528d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6060281709525177d, y: 0.37364162415418056d), radius: 0.04463753337497989d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6538993790180503d, y: 0.8434531327670876d), radius: 0.5904253902262354d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07495390596012974d, y: 0.26662134004270954d), radius: 0.7634823055661325d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667895327100563d, y: 0.4215984150485066d), radius: 0.7733318114145132d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.053880415738607246d, y: 0.12255130511481072d), radius: 0.36958663518181434d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8875171734927165d, y: 0.6883853219659826d), radius: 0.3458785926320206d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9888463143169895d, y: 0.9979671387501127d), radius: 0.21239611443877582d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4034180726486213d, y: 0.34173367419319434d), radius: 0.6061017477752703d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4925056370006685d, y: 0.43397326909419565d), radius: 0.18250300516860607d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29125276336472206d, y: 0.6418644295165911d), radius: 0.3579562933335686d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.415369123888097d, y: 0.8073066222074977d), radius: 0.5269820692825002d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.78997936875409d, y: 0.44874372618671654d), radius: 0.0612835710198224d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.714916204573322d, y: 0.7284216380014755d), radius: 0.2982958250636807d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8391171724792114d, y: 0.8818115287526166d), radius: 0.3372826245428512d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17785634253615668d, y: 0.8923606130466566d), radius: 0.19205888679090777d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24570188531073667d, y: 0.6051638565285934d), radius: 0.25337518005138826d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6631405537026677d, y: 0.14128669234272595d), radius: 0.446459081046623d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8313357948305558d, y: 0.5538202698258916d), radius: 0.5130752944133338d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06500000184046151d, y: 0.8922688977990347d), radius: 0.9922145721684171d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8232568419106236d, y: 0.7017844130437444d), radius: 0.7571435279184968d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6342273845567756d, y: 0.9851751795810163d), radius: 0.14733530669844397d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8844595355341075d, y: 0.6211816383465727d), radius: 0.623775825372442d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4024772222146046d, y: 0.9263421443035859d), radius: 0.7343002877316936d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0028803345771523103d, y: 0.29579606011052184d), radius: 0.7068632835394529d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8052973651273304d, y: 0.06279958272480612d), radius: 0.34713180699848456d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02673040536848026d, y: 0.8833808369284686d), radius: 0.9012077685694257d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.994852902232433d, y: 0.35347064893320435d), radius: 0.022973766491386605d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07498463321109439d, y: 0.6020886510152772d), radius: 0.5304353480757308d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08109605096510075d, y: 0.9294815286196504d), radius: 0.2975406265894084d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6995293531164316d, y: 0.4717100416128984d), radius: 0.32130029327051746d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9255333667204536d, y: 0.9996001052243009d), radius: 0.40664141960859157d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6353163565540826d, y: 0.21170640035951693d), radius: 0.5356053033141664d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07078585766223999d, y: 0.6605925515002099d), radius: 0.6713572957099104d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3580494542809365d, y: 0.11876625024000798d), radius: 0.4027097463818684d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.034857297043699775d, y: 0.7457448207997378d), radius: 0.3532459694351241d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19981133756631053d, y: 0.7536455349068326d), radius: 0.530763451963982d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43448994160027077d, y: 0.8903539554080852d), radius: 0.22349562871251039d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8519191935533721d, y: 0.7445420948619579d), radius: 0.1420834706389631d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5594625009730527d, y: 0.30066205202657637d), radius: 0.050757549262417156d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1227744418594211d, y: 0.005319831266775488d), radius: 0.4524079788276689d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8750915656317658d, y: 0.4823725762070966d), radius: 0.8589786153165816d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.858709626533227d, y: 0.5143864776867304d), radius: 0.12976713187537448d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6871518043648388d, y: 0.6986937281580765d), radius: 0.1847940519687723d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8462492434748262d, y: 0.2888801792430624d), radius: 0.5554169868258205d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.377486762353223d, y: 0.21924340684126586d), radius: 0.44433718624085927d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8516354357666397d, y: 0.975443121219578d), radius: 0.8294350122013604d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4726212190865092d, y: 0.55365679690405d), radius: 0.2043450323306426d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43955670451848905d, y: 0.3955021637054943d), radius: 0.6177409943558849d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16747292360473465d, y: 0.7539420351398309d), radius: 0.8588539722013927d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2863236904957185d, y: 0.49318041063247786d), radius: 0.8275806293658224d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8797379703768179d, y: 0.33558971822472716d), radius: 0.9725040354714872d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8816497922769355d, y: 0.26495925324394975d), radius: 0.16052212983401715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2885810083022562d, y: 0.810015576249659d), radius: 0.10389207617712437d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41720265962057146d, y: 0.5870174862271623d), radius: 0.5673958698774897d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5407597621839062d, y: 0.18798014499040916d), radius: 0.32586578321423376d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6584193620312259d, y: 0.07568238102318958d), radius: 0.9022234072254153d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14338425298615287d, y: 0.2670991362216206d), radius: 0.939837091405867d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1274286456487448d, y: 0.31954317550592126d), radius: 0.1188686380917513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17831643034723577d, y: 0.2185489799014283d), radius: 0.16506229436624142d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5948537690956581d, y: 0.6828688047335768d), radius: 0.12700393167385426d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.492788784464291d, y: 0.8722535884027046d), radius: 0.0017241126799922846d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.97875512970066d, y: 0.5653464566471331d), radius: 0.5233245332527985d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09878785535958357d, y: 0.013029797427944745d), radius: 0.7197197876131036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8864606360023934d, y: 0.01042304880481748d), radius: 0.5659690987316565d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8024808251680202d, y: 0.8486503032122231d), radius: 0.924429481754282d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2585143193237438d, y: 0.20614977775035181d), radius: 0.2106460619072088d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.349130859383716d, y: 0.7890388278633725d), radius: 0.9748951654325584d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4498164791184769d, y: 0.24810549430284445d), radius: 0.8733928372768971d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4826547568899823d, y: 0.9763125327035725d), radius: 0.42953625289267394d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4301410502404046d, y: 0.6076741339989736d), radius: 0.691860279180382d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9852254291712743d, y: 0.1712839410878303d), radius: 0.020946323146088575d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5800034611486108d, y: 0.3622422364048984d), radius: 0.5510903395925819d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0676194964769109d, y: 0.6692581764096192d), radius: 0.8418515630798418d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9843662410091881d, y: 0.9069438779975723d), radius: 0.5723391784486328d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9674951082114388d, y: 0.012820544281047286d), radius: 0.17450076824107685d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7184477701505945d, y: 0.4139350056800414d), radius: 0.10301394743317138d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3333210723818897d, y: 0.5135490289961369d), radius: 0.6424453443783742d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8956046954114364d, y: 0.8251493814554461d), radius: 0.5725058721450943d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6851077359344883d, y: 0.5945021082168495d), radius: 0.2040007832438201d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00723757766874511d, y: 0.5787412710493679d), radius: 0.8085075465169346d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4980872242308573d, y: 0.038003376614760165d), radius: 0.8597767078917333d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4616878270020205d, y: 0.2451000154636439d), radius: 0.182729526632604d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10199469105004533d, y: 0.4978679087758827d), radius: 0.6590057851116374d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5906159129846603d, y: 0.6330700580300412d), radius: 0.625671004788512d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2741408276645171d, y: 0.2912079683177724d), radius: 0.3734337209948153d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3383723218336969d, y: 0.6569737216224949d), radius: 0.3634132003711692d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09211202163376386d, y: 0.43662452687863984d), radius: 0.3900006518104545d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8198901279359135d, y: 0.873455370790782d), radius: 0.044158321761870956d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28957251017001406d, y: 0.18378901923888302d), radius: 0.6259401684872328d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5577532305236831d, y: 0.34765221083359266d), radius: 0.6448112531071996d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8276450235529351d, y: 0.8808367526311581d), radius: 0.6196917089145616d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12006719790799947d, y: 0.28342629555358134d), radius: 0.531491026773361d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8124603319592808d, y: 0.5871718491119539d), radius: 0.07341228844011782d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20596721234246473d, y: 0.19599595716800788d), radius: 0.27913912859951495d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38548798480257673d, y: 0.8054558609656174d), radius: 0.13272140867586535d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31826469503001187d, y: 0.7181759327054464d), radius: 0.029784445865606357d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3262242576215121d, y: 0.05004640742050315d), radius: 0.45933440485662047d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8160207196582983d, y: 0.08725338297475094d), radius: 0.71692540018732d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48087852212826276d, y: 0.7224088920183847d), radius: 0.5360407262193715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19422913180170354d, y: 0.5122108136102386d), radius: 0.49796251084002596d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41231702063420395d, y: 0.7633451533873381d), radius: 0.03471554451379477d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9876470222763631d, y: 0.20820641421108144d), radius: 0.8092044204639026d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10686931209738926d, y: 0.6768633572193037d), radius: 0.6560007652164286d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7621060618790325d, y: 0.18200292151710573d), radius: 0.13090033804798973d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32954247989012786d, y: 0.6525688047087658d), radius: 0.25156527732148326d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07712702822055106d, y: 0.9402628484757176d), radius: 0.916644857446666d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19641176404705063d, y: 0.8260138344165499d), radius: 0.8015151096260387d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8737609413863692d, y: 0.5825602128002423d), radius: 0.39995729705881133d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5963894535312474d, y: 0.46341832738598576d), radius: 0.6783297651513188d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5117872796352939d, y: 0.7358935661446643d), radius: 0.927055557797996d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012793046022159138d, y: 0.837165096304778d), radius: 0.4607845729226647d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7169765565115244d, y: 0.13173379763294912d), radius: 0.4503385837675705d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9785408135720699d, y: 0.32388055673483673d), radius: 0.09110035067829847d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.838958289725873d, y: 0.607623180082265d), radius: 0.5401390559912416d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1455377698088367d, y: 0.5880494766423817d), radius: 0.8807540174404758d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5283230727704521d, y: 0.6552840376046555d), radius: 0.4436832559977445d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2034855237026978d, y: 0.9531997060049157d), radius: 0.5251296349473589d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8879005941661157d, y: 0.9527428899543805d), radius: 0.9963468018055668d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6334285673692259d, y: 0.5906950765643482d), radius: 0.23147724294024985d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4246973045518838d, y: 0.4422816699326866d), radius: 0.29723386329191936d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.898659186322523d, y: 0.3015624230311462d), radius: 0.20898199503601378d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16104603495472913d, y: 0.22027893309997348d), radius: 0.9898751910008605d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14636905443105352d, y: 0.13379287444608334d), radius: 0.07084129466943578d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08626661681259695d, y: 0.5538953226096563d), radius: 0.9551148751936223d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3896177974997015d, y: 0.9732623170194193d), radius: 0.9194270338220801d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6449811646850626d, y: 0.15573462594124288d), radius: 0.7600321169583308d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3223032319143757d, y: 0.03054932118992093d), radius: 0.7517081170426053d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5801860844580148d, y: 0.12824050463347414d), radius: 0.05426973015691472d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9473674341744405d, y: 0.2456314050490327d), radius: 0.8990468922113717d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07000107197399685d, y: 0.7479879869041023d), radius: 0.48658555085629374d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46952602367576823d, y: 0.22550511387906713d), radius: 0.9792588829562276d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4561744058722069d, y: 0.1747885814562231d), radius: 0.8907289646783999d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7749350467458017d, y: 0.9957765882772748d), radius: 0.9374140716097881d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05934748877097351d, y: 0.56539697937822d), radius: 0.32989287853561977d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37394221250955584d, y: 0.007459217750012237d), radius: 0.27941330798754216d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06014272157037681d, y: 0.12230659472086614d), radius: 0.47478759935925685d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8891423805549638d, y: 0.10901615366641415d), radius: 0.8106832390288262d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39428833538107044d, y: 0.188718259575551d), radius: 0.7319173363331213d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36448738374406464d, y: 0.7270375988713548d), radius: 0.6262599398951134d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8901706272135046d, y: 0.4004854430356647d), radius: 0.8755540268828095d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3237189500939258d, y: 0.3679870791190535d), radius: 0.3195516367202278d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7733935529537064d, y: 0.8140814231830915d), radius: 0.17943414447661754d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23517985854102652d, y: 0.6954281585632628d), radius: 0.9585568320974732d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.487748645784159d, y: 0.3742759790828941d), radius: 0.41535645698516943d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6312745635417173d, y: 0.9717269658659528d), radius: 0.1620756252476846d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13580734083779933d, y: 0.4003702428150675d), radius: 0.11453473993969354d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2905366629905407d, y: 0.004494149732827357d), radius: 0.4613031467220897d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5686847621579811d, y: 0.13741197094999302d), radius: 0.31289235300127827d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5442133325953556d, y: 0.8551952159116405d), radius: 0.6187377907171212d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8673519944505776d, y: 0.13638267760281453d), radius: 0.07205171090420881d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8269304593906116d, y: 0.3199414683292787d), radius: 0.49513440373075657d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5405340477034676d, y: 0.07437335436947967d), radius: 0.08941816163159944d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9177355574858712d, y: 0.2939243058902372d), radius: 0.5680595938268822d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26084082611083026d, y: 0.9884067385955337d), radius: 0.05479265181014459d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43778894298920734d, y: 0.5673742868691446d), radius: 0.48593026193206146d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5319365855347169d, y: 0.7541109654142975d), radius: 0.23641693501924943d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9960661216990689d, y: 0.6377255050897265d), radius: 0.428792134163108d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8374757076807247d, y: 0.978369488583575d), radius: 0.9997765422776923d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7667725914869081d, y: 0.2957096726841286d), radius: 0.492957031478659d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7514421311653935d, y: 0.40271560250120886d), radius: 0.6580371686667903d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4393822256284101d, y: 0.8688034155330028d), radius: 0.9716598440177667d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4924100948835387d, y: 0.038973501692671775d), radius: 0.22495271536949013d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23465584326430156d, y: 0.0688104257229114d), radius: 0.0030854933464907752d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18624821757691656d, y: 0.8602117377989181d), radius: 0.06696245964555902d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09061520642415011d, y: 0.3012255686522547d), radius: 0.39888449372907153d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.433608047219462d, y: 0.819654301787399d), radius: 0.19447422506016898d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7474438090578457d, y: 0.5888059070360308d), radius: 0.41020352558026363d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2203777231144648d, y: 0.13542712418582947d), radius: 0.7865828793548891d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2608528738725461d, y: 0.10927484087738926d), radius: 0.058850553945901996d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5164264064406958d, y: 0.020935087301627964d), radius: 0.020509205724522084d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4563417719312943d, y: 0.7862272042690436d), radius: 0.5972706283814379d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41303673075201597d, y: 0.11896940845316406d), radius: 0.27693305795358125d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6480449634609315d, y: 0.5991609389111507d), radius: 0.4603171936344125d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1754288908247419d, y: 0.2586355484060133d), radius: 0.798376585638726d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17139498041076473d, y: 0.8431987430949975d), radius: 0.44679674024241933d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3166089634999617d, y: 0.7680670888478954d), radius: 0.6919380516667856d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7490292816600288d, y: 0.5416873423070335d), radius: 0.3062946876275495d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4295891194604152d, y: 0.8229600100455975d), radius: 0.8680099412443418d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19192464985472324d, y: 0.7018201723287147d), radius: 0.08811189446502055d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4177420490738688d, y: 0.1878129517214251d), radius: 0.4120471168322931d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6474220858762673d, y: 0.5289325724434856d), radius: 0.7389168063817647d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7041986861590341d, y: 0.7509663884598538d), radius: 0.5143493736719439d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7202866509177163d, y: 0.1842212772076942d), radius: 0.2737389463356651d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22769761578382064d, y: 0.7236822288258249d), radius: 0.3146266635790814d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7813632095973599d, y: 0.7329291370127338d), radius: 0.7421800190121247d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9032258753140445d, y: 0.5417032377525925d), radius: 0.6590658959226116d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4642900694601749d, y: 0.7360245083338994d), radius: 0.16774726696641762d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.807508231010169d, y: 0.6972006889791218d), radius: 0.0782034724837215d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14880177035319309d, y: 0.6373508900799393d), radius: 0.07325276225007393d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1887919381773927d, y: 0.34129362252848827d), radius: 0.5755382468463489d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8162232474024732d, y: 0.24494636609903575d), radius: 0.5220179792863762d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8154496831591338d, y: 0.18816918758343626d), radius: 0.11739779820838414d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3654200372305467d, y: 0.018904123059568234d), radius: 0.3969812834906822d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7581681043106411d, y: 0.5734977811431728d), radius: 0.43020733547141554d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8655191099926771d, y: 0.6420189531268735d), radius: 0.6905029484356983d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23840497681937d, y: 0.3368691698382926d), radius: 0.27916954283433304d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.542836606055877d, y: 0.7356760192655196d), radius: 0.20400482064621717d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37181047126006084d, y: 0.6575240184811761d), radius: 0.8931261852781743d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.99575658817595d, y: 0.9867320401253974d), radius: 0.45600465384004274d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1336377218688769d, y: 0.8877669108436378d), radius: 0.13866378690908043d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06537287206572762d, y: 0.9567132504083798d), radius: 0.9682632537250033d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8410969249603307d, y: 0.01602645084795551d), radius: 0.8802683277321885d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2789779749597173d, y: 0.19821416337934838d), radius: 0.4011524516457049d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6575658577553086d, y: 0.5282059910055608d), radius: 0.6864770373234728d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8460891004542999d, y: 0.808051821701814d), radius: 0.07583134975064831d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5484112968890108d, y: 0.462187402062733d), radius: 0.1356019858891354d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25710672622263453d, y: 0.1624352913699202d), radius: 0.5286633481851181d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9730430661548071d, y: 0.1036659284320276d), radius: 0.45700049781100505d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5290421944204607d, y: 0.35909166299870876d), radius: 0.9525005157521174d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14020137892915052d, y: 0.8965256224451816d), radius: 0.6856291654767598d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.693542643484713d, y: 0.37564293505320734d), radius: 0.4074128087491744d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0035103989140921055d, y: 0.7559526857291806d), radius: 0.6959564502713325d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13702571484216808d, y: 0.41732062803273773d), radius: 0.08172848395677645d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4014445354439077d, y: 0.8168943485378519d), radius: 0.49868316828571957d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41045609233221847d, y: 0.3872040332081075d), radius: 0.9081820643770886d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.524583696311987d, y: 0.49456213649136715d), radius: 0.9832158849976628d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8976594775585873d, y: 0.6494146862217492d), radius: 0.1436643434259146d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.057190166252721664d, y: 0.7534563489192069d), radius: 0.05244378023401486d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8400336634832025d, y: 0.30653696027769617d), radius: 0.14273869749659873d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28960557639900264d, y: 0.23641196293418754d), radius: 0.8445806152793657d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9367772551417537d, y: 0.2194916637268679d), radius: 0.7726341248774712d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12708820983619973d, y: 0.05779384343583016d), radius: 0.8870698659974516d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5557452025339874d, y: 0.36795699845241836d), radius: 0.2379540502418298d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14415531174102847d, y: 0.7652180755424998d), radius: 0.8538187749398619d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19121770680874617d, y: 0.7081930922854025d), radius: 0.1925960411966926d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26632579023240976d, y: 0.047305950961475385d), radius: 0.5342127434748262d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8584432776764449d, y: 0.6674894843857946d), radius: 0.6089745736811124d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4105489397993062d, y: 0.7838929963125959d), radius: 0.9073482037256888d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48334348674402716d, y: 0.8732649994344752d), radius: 0.07275695168115326d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04115703658187453d, y: 0.5258432447051246d), radius: 0.32225959311053953d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.260671208485001d, y: 0.6429306631886279d), radius: 0.5906396691909964d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6678640042838582d, y: 0.15898262617772352d), radius: 0.5330114535809296d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4786207862969216d, y: 0.0024524613054462963d), radius: 0.3308401494656307d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17571843528960218d, y: 0.40037419010024555d), radius: 0.01012287965786518d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19494820607833252d, y: 0.21435375366444698d), radius: 0.5390786739937566d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7148123036861802d, y: 0.002535484109758457d), radius: 0.2251940367181402d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09913763286095001d, y: 0.2644759947278492d), radius: 0.5505523833965743d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.378873540898389d, y: 0.9990214139210031d), radius: 0.765349944155738d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5111958408161221d, y: 0.15537765136168213d), radius: 0.742825734566995d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27011037742713084d, y: 0.33093953745637217d), radius: 0.21147949547061562d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7167826519486311d, y: 0.22445437838970705d), radius: 0.7685370718889665d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6886571865959564d, y: 0.8151952931385515d), radius: 0.16437090524673748d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8921267607049126d, y: 0.951882582032726d), radius: 0.13937535884103536d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526599289560153d, y: 0.28944687416919057d), radius: 0.07518542125293082d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9532639314883241d, y: 0.14607583536003288d), radius: 0.4795485065579075d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2872289029030015d, y: 0.7169642771397725d), radius: 0.7294642571553885d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8378660838513148d, y: 0.48282908382007506d), radius: 0.10010327505524685d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46252686341578875d, y: 0.7960776858830965d), radius: 0.9818694287719523d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024197316480116582d, y: 0.447027697989565d), radius: 0.06591471325607812d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1006362367458018d, y: 0.7605834732791061d), radius: 0.8880529248191151d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6752528153457216d, y: 0.5390840268135895d), radius: 0.17976371432615368d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1917210791438887d, y: 0.08726750586262455d), radius: 0.24707735230551742d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30338697855284036d, y: 0.7723661294237637d), radius: 0.5996115780882566d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36030225199563604d, y: 0.8170504780693842d), radius: 0.13144670475507247d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36172327437705165d, y: 0.9822676065899932d), radius: 0.11525626950933177d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20287628860661644d, y: 0.0563533797585023d), radius: 0.8258943404432669d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3590729664256781d, y: 0.8478524388212635d), radius: 0.9169951211635438d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.302929231054895d, y: 0.45671781632360076d), radius: 0.04170982026059622d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8983812607665447d, y: 0.39061284867727675d), radius: 0.9176794447724497d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9692297718084092d, y: 0.4283157117212709d), radius: 0.48968156659670803d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06327706034520919d, y: 0.5897824280741429d), radius: 0.573783381756987d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2895016763085053d, y: 0.4958122791689602d), radius: 0.35129359212865474d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24236325780052304d, y: 0.6256329935809931d), radius: 0.5283038868998279d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7249991059695295d, y: 0.35179571358345507d), radius: 0.49624563108948894d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8780874120530591d, y: 0.9347458525792762d), radius: 0.5988420962904274d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6845271139539367d, y: 0.8459376729079009d), radius: 0.7024523885630521d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7551783048345818d, y: 0.27082895319291567d), radius: 0.5036798308511394d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3790912603228226d, y: 0.017427461690474377d), radius: 0.027080625513389966d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19039209119767442d, y: 0.3764823972331969d), radius: 0.7697535642330938d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7071572673301992d, y: 0.5259952798969215d), radius: 0.28579191713682284d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8907128919692828d, y: 0.7460456371091037d), radius: 0.8668948670822773d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9904924415809857d, y: 0.3610545377083433d), radius: 0.11647398106409479d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37960985360632127d, y: 0.5487868411369038d), radius: 0.7709213761733323d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4300086121253812d, y: 0.13439462798766844d), radius: 0.3598508182376149d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6145413967636257d, y: 0.4702311990147746d), radius: 0.8924202693193072d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7258550413286158d, y: 0.37271009965299695d), radius: 0.29432736952333194d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36065048047008075d, y: 0.743104965697831d), radius: 0.5524516508621246d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4910988746554208d, y: 0.9013438211410917d), radius: 0.5613888797353281d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4126993890149414d, y: 0.5692265367496321d), radius: 0.9621878213882588d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.932491089799403d, y: 0.06797356067634586d), radius: 0.6540556738090327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3411410400628436d, y: 0.2980359324348686d), radius: 0.030139074316264947d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0059418921949536685d, y: 0.9335630479265179d), radius: 0.4881723370293849d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0593138153090913d, y: 0.7801564482263253d), radius: 0.6193412699484677d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13999900333685933d, y: 0.823641242756498d), radius: 0.23678968417451385d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6571782216350472d, y: 0.4684995293257602d), radius: 0.27402458087228243d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6945879526710478d, y: 0.00605238985222889d), radius: 0.8288598137990525d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25079682934529934d, y: 0.5397225651921544d), radius: 0.43901638284851463d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.503134959384675d, y: 0.9296101339893025d), radius: 0.16935343843806072d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2733342015250627d, y: 0.6351511229459773d), radius: 0.7762571047560897d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6984392783915929d, y: 0.499396691034264d), radius: 0.9763586414438793d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5792754593184386d, y: 0.8825369884555174d), radius: 0.9204047691994128d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0522018705035755d, y: 0.7269315545264551d), radius: 0.977346550582694d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8883921705392279d, y: 0.7742798624518403d), radius: 0.5873861308087431d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11162464858862842d, y: 0.599454184088565d), radius: 0.5755877641786844d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9675644429915097d, y: 0.11320257123133226d), radius: 0.06858442381708818d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5823564768232492d, y: 0.8637004765939706d), radius: 0.424290177662372d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9560332382900529d, y: 0.6582722476146528d), radius: 0.23173142696364268d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.002600356329564679d, y: 0.025485149237399307d), radius: 0.6080261186566334d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6448121067042755d, y: 0.23801795279511617d), radius: 0.09099264366619997d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4176077559054888d, y: 0.18760453461895554d), radius: 0.7857723779441625d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11713775893665046d, y: 0.5579586894126188d), radius: 0.6835824144561242d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45058160705800476d, y: 0.8663129339854811d), radius: 0.2538187365604977d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3008968557275524d, y: 0.856772134635255d), radius: 0.7695901472423948d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21528891804471917d, y: 0.6208826287683175d), radius: 0.6475391931546991d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17937966358874147d, y: 0.3712492817861618d), radius: 0.25048020696421647d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8461602182506681d, y: 0.23356304547398443d), radius: 0.5848098629562198d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2120153950843484d, y: 0.5738219777341361d), radius: 0.36016961312790385d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6927287844001179d, y: 0.7260960365216754d), radius: 0.5023829537659394d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5008171435930479d, y: 0.6325463720252409d), radius: 0.9437575575028934d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9376124526471418d, y: 0.5719883286534905d), radius: 0.7590759516734658d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1670762318001906d, y: 0.07947962611539261d), radius: 0.6629312638670432d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6604993450983958d, y: 0.4583369096829334d), radius: 0.34224838487229536d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9658122589592746d, y: 0.45269054324192715d), radius: 0.7638482171112435d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8287699220083455d, y: 0.7472508497492949d), radius: 0.658754344337661d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33057550016725523d, y: 0.3517955011162984d), radius: 0.014956228469593769d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3181344043502796d, y: 0.6339964812913303d), radius: 0.7337859122681036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8889335570359562d, y: 0.22694741675217067d), radius: 0.30133751315651214d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19644323252100837d, y: 0.9020288533056651d), radius: 0.4863392202258616d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30467456100345724d, y: 0.15561746151034117d), radius: 0.6955984429234386d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6189433074352853d, y: 0.6710546788068882d), radius: 0.4124219621810622d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7215726459948277d, y: 0.4905336955469657d), radius: 0.7615977724979351d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6475162698238373d, y: 0.5874761216838899d), radius: 0.6362427686393041d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5508558032118364d, y: 0.7527669681716246d), radius: 0.9334939694714159d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4076539367399614d, y: 0.43340949835941045d), radius: 0.3436218205357492d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7975626499976756d, y: 0.7001892834483056d), radius: 0.7458471461236132d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06151097005261352d, y: 0.3865462349834814d), radius: 0.4278106146156573d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6878476015904129d, y: 0.18315816242716854d), radius: 0.7264201491133279d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3154339955635208d, y: 0.4977219949833841d), radius: 0.1388431358695823d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6280420509922952d, y: 0.9646947444864838d), radius: 0.39433390154908554d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5637878553032843d, y: 0.6656176562184232d), radius: 0.15534883791007248d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6235351675704126d, y: 0.6891295752638773d), radius: 0.33842229638573174d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7632201621025515d, y: 0.12260676779548108d), radius: 0.30405484518885284d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.978356967191593d, y: 0.8630226447434053d), radius: 0.09805267557495123d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10139305564097734d, y: 0.8488370990642462d), radius: 0.20182986825055882d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5804608853670756d, y: 0.5816836328810147d), radius: 0.3907406819566345d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.402583337868504d, y: 0.7759491982848646d), radius: 0.5650093331540573d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16211719030858174d, y: 0.40491637866676233d), radius: 0.23930179952023556d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.587635671998576d, y: 0.011135992458345956d), radius: 0.41501893674506485d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5010026142113806d, y: 0.6438390213942685d), radius: 0.7667005381517298d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6142976666177057d, y: 0.34223750874888637d), radius: 0.6850941080141764d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5463500479193735d, y: 0.18840580963028863d), radius: 0.37806660477705134d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14930083751641354d, y: 0.1961481883839139d), radius: 0.9468392567911368d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7837238314064378d, y: 0.9669258993605885d), radius: 0.6684592880588843d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28662876379790647d, y: 0.40940461836595354d), radius: 0.7514183137458338d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8091945626514646d, y: 0.8489716762955881d), radius: 0.04954331950964097d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.985425051670849d, y: 0.9068515353833031d), radius: 0.7999175558068011d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.259905641286848d, y: 0.8818521697911661d), radius: 0.5132922741844813d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36374008258479873d, y: 0.4246191026077303d), radius: 0.3379349183721966d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8824295753420135d, y: 0.4584425185158848d), radius: 0.40667018643627717d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08574796409905105d, y: 0.7532791618616196d), radius: 0.23182048665871124d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24980578127216613d, y: 0.982207416761363d), radius: 0.5905156682121647d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7315342563785896d, y: 0.8256697659435736d), radius: 0.03608271560162524d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2797404047337434d, y: 0.5417930117282563d), radius: 0.5381219507517244d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6238688210976889d, y: 0.7388790551760207d), radius: 0.7687019113747239d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7786769096773873d, y: 0.15609409081231396d), radius: 0.4617254420283766d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07855062554251924d, y: 0.5559697753257005d), radius: 0.5913527534789563d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2593762009223908d, y: 0.33285439870967926d), radius: 0.5190732475302743d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03320662001748975d, y: 0.9073731172571945d), radius: 0.6592142576734874d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.657585370303837d, y: 0.5768733733091934d), radius: 0.1878384363869774d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6966175242417724d, y: 0.41417045127606644d), radius: 0.20104374604216568d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.462773951659458d, y: 0.0570377115792331d), radius: 0.02041904295753416d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7531673821479367d, y: 0.021973216109609117d), radius: 0.4848764280835812d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08540380904472078d, y: 0.24154429723044069d), radius: 0.6806924312853468d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06231703440306946d, y: 0.18264857635695886d), radius: 0.7842438806321455d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.821315476082922d, y: 0.1819572077231073d), radius: 0.6007451949769826d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4791550534057407d, y: 0.02616051775119721d), radius: 0.2669609104673032d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13644554357115135d, y: 0.13593883815879593d), radius: 0.8128166745292722d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09501675982815805d, y: 0.4783815511372862d), radius: 0.8254233842341501d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021470256762914586d, y: 0.7849359563352494d), radius: 0.3415646664390791d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9426183047742437d, y: 0.6784630056585729d), radius: 0.8974817797348826d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5437613543456208d, y: 0.23346393873169557d), radius: 0.27261475797252477d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22627960081940168d, y: 0.7946546170647614d), radius: 0.9460677797312141d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4381386264999356d, y: 0.789363275046427d), radius: 0.24706630948099806d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.671051519082467d, y: 0.5981804071041078d), radius: 0.6554263892189766d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28312923716551763d, y: 0.5888888971371111d), radius: 0.47094786420023305d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8115430231455948d, y: 0.3433905098902871d), radius: 0.22495119912450923d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5836398221012389d, y: 0.6353367440380294d), radius: 0.8273822163689415d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8103749718925175d, y: 0.664222605731983d), radius: 0.18610236322003815d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8420633558819587d, y: 0.21671939292390974d), radius: 0.6001213619623524d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2806782707231892d, y: 0.1053512159453841d), radius: 0.7973789145865372d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4400760674623915d, y: 0.5318441932664286d), radius: 0.38262932874490896d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.935809848092612d, y: 0.8618081167772829d), radius: 0.6465266599024252d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10156834449503349d, y: 0.8795314887354022d), radius: 0.36534679737719067d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07988877640303216d, y: 0.15243280931397474d), radius: 0.5099989168101421d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2021298066495799d, y: 0.6381823574559898d), radius: 0.8017980855872604d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5091200916576569d, y: 0.20294923274802612d), radius: 0.6730137119796312d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2114900522751767d, y: 0.268542096327278d), radius: 0.3697097417904338d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09904831165521022d, y: 0.045537420620304525d), radius: 0.48796304145787106d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0011853199775214707d, y: 0.21563517458558412d), radius: 0.6560351943981133d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.956486791306842d, y: 0.9379392312390665d), radius: 0.9352118595907035d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8511904653609554d, y: 0.21620187221102571d), radius: 0.6858860601373724d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6303988282402812d, y: 0.0036017801668627447d), radius: 0.3636524232317496d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4603843828831947d, y: 0.8119154785456013d), radius: 0.6862916454446868d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1597544354370657d, y: 0.7810658185816337d), radius: 0.023828763120748553d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22999228388221382d, y: 0.19981119321887175d), radius: 0.8553993772548877d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3201371208384075d, y: 0.09113573179917778d), radius: 0.7480328574450981d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8478794660040185d, y: 0.6500441681856806d), radius: 0.47948170968370807d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35049389482395d, y: 0.7312048111983641d), radius: 0.5835745669455533d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5957800330254663d, y: 0.9535162943152004d), radius: 0.8042250658109535d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7216422519150265d, y: 0.42436566702041967d), radius: 0.49106521368417655d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028565670983317304d, y: 0.8953140626959092d), radius: 0.07257428835771351d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6400051889292507d, y: 0.8123928811565597d), radius: 0.9301197578575715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8693697075673283d, y: 0.12106831998215295d), radius: 0.0753757692318513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5376075771645372d, y: 0.160132392681403d), radius: 0.1406632611658124d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.776152281826076d, y: 0.02327989318288537d), radius: 0.733280479098907d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22541774899718647d, y: 0.5130795262303397d), radius: 0.6058813017300336d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2979087433550083d, y: 0.3160030916994636d), radius: 0.778178900643384d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49032097646043926d, y: 0.4958760999248021d), radius: 0.5178683177281962d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4572761116744114d, y: 0.3723785746400107d), radius: 0.6298346001254412d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42995283016670016d, y: 0.8601148780500885d), radius: 0.8572963515807915d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9283913238845541d, y: 0.11508968271560449d), radius: 0.5257469110097823d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5680355555128931d, y: 0.7568657091409605d), radius: 0.14555054020358527d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1687007663367166d, y: 0.7295633207407682d), radius: 0.8546791680866022d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7545257274185235d, y: 0.39971128558881175d), radius: 0.4369461199712902d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8687235453629948d, y: 0.7125778428733054d), radius: 0.2919346273479021d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3172602693937412d, y: 0.7539046056112196d), radius: 0.7047128324325067d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5037498293122404d, y: 0.9097547309087953d), radius: 0.43800829568842736d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09072475958463866d, y: 0.7191816619664859d), radius: 0.4545153249400109d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0943286183360258d, y: 0.2572650622627406d), radius: 0.4448997454620537d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.500371303244311d, y: 0.6533683624053993d), radius: 0.3405105323845484d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.519289517280357d, y: 0.9255396102644855d), radius: 0.8410938190650481d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2040862219775057d, y: 0.30063751994098187d), radius: 0.7058680868056638d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7499223895250487d, y: 0.547328940139344d), radius: 0.9824107629815167d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49472836425281785d, y: 0.4112307814754399d), radius: 0.7801484865668102d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9781288810996998d, y: 0.3562851000376209d), radius: 0.17475857961652608d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5195422831498993d, y: 0.7504502031829595d), radius: 0.5070783401827141d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13229781724321243d, y: 0.6410738242067507d), radius: 0.23672742662305157d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9305529359356143d, y: 0.5370193801259672d), radius: 0.9222799377259077d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013674372660003042d, y: 0.47324116915932946d), radius: 0.8163554470300772d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3135286861063159d, y: 0.880065237511675d), radius: 0.9029986776052673d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07923693737892079d, y: 0.8411243658549212d), radius: 0.3610441774781654d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29584901389210094d, y: 0.4949022703833753d), radius: 0.3554819091394632d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14571205745417637d, y: 0.6391188396100975d), radius: 0.43359802798931146d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4310272851778024d, y: 0.48591764567368956d), radius: 0.874863932709935d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17965723180433124d, y: 0.6542750494480846d), radius: 0.7802940808025765d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6398949826792031d, y: 0.8999565938042454d), radius: 0.2019660425659766d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36278091132655976d, y: 0.9907692036048841d), radius: 0.27934096420640875d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9588212606392265d, y: 0.9625846599770187d), radius: 0.7871262889259696d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34914709237774355d, y: 0.6776944198814261d), radius: 0.9161327310909438d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7808749859852812d, y: 0.3993654467057963d), radius: 0.3423016267466553d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4332427081957816d, y: 0.8920194729719009d), radius: 0.5292733580315114d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22711244653821694d, y: 0.8185330931079942d), radius: 0.24268718558863045d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8848983839003466d, y: 0.4362097612189011d), radius: 0.37420316117132146d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5463393216478327d, y: 0.4828481141786408d), radius: 0.4777139396885096d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26130934065929856d, y: 0.7869379129569565d), radius: 0.5149443034702288d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.691740711538432d, y: 0.30392404448774857d), radius: 0.3727388919719574d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14106426671195438d, y: 0.8450992125060994d), radius: 0.18759034953691767d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5749761381915991d, y: 0.6241508442497982d), radius: 0.40172528087880777d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3748978933560808d, y: 0.4225961916920774d), radius: 0.5481614195623695d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5190641575772121d, y: 0.003365275069042717d), radius: 0.4445722352888213d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5817015015566052d, y: 0.6758999202708409d), radius: 0.5695835001988648d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.866737789393721d, y: 0.7099771191345887d), radius: 0.09446384967610633d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2681631339206334d, y: 0.4618217928890457d), radius: 0.26401896094636657d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5098842360689978d, y: 0.3730680163018807d), radius: 0.08821483555155729d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10873633640434788d, y: 0.8179765461145888d), radius: 0.4529162528532281d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25139668942933335d, y: 0.9394520586511557d), radius: 0.622937986121595d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8898869215965203d, y: 0.1422154465374108d), radius: 0.7288208068702869d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5181021878319668d, y: 0.18837154528654043d), radius: 0.571107538130586d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4601814750807629d, y: 0.4046330178618702d), radius: 0.026369441106005587d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5872634473827644d, y: 0.4437436576647681d), radius: 0.0526531078657787d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2724161495366897d, y: 0.702184985918213d), radius: 0.4295135177747835d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7874753063697365d, y: 0.6921166415873061d), radius: 0.6778283932997669d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3642930666396943d, y: 0.3478297305127336d), radius: 0.6891679309039954d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24407293033894872d, y: 0.9652313206273996d), radius: 0.46846711401215746d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0815660759721264d, y: 0.14561989767155825d), radius: 0.35914322248847663d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2128389895511087d, y: 0.32551098533410106d), radius: 0.3487603527711154d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29934159204667465d, y: 0.8231909745542243d), radius: 0.9436845219345337d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7633838810187022d, y: 0.23755241952077155d), radius: 0.10724941732930571d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.595906488136033d, y: 0.3784004939612725d), radius: 0.8978108688326196d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46170403150082384d, y: 0.8821405923187013d), radius: 0.9230910647513677d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22765776024589357d, y: 0.4035941245767649d), radius: 0.5497277934019615d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8892365644480326d, y: 0.06233766320977696d), radius: 0.1554558337041828d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31174036707199393d, y: 0.027288910808744626d), radius: 0.019161751377406278d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5637496365235714d, y: 0.6145094776198269d), radius: 0.2615791431057519d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8330588765739892d, y: 0.22833234848602402d), radius: 0.5450785073250723d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7325493987190088d, y: 0.15470465308056902d), radius: 0.10734639598532636d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9075188596794439d, y: 0.030985342957901896d), radius: 0.3843526261089608d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5597288027340566d, y: 0.7102065274963969d), radius: 0.21758492327609502d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1705985400695792d, y: 0.6974677788955672d), radius: 0.16123341631831734d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23765779070919146d, y: 0.5565157877729666d), radius: 0.19708367519122894d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8455318478882191d, y: 0.5771155478530482d), radius: 0.09433254017233028d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9036643699100548d, y: 0.11091145597003638d), radius: 0.9376408828505073d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3128974318555485d, y: 0.6607914866684061d), radius: 0.8339699131998013d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04574542874494014d, y: 0.9428940472853246d), radius: 0.3879048846291565d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6290784171952801d, y: 0.13672804813780337d), radius: 0.7481450327451901d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3020258342432489d, y: 0.2716023778250587d), radius: 0.29212576671277213d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5708250652816653d, y: 0.7901776441064d), radius: 0.0035684383205589754d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9586636075778805d, y: 0.9331651580904002d), radius: 0.16188412684950404d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3030443764085339d, y: 0.5144613870536852d), radius: 0.27026148731001887d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4552518048023828d, y: 0.6804212845421009d), radius: 0.6262249956913686d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5657028506019129d, y: 0.3276434068521228d), radius: 0.701780215968839d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15381952106057084d, y: 0.06850623707259729d), radius: 0.4478652270365747d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3866800362887216d, y: 0.14996833257559794d), radius: 0.33049419819109305d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2820581206730839d, y: 0.08710744430846551d), radius: 0.40971680116921694d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42504989497308554d, y: 0.6185379015335463d), radius: 0.837624049121305d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923454659570541d, y: 0.704401650326667d), radius: 0.3170960264616487d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2379011538678646d, y: 0.8578308543885597d), radius: 0.8586927486206969d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4296368115050986d, y: 0.16834738680809602d), radius: 0.005599363442382321d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5041577644281677d, y: 0.8195861361339063d), radius: 0.6687106219981493d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.734538249320959d, y: 0.5809775354049156d), radius: 0.8743475537268177d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37876570049292024d, y: 0.8054115066911706d), radius: 0.04731990925022711d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4510197301551785d, y: 0.6794758079861501d), radius: 0.745188190619168d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1333548884130653d, y: 0.7429898215474049d), radius: 0.04574668549296301d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8109313985185832d, y: 0.1016505167342715d), radius: 0.48359496762646914d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5378445485842217d, y: 0.5371633716896586d), radius: 0.09960525983597135d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3133853873891931d, y: 0.5435512578490902d), radius: 0.7829828155647147d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8031766222292511d, y: 0.24648928539144543d), radius: 0.02181766779792449d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7342928784346421d, y: 0.7633515910428978d), radius: 0.35083736467490556d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7860719245749245d, y: 0.427653261340884d), radius: 0.3612549655401658d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47408183104449386d, y: 0.47211632205185294d), radius: 0.44820023044959556d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6524824946856909d, y: 0.13501863668676373d), radius: 0.13539716539149882d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9867864388081095d, y: 0.010864330395893074d), radius: 0.5791688125583904d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9938651417924574d, y: 0.13046872713889301d), radius: 0.30864655814306163d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7003944108680688d, y: 0.6298454097147593d), radius: 0.21026957769656385d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9557265376273634d, y: 0.9322611716701261d), radius: 0.2655938452507215d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.263281560126017d, y: 0.40323969100860946d), radius: 0.7621823549259247d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4045344283761054d, y: 0.9559123950822188d), radius: 0.5127752091122135d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3625159691114056d, y: 0.2707195977509391d), radius: 0.9640065862691338d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4513347516473054d, y: 0.7079858571135195d), radius: 0.22854045461623307d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6824169734704877d, y: 0.059859722573720964d), radius: 0.5502634972301839d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026359631626254654d, y: 0.6539529921084537d), radius: 0.23180055766795626d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7418733391038178d, y: 0.8328647387835327d), radius: 0.27009270505891025d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7297469835744933d, y: 0.9634329715875907d), radius: 0.4134027985391484d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9652198185551037d, y: 0.6058982105973169d), radius: 0.8472204549700334d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8421013403135894d, y: 0.7155236962231485d), radius: 0.07245676728491512d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6197236373690929d, y: 0.76951922229966d), radius: 0.7869768463627645d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6240288516231972d, y: 0.4115623051766786d), radius: 0.9705449202715826d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5807925062816159d, y: 0.05544382969914752d), radius: 0.25090665920959065d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5538284671681143d, y: 0.2378532664162465d), radius: 0.7560057479716442d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47197927600513534d, y: 0.2277754282883071d), radius: 0.4940508091792737d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34531896231474735d, y: 0.029406591383050573d), radius: 0.5305974310630104d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7290041038002799d, y: 0.32391173373266424d), radius: 0.5994969476881549d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05880999301633916d, y: 0.4419266608868673d), radius: 0.33008663485965695d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9186463160329418d, y: 0.17417475271461946d), radius: 0.1643183990625522d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1353885182447515d, y: 0.23384770079297434d), radius: 0.3697512280074502d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24868663574169336d, y: 0.020453176453962163d), radius: 0.685721359979027d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5947309468546612d, y: 0.4434788746180254d), radius: 0.19850904034437566d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47500661257220045d, y: 0.9270895790925036d), radius: 0.09864507239939635d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11865454673659825d, y: 0.5909648694826454d), radius: 0.6214211951141351d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5385467328350545d, y: 0.8939090395382598d), radius: 0.9123740679433292d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16685087615469796d, y: 0.4023254998393375d), radius: 0.5185789157592648d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06530009787923152d, y: 0.36754464887202787d), radius: 0.6877102030755786d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4725017099605292d, y: 0.33708500886756254d), radius: 0.5814613216576383d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3011432610131394d, y: 0.5614669601585949d), radius: 0.2093840098630786d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9930286789014846d, y: 0.1636643122578917d), radius: 0.14374779478074884d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6248581746632861d, y: 0.49815993783950807d), radius: 0.8791861145243828d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1920603914711314d, y: 0.9167369954980367d), radius: 0.42279578603626344d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3494789828948539d, y: 0.31850983447231107d), radius: 0.9873965028752891d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06959068676380387d, y: 0.3229163783118444d), radius: 0.3877075288156653d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4770029438121607d, y: 0.48008857649156733d), radius: 0.8419313443213672d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10941649892226102d, y: 0.08815884672711849d), radius: 0.46779600096019003d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4706150792887056d, y: 0.25700124970522675d), radius: 0.5574208686923929d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7982272571654347d, y: 0.3585747237701019d), radius: 0.025841885128079056d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4542737127341705d, y: 0.23348772221507175d), radius: 0.21176194111255342d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11690430059112866d, y: 0.6632636115333278d), radius: 0.5740843110760389d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.867656999048149d, y: 0.1860137957699205d), radius: 0.09690943259929985d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05198278379111887d, y: 0.7519732425849234d), radius: 0.6791495444501782d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15818973725147023d, y: 0.5571193921833831d), radius: 0.7659666434237692d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8413298135064656d, y: 0.588695143624367d), radius: 0.08835946300455533d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3172305984954691d, y: 0.7145476301136183d), radius: 0.6588401446608646d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6653289445355323d, y: 0.7323034213024741d), radius: 0.8287983276408873d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7895711944701445d, y: 0.1800650580157772d), radius: 0.923498088999545d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10899705623710576d, y: 0.6152307104758962d), radius: 0.844451758747524d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.361269426699259d, y: 0.023266098461988793d), radius: 0.3645516750349852d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18164695553242038d, y: 0.8408952288758401d), radius: 0.3367954151667747d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5463223187029727d, y: 0.4410212853485235d), radius: 0.8301845568193988d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6241382133322365d, y: 0.46436625476599624d), radius: 0.18821227050713718d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05883691710831751d, y: 0.10855822166432938d), radius: 0.5696565618300309d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17908959551255954d, y: 0.6711807653240879d), radius: 0.20010150835152707d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14407880124996486d, y: 0.918455184230017d), radius: 0.34293510095912194d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09141449935105994d, y: 0.23373545720196343d), radius: 0.2680413391938531d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6548959562312119d, y: 0.5057115750402489d), radius: 0.7073257527887156d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9405103834682934d, y: 0.5458267513728213d), radius: 0.3306303085671487d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21688526624062432d, y: 0.24659313721931087d), radius: 0.588084189912205d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7115167498047441d, y: 0.0856000604020769d), radius: 0.9744236398128057d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9855654205197488d, y: 0.7061855984651206d), radius: 0.18965112256952565d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8923715315056978d, y: 0.7316420042049021d), radius: 0.9487065429678625d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08296138345685522d, y: 0.08199723787472624d), radius: 0.7573933099619933d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.902864408870613d, y: 0.1650732570361647d), radius: 0.010816263975036433d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44659427466956003d, y: 0.7698148684352628d), radius: 0.5126174383081453d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43672139806446164d, y: 0.8357886751237884d), radius: 0.5236660463623489d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39231430030994685d, y: 0.42318463515151983d), radius: 0.9685806363614158d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7018732728823718d, y: 0.957327613366329d), radius: 0.1294375036842993d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6079519852945889d, y: 0.27314615276297494d), radius: 0.6461242074779413d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6665630391323544d, y: 0.18683095953914675d), radius: 0.8331832321674509d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.571916716129754d, y: 0.19241123628327583d), radius: 0.6488598150835881d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9302579313056009d, y: 0.501211123304946d), radius: 0.009872991831392675d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6391844758752943d, y: 0.5998532997492879d), radius: 0.42908059960132316d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7203181297386874d, y: 0.1997286714199873d), radius: 0.6562516006037536d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24973078160646978d, y: 0.9707535659120593d), radius: 0.5761662347205975d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7149538914830166d, y: 0.464644030992474d), radius: 0.409936840634741d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8977167358464699d, y: 0.20018200875633008d), radius: 0.42518951248197046d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07140434833853171d, y: 0.07840222813448716d), radius: 0.5142557770948387d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23662892796483592d, y: 0.4703684709918722d), radius: 0.28963258803962355d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11588978054533161d, y: 0.9416597831724709d), radius: 0.6375830020680061d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6692228545894053d, y: 0.6421448227486449d), radius: 0.42851616403993775d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38452921520370364d, y: 0.9036681609011795d), radius: 0.22311142683970042d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44931818050921757d, y: 0.7622518357497683d), radius: 0.4775520182581915d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7606641548416084d, y: 0.6576929149482749d), radius: 0.17538090135349405d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17030782674952272d, y: 0.5979361582843914d), radius: 0.959958417796093d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47308172152360584d, y: 0.17549078428745846d), radius: 0.0844578438579009d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36085472922407746d, y: 0.7130696327287245d), radius: 0.7149588450362004d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5996620962633404d, y: 0.2540398768678832d), radius: 0.396345713924078d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2595462441561933d, y: 0.22831337523063988d), radius: 0.49872835856288744d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9484186598631704d, y: 0.2014849706236198d), radius: 0.8090935917569831d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6121559825308072d, y: 0.8480817413304609d), radius: 0.18117319987597058d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7659711172728866d, y: 0.42573758986215005d), radius: 0.7108381657027476d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.050812436064802124d, y: 0.6655731489104649d), radius: 0.8504420268640077d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18064134661903497d, y: 0.8480860653157946d), radius: 0.27972816795109123d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4690158928309629d, y: 0.6363119083506652d), radius: 0.3393899566949843d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8924537267391115d, y: 0.7619702705305702d), radius: 0.6359443961617586d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08499383019657947d, y: 0.8744296601186636d), radius: 0.08372225675016942d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5414077259667517d, y: 0.9863198195151629d), radius: 0.46984382316992124d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7550694257109952d, y: 0.6313899752952035d), radius: 0.17030584082683975d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21239705194285274d, y: 0.6212653360112487d), radius: 0.2349120234641089d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7286587158461065d, y: 0.2780423401042432d), radius: 0.018145358467911987d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14777872985707352d, y: 0.6360576785329407d), radius: 0.23343228893509904d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10902977398184366d, y: 0.8631527629172254d), radius: 0.32285673407267723d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3510733871116676d, y: 0.15691915761848618d), radius: 0.9294747588087537d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48878185280488795d, y: 0.36300358010480493d), radius: 0.12297993894693793d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011686884373524498d, y: 0.08321286473543277d), radius: 0.26715500543341286d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8330567586701116d, y: 0.3684775818562781d), radius: 0.6512704542348167d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.473107346673712d, y: 0.7881979424528102d), radius: 0.3223539292020814d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6615301613961588d, y: 0.4145948079132685d), radius: 0.5830284354232343d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05188642714600755d, y: 0.34482727951563896d), radius: 0.25278504358595755d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5496008946195806d, y: 0.2659367301580443d), radius: 0.8786046223457691d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26618983446607314d, y: 0.3475066273231877d), radius: 0.19351038931093467d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7663547988365128d, y: 0.7536310349860824d), radius: 0.69181971323109d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49215373811538876d, y: 0.6126429453116908d), radius: 0.04676776645229985d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009825380206538559d, y: 0.12990478988323828d), radius: 0.0761977691953426d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3729096409488817d, y: 0.45614766465361d), radius: 0.474318415706636d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23612410023387875d, y: 0.6080357913965911d), radius: 0.11095134354358827d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6669100203181021d, y: 0.9062285114415772d), radius: 0.009772315450030211d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13573670652341052d, y: 0.808188275303565d), radius: 0.6448165090067354d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04935345738239583d, y: 0.4456073534498036d), radius: 0.2593934749367023d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48875492298300094d, y: 0.8906298880664932d), radius: 0.7837465739258662d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29271488523117284d, y: 0.6594141586218131d), radius: 0.013417212969135228d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48984509894552464d, y: 0.649840438544761d), radius: 0.7164673182215434d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25263219072480303d, y: 0.4822154425647852d), radius: 0.15650926733765191d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8325825817746272d, y: 0.6201633840675141d), radius: 0.8570312483489109d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3678508448378205d, y: 0.6088391337610503d), radius: 0.013863906288955952d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6513232412275088d, y: 0.2837945306428422d), radius: 0.1558894584544127d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8181554500313448d, y: 0.9721105000477709d), radius: 0.1713798510209008d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8669770326540048d, y: 0.8460756755377534d), radius: 0.4497414711014234d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9527202099778896d, y: 0.4999443261621517d), radius: 0.3906153340792454d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44508815003720115d, y: 0.7467182479533648d), radius: 0.7975871453270209d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.899296946837683d, y: 0.19174384522805799d), radius: 0.5037459267081924d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3802335387748903d, y: 0.7064274203086894d), radius: 0.37603283623727746d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281801537057845d, y: 0.4959629965712291d), radius: 0.8261471024017321d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5477113045005667d, y: 0.8308702523051608d), radius: 0.15316843772393396d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6974312276923372d, y: 0.27452508970011413d), radius: 0.7575944228488535d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5761422865025165d, y: 0.040479842930127186d), radius: 0.852970468632946d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8150823612851013d, y: 0.6257418947840969d), radius: 0.8454355950671685d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6094614103520022d, y: 0.884073893665025d), radius: 0.3947339383144981d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15700795422801883d, y: 0.37173093331221607d), radius: 0.014602429550002904d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6122462849327397d, y: 0.7025719202231722d), radius: 0.8879203399694323d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41922396923670746d, y: 0.3962155146545635d), radius: 0.9250020541253173d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3115702407452575d, y: 0.1175961424500499d), radius: 0.013368177463262576d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41322184893841474d, y: 0.10946290991135366d), radius: 0.8904764813898091d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7331200760172462d, y: 0.11161543743247959d), radius: 0.38994700331655285d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20094208455677964d, y: 0.2643804122785479d), radius: 0.4447228934993026d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5554835756881829d, y: 0.28976977289080474d), radius: 0.05992354126770083d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3261017436927661d, y: 0.5476777802248394d), radius: 0.5138646082601375d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5814979945196663d, y: 0.6844748544698022d), radius: 0.7458861517386892d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20170149609942245d, y: 0.36018060795596696d), radius: 0.16965144040201452d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9212175844372084d, y: 0.7183914086033591d), radius: 0.4707052995300993d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3989795849793193d, y: 0.960914030672106d), radius: 0.8155269743743043d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7305797067081545d, y: 0.8246573705911536d), radius: 0.3948875698177844d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8771059959479297d, y: 0.02496815219235138d), radius: 0.5352514237694717d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6606762874699441d, y: 0.7810882455357679d), radius: 0.37495465424277685d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9832835803288174d, y: 0.23168928607510197d), radius: 0.41606505833942997d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15084079068799316d, y: 0.5287977959799981d), radius: 0.32232508183427755d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1336633501030271d, y: 0.0020925534979294724d), radius: 0.03834695374725117d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5107482677821138d, y: 0.290206729649673d), radius: 0.7355788967051754d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5223565671782759d, y: 0.26316665525204086d), radius: 0.9834074110126716d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4421653483362661d, y: 0.049068171857970855d), radius: 0.10796308652267816d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.741638216726518d, y: 0.5136871306878111d), radius: 0.6405439377634939d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9363898085169028d, y: 0.27779403730490804d), radius: 0.3395553222019333d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7305397193292406d, y: 0.9075810361062572d), radius: 0.9802795576547401d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4978887007102518d, y: 0.027942154633604277d), radius: 0.19725156956331624d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2848287314761966d, y: 0.9666452398616814d), radius: 0.5368899703661604d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9895904294414923d, y: 0.34720047987805835d), radius: 0.950290185709084d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8258905937133593d, y: 0.4313308974414225d), radius: 0.8104659071373468d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39453997394654927d, y: 0.5756711919004124d), radius: 0.12538512041251682d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3978040229511657d, y: 0.6375619278830508d), radius: 0.8537806242582128d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9371426696852572d, y: 0.982549416958289d), radius: 0.9322901487236109d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5489241297391135d, y: 0.5808761965779987d), radius: 0.930481623265209d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5773003130073815d, y: 0.5878608569270678d), radius: 0.9278408670955349d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7440713923385003d, y: 0.5378097834995139d), radius: 0.3780139055516003d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7514683300338192d, y: 0.8713615812247589d), radius: 0.4696792675194653d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16979345111666144d, y: 0.4844616125839313d), radius: 0.9232856111952824d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6986301411344815d, y: 0.10794519772149269d), radius: 0.9870656433530515d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09676132961223516d, y: 0.46988110235482294d), radius: 0.09580748235054315d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1749098559243477d, y: 0.582359882903653d), radius: 0.9590009195731686d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4949764283153213d, y: 0.9989325582900439d), radius: 0.079417998048538d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12311204029675926d, y: 0.8100621518453784d), radius: 0.34300964686749835d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9756781925742414d, y: 0.354115901750913d), radius: 0.5237634893748236d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4973768010842866d, y: 0.2664758935323246d), radius: 0.14079976459879706d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8696304788731621d, y: 0.5997901599142744d), radius: 0.933688818026671d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5153538149775d, y: 0.7084514126040105d), radius: 0.30394082127146094d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5101553809319603d, y: 0.3166244814175784d), radius: 0.7426508548882883d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9130389321759687d, y: 0.7679819300547257d), radius: 0.8929895079018262d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13992750950354027d, y: 0.48043500298426633d), radius: 0.003321578027540073d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6298236888579615d, y: 0.03276657373210534d), radius: 0.8420145315123776d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4686497988637781d, y: 0.7706865317411499d), radius: 0.5944993257752739d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24984777065030583d, y: 0.13997599180611142d), radius: 0.12988332267071345d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2838509310375593d, y: 0.1003305866638401d), radius: 0.19455947334025703d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20538799003154284d, y: 0.17039667370121625d), radius: 0.790553003219708d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9540478924815283d, y: 0.662553784688023d), radius: 0.8357058336009657d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8056455889559563d, y: 0.16086293921325223d), radius: 0.3877261882060917d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6020781266429533d, y: 0.48809496102075856d), radius: 0.6973952409837626d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9775234917021421d, y: 0.6481206763908167d), radius: 0.5291879544540581d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5668781243133437d, y: 0.14199645393317817d), radius: 4.797987182292296E-05d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5628949236688015d, y: 0.1425029868790887d), radius: 0.44061526520152494d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35835125205294616d, y: 0.3788035146115517d), radius: 0.22580250243322708d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3266306168354465d, y: 0.39790922689271924d), radius: 0.3727505060895455d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5128798450575484d, y: 0.8814615591843562d), radius: 0.8069860191304227d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8137277110250773d, y: 0.04373610253796878d), radius: 0.04119482908301031d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30158491175965174d, y: 0.5000579353320648d), radius: 0.9426865471360008d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02695879706142701d, y: 0.6599520818372637d), radius: 0.6482098954347805d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32529786816115014d, y: 0.016580055666839177d), radius: 0.5820795475637625d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11434511225741373d, y: 0.6200307147850443d), radius: 0.9794685680224681d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18310592279997306d, y: 0.30134237250295337d), radius: 0.330291290736206d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7813707763620981d, y: 0.039237273670202466d), radius: 0.9841516055125435d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4405942663527953d, y: 0.9810948796173546d), radius: 0.1845628029405666d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44384965759386663d, y: 0.5887341701106604d), radius: 0.671855736518985d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2411403982696093d, y: 0.48753021380042516d), radius: 0.7164763073373769d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791268739711684d, y: 0.8322920662077121d), radius: 0.17284853331352767d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45304274288802493d, y: 0.5432305336347284d), radius: 0.7085621859073328d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.045198488458877084d, y: 0.13460336045985422d), radius: 0.6689614132882133d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5948285301463102d, y: 0.13444692467735453d), radius: 0.36427643681514077d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8754519740884834d, y: 0.7495869713006634d), radius: 0.47667846089406685d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.260377442136671d, y: 0.045058264957800964d), radius: 0.8415515661502194d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.582923790389575d, y: 0.31979581235136656d), radius: 0.011821884627014834d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6061376627968376d, y: 0.7246317656089653d), radius: 0.3912641157833401d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10068562029553096d, y: 0.07030411464857944d), radius: 0.6370096825996965d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27199237229172357d, y: 0.37742283381557407d), radius: 0.18146890443441932d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7578729083663005d, y: 0.4745646008274931d), radius: 0.38910122478013287d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42564263486106213d, y: 0.414250203762456d), radius: 0.47277171958088093d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8730685869526169d, y: 0.6792102932425079d), radius: 0.6486972258250918d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12385764169424562d, y: 0.34447606808263265d), radius: 0.27653365459440926d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.708484896999792d, y: 0.041278426679097646d), radius: 0.8987951269322495d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9347788893386451d, y: 0.6053032362304861d), radius: 0.04682253635012723d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1980852647829764d, y: 0.5689472768920179d), radius: 0.910586335579621d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6668474261392491d, y: 0.8156118085238276d), radius: 0.7273786990679195d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1546527290934434d, y: 0.5748679345270621d), radius: 0.5840433403548356d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1786004738268896d, y: 0.443980915664532d), radius: 0.7123418186664183d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007638772871820909d, y: 0.6015982494456642d), radius: 0.14344658653562248d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5255368959254699d, y: 0.36044134682991913d), radius: 0.6091612662660618d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6512212017291155d, y: 0.39855144729635206d), radius: 0.2654354199775848d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6929053925646045d, y: 0.9312612713787389d), radius: 0.49111660153586345d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6258105756794189d, y: 0.8240507941844357d), radius: 0.8312443566420293d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7456723281551245d, y: 0.7713764607969487d), radius: 0.08748169695036889d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23467582491546812d, y: 0.1747046782845606d), radius: 0.9439429249474037d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.743187210969958d, y: 0.13991214421224407d), radius: 0.3913231815772227d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4570516132903977d, y: 0.551529414640029d), radius: 0.6217285148435062d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021865462931204727d, y: 0.5761980583125185d), radius: 0.9364627687982499d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.749637184387999d, y: 0.6975212664813539d), radius: 0.8978129018923101d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9080990755660848d, y: 0.07763144180782333d), radius: 0.06958219432674961d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6400486681396782d, y: 0.884749486253707d), radius: 0.4065720353525737d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42172052786106873d, y: 0.4313072891485892d), radius: 0.85509234564227d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8041684099141939d, y: 0.3900281175255289d), radius: 0.7023572332236874d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5035112296005927d, y: 0.6837819593793396d), radius: 0.45557045965638865d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9796035942970373d, y: 0.4548761314301276d), radius: 0.4977042193273705d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6953551035988511d, y: 0.4431326432024427d), radius: 0.21650619869761634d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32245355336845316d, y: 0.02701599491236406d), radius: 0.31937610587386d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07874103190434079d, y: 0.8127980631431976d), radius: 0.9327108580632631d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4903633450025301d, y: 0.23224136064731293d), radius: 0.724943472316409d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03622991249577601d, y: 0.259581260741259d), radius: 0.31651013825850527d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3899600132118295d, y: 0.523289310138616d), radius: 0.27104712907357664d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10587163105618591d, y: 0.23740601683528761d), radius: 0.4756804885662216d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9835603163916393d, y: 0.655895855558588d), radius: 0.4806170287633641d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2856914451807815d, y: 0.8770440488341311d), radius: 0.549477315383658d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.453699029707055d, y: 0.8291991483753296d), radius: 0.7383824788803371d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8978070625198364d, y: 0.19116263370452158d), radius: 0.7606342210575096d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6985820895222113d, y: 0.5415969114922218d), radius: 0.472946525971465d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4705923462494225d, y: 0.7285427356620211d), radius: 0.35614979341183095d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7455667986045215d, y: 0.258231189652404d), radius: 0.9933521209080812d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3606717907718813d, y: 0.6424454203467913d), radius: 0.02698141297197154d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5909279496582133d, y: 0.9973005099398491d), radius: 0.7385235242563389d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2342069060588391d, y: 0.9364619507797695d), radius: 0.7148243773462487d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4272513460467281d, y: 0.7294584689046879d), radius: 0.7644057331322633d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28932133728594756d, y: 0.005788425851163792d), radius: 0.5283255013707696d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6672519550909248d, y: 0.37181481545556894d), radius: 0.07096416877531342d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8318387794763136d, y: 0.7264975913010181d), radius: 0.18839902576998424d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7099237477065352d, y: 0.44628351834477176d), radius: 0.11658259854977981d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6947674659561831d, y: 0.02882380429864917d), radius: 0.3395423617024419d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5261334810711622d, y: 0.6073996609917212d), radius: 0.6376575190798166d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8827280026283649d, y: 0.2538853295851212d), radius: 0.7908312473524768d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4463146546973452d, y: 0.866598075965631d), radius: 0.22464017855500662d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7430650008322114d, y: 0.2353145613943799d), radius: 0.8746175340894609d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15482924284531585d, y: 0.5860891420681371d), radius: 0.7848939909406115d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7410555649623116d, y: 0.2148993561663317d), radius: 0.5505463683019715d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9974517662100224d, y: 0.3481689108334355d), radius: 0.3023657381222079d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1904421156762346d, y: 0.9256837752388876d), radius: 0.49149133418230073d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.283553426052112d, y: 0.9040036712786209d), radius: 0.6956605233272412d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9438776625082284d, y: 0.23646850465117053d), radius: 0.03213136229082458d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38844708276320794d, y: 0.3698108435469514d), radius: 0.34419051543590184d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43176561073343855d, y: 0.23325927481940623d), radius: 0.3677577111026781d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.997996399801479d, y: 0.08127297388281407d), radius: 0.5964406715172618d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8503550271832384d, y: 0.009033508476678165d), radius: 0.44607669629428237d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2506098513910433d, y: 0.8332494473376069d), radius: 0.853387221794628d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6537662028743193d, y: 0.35403986496358886d), radius: 0.5899331111064984d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45021643611518636d, y: 0.3694936875586613d), radius: 0.48564353313671993d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8422082401971124d, y: 0.43830045497624115d), radius: 0.2262094676897064d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5262038500862007d, y: 0.3987534596416711d), radius: 0.9877471778165083d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6240136309891503d, y: 0.6711472284493369d), radius: 0.22357343923772333d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6878414168520545d, y: 0.9885529907293912d), radius: 0.7632418538593785d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17658096904674025d, y: 0.9893706438934301d), radius: 0.16330250158168358d), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7614880283065586d, y: 0.7775849405626362d), radius: 0.31377974005906895d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5630953383987322d, y: 0.7824602670153159d), radius: 0.4411670565501874d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35494739256427577d, y: 0.8367736888582732d), radius: 0.5398322729202276d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5254944049792767d, y: 0.46430430332899797d), radius: 0.20336263498818774d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8040025925461565d, y: 0.5568714537467969d), radius: 0.7127909146606674d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5950270401211291d, y: 0.864906239115648d), radius: 0.3142895221095584d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37021449797298667d, y: 0.5436611800177075d), radius: 0.08606482942975502d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023288107253216395d, y: 0.3483209564327512d), radius: 0.31752551555535236d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48749424910205774d, y: 0.1765877042906311d), radius: 0.6173881950371032d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7213991487592438d, y: 0.9364047304254512d), radius: 0.536824249957177d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08270191124826021d, y: 0.1930833884512677d), radius: 0.6474830001778371d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7521361535180586d, y: 0.09295285610520787d), radius: 0.8887381135831103d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050015360722438d, y: 0.5692677824826116d), radius: 0.31815834888086925d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07020204647324335d, y: 0.495265957376991d), radius: 0.34556430763462764d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11222823098664447d, y: 0.19223205978122027d), radius: 0.4853108787992989d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3225639413497815d, y: 0.9740178217492833d), radius: 0.8466822265209487d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5443849604494672d, y: 0.19262539903525977d), radius: 0.014569434980956975d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9191471742720024d, y: 0.8690005821851595d), radius: 0.36695960798818417d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6956765136753227d, y: 0.28449812314886647d), radius: 0.11519426362319918d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12648697369982287d, y: 0.46360375841866075d), radius: 0.6793812644904117d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2178783122182153d, y: 0.7325220199642465d), radius: 0.08837051485865444d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03968246820085186d, y: 0.46086090642537614d), radius: 0.4391022101754207d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7549681596047093d, y: 0.5032319578799762d), radius: 0.25875860256240635d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6979708761680208d, y: 0.8305214019146813d), radius: 0.14034205660136345d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32198050287462354d, y: 0.7612200101340071d), radius: 0.6041865642775381d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01625673104308678d, y: 0.596014580155719d), radius: 0.8797433730621245d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7021989263521707d, y: 0.8100592053434296d), radius: 0.8264370691111542d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.883255702153364d, y: 0.6390616192686324d), radius: 0.9384619310351546d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05618789566386295d, y: 0.7247189216359331d), radius: 0.9829069190744423d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.601811991091592d, y: 0.8012290221781502d), radius: 0.39882264273173995d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028288689573309433d, y: 0.5414946003238752d), radius: 0.5186127063111486d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16186894927121187d, y: 0.04539087808969533d), radius: 0.23219437560547884d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4550773031119021d, y: 0.4982927449705058d), radius: 0.7413425971895995d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5747613866663946d, y: 0.44938149779546366d), radius: 0.6851407052401527d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2619863484428583d, y: 0.07812364477892964d), radius: 0.9797986578106169d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5430939220243586d, y: 0.22541574105126516d), radius: 0.4554829104292074d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10356826581303935d, y: 0.6132001583684984d), radius: 0.3153643908278958d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8694445190594561d, y: 0.7449697447320223d), radius: 0.4003191912753463d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12911776972626565d, y: 0.48946031609948615d), radius: 0.6106052389474527d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24114540131855766d, y: 0.2063079635004137d), radius: 0.6358706378714789d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5041068375558996d, y: 0.5331269139495712d), radius: 0.0972977466508339d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8152897718583152d, y: 0.8666638546756518d), radius: 0.10317764453691425d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025627944206484843d, y: 0.8743996459495141d), radius: 0.9110239176872185d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4582637013259583d, y: 0.4090500194898439d), radius: 0.2636349119406236d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9239262034345552d, y: 0.34153597364733623d), radius: 0.30530918054813005d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8579230270674176d, y: 0.2925505335194132d), radius: 0.9818414476006249d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8202665574084399d, y: 0.21996705988630816d), radius: 0.8002769097742446d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36938757325299587d, y: 0.17350246552508564d), radius: 0.9376745045681023d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9088038387501084d, y: 0.18131597604409522d), radius: 0.16773844604068233d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19339651784080725d, y: 0.9306722395139992d), radius: 0.4428343027784679d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8163506353380512d, y: 0.25879930210166113d), radius: 0.11197368236617655d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6091921692731644d, y: 0.2669175008605075d), radius: 0.10883533125798206d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5394842904066615d, y: 0.2463118288461692d), radius: 0.7524554716887171d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9532065623703037d, y: 0.28200625650099564d), radius: 0.9434449502361986d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7155841569825984d, y: 0.21147839876982277d), radius: 0.2812516296009694d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.481321806277517d, y: 0.6254191297444562d), radius: 0.9129737282901742d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.430510065065453d, y: 0.5276499234249543d), radius: 0.9725168521475377d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6050418403571819d, y: 0.14165180119790022d), radius: 0.1444948255558426d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9890690908760058d, y: 0.6398826131274508d), radius: 0.7056345891479624d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1927344177579965d, y: 0.2703235758257645d), radius: 0.7362573280897556d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.644106141012862d, y: 0.42480372544742984d), radius: 0.7492197216033594d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23746738183654847d, y: 0.4236148056848459d), radius: 0.8852694635563282d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2665824593367453d, y: 0.7846458507497128d), radius: 0.23429100347436316d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7033143334513031d, y: 0.6298215363745757d), radius: 0.255490953881089d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9784872482463381d, y: 0.5882667497769826d), radius: 0.1273163376413049d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44677831145219615d, y: 0.23032365297794088d), radius: 0.9274791770816945d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6646286872528531d, y: 0.6950253502276461d), radius: 0.07567999673319492d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25140094682523595d, y: 0.5920025207182518d), radius: 0.4801002759941817d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17647164918613034d, y: 0.8834801321758968d), radius: 0.4859002509723005d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8973821098320328d, y: 0.4988796246692383d), radius: 0.4059109132671562d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3270374326067922d, y: 0.4987832622655173d), radius: 0.8690992432915849d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6010903138851971d, y: 0.1482317642445199d), radius: 0.5757129454765737d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9315736039094542d, y: 0.7813408044804261d), radius: 0.28064916673810847d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8174765541011113d, y: 0.8035371048711766d), radius: 0.8634962901820429d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3149230250791436d, y: 0.6612900759868153d), radius: 0.3467637213046215d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8861603410307153d, y: 0.5925251223056835d), radius: 0.46136889036480544d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49007385029947315d, y: 0.27434856661398754d), radius: 0.3082807620921726d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8401959968366548d, y: 0.6853125966866475d), radius: 0.36619171711503895d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3541061666118632d, y: 0.5085091606206957d), radius: 0.527511935383379d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.950339346626801d, y: 0.45266358773854176d), radius: 0.8732771876816652d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.886238685677775d, y: 0.2887689358360176d), radius: 0.4041116335979633d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9227668773989676d, y: 0.6872333068099375d), radius: 0.7697600041843402d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8798192799693498d, y: 0.6896652118138611d), radius: 0.5930027380597971d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9734309117330322d, y: 0.3254623343110534d), radius: 0.709481461953522d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8631768579701786d, y: 0.658426828740279d), radius: 0.3593839719929952d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9587846356873422d, y: 0.9651466914532583d), radius: 0.5337661120078714d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8485368060496914d, y: 0.5988079708776458d), radius: 0.11251151917064472d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5686431634745142d, y: 0.610634897964012d), radius: 0.0735847649623741d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8847038912191911d, y: 0.40261381886162007d), radius: 0.2931838835442653d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5834737503994528d, y: 0.37505198423720343d), radius: 0.06801228253950364d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009367963506229926d, y: 0.7439825640665647d), radius: 0.7884327170658051d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08166898923903598d, y: 0.43188341004046926d), radius: 0.33200959118383644d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5581365612460046d, y: 0.5697225733421833d), radius: 0.21244980454845852d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2620848856517024d, y: 0.12720752217609144d), radius: 0.7892072299538948d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45353506806471056d, y: 0.9232691156929517d), radius: 0.39757315243910407d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5589990503499211d, y: 0.6728627900634367d), radius: 0.006415130028864735d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5250534836659374d, y: 0.6199899310810284d), radius: 0.9529297029955403d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5639653223508455d, y: 0.8018775578721051d), radius: 0.8910494119596538d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9700827642379883d, y: 0.5697663207313858d), radius: 0.26827940877250234d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7065924774180129d, y: 0.5826918842235573d), radius: 0.3273609413857117d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3403913976419435d, y: 0.4058435169206479d), radius: 0.4752807519552953d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44014173531793876d, y: 0.15894036233397213d), radius: 0.7483346568644935d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5549351419639351d, y: 0.39650854566234306d), radius: 0.4371755634702983d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0555193785355107d, y: 0.6399809455273199d), radius: 0.17292195000911015d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19315418017114072d, y: 0.5667951976246419d), radius: 0.17455391679150367d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5083035433119456d, y: 0.04907633374089149d), radius: 0.713952684814759d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8609610339268878d, y: 0.30638580825033734d), radius: 0.589054847804747d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3089229468547088d, y: 0.5034130975277203d), radius: 0.13270806019150505d), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4767182919985655d, y: 0.470543744620576d), radius: 0.5266217957829737d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36505507804534887d, y: 0.3636917510125225d), radius: 0.06780171126070156d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9478676943143844d, y: 0.2221381781301225d), radius: 0.29467560601565934d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0964626002326292d, y: 0.7312355313175269d), radius: 0.5110669019920462d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47744338660302865d, y: 0.3478172011887226d), radius: 0.6392741400746286d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33760240443213907d, y: 0.38135285001696684d), radius: 0.20075007307549764d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9120459770611327d, y: 0.4864398485571445d), radius: 0.7852713035911271d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7100851022121184d, y: 0.3039298631983498d), radius: 0.5862820466201013d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7995575800696174d, y: 0.6981777303696374d), radius: 0.1799263899380722d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8414363944420065d, y: 0.7673373734463463d), radius: 0.9825297762665172d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3000505987673098d, y: 0.7504993759945797d), radius: 0.9830577646167403d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27207197237119785d, y: 0.061673498756404155d), radius: 0.3734606534389373d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29997577434204314d, y: 0.6837461563279982d), radius: 0.7600470017887327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5977151222527642d, y: 0.22847520817177103d), radius: 0.9284783572669197d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7375099919067041d, y: 0.13212928676436686d), radius: 0.426151447016888d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8473893243129249d, y: 0.08534512659901461d), radius: 0.8059532146454478d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.053639006127972455d, y: 0.8148548250248387d), radius: 0.24519630054982922d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8910131271398003d, y: 0.06737198909782904d), radius: 0.9871016922541238d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.558058994315562d, y: 0.3867001378661812d), radius: 0.37418353233602886d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022613676029179408d, y: 0.2911766279073531d), radius: 0.06063931459693017d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12726295683917854d, y: 0.04942562595464539d), radius: 0.9126191540473291d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07597627536993135d, y: 0.5773396758814591d), radius: 0.20131197833241632d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9738160658237847d, y: 0.17997844625748705d), radius: 0.3350470086109364d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0205418850490533d, y: 0.8662080011617127d), radius: 0.6450173880941692d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7714467549775561d, y: 0.11519642564404586d), radius: 0.06520426972176852d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5791784156218d, y: 0.7272054901131273d), radius: 0.9850222407796286d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2149488656426557d, y: 0.031311716644911725d), radius: 0.7492645000241416d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2854643145251704d, y: 0.8877774770080106d), radius: 0.9872213429179951d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12929450420203048d, y: 0.931199375429512d), radius: 0.6582855364771213d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.553259410447464d, y: 0.20527871329161818d), radius: 0.06782443231207747d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2740434806625628d, y: 0.29759953975696385d), radius: 0.20962422035921613d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31165592533884d, y: 0.5668057761268154d), radius: 0.8708847216040376d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7034996254595318d, y: 0.8838086371836633d), radius: 0.6389854870484595d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6673125444296587d, y: 0.48349842510880214d), radius: 0.3651971105101798d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4541495452660468d, y: 0.08195512941271643d), radius: 0.7448508201459542d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10412809007666812d, y: 0.8836864719039803d), radius: 0.169919905003023d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7188461291870538d, y: 0.9242209620436216d), radius: 0.4899784738287605d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42510414114090744d, y: 0.909986049063509d), radius: 0.32332374848183465d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4116285421830784d, y: 0.3405757287921469d), radius: 0.09480259547213643d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37895665595677297d, y: 0.8560383672256864d), radius: 0.16834400949343065d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18018109701678775d, y: 0.09650772764994853d), radius: 0.43470290675353973d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9351009618059151d, y: 0.7507827239674806d), radius: 0.4772010621625269d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49562613201455497d, y: 0.9593424655806968d), radius: 0.3688922986453623d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6448746525837052d, y: 0.9763608931762371d), radius: 0.9333462243016278d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6926735104158047d, y: 0.3542017143048052d), radius: 0.5966644865565109d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1796656802195672d, y: 0.634201780882929d), radius: 0.20939551788055077d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9343724575297361d, y: 0.42748729819487463d), radius: 0.27236086859952335d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6776611716731569d, y: 0.5631315416166697d), radius: 0.16538664128582858d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10053869586096464d, y: 0.9016547688066747d), radius: 0.4213272721550815d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9380585731845696d, y: 0.40950933785879995d), radius: 0.5856631804462373d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6976081726334218d, y: 0.4146543474018367d), radius: 0.9226517307254527d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6546117896288858d, y: 0.19747507950729493d), radius: 0.17673555455813394d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47038212653751366d, y: 0.5904353585736147d), radius: 0.9511283947190269d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11401068889342525d, y: 0.016805883453684833d), radius: 0.2799296686164222d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7920322372433105d, y: 0.14313790234988866d), radius: 0.6880150733385049d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009841585506311645d, y: 0.3965640709096738d), radius: 0.28193097433371417d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6126719657613353d, y: 0.4675308177871723d), radius: 0.9909533957614138d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8764819476991651d, y: 0.895693607364164d), radius: 0.2609378739160836d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21217143279415085d, y: 0.11870640440061708d), radius: 0.5396019928616659d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9868631321050041d, y: 0.46655703020844874d), radius: 0.6326248333781408d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7278837463752027d, y: 0.4519686225017856d), radius: 0.2649500194634643d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40789573165305715d, y: 0.4912981399978531d), radius: 0.8446295536626194d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19320429497536284d, y: 0.9654078777477706d), radius: 0.9960180574646857d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8726780318797581d, y: 0.6020009813767281d), radius: 0.8951447175705818d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5845531370803111d, y: 0.5465987777868273d), radius: 0.44267423654915783d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7889349953588531d, y: 0.5921105849768061d), radius: 0.8484784376474122d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.826641038339448d, y: 0.6175003188494225d), radius: 0.06943959235159869d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4882648163208221d, y: 0.87481780527057d), radius: 0.7858040847036012d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3106907092115052d, y: 0.15689392333732555d), radius: 0.8357863386754513d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44131535903748353d, y: 0.8180203008901966d), radius: 0.6014310036433365d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6776892877271351d, y: 0.27052024751031833d), radius: 0.6774441539601069d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.544961683438095d, y: 0.09712743329719964d), radius: 0.020755331098982532d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17269766939998188d, y: 0.16675868688976692d), radius: 0.2350662054869711d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32427495088976255d, y: 0.2727715865341853d), radius: 0.2888245561880749d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8133791415076076d, y: 0.002025489022697724d), radius: 0.6095064684478465d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09743000391180634d, y: 0.6249838755494697d), radius: 0.4518931392605515d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9259514186008428d, y: 0.016235634983436387d), radius: 0.996700018073611d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9177552840462916d, y: 0.627157205790302d), radius: 0.5763446743965306d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9986826353735989d, y: 0.8431500785225345d), radius: 0.14318301534716793d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3201789871207914d, y: 0.360721427567432d), radius: 0.7980746116778712d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16700134872939776d, y: 0.9673489430092944d), radius: 0.9649652230376787d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12839741341955235d, y: 0.33201376137423144d), radius: 0.32623302801734055d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4452692444634406d, y: 0.308037748567192d), radius: 0.36869395767652036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8341807265838042d, y: 0.12812318334123907d), radius: 0.2875923975691427d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8194948316088807d, y: 0.5929306356151337d), radius: 0.800316256074771d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9271380552606826d, y: 0.0037552623754771863d), radius: 0.20925215389802576d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6129302876045538d, y: 0.729389304481436d), radius: 0.7542282643385232d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.847870844989038d, y: 0.8442702225738026d), radius: 0.09121026703074375d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0060813874375803545d, y: 0.7277005570219496d), radius: 0.8735405119277424d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8922692859094797d, y: 0.5840970375860481d), radius: 0.5277765466497394d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32771068051127494d, y: 0.00431659329603673d), radius: 0.7809869858154056d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11250668920398266d, y: 0.15792178127570067d), radius: 0.2690117741350405d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6271152356451002d, y: 0.16776487885366842d), radius: 0.8502629622601493d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9019190399143218d, y: 0.23121448229724095d), radius: 0.5856289166470788d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9360210841753092d, y: 0.30519239385823616d), radius: 0.6697434296356083d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7440286002471354d, y: 0.8997029911539853d), radius: 0.025727233860064924d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.577446090079359d, y: 0.5814174800854999d), radius: 0.579953913860155d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011689617890015103d, y: 0.098187663229235d), radius: 0.8367336808902565d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7325508330798626d, y: 0.7894439926597264d), radius: 0.09586179241751791d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058126666658636d, y: 0.9500168464884686d), radius: 0.9676381788215983d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.961256139263827d, y: 0.18792480364218012d), radius: 0.50744772663047d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5105257066918373d, y: 0.4585413723185985d), radius: 0.36243783323101564d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13059791600310144d, y: 0.09379015031030624d), radius: 0.5566504501742661d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.039193616715588186d, y: 0.8004219358825378d), radius: 0.31263768070201137d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37072098333396164d, y: 0.7384745817198161d), radius: 0.6415699708048038d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5812014081536321d, y: 0.8959316965048785d), radius: 0.6604680673019192d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9006802080890675d, y: 0.028290091260330663d), radius: 0.5115977220042277d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3514925018879449d, y: 0.06775230199166837d), radius: 0.18801126202902263d), }, }, },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2233190373733449d, y: 0.7561646832738073d), radius: 0.6868695525727931d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08461595197490512d, y: 0.1807828076579343d), radius: 0.4203349191879513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019385867855836403d, y: 0.031933739680914175d), radius: 0.27819489738023606d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33482146309212724d, y: 0.4362536486585499d), radius: 0.14168973185654943d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08741806320164791d, y: 0.796849597170694d), radius: 0.7265217973854917d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20496206144740126d, y: 0.493140921717111d), radius: 0.9999347346543604d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6367508860450999d, y: 0.7580544381340489d), radius: 0.8801913865083508d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08954854827029246d, y: 0.3295495641436732d), radius: 0.18140754445154483d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.002579793496941818d, y: 0.5020839437786063d), radius: 0.6331683724843337d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09820357890746001d, y: 0.18730969865133207d), radius: 0.8603645070637327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6190207206192705d, y: 0.6733488357356976d), radius: 0.855365587417541d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18743187006580964d, y: 0.8676542004789003d), radius: 0.40026757442216276d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7244207816963253d, y: 0.7078807284791264d), radius: 0.3769820077400696d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9052607005572981d, y: 0.09442139573131891d), radius: 0.9043066145667842d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9544820591421744d, y: 0.28480440927862904d), radius: 0.7766462532559394d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7031115550638989d, y: 0.3934812181411801d), radius: 0.11935076703869307d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4468704037750507d, y: 0.029212735223099195d), radius: 0.7761309032354858d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9291255339056541d, y: 0.9586368816740019d), radius: 0.5946139857389429d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31636505962566497d, y: 0.5145556088369029d), radius: 0.06142363362818448d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23847433534591655d, y: 0.20972632805569824d), radius: 0.1348855237565858d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7936083158599383d, y: 0.16506463433991692d), radius: 0.23052200193226546d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8492682477496214d, y: 0.9928891157548059d), radius: 0.16432298690859637d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39872504668561093d, y: 0.531806512765015d), radius: 0.8212712598680901d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16827551049456568d, y: 0.052881820564700144d), radius: 0.40705847581799504d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8461454809103149d, y: 0.6061901094694544d), radius: 0.17983578551760437d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.324812576764098d, y: 0.928759545280309d), radius: 0.7717092578424951d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5649761498217626d, y: 0.375290441244549d), radius: 0.8446858274011566d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6805441790678459d, y: 0.6849244406993804d), radius: 0.5857969842346091d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9690283419572236d, y: 0.21038369007054447d), radius: 0.8557258733251825d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2576977682937941d, y: 0.48963829544701043d), radius: 0.8495866946830085d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4781741444981499d, y: 0.30021160007148573d), radius: 0.575110120835864d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37148322786417565d, y: 0.5276262890832102d), radius: 0.552564419516966d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5250141658103846d, y: 0.3812264438158959d), radius: 0.16554629665594534d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8399645779404626d, y: 0.15322291164261892d), radius: 0.3868219867754872d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6947092694504533d, y: 0.550398387349008d), radius: 0.12995077515434839d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9735502535320121d, y: 0.9507794542619996d), radius: 0.31796598062485304d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4493301536141704d, y: 0.01418313594300169d), radius: 0.09852872488669295d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9741977661951614d, y: 0.9598182819002855d), radius: 0.932848919296504d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24329985145120092d, y: 0.20274453129175696d), radius: 0.4620287526891018d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6079325561563966d, y: 0.4258508493550486d), radius: 0.36171215348587793d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18141835752674618d, y: 0.17434168495854885d), radius: 0.8110347609802974d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.439846977102879d, y: 0.08347316093336432d), radius: 0.4247167061942211d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5792895140587245d, y: 0.7338716399001568d), radius: 0.3301431268161896d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9518874032374518d, y: 0.6385018924856d), radius: 0.6182770944470137d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7497223419827926d, y: 0.7373457284489683d), radius: 0.699793371206718d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6512601192691746d, y: 0.5974878339218792d), radius: 0.2742618395250812d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6666825048171864d, y: 0.10374869121485608d), radius: 0.8655729383325651d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7156251518071394d, y: 0.3058149106377507d), radius: 0.5674020921535778d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6642573344690836d, y: 0.5556959107074099d), radius: 0.4893659394094505d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9984406243023008d, y: 0.1338368128118197d), radius: 0.01302961654009005d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7861679454328753d, y: 0.45232152092715094d), radius: 0.733590975198542d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2008646793456249d, y: 0.1011179795915641d), radius: 0.810591182430764d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5670219741109096d, y: 0.06633834067226951d), radius: 0.0995578849487272d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5057444413901937d, y: 0.6547922698008711d), radius: 0.4552052146912555d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14295390886879356d, y: 0.16476846834990677d), radius: 0.40800758563254513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26613023883030984d, y: 0.38937585982823164d), radius: 0.8793984682864595d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6066805083140181d, y: 0.6172934718367927d), radius: 0.16870313610647714d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8383935642579096d, y: 0.8211680778059961d), radius: 0.5788921624875868d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6328376438804333d, y: 0.6907749931517024d), radius: 0.9970871667635292d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40352289818068376d, y: 0.10226140773315462d), radius: 0.8831476667087251d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44094497926896825d, y: 0.7367799912174015d), radius: 0.8327847659942449d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22250425917581595d, y: 0.004389657931733404d), radius: 0.9922350854689806d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2880999197105816d, y: 0.8124250933464516d), radius: 0.6158589114825763d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.373407249737436d, y: 0.5612211706759439d), radius: 0.29862250941142754d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.665932868799019d, y: 0.58198639241153d), radius: 0.2092673752842975d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8833079095712174d, y: 0.7350089742228884d), radius: 0.6760669000873651d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6069911309990244d, y: 0.7314682141201309d), radius: 0.3660566049515108d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0492018846661475d, y: 0.9727148267334195d), radius: 0.33247938029344515d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.882136283131959d, y: 0.1441282275204795d), radius: 0.49715626286304393d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030928960327951338d, y: 0.8653561982573343d), radius: 0.5194425325010965d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4273545525981842d, y: 0.46803769590955935d), radius: 0.4650214029973886d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.529481162547963d, y: 0.23598837567532482d), radius: 0.43268029316874956d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6506412913495097d, y: 0.022980452010110564d), radius: 0.3856535958360414d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47617730074193176d, y: 0.871716677692013d), radius: 0.6302359244290062d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45515587119514445d, y: 0.5853484535556881d), radius: 0.7933813860437992d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4764359187790007d, y: 0.14602520102203764d), radius: 0.2978251545457353d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5657795841582415d, y: 0.30675665762799853d), radius: 0.35449723315247805d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5140496128918505d, y: 0.14802705712517905d), radius: 0.02544181541708279d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8812795326837135d, y: 0.72502505209011d), radius: 0.29518596661716134d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9144005146824326d, y: 0.9566431771191279d), radius: 0.7784338719744701d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7849651431416275d, y: 0.3295017570052925d), radius: 0.260495139479639d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7448119677308891d, y: 0.18639277851483727d), radius: 0.5953761002426117d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07053033891526006d, y: 0.23692394553182583d), radius: 0.9406668435840592d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17271840507694491d, y: 0.10421888842054472d), radius: 0.7573920933679081d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08795118378223199d, y: 0.7764019216552598d), radius: 0.2683236919681993d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.757324241783038d, y: 0.04353002972305975d), radius: 0.9379668894480724d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5955972066944543d, y: 0.43795753482399635d), radius: 0.05305536513327458d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6833779128743878d, y: 0.14379483713398677d), radius: 0.6127415130272404d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1768686627210354d, y: 0.02406067957782354d), radius: 0.3596935057363022d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03443429161617784d, y: 0.5479237923727686d), radius: 0.8434920359723517d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4161811916314635d, y: 0.9308962058270039d), radius: 0.09254460537433162d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025372625621635447d, y: 0.8246359254950267d), radius: 0.9667065486667419d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6989086354180568d, y: 0.27420652662853373d), radius: 0.6558732681453279d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8823528451654905d, y: 0.053957476429463025d), radius: 0.3274321300768993d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07165178411900774d, y: 0.9000889670950154d), radius: 0.7084518386256187d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4559236726522371d, y: 0.5330389143968d), radius: 0.3137830942631692d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48713004507682234d, y: 0.6718199609232736d), radius: 0.1952381154707592d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7806384163932327d, y: 0.43644524117386996d), radius: 0.4803829042505452d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3296203518067746d, y: 0.6271923423577179d), radius: 0.5309552476401815d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.792236522939651d, y: 0.020085081451442943d), radius: 0.13713405014083702d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5161056140092327d, y: 0.4250265085134095d), radius: 0.7751031054722396d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9847790917971934d, y: 0.13040925166216977d), radius: 0.1510931807538035d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9777734872922867d, y: 0.06154895763856605d), radius: 0.04796612199832184d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04711600078912015d, y: 0.34553182213333544d), radius: 0.24929154017739497d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7729003407838798d, y: 0.23385923664970631d), radius: 0.830117019826853d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16311464295390865d, y: 0.12060973465658642d), radius: 0.07404926526301148d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02668292580106091d, y: 0.576727826173237d), radius: 0.2897513170938154d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.683678260530764d, y: 0.8297774699897326d), radius: 0.6033128210525889d), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9165360578146449d, y: 0.801282647416599d), radius: 0.31959651042372295d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15012234540265113d, y: 0.8273324911585882d), radius: 0.5937942538810757d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39146192049387096d, y: 0.41979795156281596d), radius: 0.36489075042192d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35534547641564684d, y: 0.9550273659164399d), radius: 0.1263994974058379d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6141135638210656d, y: 0.009053758245887833d), radius: 0.020699622516358485d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6779820050429075d, y: 0.11624075078053953d), radius: 0.8882313580027822d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7656062052245358d, y: 0.5953574646828949d), radius: 0.6721864939237399d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8091209230930398d, y: 0.17739742948969772d), radius: 0.20841646743235764d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4401799234986238d, y: 0.2812067505648398d), radius: 0.413093979006834d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37691448162292285d, y: 0.6090492557987458d), radius: 0.013852358097698803d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8247394662583812d, y: 0.18148984689822611d), radius: 0.11234735026634346d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4360298162613695d, y: 0.6445988154010701d), radius: 0.28384100929316314d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7150565631624621d, y: 0.8718071423227808d), radius: 0.6423659283528329d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7114523265873297d, y: 0.8253968329030873d), radius: 0.7073477447401635d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.038401512745537936d, y: 0.8573503810389531d), radius: 0.5297991488738738d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4800607414645559d, y: 0.8743831429849731d), radius: 0.86330312537763d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39674300493691783d, y: 0.5809586380176658d), radius: 0.9151424931260198d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7797567044739147d, y: 0.6608293336365111d), radius: 0.9784282158849023d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05865713461746458d, y: 0.16683800200620258d), radius: 0.38671195149199633d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16232090480562344d, y: 0.3339929298636678d), radius: 0.8846932126539612d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015270397988521478d, y: 0.25452084856858925d), radius: 0.40532109018004625d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5944323575607741d, y: 0.13611320986611308d), radius: 0.4939605826353559d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39458862525271954d, y: 0.9589519644263761d), radius: 0.5690936432099287d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0002546943970820337d, y: 0.6991708611560506d), radius: 0.4315686183009525d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5508691441678053d, y: 0.42961809667883544d), radius: 0.6752630842644697d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4761938852306913d, y: 0.42464747808394143d), radius: 0.40716101109176484d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4903621256514753d, y: 0.8849614120408864d), radius: 0.43717678145762273d), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43481621032855977d, y: 0.5446569828865887d), radius: 0.036844388850050036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6499178689567682d, y: 0.9855723805087138d), radius: 0.48394534497420616d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7895398094671129d, y: 0.11231418828746986d), radius: 0.8332208748296632d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7814867841068514d, y: 0.44415605782223255d), radius: 0.37982375303384963d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.988741306988884d, y: 0.17652354431338735d), radius: 0.9338012545645988d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19131430099369073d, y: 0.8524178789364159d), radius: 0.8374409072859018d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9100228882788791d, y: 0.8875106977682793d), radius: 0.5456249377618129d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21112657312186212d, y: 0.3650194439419251d), radius: 0.9072071539761111d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6971352706287409d, y: 0.6899845193773811d), radius: 0.9744874301507888d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14727935723580576d, y: 0.33864039297100246d), radius: 0.3735336275701483d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12149820885068141d, y: 0.8990941368657112d), radius: 0.4862824925364456d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01290511964802965d, y: 0.6867762320379702d), radius: 0.5924038783155139d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7252927042401371d, y: 0.6455804574182996d), radius: 0.0027644236120510923d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3055026225880859d, y: 0.4187944797131431d), radius: 0.2878548618852981d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10029742357008842d, y: 0.22776469450288683d), radius: 0.3136102115498508d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14090812553905652d, y: 0.3257875474509293d), radius: 0.47083867272774893d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22879664044929093d, y: 0.8562011190101603d), radius: 0.01349576073613612d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21477155516222246d, y: 0.11481146809635179d), radius: 0.0018163848248349268d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9110884039248804d, y: 0.1493459156257667d), radius: 0.6609160512308303d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4930955271019053d, y: 0.1452266816465566d), radius: 0.7813527196201513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7380665927355526d, y: 0.7276550440442051d), radius: 0.6150940142417821d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7088867671111159d, y: 0.5698566944070451d), radius: 0.3192446827386003d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2048409509733271d, y: 0.146682962254858d), radius: 0.16152660308760558d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45760415074092975d, y: 0.0504897895427332d), radius: 0.6988016338397817d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6158974259600455d, y: 0.8164641476559295d), radius: 0.9974351895219818d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8796947121305957d, y: 0.08726626139994786d), radius: 0.11599904205106282d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5396668370302067d, y: 0.16003067454791664d), radius: 0.08946322384558902d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6952523913449976d, y: 0.23183181703360378d), radius: 0.5657443286056612d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18232098997636448d, y: 0.04392783886829699d), radius: 0.9226730762396895d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13329438053188347d, y: 0.46469655422461087d), radius: 0.7843079069168689d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6825351630124731d, y: 0.6382648750375273d), radius: 0.07483541471155142d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7669234596358218d, y: 0.600907856118068d), radius: 0.5717055840055966d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8813467084315192d, y: 0.48320750585284067d), radius: 0.12553956284577839d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.769680718464704d, y: 0.13633654311168208d), radius: 0.044039026408097426d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38464577121246313d, y: 0.4304822540148915d), radius: 0.4789014910695023d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5084326133095934d, y: 0.7064417508228409d), radius: 0.7026609017680561d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008048654618565299d, y: 0.5005250435608113d), radius: 0.35345447608727054d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.838372696556898d, y: 0.4694891222502756d), radius: 0.6117358759222108d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9443280081821517d, y: 0.9445892681416044d), radius: 0.33337658188362207d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296238676206698d, y: 0.6565816101814724d), radius: 0.36171577345833705d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9743732515543091d, y: 0.1837113265310928d), radius: 0.9857934809465421d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6769766452186422d, y: 0.5754977831301091d), radius: 0.8392279767181219d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7699298141649258d, y: 0.7206624538706156d), radius: 0.0009667942273539065d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1907587808279736d, y: 0.1556363593571043d), radius: 0.9158285994425805d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4634435363738556d, y: 0.6223864618619042d), radius: 0.35430101373268774d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23027735832542162d, y: 0.8953568847788326d), radius: 0.7770827988768491d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08015921953138583d, y: 0.9498816286815895d), radius: 0.4287328482341781d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9348954319950781d, y: 0.6086163158328591d), radius: 0.6345200848569426d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4165897412001134d, y: 0.23509060557875872d), radius: 0.8458766414937128d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17349243699859163d, y: 0.13878906387471313d), radius: 0.810528416285477d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10934874590410015d, y: 0.3653955141807902d), radius: 0.5186695150291085d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6620239669630487d, y: 0.02041109207017877d), radius: 0.9377977077634456d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5983749166031364d, y: 0.14889446435941078d), radius: 0.1397403886170393d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018337568756987332d, y: 0.7712258162994852d), radius: 0.5005695233002599d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48104347699706007d, y: 0.3705022980541629d), radius: 0.7291119723592178d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7326282758490975d, y: 0.8538762748502764d), radius: 0.5300167628976998d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4563958905911141d, y: 0.19296892960033474d), radius: 0.5198104271577741d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7121836100410649d, y: 0.020046782655049444d), radius: 0.8079692796939337d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.032431106220937256d, y: 0.6143506276734189d), radius: 0.33699538831371645d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20752187748905093d, y: 0.9205104032114171d), radius: 0.10156532264762175d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4243498039361745d, y: 0.9705655402692293d), radius: 0.8003876256299505d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7921655748972974d, y: 0.310560406328383d), radius: 0.4048002945785675d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04604771148080655d, y: 0.516135081848794d), radius: 0.5868664849627682d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6998984293712807d, y: 0.9144378374290143d), radius: 0.6569306650302362d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9531708809432016d, y: 0.19497601677808318d), radius: 0.033944295474818476d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7581790340735717d, y: 0.5212822241254604d), radius: 0.09973228412913082d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9945511592600149d, y: 0.5266014842655233d), radius: 0.01762033808109964d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8130939383543478d, y: 0.7016390648387901d), radius: 0.7413710114861395d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8113883895908062d, y: 0.743923147189179d), radius: 0.057643539544839584d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8176871321452497d, y: 0.9766340005180562d), radius: 0.3544647114028563d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5814336839895364d, y: 0.9336519500943462d), radius: 0.9041230839160336d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18866770001003508d, y: 0.8742212633536968d), radius: 0.9389867746232694d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5049374209187507d, y: 0.3846564951109208d), radius: 0.5230065091983261d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5334447905303344d, y: 0.19998551294531497d), radius: 0.33012618428239704d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2967401880902444d, y: 0.8968620927552055d), radius: 0.7553398409237762d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2624322414902558d, y: 0.5332754315851397d), radius: 0.6863648576613538d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9571412570202822d, y: 0.616978015211492d), radius: 0.9542638984585883d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4508718863520923d, y: 0.6727366315204872d), radius: 0.6657106603258719d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16829077489144262d, y: 0.6104663800739218d), radius: 0.8012598345423222d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49789055104112656d, y: 0.8051165053967637d), radius: 0.463519479238073d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8250551946927434d, y: 0.7111978679848228d), radius: 0.37884185632223977d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7713112542410442d, y: 0.795874768815222d), radius: 0.4894357025731697d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8503573192996163d, y: 0.6705121142709249d), radius: 0.946843996085231d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6929821331859292d, y: 0.7989482295029232d), radius: 0.3875830032557962d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07050591420538821d, y: 0.5176172800252542d), radius: 0.9640517499795834d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.910825988578055d, y: 0.8549050423990592d), radius: 0.08714537424631785d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7783174898810693d, y: 0.36877435028745753d), radius: 0.08346252622235006d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.926149272294751d, y: 0.8419530004362429d), radius: 0.2634889524297418d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46487303924237877d, y: 0.5810422179416572d), radius: 0.010877875836722728d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1246273649825207d, y: 0.7050622156846936d), radius: 0.5759525477928114d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5250446491167685d, y: 0.24553306973340694d), radius: 0.7245970290425248d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29706554800464025d, y: 0.05954614437438388d), radius: 0.1595332458002544d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22454663873463432d, y: 0.18029344923419965d), radius: 0.9425454239531221d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17231399606492803d, y: 0.015327739115918892d), radius: 0.8088633222056465d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40290162570408816d, y: 0.6313155454543251d), radius: 0.311746523667518d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2970132345669959d, y: 0.7486487140780109d), radius: 0.33216219648087153d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1743325736089495d, y: 0.7144022232935441d), radius: 0.923111173477965d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8051635635063745d, y: 0.6611770051759466d), radius: 0.89190971859327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6387163398842582d, y: 0.4952843106929862d), radius: 0.18885411003176444d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40188652067137265d, y: 0.5112511706893423d), radius: 0.8402295906874461d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8554917649300258d, y: 0.16473622701156065d), radius: 0.21180881763722392d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38936463602553695d, y: 0.8404318096345381d), radius: 0.9192075211763566d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4080675625651554d, y: 0.05653250295658108d), radius: 0.3256423734089926d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5555017931980177d, y: 0.9722498780998067d), radius: 0.19005160660492937d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41539857136710423d, y: 0.7058193769814385d), radius: 0.9727551184979542d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8334957532298695d, y: 0.6182087574607714d), radius: 0.5048660777049641d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3707941038571074d, y: 0.28102146833745456d), radius: 0.7737901402218555d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41701234814204d, y: 0.44924919979546263d), radius: 0.2913500244598656d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6016284794506918d, y: 0.3392260178101172d), radius: 0.11269318258995764d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7801537908597211d, y: 0.47060537477585307d), radius: 0.3658220971127363d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02083642343440284d, y: 0.36030714023380506d), radius: 0.6032508002838113d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.886143920405928d, y: 0.6082192429105521d), radius: 0.595679161482399d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3248371162310766d, y: 0.4003352313981443d), radius: 0.236091665388109d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1441218473177891d, y: 0.16629144242749017d), radius: 0.25130224429302084d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18564049402585248d, y: 0.08872945630376683d), radius: 0.017405271271899614d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.307726554961103d, y: 0.8168983995053911d), radius: 0.10476664953944781d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6094825014050725d, y: 0.2188098985493636d), radius: 0.5831348535581516d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44745845891278524d, y: 0.2618479551648014d), radius: 0.5892320389074187d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.963234490686662d, y: 0.3264395328330003d), radius: 0.23261867501728928d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06400255330514748d, y: 0.1351388001306697d), radius: 0.2945550864665747d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2586667779226913d, y: 0.39140988941877375d), radius: 0.36866500184852147d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5298772119191626d, y: 0.9725613608017528d), radius: 0.22792718323008154d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6986260627685106d, y: 0.5264358240102599d), radius: 0.15776506323962736d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7431743389352041d, y: 0.39176320823633715d), radius: 0.23211310977618937d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14888630216228638d, y: 0.9633585149008098d), radius: 0.20225590541628113d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5475249981809052d, y: 0.5423557106771814d), radius: 0.9547362078126208d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8171084321552011d, y: 0.4240767798801045d), radius: 0.20116971473087397d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23865494238924734d, y: 0.7069666780970244d), radius: 0.8839658068763113d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7547236715683365d, y: 0.28673616584663786d), radius: 0.9280862397498202d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6472613677950412d, y: 0.738676945201327d), radius: 0.2719754648600593d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8920867384606264d, y: 0.5716098066940418d), radius: 0.8815257619985883d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8353696840919657d, y: 0.034114185313402934d), radius: 0.18526728478280108d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6772987829847241d, y: 0.3901528035145969d), radius: 0.17182343130922673d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6481920151152345d, y: 0.5604808653935422d), radius: 0.6269843975476375d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4436225786787463d, y: 0.20338149278971218d), radius: 0.41098540121956173d), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7291240974171526d, y: 0.000571138791282011d), radius: 0.7765674930800569d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5040636571075775d, y: 0.08472635530942219d), radius: 0.4915499389144644d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8086449639089789d, y: 0.5429129499731357d), radius: 0.7708672545538873d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8786916362511711d, y: 0.9568297637581251d), radius: 0.05757017495858541d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5406942102815858d, y: 0.7765700221866257d), radius: 0.6675356803339663d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09818966409501162d, y: 0.3257212819434724d), radius: 0.4718016069590759d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8703797516867795d, y: 0.21492587434888966d), radius: 0.38847224967766714d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3022430966013072d, y: 0.8367620764940873d), radius: 0.9219152498273063d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8070259975075981d, y: 0.15844649526867505d), radius: 0.03699961576414512d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5954183235779922d, y: 0.615216906159409d), radius: 0.061842048121265036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2607861988483615d, y: 0.414502258039687d), radius: 0.3171570289161584d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29074870312370826d, y: 0.33365254634558084d), radius: 0.4627069247935658d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7179633890080062d, y: 0.8575512296649015d), radius: 0.5516867937718146d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8728848217533517d, y: 0.9190703612833716d), radius: 0.16728620095444513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4665044519367624d, y: 0.7947052318555056d), radius: 0.4373615496216362d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8561173675876778d, y: 0.25491524961141376d), radius: 0.6096365530259216d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.85071091119999d, y: 0.7991107634406653d), radius: 0.7666950360176827d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47222985534872286d, y: 0.6199580552777219d), radius: 0.20072377817647669d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4199862672963498d, y: 0.5524671750543254d), radius: 0.7489569542476108d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2958496800025229d, y: 0.03619767839336796d), radius: 0.4480005663859139d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6656832202687111d, y: 0.49228993852337444d), radius: 0.5896478510817199d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22883987993195354d, y: 0.25907551555871144d), radius: 0.3400891129145007d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8069195643740128d, y: 0.08241371846836998d), radius: 0.40371428279723975d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6506914470523981d, y: 0.8563777987066379d), radius: 0.8994430773793769d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7526921676352077d, y: 0.07991656895468013d), radius: 0.4824134540081718d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5413782212880358d, y: 0.2667343768971243d), radius: 0.3375787356634864d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08961472357551592d, y: 0.3018211882520778d), radius: 0.504070276677294d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03788997965741847d, y: 0.7826453039917458d), radius: 0.9787283891294899d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9944010577024249d, y: 0.3108353837715577d), radius: 0.03563999200932244d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9895259512280906d, y: 0.23844274889589978d), radius: 0.15900994807511748d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8928477163446343d, y: 0.6812891272375899d), radius: 0.4322508622303928d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1469039861444147d, y: 0.8415304357089551d), radius: 0.3345392594429718d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9517692274836751d, y: 0.3838009694098862d), radius: 0.4978972473094785d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15243828115913705d, y: 0.6324966170817232d), radius: 0.7429827509345633d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9860650879461913d, y: 0.46063615284468507d), radius: 0.8585451488641216d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3618986695961838d, y: 0.37440393051449916d), radius: 0.2695492963160875d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.745327028478902d, y: 0.7886947372545846d), radius: 0.8543575078963297d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41472615730572704d, y: 0.6717272313963939d), radius: 0.9366812528195384d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07590866620120895d, y: 0.3309524928587819d), radius: 0.2498948858668364d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018179400443697813d, y: 0.28535402078502003d), radius: 0.7219401644607335d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9238420786528196d, y: 0.5347260590202217d), radius: 0.8450463302008425d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8048250723195643d, y: 0.6548392380738115d), radius: 0.41474308226158185d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3474404864066519d, y: 0.3864441485454526d), radius: 0.49242106599749746d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5972128030864944d, y: 0.2509985490237767d), radius: 0.7002811125444104d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10789747051986243d, y: 0.09424745504940601d), radius: 0.368874643453206d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.926465224365708d, y: 0.08623755290356827d), radius: 0.36591499997746657d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5057788390852385d, y: 0.8169711385194779d), radius: 0.7001927141701227d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5377864660326271d, y: 0.35161284848263674d), radius: 0.11167995758155147d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16012098807158415d, y: 0.10718842395525274d), radius: 0.24755626100203254d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8890467316224462d, y: 0.06653695686179517d), radius: 0.24855191068661953d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8974899172565853d, y: 0.6777621668109823d), radius: 0.33319916085244383d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6957293567500095d, y: 0.8992762011248023d), radius: 0.2316709153468044d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1933736184774536d, y: 0.456348665883748d), radius: 0.22726950638339805d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3915678779218925d, y: 0.7786965239413013d), radius: 0.06076983696616123d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8697095958294688d, y: 0.7977713119559281d), radius: 0.6478565104703164d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7919035811573545d, y: 0.29648143242782177d), radius: 0.6260762745310342d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28094789874317105d, y: 0.23196486019691298d), radius: 0.5340079191975646d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7605626908235489d, y: 0.16510495587599783d), radius: 0.7856700174249329d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19531814473200637d, y: 0.8647533776356042d), radius: 0.3850110796003602d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7475716392167454d, y: 0.6562668855549513d), radius: 0.5134701300150354d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3669079339472754d, y: 0.21091993793008146d), radius: 0.891627814550441d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4460264659240305d, y: 0.3938993553268073d), radius: 0.9919852541315157d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8211874107704896d, y: 0.2566764210128949d), radius: 0.7131405653518975d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26786036334966956d, y: 0.6928952671419498d), radius: 0.9913571212460847d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6280850599805086d, y: 0.9498767867442549d), radius: 0.2262871468359955d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3368401890738545d, y: 0.698623819075042d), radius: 0.8415955132561762d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6445174065289595d, y: 0.5621691932473459d), radius: 0.7078273981977381d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7317381410168943d, y: 0.09694859456251892d), radius: 0.8444754292143664d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9430892863930155d, y: 0.9752245088839641d), radius: 0.3910066585823192d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019532795745122344d, y: 0.897085430305466d), radius: 0.3729777156007472d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7848061191342518d, y: 0.2200032559325119d), radius: 0.27127274960336756d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9276336451154397d, y: 0.6903018993101087d), radius: 0.5869358788857194d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10585087794024817d, y: 0.3409444639842685d), radius: 0.14291145404038164d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.034362038812987494d, y: 0.1428412069820968d), radius: 0.17153793058916122d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5090201787523856d, y: 0.30635621643410127d), radius: 0.4541888319123517d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4262608560042128d, y: 0.7315735446802245d), radius: 0.7810233565560192d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02265326765987441d, y: 0.5424643995433315d), radius: 0.39329086229583854d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9142790979405124d, y: 0.041023787203169126d), radius: 0.1293931564242946d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5886615670092236d, y: 0.42285897726862054d), radius: 0.6385892465597864d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7030031745340112d, y: 0.5445186603525253d), radius: 0.8305981238321586d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34200584608384665d, y: 0.23714018368664602d), radius: 0.03866727046795637d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9669035829343837d, y: 0.43103815835136405d), radius: 0.7784448300446566d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3534096895233637d, y: 0.003257111738268481d), radius: 0.5683526076336427d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0578437167283995d, y: 0.31428100800603076d), radius: 0.42117587121103106d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12110564234951982d, y: 0.2710591556509766d), radius: 0.9066923765179462d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5189787557775697d, y: 0.9963340042507508d), radius: 0.8886346978335551d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12928242020984193d, y: 0.49816126611650313d), radius: 0.23560287456430884d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39873100670879846d, y: 0.9673171658528689d), radius: 0.5941900808579939d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5015848071721936d, y: 0.41484580596018295d), radius: 0.35917780938764965d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8617171610728256d, y: 0.2567341166595023d), radius: 0.5595612494699761d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.179441350886826d, y: 0.8173245101615774d), radius: 0.04026543453884912d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6861586551448754d, y: 0.9231441841779588d), radius: 0.7424350042618357d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5166922107960453d, y: 0.7431579386396188d), radius: 0.3609625386428804d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31749263335495836d, y: 0.6938612075473116d), radius: 0.5187429663665255d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0186437290455298d, y: 0.6862690992490321d), radius: 0.2466537071250594d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6568426946336371d, y: 0.5584687529402648d), radius: 0.7757878155675939d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6957266186586657d, y: 0.7437570269155207d), radius: 0.4547247271993239d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5612077534532545d, y: 0.7528723251278508d), radius: 0.04521279241620724d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8611425589678492d, y: 0.6684302934262968d), radius: 0.9374557636058227d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5556522993531402d, y: 0.8866458380675335d), radius: 0.8246415573377467d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18735122056483022d, y: 0.4756098536236403d), radius: 0.31792526550188105d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5469625660509018d, y: 0.5514439824766927d), radius: 0.6405689104802991d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1685587309807658d, y: 0.5083541249457072d), radius: 0.901954122093607d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08363959257779796d, y: 0.2822418210033152d), radius: 0.584922704424893d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20334946181337576d, y: 0.9474172670231223d), radius: 0.13528131706873014d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6485885344651288d, y: 0.5933890383838393d), radius: 0.9126180028753186d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7051964252134406d, y: 0.6642884400109227d), radius: 0.9741179755590494d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40106897940445885d, y: 0.10962387259537665d), radius: 0.15980155256397544d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49907110274320476d, y: 0.5009794353858134d), radius: 0.6203013301401008d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12542502283879098d, y: 0.21435139681236037d), radius: 0.7331415777127248d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1381216802486892d, y: 0.24678235046853303d), radius: 0.6617135505437519d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23649880367117004d, y: 0.4645619105781298d), radius: 0.1988914954122285d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.526899348488184d, y: 0.569426293724564d), radius: 0.6793991370074028d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8521102953619832d, y: 0.02177238932304093d), radius: 0.006430208361900336d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5787184433431283d, y: 0.3482198810125282d), radius: 0.4156147211221164d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7090566225214188d, y: 0.2799256955958903d), radius: 0.9835261797263617d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7040151372679395d, y: 0.2164301021949233d), radius: 0.9030543625552686d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8723513224633662d, y: 0.072061036286308d), radius: 0.4542074050725907d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43331117166881183d, y: 0.10595340940012288d), radius: 0.9357714801368796d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14098551816332328d, y: 0.18432615560993837d), radius: 0.7760917493229526d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2971861293253546d, y: 0.19848858065787245d), radius: 0.8288629490663187d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2936750624299215d, y: 0.12756217309635332d), radius: 0.8554148264782667d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19923167401747977d, y: 0.6959637876102182d), radius: 0.11541183286308987d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7415868749630036d, y: 0.5785287658159687d), radius: 0.6406701035505761d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8294602428572045d, y: 0.18555994173645396d), radius: 0.34899732534077654d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014047442838420743d, y: 0.21143127205260948d), radius: 0.1470415821011427d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1733254239563019d, y: 0.03992958539136737d), radius: 0.29399312117123466d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32754693577493854d, y: 0.2922448272028709d), radius: 0.3954210286815619d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7609236041372135d, y: 0.29019849469063985d), radius: 0.8335836435413712d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8839287488894267d, y: 0.15845805603741114d), radius: 0.23122901469899604d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3861947742978862d, y: 0.9826084423760473d), radius: 0.11751155233145816d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9678257487670486d, y: 0.4090654829994843d), radius: 0.36794787294751086d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7296212217792287d, y: 0.29824708034542835d), radius: 0.7018028882388876d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24084446681126725d, y: 0.07346547264141301d), radius: 0.7328850616545278d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3770097334725424d, y: 0.6838676198509962d), radius: 0.14444125272039743d), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5510470623565581d, y: 0.12925208727662252d), radius: 0.031194802776317365d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9875915277525769d, y: 0.3066151357997988d), radius: 0.76812211272523d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.942195345452486d, y: 0.973175114332776d), radius: 0.40543086363801806d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1848667792326889d, y: 0.8021617625443431d), radius: 0.8136801889125904d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5005578298883211d, y: 0.7329851962002686d), radius: 0.4948977574986917d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0723311546418649d, y: 0.6972822460118128d), radius: 0.6938921875016407d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4727446734098786d, y: 0.2606099843671249d), radius: 0.9900856478918847d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8217862595812235d, y: 0.7515395809359274d), radius: 0.8372181935565931d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6159942553072963d, y: 0.22727433021635768d), radius: 0.29500039072546d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10370059337922366d, y: 0.11871603715026546d), radius: 0.17077201853052415d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2790993914654112d, y: 0.9490691473801003d), radius: 0.3928674031400349d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19358143287884155d, y: 0.6830648095373083d), radius: 0.051891681088882424d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7323707746215287d, y: 0.6718718313612013d), radius: 0.2270465993160019d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9849669417717858d, y: 0.381427757749082d), radius: 0.6932655825310119d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24653685283325533d, y: 0.24352196253642622d), radius: 0.8241640483742821d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09401088709685557d, y: 0.6504939171865185d), radius: 0.6953451625131094d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8748794207098689d, y: 0.1918490359212981d), radius: 0.07935274857754882d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6097208514482764d, y: 0.4621732183603665d), radius: 0.10257696355374901d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13780886728967978d, y: 0.14262579008676302d), radius: 0.7784332271379409d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5590029734808621d, y: 0.578252647502725d), radius: 0.28178849827306496d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1923264421482609d, y: 0.5838372072483458d), radius: 0.6191225379113732d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33905758414145926d, y: 0.34267969894452155d), radius: 0.2121444322553001d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3147693917994818d, y: 0.13782797729245588d), radius: 0.02782996003651661d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7856049336961205d, y: 0.5717714102929166d), radius: 0.7541466902663301d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18937935326223565d, y: 0.023958956584312907d), radius: 0.6106992062565545d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10976851508694307d, y: 0.2943053700146835d), radius: 0.6726946887482625d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9388347721250399d, y: 0.11963510907869424d), radius: 0.2860431950034028d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5811243820900773d, y: 0.7442842042131294d), radius: 0.49985794650145265d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3186158075100245d, y: 0.7598871730841679d), radius: 0.5556950482841605d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8825551276395603d, y: 0.7601371317467259d), radius: 0.837292585655844d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32501853145127735d, y: 0.36545589403545753d), radius: 0.13397452717025193d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9859451299247538d, y: 0.41348792436857584d), radius: 0.7026339327966784d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07430673098947049d, y: 0.36724554018527544d), radius: 0.6146208853961903d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13968317668202201d, y: 0.8451518345620576d), radius: 0.5998582675182208d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11693709807676034d, y: 0.8363352377640422d), radius: 0.39493457682266997d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5674223584057325d, y: 0.42512192470601584d), radius: 0.3184744004126022d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2744432348674515d, y: 0.1182201849362765d), radius: 0.16515981225178344d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4317240176069036d, y: 0.05712051881006375d), radius: 0.08408894005328871d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7230424328080806d, y: 0.9819485181712091d), radius: 0.44884472742300585d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1288575112935103d, y: 0.8447038364299679d), radius: 0.10728707333689735d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6787021232872755d, y: 0.7434859069046581d), radius: 0.2726607549709509d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014082870832368033d, y: 0.985994528371006d), radius: 0.3630962280443364d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22588094585823326d, y: 0.18933110894560212d), radius: 0.9569823937560199d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08581762204369137d, y: 0.563238186051869d), radius: 0.10835942796880904d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31668827275062017d, y: 0.11860487897528027d), radius: 0.7297033048273248d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10652104492520087d, y: 0.3219641753175144d), radius: 0.025433623954292273d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.861433702317894d, y: 0.33709687752442774d), radius: 0.03210776082159128d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7694014493429453d, y: 0.5327693787682168d), radius: 0.7685292929677822d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09280835590499559d, y: 0.34973439401310036d), radius: 0.7808766333912921d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5108753493455386d, y: 0.8324145938301576d), radius: 0.08246960851053786d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6380085009790084d, y: 0.11138042473403786d), radius: 0.7207507020110622d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6905932393185795d, y: 0.17656620635433973d), radius: 0.30451895660935624d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8363916746211683d, y: 0.0481817173165352d), radius: 0.4553015906032293d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683004935762301d, y: 0.9943991138371304d), radius: 0.6079982372364292d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5087917725972035d, y: 0.3977592532234704d), radius: 0.33776115257927763d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08886030704693226d, y: 0.9982830163817892d), radius: 0.26257898132315605d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3082459340379541d, y: 0.40690129824877463d), radius: 0.3616176705534164d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24757742768888713d, y: 0.4296125226205877d), radius: 0.452180497682687d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683747854514994d, y: 0.727891383185595d), radius: 0.443973602119236d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6894376886997464d, y: 0.16924054294490376d), radius: 0.762573249723581d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7457917605200661d, y: 0.6077375705325829d), radius: 0.4069906358469093d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5299456556650675d, y: 0.8435364912624567d), radius: 0.842401864458367d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4663123674945274d, y: 0.733760609776246d), radius: 0.4621860470077892d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6774392866766002d, y: 0.4711675168792694d), radius: 0.9220790497324236d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009184354680262241d, y: 0.1829624437008417d), radius: 0.7718964802634338d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44190592093576764d, y: 0.35212443334238275d), radius: 0.46241980383221903d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8436457238980779d, y: 0.3157439391940451d), radius: 0.8253179498280719d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8654102103239205d, y: 0.4961989169086709d), radius: 0.4621043911959949d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8916197479847472d, y: 0.1717943260416923d), radius: 0.3236239388455968d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7621791518033508d, y: 0.31856337629179454d), radius: 0.07110369564606511d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7906372502705301d, y: 0.09675965662206676d), radius: 0.7031696383765339d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8122706098470216d, y: 0.43203859320593463d), radius: 0.8612383316818495d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9533307522963387d, y: 0.2515007166099358d), radius: 0.2622529934651546d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9627394676488334d, y: 0.3152009403680528d), radius: 0.8710294777169711d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7257615781140114d, y: 0.7990209576124481d), radius: 0.4767883114942091d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9582218669921025d, y: 0.07170791531133913d), radius: 0.31411955329247143d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32253456247804524d, y: 0.9370395016836087d), radius: 0.936412958259623d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15991086660460507d, y: 0.5663603938015911d), radius: 0.5032846202013754d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1325459691362133d, y: 0.2347701003878968d), radius: 0.38764734736475903d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9816174840974339d, y: 0.8145330273490589d), radius: 0.49674841841035455d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45371967699168514d, y: 0.8074607599415673d), radius: 0.3357299109899514d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2833814019971961d, y: 0.8704867232753714d), radius: 0.4045038039839498d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4517912043165525d, y: 0.285222815936931d), radius: 0.2493105911397534d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9947812871541456d, y: 0.9500109949151642d), radius: 0.6150171417014212d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1297930948823276d, y: 0.8299971565642356d), radius: 0.2415771574873421d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1621156920105058d, y: 0.004563756229225113d), radius: 0.3204911481010968d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10734459256938378d, y: 0.4675614484195416d), radius: 0.9249797295370685d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.064261659332425d, y: 0.751625856614528d), radius: 0.7642149446488848d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.941484390511075d, y: 0.23013216417083326d), radius: 0.8299162469374886d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9231042419011991d, y: 0.16900165319915206d), radius: 0.5755502260037222d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2676213450414604d, y: 0.41676846441562987d), radius: 0.9571286708021982d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5424700981538954d, y: 0.36083830028580577d), radius: 0.8086339092328763d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9285947338572771d, y: 0.9437163744773239d), radius: 0.5022648596959535d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7980507299934715d, y: 0.5038694909160668d), radius: 0.8804180388661641d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6573278493051123d, y: 0.5815695947014697d), radius: 0.4006245304244356d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6864508418574443d, y: 0.026485454990211044d), radius: 0.653374432329411d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20430286947724452d, y: 0.22657634212471034d), radius: 0.14030788354637858d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8927306440806702d, y: 0.0475034347774097d), radius: 0.18190685677897656d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3844408187353572d, y: 0.3674196196366626d), radius: 0.06982008177740617d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21040745547224937d, y: 0.6797732561873661d), radius: 0.05536630225333383d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4017583907364417d, y: 0.270625603013241d), radius: 0.6927281507575597d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9998468080838515d, y: 0.7580678926125932d), radius: 0.690020798319958d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2824112237166121d, y: 0.02446549603182735d), radius: 0.11023809574122712d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8539859229848208d, y: 0.7759837493953929d), radius: 0.6405235983756682d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3671152556126852d, y: 0.544724432768006d), radius: 0.6377548634261707d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9129990718805984d, y: 0.6005289342769627d), radius: 0.7308869858081879d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6966683220325603d, y: 0.7019639207592782d), radius: 0.9556344528138503d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8793459545637669d, y: 0.17299446075191627d), radius: 0.12265785324648104d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9022271188095579d, y: 0.4394035279043518d), radius: 0.6059404202924118d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7304546827452936d, y: 0.8010010156795909d), radius: 0.5941372154597961d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45873925736461973d, y: 0.40554376258359237d), radius: 0.39734607739548955d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9052010356626838d, y: 0.4896925019637558d), radius: 0.05599573623779508d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16555611491756717d, y: 0.5798318326176961d), radius: 0.873448918977103d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7106242969435101d, y: 0.8304433220027051d), radius: 0.08605218865504527d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8923479082730461d, y: 0.7492114687492777d), radius: 0.5968904332999219d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13015358899534202d, y: 0.06189653163902176d), radius: 0.9829934072360771d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46382180581343047d, y: 0.9369470670598216d), radius: 0.29173522614535763d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.353197687616584d, y: 0.05049117108122425d), radius: 0.19353641895933982d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19614593526345458d, y: 0.3922929286646729d), radius: 0.07341400491777317d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9216641405575409d, y: 0.987798336646218d), radius: 0.03687314325054414d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020280514542381667d, y: 0.7650489053401002d), radius: 0.29065126950173703d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7062895366453282d, y: 0.35309345600446507d), radius: 0.8608157329504112d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31606398925947055d, y: 0.38039301815834303d), radius: 0.5402538869683752d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31804297336726295d, y: 0.13593377684822583d), radius: 0.5181903380832799d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9447378075441205d, y: 0.06508831759099032d), radius: 0.04553212635106396d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19395176127620228d, y: 0.45225723177390165d), radius: 0.7246992135011354d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3735171735370578d, y: 0.6952041710920275d), radius: 0.1308688024412099d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8720362920651783d, y: 0.1119727083606119d), radius: 0.9695226741603964d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47767172927953117d, y: 0.6468152887906854d), radius: 0.183801149058755d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.038614635881632386d, y: 0.5981577128801662d), radius: 0.9135150996334229d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.029887785031538106d, y: 0.9613544837826924d), radius: 0.604678044132229d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18218333775556617d, y: 0.9195741015025315d), radius: 0.8879911340673717d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763313040747983d, y: 0.9099317290592481d), radius: 0.9535890956436252d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.410878240986812d, y: 0.38955609649968115d), radius: 0.5874480357863472d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9720650592160067d, y: 0.5469565169367314d), radius: 0.638303955329531d), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.897814901391147d, y: 0.6503636956932305d), radius: 0.7942863915390502d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.511872754890599d, y: 0.6031865788504516d), radius: 0.7604937297363579d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14113016162479175d, y: 0.32220111513402805d), radius: 0.43483580873466365d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3444066216261713d, y: 0.7917017601257142d), radius: 0.5322378109377479d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6488652304594708d, y: 0.539975909835359d), radius: 0.315925312825742d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9014549318772349d, y: 0.438819886816159d), radius: 0.828021835980274d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.677667709663923d, y: 0.7072792882239032d), radius: 0.265487179140238d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19632024466241305d, y: 0.593537291101377d), radius: 0.8765090648749327d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9335265007490946d, y: 0.5356214843256948d), radius: 0.3842304172503631d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9219200529011838d, y: 0.9782521532563827d), radius: 0.3593802210212601d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4672564451308364d, y: 0.9552835241928811d), radius: 0.6703643370491194d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09682356011465809d, y: 0.8134797229806293d), radius: 0.6146082452522024d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45820311217182086d, y: 0.8577748682416538d), radius: 0.963565753607532d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36499219336144406d, y: 0.8985681546988852d), radius: 0.2438947312669708d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2775443868769659d, y: 0.2821309998436121d), radius: 0.828383364438407d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.588886860132971d, y: 0.17734982054586124d), radius: 0.18199265886616356d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9690265209899713d, y: 0.1409025787682141d), radius: 0.3059967261297484d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9067254096874302d, y: 0.1500275247360323d), radius: 0.5739662825865649d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17420528498596832d, y: 0.5046240243684035d), radius: 0.4048896901705259d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9531204093554301d, y: 0.2096013490019225d), radius: 0.03841767444442634d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6652724315265962d, y: 0.8487602054555051d), radius: 0.7744068079340052d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37772403859550274d, y: 0.6949332548467927d), radius: 0.7967661452451058d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9405352114257397d, y: 0.19194706439246323d), radius: 0.046078317515919065d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3289452522217917d, y: 0.7449521066616202d), radius: 0.11884440282880437d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49083594038771294d, y: 0.7362793216631516d), radius: 0.7396445260206675d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4301683278562001d, y: 0.4473005494637943d), radius: 0.8576349939730895d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4969457188233347d, y: 0.29561673335345695d), radius: 0.12974524994695458d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6220501488539528d, y: 0.8711377318521497d), radius: 0.3092137270031974d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3481342144682701d, y: 0.352524013287958d), radius: 0.8355883880078845d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05667589712348842d, y: 0.4846387267965502d), radius: 0.8516799485187956d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.938113174604975d, y: 0.5310468313115075d), radius: 0.35484866188066555d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8822357116638985d, y: 0.060264443266029755d), radius: 0.28059938571730525d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8212707318263107d, y: 0.9334018070842672d), radius: 0.6062388925694826d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9006564110303519d, y: 0.8365347511754374d), radius: 0.8677470740181848d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2855211455215003d, y: 0.748454629777872d), radius: 0.19994502374880985d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08902777204179046d, y: 0.7223495764314786d), radius: 0.5457599432760939d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8865925415901922d, y: 0.4437967696083862d), radius: 0.6045143362654738d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8274564464059909d, y: 0.2521959909271646d), radius: 0.6781162417995142d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5098370840662654d, y: 0.7390034393569742d), radius: 0.32529682833143514d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5346981121430521d, y: 0.7146270736811648d), radius: 0.0899532018711543d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2055323457278957d, y: 0.4069920470245816d), radius: 0.943526335294485d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4291058654910731d, y: 0.6809421173927372d), radius: 0.3904059259979108d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8794946959929342d, y: 0.9613828551064695d), radius: 0.012942525984402486d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3883129795834863d, y: 0.6658071113807181d), radius: 0.27002719409583487d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09868722676078223d, y: 0.2022821312976979d), radius: 0.6070070063915635d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47033138184072654d, y: 0.23223904012600272d), radius: 0.4005466289573437d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39461999411420456d, y: 0.6739778273972901d), radius: 0.9201143355865035d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12437715135205318d, y: 0.12787718892642763d), radius: 0.6788823953870636d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8946438813651636d, y: 0.6484146552075875d), radius: 0.7200219227121254d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24867321113795648d, y: 0.3147222713465201d), radius: 0.27593480312042185d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9837522391617992d, y: 0.16174037333282165d), radius: 0.54218311520002d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06898406890041386d, y: 0.09475648471488418d), radius: 0.9184920649468075d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7964543832839743d, y: 0.30627159162024176d), radius: 0.8814951285964172d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2847535849082983d, y: 0.3660481347217839d), radius: 0.8258116212348192d), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7438293953955161d, y: 0.36487713347436246d), radius: 0.31438671461731904d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7265014191835681d, y: 0.28182086267473194d), radius: 0.7751878361909139d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028611730056541607d, y: 0.06906799916296802d), radius: 0.7226316505713326d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3995951001712288d, y: 0.12546435691977298d), radius: 0.13323490623685008d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3757216205382604d, y: 0.7868614338255159d), radius: 0.956307563159272d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9994627768853174d, y: 0.20781125390626143d), radius: 0.9506543751302085d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3043038386632676d, y: 0.10792412488769387d), radius: 0.17489937516012677d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021523791263962977d, y: 0.08642701070810632d), radius: 0.027686147836609165d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15608350929474268d, y: 0.8584337420946635d), radius: 0.4096857972582808d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6031857029598237d, y: 0.0031784174425655287d), radius: 0.7339783740888353d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2565496207187875d, y: 0.3031597351923446d), radius: 0.44528140628218893d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22647475960020647d, y: 0.678204889139174d), radius: 0.33785504415283696d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4434963245070921d, y: 0.08290009955178379d), radius: 0.570340421432542d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763406101029665d, y: 0.466863449346534d), radius: 0.06539370060523952d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05398525962038958d, y: 0.6139331934207114d), radius: 0.6815905829310692d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3312188985617357d, y: 0.719841051539747d), radius: 0.29210495749974674d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41053160289155577d, y: 0.8089363406454423d), radius: 0.8557183481019819d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5932771850821982d, y: 0.1270462719090737d), radius: 0.8374307486395316d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7906513008814423d, y: 0.31291118011930064d), radius: 0.4130391397639046d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36156055582377733d, y: 0.879579678913425d), radius: 0.7354330700166604d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40032917891515973d, y: 0.04444059883416751d), radius: 0.6996693024920162d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2889474212307662d, y: 0.4199360981237502d), radius: 0.6420018473560666d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7686078060467907d, y: 0.11225987630487333d), radius: 0.9390383786116374d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.665570331253022d, y: 0.43994193883932586d), radius: 0.2303481199385713d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7197759923087605d, y: 0.04647090472919613d), radius: 0.646174745908311d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27731995755455396d, y: 0.5591415672741251d), radius: 0.8376572999119705d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06506767820494641d, y: 0.6673688683110739d), radius: 0.6047045527537461d), }, }, },
    ModelInner = new NpgsqlCirclecircleMMArrayD3E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3610150949548995d, y: 0.24589955056635882d), radius: 0.2862918408953592d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2486075417251271d, y: 0.6336947430077317d), radius: 0.11056688704867634d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.041253060909957506d, y: 0.43727624843057544d), radius: 0.477362246452116d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28963970956729534d, y: 0.7268104619422324d), radius: 0.5190451113197716d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7068518518109365d, y: 0.10552323680493203d), radius: 0.2393573231891558d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7156314515199184d, y: 0.29755569548418903d), radius: 0.5794840893519191d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7032663359684828d, y: 0.2009621994561852d), radius: 0.9968921975363352d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9719153178331625d, y: 0.5778453353263424d), radius: 0.8522356046616778d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.047456825532801616d, y: 0.7058460779988396d), radius: 0.09553113862578311d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9344110323801925d, y: 0.12690602940567186d), radius: 0.4171538448568246d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9556767530931676d, y: 0.9399208028585755d), radius: 0.891205600878289d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6289805541596297d, y: 0.46332199959525433d), radius: 0.27675335054644845d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.050248793291596705d, y: 0.2502349678299075d), radius: 0.7480501099985704d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25677647260611913d, y: 0.9506653040453565d), radius: 0.37587527444312907d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7317997896920957d, y: 0.9930294483974512d), radius: 0.7763140344756759d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9594560900883224d, y: 0.7597868037491822d), radius: 0.5609098622383447d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6727470152631657d, y: 0.8986599007634923d), radius: 0.7642599885308512d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3490909033324824d, y: 0.9934690889525104d), radius: 0.5825501013707007d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30868995065695215d, y: 0.09011365038506047d), radius: 0.9813790174917769d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01569291553149421d, y: 0.16265959092069682d), radius: 0.501703466798062d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9307549903150382d, y: 0.18587357304420238d), radius: 0.7954839264638919d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7827287278924123d, y: 0.21279800620233214d), radius: 0.5191563147508031d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04130180692683294d, y: 0.24808466493171788d), radius: 0.8714818033088734d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06839989104905286d, y: 0.8271457748694071d), radius: 0.20581320773599565d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8357401202408092d, y: 0.15487187587332274d), radius: 0.1377770400393401d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07975751939258868d, y: 0.0034924098228924505d), radius: 0.27752806379370676d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4170120714594101d, y: 0.48513565255118163d), radius: 0.5955468564549204d), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3884781911066669d, y: 0.3195793324952967d), radius: 0.9793787917817433d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5054647882116429d, y: 0.09067667743152985d), radius: 0.07986812045810265d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7587616610976685d, y: 0.6589505373767749d), radius: 0.9850718520907061d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.923210934861439d, y: 0.8640384881717016d), radius: 0.04105999526523996d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49827349439119184d, y: 0.4983949600628593d), radius: 0.024783689439523027d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3612484662592198d, y: 0.030504924459426652d), radius: 0.4331062464691814d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08549564234244056d, y: 0.48698894064260134d), radius: 0.46495647586095523d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13870951872672665d, y: 0.15511411149288545d), radius: 0.24164087923635702d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5448267973898748d, y: 0.3508084139111681d), radius: 0.06868733505780333d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24786154294379292d, y: 0.9053083915833706d), radius: 0.40840978896765623d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4953585495844893d, y: 0.9092351740722394d), radius: 0.25669973802937607d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05314269827402518d, y: 0.35974892592050567d), radius: 0.7477134615688537d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35078753035896737d, y: 0.33348705123424804d), radius: 0.6621940494035946d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5743649240138883d, y: 0.9703696880821182d), radius: 0.6337265541621427d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4186232377824016d, y: 0.02307696301439066d), radius: 0.4651946035714448d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.650296426898528d, y: 0.5668003953202042d), radius: 0.38122491984801066d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43896689233821673d, y: 0.4652567906252385d), radius: 0.4626509910939638d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4049621291649973d, y: 0.6564544145001517d), radius: 0.7072108189178818d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21400483616896238d, y: 0.4235815770997521d), radius: 0.13778362690688883d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.032250714060794605d, y: 0.4268420932384883d), radius: 0.06472717954837859d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4228974147573764d, y: 0.7862855163532254d), radius: 0.2829006045961837d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7401453411695368d, y: 0.24393227760327296d), radius: 0.9915886753184858d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6452165645261049d, y: 0.6054386876064818d), radius: 0.43896187326103075d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8350884954802151d, y: 0.8533383695451182d), radius: 0.8411412692551617d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1018734753559174d, y: 0.9039405168044713d), radius: 0.7649416993974876d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1321205093122262d, y: 0.7697521815904672d), radius: 0.7032045457561955d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.618368525852108d, y: 0.3503009955439085d), radius: 0.9607214896448721d), }, }, },
},
            new NpgsqlCirclecircleMMArrayD3E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1751098374324328d, y: 0.14128649444019659d), radius: 0.8154801254836586d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8573289588370393d, y: 0.8435938138289591d), radius: 0.5645502708702778d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.650550171293906d, y: 0.40822497531274793d), radius: 0.8934960443544545d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17840879537275334d, y: 0.7699923174803759d), radius: 0.9731639229230934d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31319292471648663d, y: 0.15707062302733144d), radius: 0.34270960848234333d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9924580904986497d, y: 0.4416440993692141d), radius: 0.012164014923084276d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8843867461680586d, y: 0.11954825824217874d), radius: 0.1828777081738968d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4932395416393026d, y: 0.5715435273892774d), radius: 0.6172134940165298d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5920763916265593d, y: 0.18012163368646306d), radius: 0.41524584605677717d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2793915604338816d, y: 0.47627507191019214d), radius: 0.5575326048431899d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8344264736183298d, y: 0.4279908700957743d), radius: 0.8464727508428684d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8328347904327035d, y: 0.40258808957638925d), radius: 0.44443410206254896d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0807200754424321d, y: 0.9706151014310584d), radius: 0.781618219150454d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8704585032910799d, y: 0.679413323998631d), radius: 0.31088913332936585d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13045255885923257d, y: 0.6023248198006081d), radius: 0.6584069240388508d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12837616091114146d, y: 0.25215173718424067d), radius: 0.40153025445926516d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13491538291244043d, y: 0.688066616619947d), radius: 0.9332863538262486d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3356894457307784d, y: 0.7462863887717089d), radius: 0.6812577648375177d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1097183136784412d, y: 0.9430678927295962d), radius: 0.7994148573556775d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27789218697584783d, y: 0.2880928735924092d), radius: 0.81373355503939d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15681145509426686d, y: 0.30601696048733196d), radius: 0.15094135302950484d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8893181736465825d, y: 0.22449711888578117d), radius: 0.7061368373003793d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024547999797963516d, y: 0.715936963664308d), radius: 0.2302238234289915d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2857091110266784d, y: 0.8879697625338132d), radius: 0.807812992722602d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44785435605724655d, y: 0.7975984349405595d), radius: 0.8398812467392681d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2776060168479475d, y: 0.06074259161717965d), radius: 0.1850610082218045d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.673440047880635d, y: 0.5156855313191397d), radius: 0.3649381640210769d), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.943969657648626d, y: 0.09955832311996382d), radius: 0.9473765489688621d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9092050068493174d, y: 0.790545852214956d), radius: 0.2690851605208672d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20152772786602546d, y: 0.6693499568379728d), radius: 0.6104804184816008d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3028640790989452d, y: 0.9767655484168819d), radius: 0.5104564376794373d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8200506256242438d, y: 0.34109671045724144d), radius: 0.8634101238782335d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4958644331757528d, y: 0.8407157771240233d), radius: 0.8046407230060599d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6931496695064348d, y: 0.48313159387530547d), radius: 0.9774612682448361d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.824637614371002d, y: 0.10815722666594607d), radius: 0.8533133490759721d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7259520770902136d, y: 0.37398053850751267d), radius: 0.29620153483169454d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6869860636948649d, y: 0.42514064350583014d), radius: 0.3661610254191914d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26523240209332544d, y: 0.16018658590703427d), radius: 0.7068828124719779d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5342831615398925d, y: 0.6607644494111796d), radius: 0.8355328346963029d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7043294647652442d, y: 0.19765838628198173d), radius: 0.8490938318991166d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35476040598231573d, y: 0.5187184171540875d), radius: 0.3525438315538383d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38129716149362425d, y: 0.7412027262753935d), radius: 0.34291296850080333d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6176960993528248d, y: 0.2625582607588176d), radius: 0.15621579061582602d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6140166430254511d, y: 0.5130147576185854d), radius: 0.4099448389059077d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6053353963673362d, y: 0.48451454472284294d), radius: 0.8392256247318777d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5194587840444942d, y: 0.9649364855505306d), radius: 0.5492684558569693d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7615216045494623d, y: 0.2005173851208517d), radius: 0.45989212546460867d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35970414704674547d, y: 0.679808933626063d), radius: 0.8458129512960928d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5709274612539786d, y: 0.6096112441225641d), radius: 0.7663870836048953d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9907687209162495d, y: 0.05756073273786577d), radius: 0.7959223405116304d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5332391332112335d, y: 0.8957501981903345d), radius: 0.778741554033845d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.117950785948849d, y: 0.467456794232599d), radius: 0.5135911693984867d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8520378575765094d, y: 0.44882955256546253d), radius: 0.6265231232942399d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6451397159142949d, y: 0.3682074618754869d), radius: 0.9614937934319151d), }, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd3e1mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd3e1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]), 
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

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd3e1mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd3e1mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd3e1mi_id
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
    npgsqlcirclecirclemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                NpgsqlTypes.NpgsqlCircle[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41720265962057146d, y: 0.5870174862271623d), radius: 0.5673958698774897d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5407597621839062d, y: 0.18798014499040916d), radius: 0.32586578321423376d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6584193620312259d, y: 0.07568238102318958d), radius: 0.9022234072254153d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14338425298615287d, y: 0.2670991362216206d), radius: 0.939837091405867d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1274286456487448d, y: 0.31954317550592126d), radius: 0.1188686380917513d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17831643034723577d, y: 0.2185489799014283d), radius: 0.16506229436624142d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5948537690956581d, y: 0.6828688047335768d), radius: 0.12700393167385426d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.492788784464291d, y: 0.8722535884027046d), radius: 0.0017241126799922846d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.97875512970066d, y: 0.5653464566471331d), radius: 0.5233245332527985d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09878785535958357d, y: 0.013029797427944745d), radius: 0.7197197876131036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8864606360023934d, y: 0.01042304880481748d), radius: 0.5659690987316565d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8024808251680202d, y: 0.8486503032122231d), radius: 0.924429481754282d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2585143193237438d, y: 0.20614977775035181d), radius: 0.2106460619072088d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.349130859383716d, y: 0.7890388278633725d), radius: 0.9748951654325584d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4498164791184769d, y: 0.24810549430284445d), radius: 0.8733928372768971d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4826547568899823d, y: 0.9763125327035725d), radius: 0.42953625289267394d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4301410502404046d, y: 0.6076741339989736d), radius: 0.691860279180382d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9852254291712743d, y: 0.1712839410878303d), radius: 0.020946323146088575d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5800034611486108d, y: 0.3622422364048984d), radius: 0.5510903395925819d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0676194964769109d, y: 0.6692581764096192d), radius: 0.8418515630798418d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9843662410091881d, y: 0.9069438779975723d), radius: 0.5723391784486328d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9674951082114388d, y: 0.012820544281047286d), radius: 0.17450076824107685d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7184477701505945d, y: 0.4139350056800414d), radius: 0.10301394743317138d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3333210723818897d, y: 0.5135490289961369d), radius: 0.6424453443783742d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8956046954114364d, y: 0.8251493814554461d), radius: 0.5725058721450943d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6851077359344883d, y: 0.5945021082168495d), radius: 0.2040007832438201d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00723757766874511d, y: 0.5787412710493679d), radius: 0.8085075465169346d), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd3e1mi_id
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
    npgsqlcirclecirclemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd3e1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[,,] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[,,] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,,] { { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9560332382900529d, y: 0.6582722476146528d), radius: 0.23173142696364268d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.002600356329564679d, y: 0.025485149237399307d), radius: 0.6080261186566334d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6448121067042755d, y: 0.23801795279511617d), radius: 0.09099264366619997d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4176077559054888d, y: 0.18760453461895554d), radius: 0.7857723779441625d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11713775893665046d, y: 0.5579586894126188d), radius: 0.6835824144561242d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45058160705800476d, y: 0.8663129339854811d), radius: 0.2538187365604977d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3008968557275524d, y: 0.856772134635255d), radius: 0.7695901472423948d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21528891804471917d, y: 0.6208826287683175d), radius: 0.6475391931546991d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17937966358874147d, y: 0.3712492817861618d), radius: 0.25048020696421647d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8461602182506681d, y: 0.23356304547398443d), radius: 0.5848098629562198d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2120153950843484d, y: 0.5738219777341361d), radius: 0.36016961312790385d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6927287844001179d, y: 0.7260960365216754d), radius: 0.5023829537659394d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5008171435930479d, y: 0.6325463720252409d), radius: 0.9437575575028934d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9376124526471418d, y: 0.5719883286534905d), radius: 0.7590759516734658d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1670762318001906d, y: 0.07947962611539261d), radius: 0.6629312638670432d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6604993450983958d, y: 0.4583369096829334d), radius: 0.34224838487229536d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9658122589592746d, y: 0.45269054324192715d), radius: 0.7638482171112435d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8287699220083455d, y: 0.7472508497492949d), radius: 0.658754344337661d), }, }, { { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33057550016725523d, y: 0.3517955011162984d), radius: 0.014956228469593769d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3181344043502796d, y: 0.6339964812913303d), radius: 0.7337859122681036d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8889335570359562d, y: 0.22694741675217067d), radius: 0.30133751315651214d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19644323252100837d, y: 0.9020288533056651d), radius: 0.4863392202258616d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30467456100345724d, y: 0.15561746151034117d), radius: 0.6955984429234386d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6189433074352853d, y: 0.6710546788068882d), radius: 0.4124219621810622d), }, { new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7215726459948277d, y: 0.4905336955469657d), radius: 0.7615977724979351d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6475162698238373d, y: 0.5874761216838899d), radius: 0.6362427686393041d), new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5508558032118364d, y: 0.7527669681716246d), radius: 0.9334939694714159d), }, }, }));
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD3E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD3E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M), typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd3e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M), typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd3e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M), typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 104;
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd3e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M), typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 35, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 139, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 152, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 148, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 151, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD3E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD3E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd3e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd3e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 139, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                NpgsqlCirclecircleMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD3E1MIWA),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD3E1MI),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD3E1M),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
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
FROM public.binary_npgsqlcirclecirclemmarrayd3e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemmarrayd3e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models =  ((INpgsqlCircleMArraycircleMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA), typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
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
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
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
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA), typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
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
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
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
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MI), typeof(NpgsqlCirclecircleMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MI>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MI>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA), typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD3E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD3))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

