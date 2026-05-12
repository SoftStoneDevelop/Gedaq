

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD1
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD1 : INpgsqlBoxMArrayboxMMArrayD1
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD1E1M[] _testData = new NpgsqlBoxboxMMArrayD1E1M[]
        {
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5458488022098726d,right: 0.5921228083739886d,bottom: 0.359457896991796d,left: 0.3310186748430415d),
new NpgsqlTypes.NpgsqlBox(top: 0.7389710813612498d,right: 0.5360557573619481d,bottom: 0.4217793822153145d,left: 0.2754338387801112d),
new NpgsqlTypes.NpgsqlBox(top: 0.8635563536744886d,right: 0.9981052216703356d,bottom: 0.7784301981591434d,left: 0.15116778770951156d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7199496045620235d,right: 0.7740862556278181d,bottom: 0.006388532143236758d,left: 0.04803940363365611d),
new NpgsqlTypes.NpgsqlBox(top: 0.4629861124409027d,right: 0.9244745964096517d,bottom: 0.2683962391377801d,left: 0.010308036933532994d),
new NpgsqlTypes.NpgsqlBox(top: 0.8582089227619247d,right: 0.8611314210201786d,bottom: 0.5299717257079275d,left: 0.403171496555351d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.325397050073001d,right: 0.5870292135502873d,bottom: 0.13311857537726013d,left: 0.3841667076992844d),
new NpgsqlTypes.NpgsqlBox(top: 0.993742032153541d,right: 0.8396956139811406d,bottom: 0.4342722858160595d,left: 0.15184370044547046d),
new NpgsqlTypes.NpgsqlBox(top: 0.5940771607499087d,right: 0.12224816994290577d,bottom: 0.32494012502792036d,left: 0.07783484896584103d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44809044392733d,right: 0.4872250699938716d,bottom: 0.3794788799218548d,left: 0.26515334974694116d),
new NpgsqlTypes.NpgsqlBox(top: 0.9512147794444957d,right: 0.35760711795481626d,bottom: 0.5435535877201045d,left: 0.23302358770523912d),
new NpgsqlTypes.NpgsqlBox(top: 0.8548770318028075d,right: 0.7255767449859301d,bottom: 0.4855372854179957d,left: 0.22113836523708186d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5809176850254042d,right: 0.7228728844261287d,bottom: 0.2694988419905868d,left: 0.3081616842585929d),
new NpgsqlTypes.NpgsqlBox(top: 0.2601139662868601d,right: 0.973257702033807d,bottom: 0.19280768434737694d,left: 0.7668023525015939d),
new NpgsqlTypes.NpgsqlBox(top: 0.7432835752436148d,right: 0.6628139769305769d,bottom: 0.5647700293506334d,left: 0.36940134935940216d),
new NpgsqlTypes.NpgsqlBox(top: 0.5852968502117704d,right: 0.7916291812932095d,bottom: 0.12526151260033835d,left: 0.5416261309380318d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5510286369654843d,right: 0.3371823617799603d,bottom: 0.11274136820171088d,left: 0.16921509078288732d),
new NpgsqlTypes.NpgsqlBox(top: 0.9551690676795571d,right: 0.8962079560701607d,bottom: 0.7580580483039437d,left: 0.6596599340392806d),
new NpgsqlTypes.NpgsqlBox(top: 0.7987219769524636d,right: 0.5603200697283764d,bottom: 0.6196318903965989d,left: 0.45174606789559146d),
new NpgsqlTypes.NpgsqlBox(top: 0.6643807452727876d,right: 0.6154190989674785d,bottom: 0.006172267480111127d,left: 0.2003631416425885d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6375072936277223d,right: 0.9222781090772448d,bottom: 0.5719263451435553d,left: 0.6317554181064003d),
new NpgsqlTypes.NpgsqlBox(top: 0.9145841440056616d,right: 0.5544230903262377d,bottom: 0.6734421900066647d,left: 0.19603062284557815d),
new NpgsqlTypes.NpgsqlBox(top: 0.5905814931200468d,right: 0.9942875371978224d,bottom: 0.3265702355320115d,left: 0.87524378156328d),
new NpgsqlTypes.NpgsqlBox(top: 0.4415672489067942d,right: 0.9836129212150145d,bottom: 0.10237223950848706d,left: 0.19955670463422748d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.705000380561489d,right: 0.42215244245456307d,bottom: 0.5297662951169615d,left: 0.15847360500032182d),
new NpgsqlTypes.NpgsqlBox(top: 0.9156577592146024d,right: 0.09837270183856728d,bottom: 0.6770973088644892d,left: 0.04570930308294874d),
new NpgsqlTypes.NpgsqlBox(top: 0.6749276381846308d,right: 0.5928545482039139d,bottom: 0.1483950231341412d,left: 0.10216839102901398d),
new NpgsqlTypes.NpgsqlBox(top: 0.373366650004593d,right: 0.34052566122821404d,bottom: 0.24458826585933147d,left: 0.19620074027383338d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.824820896938035d,right: 0.3579975531322793d,bottom: 0.5540053042584092d,left: 0.27050415980027664d),
new NpgsqlTypes.NpgsqlBox(top: 0.4429984033915756d,right: 0.3610827764896323d,bottom: 0.10762916596616368d,left: 0.29860928375440354d),
new NpgsqlTypes.NpgsqlBox(top: 0.42186437510380914d,right: 0.27962662169369346d,bottom: 0.41153281162073485d,left: 0.23407698974901558d),
new NpgsqlTypes.NpgsqlBox(top: 0.9538712096355769d,right: 0.5116744083586585d,bottom: 0.3702291249163904d,left: 0.00876272486739349d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.252214286309854d,right: 0.9023753903045173d,bottom: 0.05874003453483245d,left: 0.12268084470742158d),
new NpgsqlTypes.NpgsqlBox(top: 0.8825168876320467d,right: 0.9419870670152583d,bottom: 0.2875818668826079d,left: 0.8250611287304735d),
new NpgsqlTypes.NpgsqlBox(top: 0.24147172681996187d,right: 0.8700144207374767d,bottom: 0.019236696388640562d,left: 0.5547544794936842d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9899190218125423d,right: 0.27641525507496756d,bottom: 0.3149271321817515d,left: 0.14737249601839197d),
new NpgsqlTypes.NpgsqlBox(top: 0.7420972744900657d,right: 0.5981250993484296d,bottom: 0.4496025551621854d,left: 0.4307718624806891d),
new NpgsqlTypes.NpgsqlBox(top: 0.42501185549732756d,right: 0.732812823042052d,bottom: 0.17876963993611295d,left: 0.3911302534891511d),
new NpgsqlTypes.NpgsqlBox(top: 0.8639465768021776d,right: 0.4170607842669989d,bottom: 0.45948430532516726d,left: 0.3502615179446674d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.900283877485244d,right: 0.42119691374684465d,bottom: 0.4680204818777207d,left: 0.34647108805443205d),
new NpgsqlTypes.NpgsqlBox(top: 0.8743300127614541d,right: 0.7249741984681444d,bottom: 0.11369419361478517d,left: 0.5051992491745353d),
new NpgsqlTypes.NpgsqlBox(top: 0.3826404771442028d,right: 0.6907157754065855d,bottom: 0.2530329988962552d,left: 0.5425953208919614d),
new NpgsqlTypes.NpgsqlBox(top: 0.8309701225650918d,right: 0.5347675747362699d,bottom: 0.7978718323729507d,left: 0.1676204118441459d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7407185429476266d,right: 0.2828496279539222d,bottom: 0.34805331217864155d,left: 0.0393440494495616d),
new NpgsqlTypes.NpgsqlBox(top: 0.7445837269179449d,right: 0.9860731151981512d,bottom: 0.26833860025477896d,left: 0.3906979632196138d),
new NpgsqlTypes.NpgsqlBox(top: 0.34038538684849007d,right: 0.39313951238947065d,bottom: 0.3305101570848368d,left: 0.1064258752145989d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8556248468415872d,right: 0.5410662031283568d,bottom: 0.6096094265766945d,left: 0.2473972957065549d),
new NpgsqlTypes.NpgsqlBox(top: 0.20166790186353956d,right: 0.8674397836972615d,bottom: 0.09650507976653189d,left: 0.06432475488603984d),
new NpgsqlTypes.NpgsqlBox(top: 0.6235020914005249d,right: 0.6419291640428126d,bottom: 0.20570001725599674d,left: 0.018527072272800815d),
new NpgsqlTypes.NpgsqlBox(top: 0.7060628427084197d,right: 0.9605713117211839d,bottom: 0.46009042842648495d,left: 0.9334278237142948d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.13061557869693052d,right: 0.8690378534104778d,bottom: 0.10989507651673447d,left: 0.6621325190257952d),
new NpgsqlTypes.NpgsqlBox(top: 0.9604941508773462d,right: 0.31491684777679707d,bottom: 0.053115620672155806d,left: 0.12131837614773577d),
new NpgsqlTypes.NpgsqlBox(top: 0.6759752799665096d,right: 0.7274533327506989d,bottom: 0.27882188252579687d,left: 0.5235454587021223d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8321861695343388d,right: 0.638605063848007d,bottom: 0.1287427174875415d,left: 0.3577630054712311d),
new NpgsqlTypes.NpgsqlBox(top: 0.3134745013807745d,right: 0.7919913624385361d,bottom: 0.12389024686166172d,left: 0.2362672302533464d),
new NpgsqlTypes.NpgsqlBox(top: 0.6085576948201088d,right: 0.7901254737146536d,bottom: 0.31827457491923994d,left: 0.32151972547037644d),
new NpgsqlTypes.NpgsqlBox(top: 0.9331733078588039d,right: 0.720236499686156d,bottom: 0.6116577657628749d,left: 0.23336423141086104d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7908884335100507d,right: 0.8292908089066231d,bottom: 0.0008289219636647971d,left: 0.34476615027614166d),
new NpgsqlTypes.NpgsqlBox(top: 0.8077364313625269d,right: 0.7523772167198349d,bottom: 0.705144997885895d,left: 0.4429981226008295d),
new NpgsqlTypes.NpgsqlBox(top: 0.7278104392690092d,right: 0.8978016417686049d,bottom: 0.3102288736072608d,left: 0.5379414462255613d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.547539122810394d,right: 0.40924081838000215d,bottom: 0.5198405702039121d,left: 0.3832952213755352d),
new NpgsqlTypes.NpgsqlBox(top: 0.11844317947141503d,right: 0.23138698984601913d,bottom: 0.08420998909922905d,left: 0.10060108646757382d),
new NpgsqlTypes.NpgsqlBox(top: 0.7901994881899582d,right: 0.8242402810180366d,bottom: 0.5658082874138736d,left: 0.2911145642175931d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3449985425051848d,right: 0.8276622498718419d,bottom: 0.23472246182938927d,left: 0.266328120285374d),
new NpgsqlTypes.NpgsqlBox(top: 0.7906761500158285d,right: 0.1109395980295067d,bottom: 0.08273121389604854d,left: 0.06691602279842279d),
new NpgsqlTypes.NpgsqlBox(top: 0.8253798091759313d,right: 0.9546346021918114d,bottom: 0.45385982192133945d,left: 0.38974341890213404d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.27366402002401946d,right: 0.6062335071788423d,bottom: 0.110417919157348d,left: 0.33005852991932927d),
new NpgsqlTypes.NpgsqlBox(top: 0.6669188345894601d,right: 0.8409055323824287d,bottom: 0.21194070360359674d,left: 0.24143720134854463d),
new NpgsqlTypes.NpgsqlBox(top: 0.8655524059832214d,right: 0.5433897989716504d,bottom: 0.4562505062136831d,left: 0.5079294025359687d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6808790642560832d,right: 0.7688486237427554d,bottom: 0.488802517995639d,left: 0.42144121053118566d),
new NpgsqlTypes.NpgsqlBox(top: 0.7380345786777877d,right: 0.858539638439782d,bottom: 0.008085641247004949d,left: 0.09905011301836864d),
new NpgsqlTypes.NpgsqlBox(top: 0.6929667469511881d,right: 0.17852428822396804d,bottom: 0.007386308617252202d,left: 0.09937325739896585d),
new NpgsqlTypes.NpgsqlBox(top: 0.8922010471925778d,right: 0.8550675644865247d,bottom: 0.3257945098962902d,left: 0.8204723604397197d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9896157933545605d,right: 0.9518797068965251d,bottom: 0.589779810988199d,left: 0.1517051674340658d),
new NpgsqlTypes.NpgsqlBox(top: 0.5994454730939328d,right: 0.4095346446971625d,bottom: 0.20928045299238252d,left: 0.34940947609176143d),
new NpgsqlTypes.NpgsqlBox(top: 0.9973546546713781d,right: 0.6336614054820712d,bottom: 0.19088611060115757d,left: 0.24785175746824661d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30084042331490846d,right: 0.5496584062907844d,bottom: 0.006638604826655237d,left: 0.13055200391127442d),
new NpgsqlTypes.NpgsqlBox(top: 0.6269482798813579d,right: 0.6418330813254539d,bottom: 0.6143808292208871d,left: 0.07614626413888714d),
new NpgsqlTypes.NpgsqlBox(top: 0.8334269668814677d,right: 0.8227911845976502d,bottom: 0.7937122914589908d,left: 0.7412340301654715d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5050144388137844d,right: 0.7178412063315588d,bottom: 0.1408219505017222d,left: 0.030118264378576676d),
new NpgsqlTypes.NpgsqlBox(top: 0.939535834932533d,right: 0.5888099986192467d,bottom: 0.5914374181707864d,left: 0.41265269815258976d),
new NpgsqlTypes.NpgsqlBox(top: 0.9465399782258979d,right: 0.8783659843981815d,bottom: 0.590445897792967d,left: 0.7721373102011124d),
new NpgsqlTypes.NpgsqlBox(top: 0.7272388726402992d,right: 0.9612986250776526d,bottom: 0.10322689465585466d,left: 0.46749703174902024d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2555656554449086d,right: 0.9361562607613232d,bottom: 0.01735873001385546d,left: 0.34129092458174237d),
new NpgsqlTypes.NpgsqlBox(top: 0.9526428160682109d,right: 0.6712768326109068d,bottom: 0.6269182462704788d,left: 0.05710863656136811d),
new NpgsqlTypes.NpgsqlBox(top: 0.3217921275577097d,right: 0.39400687512965915d,bottom: 0.2929237500870724d,left: 0.015163672922933302d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6012209574298344d,right: 0.9657133686282338d,bottom: 0.16530169805734185d,left: 0.6112273226348104d),
new NpgsqlTypes.NpgsqlBox(top: 0.6542796829355481d,right: 0.9478527067535983d,bottom: 0.22815656140534757d,left: 0.665372961177279d),
new NpgsqlTypes.NpgsqlBox(top: 0.5338419448201249d,right: 0.6203542740262652d,bottom: 0.05675219061241121d,left: 0.13761041974848232d),
new NpgsqlTypes.NpgsqlBox(top: 0.5082249082952465d,right: 0.9674398204063083d,bottom: 0.4991684308264597d,left: 0.33630029456465105d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.944980285810242d,right: 0.8527145916655958d,bottom: 0.164747606451506d,left: 0.7341197524902011d),
new NpgsqlTypes.NpgsqlBox(top: 0.6017625418715514d,right: 0.8361967673831062d,bottom: 0.49462767813468766d,left: 0.5074416014238297d),
new NpgsqlTypes.NpgsqlBox(top: 0.14352791858064629d,right: 0.052826117176144605d,bottom: 0.12137812671019443d,left: 0.045827434961145386d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5931116189374597d,right: 0.7368635707000238d,bottom: 0.5447393397126472d,left: 0.01998164239831479d),
new NpgsqlTypes.NpgsqlBox(top: 0.928814572842965d,right: 0.6876925118082653d,bottom: 0.17298359220032666d,left: 0.0554045065831672d),
new NpgsqlTypes.NpgsqlBox(top: 0.8432481782836506d,right: 0.8352592014701332d,bottom: 0.5280440292207914d,left: 0.09941875300631198d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9121119348035094d,right: 0.5003124458479868d,bottom: 0.04070547690984361d,left: 0.344644855058426d),
new NpgsqlTypes.NpgsqlBox(top: 0.8638693025094537d,right: 0.35553109820652995d,bottom: 0.6486147582030465d,left: 0.17759951568560828d),
new NpgsqlTypes.NpgsqlBox(top: 0.8274664141753253d,right: 0.33283464766234483d,bottom: 0.7321656996187167d,left: 0.2536803631413459d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7416867887055925d,right: 0.6868688306406424d,bottom: 0.039441667076241194d,left: 0.09109719906209002d),
new NpgsqlTypes.NpgsqlBox(top: 0.916205341531503d,right: 0.7015742308387811d,bottom: 0.09283305998457847d,left: 0.20880597444997218d),
new NpgsqlTypes.NpgsqlBox(top: 0.7384031620853794d,right: 0.7442349294039751d,bottom: 0.17350481951443153d,left: 0.12968761832787412d),
new NpgsqlTypes.NpgsqlBox(top: 0.8122860379615113d,right: 0.939573357791747d,bottom: 0.25042773613987757d,left: 0.5305359405731368d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7685675881983914d,right: 0.861659711653146d,bottom: 0.4911176241985209d,left: 0.46782403834521946d),
new NpgsqlTypes.NpgsqlBox(top: 0.6896388930689161d,right: 0.40042718463461646d,bottom: 0.5497629858727432d,left: 0.14680317604320736d),
new NpgsqlTypes.NpgsqlBox(top: 0.8366553972430717d,right: 0.9010177495720447d,bottom: 0.19526275684865801d,left: 0.5208214820686653d),
new NpgsqlTypes.NpgsqlBox(top: 0.6245341254493179d,right: 0.34902589587096855d,bottom: 0.1276908384476706d,left: 0.2839977076715673d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8782955566915155d,right: 0.9040859538110064d,bottom: 0.48759567846899043d,left: 0.48965312316021403d),
new NpgsqlTypes.NpgsqlBox(top: 0.8859571019606899d,right: 0.9981329105458124d,bottom: 0.3600150565705257d,left: 0.7089668316232294d),
new NpgsqlTypes.NpgsqlBox(top: 0.8403878995928593d,right: 0.6416415124182575d,bottom: 0.246971129190381d,left: 0.20903601276750716d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49338886072246435d,right: 0.6203374954177718d,bottom: 0.14917280936021216d,left: 0.13461919726497784d),
new NpgsqlTypes.NpgsqlBox(top: 0.7996190488256066d,right: 0.21262698712800154d,bottom: 0.7876092140065231d,left: 0.016524159027318075d),
new NpgsqlTypes.NpgsqlBox(top: 0.7272222411142096d,right: 0.5480088425732084d,bottom: 0.10188676918221762d,left: 0.03679062883649198d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9620518116647954d,right: 0.8300605559644307d,bottom: 0.33517253234659794d,left: 0.7562105496403352d),
new NpgsqlTypes.NpgsqlBox(top: 0.682104374551772d,right: 0.8637679894190892d,bottom: 0.5328503868998968d,left: 0.7770939912646387d),
new NpgsqlTypes.NpgsqlBox(top: 0.6017881011453667d,right: 0.9902788568020638d,bottom: 0.04838626046501826d,left: 0.4765228446577081d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9432061716920217d,right: 0.8530450599246746d,bottom: 0.46769529643087127d,left: 0.7710820767940056d),
new NpgsqlTypes.NpgsqlBox(top: 0.4980173416788689d,right: 0.8864561207690808d,bottom: 0.42263254842983655d,left: 0.48705368913382585d),
new NpgsqlTypes.NpgsqlBox(top: 0.7134021475061608d,right: 0.40576166317396234d,bottom: 0.40321306526126566d,left: 0.241574439339433d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5447418745153811d,right: 0.6111152638518206d,bottom: 0.43179210138966995d,left: 0.19095505063043128d),
new NpgsqlTypes.NpgsqlBox(top: 0.9921582671707513d,right: 0.4268419372397799d,bottom: 0.012840509144918744d,left: 0.11944380488823414d),
new NpgsqlTypes.NpgsqlBox(top: 0.8102053448601959d,right: 0.4367257439602984d,bottom: 0.7216449648358679d,left: 0.15224881934175383d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6725727851422264d,right: 0.20677344454017788d,bottom: 0.2232657860776568d,left: 0.1730082644040507d),
new NpgsqlTypes.NpgsqlBox(top: 0.6112588066369661d,right: 0.6653022993769072d,bottom: 0.5761698028035456d,left: 0.03667116826906114d),
new NpgsqlTypes.NpgsqlBox(top: 0.05982929494421507d,right: 0.9044709876492975d,bottom: 0.0516792674550518d,left: 0.5241282159012726d),
new NpgsqlTypes.NpgsqlBox(top: 0.2981479389630197d,right: 0.5139446285501227d,bottom: 0.09753019839458765d,left: 0.33153590834106605d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8846623396181007d,right: 0.9888797891587564d,bottom: 0.378792648374916d,left: 0.7372817915735543d),
new NpgsqlTypes.NpgsqlBox(top: 0.721457607517752d,right: 0.8675056673560195d,bottom: 0.1640149392820337d,left: 0.008427273147985859d),
new NpgsqlTypes.NpgsqlBox(top: 0.9653900104704675d,right: 0.9009856189008977d,bottom: 0.018011965353465276d,left: 0.3625761246264845d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8297017267067466d,right: 0.5908419060861503d,bottom: 0.2072277789126069d,left: 0.16359218041738532d),
new NpgsqlTypes.NpgsqlBox(top: 0.7271668591421528d,right: 0.8728882839645264d,bottom: 0.2972963372307501d,left: 0.8173779872811182d),
new NpgsqlTypes.NpgsqlBox(top: 0.6738784388393044d,right: 0.16101094133166238d,bottom: 0.5117475457629772d,left: 0.1367770429237546d),
new NpgsqlTypes.NpgsqlBox(top: 0.5878608696254315d,right: 0.8051254313561975d,bottom: 0.4224032076611808d,left: 0.6963084627581104d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8929709994888648d,right: 0.7471545165147007d,bottom: 0.4302135651557454d,left: 0.4587823525412589d),
new NpgsqlTypes.NpgsqlBox(top: 0.5870895868895912d,right: 0.3489480580747433d,bottom: 0.2261212979501961d,left: 0.1272605717487837d),
new NpgsqlTypes.NpgsqlBox(top: 0.5531971013741943d,right: 0.8969483086626602d,bottom: 0.3213697591528294d,left: 0.8747278132142317d),
new NpgsqlTypes.NpgsqlBox(top: 0.8326011717266057d,right: 0.6220373245338369d,bottom: 0.30759381803971564d,left: 0.4362145447992505d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8462173391411468d,right: 0.3469556899841616d,bottom: 0.3071528698326551d,left: 0.08969827864895752d),
new NpgsqlTypes.NpgsqlBox(top: 0.8792385513661907d,right: 0.28212330410218034d,bottom: 0.0552750212410722d,left: 0.017844748115541154d),
new NpgsqlTypes.NpgsqlBox(top: 0.21906113888413759d,right: 0.9650006548131514d,bottom: 0.035861939059711134d,left: 0.04384832710257691d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6788376954611812d,right: 0.5850805754019844d,bottom: 0.31530537762785527d,left: 0.4738750372366737d),
new NpgsqlTypes.NpgsqlBox(top: 0.34763380060315685d,right: 0.8705132332257692d,bottom: 0.24805857390085162d,left: 0.6044798256704416d),
new NpgsqlTypes.NpgsqlBox(top: 0.87155450221082d,right: 0.8358387672600586d,bottom: 0.36179803320048354d,left: 0.624161450429348d),
new NpgsqlTypes.NpgsqlBox(top: 0.49060501903811415d,right: 0.7625111997130337d,bottom: 0.04884772187135333d,left: 0.27026431035641374d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.543275763871469d,right: 0.9566837548642436d,bottom: 0.5218588533598802d,left: 0.30798168232845236d),
new NpgsqlTypes.NpgsqlBox(top: 0.9420492656679209d,right: 0.783568877473739d,bottom: 0.6847170303568294d,left: 0.3074307986124286d),
new NpgsqlTypes.NpgsqlBox(top: 0.7747551628472541d,right: 0.3772270370037335d,bottom: 0.24445742953372807d,left: 0.07730786976920245d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1307981976049769d,right: 0.9737619637298237d,bottom: 0.0019174066404443746d,left: 0.46928419112244313d),
new NpgsqlTypes.NpgsqlBox(top: 0.6246880255509853d,right: 0.2304798631129379d,bottom: 0.5858428172747875d,left: 0.056611666777347525d),
new NpgsqlTypes.NpgsqlBox(top: 0.9290445367075048d,right: 0.7147678979324938d,bottom: 0.8825439179090233d,left: 0.6853849991247267d),
new NpgsqlTypes.NpgsqlBox(top: 0.5521086938641626d,right: 0.5585099871269676d,bottom: 0.07447866968437733d,left: 0.010917612630631846d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6089329109734256d,right: 0.4897031964937304d,bottom: 0.0438053016686466d,left: 0.2797748414020276d),
new NpgsqlTypes.NpgsqlBox(top: 0.2817956520062931d,right: 0.8318687255304483d,bottom: 0.1121531148564806d,left: 0.6964932625459586d),
new NpgsqlTypes.NpgsqlBox(top: 0.695831854409697d,right: 0.47869201007264517d,bottom: 0.6729881778540225d,left: 0.00186873583022662d),
new NpgsqlTypes.NpgsqlBox(top: 0.8618171115205673d,right: 0.5670983306007039d,bottom: 0.08608429315378652d,left: 0.19991191679400444d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9163022773321445d,right: 0.9579095541541451d,bottom: 0.36501106582782206d,left: 0.2894543850562661d),
new NpgsqlTypes.NpgsqlBox(top: 0.43560040407937395d,right: 0.9855408679139392d,bottom: 0.24117783096273748d,left: 0.6158724837198485d),
new NpgsqlTypes.NpgsqlBox(top: 0.97914496095335d,right: 0.871839893494358d,bottom: 0.4115059994003314d,left: 0.3500339648443992d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5037108592177396d,right: 0.8871501451724999d,bottom: 0.10047198916007805d,left: 0.5393960841271898d),
new NpgsqlTypes.NpgsqlBox(top: 0.5446756959714573d,right: 0.8340201250476439d,bottom: 0.3705352041005684d,left: 0.8325426618226298d),
new NpgsqlTypes.NpgsqlBox(top: 0.2589701156625487d,right: 0.7182042152013559d,bottom: 0.13288700703429668d,left: 0.6208194790581051d),
new NpgsqlTypes.NpgsqlBox(top: 0.47257163411336855d,right: 0.3525338721786606d,bottom: 0.3208515264824716d,left: 0.05935592629036679d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8852520259418564d,right: 0.5657363859802667d,bottom: 0.8100734170908792d,left: 0.27112421082843885d),
new NpgsqlTypes.NpgsqlBox(top: 0.9165960756421383d,right: 0.9674732441869399d,bottom: 0.3703075297460995d,left: 0.09122884145897803d),
new NpgsqlTypes.NpgsqlBox(top: 0.9225802772959011d,right: 0.1417969050564296d,bottom: 0.21193838303522383d,left: 0.09706383867080604d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7633241298674978d,right: 0.32765394536738446d,bottom: 0.12256391354625862d,left: 0.004875121827398576d),
new NpgsqlTypes.NpgsqlBox(top: 0.25684360653262917d,right: 0.4116242998636763d,bottom: 0.25466846181166924d,left: 0.2116723296499362d),
new NpgsqlTypes.NpgsqlBox(top: 0.7662131871695992d,right: 0.5183928840268945d,bottom: 0.7085588527299709d,left: 0.20293329925936088d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.979967192565183d,right: 0.985250500726763d,bottom: 0.3018297674049034d,left: 0.32972916738797364d),
new NpgsqlTypes.NpgsqlBox(top: 0.19280857267902896d,right: 0.7801838784950557d,bottom: 0.10415482705906787d,left: 0.5466020670670233d),
new NpgsqlTypes.NpgsqlBox(top: 0.6867116786489149d,right: 0.620691849495639d,bottom: 0.11676227662975047d,left: 0.2624704916735817d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3299760922946178d,right: 0.94813532642101d,bottom: 0.13909547809968503d,left: 0.9242930961248574d),
new NpgsqlTypes.NpgsqlBox(top: 0.9014517141429305d,right: 0.6984767218809966d,bottom: 0.3541077359618331d,left: 0.6519189366095447d),
new NpgsqlTypes.NpgsqlBox(top: 0.9640880502089935d,right: 0.9355372159217376d,bottom: 0.905298814828724d,left: 0.4815114096961274d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2003851489460522d,right: 0.6213768636912849d,bottom: 0.075801524144254d,left: 0.19351454512883592d),
new NpgsqlTypes.NpgsqlBox(top: 0.0587069361842929d,right: 0.1943893413165102d,bottom: 0.016002650900350912d,left: 0.11155331881574937d),
new NpgsqlTypes.NpgsqlBox(top: 0.7271708309823904d,right: 0.5892042999216425d,bottom: 0.607086478040237d,left: 0.33764163047782114d),
new NpgsqlTypes.NpgsqlBox(top: 0.42941843090381504d,right: 0.8172830519935725d,bottom: 0.34556485277144877d,left: 0.524344758535896d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6088825050292842d,right: 0.6449204042780498d,bottom: 0.5221667562308704d,left: 0.08365172539420951d),
new NpgsqlTypes.NpgsqlBox(top: 0.8967313574817569d,right: 0.3218700384879939d,bottom: 0.5948349969160457d,left: 0.1539428357253988d),
new NpgsqlTypes.NpgsqlBox(top: 0.4065564220256702d,right: 0.7534326629371993d,bottom: 0.33991698329611575d,left: 0.4461063940257114d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8841499655124577d,right: 0.2737790699743573d,bottom: 0.30611574727772783d,left: 0.07615123592647255d),
new NpgsqlTypes.NpgsqlBox(top: 0.773887055965799d,right: 0.7186428001186214d,bottom: 0.5780433473785901d,left: 0.2833067174052364d),
new NpgsqlTypes.NpgsqlBox(top: 0.3597139727271418d,right: 0.7183591202040476d,bottom: 0.23578722997011103d,left: 0.5039706402469921d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5832605202024634d,right: 0.6630072768931065d,bottom: 0.28808096795379357d,left: 0.5361163838822619d),
new NpgsqlTypes.NpgsqlBox(top: 0.7402863183382065d,right: 0.6252090907976513d,bottom: 0.6717161297158898d,left: 0.3482724722323126d),
new NpgsqlTypes.NpgsqlBox(top: 0.6813629520508937d,right: 0.7979180533383673d,bottom: 0.0005552212421395808d,left: 0.7163539776074114d),
new NpgsqlTypes.NpgsqlBox(top: 0.6089170794149925d,right: 0.656436533437176d,bottom: 0.35146648154179627d,left: 0.2064326987571773d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9918114896365607d,right: 0.8962538143377425d,bottom: 0.5729984224786151d,left: 0.8701207695053661d),
new NpgsqlTypes.NpgsqlBox(top: 0.9257438580816324d,right: 0.8514588761748265d,bottom: 0.40240680293112685d,left: 0.18646585705837693d),
new NpgsqlTypes.NpgsqlBox(top: 0.8051302503919744d,right: 0.24104058024807906d,bottom: 0.29558162753987927d,left: 0.08116586513855295d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5753472461480538d,right: 0.9981201164299811d,bottom: 0.13503341523662804d,left: 0.08976107189588678d),
new NpgsqlTypes.NpgsqlBox(top: 0.3803287235273092d,right: 0.12007955351594113d,bottom: 0.02161641308364437d,left: 0.009416672400677895d),
new NpgsqlTypes.NpgsqlBox(top: 0.8571216806737961d,right: 0.9562869695440446d,bottom: 0.27525972076017846d,left: 0.19375474619012434d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7732363615067391d,right: 0.4116598183179082d,bottom: 0.17827106213415478d,left: 0.3440086862363232d),
new NpgsqlTypes.NpgsqlBox(top: 0.14581232408366307d,right: 0.5369415416643429d,bottom: 0.1347152358858097d,left: 0.20190605527622096d),
new NpgsqlTypes.NpgsqlBox(top: 0.49885328907422943d,right: 0.4105580102683033d,bottom: 0.16229346970480507d,left: 0.02721119214212775d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5413481654415314d,right: 0.5349900183436541d,bottom: 0.46156454274014747d,left: 0.20229552920233884d),
new NpgsqlTypes.NpgsqlBox(top: 0.755992505789056d,right: 0.9772155950906644d,bottom: 0.5737429015319463d,left: 0.0008342089562012323d),
new NpgsqlTypes.NpgsqlBox(top: 0.7458313917163333d,right: 0.8013961493578764d,bottom: 0.26831731111911117d,left: 0.5687980220848844d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6634426788259984d,right: 0.7586651257734058d,bottom: 0.03346450212696905d,left: 0.1865357617655501d),
new NpgsqlTypes.NpgsqlBox(top: 0.6143945569963044d,right: 0.29254089320765875d,bottom: 0.30103764505031705d,left: 0.10045742808231417d),
new NpgsqlTypes.NpgsqlBox(top: 0.44340737201572067d,right: 0.9389249529807119d,bottom: 0.20989714452649078d,left: 0.1376439904845126d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.496816741151748d,right: 0.6464919857645643d,bottom: 0.2117958093736707d,left: 0.2641379009507243d),
new NpgsqlTypes.NpgsqlBox(top: 0.21947741745373028d,right: 0.9973973118456422d,bottom: 0.12035320033492614d,left: 0.9907723506655896d),
new NpgsqlTypes.NpgsqlBox(top: 0.2623004426375405d,right: 0.6154331199152234d,bottom: 0.023984815975233054d,left: 0.23769469182389058d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32924486065430847d,right: 0.9961312243993534d,bottom: 0.2513693804674517d,left: 0.9755070645427568d),
new NpgsqlTypes.NpgsqlBox(top: 0.9790482096532516d,right: 0.9204092038201119d,bottom: 0.17279191023797202d,left: 0.5981433872438123d),
new NpgsqlTypes.NpgsqlBox(top: 0.2446431545554716d,right: 0.8972939724247961d,bottom: 0.01901450099650137d,left: 0.7826434768905958d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8343185553941137d,right: 0.5523067396579894d,bottom: 0.7897928091835938d,left: 0.21327265789371397d),
new NpgsqlTypes.NpgsqlBox(top: 0.7498343992713667d,right: 0.8362023913413933d,bottom: 0.3410872248558626d,left: 0.04560262157146411d),
new NpgsqlTypes.NpgsqlBox(top: 0.8430690983481746d,right: 0.9628231887478942d,bottom: 0.014047825831595362d,left: 0.7021673531168695d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.889911067391543d,right: 0.7203101863940233d,bottom: 0.4547660336696395d,left: 0.19465399820992746d),
new NpgsqlTypes.NpgsqlBox(top: 0.4269383404029431d,right: 0.7746244335488559d,bottom: 0.24306730476329608d,left: 0.16763825900713436d),
new NpgsqlTypes.NpgsqlBox(top: 0.3416177603883179d,right: 0.4479226694640046d,bottom: 0.17466919351149068d,left: 0.10522793531951136d),
new NpgsqlTypes.NpgsqlBox(top: 0.965001819740883d,right: 0.44870305366277385d,bottom: 0.7894321593531346d,left: 0.17013322812290677d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9815075572577358d,right: 0.930862613584656d,bottom: 0.08161607751728384d,left: 0.19990624013304792d),
new NpgsqlTypes.NpgsqlBox(top: 0.8488055174666832d,right: 0.5840836470931459d,bottom: 0.22033518369213567d,left: 0.3723226959817041d),
new NpgsqlTypes.NpgsqlBox(top: 0.914015404610334d,right: 0.7449414642314247d,bottom: 0.5686058789706405d,left: 0.15796396107385102d),
new NpgsqlTypes.NpgsqlBox(top: 0.8809350428590983d,right: 0.967353277973641d,bottom: 0.09766884387214392d,left: 0.3182050302215391d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5931512306234888d,right: 0.31602732785411414d,bottom: 0.03676634933209544d,left: 0.1995740617031707d),
new NpgsqlTypes.NpgsqlBox(top: 0.5800826567937499d,right: 0.802637869026962d,bottom: 0.035926691129011146d,left: 0.1832946652497981d),
new NpgsqlTypes.NpgsqlBox(top: 0.9879123046073293d,right: 0.7418520217386019d,bottom: 0.579703623363228d,left: 0.053916918214034215d),
new NpgsqlTypes.NpgsqlBox(top: 0.8126324873939226d,right: 0.49643732666430873d,bottom: 0.5773134884390353d,left: 0.13521398766824289d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.704498442140951d,right: 0.9317025344254493d,bottom: 0.0802199646805305d,left: 0.05950109604347087d),
new NpgsqlTypes.NpgsqlBox(top: 0.584145942454561d,right: 0.9915904504623793d,bottom: 0.022463680611945258d,left: 0.5752260890567845d),
new NpgsqlTypes.NpgsqlBox(top: 0.7284059684544308d,right: 0.8819601690087755d,bottom: 0.2063632978100125d,left: 0.43291500435860253d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6855981375266638d,right: 0.9498397298944037d,bottom: 0.19497342734892398d,left: 0.2601774878476335d),
new NpgsqlTypes.NpgsqlBox(top: 0.34859812607034724d,right: 0.873494748382519d,bottom: 0.13623835877979673d,left: 0.05194096908131274d),
new NpgsqlTypes.NpgsqlBox(top: 0.8044914280702077d,right: 0.29646371552686257d,bottom: 0.10026084024840931d,left: 0.1465526660461236d),
new NpgsqlTypes.NpgsqlBox(top: 0.8883690003579329d,right: 0.9002022148374259d,bottom: 0.40109307546195594d,left: 0.43176719676062825d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6420963732923369d,right: 0.1657719803380464d,bottom: 0.6046329037288206d,left: 0.14380790579130198d),
new NpgsqlTypes.NpgsqlBox(top: 0.6547376437846774d,right: 0.6017581988724056d,bottom: 0.38439825447059417d,left: 0.5777938895759482d),
new NpgsqlTypes.NpgsqlBox(top: 0.516814104806198d,right: 0.585650519199219d,bottom: 0.2325791511733576d,left: 0.4119935785252208d),
new NpgsqlTypes.NpgsqlBox(top: 0.6897729112143993d,right: 0.9216026409201646d,bottom: 0.3666782032377549d,left: 0.8715058440711411d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9914017660093011d,right: 0.34159737427783254d,bottom: 0.10486977636103334d,left: 0.19355430779261007d),
new NpgsqlTypes.NpgsqlBox(top: 0.9582720401778783d,right: 0.7405170412485766d,bottom: 0.6885065870851909d,left: 0.30456380508668635d),
new NpgsqlTypes.NpgsqlBox(top: 0.7273995401358687d,right: 0.11851247091150807d,bottom: 0.016637950748935593d,left: 0.06059761904038141d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7769797005286119d,right: 0.6753689623720759d,bottom: 0.34888887693956583d,left: 0.006026123894685598d),
new NpgsqlTypes.NpgsqlBox(top: 0.5471638161437786d,right: 0.7322003256707307d,bottom: 0.4380631025258662d,left: 0.016638934481712164d),
new NpgsqlTypes.NpgsqlBox(top: 0.7984894469060683d,right: 0.7851697038539058d,bottom: 0.057995736851061075d,left: 0.14185984292129838d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7249032834327385d,right: 0.9491173443954255d,bottom: 0.13062221831839704d,left: 0.6315291472799077d),
new NpgsqlTypes.NpgsqlBox(top: 0.6326719376536315d,right: 0.833023953882591d,bottom: 0.4849499715172664d,left: 0.7373638183368285d),
new NpgsqlTypes.NpgsqlBox(top: 0.2793318641668886d,right: 0.7719164498782103d,bottom: 0.12673655129877703d,left: 0.3846671326165958d),
new NpgsqlTypes.NpgsqlBox(top: 0.7454067393416061d,right: 0.5957010149030016d,bottom: 0.6409275876757123d,left: 0.519270587513922d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6438261955176537d,right: 0.3017418246050726d,bottom: 0.36722078395806323d,left: 0.15955771938754482d),
new NpgsqlTypes.NpgsqlBox(top: 0.7594404216304005d,right: 0.7423100417701134d,bottom: 0.48069661265099406d,left: 0.6355931110968944d),
new NpgsqlTypes.NpgsqlBox(top: 0.7645811419059125d,right: 0.23708070125985992d,bottom: 0.7409480272100581d,left: 0.20182000732854255d),
new NpgsqlTypes.NpgsqlBox(top: 0.9940726572169165d,right: 0.7466410184021216d,bottom: 0.9170500034999192d,left: 0.08023865998246404d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7193320409594532d,right: 0.874953245832304d,bottom: 0.5096326772459786d,left: 0.3204220128374522d),
new NpgsqlTypes.NpgsqlBox(top: 0.5059996633422826d,right: 0.5264636661052412d,bottom: 0.10222883364873725d,left: 0.05154469868439826d),
new NpgsqlTypes.NpgsqlBox(top: 0.9308165918394968d,right: 0.4581780956958129d,bottom: 0.9307449722494723d,left: 0.031087253305371987d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8677753002222313d,right: 0.5409301475560349d,bottom: 0.11003293850227047d,left: 0.38181759568215035d),
new NpgsqlTypes.NpgsqlBox(top: 0.29029767996925815d,right: 0.46433548318504614d,bottom: 0.22702920100779433d,left: 0.43072592399792675d),
new NpgsqlTypes.NpgsqlBox(top: 0.39173639958859474d,right: 0.8154751420131168d,bottom: 0.30072686272888705d,left: 0.1698727075230423d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6404408915339225d,right: 0.9754926905099272d,bottom: 0.18263841213098064d,left: 0.7522593899716014d),
new NpgsqlTypes.NpgsqlBox(top: 0.9904230601069348d,right: 0.9760545360858521d,bottom: 0.07055755800426355d,left: 0.41209093503459304d),
new NpgsqlTypes.NpgsqlBox(top: 0.6231773873301661d,right: 0.3861718424059455d,bottom: 0.159138233915062d,left: 0.2751333414563566d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6746472146798091d,right: 0.5468943578415154d,bottom: 0.2097037405706469d,left: 0.054117800662040416d),
new NpgsqlTypes.NpgsqlBox(top: 0.6069180890583113d,right: 0.7316430404802473d,bottom: 0.009147422365823665d,left: 0.20951860441057013d),
new NpgsqlTypes.NpgsqlBox(top: 0.5028198834864194d,right: 0.844238940129553d,bottom: 0.01114063413737465d,left: 0.017956301911597472d),
new NpgsqlTypes.NpgsqlBox(top: 0.48109306510914573d,right: 0.8931817812219037d,bottom: 0.44523924941892823d,left: 0.46763433192577053d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)), 
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
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.900283877485244d,right: 0.42119691374684465d,bottom: 0.4680204818777207d,left: 0.34647108805443205d),
new NpgsqlTypes.NpgsqlBox(top: 0.8743300127614541d,right: 0.7249741984681444d,bottom: 0.11369419361478517d,left: 0.5051992491745353d),
new NpgsqlTypes.NpgsqlBox(top: 0.3826404771442028d,right: 0.6907157754065855d,bottom: 0.2530329988962552d,left: 0.5425953208919614d),
new NpgsqlTypes.NpgsqlBox(top: 0.8309701225650918d,right: 0.5347675747362699d,bottom: 0.7978718323729507d,left: 0.1676204118441459d),
}));
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8321861695343388d,right: 0.638605063848007d,bottom: 0.1287427174875415d,left: 0.3577630054712311d),
new NpgsqlTypes.NpgsqlBox(top: 0.3134745013807745d,right: 0.7919913624385361d,bottom: 0.12389024686166172d,left: 0.2362672302533464d),
new NpgsqlTypes.NpgsqlBox(top: 0.6085576948201088d,right: 0.7901254737146536d,bottom: 0.31827457491923994d,left: 0.32151972547037644d),
new NpgsqlTypes.NpgsqlBox(top: 0.9331733078588039d,right: 0.720236499686156d,bottom: 0.6116577657628749d,left: 0.23336423141086104d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 12;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 11, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 21, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 81, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 142, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
FROM public.binary_npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI), typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

