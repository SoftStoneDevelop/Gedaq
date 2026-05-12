

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
    internal partial interface IInt64MArrayMArrayD1
    {
    }
    
    internal partial class Int64MArrayMArrayD1 : IInt64MArrayMArrayD1
    {


#region TestData

        private readonly Int64MArrayD1E1M[] _testData = new Int64MArrayD1E1M[]
        {
            new Int64MArrayD1E1M
{
    Id = 3,
    Value = 
new System.Int64[4]
{
5451552519194175606L,
556577236522215744L,
1539137355870795834L,
4170922524761819622L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Int64[4]
{
7899752081507371378L,
710976831018308725L,
3186370026445122269L,
3585992435408012008L,
},
    NullableValue = 
new System.Int64[4]
{
6511850732672733371L,
5749470634010793901L,
3620785086870789964L,
5333212708504998289L,
},
},
    NullableValue = 
new System.Int64[4]
{
7576687903372862050L,
8854656059250414264L,
2090341166918447872L,
5865403665267677550L,
},
},
            new Int64MArrayD1E1M
{
    Id = 10,
    Value = 
new System.Int64[4]
{
7570558397556266125L,
7305221748622938923L,
4029581171261610980L,
5991018368119191896L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Int64[4]
{
7558503345599318883L,
517154089351725768L,
512355491562736711L,
5228237451986778264L,
},
    NullableValue = 
new System.Int64[3]
{
6787696287952045283L,
5491979420233754771L,
137566318300640104L,
},
},
    NullableValue = 
new System.Int64[3]
{
4270023812090952076L,
4133941344088262584L,
3553226900177770330L,
},
},
            new Int64MArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int64[3]
{
6666484356402685083L,
215955304777164818L,
784927816505051940L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Int64[4]
{
9027765786956326510L,
6210750894839677244L,
5152522364224222958L,
5775285259139531173L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2585368796464989011L,
975932324009926866L,
4778981532023431085L,
8335652650958934270L,
},
},
            new Int64MArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int64[4]
{
5255991336606727624L,
3168444954251699469L,
2821800454755325142L,
2023936283036732872L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Int64[3]
{
88570498911640534L,
803327480296235199L,
8482222104584254446L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 28,
    Value = 
new System.Int64[3]
{
1530734360125466810L,
4344013741597758787L,
6860007405930602036L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int64[3]
{
1853127994066894326L,
3150414762622366481L,
1281280660394388255L,
},
    NullableValue = 
new System.Int64[4]
{
7725531290060750637L,
4004374877017736110L,
5284063632705673166L,
96865629123200307L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 29,
    Value = 
new System.Int64[4]
{
716862664224298572L,
5270590679939993547L,
9045234794101215434L,
3177197485245237095L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Int64[4]
{
1864465809739876951L,
8294700725596484435L,
384222235977437571L,
5860753703583015459L,
},
    NullableValue = 
new System.Int64[4]
{
3125701171879252259L,
7970401870923020853L,
6364565797005737031L,
223179390414121339L,
},
},
    NullableValue = 
new System.Int64[3]
{
1244528016925198499L,
5902539670277225630L,
4133899293324624830L,
},
},
            new Int64MArrayD1E1M
{
    Id = 38,
    Value = 
new System.Int64[3]
{
3567405855263635876L,
8133352369233552990L,
6624195192874463486L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Int64[3]
{
4804415848399203609L,
5114392029013466963L,
7458258581598513780L,
},
    NullableValue = 
new System.Int64[4]
{
7837942086180076965L,
2421942925128893896L,
4334350804623334315L,
854740542997761664L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int64[4]
{
6258262187349286010L,
1462300846237997299L,
8382470672623019489L,
5742008790592764775L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Int64[3]
{
6026113129967211816L,
2094219520575103118L,
8258832583388461265L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2035417849695696061L,
1017562681525061093L,
3586594530203128150L,
},
},
            new Int64MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
1139204998565737260L,
3426869880524115426L,
2383553865625247510L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int64[3]
{
9008756332616837418L,
1607881148629829891L,
2363581081938978924L,
},
    NullableValue = 
new System.Int64[3]
{
9209838590969473516L,
1572857008197184186L,
37167223249952757L,
},
},
    NullableValue = 
new System.Int64[3]
{
3529325149108157671L,
2481695096214929728L,
4176876652782533999L,
},
},
            new Int64MArrayD1E1M
{
    Id = 55,
    Value = 
new System.Int64[4]
{
3990999793981023128L,
8885093200515852598L,
8697329964786227575L,
7196426562007761304L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Int64[4]
{
7691663557414423776L,
2598420754323996335L,
8262329053954199273L,
6622963706564739890L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8796930385946319387L,
8003709168560054244L,
6259140978435916449L,
8274952812095134356L,
},
},
            new Int64MArrayD1E1M
{
    Id = 62,
    Value = 
new System.Int64[3]
{
699656891965610328L,
4259067187850251062L,
55397265428842190L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Int64[3]
{
7491145667420493640L,
3710737537967929524L,
2324571530144546256L,
},
    NullableValue = 
new System.Int64[4]
{
9074226058225626857L,
4355292312309488949L,
4956619455178137866L,
1614535969877792556L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 68,
    Value = 
new System.Int64[4]
{
2731848657172486369L,
3537374113845214229L,
6220732003556251039L,
3172149912793333197L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Int64[4]
{
7895621615167762450L,
3302478939570708123L,
3782450589913358170L,
7411243434580312812L,
},
    NullableValue = 
new System.Int64[4]
{
2407092201110025180L,
1787782887048768992L,
611839085684414466L,
7602185427896295094L,
},
},
    NullableValue = 
new System.Int64[3]
{
2924693194512710801L,
7357685000238612538L,
4189241894530524439L,
},
},
            new Int64MArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int64[3]
{
3749890928237927513L,
7597024680748628931L,
8268886794812036487L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int64[3]
{
4945169960200057605L,
2588302826206770073L,
5383017127162436609L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1749044536808135400L,
8892026630548428508L,
2703492773455948537L,
},
},
            new Int64MArrayD1E1M
{
    Id = 78,
    Value = 
new System.Int64[3]
{
8972418908195254625L,
4832532886546821957L,
8934846529421979190L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
332506611713887617L,
766999632293410824L,
4048285391516387497L,
4027605488542814544L,
},
    NullableValue = 
new System.Int64[4]
{
3430420215353168560L,
2534679742196212400L,
6752874913946541990L,
9051409508530210786L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 87,
    Value = 
new System.Int64[3]
{
3555418184242597450L,
8012173123034539660L,
8385010043703224039L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int64[3]
{
1824314907078543907L,
8139009390767784257L,
334362211249647006L,
},
    NullableValue = 
new System.Int64[4]
{
4836002395315007438L,
3454983417006122884L,
3712504052690273014L,
2667406884378794669L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 91,
    Value = 
new System.Int64[4]
{
2613707914387682411L,
8183919663944729248L,
3125839782748709392L,
3932059765330105693L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Int64[3]
{
2546504830877014411L,
4884877493532560383L,
3838375814141763416L,
},
    NullableValue = 
new System.Int64[4]
{
7721082772494093519L,
2793518714138457917L,
1746258889045784711L,
7284473060979242321L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 92,
    Value = 
new System.Int64[4]
{
5590168923676591538L,
3479437016908225384L,
3347008324186666796L,
887331836474405361L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Int64[3]
{
8132349750697341404L,
1131154099475063228L,
3832137632060853403L,
},
    NullableValue = 
new System.Int64[3]
{
7719050599315735504L,
6197052882569695919L,
7941102431698892103L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 101,
    Value = 
new System.Int64[3]
{
4512663307321090232L,
579011570388071165L,
7699314425742010152L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Int64[4]
{
3720863605701839535L,
8335317187801706979L,
7178559680428112872L,
3533663669573615134L,
},
    NullableValue = 
new System.Int64[4]
{
2772825500054436858L,
5148273491645268204L,
121456344334183066L,
6020347900342577893L,
},
},
    NullableValue = 
new System.Int64[3]
{
8165896482696839181L,
481481097828255165L,
7970990213015579166L,
},
},
            new Int64MArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int64[4]
{
3289948377624835362L,
6336057907171386820L,
6132750717432588103L,
7021117761562971640L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Int64[3]
{
8393631044551843404L,
1071548674353238298L,
162288364344880768L,
},
    NullableValue = 
new System.Int64[4]
{
8353370134049977650L,
760568198081588407L,
531341967293377377L,
7073624195655342335L,
},
},
    NullableValue = 
new System.Int64[3]
{
4082504891372547229L,
9201125711657263627L,
8695757458304180199L,
},
},
            new Int64MArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int64[3]
{
7922640544934424568L,
4824569301941222092L,
7378033259931645635L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int64[4]
{
2892956138876636096L,
6298730217663530455L,
108744150387487732L,
7656377200972731944L,
},
    NullableValue = 
new System.Int64[4]
{
5002395499624939297L,
1733972552544972372L,
158305631066836451L,
2342913087878192355L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 112,
    Value = 
new System.Int64[4]
{
1742616866561864958L,
5642068216694228870L,
4742124469346377168L,
4037223992158015824L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Int64[4]
{
2156837672387987232L,
3961541436299868448L,
1431246119335736558L,
739121826938404885L,
},
    NullableValue = 
new System.Int64[3]
{
5164827941097623464L,
8940577485774374388L,
4378335070177429570L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int64[4]
{
8095751832353874591L,
7286843654061673920L,
5029895185662469148L,
6760563148087835276L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int64[4]
{
9007718487759831069L,
1813822758378754960L,
2509980790259973077L,
7396123015310599632L,
},
    NullableValue = 
new System.Int64[3]
{
4114592850233431609L,
1637483112150943363L,
8140514600346906495L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Int64[3]
{
8841981896031291311L,
832444462585827704L,
1059060264162457499L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Int64[3]
{
3440409655769144583L,
2731725956790208685L,
8553017786940527660L,
},
    NullableValue = 
new System.Int64[3]
{
9057742077795737965L,
5401418913621593634L,
6691288159229498780L,
},
},
    NullableValue = 
new System.Int64[3]
{
7276523920415148906L,
6230330364707430279L,
3895353097747959656L,
},
},
            new Int64MArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int64[3]
{
1996743065553547439L,
2574033938682250092L,
8432809421368839655L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.Int64[4]
{
8453177663218414208L,
5431823924083645453L,
8762333256563521481L,
9204009558280432501L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8131309315100857406L,
5732106611650124106L,
1396102710608659900L,
5400628580530171059L,
},
},
            new Int64MArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int64[3]
{
9188196194798623626L,
4861818286024224248L,
2914440281012526707L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 111,
    Value = 
new System.Int64[3]
{
6064084713613547267L,
6093036656834588778L,
2979760788723073033L,
},
    NullableValue = 
new System.Int64[4]
{
7216809284057789632L,
8358709010473962827L,
6990821685676209125L,
1656888398687229766L,
},
},
    NullableValue = 
new System.Int64[3]
{
7329070071389888632L,
5583335563332438609L,
4303382400680631038L,
},
},
            new Int64MArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int64[4]
{
765894775001075165L,
6073229972396373499L,
6429361061588309973L,
7368210845364020669L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Int64[4]
{
6418735308824084990L,
2675042745701242281L,
2016679175348426531L,
9054195246498269751L,
},
    NullableValue = 
new System.Int64[3]
{
6299265810888821252L,
8553694684277589634L,
2277114811201147041L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 139,
    Value = 
new System.Int64[4]
{
742938789042741901L,
1501681520987586998L,
6243759482144538147L,
2899637922945124880L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 121,
    Value = 
new System.Int64[3]
{
8311176675561408113L,
2135182356342423957L,
6695201165935911546L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
9064256788687574220L,
1605902487275555653L,
6794046935225398597L,
},
},
            new Int64MArrayD1E1M
{
    Id = 142,
    Value = 
new System.Int64[3]
{
7550395336783604434L,
2477722673314309579L,
7508601600603226800L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Int64[4]
{
2797218465781530509L,
4773750944663957418L,
1423890118969466058L,
95337858932198328L,
},
    NullableValue = 
new System.Int64[4]
{
5975368787992255388L,
371924816363758919L,
8586907157975063082L,
7627113040983765817L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 148,
    Value = 
new System.Int64[3]
{
6063932200817996874L,
6883199060949582222L,
3877972794899771834L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Int64[4]
{
6455922896205945646L,
539734912525849499L,
7797596759649201056L,
7142714055767504501L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8229661404717664669L,
1098103998596450046L,
7376624850780304544L,
},
},
            new Int64MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int64[4]
{
2962030179237424164L,
1696240338913090144L,
7153234204021769627L,
800905105643772176L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.Int64[4]
{
1462734569820000824L,
5058373256529011439L,
6903427787448795717L,
8330870434703144646L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 158,
    Value = 
new System.Int64[4]
{
2616126197029174751L,
6598920450923264593L,
5094712975017894680L,
65932334259982917L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Int64[3]
{
4715475609094332246L,
4132723012292496883L,
7523329398713881150L,
},
    NullableValue = 
new System.Int64[4]
{
8273203131774872311L,
1426056670298056645L,
3047041449029571456L,
6412081800038426846L,
},
},
    NullableValue = 
new System.Int64[4]
{
826116889717894302L,
9122302833060372856L,
3543679944914194706L,
4691834474009282803L,
},
},
            new Int64MArrayD1E1M
{
    Id = 167,
    Value = 
new System.Int64[4]
{
2889221340464343929L,
2511021929449578999L,
7478229957988227868L,
7173901683218343580L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 148,
    Value = 
new System.Int64[4]
{
2367497666153533345L,
5927669159120681793L,
2693183935758878509L,
7807448486270363882L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 176,
    Value = 
new System.Int64[3]
{
5672940091999459978L,
4180064306183810297L,
6285002105213027830L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Int64[4]
{
7458555266156604492L,
2369706426388882886L,
8806964844188293938L,
672907661150947619L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 179,
    Value = 
new System.Int64[4]
{
7302152628678221989L,
1116711213892995898L,
2900359280218201025L,
6375523054737919330L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 158,
    Value = 
new System.Int64[3]
{
7064268103388173405L,
2779233011951570480L,
6788664387689759869L,
},
    NullableValue = 
new System.Int64[4]
{
5303140723189754019L,
7314540322341745010L,
5195618275623555135L,
8212886182932466116L,
},
},
    NullableValue = 
new System.Int64[4]
{
2587393768485889089L,
8472966003210166646L,
3637512137513463514L,
7272841253237244550L,
},
},
            new Int64MArrayD1E1M
{
    Id = 184,
    Value = 
new System.Int64[3]
{
6688426676205559801L,
3867967546109714631L,
6298397245958148780L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.Int64[4]
{
8611089306387831976L,
8450889322029693235L,
8240387433539275533L,
9191044698842349802L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1893113616672321886L,
5215114604835448405L,
1887654103102523687L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int64)}, 
    {mi_id:Int32},
    {mi_value:Array(Int64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
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
                    await ((IInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IInt64MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.int64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
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
                    var models = await ((IInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

