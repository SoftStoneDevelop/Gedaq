

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
    internal partial interface INpgsqlCircleMArraycircleMArrayD2
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMArrayD2 : INpgsqlCircleMArraycircleMArrayD2
    {


#region TestData

        private readonly NpgsqlCirclecircleMArrayD2E1M[] _testData = new NpgsqlCirclecircleMArrayD2E1M[]
        {
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7714886986556915d, y: 0.10076118617958485d), radius: 0.6870535353466886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03716441641182655d, y: 0.013474983097888416d), radius: 0.4999368664397895d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27622019561542166d, y: 0.7983948660095653d), radius: 0.006860541895027605d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5167600743306797d, y: 0.11970094006195309d), radius: 0.8865123075473085d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.017522626200358382d, y: 0.9900100862140885d), radius: 0.22916130198611762d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3537909354097778d, y: 0.2430812012808511d), radius: 0.2870607774360744d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6357925077713422d, y: 0.588037688282839d), radius: 0.6866761863302304d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8010848781623011d, y: 0.7618763486608717d), radius: 0.36930273537070935d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.789021960379532d, y: 0.02836904421699782d), radius: 0.1867443958389312d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.399555208061677d, y: 0.776731341438897d), radius: 0.10481586007755572d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.818227417889712d, y: 0.2403523299589363d), radius: 0.19848386373481974d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9509111599639019d, y: 0.9030939302819673d), radius: 0.06442006384074506d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23903382076672997d, y: 0.6498362132557257d), radius: 0.14064373055726997d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3214670860924218d, y: 0.5169011501973192d), radius: 0.3961029254345648d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7967380803764986d, y: 0.9705359387024467d), radius: 0.5594152505430339d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8439426981630177d, y: 0.3690375538585795d), radius: 0.9795571837779867d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4261235916578565d, y: 0.2705057037716938d), radius: 0.3928205990865262d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15748978535792513d, y: 0.11612217558865212d), radius: 0.07780807527866784d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6857572365704497d, y: 0.28610160043585176d), radius: 0.8158137087351106d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4879585000074941d, y: 0.6406323285078722d), radius: 0.9813232311457051d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15771561463628603d, y: 0.4710705798282606d), radius: 0.3437461977905627d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13907224488818226d, y: 0.9057609895387776d), radius: 0.8025107000435876d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9902443885324682d, y: 0.6686038617474117d), radius: 0.37708245305520494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4024985201226797d, y: 0.9666953252673924d), radius: 0.15658093670673412d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19435948320901641d, y: 0.8953147900718833d), radius: 0.614373288350566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4855922804160354d, y: 0.5591140820825915d), radius: 0.6991001812307032d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.052804211553155955d, y: 0.025122126306473147d), radius: 0.861724666785734d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06915470808304913d, y: 0.028644599964480433d), radius: 0.9906920390801573d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.046061808231657286d, y: 0.15639956933072363d), radius: 0.8610837010236834d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21899778441427387d, y: 0.90836223963928d), radius: 0.24817053557685043d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4013083386854569d, y: 0.8680749330047601d), radius: 0.07260390441823927d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040501140264465274d, y: 0.36237228551244105d), radius: 0.39121843167547843d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8811956449113441d, y: 0.8873361452379613d), radius: 0.08315678115709357d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5291999321169495d, y: 0.887781339810808d), radius: 0.21502044121113917d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11169027292941636d, y: 0.762484745858952d), radius: 0.008749648572962454d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1645338744084911d, y: 0.7498208577734196d), radius: 0.49871834556818917d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.846398749306849d, y: 0.39267517140453645d), radius: 0.8792838232917942d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6722539565810602d, y: 0.5864369635431925d), radius: 0.34067244245318606d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05409754484122453d, y: 0.34732551026133474d), radius: 0.7777364378365956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7699089974357047d, y: 0.1300671008779991d), radius: 0.44612515635477445d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14083596445171576d, y: 0.14057336678090449d), radius: 0.9880770151483865d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04190883732519812d, y: 0.8611116819120394d), radius: 0.26457552187206035d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6839295772539975d, y: 0.6551358727372858d), radius: 0.6511036788199833d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8669543499151073d, y: 0.7635237785968159d), radius: 0.416958145208851d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6987477185110723d, y: 0.6786334872069186d), radius: 0.07462867610715418d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5366947715320194d, y: 0.022608293970309723d), radius: 0.3266349918581223d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7849884733272658d, y: 0.5969558651440839d), radius: 0.4658131283850996d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18450529151680406d, y: 0.8905868318669189d), radius: 0.37080981665690915d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8290194367142205d, y: 0.8297633320784595d), radius: 0.5258787214077829d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.029434988483966418d, y: 0.7900345692081228d), radius: 0.6515527152012396d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10012047117784251d, y: 0.6485533457405628d), radius: 0.5053029699976865d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17309079991691467d, y: 0.46238203245743226d), radius: 0.6372297527260508d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.912905601418049d, y: 0.4339818527803232d), radius: 0.5342337361913275d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5250515318442869d, y: 0.9114936931053284d), radius: 0.7612891311357349d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9180724591580312d, y: 0.16790264468368676d), radius: 0.5382096888354241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.689443216571572d, y: 0.15349235275374573d), radius: 0.2384863843165368d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18720222861516445d, y: 0.9373398071187536d), radius: 0.8887392993202221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9884395728784191d, y: 0.13356415121326837d), radius: 0.39139336491847065d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18639048073662445d, y: 0.7911015254967876d), radius: 0.629630565637134d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6103109829486845d, y: 0.022773614469574266d), radius: 0.7497121518989085d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3376364467278292d, y: 0.6514439359524563d), radius: 0.6353323318179306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4174027203961156d, y: 0.05536659977174996d), radius: 0.3050352130708911d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32072192003345246d, y: 0.8103014001963051d), radius: 0.20494993888568802d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7716550659078687d, y: 0.7819056675422539d), radius: 0.688603934418891d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9407168104030431d, y: 0.03590871355137626d), radius: 0.23449052938672688d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4566424539717234d, y: 0.6193550223052499d), radius: 0.10570527311657008d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.182893502836311d, y: 0.48375520320447674d), radius: 0.9180141605432878d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.636239840737284d, y: 0.10002482052084494d), radius: 0.6001793935677636d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33656850851467435d, y: 0.14037116199197974d), radius: 0.6598769331552052d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08911686080350067d, y: 0.09405547478441556d), radius: 0.296358892439724d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8760430288308918d, y: 0.689764557792208d), radius: 0.9437835081530231d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5579923686217475d, y: 0.8798451390605929d), radius: 0.7081414435876163d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5075969133372423d, y: 0.9860661342375265d), radius: 0.7614655775794763d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9428712050803076d, y: 0.8760595258420528d), radius: 0.31772679797200154d), } },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7997390085738447d, y: 0.29273302348651575d), radius: 0.9657249280507582d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45398769796311156d, y: 0.7923206880971049d), radius: 0.5086451847623132d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39798806780025575d, y: 0.9298917347915168d), radius: 0.9953847356561636d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6480020624045005d, y: 0.5480648719236263d), radius: 0.06465892851081778d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2320304843653811d, y: 0.3911299108746086d), radius: 0.03009704085971865d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8841417675779281d, y: 0.7327620769987758d), radius: 0.042966400565818574d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30540291554681187d, y: 0.20606906759374344d), radius: 0.42948215571757176d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46636513496587473d, y: 0.9936213992892418d), radius: 0.47633712379031323d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048255105291628464d, y: 0.9382086279371434d), radius: 0.355113225759226d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7164453578534393d, y: 0.8039315166378046d), radius: 0.46866823240973743d), } },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9033231990030749d, y: 0.012984880486726746d), radius: 0.5715231739648033d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1984311358081493d, y: 0.886675084515035d), radius: 0.7663788240545862d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6421349834502618d, y: 0.3520037343055167d), radius: 0.6135120841046158d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46681012902634633d, y: 0.5054497846646615d), radius: 0.9624234977838608d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028907966543342156d, y: 0.530249507209085d), radius: 0.47016950271231017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10532864511498008d, y: 0.7108617985404172d), radius: 0.010263623765236818d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7960156325692537d, y: 0.04780143982406693d), radius: 0.261547780251028d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9894147747313949d, y: 0.31424916592014973d), radius: 0.023317703774578313d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7665823735819435d, y: 0.5454547835908844d), radius: 0.20672476761363856d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1178843057874629d, y: 0.7925918936518419d), radius: 0.5290690637526115d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8027777550824248d, y: 0.33460316480725405d), radius: 0.48092689455658255d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6624519180053732d, y: 0.8027908357113313d), radius: 0.2697771573684926d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6132877538627802d, y: 0.7515552941409901d), radius: 0.9837216437891217d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6773725932515535d, y: 0.8418040941234379d), radius: 0.6312135007566777d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8651433272891333d, y: 0.30659013264313484d), radius: 0.6524380572770214d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1553063002609616d, y: 0.7755288302443857d), radius: 0.4734877416396185d), } },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2677103733839321d, y: 0.5336279942863306d), radius: 0.054075845748544515d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5806077088272634d, y: 0.9120510145432713d), radius: 0.008097864476883654d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8953514806692783d, y: 0.7014388133506448d), radius: 0.40541692828483245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1897917818082605d, y: 0.3284195902830326d), radius: 0.26406960054214845d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5768701537150449d, y: 0.08853349108078801d), radius: 0.33808903045682714d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48540268180618285d, y: 0.08331549907330893d), radius: 0.45246382123523965d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47421370198133983d, y: 0.5782197911083832d), radius: 0.43911051305022186d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33799957704374006d, y: 0.22003332700468714d), radius: 0.07169424300052774d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5114426108101103d, y: 0.0331965422094046d), radius: 0.47258444328355054d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35697262926334494d, y: 0.49381612568073807d), radius: 0.0847363775003277d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5380078339171313d, y: 0.6258096113479286d), radius: 0.11092525626496264d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5935449198210732d, y: 0.5854149607575472d), radius: 0.1617762677880623d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1701316031184924d, y: 0.9406787758298581d), radius: 0.9720083033361695d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47580814140024974d, y: 0.5485435757811734d), radius: 0.981115919396224d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9044159253140384d, y: 0.17590793990054032d), radius: 0.1518873271608817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4162107499068365d, y: 0.6458871516915515d), radius: 0.31120377046456704d), } },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6884719300504579d, y: 0.5410823844320893d), radius: 0.23451696565052693d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13918115516821128d, y: 0.2233954170613548d), radius: 0.03815972130744871d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31208207683231026d, y: 0.9140689841696739d), radius: 0.18586605333221218d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26827860695525707d, y: 0.3720428053303746d), radius: 0.3213550221856145d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3206280695207152d, y: 0.8994469417791466d), radius: 0.38426974858900187d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2015791382870099d, y: 0.6630104680663061d), radius: 0.17879790006783403d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4451313272174364d, y: 0.2610700135216053d), radius: 0.8098443406822324d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01609497520249603d, y: 0.5381159691690433d), radius: 0.5833507097028802d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08442621011901374d, y: 0.8970833957690458d), radius: 0.5001299123074031d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7852228007706261d, y: 0.18970087049257656d), radius: 0.7732931978889467d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06797765069883643d, y: 0.2354926668818188d), radius: 0.9558501284333014d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07306314041631534d, y: 0.11660299357859016d), radius: 0.11383715801113348d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1050232726397271d, y: 0.7229254780364668d), radius: 0.231577775628247d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7834944901253744d, y: 0.6218430192619049d), radius: 0.34996152723584517d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02685008681366996d, y: 0.4941673231762106d), radius: 0.29741826717079645d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36560360340650133d, y: 0.46880886200313676d), radius: 0.7536673324954399d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.504266152388437d, y: 0.7653880319357661d), radius: 0.8604250319928431d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7633830498766595d, y: 0.5931461245405577d), radius: 0.2320930492205685d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3826802044793819d, y: 0.8578772474674081d), radius: 0.28040217180791027d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9929042021651646d, y: 0.8650364390857775d), radius: 0.960903538585677d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4334181853686834d, y: 0.31893664109997255d), radius: 0.2905968091958352d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43301152624107686d, y: 0.4716975319909894d), radius: 0.1779816922918982d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1405940342906521d, y: 0.22098469895721995d), radius: 0.9668890158274854d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6448546004732829d, y: 0.14055540176868409d), radius: 0.22203723141569875d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3282953346420089d, y: 0.8369156994446652d), radius: 0.9780116441590583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21935426234885147d, y: 0.9702244628545156d), radius: 0.4001661001648731d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9669438873319929d, y: 0.7544184853055553d), radius: 0.4569156609092019d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8615870828859412d, y: 0.36940057066877363d), radius: 0.9601807990898861d), } },
    ModelInner = new NpgsqlCirclecircleMArrayD21MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6865422269064546d, y: 0.449266363554108d), radius: 0.45287042567305713d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5354735468642908d, y: 0.09766216205499334d), radius: 0.7126037728530523d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9804508418498431d, y: 0.4704030009547999d), radius: 0.6443088922001071d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8452096290836085d, y: 0.052426047422663435d), radius: 0.9602192022778433d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27074835125524255d, y: 0.9129603638012042d), radius: 0.5589851750495639d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8844498161200713d, y: 0.09291604868320913d), radius: 0.07610818637568817d), } },
},
            new NpgsqlCirclecircleMArrayD2E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9158500703048309d, y: 0.5912339693793139d), radius: 0.29824384175734286d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11472476026973433d, y: 0.38191966674235067d), radius: 0.719987797736554d), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd21mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd21mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
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

                changedRows =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemarrayd21mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemarrayd21mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemarrayd21mi_id
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
    npgsqlcirclecirclemarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemarrayd21mi_id
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
    npgsqlcirclecirclemarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemarrayd21mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.846398749306849d, y: 0.39267517140453645d), radius: 0.8792838232917942d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6722539565810602d, y: 0.5864369635431925d), radius: 0.34067244245318606d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleMArraycircleMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7849884733272658d, y: 0.5969558651440839d), radius: 0.4658131283850996d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18450529151680406d, y: 0.8905868318669189d), radius: 0.37080981665690915d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMArrayD2E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMArrayD2E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd21mi mi ON mi.id = m.npgsqlcirclecirclemarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd21mi mi ON mi.id = m.npgsqlcirclecirclemarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 87;
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 77;
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 142;
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd21mi mi ON mi.id = m.npgsqlcirclecirclemarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 81, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 86, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 96, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 48, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 9, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 89, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd21mi mi ON mi.id = m.npgsqlcirclecirclemarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 87, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 63, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((INpgsqlCircleMArraycircleMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                NpgsqlCirclecircleMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD21MIWA),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD21MI),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
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
FROM public.binary_npgsqlcirclecirclemarrayd2e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemarrayd21mi mi ON mi.id = m.npgsqlcirclecirclemarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models =  ((INpgsqlCircleMArraycircleMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA), typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
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
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
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
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA), typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
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
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
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
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MI), typeof(NpgsqlCirclecircleMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MI>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MI>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MI>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MI>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA), typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                await ((INpgsqlCircleMArraycircleMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD21MIWA>();
                ((INpgsqlCircleMArraycircleMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

