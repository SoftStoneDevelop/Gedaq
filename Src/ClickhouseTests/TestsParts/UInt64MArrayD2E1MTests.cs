

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IUInt64MArrayMArrayD2
    {
    }
    
    internal partial class UInt64MArrayMArrayD2 : IUInt64MArrayMArrayD2
    {


#region TestData

        private readonly UInt64MArrayD2E1M[] _testData = new UInt64MArrayD2E1M[]
        {
            new UInt64MArrayD2E1M
{
    Id = 2,
    Value = 
new System.UInt64[,] { { 4572211731888756533L, 998215857486077314L, }, { 8774751833818686937L, 6668376057486029822L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 5,
    Value = 
new System.UInt64[,] { { 4131626140073962572L, 3354718721661422881L, }, { 1667431353724900241L, 6267112406067000519L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6705413638995201389L, 3220015979453372386L, }, { 9095063379633578273L, 814067212538772414L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 3,
    Value = 
new System.UInt64[,] { { 4129301297217277899L, 8394860650284874840L, }, { 7791257538381190240L, 2394884090010146223L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.UInt64[,] { { 473245189699342274L, 1443110498807980874L, }, { 1588621739561367584L, 1591272689529162326L, }, },
    NullableValue = 
new System.UInt64[,] { { 5048103083370855395L, 4320522386731047708L, }, { 5186324507316816858L, 4261193039317933528L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 7295752561858897181L, 5642816931205058901L, }, { 1607704455643658873L, 1348295178973740025L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 6,
    Value = 
new System.UInt64[,] { { 1233889587428739391L, 1554346493310162938L, }, { 4056854286775672114L, 2214339079909627973L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.UInt64[,] { { 3576038398010410683L, 2828635708677225027L, }, { 7720379940203473288L, 3461739028725689679L, }, },
    NullableValue = 
new System.UInt64[,] { { 3290958366392363516L, 1811959936560682190L, }, { 8666744421282235349L, 1803134403491563608L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 4770068961213249185L, 4387244454241462231L, }, { 7286326355873557221L, 7139879634876241440L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 7,
    Value = 
new System.UInt64[,] { { 922391811537266638L, 2838686852241609391L, }, { 6534604334942569690L, 3793834110766465007L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt64[,] { { 1583971280809234431L, 849017564971225636L, }, { 605526563746118489L, 4185975624683023723L, }, },
    NullableValue = 
new System.UInt64[,] { { 3873208245610035062L, 5042037872687874725L, }, { 1210874249845224000L, 3234045638044123694L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 1542006673394983481L, 1573823540893297103L, }, { 476952766429391219L, 5790735836274753653L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 11,
    Value = 
new System.UInt64[,] { { 715156664430635646L, 4497857504993402459L, }, { 4374907849486265392L, 6819999894200356553L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 26,
    Value = 
new System.UInt64[,] { { 3821216718676835006L, 4913008000003901307L, }, { 9054187934344418299L, 4453695992685159513L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 8818482608535667553L, 1352977080824469429L, }, { 7574868384196719684L, 5437727786198581545L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 19,
    Value = 
new System.UInt64[,] { { 1586728055415771400L, 1801660898382123368L, }, { 4061482571676423589L, 4036563057413654110L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.UInt64[,] { { 2338861733915356803L, 3508243701712332058L, }, { 7076955623238527394L, 6762066231033815784L, }, },
    NullableValue = 
new System.UInt64[,] { { 5679332482606916013L, 173055983972696931L, }, { 1525117289328879453L, 4274953546058130612L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 9206905064992640197L, 3679195158836458900L, }, { 6072288996003388913L, 6254308447586193336L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 20,
    Value = 
new System.UInt64[,] { { 3624103970704229112L, 8374187636951813115L, }, { 1171762021393945193L, 46835545235170151L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.UInt64[,] { { 2643895828847570890L, 7693650139240647935L, }, { 1063498360389967688L, 1832914481683694114L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 380983282578878020L, 7744002238119814839L, }, { 4387371646109446519L, 6252237104640364162L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 24,
    Value = 
new System.UInt64[,] { { 3263048465420387000L, 8178614433768498456L, }, { 544695727041602866L, 4962951867043445416L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.UInt64[,] { { 8387235346340165222L, 2194068085103054580L, }, { 160192899098138286L, 6062453172906129739L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 3423334327751197342L, 6356834128557175260L, }, { 212739394416512733L, 2626580679910670169L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 27,
    Value = 
new System.UInt64[,] { { 337585930888985896L, 784297927751596357L, }, { 6174526245455457509L, 4473732834114150280L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.UInt64[,] { { 8076707658847206736L, 6388136108257481233L, }, { 2702537983752382586L, 1136255769939428412L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 35,
    Value = 
new System.UInt64[,] { { 527745226395979844L, 3681043797275463971L, }, { 1248808559775417679L, 8548500961291447638L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt64[,] { { 7802484115531584935L, 5469586958438582428L, }, { 2267953313003883267L, 434232092923038320L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 7312115660425444891L, 1597743604800893264L, }, { 3599784338248758575L, 8241103347696475814L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 36,
    Value = 
new System.UInt64[,] { { 2595929188735952155L, 116897972841374595L, }, { 8468587687315499107L, 5025944702132713011L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 52,
    Value = 
new System.UInt64[,] { { 5793571183964028105L, 312676600463402520L, }, { 2334190625373363955L, 3168435873789340439L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 1360283372407201535L, 8761243598609119396L, }, { 4762245835924502467L, 7554349115608230793L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt64[,] { { 4837553615172130485L, 167037941731235138L, }, { 9161759177563805401L, 6655861439796797418L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.UInt64[,] { { 6833467035192803569L, 2477059325953870504L, }, { 7934912888967733043L, 8664909196484423834L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 8589032452390139425L, 979804526054447395L, }, { 7794426830505182431L, 1670452922888347981L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 44,
    Value = 
new System.UInt64[,] { { 7367846851415978878L, 6154150860195117485L, }, { 5761045088276610123L, 4385055297477204561L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.UInt64[,] { { 8203988430690995442L, 6302689541751833685L, }, { 7366172923426894155L, 814141071175355501L, }, },
    NullableValue = 
new System.UInt64[,] { { 2518819388809206617L, 368249840039686181L, }, { 8405055236764178848L, 7569033219690245258L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 48,
    Value = 
new System.UInt64[,] { { 3519476741319242029L, 8573194885455571244L, }, { 3478717033512892133L, 1879820290072139631L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 64,
    Value = 
new System.UInt64[,] { { 3460619984493503931L, 6584941073322815051L, }, { 1291303552405265608L, 8599736168988511992L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 183302064387415986L, 5928751803490494010L, }, { 6788632552948617055L, 6560223985460189235L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 52,
    Value = 
new System.UInt64[,] { { 1485965628151964588L, 6788718509161063099L, }, { 7211707689035408701L, 7808334487120029931L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.UInt64[,] { { 3476660331322004439L, 7841885939420735388L, }, { 9189627457724490113L, 2742346728387058162L, }, },
    NullableValue = 
new System.UInt64[,] { { 9072453881527138171L, 8936536228195653018L, }, { 3317360851545151591L, 6531685418011350539L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 60,
    Value = 
new System.UInt64[,] { { 1698544686839351873L, 8001984620730650993L, }, { 5346591167832771374L, 4612970652545841067L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 75,
    Value = 
new System.UInt64[,] { { 6328695601501485429L, 9010259791066839716L, }, { 7326106559190016088L, 4672384737480171904L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 295798360015114203L, 3794861272087458341L, }, { 8413649960951929191L, 7034378672722237475L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 61,
    Value = 
new System.UInt64[,] { { 375286600763853484L, 7784446376118772977L, }, { 5118808186585488056L, 6605255981844565743L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.UInt64[,] { { 5584286709847076417L, 3872285791512121842L, }, { 5974386510139594973L, 185421736220356432L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6945393254458259732L, 8877044512874111958L, }, { 3724404819253116164L, 4994131824379872712L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 65,
    Value = 
new System.UInt64[,] { { 4552900460961004672L, 3650862446043641774L, }, { 4084141262666253696L, 1569977540830076512L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 7045882119974709589L, 8292377377025797256L, }, { 6292116452394825144L, 837584857567963305L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt64[,] { { 5819827974948640064L, 1199502065448895385L, }, { 4901237914733177644L, 4323361188299295361L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.UInt64[,] { { 3734212007839481076L, 5886021880193241759L, }, { 8091131660008967640L, 4849633671556323990L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2653271722529336956L, 8646220395446640669L, }, { 8232307837815575407L, 8253081462539757655L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 74,
    Value = 
new System.UInt64[,] { { 6431791193815112469L, 5178784585502952561L, }, { 3642314778062825539L, 4591949299350732957L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.UInt64[,] { { 6722013403629530001L, 3842469051759180518L, }, { 2506783416015081949L, 4228546361713420582L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 80,
    Value = 
new System.UInt64[,] { { 8543874981442527315L, 457092556106946807L, }, { 3391620901340395726L, 442964592706826705L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.UInt64[,] { { 5381207268450252548L, 7297285904729594809L, }, { 7784461392199592326L, 8899359492454269910L, }, },
    NullableValue = 
new System.UInt64[,] { { 4868793770875283430L, 1913625564445662623L, }, { 456805014949281672L, 8868293078831555115L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 83,
    Value = 
new System.UInt64[,] { { 6957513296554718311L, 6069544210302335768L, }, { 9097494932558536164L, 864934426115525474L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.UInt64[,] { { 7917663365237937520L, 211696692339903255L, }, { 729490175917025747L, 4698219134686029839L, }, },
    NullableValue = 
new System.UInt64[,] { { 6931414846359440900L, 830730962665124931L, }, { 1407354631890061301L, 8979747992505898438L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 6175952121723113907L, 2436668428355771211L, }, { 7653129204390466874L, 8853692432129305562L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 9066453395216771518L, 8186658465200652232L, }, { 3971315373897912165L, 8368077577075810562L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.UInt64[,] { { 4077873402548831311L, 8072295163071482690L, }, { 7145489768909669596L, 5859107008509011335L, }, },
    NullableValue = 
new System.UInt64[,] { { 6309150517743255599L, 2204591543561805666L, }, { 8924293645591433065L, 1047755256084488415L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 93,
    Value = 
new System.UInt64[,] { { 4249504737963436329L, 8786987986687593071L, }, { 6069411398782315544L, 4451153786960448889L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.UInt64[,] { { 2731700207085437375L, 3672915248633199278L, }, { 8270946300433695166L, 9065854857987281500L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 100,
    Value = 
new System.UInt64[,] { { 5383410827951011236L, 2511273057715628619L, }, { 5369575457725479469L, 1155580031005313732L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.UInt64[,] { { 6130437643664810221L, 4200332963044179324L, }, { 1862318246177381638L, 8481880281652067515L, }, },
    NullableValue = 
new System.UInt64[,] { { 6370997829404426345L, 1272326952487007757L, }, { 5743586301739660443L, 2431588968944310125L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 102,
    Value = 
new System.UInt64[,] { { 8027547730567553486L, 3747243357605867846L, }, { 3643869180009327543L, 7821368579387029964L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.UInt64[,] { { 922899967353795046L, 2935727480478155076L, }, { 7921070402998568907L, 6812269477958773527L, }, },
    NullableValue = 
new System.UInt64[,] { { 3675671495812628174L, 7743939057827814508L, }, { 7522346258161568504L, 6371898639443240520L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 8579497737848707286L, 2635718620978565556L, }, { 3249861094846416703L, 2821257370784544492L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 103,
    Value = 
new System.UInt64[,] { { 6663037348269327714L, 3862384329349233149L, }, { 3107109515406383540L, 4128797212110532635L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.UInt64[,] { { 4114334225020971442L, 2679017047170336950L, }, { 1838628573731817713L, 2223243916924572020L, }, },
    NullableValue = 
new System.UInt64[,] { { 7619276289117411812L, 328279515456251253L, }, { 5853170890011412174L, 2196532357081649934L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 106,
    Value = 
new System.UInt64[,] { { 4676638008462664432L, 818232427126974030L, }, { 677094553813235969L, 4714677820693172678L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.UInt64[,] { { 3406307345426163227L, 589088476521488582L, }, { 8422562790148420295L, 8708862973857988694L, }, },
    NullableValue = 
new System.UInt64[,] { { 7842619542158854352L, 1538586337155150861L, }, { 8963395029242532930L, 7661034389361298746L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 111,
    Value = 
new System.UInt64[,] { { 5754877422040364268L, 3674860733287742585L, }, { 1635469559056086042L, 2134439622424409885L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.UInt64[,] { { 6341451748244313647L, 2767129465210928680L, }, { 4951369803817941166L, 3461925888812306886L, }, },
    NullableValue = 
new System.UInt64[,] { { 331588208242442381L, 3615755636041025006L, }, { 4042505093317835997L, 1938633985040826194L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 116,
    Value = 
new System.UInt64[,] { { 6720635713994831739L, 8163907453277959978L, }, { 9000317026289578039L, 694186341043897539L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.UInt64[,] { { 8698625760922990207L, 5020679131123361265L, }, { 1753080576055167733L, 5631718971510626987L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 120,
    Value = 
new System.UInt64[,] { { 3521457998252661430L, 7662553871783992255L, }, { 5902708980410668738L, 7070767889470222940L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.UInt64[,] { { 5692074393794280703L, 6069040778379524611L, }, { 272234774146474831L, 7677275240626700262L, }, },
    NullableValue = 
new System.UInt64[,] { { 9152928355200524912L, 1838306776246396176L, }, { 4941160822771730546L, 4150042476180890766L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 129,
    Value = 
new System.UInt64[,] { { 2061789140305198381L, 7096888042830081957L, }, { 229500511355895531L, 6382686369818156372L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 164,
    Value = 
new System.UInt64[,] { { 3065275743561880379L, 7418454129422342280L, }, { 7328733815164364363L, 2791566727338235526L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6191090690952379673L, 6009239699322418416L, }, { 4934021943853029712L, 3167490255013919007L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 134,
    Value = 
new System.UInt64[,] { { 8122643977862397139L, 7038325750613981911L, }, { 4222491978869150236L, 6203968409833357950L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 170,
    Value = 
new System.UInt64[,] { { 4560791004338632160L, 9116397259672711292L, }, { 457226942482023025L, 4324993646668339988L, }, },
    NullableValue = 
new System.UInt64[,] { { 3179043874550586241L, 9197227216399867801L, }, { 5174105254260679440L, 8541089750731540575L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 5466686307242197738L, 7204003227657450509L, }, { 5146900647113527625L, 7353181203537714761L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 135,
    Value = 
new System.UInt64[,] { { 3573906229053358534L, 911282654322158597L, }, { 324315385162894224L, 1483127964047882787L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 173,
    Value = 
new System.UInt64[,] { { 69065760829324147L, 772984501724718961L, }, { 4969586637103287103L, 315395836321785300L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 140,
    Value = 
new System.UInt64[,] { { 3394707066198823494L, 3323823428647094164L, }, { 1502974297020714618L, 2039960954504607276L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 177,
    Value = 
new System.UInt64[,] { { 8049583042344953706L, 3355693650212969969L, }, { 515533186814468316L, 2948520490109311292L, }, },
    NullableValue = 
new System.UInt64[,] { { 1243151100612058099L, 4348041677903360890L, }, { 603256365359403031L, 5087669731982291970L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 5400030717742700333L, 2063696472529974909L, }, { 3090140605089615251L, 1882725146547342126L, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IUInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IUInt64MArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.uint64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IUInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IUInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

