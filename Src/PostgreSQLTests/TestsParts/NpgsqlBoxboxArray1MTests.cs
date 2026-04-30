

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4302005659840139d,right: 0.642976821322822d,bottom: 0.39731224256224484d,left: 0.12124411502547827d),
new NpgsqlTypes.NpgsqlBox(top: 0.7851900040855688d,right: 0.933761955217082d,bottom: 0.6851969293183479d,left: 0.20534237568953662d),
new NpgsqlTypes.NpgsqlBox(top: 0.8508470244981917d,right: 0.9116934839561154d,bottom: 0.7799791761244494d,left: 0.3161745940354853d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4089955128190852d,right: 0.3069769433731738d,bottom: 0.29202698138251226d,left: 0.053158386636510624d),
new NpgsqlTypes.NpgsqlBox(top: 0.7088118075300809d,right: 0.6443594681023755d,bottom: 0.448592450177664d,left: 0.18046970849288968d),
new NpgsqlTypes.NpgsqlBox(top: 0.5947778832195422d,right: 0.8122283118088492d,bottom: 0.48856184681774384d,left: 0.008113910175806316d),
new NpgsqlTypes.NpgsqlBox(top: 0.8134757173614794d,right: 0.27625734358098564d,bottom: 0.42262711723531154d,left: 0.07528254513523203d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3312978526713707d,right: 0.4579928532210682d,bottom: 0.24127133633819098d,left: 0.44300701094984984d),
new NpgsqlTypes.NpgsqlBox(top: 0.5069474034038248d,right: 0.7903471620346092d,bottom: 0.08172989356741645d,left: 0.7502020679539192d),
new NpgsqlTypes.NpgsqlBox(top: 0.9826739303862221d,right: 0.5032267710749926d,bottom: 0.508977324010644d,left: 0.3977107702131908d),
new NpgsqlTypes.NpgsqlBox(top: 0.3435368723675304d,right: 0.22414217197734787d,bottom: 0.08291077855049234d,left: 0.0157741216943742d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6074069110591118d,right: 0.9023201460732072d,bottom: 0.041616845854434925d,left: 0.42061223327227826d),
new NpgsqlTypes.NpgsqlBox(top: 0.5932665748606689d,right: 0.7269878344461543d,bottom: 0.1378649101859849d,left: 0.6288336717100799d),
new NpgsqlTypes.NpgsqlBox(top: 0.6034197668980884d,right: 0.8042584044881561d,bottom: 0.2740555195570161d,left: 0.32448554197058666d),
new NpgsqlTypes.NpgsqlBox(top: 0.8269793136231014d,right: 0.6629603172741578d,bottom: 0.301704476949056d,left: 0.46170693889347925d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8616971933821798d,right: 0.5323683939608692d,bottom: 0.45627617899337325d,left: 0.1031295470294028d),
new NpgsqlTypes.NpgsqlBox(top: 0.9926569605578045d,right: 0.783258962384035d,bottom: 0.06839099641193713d,left: 0.2972009038033343d),
new NpgsqlTypes.NpgsqlBox(top: 0.8400740816286774d,right: 0.928316056004711d,bottom: 0.8268692581752394d,left: 0.3830545312306888d),
new NpgsqlTypes.NpgsqlBox(top: 0.3981895197462171d,right: 0.2060612877064455d,bottom: 0.0570362823202436d,left: 0.09064391035921315d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8340563903364486d,right: 0.7537906710878016d,bottom: 0.18617227406469983d,left: 0.4438975728993376d),
new NpgsqlTypes.NpgsqlBox(top: 0.47471459885725276d,right: 0.9984392877963997d,bottom: 0.2611930211111849d,left: 0.5580671024621696d),
new NpgsqlTypes.NpgsqlBox(top: 0.9459602600745094d,right: 0.722580118047027d,bottom: 0.5179490863365807d,left: 0.6763793870762288d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6869403031325648d,right: 0.8973412803994248d,bottom: 0.042607029723719325d,left: 0.026003392817292248d),
new NpgsqlTypes.NpgsqlBox(top: 0.31957965669666155d,right: 0.8141885966277974d,bottom: 0.20401042421199522d,left: 0.6333276095538032d),
new NpgsqlTypes.NpgsqlBox(top: 0.9063705666536723d,right: 0.12162216782129287d,bottom: 0.1539002561829409d,left: 0.06322262249442467d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8232361627919138d,right: 0.7604610757468282d,bottom: 0.04504249895353618d,left: 0.008975529674226546d),
new NpgsqlTypes.NpgsqlBox(top: 0.4851535739473506d,right: 0.7858837624124603d,bottom: 0.10529216412037468d,left: 0.4385024759144448d),
new NpgsqlTypes.NpgsqlBox(top: 0.17426763508170406d,right: 0.6020929812723365d,bottom: 0.12160780263589532d,left: 0.30618061433813637d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.919185864998009d,right: 0.5688344611267842d,bottom: 0.1772037773383789d,left: 0.11271173949863722d),
new NpgsqlTypes.NpgsqlBox(top: 0.8885122401669663d,right: 0.662839216258892d,bottom: 0.0291080327366533d,left: 0.4110738728487743d),
new NpgsqlTypes.NpgsqlBox(top: 0.4885024907081521d,right: 0.8638026543734787d,bottom: 0.002779239255003896d,left: 0.41893858686423213d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6674523284929312d,right: 0.678914097629891d,bottom: 0.379114419344609d,left: 0.2120151892603328d),
new NpgsqlTypes.NpgsqlBox(top: 0.06190299503326435d,right: 0.9434150481368876d,bottom: 0.045101327160670834d,left: 0.08910960215420705d),
new NpgsqlTypes.NpgsqlBox(top: 0.31442453446387786d,right: 0.5055349616636945d,bottom: 0.2871162345340065d,left: 0.032403923411605806d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.733938059039171d,right: 0.9649200905297572d,bottom: 0.20895142780387566d,left: 0.8538405518636368d),
new NpgsqlTypes.NpgsqlBox(top: 0.2103426754381168d,right: 0.7515180186333739d,bottom: 0.026033128621251067d,left: 0.2321633460933652d),
new NpgsqlTypes.NpgsqlBox(top: 0.4781983510024943d,right: 0.6568526852375337d,bottom: 0.09240529829664312d,left: 0.3060647341396685d),
new NpgsqlTypes.NpgsqlBox(top: 0.22081000587886468d,right: 0.7213431747678006d,bottom: 0.21630351771115564d,left: 0.4140375890207194d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4983612182650041d,right: 0.7954885919999514d,bottom: 0.06872869840318074d,left: 0.39696446634013294d),
new NpgsqlTypes.NpgsqlBox(top: 0.6028409193536668d,right: 0.26732507177751796d,bottom: 0.35621747599153364d,left: 0.24206521538949632d),
new NpgsqlTypes.NpgsqlBox(top: 0.20805451667179065d,right: 0.3029348110814313d,bottom: 0.006073962409629319d,left: 0.06150031951802559d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32396754263042293d,right: 0.9241098071291761d,bottom: 0.27664666608643107d,left: 0.6328267085583015d),
new NpgsqlTypes.NpgsqlBox(top: 0.9219110625241113d,right: 0.928310724135202d,bottom: 0.9145917576590487d,left: 0.07230602319363577d),
new NpgsqlTypes.NpgsqlBox(top: 0.9706489729849488d,right: 0.983717498065645d,bottom: 0.39039316830450477d,left: 0.8676162085816188d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9014490432993082d,right: 0.48791950635946113d,bottom: 0.4264188654739358d,left: 0.023036959402258916d),
new NpgsqlTypes.NpgsqlBox(top: 0.5259121044969174d,right: 0.6574668320958286d,bottom: 0.17377256699090904d,left: 0.02092705018846841d),
new NpgsqlTypes.NpgsqlBox(top: 0.41727700521622013d,right: 0.6759025860970903d,bottom: 0.3966990736843232d,left: 0.028288029847518548d),
new NpgsqlTypes.NpgsqlBox(top: 0.9584044746910093d,right: 0.8390160017268754d,bottom: 0.7485643197840194d,left: 0.30648207795097304d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6938960017190353d,right: 0.03507242181698933d,bottom: 0.09241555394824308d,left: 0.029510091107416758d),
new NpgsqlTypes.NpgsqlBox(top: 0.8337231781640283d,right: 0.9198250486324437d,bottom: 0.4000403295074775d,left: 0.5037557030096079d),
new NpgsqlTypes.NpgsqlBox(top: 0.7094633962909679d,right: 0.3547375353276563d,bottom: 0.4897900101129886d,left: 0.1407305760647447d),
new NpgsqlTypes.NpgsqlBox(top: 0.8042855468312146d,right: 0.8836898037130687d,bottom: 0.1998438758913288d,left: 0.06588761074815408d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6662295648842236d,right: 0.9605157420299635d,bottom: 0.43556293632319276d,left: 0.06049086687000149d),
new NpgsqlTypes.NpgsqlBox(top: 0.14941510116206425d,right: 0.9326466542054312d,bottom: 0.06928345248972989d,left: 0.8917876625110798d),
new NpgsqlTypes.NpgsqlBox(top: 0.9411184407602942d,right: 0.9348249742541215d,bottom: 0.81956626798148d,left: 0.22339492435643293d),
new NpgsqlTypes.NpgsqlBox(top: 0.8406782237751814d,right: 0.3763433037798838d,bottom: 0.09290476239987466d,left: 0.279006070400024d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9451066059630318d,right: 0.910822219958621d,bottom: 0.664539496008374d,left: 0.704788718364054d),
new NpgsqlTypes.NpgsqlBox(top: 0.8953569193003653d,right: 0.8909977089442805d,bottom: 0.3318085544115623d,left: 0.27574233522757186d),
new NpgsqlTypes.NpgsqlBox(top: 0.6425775647540275d,right: 0.8753564642181441d,bottom: 0.27737761336353606d,left: 0.6449462037264776d),
new NpgsqlTypes.NpgsqlBox(top: 0.5232487594589211d,right: 0.5734439645465955d,bottom: 0.057965245762461204d,left: 0.04348752724232863d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9342571250207925d,right: 0.6907672257066284d,bottom: 0.5664219999053686d,left: 0.36981490267138817d),
new NpgsqlTypes.NpgsqlBox(top: 0.869303994305979d,right: 0.5313786700309888d,bottom: 0.3415422924741559d,left: 0.31782657339962483d),
new NpgsqlTypes.NpgsqlBox(top: 0.9111465815951846d,right: 0.532533448310652d,bottom: 0.27414169253258525d,left: 0.10480222091095936d),
new NpgsqlTypes.NpgsqlBox(top: 0.9726778307018157d,right: 0.49564302628646273d,bottom: 0.4498351297471639d,left: 0.12746345574101925d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5175595951337749d,right: 0.46160781417673835d,bottom: 0.3327039857337982d,left: 0.13577451118070372d),
new NpgsqlTypes.NpgsqlBox(top: 0.19985442139653553d,right: 0.8605876835533072d,bottom: 0.17512807325045887d,left: 0.285134187552633d),
new NpgsqlTypes.NpgsqlBox(top: 0.7778564203667225d,right: 0.833153814076455d,bottom: 0.6714104412204853d,left: 0.4860772383929177d),
new NpgsqlTypes.NpgsqlBox(top: 0.48486664380890976d,right: 0.5126000827025049d,bottom: 0.321362574652057d,left: 0.26398591184834785d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6330992697207353d,right: 0.6025693516058578d,bottom: 0.22847034575261882d,left: 0.4732585205963411d),
new NpgsqlTypes.NpgsqlBox(top: 0.8001495021762974d,right: 0.8712634033127699d,bottom: 0.6960502986463616d,left: 0.7934377686191718d),
new NpgsqlTypes.NpgsqlBox(top: 0.7067291785698411d,right: 0.8666937461512384d,bottom: 0.0360520233820969d,left: 0.48796831915535754d),
new NpgsqlTypes.NpgsqlBox(top: 0.682393585035237d,right: 0.7710912879000895d,bottom: 0.4195120360929453d,left: 0.04823012512600888d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33442743351149384d,right: 0.7419251959262125d,bottom: 0.31598456745854586d,left: 0.015255151488822838d),
new NpgsqlTypes.NpgsqlBox(top: 0.46134829994343163d,right: 0.7017628252583711d,bottom: 0.16319969743572527d,left: 0.02632862438949879d),
new NpgsqlTypes.NpgsqlBox(top: 0.7749782813220145d,right: 0.61683955463073d,bottom: 0.5247335148641722d,left: 0.20999407134862058d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32859725216205393d,right: 0.9320536333584958d,bottom: 0.1510638762532588d,left: 0.036408771786342164d),
new NpgsqlTypes.NpgsqlBox(top: 0.9181595618463058d,right: 0.8440503417837709d,bottom: 0.48054022009259856d,left: 0.09476923627459966d),
new NpgsqlTypes.NpgsqlBox(top: 0.9736647962571586d,right: 0.5561530010966889d,bottom: 0.3225418801448776d,left: 0.46796619489396885d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8889939146307503d,right: 0.5033410130270838d,bottom: 0.7269733448148413d,left: 0.256521716287222d),
new NpgsqlTypes.NpgsqlBox(top: 0.36718877132342387d,right: 0.12448340471656816d,bottom: 0.35559380765933857d,left: 0.1063369871386961d),
new NpgsqlTypes.NpgsqlBox(top: 0.3249749831661296d,right: 0.3012313960808658d,bottom: 0.23643216463528238d,left: 0.26417713100018936d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9051892937903221d,right: 0.9955063175452988d,bottom: 0.6669284300395946d,left: 0.43133655098535595d),
new NpgsqlTypes.NpgsqlBox(top: 0.9193793732879759d,right: 0.898041337977705d,bottom: 0.6190307044195261d,left: 0.2847972912565676d),
new NpgsqlTypes.NpgsqlBox(top: 0.7499416034328408d,right: 0.9771059397639621d,bottom: 0.2517907835798604d,left: 0.3579475559459814d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7182937132792823d,right: 0.9366884363760426d,bottom: 0.07699573263915238d,left: 0.3861571012441485d),
new NpgsqlTypes.NpgsqlBox(top: 0.988899472735319d,right: 0.21040110644498056d,bottom: 0.9305120076248178d,left: 0.05547453967480409d),
new NpgsqlTypes.NpgsqlBox(top: 0.7122658365598897d,right: 0.6581390885283779d,bottom: 0.1755758460999618d,left: 0.6410918527151661d),
new NpgsqlTypes.NpgsqlBox(top: 0.18770114315034192d,right: 0.6897944749702073d,bottom: 0.18357433518136634d,left: 0.5268925288726003d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3661564331764041d,right: 0.7829317927997975d,bottom: 0.1623881829679954d,left: 0.5066800604702348d),
new NpgsqlTypes.NpgsqlBox(top: 0.7072612474315915d,right: 0.7881078087479118d,bottom: 0.3124649681723206d,left: 0.7697344268308604d),
new NpgsqlTypes.NpgsqlBox(top: 0.4814252959934736d,right: 0.7511153058992052d,bottom: 0.13418512351153733d,left: 0.26510066366039486d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7188774269043632d,right: 0.20140304196372927d,bottom: 0.23730388705111105d,left: 0.17123665275338829d),
new NpgsqlTypes.NpgsqlBox(top: 0.8333014059758546d,right: 0.8663149475902178d,bottom: 0.4708743883146558d,left: 0.6676291980102043d),
new NpgsqlTypes.NpgsqlBox(top: 0.32856254843729404d,right: 0.5567100063326406d,bottom: 0.09284630351917433d,left: 0.21703124661914563d),
new NpgsqlTypes.NpgsqlBox(top: 0.6234074174464402d,right: 0.707356113663347d,bottom: 0.06918211615063208d,left: 0.5795958022238126d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9455908855828861d,right: 0.7196161714980819d,bottom: 0.08162919410781544d,left: 0.29865802256263607d),
new NpgsqlTypes.NpgsqlBox(top: 0.5132383963858627d,right: 0.9274565050830358d,bottom: 0.2024830432831679d,left: 0.13110041751346624d),
new NpgsqlTypes.NpgsqlBox(top: 0.5567723069212016d,right: 0.9019241113630356d,bottom: 0.34099197922210656d,left: 0.8144401728499d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.814254206354825d,right: 0.3118734796945245d,bottom: 0.7026395203496962d,left: 0.08761683967177047d),
new NpgsqlTypes.NpgsqlBox(top: 0.3505163817346859d,right: 0.7548547798430496d,bottom: 0.15205820221115895d,left: 0.38431860980047616d),
new NpgsqlTypes.NpgsqlBox(top: 0.9388544584635184d,right: 0.9511552780066156d,bottom: 0.5095196737305906d,left: 0.46847404041228335d),
new NpgsqlTypes.NpgsqlBox(top: 0.9958845141863784d,right: 0.6088585467814479d,bottom: 0.24655834530602183d,left: 0.36114741495187463d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9366457333916952d,right: 0.521435833653215d,bottom: 0.057015881185292105d,left: 0.1503033957457588d),
new NpgsqlTypes.NpgsqlBox(top: 0.9681401916145685d,right: 0.3552376825984793d,bottom: 0.21312007302792846d,left: 0.29801059665438645d),
new NpgsqlTypes.NpgsqlBox(top: 0.43829138325920125d,right: 0.7436542436078223d,bottom: 0.07507743758771324d,left: 0.38914740628980815d),
new NpgsqlTypes.NpgsqlBox(top: 0.40003367774929466d,right: 0.4024486282311137d,bottom: 0.07180483400902837d,left: 0.05556260599689755d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8885747726826029d,right: 0.9593631584599512d,bottom: 0.5204301477748032d,left: 0.9153960972197717d),
new NpgsqlTypes.NpgsqlBox(top: 0.5625293959725005d,right: 0.832471220453275d,bottom: 0.18492287431020882d,left: 0.23658631980984368d),
new NpgsqlTypes.NpgsqlBox(top: 0.325117469041446d,right: 0.7195437405823523d,bottom: 0.29587343075894357d,left: 0.23413804849418351d),
new NpgsqlTypes.NpgsqlBox(top: 0.4027019470419063d,right: 0.7335326096884005d,bottom: 0.22636600812831065d,left: 0.44455513247990186d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8325578351497458d,right: 0.7071601442347243d,bottom: 0.5421009826951437d,left: 0.2615604764180577d),
new NpgsqlTypes.NpgsqlBox(top: 0.505477885114629d,right: 0.7911449864025484d,bottom: 0.23613213543685252d,left: 0.1985622994451548d),
new NpgsqlTypes.NpgsqlBox(top: 0.32304136259721183d,right: 0.6507406451225494d,bottom: 0.08085622641857415d,left: 0.20316267246512365d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5615312627433008d,right: 0.6116369805398012d,bottom: 0.4789536104070653d,left: 0.5754338687478365d),
new NpgsqlTypes.NpgsqlBox(top: 0.9633006468264947d,right: 0.5658800573254241d,bottom: 0.7784700276316512d,left: 0.44390159209246816d),
new NpgsqlTypes.NpgsqlBox(top: 0.9616881505908859d,right: 0.24602125347112225d,bottom: 0.20434559303639432d,left: 0.14636508886306143d),
new NpgsqlTypes.NpgsqlBox(top: 0.6584359402927941d,right: 0.9778649756175265d,bottom: 0.14079075039768663d,left: 0.33443151749876043d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49647733033769514d,right: 0.6203896572492821d,bottom: 0.23585760088178798d,left: 0.36222755492523806d),
new NpgsqlTypes.NpgsqlBox(top: 0.651610661677059d,right: 0.5998211311096244d,bottom: 0.31943921486602167d,left: 0.5244190834382112d),
new NpgsqlTypes.NpgsqlBox(top: 0.4099370939701793d,right: 0.8920238087721396d,bottom: 0.3518546069309272d,left: 0.5461573946850465d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34947474220391916d,right: 0.9241662459784085d,bottom: 0.1736678060592889d,left: 0.12445552071272326d),
new NpgsqlTypes.NpgsqlBox(top: 0.8938040330546312d,right: 0.3018422566039527d,bottom: 0.7671763279382707d,left: 0.12548328328854474d),
new NpgsqlTypes.NpgsqlBox(top: 0.49410715173769204d,right: 0.2861962830341548d,bottom: 0.10761271882778811d,left: 0.13528505115562595d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9388837409844207d,right: 0.4136433162915517d,bottom: 0.4906093812702145d,left: 0.3877617898290744d),
new NpgsqlTypes.NpgsqlBox(top: 0.03909220021529758d,right: 0.5027137471907016d,bottom: 0.03467535232382668d,left: 0.04206162805096392d),
new NpgsqlTypes.NpgsqlBox(top: 0.25377530230212075d,right: 0.8970929434300448d,bottom: 0.06403181868341079d,left: 0.8209517767085026d),
new NpgsqlTypes.NpgsqlBox(top: 0.9770792698400451d,right: 0.9045906578031333d,bottom: 0.6177622407924952d,left: 0.7551087489892396d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6474490061193435d,right: 0.38156885381432526d,bottom: 0.16243035009955042d,left: 0.1900730203587172d),
new NpgsqlTypes.NpgsqlBox(top: 0.30836804166388854d,right: 0.9416878166155412d,bottom: 0.02421787794896524d,left: 0.8990444465146725d),
new NpgsqlTypes.NpgsqlBox(top: 0.33301054553394904d,right: 0.9735506887993987d,bottom: 0.1289862078000873d,left: 0.6136579548280016d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19090354822682154d,right: 0.4973118351295204d,bottom: 0.11059482970723644d,left: 0.02323899195634449d),
new NpgsqlTypes.NpgsqlBox(top: 0.7502479800872419d,right: 0.9574574304801468d,bottom: 0.5746247222432183d,left: 0.39320998070603663d),
new NpgsqlTypes.NpgsqlBox(top: 0.7400880519244737d,right: 0.7581818086383316d,bottom: 0.3714895764086187d,left: 0.24571830318759014d),
new NpgsqlTypes.NpgsqlBox(top: 0.8759864552082772d,right: 0.9789059248500173d,bottom: 0.12089376518507522d,left: 0.7350793372850456d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17140607575297773d,right: 0.6189218906859842d,bottom: 0.07429573658329014d,left: 0.5080968186445718d),
new NpgsqlTypes.NpgsqlBox(top: 0.7364202631272941d,right: 0.5523145814248239d,bottom: 0.6560951577708539d,left: 0.10696973756202066d),
new NpgsqlTypes.NpgsqlBox(top: 0.7180790929201366d,right: 0.9041568278344124d,bottom: 0.24862085324264838d,left: 0.17488317021050537d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.52666620913634d,right: 0.8509809105815723d,bottom: 0.3948164555125778d,left: 0.28134709479648046d),
new NpgsqlTypes.NpgsqlBox(top: 0.3029881056987891d,right: 0.8503067362770557d,bottom: 0.29375381628924535d,left: 0.21695115107200913d),
new NpgsqlTypes.NpgsqlBox(top: 0.9896313846024631d,right: 0.9106565276704606d,bottom: 0.988366158543414d,left: 0.5573252479282461d),
new NpgsqlTypes.NpgsqlBox(top: 0.3324027129542918d,right: 0.8767545855561382d,bottom: 0.21128948548733462d,left: 0.25495143948177346d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8853328533963646d,right: 0.9994206653689979d,bottom: 0.7140488242518579d,left: 0.7888677202178843d),
new NpgsqlTypes.NpgsqlBox(top: 0.9616942837738444d,right: 0.5678552561605491d,bottom: 0.00945848790663617d,left: 0.25319197455214626d),
new NpgsqlTypes.NpgsqlBox(top: 0.43133327802345656d,right: 0.522373792303535d,bottom: 0.4178509582214056d,left: 0.38513098547825164d),
new NpgsqlTypes.NpgsqlBox(top: 0.7447759406658196d,right: 0.3327847073257263d,bottom: 0.4835202423557513d,left: 0.05223532410876275d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.694990294522125d,right: 0.9154266584125506d,bottom: 0.5003450868048032d,left: 0.270369277328691d),
new NpgsqlTypes.NpgsqlBox(top: 0.9977771801742958d,right: 0.9893985150065181d,bottom: 0.3720493997668024d,left: 0.16845462493828833d),
new NpgsqlTypes.NpgsqlBox(top: 0.3631131991108596d,right: 0.6620488916377006d,bottom: 0.35249131689553015d,left: 0.5408901539250748d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7322547076250225d,right: 0.7689193867289463d,bottom: 0.019148218053444355d,left: 0.2089722097580845d),
new NpgsqlTypes.NpgsqlBox(top: 0.6101302640903824d,right: 0.8049497163567807d,bottom: 0.2773199790533465d,left: 0.7911775075155828d),
new NpgsqlTypes.NpgsqlBox(top: 0.5773671920229054d,right: 0.6096880385652718d,bottom: 0.41248511803424615d,left: 0.5974557401499923d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6760670807913421d,right: 0.6920243558836447d,bottom: 0.002833077429383546d,left: 0.02494910396622274d),
new NpgsqlTypes.NpgsqlBox(top: 0.9932096714832992d,right: 0.942202279119468d,bottom: 0.8757059595370541d,left: 0.7907092946206267d),
new NpgsqlTypes.NpgsqlBox(top: 0.5926292249881492d,right: 0.7623272565427576d,bottom: 0.23635714625283555d,left: 0.5786922014591159d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.65537970667844d,right: 0.9161940433784956d,bottom: 0.11435329843747344d,left: 0.5695303129542703d),
new NpgsqlTypes.NpgsqlBox(top: 0.16848729355937841d,right: 0.9064222100578461d,bottom: 0.1432620699437287d,left: 0.4458627547623014d),
new NpgsqlTypes.NpgsqlBox(top: 0.7392284997746494d,right: 0.615067494058497d,bottom: 0.32836573910160516d,left: 0.23759915956478994d),
new NpgsqlTypes.NpgsqlBox(top: 0.934403865408702d,right: 0.20208866163041828d,bottom: 0.4785070623422688d,left: 0.09455521557740043d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5482545606435871d,right: 0.8381969786602688d,bottom: 0.5152803895970863d,left: 0.4406246334582766d),
new NpgsqlTypes.NpgsqlBox(top: 0.3614045217786507d,right: 0.7414344059597715d,bottom: 0.10622533867673589d,left: 0.3247962240370714d),
new NpgsqlTypes.NpgsqlBox(top: 0.2674912371093898d,right: 0.8836861164708291d,bottom: 0.03242785034886697d,left: 0.18848120361346d),
new NpgsqlTypes.NpgsqlBox(top: 0.9843207410540887d,right: 0.9311408019072375d,bottom: 0.9080497156020195d,left: 0.7764097703048737d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8649545449036092d,right: 0.9344993439772048d,bottom: 0.20729394238513488d,left: 0.3826567195704723d),
new NpgsqlTypes.NpgsqlBox(top: 0.6602599070421165d,right: 0.7348983644625479d,bottom: 0.19115772454601d,left: 0.4264657625311993d),
new NpgsqlTypes.NpgsqlBox(top: 0.40078311399149624d,right: 0.5865253698628627d,bottom: 0.06815279647581585d,left: 0.3385101132308769d),
new NpgsqlTypes.NpgsqlBox(top: 0.6935548023776728d,right: 0.5636245992400472d,bottom: 0.52183651409298d,left: 0.4056311841760484d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6345088903241587d,right: 0.5763817976067429d,bottom: 0.4777230509665866d,left: 0.1849266067702967d),
new NpgsqlTypes.NpgsqlBox(top: 0.7359234777938914d,right: 0.63799748144476d,bottom: 0.4637608049076575d,left: 0.6231960631311089d),
new NpgsqlTypes.NpgsqlBox(top: 0.39822719627959524d,right: 0.9584868002567782d,bottom: 0.352220961000949d,left: 0.5508808894702935d),
new NpgsqlTypes.NpgsqlBox(top: 0.8225938539807309d,right: 0.8770729359978535d,bottom: 0.816332102601281d,left: 0.2128195491118342d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.324454470265637d,right: 0.29916790768007206d,bottom: 0.013530134256311332d,left: 0.003258255428290502d),
new NpgsqlTypes.NpgsqlBox(top: 0.042107939152424945d,right: 0.5707512322691832d,bottom: 0.028104468029607865d,left: 0.5451350771708408d),
new NpgsqlTypes.NpgsqlBox(top: 0.5612302923848224d,right: 0.5708537083215112d,bottom: 0.32636928500431395d,left: 0.2847032568044119d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6881845093921377d,right: 0.8251056974566219d,bottom: 0.595206405939935d,left: 0.5814359216532801d),
new NpgsqlTypes.NpgsqlBox(top: 0.9876316315369117d,right: 0.7358128523520147d,bottom: 0.9567890109208956d,left: 0.34579140295137545d),
new NpgsqlTypes.NpgsqlBox(top: 0.9217412309845617d,right: 0.7739383761741877d,bottom: 0.7370301872344946d,left: 0.4179794714510182d),
new NpgsqlTypes.NpgsqlBox(top: 0.49114609323381897d,right: 0.7996220555538845d,bottom: 0.07823018199379728d,left: 0.4352276527081391d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6179588934679466d,right: 0.8227057839622802d,bottom: 0.04959650622598688d,left: 0.3488003831082802d),
new NpgsqlTypes.NpgsqlBox(top: 0.8721441509582216d,right: 0.7965574557710557d,bottom: 0.2944988118895121d,left: 0.7015685928572881d),
new NpgsqlTypes.NpgsqlBox(top: 0.4711552724195903d,right: 0.8139751125204077d,bottom: 0.2461264602874852d,left: 0.28517348561504086d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4263311792125045d,right: 0.8976839297351389d,bottom: 0.3113777914506941d,left: 0.7716629062151568d),
new NpgsqlTypes.NpgsqlBox(top: 0.807666102376785d,right: 0.947634934528992d,bottom: 0.7110544933607882d,left: 0.2700310803886168d),
new NpgsqlTypes.NpgsqlBox(top: 0.5197710696596816d,right: 0.5594520782286975d,bottom: 0.5123646467441949d,left: 0.1642055971792179d),
new NpgsqlTypes.NpgsqlBox(top: 0.5681392925993397d,right: 0.36979213388819754d,bottom: 0.33692870476199277d,left: 0.0898268331311326d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.38748034583215063d,right: 0.6996309072831929d,bottom: 0.3752218281590537d,left: 0.5478758715366734d),
new NpgsqlTypes.NpgsqlBox(top: 0.8456613090817574d,right: 0.6964424258364845d,bottom: 0.6060696038734354d,left: 0.6022654870946149d),
new NpgsqlTypes.NpgsqlBox(top: 0.8927557535942138d,right: 0.8816812734517151d,bottom: 0.6545448639435826d,left: 0.3597152618723193d),
new NpgsqlTypes.NpgsqlBox(top: 0.9803696735732415d,right: 0.7308690734124512d,bottom: 0.883024836578669d,left: 0.4246852059571824d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9715505307302459d,right: 0.6645221386462777d,bottom: 0.0775749621822065d,left: 0.2492118890065389d),
new NpgsqlTypes.NpgsqlBox(top: 0.9155576914821645d,right: 0.7320129722547208d,bottom: 0.08383972189821753d,left: 0.3480958463901128d),
new NpgsqlTypes.NpgsqlBox(top: 0.03669744021345711d,right: 0.9953988431294671d,bottom: 0.00329763039343689d,left: 0.5420945542139566d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5584075714545239d,right: 0.6512295512781178d,bottom: 0.31656694156744347d,left: 0.16751528866281806d),
new NpgsqlTypes.NpgsqlBox(top: 0.6426539760944893d,right: 0.41147437709616386d,bottom: 0.20770357103760395d,left: 0.0706340032687155d),
new NpgsqlTypes.NpgsqlBox(top: 0.8549674106498609d,right: 0.6930450896090558d,bottom: 0.158271735070333d,left: 0.5525789303757347d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7342737930805018d,right: 0.7834992851305497d,bottom: 0.6214672848460905d,left: 0.2841625089328199d),
new NpgsqlTypes.NpgsqlBox(top: 0.8878854214778026d,right: 0.9512988743746777d,bottom: 0.5323004012088183d,left: 0.03499937433609712d),
new NpgsqlTypes.NpgsqlBox(top: 0.9678961247420346d,right: 0.6193435895931065d,bottom: 0.7085597750354107d,left: 0.5291262984477685d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9723174379236266d,right: 0.8005531150639282d,bottom: 0.6195119916403278d,left: 0.7531655991094742d),
new NpgsqlTypes.NpgsqlBox(top: 0.5555939885438749d,right: 0.5229736408408386d,bottom: 0.5098718856440879d,left: 0.3346386587287946d),
new NpgsqlTypes.NpgsqlBox(top: 0.968663431227841d,right: 0.9251512836053472d,bottom: 0.19090470238384016d,left: 0.21371065117172605d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.964229483442993d,right: 0.534642663055608d,bottom: 0.2789889796655649d,left: 0.3849641610561635d),
new NpgsqlTypes.NpgsqlBox(top: 0.5699436452027554d,right: 0.35775807181227104d,bottom: 0.36600962192467956d,left: 0.3018017888676051d),
new NpgsqlTypes.NpgsqlBox(top: 0.4995601858244426d,right: 0.8120311938396347d,bottom: 0.24224704626363425d,left: 0.03750977120354326d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7493515632320678d,right: 0.8013407033568348d,bottom: 0.5061364906532961d,left: 0.17609565860214926d),
new NpgsqlTypes.NpgsqlBox(top: 0.30083290437604626d,right: 0.9558395371589128d,bottom: 0.024907309439038072d,left: 0.08606706397984698d),
new NpgsqlTypes.NpgsqlBox(top: 0.8051366054202576d,right: 0.6542331110085079d,bottom: 0.39979480691976454d,left: 0.08247609120544819d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7605698290464941d,right: 0.5566460068390995d,bottom: 0.02596973278310677d,left: 0.29351640655157596d),
new NpgsqlTypes.NpgsqlBox(top: 0.4216453314984354d,right: 0.09385162425298565d,bottom: 0.09614835052391657d,left: 0.06689429348077447d),
new NpgsqlTypes.NpgsqlBox(top: 0.26145041260516066d,right: 0.8749535157233763d,bottom: 0.2449250596698097d,left: 0.5233361238438325d),
new NpgsqlTypes.NpgsqlBox(top: 0.5907367087743568d,right: 0.5963155205669406d,bottom: 0.053816814421854375d,left: 0.24603734755679463d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2634150615287383d,right: 0.8028792364459824d,bottom: 0.15367896395626068d,left: 0.21616634871731633d),
new NpgsqlTypes.NpgsqlBox(top: 0.5139646551721896d,right: 0.9276162280203086d,bottom: 0.40123662097024304d,left: 0.04093390839124589d),
new NpgsqlTypes.NpgsqlBox(top: 0.4759638769615294d,right: 0.4532771239704686d,bottom: 0.12715304894747603d,left: 0.19458039337433541d),
new NpgsqlTypes.NpgsqlBox(top: 0.4150193536354121d,right: 0.8897833895005116d,bottom: 0.20702754641046495d,left: 0.6302901134573733d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8284815430703181d,right: 0.5807830349427754d,bottom: 0.5629621185028475d,left: 0.17587165452136044d),
new NpgsqlTypes.NpgsqlBox(top: 0.4031166750959143d,right: 0.5299353431494201d,bottom: 0.1923262746195058d,left: 0.3301812629315547d),
new NpgsqlTypes.NpgsqlBox(top: 0.5946934688620255d,right: 0.9558907823091016d,bottom: 0.44981677593302727d,left: 0.8255558684440957d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5276625598303949d,right: 0.8107149963927407d,bottom: 0.08756574214233748d,left: 0.1791785640210164d),
new NpgsqlTypes.NpgsqlBox(top: 0.37015821197918153d,right: 0.4201360984684911d,bottom: 0.22700543280248742d,left: 0.10907008842416677d),
new NpgsqlTypes.NpgsqlBox(top: 0.39785429474069545d,right: 0.9865867945656431d,bottom: 0.2623256618471601d,left: 0.9232791751677093d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5559523515712111d,right: 0.7838986617019355d,bottom: 0.4100544967524853d,left: 0.7750718710494549d),
new NpgsqlTypes.NpgsqlBox(top: 0.2763602788581996d,right: 0.7334696556291386d,bottom: 0.18497504462949432d,left: 0.6442263208748812d),
new NpgsqlTypes.NpgsqlBox(top: 0.9765915353149669d,right: 0.7540763317324484d,bottom: 0.935567518122232d,left: 0.6640816830445729d),
new NpgsqlTypes.NpgsqlBox(top: 0.8049208218636418d,right: 0.5637642895544415d,bottom: 0.2012279049971505d,left: 0.5146973485591937d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.642303056267401d,right: 0.9677483030807308d,bottom: 0.20772812068964697d,left: 0.3248202841204104d),
new NpgsqlTypes.NpgsqlBox(top: 0.7134117072655637d,right: 0.31289715581216415d,bottom: 0.09808432637159792d,left: 0.1007321719460994d),
new NpgsqlTypes.NpgsqlBox(top: 0.784222606823208d,right: 0.9855478858444152d,bottom: 0.2642054221691278d,left: 0.8995954430578809d),
new NpgsqlTypes.NpgsqlBox(top: 0.7626242852085333d,right: 0.5920076152681372d,bottom: 0.6408662387338357d,left: 0.5714632247256954d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3790432749528604d,right: 0.8797321615886505d,bottom: 0.019776845938962673d,left: 0.14936208204236656d),
new NpgsqlTypes.NpgsqlBox(top: 0.6259774177200053d,right: 0.7444095276068241d,bottom: 0.2858387038748861d,left: 0.590608041044317d),
new NpgsqlTypes.NpgsqlBox(top: 0.4607115926188782d,right: 0.12723220178952532d,bottom: 0.20619536409638772d,left: 0.020706589688764043d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4347490513455323d,right: 0.9450961051032082d,bottom: 0.38765844837755303d,left: 0.5991705047710518d),
new NpgsqlTypes.NpgsqlBox(top: 0.3053230948666763d,right: 0.675602368823288d,bottom: 0.05966977375438243d,left: 0.5008437380480749d),
new NpgsqlTypes.NpgsqlBox(top: 0.9249940511087784d,right: 0.3708969894441896d,bottom: 0.8394359449059832d,left: 0.02618148701667633d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.788727279955022d,right: 0.8455652573057262d,bottom: 0.5705640397933228d,left: 0.5444452075138279d),
new NpgsqlTypes.NpgsqlBox(top: 0.3854282680719674d,right: 0.9882593703101643d,bottom: 0.23019966215575927d,left: 0.05969908418921677d),
new NpgsqlTypes.NpgsqlBox(top: 0.9656129052674728d,right: 0.4126471594079417d,bottom: 0.43906384561644696d,left: 0.33581631443782856d),
new NpgsqlTypes.NpgsqlBox(top: 0.7380430260527082d,right: 0.7435701559296357d,bottom: 0.38797487556670474d,left: 0.4895120751225641d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7861088697995141d,right: 0.5455969849245885d,bottom: 0.7521093303605387d,left: 0.33624987785558846d),
new NpgsqlTypes.NpgsqlBox(top: 0.6039030370523515d,right: 0.9008388871344477d,bottom: 0.00906051145959652d,left: 0.878773134634893d),
new NpgsqlTypes.NpgsqlBox(top: 0.7972820600839255d,right: 0.4989631288346553d,bottom: 0.2624430259547107d,left: 0.2921641221071771d),
new NpgsqlTypes.NpgsqlBox(top: 0.4907050810381911d,right: 0.6782466581737675d,bottom: 0.4492534096954055d,left: 0.2996692497889215d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 188,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8103617793040055d,right: 0.9566919709313445d,bottom: 0.4575028163495769d,left: 0.18353242435848094d),
new NpgsqlTypes.NpgsqlBox(top: 0.6741426318408468d,right: 0.5004049307570292d,bottom: 0.6411057824736601d,left: 0.14708975332781038d),
new NpgsqlTypes.NpgsqlBox(top: 0.3634194373136477d,right: 0.613885476215698d,bottom: 0.24126519324130424d,left: 0.039240222447294304d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9720172301979131d,right: 0.9185736059257732d,bottom: 0.30256916206752704d,left: 0.34635041376157727d),
new NpgsqlTypes.NpgsqlBox(top: 0.46983132902897384d,right: 0.9009056567799841d,bottom: 0.14758593246790075d,left: 0.16185856056428694d),
new NpgsqlTypes.NpgsqlBox(top: 0.4920488246182365d,right: 0.8498829666597123d,bottom: 0.3374750373215081d,left: 0.49154504781965225d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 191,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8463166902679801d,right: 0.845194450093035d,bottom: 0.15545461678033268d,left: 0.7120027103100799d),
new NpgsqlTypes.NpgsqlBox(top: 0.9420857896805459d,right: 0.3979031170903149d,bottom: 0.5351535359894729d,left: 0.24667384676368787d),
new NpgsqlTypes.NpgsqlBox(top: 0.5997892738369094d,right: 0.978304524641599d,bottom: 0.46126803918878745d,left: 0.782064477174443d),
new NpgsqlTypes.NpgsqlBox(top: 0.1185481415472337d,right: 0.8635834136312099d,bottom: 0.11447629187075259d,left: 0.23355330942039843d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6571609087674184d,right: 0.9495202902256d,bottom: 0.4030845990813975d,left: 0.5154732193995311d),
new NpgsqlTypes.NpgsqlBox(top: 0.4405455023665227d,right: 0.9237579224698437d,bottom: 0.1515929149276637d,left: 0.7476614355366067d),
new NpgsqlTypes.NpgsqlBox(top: 0.6881059064575358d,right: 0.7053679488505267d,bottom: 0.6109588665602086d,left: 0.12470456438865618d),
new NpgsqlTypes.NpgsqlBox(top: 0.3722569152045526d,right: 0.4608970702741205d,bottom: 0.10805462980458724d,left: 0.20828852339878856d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 192,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6141075164032805d,right: 0.9649934149937647d,bottom: 0.5983596915529477d,left: 0.2576346923980666d),
new NpgsqlTypes.NpgsqlBox(top: 0.9618899476796464d,right: 0.720271307146438d,bottom: 0.8661755112618235d,left: 0.19070678620529335d),
new NpgsqlTypes.NpgsqlBox(top: 0.7960389886876705d,right: 0.9246345918909548d,bottom: 0.5055317449783127d,left: 0.634234694577531d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8889939146307503d,right: 0.5033410130270838d,bottom: 0.7269733448148413d,left: 0.256521716287222d),
new NpgsqlTypes.NpgsqlBox(top: 0.36718877132342387d,right: 0.12448340471656816d,bottom: 0.35559380765933857d,left: 0.1063369871386961d),
new NpgsqlTypes.NpgsqlBox(top: 0.3249749831661296d,right: 0.3012313960808658d,bottom: 0.23643216463528238d,left: 0.26417713100018936d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 140;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 81;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 91, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 146, query1, 179, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 144, query1, 178, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 159, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 91, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 48, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 176, query1, 178, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 159, 110))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 8, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 179);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[30], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[31], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[32], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[33], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

