

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
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6994597213628143d, y: 0.38698058491140985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865164117065387d, y: 0.9079718297865741d), new NpgsqlTypes.NpgsqlPoint(x: 0.34307135527178645d, y: 0.16636716508941896d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08759494004410684d, y: 0.04020655570133502d), new NpgsqlTypes.NpgsqlPoint(x: 0.36524711965732415d, y: 0.6486575188506062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5473136352774283d, y: 0.7957346869943432d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8068819885209475d, y: 0.7040128022946375d), new NpgsqlTypes.NpgsqlPoint(x: 0.3472044538218817d, y: 0.1868964188971407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577678419025515d, y: 0.8928241492823118d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8635258563291018d, y: 0.43145991990334365d), new NpgsqlTypes.NpgsqlPoint(x: 0.35403591706178716d, y: 0.6955121801312344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7123100607232927d, y: 0.7636798829692961d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7806792049248475d, y: 0.7377794032402892d), new NpgsqlTypes.NpgsqlPoint(x: 0.33311988544704696d, y: 0.2150202553524596d), new NpgsqlTypes.NpgsqlPoint(x: 0.004600052497189977d, y: 0.6855524338981898d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09004367681147196d, y: 0.816443273395598d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617326987947195d, y: 0.866200046595327d), new NpgsqlTypes.NpgsqlPoint(x: 0.30862434240431635d, y: 0.24578446269570653d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4959369958047617d, y: 0.47452137839725317d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234150210861526d, y: 0.930672191557068d), new NpgsqlTypes.NpgsqlPoint(x: 0.24309831818165206d, y: 0.28581388150974474d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1470424227137188d, y: 0.9794855950388818d), new NpgsqlTypes.NpgsqlPoint(x: 0.21716727291229998d, y: 0.8672797739766218d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764167182608805d, y: 0.13741514186280257d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2960734722625845d, y: 0.9028679240641756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553379022338227d, y: 0.5486211015324282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237987227576245d, y: 0.9764295529761507d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.445673778706802d, y: 0.7380375899119911d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639133092551891d, y: 0.7414042387979284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329660250764064d, y: 0.3825194701303396d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3457364530174434d, y: 0.5036426195744627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9003043334379796d, y: 0.7045324633113953d), new NpgsqlTypes.NpgsqlPoint(x: 0.807921246031466d, y: 0.24369460558244194d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9662586168240461d, y: 0.68805205418046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758180155665775d, y: 0.17106703843149806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380798538824022d, y: 0.03744603798576762d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29512382545154836d, y: 0.8772213921611257d), new NpgsqlTypes.NpgsqlPoint(x: 0.0311035438208207d, y: 0.8015801617761809d), new NpgsqlTypes.NpgsqlPoint(x: 0.679454864007424d, y: 0.09954449703246493d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9782671839663142d, y: 0.6629951725526568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554133706873014d, y: 0.7319825384901864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9088379732643923d, y: 0.38503016029310255d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15847095209986883d, y: 0.9582022157185057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421775510027709d, y: 0.01468373441276516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1782760180557743d, y: 0.13994814342296558d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016448309185597143d, y: 0.2895507421933923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3811218880708709d, y: 0.0055091781564570175d), new NpgsqlTypes.NpgsqlPoint(x: 0.10705758446865055d, y: 0.4170855631904187d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7037045311563264d, y: 0.33646744285580577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016787252749428d, y: 0.9986576029990066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631690266279251d, y: 0.17959759249922347d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34041287530766273d, y: 0.887791337087188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407185872342093d, y: 0.30148003543222357d), new NpgsqlTypes.NpgsqlPoint(x: 0.573036413386585d, y: 0.46462421133405685d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8004258280938187d, y: 0.08623594945384294d), new NpgsqlTypes.NpgsqlPoint(x: 0.17843858549517366d, y: 0.5146433069357552d), new NpgsqlTypes.NpgsqlPoint(x: 0.05229496350196883d, y: 0.6521050496079418d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9337477180355239d, y: 0.31003218309292535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443736217033988d, y: 0.07841783352690324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720741678535205d, y: 0.5342722051714408d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22052715124335076d, y: 0.4604551809283848d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835263069198469d, y: 0.40230557852023996d), new NpgsqlTypes.NpgsqlPoint(x: 0.01277969801361245d, y: 0.4374999880713437d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7348540998211849d, y: 0.5759491856704421d), new NpgsqlTypes.NpgsqlPoint(x: 0.14737740829741874d, y: 0.2942230881120801d), new NpgsqlTypes.NpgsqlPoint(x: 0.03193007516367774d, y: 0.778576746632165d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23304218421825917d, y: 0.6216073465652532d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203115862523436d, y: 0.8631178009171337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4969377679511464d, y: 0.8529444128304015d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7166028959287231d, y: 0.7694228138865113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729703774538338d, y: 0.49931398340134614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2978277287250106d, y: 0.5824153311072925d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7058179072576098d, y: 0.7363223186482359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772033497448275d, y: 0.1634572508339972d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571703075695094d, y: 0.8714904805320057d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14712994946430902d, y: 0.00025839802689797686d), new NpgsqlTypes.NpgsqlPoint(x: 0.08788391209998436d, y: 0.7432259440156954d), new NpgsqlTypes.NpgsqlPoint(x: 0.41976532532402344d, y: 0.7234418482085343d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8049431512042892d, y: 0.2446847488414522d), new NpgsqlTypes.NpgsqlPoint(x: 0.16207960093259d, y: 0.41298778890441756d), new NpgsqlTypes.NpgsqlPoint(x: 0.960903550026009d, y: 0.10276614926871863d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6650386277049868d, y: 0.6770605318433431d), new NpgsqlTypes.NpgsqlPoint(x: 0.355953333393919d, y: 0.34615055723677257d), new NpgsqlTypes.NpgsqlPoint(x: 0.329479154018232d, y: 0.9334466286757752d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16727940418906395d, y: 0.8664187586056731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607508770109752d, y: 0.011097086255205113d), new NpgsqlTypes.NpgsqlPoint(x: 0.26751541508741494d, y: 0.8964352458782667d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19385165827273076d, y: 0.9218932065449517d), new NpgsqlTypes.NpgsqlPoint(x: 0.547371632066838d, y: 0.13927950370254516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9909754407343754d, y: 0.5568136549709032d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3787020363015018d, y: 0.6102310763556121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803334746294918d, y: 0.3020306578889451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5326586187216069d, y: 0.7363647458909939d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6097565390677833d, y: 0.5465897200456197d), new NpgsqlTypes.NpgsqlPoint(x: 0.67403895425476d, y: 0.3773147913255521d), new NpgsqlTypes.NpgsqlPoint(x: 0.07379237530813554d, y: 0.18040359075876788d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4856762632093713d, y: 0.10994970463384246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7135368423281078d, y: 0.6893708919380646d), new NpgsqlTypes.NpgsqlPoint(x: 0.22635057611768739d, y: 0.16508167731961176d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07425146365064939d, y: 0.7383416856742248d), new NpgsqlTypes.NpgsqlPoint(x: 0.57955334657248d, y: 0.9269536350725905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349288188139443d, y: 0.059608501859703344d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3448074321778509d, y: 0.11989075602419019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327123038613234d, y: 0.28376904512294765d), new NpgsqlTypes.NpgsqlPoint(x: 0.19544952855632203d, y: 0.6381105218951181d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7148826313627334d, y: 0.3592539683211816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227694091824184d, y: 0.21622966174052605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8231495847714422d, y: 0.044440342986838965d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49040337548724844d, y: 0.05830086834858461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433026607559251d, y: 0.6311303137609958d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412383204046044d, y: 0.5015362135420998d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6146222030279879d, y: 0.5496828780861417d), new NpgsqlTypes.NpgsqlPoint(x: 0.06086031337979525d, y: 0.09849261534831621d), new NpgsqlTypes.NpgsqlPoint(x: 0.28801528244674646d, y: 0.935753243257506d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46394596376948827d, y: 0.26601365690120093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267985323302373d, y: 0.6984375792499777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9247298874913913d, y: 0.1519898369038839d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4243855198465665d, y: 0.21071759281294977d), new NpgsqlTypes.NpgsqlPoint(x: 0.513804255618444d, y: 0.5380354528782211d), new NpgsqlTypes.NpgsqlPoint(x: 0.23480046999716786d, y: 0.5908125918050428d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9844117929029204d, y: 0.49787782217211274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447849983382464d, y: 0.6810149861351167d), new NpgsqlTypes.NpgsqlPoint(x: 0.10247535983360456d, y: 0.6741914386159873d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05025323595855802d, y: 0.949759349446369d), new NpgsqlTypes.NpgsqlPoint(x: 0.06040541272960209d, y: 0.41097631954088176d), new NpgsqlTypes.NpgsqlPoint(x: 0.515188339681485d, y: 0.628593227969109d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5272185715667738d, y: 0.8538587268713492d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049935295165235d, y: 0.8063080092971211d), new NpgsqlTypes.NpgsqlPoint(x: 0.42047680388033104d, y: 0.07546018347627825d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6370144411213335d, y: 0.501307955771181d), new NpgsqlTypes.NpgsqlPoint(x: 0.435015993215745d, y: 0.5823606928476632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861501324885253d, y: 0.03664075774212827d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.685345849797955d, y: 0.4369267920116905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562977224157631d, y: 0.7435551888930503d), new NpgsqlTypes.NpgsqlPoint(x: 0.4840473681581291d, y: 0.23619106722740713d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7870851069512919d, y: 0.6419417816111056d), new NpgsqlTypes.NpgsqlPoint(x: 0.723501475318583d, y: 0.6366253525620327d), new NpgsqlTypes.NpgsqlPoint(x: 0.47393191855856154d, y: 0.4319172143157489d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9902296444270436d, y: 0.8018999304077348d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405377731389172d, y: 0.5577080455298787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194507501116947d, y: 0.4870354578334729d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8385612550457008d, y: 0.09472204708541487d), new NpgsqlTypes.NpgsqlPoint(x: 0.0643821761428105d, y: 0.0832398688563436d), new NpgsqlTypes.NpgsqlPoint(x: 0.30125080965584494d, y: 0.24499167663156507d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22316330962219288d, y: 0.37828674023123d), new NpgsqlTypes.NpgsqlPoint(x: 0.33214939019078304d, y: 0.8763354715757938d), new NpgsqlTypes.NpgsqlPoint(x: 0.2567335015433371d, y: 0.6242772357472985d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4831183703327314d, y: 0.03983293827722678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086674825318145d, y: 0.6387859422188789d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688624549358851d, y: 0.8913269743386045d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18394132139295105d, y: 0.9836552981031457d), new NpgsqlTypes.NpgsqlPoint(x: 0.22718512563502102d, y: 0.09750269544457324d), new NpgsqlTypes.NpgsqlPoint(x: 0.0432003135586142d, y: 0.1368084113289577d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41472247512524574d, y: 0.9259160940612853d), new NpgsqlTypes.NpgsqlPoint(x: 0.47745836114058116d, y: 0.83149299123539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354907251939571d, y: 0.9643995274952036d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8661591048231045d, y: 0.31122208395010154d), new NpgsqlTypes.NpgsqlPoint(x: 0.14636756729604639d, y: 0.12059718326542723d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288409193776986d, y: 0.17055117822558108d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09810390424333304d, y: 0.5477901116836899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967229213758257d, y: 0.07397313044850606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296652283284135d, y: 0.40676126181985917d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04909797650069592d, y: 0.02087364266486258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883942853637045d, y: 0.9604424267330656d), new NpgsqlTypes.NpgsqlPoint(x: 0.786912155976302d, y: 0.6700123632639863d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7627369536540612d, y: 0.24082932721475425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621535884455766d, y: 0.785863045194604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841194134473396d, y: 0.018829426521566828d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9512654765557257d, y: 0.3944531995056111d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026454189711016d, y: 0.8459452947924915d), new NpgsqlTypes.NpgsqlPoint(x: 0.3637273450441786d, y: 0.734925946036977d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7747910551001181d, y: 0.6718505785302129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753303682817457d, y: 0.03236935150981468d), new NpgsqlTypes.NpgsqlPoint(x: 0.01719516777690544d, y: 0.5148398994370013d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3690962766860171d, y: 0.22557772024916278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441507099661885d, y: 0.5516824936996059d), new NpgsqlTypes.NpgsqlPoint(x: 0.725960398812282d, y: 0.8810327501276269d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9755120008472092d, y: 0.7288658455784053d), new NpgsqlTypes.NpgsqlPoint(x: 0.18570865662748703d, y: 0.439300800229811d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736665560994089d, y: 0.3702938166318359d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7423836940540762d, y: 0.6932498580622906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4877397730026085d, y: 0.1419935502830314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575941044577769d, y: 0.5647703904787894d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7105049059954825d, y: 0.02841650819697128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412943672948901d, y: 0.7609343339924073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747476046625995d, y: 0.7359927423680624d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52030564300286d, y: 0.5887703672274013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008441275964639d, y: 0.9628943228597739d), new NpgsqlTypes.NpgsqlPoint(x: 0.4350241796788358d, y: 0.2700264490704273d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7821545970129281d, y: 0.581793712345569d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822920795638284d, y: 0.5328458280569466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493126781040081d, y: 0.2502822436406057d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5720401170557087d, y: 0.49803904247664366d), new NpgsqlTypes.NpgsqlPoint(x: 0.43417012958522305d, y: 0.9461755104974919d), new NpgsqlTypes.NpgsqlPoint(x: 0.530342731623177d, y: 0.6486348113576921d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9878998130770643d, y: 0.8641588707444505d), new NpgsqlTypes.NpgsqlPoint(x: 0.31367224066098d, y: 0.4746046754755754d), new NpgsqlTypes.NpgsqlPoint(x: 0.35884181665756365d, y: 0.4029895560597542d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6094421715140969d, y: 0.18551671343671916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166210275131939d, y: 0.6518381979748041d), new NpgsqlTypes.NpgsqlPoint(x: 0.20090038629905738d, y: 0.07007944623177864d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6070600521879637d, y: 0.17388739885896554d), new NpgsqlTypes.NpgsqlPoint(x: 0.40122057116311005d, y: 0.15063710009198839d), new NpgsqlTypes.NpgsqlPoint(x: 0.40356989679470223d, y: 0.4734396758277407d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9587128651768321d, y: 0.5915748867793803d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059886657725436d, y: 0.6812461019105799d), new NpgsqlTypes.NpgsqlPoint(x: 0.19277612755272044d, y: 0.692699017389119d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6513052559634303d, y: 0.023185606927691782d), new NpgsqlTypes.NpgsqlPoint(x: 0.24760621479920775d, y: 0.6243030142763842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807986523084946d, y: 0.6247391976074318d)),
    NullableValue = null,
},
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.445673778706802d, y: 0.7380375899119911d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639133092551891d, y: 0.7414042387979284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329660250764064d, y: 0.3825194701303396d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15847095209986883d, y: 0.9582022157185057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421775510027709d, y: 0.01468373441276516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1782760180557743d, y: 0.13994814342296558d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8004258280938187d, y: 0.08623594945384294d), new NpgsqlTypes.NpgsqlPoint(x: 0.17843858549517366d, y: 0.5146433069357552d), new NpgsqlTypes.NpgsqlPoint(x: 0.05229496350196883d, y: 0.6521050496079418d))));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23304218421825917d, y: 0.6216073465652532d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203115862523436d, y: 0.8631178009171337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4969377679511464d, y: 0.8529444128304015d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[29], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[29], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[29], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 86, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[29], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 34, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 35, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 30, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6994597213628143d, y: 0.38698058491140985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865164117065387d, y: 0.9079718297865741d), new NpgsqlTypes.NpgsqlPoint(x: 0.34307135527178645d, y: 0.16636716508941896d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08759494004410684d, y: 0.04020655570133502d), new NpgsqlTypes.NpgsqlPoint(x: 0.36524711965732415d, y: 0.6486575188506062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5473136352774283d, y: 0.7957346869943432d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8068819885209475d, y: 0.7040128022946375d), new NpgsqlTypes.NpgsqlPoint(x: 0.3472044538218817d, y: 0.1868964188971407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577678419025515d, y: 0.8928241492823118d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8635258563291018d, y: 0.43145991990334365d), new NpgsqlTypes.NpgsqlPoint(x: 0.35403591706178716d, y: 0.6955121801312344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7123100607232927d, y: 0.7636798829692961d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7806792049248475d, y: 0.7377794032402892d), new NpgsqlTypes.NpgsqlPoint(x: 0.33311988544704696d, y: 0.2150202553524596d), new NpgsqlTypes.NpgsqlPoint(x: 0.004600052497189977d, y: 0.6855524338981898d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09004367681147196d, y: 0.816443273395598d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617326987947195d, y: 0.866200046595327d), new NpgsqlTypes.NpgsqlPoint(x: 0.30862434240431635d, y: 0.24578446269570653d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4959369958047617d, y: 0.47452137839725317d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234150210861526d, y: 0.930672191557068d), new NpgsqlTypes.NpgsqlPoint(x: 0.24309831818165206d, y: 0.28581388150974474d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1470424227137188d, y: 0.9794855950388818d), new NpgsqlTypes.NpgsqlPoint(x: 0.21716727291229998d, y: 0.8672797739766218d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764167182608805d, y: 0.13741514186280257d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2960734722625845d, y: 0.9028679240641756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553379022338227d, y: 0.5486211015324282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237987227576245d, y: 0.9764295529761507d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.445673778706802d, y: 0.7380375899119911d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639133092551891d, y: 0.7414042387979284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329660250764064d, y: 0.3825194701303396d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3457364530174434d, y: 0.5036426195744627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9003043334379796d, y: 0.7045324633113953d), new NpgsqlTypes.NpgsqlPoint(x: 0.807921246031466d, y: 0.24369460558244194d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9662586168240461d, y: 0.68805205418046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758180155665775d, y: 0.17106703843149806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380798538824022d, y: 0.03744603798576762d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29512382545154836d, y: 0.8772213921611257d), new NpgsqlTypes.NpgsqlPoint(x: 0.0311035438208207d, y: 0.8015801617761809d), new NpgsqlTypes.NpgsqlPoint(x: 0.679454864007424d, y: 0.09954449703246493d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9782671839663142d, y: 0.6629951725526568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554133706873014d, y: 0.7319825384901864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9088379732643923d, y: 0.38503016029310255d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15847095209986883d, y: 0.9582022157185057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421775510027709d, y: 0.01468373441276516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1782760180557743d, y: 0.13994814342296558d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016448309185597143d, y: 0.2895507421933923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3811218880708709d, y: 0.0055091781564570175d), new NpgsqlTypes.NpgsqlPoint(x: 0.10705758446865055d, y: 0.4170855631904187d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7037045311563264d, y: 0.33646744285580577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016787252749428d, y: 0.9986576029990066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631690266279251d, y: 0.17959759249922347d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34041287530766273d, y: 0.887791337087188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407185872342093d, y: 0.30148003543222357d), new NpgsqlTypes.NpgsqlPoint(x: 0.573036413386585d, y: 0.46462421133405685d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8004258280938187d, y: 0.08623594945384294d), new NpgsqlTypes.NpgsqlPoint(x: 0.17843858549517366d, y: 0.5146433069357552d), new NpgsqlTypes.NpgsqlPoint(x: 0.05229496350196883d, y: 0.6521050496079418d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9337477180355239d, y: 0.31003218309292535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443736217033988d, y: 0.07841783352690324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720741678535205d, y: 0.5342722051714408d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22052715124335076d, y: 0.4604551809283848d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835263069198469d, y: 0.40230557852023996d), new NpgsqlTypes.NpgsqlPoint(x: 0.01277969801361245d, y: 0.4374999880713437d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7348540998211849d, y: 0.5759491856704421d), new NpgsqlTypes.NpgsqlPoint(x: 0.14737740829741874d, y: 0.2942230881120801d), new NpgsqlTypes.NpgsqlPoint(x: 0.03193007516367774d, y: 0.778576746632165d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23304218421825917d, y: 0.6216073465652532d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203115862523436d, y: 0.8631178009171337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4969377679511464d, y: 0.8529444128304015d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7166028959287231d, y: 0.7694228138865113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729703774538338d, y: 0.49931398340134614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2978277287250106d, y: 0.5824153311072925d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7058179072576098d, y: 0.7363223186482359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772033497448275d, y: 0.1634572508339972d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571703075695094d, y: 0.8714904805320057d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14712994946430902d, y: 0.00025839802689797686d), new NpgsqlTypes.NpgsqlPoint(x: 0.08788391209998436d, y: 0.7432259440156954d), new NpgsqlTypes.NpgsqlPoint(x: 0.41976532532402344d, y: 0.7234418482085343d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8049431512042892d, y: 0.2446847488414522d), new NpgsqlTypes.NpgsqlPoint(x: 0.16207960093259d, y: 0.41298778890441756d), new NpgsqlTypes.NpgsqlPoint(x: 0.960903550026009d, y: 0.10276614926871863d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6650386277049868d, y: 0.6770605318433431d), new NpgsqlTypes.NpgsqlPoint(x: 0.355953333393919d, y: 0.34615055723677257d), new NpgsqlTypes.NpgsqlPoint(x: 0.329479154018232d, y: 0.9334466286757752d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16727940418906395d, y: 0.8664187586056731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607508770109752d, y: 0.011097086255205113d), new NpgsqlTypes.NpgsqlPoint(x: 0.26751541508741494d, y: 0.8964352458782667d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19385165827273076d, y: 0.9218932065449517d), new NpgsqlTypes.NpgsqlPoint(x: 0.547371632066838d, y: 0.13927950370254516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9909754407343754d, y: 0.5568136549709032d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3787020363015018d, y: 0.6102310763556121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803334746294918d, y: 0.3020306578889451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5326586187216069d, y: 0.7363647458909939d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6097565390677833d, y: 0.5465897200456197d), new NpgsqlTypes.NpgsqlPoint(x: 0.67403895425476d, y: 0.3773147913255521d), new NpgsqlTypes.NpgsqlPoint(x: 0.07379237530813554d, y: 0.18040359075876788d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4856762632093713d, y: 0.10994970463384246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7135368423281078d, y: 0.6893708919380646d), new NpgsqlTypes.NpgsqlPoint(x: 0.22635057611768739d, y: 0.16508167731961176d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07425146365064939d, y: 0.7383416856742248d), new NpgsqlTypes.NpgsqlPoint(x: 0.57955334657248d, y: 0.9269536350725905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349288188139443d, y: 0.059608501859703344d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3448074321778509d, y: 0.11989075602419019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327123038613234d, y: 0.28376904512294765d), new NpgsqlTypes.NpgsqlPoint(x: 0.19544952855632203d, y: 0.6381105218951181d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7148826313627334d, y: 0.3592539683211816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227694091824184d, y: 0.21622966174052605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8231495847714422d, y: 0.044440342986838965d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49040337548724844d, y: 0.05830086834858461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433026607559251d, y: 0.6311303137609958d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412383204046044d, y: 0.5015362135420998d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6146222030279879d, y: 0.5496828780861417d), new NpgsqlTypes.NpgsqlPoint(x: 0.06086031337979525d, y: 0.09849261534831621d), new NpgsqlTypes.NpgsqlPoint(x: 0.28801528244674646d, y: 0.935753243257506d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46394596376948827d, y: 0.26601365690120093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267985323302373d, y: 0.6984375792499777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9247298874913913d, y: 0.1519898369038839d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4243855198465665d, y: 0.21071759281294977d), new NpgsqlTypes.NpgsqlPoint(x: 0.513804255618444d, y: 0.5380354528782211d), new NpgsqlTypes.NpgsqlPoint(x: 0.23480046999716786d, y: 0.5908125918050428d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9844117929029204d, y: 0.49787782217211274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447849983382464d, y: 0.6810149861351167d), new NpgsqlTypes.NpgsqlPoint(x: 0.10247535983360456d, y: 0.6741914386159873d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05025323595855802d, y: 0.949759349446369d), new NpgsqlTypes.NpgsqlPoint(x: 0.06040541272960209d, y: 0.41097631954088176d), new NpgsqlTypes.NpgsqlPoint(x: 0.515188339681485d, y: 0.628593227969109d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5272185715667738d, y: 0.8538587268713492d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049935295165235d, y: 0.8063080092971211d), new NpgsqlTypes.NpgsqlPoint(x: 0.42047680388033104d, y: 0.07546018347627825d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6370144411213335d, y: 0.501307955771181d), new NpgsqlTypes.NpgsqlPoint(x: 0.435015993215745d, y: 0.5823606928476632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861501324885253d, y: 0.03664075774212827d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.685345849797955d, y: 0.4369267920116905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562977224157631d, y: 0.7435551888930503d), new NpgsqlTypes.NpgsqlPoint(x: 0.4840473681581291d, y: 0.23619106722740713d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7870851069512919d, y: 0.6419417816111056d), new NpgsqlTypes.NpgsqlPoint(x: 0.723501475318583d, y: 0.6366253525620327d), new NpgsqlTypes.NpgsqlPoint(x: 0.47393191855856154d, y: 0.4319172143157489d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9902296444270436d, y: 0.8018999304077348d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405377731389172d, y: 0.5577080455298787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194507501116947d, y: 0.4870354578334729d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8385612550457008d, y: 0.09472204708541487d), new NpgsqlTypes.NpgsqlPoint(x: 0.0643821761428105d, y: 0.0832398688563436d), new NpgsqlTypes.NpgsqlPoint(x: 0.30125080965584494d, y: 0.24499167663156507d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22316330962219288d, y: 0.37828674023123d), new NpgsqlTypes.NpgsqlPoint(x: 0.33214939019078304d, y: 0.8763354715757938d), new NpgsqlTypes.NpgsqlPoint(x: 0.2567335015433371d, y: 0.6242772357472985d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4831183703327314d, y: 0.03983293827722678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086674825318145d, y: 0.6387859422188789d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688624549358851d, y: 0.8913269743386045d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18394132139295105d, y: 0.9836552981031457d), new NpgsqlTypes.NpgsqlPoint(x: 0.22718512563502102d, y: 0.09750269544457324d), new NpgsqlTypes.NpgsqlPoint(x: 0.0432003135586142d, y: 0.1368084113289577d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41472247512524574d, y: 0.9259160940612853d), new NpgsqlTypes.NpgsqlPoint(x: 0.47745836114058116d, y: 0.83149299123539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354907251939571d, y: 0.9643995274952036d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8661591048231045d, y: 0.31122208395010154d), new NpgsqlTypes.NpgsqlPoint(x: 0.14636756729604639d, y: 0.12059718326542723d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288409193776986d, y: 0.17055117822558108d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09810390424333304d, y: 0.5477901116836899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967229213758257d, y: 0.07397313044850606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296652283284135d, y: 0.40676126181985917d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04909797650069592d, y: 0.02087364266486258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883942853637045d, y: 0.9604424267330656d), new NpgsqlTypes.NpgsqlPoint(x: 0.786912155976302d, y: 0.6700123632639863d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7627369536540612d, y: 0.24082932721475425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621535884455766d, y: 0.785863045194604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841194134473396d, y: 0.018829426521566828d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9512654765557257d, y: 0.3944531995056111d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026454189711016d, y: 0.8459452947924915d), new NpgsqlTypes.NpgsqlPoint(x: 0.3637273450441786d, y: 0.734925946036977d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7747910551001181d, y: 0.6718505785302129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753303682817457d, y: 0.03236935150981468d), new NpgsqlTypes.NpgsqlPoint(x: 0.01719516777690544d, y: 0.5148398994370013d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3690962766860171d, y: 0.22557772024916278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441507099661885d, y: 0.5516824936996059d), new NpgsqlTypes.NpgsqlPoint(x: 0.725960398812282d, y: 0.8810327501276269d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9755120008472092d, y: 0.7288658455784053d), new NpgsqlTypes.NpgsqlPoint(x: 0.18570865662748703d, y: 0.439300800229811d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736665560994089d, y: 0.3702938166318359d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7423836940540762d, y: 0.6932498580622906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4877397730026085d, y: 0.1419935502830314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575941044577769d, y: 0.5647703904787894d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7105049059954825d, y: 0.02841650819697128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412943672948901d, y: 0.7609343339924073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747476046625995d, y: 0.7359927423680624d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52030564300286d, y: 0.5887703672274013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008441275964639d, y: 0.9628943228597739d), new NpgsqlTypes.NpgsqlPoint(x: 0.4350241796788358d, y: 0.2700264490704273d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7821545970129281d, y: 0.581793712345569d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822920795638284d, y: 0.5328458280569466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493126781040081d, y: 0.2502822436406057d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5720401170557087d, y: 0.49803904247664366d), new NpgsqlTypes.NpgsqlPoint(x: 0.43417012958522305d, y: 0.9461755104974919d), new NpgsqlTypes.NpgsqlPoint(x: 0.530342731623177d, y: 0.6486348113576921d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9878998130770643d, y: 0.8641588707444505d), new NpgsqlTypes.NpgsqlPoint(x: 0.31367224066098d, y: 0.4746046754755754d), new NpgsqlTypes.NpgsqlPoint(x: 0.35884181665756365d, y: 0.4029895560597542d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6094421715140969d, y: 0.18551671343671916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166210275131939d, y: 0.6518381979748041d), new NpgsqlTypes.NpgsqlPoint(x: 0.20090038629905738d, y: 0.07007944623177864d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6070600521879637d, y: 0.17388739885896554d), new NpgsqlTypes.NpgsqlPoint(x: 0.40122057116311005d, y: 0.15063710009198839d), new NpgsqlTypes.NpgsqlPoint(x: 0.40356989679470223d, y: 0.4734396758277407d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9587128651768321d, y: 0.5915748867793803d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059886657725436d, y: 0.6812461019105799d), new NpgsqlTypes.NpgsqlPoint(x: 0.19277612755272044d, y: 0.692699017389119d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6513052559634303d, y: 0.023185606927691782d), new NpgsqlTypes.NpgsqlPoint(x: 0.24760621479920775d, y: 0.6243030142763842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807986523084946d, y: 0.6247391976074318d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6994597213628143d, y: 0.38698058491140985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865164117065387d, y: 0.9079718297865741d), new NpgsqlTypes.NpgsqlPoint(x: 0.34307135527178645d, y: 0.16636716508941896d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08759494004410684d, y: 0.04020655570133502d), new NpgsqlTypes.NpgsqlPoint(x: 0.36524711965732415d, y: 0.6486575188506062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5473136352774283d, y: 0.7957346869943432d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8068819885209475d, y: 0.7040128022946375d), new NpgsqlTypes.NpgsqlPoint(x: 0.3472044538218817d, y: 0.1868964188971407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577678419025515d, y: 0.8928241492823118d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8635258563291018d, y: 0.43145991990334365d), new NpgsqlTypes.NpgsqlPoint(x: 0.35403591706178716d, y: 0.6955121801312344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7123100607232927d, y: 0.7636798829692961d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7806792049248475d, y: 0.7377794032402892d), new NpgsqlTypes.NpgsqlPoint(x: 0.33311988544704696d, y: 0.2150202553524596d), new NpgsqlTypes.NpgsqlPoint(x: 0.004600052497189977d, y: 0.6855524338981898d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09004367681147196d, y: 0.816443273395598d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617326987947195d, y: 0.866200046595327d), new NpgsqlTypes.NpgsqlPoint(x: 0.30862434240431635d, y: 0.24578446269570653d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4959369958047617d, y: 0.47452137839725317d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234150210861526d, y: 0.930672191557068d), new NpgsqlTypes.NpgsqlPoint(x: 0.24309831818165206d, y: 0.28581388150974474d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1470424227137188d, y: 0.9794855950388818d), new NpgsqlTypes.NpgsqlPoint(x: 0.21716727291229998d, y: 0.8672797739766218d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764167182608805d, y: 0.13741514186280257d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2960734722625845d, y: 0.9028679240641756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553379022338227d, y: 0.5486211015324282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237987227576245d, y: 0.9764295529761507d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.445673778706802d, y: 0.7380375899119911d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639133092551891d, y: 0.7414042387979284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329660250764064d, y: 0.3825194701303396d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3457364530174434d, y: 0.5036426195744627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9003043334379796d, y: 0.7045324633113953d), new NpgsqlTypes.NpgsqlPoint(x: 0.807921246031466d, y: 0.24369460558244194d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9662586168240461d, y: 0.68805205418046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758180155665775d, y: 0.17106703843149806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380798538824022d, y: 0.03744603798576762d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29512382545154836d, y: 0.8772213921611257d), new NpgsqlTypes.NpgsqlPoint(x: 0.0311035438208207d, y: 0.8015801617761809d), new NpgsqlTypes.NpgsqlPoint(x: 0.679454864007424d, y: 0.09954449703246493d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9782671839663142d, y: 0.6629951725526568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554133706873014d, y: 0.7319825384901864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9088379732643923d, y: 0.38503016029310255d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15847095209986883d, y: 0.9582022157185057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421775510027709d, y: 0.01468373441276516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1782760180557743d, y: 0.13994814342296558d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016448309185597143d, y: 0.2895507421933923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3811218880708709d, y: 0.0055091781564570175d), new NpgsqlTypes.NpgsqlPoint(x: 0.10705758446865055d, y: 0.4170855631904187d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7037045311563264d, y: 0.33646744285580577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016787252749428d, y: 0.9986576029990066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631690266279251d, y: 0.17959759249922347d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34041287530766273d, y: 0.887791337087188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407185872342093d, y: 0.30148003543222357d), new NpgsqlTypes.NpgsqlPoint(x: 0.573036413386585d, y: 0.46462421133405685d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8004258280938187d, y: 0.08623594945384294d), new NpgsqlTypes.NpgsqlPoint(x: 0.17843858549517366d, y: 0.5146433069357552d), new NpgsqlTypes.NpgsqlPoint(x: 0.05229496350196883d, y: 0.6521050496079418d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9337477180355239d, y: 0.31003218309292535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443736217033988d, y: 0.07841783352690324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720741678535205d, y: 0.5342722051714408d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22052715124335076d, y: 0.4604551809283848d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835263069198469d, y: 0.40230557852023996d), new NpgsqlTypes.NpgsqlPoint(x: 0.01277969801361245d, y: 0.4374999880713437d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7348540998211849d, y: 0.5759491856704421d), new NpgsqlTypes.NpgsqlPoint(x: 0.14737740829741874d, y: 0.2942230881120801d), new NpgsqlTypes.NpgsqlPoint(x: 0.03193007516367774d, y: 0.778576746632165d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23304218421825917d, y: 0.6216073465652532d), new NpgsqlTypes.NpgsqlPoint(x: 0.46203115862523436d, y: 0.8631178009171337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4969377679511464d, y: 0.8529444128304015d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7166028959287231d, y: 0.7694228138865113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729703774538338d, y: 0.49931398340134614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2978277287250106d, y: 0.5824153311072925d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7058179072576098d, y: 0.7363223186482359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772033497448275d, y: 0.1634572508339972d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571703075695094d, y: 0.8714904805320057d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14712994946430902d, y: 0.00025839802689797686d), new NpgsqlTypes.NpgsqlPoint(x: 0.08788391209998436d, y: 0.7432259440156954d), new NpgsqlTypes.NpgsqlPoint(x: 0.41976532532402344d, y: 0.7234418482085343d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8049431512042892d, y: 0.2446847488414522d), new NpgsqlTypes.NpgsqlPoint(x: 0.16207960093259d, y: 0.41298778890441756d), new NpgsqlTypes.NpgsqlPoint(x: 0.960903550026009d, y: 0.10276614926871863d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6650386277049868d, y: 0.6770605318433431d), new NpgsqlTypes.NpgsqlPoint(x: 0.355953333393919d, y: 0.34615055723677257d), new NpgsqlTypes.NpgsqlPoint(x: 0.329479154018232d, y: 0.9334466286757752d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16727940418906395d, y: 0.8664187586056731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607508770109752d, y: 0.011097086255205113d), new NpgsqlTypes.NpgsqlPoint(x: 0.26751541508741494d, y: 0.8964352458782667d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19385165827273076d, y: 0.9218932065449517d), new NpgsqlTypes.NpgsqlPoint(x: 0.547371632066838d, y: 0.13927950370254516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9909754407343754d, y: 0.5568136549709032d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3787020363015018d, y: 0.6102310763556121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803334746294918d, y: 0.3020306578889451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5326586187216069d, y: 0.7363647458909939d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6097565390677833d, y: 0.5465897200456197d), new NpgsqlTypes.NpgsqlPoint(x: 0.67403895425476d, y: 0.3773147913255521d), new NpgsqlTypes.NpgsqlPoint(x: 0.07379237530813554d, y: 0.18040359075876788d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4856762632093713d, y: 0.10994970463384246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7135368423281078d, y: 0.6893708919380646d), new NpgsqlTypes.NpgsqlPoint(x: 0.22635057611768739d, y: 0.16508167731961176d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07425146365064939d, y: 0.7383416856742248d), new NpgsqlTypes.NpgsqlPoint(x: 0.57955334657248d, y: 0.9269536350725905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349288188139443d, y: 0.059608501859703344d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3448074321778509d, y: 0.11989075602419019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327123038613234d, y: 0.28376904512294765d), new NpgsqlTypes.NpgsqlPoint(x: 0.19544952855632203d, y: 0.6381105218951181d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7148826313627334d, y: 0.3592539683211816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5227694091824184d, y: 0.21622966174052605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8231495847714422d, y: 0.044440342986838965d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49040337548724844d, y: 0.05830086834858461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433026607559251d, y: 0.6311303137609958d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412383204046044d, y: 0.5015362135420998d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6146222030279879d, y: 0.5496828780861417d), new NpgsqlTypes.NpgsqlPoint(x: 0.06086031337979525d, y: 0.09849261534831621d), new NpgsqlTypes.NpgsqlPoint(x: 0.28801528244674646d, y: 0.935753243257506d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46394596376948827d, y: 0.26601365690120093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6267985323302373d, y: 0.6984375792499777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9247298874913913d, y: 0.1519898369038839d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4243855198465665d, y: 0.21071759281294977d), new NpgsqlTypes.NpgsqlPoint(x: 0.513804255618444d, y: 0.5380354528782211d), new NpgsqlTypes.NpgsqlPoint(x: 0.23480046999716786d, y: 0.5908125918050428d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9844117929029204d, y: 0.49787782217211274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447849983382464d, y: 0.6810149861351167d), new NpgsqlTypes.NpgsqlPoint(x: 0.10247535983360456d, y: 0.6741914386159873d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05025323595855802d, y: 0.949759349446369d), new NpgsqlTypes.NpgsqlPoint(x: 0.06040541272960209d, y: 0.41097631954088176d), new NpgsqlTypes.NpgsqlPoint(x: 0.515188339681485d, y: 0.628593227969109d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5272185715667738d, y: 0.8538587268713492d), new NpgsqlTypes.NpgsqlPoint(x: 0.10049935295165235d, y: 0.8063080092971211d), new NpgsqlTypes.NpgsqlPoint(x: 0.42047680388033104d, y: 0.07546018347627825d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6370144411213335d, y: 0.501307955771181d), new NpgsqlTypes.NpgsqlPoint(x: 0.435015993215745d, y: 0.5823606928476632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861501324885253d, y: 0.03664075774212827d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.685345849797955d, y: 0.4369267920116905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562977224157631d, y: 0.7435551888930503d), new NpgsqlTypes.NpgsqlPoint(x: 0.4840473681581291d, y: 0.23619106722740713d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7870851069512919d, y: 0.6419417816111056d), new NpgsqlTypes.NpgsqlPoint(x: 0.723501475318583d, y: 0.6366253525620327d), new NpgsqlTypes.NpgsqlPoint(x: 0.47393191855856154d, y: 0.4319172143157489d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9902296444270436d, y: 0.8018999304077348d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405377731389172d, y: 0.5577080455298787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194507501116947d, y: 0.4870354578334729d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8385612550457008d, y: 0.09472204708541487d), new NpgsqlTypes.NpgsqlPoint(x: 0.0643821761428105d, y: 0.0832398688563436d), new NpgsqlTypes.NpgsqlPoint(x: 0.30125080965584494d, y: 0.24499167663156507d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22316330962219288d, y: 0.37828674023123d), new NpgsqlTypes.NpgsqlPoint(x: 0.33214939019078304d, y: 0.8763354715757938d), new NpgsqlTypes.NpgsqlPoint(x: 0.2567335015433371d, y: 0.6242772357472985d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4831183703327314d, y: 0.03983293827722678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086674825318145d, y: 0.6387859422188789d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688624549358851d, y: 0.8913269743386045d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18394132139295105d, y: 0.9836552981031457d), new NpgsqlTypes.NpgsqlPoint(x: 0.22718512563502102d, y: 0.09750269544457324d), new NpgsqlTypes.NpgsqlPoint(x: 0.0432003135586142d, y: 0.1368084113289577d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41472247512524574d, y: 0.9259160940612853d), new NpgsqlTypes.NpgsqlPoint(x: 0.47745836114058116d, y: 0.83149299123539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354907251939571d, y: 0.9643995274952036d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8661591048231045d, y: 0.31122208395010154d), new NpgsqlTypes.NpgsqlPoint(x: 0.14636756729604639d, y: 0.12059718326542723d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288409193776986d, y: 0.17055117822558108d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09810390424333304d, y: 0.5477901116836899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967229213758257d, y: 0.07397313044850606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296652283284135d, y: 0.40676126181985917d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04909797650069592d, y: 0.02087364266486258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883942853637045d, y: 0.9604424267330656d), new NpgsqlTypes.NpgsqlPoint(x: 0.786912155976302d, y: 0.6700123632639863d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7627369536540612d, y: 0.24082932721475425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621535884455766d, y: 0.785863045194604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841194134473396d, y: 0.018829426521566828d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9512654765557257d, y: 0.3944531995056111d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026454189711016d, y: 0.8459452947924915d), new NpgsqlTypes.NpgsqlPoint(x: 0.3637273450441786d, y: 0.734925946036977d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7747910551001181d, y: 0.6718505785302129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753303682817457d, y: 0.03236935150981468d), new NpgsqlTypes.NpgsqlPoint(x: 0.01719516777690544d, y: 0.5148398994370013d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3690962766860171d, y: 0.22557772024916278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441507099661885d, y: 0.5516824936996059d), new NpgsqlTypes.NpgsqlPoint(x: 0.725960398812282d, y: 0.8810327501276269d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9755120008472092d, y: 0.7288658455784053d), new NpgsqlTypes.NpgsqlPoint(x: 0.18570865662748703d, y: 0.439300800229811d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736665560994089d, y: 0.3702938166318359d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7423836940540762d, y: 0.6932498580622906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4877397730026085d, y: 0.1419935502830314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575941044577769d, y: 0.5647703904787894d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7105049059954825d, y: 0.02841650819697128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412943672948901d, y: 0.7609343339924073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747476046625995d, y: 0.7359927423680624d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52030564300286d, y: 0.5887703672274013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008441275964639d, y: 0.9628943228597739d), new NpgsqlTypes.NpgsqlPoint(x: 0.4350241796788358d, y: 0.2700264490704273d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7821545970129281d, y: 0.581793712345569d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822920795638284d, y: 0.5328458280569466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493126781040081d, y: 0.2502822436406057d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5720401170557087d, y: 0.49803904247664366d), new NpgsqlTypes.NpgsqlPoint(x: 0.43417012958522305d, y: 0.9461755104974919d), new NpgsqlTypes.NpgsqlPoint(x: 0.530342731623177d, y: 0.6486348113576921d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9878998130770643d, y: 0.8641588707444505d), new NpgsqlTypes.NpgsqlPoint(x: 0.31367224066098d, y: 0.4746046754755754d), new NpgsqlTypes.NpgsqlPoint(x: 0.35884181665756365d, y: 0.4029895560597542d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6094421715140969d, y: 0.18551671343671916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166210275131939d, y: 0.6518381979748041d), new NpgsqlTypes.NpgsqlPoint(x: 0.20090038629905738d, y: 0.07007944623177864d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6070600521879637d, y: 0.17388739885896554d), new NpgsqlTypes.NpgsqlPoint(x: 0.40122057116311005d, y: 0.15063710009198839d), new NpgsqlTypes.NpgsqlPoint(x: 0.40356989679470223d, y: 0.4734396758277407d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9587128651768321d, y: 0.5915748867793803d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059886657725436d, y: 0.6812461019105799d), new NpgsqlTypes.NpgsqlPoint(x: 0.19277612755272044d, y: 0.692699017389119d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6513052559634303d, y: 0.023185606927691782d), new NpgsqlTypes.NpgsqlPoint(x: 0.24760621479920775d, y: 0.6243030142763842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807986523084946d, y: 0.6247391976074318d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}

