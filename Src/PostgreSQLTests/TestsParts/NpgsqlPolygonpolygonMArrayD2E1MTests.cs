

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
    internal partial interface INpgsqlPolygonMArraypolygonMArrayD2
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMArrayD2 : INpgsqlPolygonMArraypolygonMArrayD2
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMArrayD2E1M[] _testData = new NpgsqlPolygonpolygonMArrayD2E1M[]
        {
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8193974003601275d, y: 0.4758204405666957d), new NpgsqlTypes.NpgsqlPoint(x: 0.21618547372814845d, y: 0.6900187060899737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321674464894101d, y: 0.8729379874838997d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5107718405504793d, y: 0.6837317495763168d), new NpgsqlTypes.NpgsqlPoint(x: 0.47886276260642147d, y: 0.2511259068764171d), new NpgsqlTypes.NpgsqlPoint(x: 0.289722515956476d, y: 0.6866563094700001d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.040772313933118864d, y: 0.3599306693024442d), new NpgsqlTypes.NpgsqlPoint(x: 0.06473137322144529d, y: 0.7291056669706055d), new NpgsqlTypes.NpgsqlPoint(x: 0.26190866974417326d, y: 0.056733833751655194d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.328658142069679d, y: 0.7427520843654787d), new NpgsqlTypes.NpgsqlPoint(x: 0.46535900697794985d, y: 0.3565168014738247d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387021127466764d, y: 0.8234384671060623d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0062710748177878806d, y: 0.8401481559726874d), new NpgsqlTypes.NpgsqlPoint(x: 0.4493405649795178d, y: 0.9714325554677703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526530246057946d, y: 0.44419458392513445d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4598517924576364d, y: 0.3399361728874595d), new NpgsqlTypes.NpgsqlPoint(x: 0.1348364068604634d, y: 0.9532050137200245d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643665475662198d, y: 0.7337807605144752d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09588211947539294d, y: 0.7097622491135751d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534824225748965d, y: 0.3135207202228142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637435227874793d, y: 0.37126876933413455d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06912141046491038d, y: 0.7104714167181467d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313125333130208d, y: 0.30809476128403035d), new NpgsqlTypes.NpgsqlPoint(x: 0.22608912939797277d, y: 0.6833135818342431d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.752544880571378d, y: 0.7703708377820858d), new NpgsqlTypes.NpgsqlPoint(x: 0.723601259187157d, y: 0.11497075960769976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5044683015820564d, y: 0.2567245237494201d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8718328410902054d, y: 0.9417087825681061d), new NpgsqlTypes.NpgsqlPoint(x: 0.022677811532723524d, y: 0.05418493906779709d), new NpgsqlTypes.NpgsqlPoint(x: 0.15402901927490786d, y: 0.4641051368071112d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34543027695659245d, y: 0.9711028807702226d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693525202554121d, y: 0.4743376184082152d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781939329371947d, y: 0.8408011877314905d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5093703628585091d, y: 0.9186329140200421d), new NpgsqlTypes.NpgsqlPoint(x: 0.49969482370781226d, y: 0.4234502710325244d), new NpgsqlTypes.NpgsqlPoint(x: 0.34611685802115977d, y: 0.011698938682627724d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26649506970372006d, y: 0.42703413712270866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3840115514389002d, y: 0.15216764136880678d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792956896721015d, y: 0.5788378204910911d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9704251711994338d, y: 0.25345787847310863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5709207103483414d, y: 0.18128653301970765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089081889746511d, y: 0.5597626336963252d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6471008783064193d, y: 0.33402713338272005d), new NpgsqlTypes.NpgsqlPoint(x: 0.3222786088803713d, y: 0.25798280661485795d), new NpgsqlTypes.NpgsqlPoint(x: 0.42134073630701063d, y: 0.7113263824203137d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6483694186566035d, y: 0.9774984283496375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8139001605241722d, y: 0.8779993687958878d), new NpgsqlTypes.NpgsqlPoint(x: 0.918985813047409d, y: 0.2990861032689184d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6627067139760826d, y: 0.3597296394177585d), new NpgsqlTypes.NpgsqlPoint(x: 0.11331959393734237d, y: 0.997935121180446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4253641245309415d, y: 0.8673140873929905d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7411832178878417d, y: 0.46171738289420483d), new NpgsqlTypes.NpgsqlPoint(x: 0.4630173805040092d, y: 0.8537980849758487d), new NpgsqlTypes.NpgsqlPoint(x: 0.6593849159755467d, y: 0.41588807153005414d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7443878424559544d, y: 0.1344332115236183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301125698908728d, y: 0.9873109672887488d), new NpgsqlTypes.NpgsqlPoint(x: 0.4053682145126909d, y: 0.28288819167574253d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22721132903644214d, y: 0.9481429200256724d), new NpgsqlTypes.NpgsqlPoint(x: 0.785620431732905d, y: 0.24287206145947549d), new NpgsqlTypes.NpgsqlPoint(x: 0.21040637886436997d, y: 0.20974556404465616d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1793093698249224d, y: 0.33430180982721425d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325559703938842d, y: 0.48911190631334256d), new NpgsqlTypes.NpgsqlPoint(x: 0.812088844146969d, y: 0.11372251517183074d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7164842150161531d, y: 0.5698201092477748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9850427349024322d, y: 0.006680387961187084d), new NpgsqlTypes.NpgsqlPoint(x: 0.35613795244852453d, y: 0.024161964474062048d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.959539469604826d, y: 0.14943713017775562d), new NpgsqlTypes.NpgsqlPoint(x: 0.21581778960691878d, y: 0.16776159349267927d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554821207203869d, y: 0.15821914507252222d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6301571997049401d, y: 0.6107269807254184d), new NpgsqlTypes.NpgsqlPoint(x: 0.044536436692189985d, y: 0.26458693270905476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783742755585616d, y: 0.6094124000175803d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8632311831383055d, y: 0.6770335138589691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072017351972646d, y: 0.1756404133092644d), new NpgsqlTypes.NpgsqlPoint(x: 0.21289863473741832d, y: 0.3371575741370417d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6682016862252342d, y: 0.03936271659045787d), new NpgsqlTypes.NpgsqlPoint(x: 0.409410068785245d, y: 0.4771820683862634d), new NpgsqlTypes.NpgsqlPoint(x: 0.18224905718969475d, y: 0.8514714974200625d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6485088629963305d, y: 0.6651129853871577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209152017772563d, y: 0.7263139413046413d), new NpgsqlTypes.NpgsqlPoint(x: 0.4851093662151702d, y: 0.22389066682030168d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8807603872328424d, y: 0.25365460580674615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151455957792389d, y: 0.6166633141368639d), new NpgsqlTypes.NpgsqlPoint(x: 0.29533392934379343d, y: 0.20805604826319868d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22545430981762216d, y: 0.7919865751293328d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685412777891325d, y: 0.3631806565885245d), new NpgsqlTypes.NpgsqlPoint(x: 0.44168207710904284d, y: 0.5947877675191344d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26270456851343615d, y: 0.4754075163646684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484957603062352d, y: 0.5395910453903495d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942476220216145d, y: 0.44116958951398433d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44650281727491725d, y: 0.5158868401065279d), new NpgsqlTypes.NpgsqlPoint(x: 0.4084809915598133d, y: 0.8433468942451524d), new NpgsqlTypes.NpgsqlPoint(x: 0.2507003719850931d, y: 0.9973982245792138d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19497018535253796d, y: 0.28236779100535725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783659511537302d, y: 0.13887311830789784d), new NpgsqlTypes.NpgsqlPoint(x: 0.006987689317563439d, y: 0.7413577834341237d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5501901753148716d, y: 0.2155003328652606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622684288429808d, y: 0.6575107904684809d), new NpgsqlTypes.NpgsqlPoint(x: 0.31085845127197687d, y: 0.30573892129557556d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4183203117730109d, y: 0.5318577437657688d), new NpgsqlTypes.NpgsqlPoint(x: 0.49520532224470526d, y: 0.3340631632438942d), new NpgsqlTypes.NpgsqlPoint(x: 0.2621799960336796d, y: 0.2909700778765125d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48441760818275414d, y: 0.06155807561795079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6308664730236399d, y: 0.2055655467452453d), new NpgsqlTypes.NpgsqlPoint(x: 0.32925506295306395d, y: 0.5406131489684829d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6383397774574271d, y: 0.9581752322563516d), new NpgsqlTypes.NpgsqlPoint(x: 0.399500823662838d, y: 0.25792607843313786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879995214099021d, y: 0.18300583466213416d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7774943653765289d, y: 0.5836572607832393d), new NpgsqlTypes.NpgsqlPoint(x: 0.023173995492867583d, y: 0.9844023238122338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668976738160398d, y: 0.2946016114151313d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9710322113968823d, y: 0.06376244836556799d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497870050480321d, y: 0.08407457275112817d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532581738985857d, y: 0.7354909590522071d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38803896723464637d, y: 0.8743753898340314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284498911520074d, y: 0.10435260618788744d), new NpgsqlTypes.NpgsqlPoint(x: 0.3644263145540596d, y: 0.38283823360392866d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7801402367884583d, y: 0.3319194847678075d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198473914509703d, y: 0.6826533270445498d), new NpgsqlTypes.NpgsqlPoint(x: 0.21187207937255714d, y: 0.8732965809275683d)), } },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.036722342817946396d, y: 0.895544758905825d), new NpgsqlTypes.NpgsqlPoint(x: 0.730181568388549d, y: 0.46509639973034134d), new NpgsqlTypes.NpgsqlPoint(x: 0.923963042784751d, y: 0.42433281768675724d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45662634152619486d, y: 0.9965973516109153d), new NpgsqlTypes.NpgsqlPoint(x: 0.6169810185477208d, y: 0.8535897352872999d), new NpgsqlTypes.NpgsqlPoint(x: 0.1479306435310903d, y: 0.48829749671040723d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9234479698640303d, y: 0.8323943715129949d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314165853636462d, y: 0.442685416194163d), new NpgsqlTypes.NpgsqlPoint(x: 0.15717378329871878d, y: 0.39277106121048144d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6393974146406569d, y: 0.3189110099925575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7823063528152765d, y: 0.09891777251127065d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854283109735303d, y: 0.0024393693012436657d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.508446933114272d, y: 0.5027830763327127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577504545501585d, y: 0.9846590842650593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7950255662452542d, y: 0.33945097008542047d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8014010686415048d, y: 0.9626963989608512d), new NpgsqlTypes.NpgsqlPoint(x: 0.20049686049175475d, y: 0.4163130408319041d), new NpgsqlTypes.NpgsqlPoint(x: 0.05860681145949931d, y: 0.9984524189123463d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8037136006087758d, y: 0.19951659960187773d), new NpgsqlTypes.NpgsqlPoint(x: 0.8090643051203219d, y: 0.12783319743219745d), new NpgsqlTypes.NpgsqlPoint(x: 0.23676149306211358d, y: 0.3329144821249356d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.429082590496353d, y: 0.6732264902849289d), new NpgsqlTypes.NpgsqlPoint(x: 0.45117812683054326d, y: 0.014268035580390803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140110483260431d, y: 0.05554991638511653d)), } },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9687846314627583d, y: 0.6893259785409633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803209733059274d, y: 0.028445087216753873d), new NpgsqlTypes.NpgsqlPoint(x: 0.057644069264893294d, y: 0.5319146931901325d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8339453631726667d, y: 0.31411064265433297d), new NpgsqlTypes.NpgsqlPoint(x: 0.27622461076549765d, y: 0.512269640164417d), new NpgsqlTypes.NpgsqlPoint(x: 0.540191993319085d, y: 0.0968605952484134d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5322490513328335d, y: 0.2641506365589781d), new NpgsqlTypes.NpgsqlPoint(x: 0.35910666216089904d, y: 0.821470372868774d), new NpgsqlTypes.NpgsqlPoint(x: 0.26436762803830904d, y: 0.5579324682431113d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4810293247602736d, y: 0.16929154412807268d), new NpgsqlTypes.NpgsqlPoint(x: 0.979995405735174d, y: 0.40008801913018266d), new NpgsqlTypes.NpgsqlPoint(x: 0.07657717799015784d, y: 0.6149267732722062d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11430354419828359d, y: 0.8011372897517015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494384096193026d, y: 0.16468780372305736d), new NpgsqlTypes.NpgsqlPoint(x: 0.2915909141381562d, y: 0.7486299506825758d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7778814482392958d, y: 0.9384987474884359d), new NpgsqlTypes.NpgsqlPoint(x: 0.49239672054895123d, y: 0.5746574139841334d), new NpgsqlTypes.NpgsqlPoint(x: 0.8634713220830674d, y: 0.4577511416178828d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23135078656562413d, y: 0.273664558959674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3410864025341849d, y: 0.07686334666252281d), new NpgsqlTypes.NpgsqlPoint(x: 0.9986869662207829d, y: 0.2883794108104556d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9247122035361603d, y: 0.2705226665487116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096534636835153d, y: 0.14283912525017217d), new NpgsqlTypes.NpgsqlPoint(x: 0.39904343238050843d, y: 0.9111550159112979d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4423975889652225d, y: 0.12588645000233023d), new NpgsqlTypes.NpgsqlPoint(x: 0.14500632477895392d, y: 0.6147042120906343d), new NpgsqlTypes.NpgsqlPoint(x: 0.955962265343083d, y: 0.14359620669070028d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07931794169611817d, y: 0.5059273360018028d), new NpgsqlTypes.NpgsqlPoint(x: 0.3827980744546726d, y: 0.18599962140643367d), new NpgsqlTypes.NpgsqlPoint(x: 0.35642649683605787d, y: 0.8756198523315494d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020440285267449898d, y: 0.5382434350984048d), new NpgsqlTypes.NpgsqlPoint(x: 0.23765422193072427d, y: 0.7072160507732786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9232131729636326d, y: 0.8588869116431805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.586411381873627d, y: 0.05609197612926531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174636864063306d, y: 0.14153536682450496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374944808920596d, y: 0.6950290959456802d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5836370922735113d, y: 0.8338722029801703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8318704260261223d, y: 0.6849767399503676d), new NpgsqlTypes.NpgsqlPoint(x: 0.2061901532651429d, y: 0.3176474380726768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9593576934550486d, y: 0.33749780978779054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5112600421304148d, y: 0.9363486006386077d), new NpgsqlTypes.NpgsqlPoint(x: 0.2103660371999273d, y: 0.7203598595312478d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6059079904212689d, y: 0.5111358660380912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313131783359688d, y: 0.9416984924461355d), new NpgsqlTypes.NpgsqlPoint(x: 0.1323238462194406d, y: 0.0856931351771657d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9285600504463486d, y: 0.8148298417202322d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357864776197308d, y: 0.06954578605739548d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936435317486076d, y: 0.27176976408820597d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8309658203676069d, y: 0.593112188291208d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476969788142466d, y: 0.46022535969562395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507535363348456d, y: 0.234817992651138d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5821218463065946d, y: 0.25412282126539587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5438308068170683d, y: 0.093302845301377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464738722486941d, y: 0.8620831974524844d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7110934919941092d, y: 0.05404813074179715d), new NpgsqlTypes.NpgsqlPoint(x: 0.696846825625959d, y: 0.9930112531682804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102910509617258d, y: 0.08459911526060115d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.53435119123371d, y: 0.562166715465984d), new NpgsqlTypes.NpgsqlPoint(x: 0.09677988527721526d, y: 0.25200837573559376d), new NpgsqlTypes.NpgsqlPoint(x: 0.36665078655791394d, y: 0.43329948095548065d)), } },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8074652271156271d, y: 0.96476573295995d), new NpgsqlTypes.NpgsqlPoint(x: 0.8320234035833395d, y: 0.22810817650223736d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243581242870581d, y: 0.28447909178018815d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3336043171147476d, y: 0.7067511287895993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6289525756237644d, y: 0.5475371395802888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581605497213845d, y: 0.3944410593230605d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028509528995890876d, y: 0.1039256573144679d), new NpgsqlTypes.NpgsqlPoint(x: 0.38079372997122063d, y: 0.755101334089427d), new NpgsqlTypes.NpgsqlPoint(x: 0.37899143200037d, y: 0.532228595333665d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5712916018877354d, y: 0.48812724008500963d), new NpgsqlTypes.NpgsqlPoint(x: 0.04634807445393274d, y: 0.3762874573833368d), new NpgsqlTypes.NpgsqlPoint(x: 0.555609506243977d, y: 0.9622854438109663d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03975611869640627d, y: 0.4275312858292297d), new NpgsqlTypes.NpgsqlPoint(x: 0.44339002820441265d, y: 0.7937388693974267d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991294545528294d, y: 0.7080270299355006d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9229657067681661d, y: 0.07442510833647575d), new NpgsqlTypes.NpgsqlPoint(x: 0.030271923062600403d, y: 0.6379922305561354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934402703301137d, y: 0.3535142698068633d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19438333946530018d, y: 0.5847405050077147d), new NpgsqlTypes.NpgsqlPoint(x: 0.699716783836842d, y: 0.03346623673854199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539593020169171d, y: 0.6421337609815623d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6379333244689318d, y: 0.7009538257865101d), new NpgsqlTypes.NpgsqlPoint(x: 0.29940095995952387d, y: 0.8774622203263249d), new NpgsqlTypes.NpgsqlPoint(x: 0.004336535247547624d, y: 0.9000344370775832d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7839453411555707d, y: 0.6365301727942595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728786098180022d, y: 0.4098253613840056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715907414219347d, y: 0.5679674229843039d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4556803793099694d, y: 0.5071931706869027d), new NpgsqlTypes.NpgsqlPoint(x: 0.452308735985676d, y: 0.30978661105593996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9193482155864223d, y: 0.6554044587554836d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3369729829348801d, y: 0.9552437830084582d), new NpgsqlTypes.NpgsqlPoint(x: 0.40141031227525314d, y: 0.6320880619580563d), new NpgsqlTypes.NpgsqlPoint(x: 0.15574693616743096d, y: 0.7702947489693757d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11550563134494463d, y: 0.7618105879673088d), new NpgsqlTypes.NpgsqlPoint(x: 0.834378657202775d, y: 0.5598318301457903d), new NpgsqlTypes.NpgsqlPoint(x: 0.14753810698492065d, y: 0.7147422044554723d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39876602613678935d, y: 0.1995067209597452d), new NpgsqlTypes.NpgsqlPoint(x: 0.755275462154316d, y: 0.6379001452312121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344358224454863d, y: 0.9465829972469818d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16351596937467217d, y: 0.3374999471085768d), new NpgsqlTypes.NpgsqlPoint(x: 0.5597869467495089d, y: 0.7591696297218861d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512014366287963d, y: 0.8864838793088102d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08545721010421148d, y: 0.8196123386930061d), new NpgsqlTypes.NpgsqlPoint(x: 0.4484915461058081d, y: 0.24729268509506197d), new NpgsqlTypes.NpgsqlPoint(x: 0.4702868814186366d, y: 0.3229517342842939d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09187967032397937d, y: 0.8488906400425189d), new NpgsqlTypes.NpgsqlPoint(x: 0.014784196444459718d, y: 0.13004956589054162d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322845051082916d, y: 0.23791916134663205d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9327733224672242d, y: 0.6029863670884015d), new NpgsqlTypes.NpgsqlPoint(x: 0.23032472575927476d, y: 0.7698021306755323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040213756581583d, y: 0.480413403236432d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9051243226688945d, y: 0.023008427069098558d), new NpgsqlTypes.NpgsqlPoint(x: 0.1399403140169857d, y: 0.08321613152723384d), new NpgsqlTypes.NpgsqlPoint(x: 0.2663044237644109d, y: 0.6028984953863187d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11585763238886149d, y: 0.7487137762969981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2258940997386929d, y: 0.05704787089583074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695812304780507d, y: 0.38817139156393876d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5699758202295488d, y: 0.7072339029385966d), new NpgsqlTypes.NpgsqlPoint(x: 0.37330777810041604d, y: 0.48717407941212143d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592466540636805d, y: 0.2664350974625689d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9095608930444029d, y: 0.2609497385584515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761914117819707d, y: 0.21057846370905287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474887763181659d, y: 0.5506489494158092d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0200101830041588d, y: 0.7211653076639163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865224399937564d, y: 0.7882771882349492d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292440488964502d, y: 0.21493024088238044d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5993815360567831d, y: 0.8018765066244001d), new NpgsqlTypes.NpgsqlPoint(x: 0.579707243976163d, y: 0.9998603443571835d), new NpgsqlTypes.NpgsqlPoint(x: 0.09353580493323033d, y: 0.28115958558360765d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3815073237772135d, y: 0.8915931821939402d), new NpgsqlTypes.NpgsqlPoint(x: 0.07926482817082325d, y: 0.15654811269560331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641219094505878d, y: 0.9016991663856385d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24510071977198689d, y: 0.7971444755361529d), new NpgsqlTypes.NpgsqlPoint(x: 0.13388871801111057d, y: 0.8615449548493556d), new NpgsqlTypes.NpgsqlPoint(x: 0.3295609128477833d, y: 0.23491008977648042d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1506930050234948d, y: 0.17516381249987234d), new NpgsqlTypes.NpgsqlPoint(x: 0.4522646387273892d, y: 0.06974383609216317d), new NpgsqlTypes.NpgsqlPoint(x: 0.34749594775097603d, y: 0.8281036447169308d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5433726325992481d, y: 0.9597047599260548d), new NpgsqlTypes.NpgsqlPoint(x: 0.0555669575029587d, y: 0.3160777388402817d), new NpgsqlTypes.NpgsqlPoint(x: 0.4267237922142306d, y: 0.33463103408975825d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7476461557494527d, y: 0.6470063981801248d), new NpgsqlTypes.NpgsqlPoint(x: 0.75034126260119d, y: 0.1374721535767337d), new NpgsqlTypes.NpgsqlPoint(x: 0.2886734970073528d, y: 0.2218661367182262d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4060139556647008d, y: 0.17488981986857122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869806613223434d, y: 0.28031090856267105d), new NpgsqlTypes.NpgsqlPoint(x: 0.1767469985901844d, y: 0.6612419938364027d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.747288417545484d, y: 0.9113818031145704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469252590897119d, y: 0.8105169325600546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605149957135975d, y: 0.03384428416407537d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9351911665524171d, y: 0.0496965687870321d), new NpgsqlTypes.NpgsqlPoint(x: 0.84197695021232d, y: 0.13365045189074154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225338846147171d, y: 0.0513574064179364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46195828415408635d, y: 0.36279540816134703d), new NpgsqlTypes.NpgsqlPoint(x: 0.16828076628215083d, y: 0.315609584248824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8421587091971189d, y: 0.6822867292461632d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35415067402906164d, y: 0.9460756912304085d), new NpgsqlTypes.NpgsqlPoint(x: 0.38069864246227203d, y: 0.7212077203411211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095450350374715d, y: 0.5042320668450935d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04088795958167313d, y: 0.5455412935710864d), new NpgsqlTypes.NpgsqlPoint(x: 0.2783987521752329d, y: 0.536586216142173d), new NpgsqlTypes.NpgsqlPoint(x: 0.595041135726577d, y: 0.26985899709856054d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8668479032886619d, y: 0.5621540591747789d), new NpgsqlTypes.NpgsqlPoint(x: 0.04854243072132702d, y: 0.30022026015507564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357501651684685d, y: 0.1544205010992925d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3009479676164367d, y: 0.4924546896882044d), new NpgsqlTypes.NpgsqlPoint(x: 0.07170484914543263d, y: 0.6215175845790516d), new NpgsqlTypes.NpgsqlPoint(x: 0.22633050466969973d, y: 0.41099649198183985d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8696757084591547d, y: 0.9427311287447501d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632818100839712d, y: 0.3333819963011082d), new NpgsqlTypes.NpgsqlPoint(x: 0.26897413239408785d, y: 0.9558265681967955d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29861105034225843d, y: 0.0936387205215522d), new NpgsqlTypes.NpgsqlPoint(x: 0.35312982420696837d, y: 0.8174304939181753d), new NpgsqlTypes.NpgsqlPoint(x: 0.8548827392004862d, y: 0.7951988228589089d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.465721146098249d, y: 0.6348627155403115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8744021762405036d, y: 0.9790214859797671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705715065495367d, y: 0.8873546609294906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2972968969128901d, y: 0.6504491308941929d), new NpgsqlTypes.NpgsqlPoint(x: 0.040209454066669204d, y: 0.9250544948921171d), new NpgsqlTypes.NpgsqlPoint(x: 0.8711792566152455d, y: 0.6816788356058252d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011370866311455563d, y: 0.8288122409081985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983248835902594d, y: 0.9236541785716639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667426727280175d, y: 0.10211809752780376d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5664364239731893d, y: 0.8903110811315201d), new NpgsqlTypes.NpgsqlPoint(x: 0.2434974751083595d, y: 0.812642507147888d), new NpgsqlTypes.NpgsqlPoint(x: 0.802427868349863d, y: 0.465341504759591d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7252880779922612d, y: 0.9814548080369837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6490300574718597d, y: 0.06490352778522979d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293912052986786d, y: 0.8944238722269893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9522866293323498d, y: 0.3151353631577699d), new NpgsqlTypes.NpgsqlPoint(x: 0.21086286529500253d, y: 0.4361548059797643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526723020557326d, y: 0.9366372166573677d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04839238391286327d, y: 0.26085619164146046d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867347867068799d, y: 0.04416325551523059d), new NpgsqlTypes.NpgsqlPoint(x: 0.3165156065841963d, y: 0.6730265230387023d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9999239040722898d, y: 0.8596074059085353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940270527634967d, y: 0.04324694188219591d), new NpgsqlTypes.NpgsqlPoint(x: 0.20040295415285359d, y: 0.7518114360990681d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.955042333894609d, y: 0.49802064517203026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348227142903891d, y: 0.5678214760493638d), new NpgsqlTypes.NpgsqlPoint(x: 0.928823816518734d, y: 0.06744426948582283d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3893140155720459d, y: 0.19831338065010973d), new NpgsqlTypes.NpgsqlPoint(x: 0.35535328215868833d, y: 0.2630462075017891d), new NpgsqlTypes.NpgsqlPoint(x: 0.951196604218425d, y: 0.16380989947249014d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014701265897135163d, y: 0.19011095572728753d), new NpgsqlTypes.NpgsqlPoint(x: 0.561028285489392d, y: 0.1414959657948185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598720902463077d, y: 0.5031897578622908d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19060703302514193d, y: 0.8252418095213894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3196042267733381d, y: 0.8922274768290215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684894361014296d, y: 0.931479741952426d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6450748576999368d, y: 0.3008725934947558d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605919306705503d, y: 0.011084189099358821d), new NpgsqlTypes.NpgsqlPoint(x: 0.013244759220580438d, y: 0.1814909928118168d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9797060309344154d, y: 0.8276870400327851d), new NpgsqlTypes.NpgsqlPoint(x: 0.581352504633037d, y: 0.8887831839069679d), new NpgsqlTypes.NpgsqlPoint(x: 0.870223382498933d, y: 0.011639098209338727d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5194256200832648d, y: 0.702403003609273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474822094001992d, y: 0.751578217953125d), new NpgsqlTypes.NpgsqlPoint(x: 0.28758691462497854d, y: 0.8873705700111543d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8203331938321876d, y: 0.8203883451109186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749258947754033d, y: 0.3658777496975407d), new NpgsqlTypes.NpgsqlPoint(x: 0.21215984458012427d, y: 0.3861504437518315d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07544672920735562d, y: 0.10619322427864442d), new NpgsqlTypes.NpgsqlPoint(x: 0.6269234552328318d, y: 0.1367281616348639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397997585994224d, y: 0.9653095164694367d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9687985727022344d, y: 0.3435961932034941d), new NpgsqlTypes.NpgsqlPoint(x: 0.02214443837514457d, y: 0.6865544351429551d), new NpgsqlTypes.NpgsqlPoint(x: 0.022801321823231913d, y: 0.7377312114141374d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6112425993745598d, y: 0.9981813698644195d), new NpgsqlTypes.NpgsqlPoint(x: 0.09620754395124631d, y: 0.2347708278403251d), new NpgsqlTypes.NpgsqlPoint(x: 5.3376916722247536E-05d, y: 0.1910285873308616d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9453054916099388d, y: 0.1784820717852832d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816507753700476d, y: 0.6286823711367295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7013467690080787d, y: 0.09102736070793493d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7024372275603544d, y: 0.8542096624610659d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926173477919059d, y: 0.7318546340021334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322687987005541d, y: 0.825005582297887d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.964558552511263d, y: 0.613052655442373d), new NpgsqlTypes.NpgsqlPoint(x: 0.37886500633490994d, y: 0.21090105629207423d), new NpgsqlTypes.NpgsqlPoint(x: 0.3575492237101674d, y: 0.7635608777012616d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9201552877682178d, y: 0.5312024649360637d), new NpgsqlTypes.NpgsqlPoint(x: 0.08681473299119324d, y: 0.4240811480580343d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468832963566598d, y: 0.4346427761522451d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7650132463691197d, y: 0.6921152683900501d), new NpgsqlTypes.NpgsqlPoint(x: 0.21838510263374855d, y: 0.16704826137057405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266795963358257d, y: 0.43598509243888217d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8042557189235489d, y: 0.3322266056261661d), new NpgsqlTypes.NpgsqlPoint(x: 0.01368223578878347d, y: 0.019730647081165675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806255033918448d, y: 0.000630870655396687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6734075490161303d, y: 0.09714063407130846d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128173301467088d, y: 0.028698997779405655d), new NpgsqlTypes.NpgsqlPoint(x: 0.08615329109118108d, y: 0.5350949358799559d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7753770097984459d, y: 0.14155274750407199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4892451669019102d, y: 0.08611267957643909d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251183417453147d, y: 0.32065989178841403d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15967785222861186d, y: 0.9767010693008245d), new NpgsqlTypes.NpgsqlPoint(x: 0.24981163272558626d, y: 0.6727044771583991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5660933476808002d, y: 0.1470270112993104d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13793077941926912d, y: 0.8978699414425535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7871448253705813d, y: 0.39110015066906d), new NpgsqlTypes.NpgsqlPoint(x: 0.1968618242421385d, y: 0.9014621195890932d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07731543735350255d, y: 0.37781604808682956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5620937937929548d, y: 0.6003188265370006d), new NpgsqlTypes.NpgsqlPoint(x: 0.41330777396558815d, y: 0.24151095995874383d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8957030371189107d, y: 0.5238134240599464d), new NpgsqlTypes.NpgsqlPoint(x: 0.49174180930388434d, y: 0.19020736357268353d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290456716843377d, y: 0.6234777374245332d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013398243654935138d, y: 0.3895357933611201d), new NpgsqlTypes.NpgsqlPoint(x: 0.4357581089606616d, y: 0.8639647053479914d), new NpgsqlTypes.NpgsqlPoint(x: 0.36355905362414975d, y: 0.36493487632988386d)), } },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4778884903371786d, y: 0.41017542299152454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4717737227848813d, y: 0.8242034474741259d), new NpgsqlTypes.NpgsqlPoint(x: 0.011990775131690223d, y: 0.06048897511337059d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4101445844261893d, y: 0.4918676054493333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7040435233475361d, y: 0.6437018402345001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4569620584544417d, y: 0.3266688455848358d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6448480908243129d, y: 0.855241152013755d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565426880360219d, y: 0.9192974351271133d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852332288366825d, y: 0.42666427249263894d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21764096300419455d, y: 0.2815018892285819d), new NpgsqlTypes.NpgsqlPoint(x: 0.08602706808901484d, y: 0.3672719446059216d), new NpgsqlTypes.NpgsqlPoint(x: 0.11999690967233079d, y: 0.7910005949426689d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425931885338098d, y: 0.6379027145535197d), new NpgsqlTypes.NpgsqlPoint(x: 0.21539218136167604d, y: 0.5781145564655902d), new NpgsqlTypes.NpgsqlPoint(x: 0.778246002100607d, y: 0.9294898665090219d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20512318674848606d, y: 0.06667901033004764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7913612083090175d, y: 0.4290167443427493d), new NpgsqlTypes.NpgsqlPoint(x: 0.0025392049855295085d, y: 0.29249298925410594d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3455114855382009d, y: 0.8957146596877963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386579799715986d, y: 0.02369134397071071d), new NpgsqlTypes.NpgsqlPoint(x: 0.22749820089957384d, y: 0.6475834498847194d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3479792552163944d, y: 0.5712652783653087d), new NpgsqlTypes.NpgsqlPoint(x: 0.1616838008698117d, y: 0.609864602886229d), new NpgsqlTypes.NpgsqlPoint(x: 0.4231069911175839d, y: 0.5247604266350433d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06982978693760578d, y: 0.004054005589164356d), new NpgsqlTypes.NpgsqlPoint(x: 0.1306522052310547d, y: 0.6659785981899549d), new NpgsqlTypes.NpgsqlPoint(x: 0.07646516070008402d, y: 0.6080816596037801d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43976282927618016d, y: 0.9778604324724125d), new NpgsqlTypes.NpgsqlPoint(x: 0.6843731199248942d, y: 0.8413245720985899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471382715130756d, y: 0.28000480799065475d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3792361785694036d, y: 0.9491754635166191d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638371173774259d, y: 0.6780589807555294d), new NpgsqlTypes.NpgsqlPoint(x: 0.884514019464455d, y: 0.9480309981103547d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6199604645222219d, y: 0.5025330061525123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345360564315498d, y: 0.2441351948898085d), new NpgsqlTypes.NpgsqlPoint(x: 0.04133584199751772d, y: 0.023803651607066212d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7382407863577435d, y: 0.6059412228367501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7859014097960064d, y: 0.662229763657439d), new NpgsqlTypes.NpgsqlPoint(x: 0.7048534630585042d, y: 0.49913213645618293d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3160689161037564d, y: 0.7546576154087052d), new NpgsqlTypes.NpgsqlPoint(x: 0.47149497464400036d, y: 0.2111915522996356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878962667468057d, y: 0.12843870028943105d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31076884500045343d, y: 0.9716929553880282d), new NpgsqlTypes.NpgsqlPoint(x: 0.901515436192528d, y: 0.23731348194851865d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831731891910575d, y: 0.814857809693654d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.88251868879337d, y: 0.21766561787118666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8001817114797364d, y: 0.24293389257560705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513869001835108d, y: 0.9280539334213517d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29441299426189493d, y: 0.17776764581163962d), new NpgsqlTypes.NpgsqlPoint(x: 0.10900698140639142d, y: 0.6128206959974355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8041003300851168d, y: 0.37404526448469577d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5687612455119962d, y: 0.7018922846089458d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793974083679752d, y: 0.11546527811499396d), new NpgsqlTypes.NpgsqlPoint(x: 0.43292656758923664d, y: 0.5990903070417345d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2890303139709284d, y: 0.0238741816922714d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236157109015464d, y: 0.8534557393925225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4830603428185549d, y: 0.7520840757005669d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7782851166498216d, y: 0.008377905724479273d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401098536200786d, y: 0.2831089265506377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479570574818197d, y: 0.1936647899762206d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9942499983589131d, y: 0.1500755420688441d), new NpgsqlTypes.NpgsqlPoint(x: 0.961585653051698d, y: 0.06796138661446449d), new NpgsqlTypes.NpgsqlPoint(x: 0.2593482322645414d, y: 0.5821964017445381d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6588572870942816d, y: 0.3889930795353519d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614991303154042d, y: 0.4852200229548762d), new NpgsqlTypes.NpgsqlPoint(x: 0.3134513796292726d, y: 0.794472103282877d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5395994746120393d, y: 0.6609490216667684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636482995914704d, y: 0.7462878700874194d), new NpgsqlTypes.NpgsqlPoint(x: 0.04713331893261985d, y: 0.40892152603920173d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7303109599120073d, y: 0.3107824250854381d), new NpgsqlTypes.NpgsqlPoint(x: 0.28575607375043d, y: 0.9880880280115804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933083219470404d, y: 0.14096081236016955d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9054799387491881d, y: 0.13098351114776974d), new NpgsqlTypes.NpgsqlPoint(x: 0.3665750901121566d, y: 0.12736715344668925d), new NpgsqlTypes.NpgsqlPoint(x: 0.412740785369467d, y: 0.740886110588356d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4066480671562902d, y: 0.46973994710518296d), new NpgsqlTypes.NpgsqlPoint(x: 0.4714181853524957d, y: 0.15232002440242176d), new NpgsqlTypes.NpgsqlPoint(x: 0.2925355893702043d, y: 0.6459860494226456d)), } },
    ModelInner = new NpgsqlPolygonpolygonMArrayD21MI
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04953406036953922d, y: 0.7376697626808832d), new NpgsqlTypes.NpgsqlPoint(x: 0.25601082447793677d, y: 0.7168082935500694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7189240209095575d, y: 0.9018133512949343d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41126809381098695d, y: 0.7598809461568617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582889038940936d, y: 0.8748776930963367d), new NpgsqlTypes.NpgsqlPoint(x: 0.43258456011527635d, y: 0.7165315930686985d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7463952026875206d, y: 0.14270230898262126d), new NpgsqlTypes.NpgsqlPoint(x: 0.20987845502139113d, y: 0.05574477112849574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866651198533974d, y: 0.20471767413428732d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7355898257790664d, y: 0.17767684898501201d), new NpgsqlTypes.NpgsqlPoint(x: 0.1086140409473364d, y: 0.046151729740210645d), new NpgsqlTypes.NpgsqlPoint(x: 0.13405630702556903d, y: 0.6947014494205797d)), } },
},
            new NpgsqlPolygonpolygonMArrayD2E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2510573167186021d, y: 0.651615158714872d), new NpgsqlTypes.NpgsqlPoint(x: 0.14652500861609374d, y: 0.21995050716820375d), new NpgsqlTypes.NpgsqlPoint(x: 0.30501958478678026d, y: 0.8508059900567442d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26597840849415355d, y: 0.4355798732430707d), new NpgsqlTypes.NpgsqlPoint(x: 0.10069918039530046d, y: 0.3658913859932862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636482210950798d, y: 0.08865180291851182d)), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd21mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd21mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmarrayd21mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmarrayd21mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmarrayd21mi_id
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
    npgsqlpolygonpolygonmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44650281727491725d, y: 0.5158868401065279d), new NpgsqlTypes.NpgsqlPoint(x: 0.4084809915598133d, y: 0.8433468942451524d), new NpgsqlTypes.NpgsqlPoint(x: 0.2507003719850931d, y: 0.9973982245792138d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19497018535253796d, y: 0.28236779100535725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783659511537302d, y: 0.13887311830789784d), new NpgsqlTypes.NpgsqlPoint(x: 0.006987689317563439d, y: 0.7413577834341237d)), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmarrayd21mi_id
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
    npgsqlpolygonpolygonmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmarrayd21mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5322490513328335d, y: 0.2641506365589781d), new NpgsqlTypes.NpgsqlPoint(x: 0.35910666216089904d, y: 0.821470372868774d), new NpgsqlTypes.NpgsqlPoint(x: 0.26436762803830904d, y: 0.5579324682431113d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4810293247602736d, y: 0.16929154412807268d), new NpgsqlTypes.NpgsqlPoint(x: 0.979995405735174d, y: 0.40008801913018266d), new NpgsqlTypes.NpgsqlPoint(x: 0.07657717799015784d, y: 0.6149267732722062d)), } }));
                nullable = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { {
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4423975889652225d, y: 0.12588645000233023d), new NpgsqlTypes.NpgsqlPoint(x: 0.14500632477895392d, y: 0.6147042120906343d), new NpgsqlTypes.NpgsqlPoint(x: 0.955962265343083d, y: 0.14359620669070028d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07931794169611817d, y: 0.5059273360018028d), new NpgsqlTypes.NpgsqlPoint(x: 0.3827980744546726d, y: 0.18599962140643367d), new NpgsqlTypes.NpgsqlPoint(x: 0.35642649683605787d, y: 0.8756198523315494d)), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMArrayD2E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMArrayD2E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd21mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd21mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 114;
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd21mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 89, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 39, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 157, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 127, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 156, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 156, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd21mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 20, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 20, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD21MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD21MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
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
FROM public.binary_npgsqlpolygonpolygonmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmarrayd21mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA), typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
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
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
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
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA), typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
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
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
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
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MI), typeof(NpgsqlPolygonpolygonMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MI>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MI>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MI>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MI>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA), typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                await ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD21MIWA>();
                ((INpgsqlPolygonMArraypolygonMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

