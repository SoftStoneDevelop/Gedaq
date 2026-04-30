

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
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7688723034251723d,right: 0.34888247177475595d,bottom: 0.3279379402647026d,left: 0.3152475128013993d),
new NpgsqlTypes.NpgsqlBox(top: 0.9727634528724755d,right: 0.6845848334279158d,bottom: 0.40032491137579695d,left: 0.02718893516204457d),
new NpgsqlTypes.NpgsqlBox(top: 0.7313273145028354d,right: 0.9615459786076811d,bottom: 0.45354277996350534d,left: 0.7783564656730299d),
new NpgsqlTypes.NpgsqlBox(top: 0.8476597766584397d,right: 0.0866266936996345d,bottom: 0.7470213539762001d,left: 0.05750364371758432d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4918358643453945d,right: 0.8936098205320481d,bottom: 0.3788765460704864d,left: 0.49212158247640525d),
new NpgsqlTypes.NpgsqlBox(top: 0.7653393804417912d,right: 0.418817624851172d,bottom: 0.3000023736987809d,left: 0.2154042392144664d),
new NpgsqlTypes.NpgsqlBox(top: 0.662169823381413d,right: 0.6838676716943268d,bottom: 0.6512319960655487d,left: 0.10505770815496196d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7158364100072268d,right: 0.31090249285058535d,bottom: 0.20271561906642777d,left: 0.1333149467400837d),
new NpgsqlTypes.NpgsqlBox(top: 0.697580523553635d,right: 0.8437705647325534d,bottom: 0.10699931799015716d,left: 0.7125358778702656d),
new NpgsqlTypes.NpgsqlBox(top: 0.45468930844710254d,right: 0.9039541222886265d,bottom: 0.4385468915056009d,left: 0.5787400501131716d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.15574095631987384d,right: 0.8949405668949358d,bottom: 0.13123449118337294d,left: 0.7020048197376262d),
new NpgsqlTypes.NpgsqlBox(top: 0.8536350631200704d,right: 0.4619485725631761d,bottom: 0.6817833621438615d,left: 0.33282318019565593d),
new NpgsqlTypes.NpgsqlBox(top: 0.960662834689946d,right: 0.8711716466589549d,bottom: 0.3950820539236545d,left: 0.27280785672865326d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9407323805394956d,right: 0.8222119842352663d,bottom: 0.7045178496308419d,left: 0.4292198456852838d),
new NpgsqlTypes.NpgsqlBox(top: 0.575714096188364d,right: 0.33241691487933056d,bottom: 0.2468716158773695d,left: 0.007452266799359286d),
new NpgsqlTypes.NpgsqlBox(top: 0.45478205813528716d,right: 0.8420094188759456d,bottom: 0.17343898027939675d,left: 0.49244980598357246d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.334566688275046d,right: 0.793355197028875d,bottom: 0.14914765777869143d,left: 0.4164465167107342d),
new NpgsqlTypes.NpgsqlBox(top: 0.746238534196999d,right: 0.8074623424445976d,bottom: 0.4364298722103903d,left: 0.37860484308119857d),
new NpgsqlTypes.NpgsqlBox(top: 0.8673861864199007d,right: 0.7116242823032065d,bottom: 0.36769313569445095d,left: 0.6695106790769438d),
new NpgsqlTypes.NpgsqlBox(top: 0.9265376993439113d,right: 0.9158528163975983d,bottom: 0.3078232140574426d,left: 0.7152653259553825d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9955572390700325d,right: 0.6453489322173674d,bottom: 0.4836139500006251d,left: 0.3087520926647508d),
new NpgsqlTypes.NpgsqlBox(top: 0.5951341080560717d,right: 0.3221300169133643d,bottom: 0.2958104108340949d,left: 0.03801811653075238d),
new NpgsqlTypes.NpgsqlBox(top: 0.9489914336418689d,right: 0.1284555471112262d,bottom: 0.3698372890098076d,left: 0.008817201917793449d),
new NpgsqlTypes.NpgsqlBox(top: 0.9336607152092739d,right: 0.5937126389556567d,bottom: 0.6766962283479171d,left: 0.07065457143757303d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8584810717682334d,right: 0.8338495279164624d,bottom: 0.41842715585712476d,left: 0.35167229731204075d),
new NpgsqlTypes.NpgsqlBox(top: 0.8665482633811158d,right: 0.8201096226850443d,bottom: 0.5797262256946335d,left: 0.7482340904271176d),
new NpgsqlTypes.NpgsqlBox(top: 0.9265196880614072d,right: 0.9962793308330691d,bottom: 0.6527980667318258d,left: 0.5035599949113057d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6255706005719837d,right: 0.9070479801281032d,bottom: 0.2289687802353062d,left: 0.6836883040152486d),
new NpgsqlTypes.NpgsqlBox(top: 0.8361887670816919d,right: 0.846694636056188d,bottom: 0.7117117853807443d,left: 0.4490466197771743d),
new NpgsqlTypes.NpgsqlBox(top: 0.9856009879123345d,right: 0.42720323393934223d,bottom: 0.3384848324142259d,left: 0.2260177191801278d),
new NpgsqlTypes.NpgsqlBox(top: 0.8954549969792828d,right: 0.8356967295881255d,bottom: 0.8684808875859277d,left: 0.05450229973144216d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9513253057825303d,right: 0.3399343025265613d,bottom: 0.1131136595827742d,left: 0.11092558266268782d),
new NpgsqlTypes.NpgsqlBox(top: 0.9775354812893331d,right: 0.9436288563671521d,bottom: 0.6994731841592208d,left: 0.4100555396864256d),
new NpgsqlTypes.NpgsqlBox(top: 0.6949017789508936d,right: 0.8690467033105562d,bottom: 0.5766952804974568d,left: 0.21250049812609106d),
new NpgsqlTypes.NpgsqlBox(top: 0.8257172762175297d,right: 0.33948127825022256d,bottom: 0.576619680551189d,left: 0.11959694174968949d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.825621240251233d,right: 0.6832847770295299d,bottom: 0.2639515771717198d,left: 0.15271648226334344d),
new NpgsqlTypes.NpgsqlBox(top: 0.4284683200737146d,right: 0.9089935294339199d,bottom: 0.22365983734412553d,left: 0.4942582107342902d),
new NpgsqlTypes.NpgsqlBox(top: 0.8151992353975153d,right: 0.8013171205714152d,bottom: 0.6110957932700052d,left: 0.5089650763517551d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3252708772595412d,right: 0.7940997986658063d,bottom: 0.17672534370337767d,left: 0.6505435128399935d),
new NpgsqlTypes.NpgsqlBox(top: 0.33508909860938085d,right: 0.6305273063665401d,bottom: 0.03753212235858194d,left: 0.27274509699177096d),
new NpgsqlTypes.NpgsqlBox(top: 0.7023748525564821d,right: 0.9026508899261264d,bottom: 0.3349793905936711d,left: 0.538409498364035d),
new NpgsqlTypes.NpgsqlBox(top: 0.7821348627684901d,right: 0.6371671000549566d,bottom: 0.07137116973993518d,left: 0.35144781663294533d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7481638279972495d,right: 0.9004003126759121d,bottom: 0.22899821667547582d,left: 0.32949429057935953d),
new NpgsqlTypes.NpgsqlBox(top: 0.42064763010993067d,right: 0.3799751373280825d,bottom: 0.049117207196382795d,left: 0.07710911109522756d),
new NpgsqlTypes.NpgsqlBox(top: 0.3912525848950795d,right: 0.5753449186452878d,bottom: 0.010012129067275d,left: 0.47411992526528635d),
new NpgsqlTypes.NpgsqlBox(top: 0.8912860766240897d,right: 0.3635982967550656d,bottom: 0.15402111750147285d,left: 0.2755448320438225d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6691730380761309d,right: 0.8432889357618049d,bottom: 0.1179268656455501d,left: 0.6820542440308449d),
new NpgsqlTypes.NpgsqlBox(top: 0.8231138851842019d,right: 0.7109293740490513d,bottom: 0.13174045361268505d,left: 0.600357079517871d),
new NpgsqlTypes.NpgsqlBox(top: 0.8906444917642661d,right: 0.6520239763520543d,bottom: 0.6627949650197728d,left: 0.1474282853308212d),
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
new NpgsqlTypes.NpgsqlBox(top: 0.6117171241773595d,right: 0.7125536907820104d,bottom: 0.3230128238164758d,left: 0.2676478505922356d),
new NpgsqlTypes.NpgsqlBox(top: 0.4016493041570156d,right: 0.6104495184809906d,bottom: 0.2589109140270548d,left: 0.5927982706288387d),
new NpgsqlTypes.NpgsqlBox(top: 0.6759978545296337d,right: 0.24772194420794258d,bottom: 0.35938485820904165d,left: 0.04831274375666961d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42355994356313487d,right: 0.6357739924375687d,bottom: 0.10814816323462628d,left: 0.2920682750664324d),
new NpgsqlTypes.NpgsqlBox(top: 0.13120634102033535d,right: 0.35233109545800567d,bottom: 0.010271755565678609d,left: 0.07067560131622752d),
new NpgsqlTypes.NpgsqlBox(top: 0.9409569173590089d,right: 0.2504037501639932d,bottom: 0.5297566277133605d,left: 0.04281720434725067d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8976386108569653d,right: 0.6379918098861499d,bottom: 0.3884474342939258d,left: 0.2229436702604254d),
new NpgsqlTypes.NpgsqlBox(top: 0.7348655582692813d,right: 0.4601123366471416d,bottom: 0.3828925913844349d,left: 0.4165019186114206d),
new NpgsqlTypes.NpgsqlBox(top: 0.6935816307415853d,right: 0.8863336378789151d,bottom: 0.47308551747510463d,left: 0.20393086393055815d),
new NpgsqlTypes.NpgsqlBox(top: 0.8478845563279307d,right: 0.7759632132584086d,bottom: 0.7296711514370844d,left: 0.2711851468689733d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6048049940128498d,right: 0.7174252861740888d,bottom: 0.4730818451265435d,left: 0.11107738641815756d),
new NpgsqlTypes.NpgsqlBox(top: 0.7354830500393188d,right: 0.9898012904530482d,bottom: 0.26253938422600676d,left: 0.3644375391487279d),
new NpgsqlTypes.NpgsqlBox(top: 0.42329291104636757d,right: 0.7141358070569476d,bottom: 0.19390790195250063d,left: 0.3303748764387684d),
new NpgsqlTypes.NpgsqlBox(top: 0.886006135849164d,right: 0.5775658925157013d,bottom: 0.6745426470116622d,left: 0.2873726412085196d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.0996344801626271d,right: 0.776715597027004d,bottom: 0.04292536206972364d,left: 0.4448346342208881d),
new NpgsqlTypes.NpgsqlBox(top: 0.3724284008527031d,right: 0.21570038798116487d,bottom: 0.03371639966772344d,left: 0.13438713671421187d),
new NpgsqlTypes.NpgsqlBox(top: 0.5456306427875258d,right: 0.503277050179093d,bottom: 0.2663942937864312d,left: 0.4464651251129287d),
new NpgsqlTypes.NpgsqlBox(top: 0.9383698980436557d,right: 0.7742010265146979d,bottom: 0.8786071858090656d,left: 0.502439525108218d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30149107557710564d,right: 0.5274318230129278d,bottom: 0.28315502706831286d,left: 0.37155548548315664d),
new NpgsqlTypes.NpgsqlBox(top: 0.7730266953352046d,right: 0.4124786805843863d,bottom: 0.14320273679105522d,left: 0.21131151910757173d),
new NpgsqlTypes.NpgsqlBox(top: 0.478839531916627d,right: 0.7175644153159633d,bottom: 0.05625209722045377d,left: 0.32069992327009333d),
new NpgsqlTypes.NpgsqlBox(top: 0.4647876406688599d,right: 0.5409303110982018d,bottom: 0.4378148833055975d,left: 0.33641258260341966d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8191871218160612d,right: 0.4339181925730483d,bottom: 0.46622973686058655d,left: 0.34825850562377314d),
new NpgsqlTypes.NpgsqlBox(top: 0.7540879537906224d,right: 0.2591037131840688d,bottom: 0.32796862386019965d,left: 0.07128222526126415d),
new NpgsqlTypes.NpgsqlBox(top: 0.8862392527957605d,right: 0.7891463381597569d,bottom: 0.6937297579031775d,left: 0.7792403206736368d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4525232422839134d,right: 0.24486856624829956d,bottom: 0.130250523194808d,left: 0.03623386743454915d),
new NpgsqlTypes.NpgsqlBox(top: 0.8652427627178352d,right: 0.3709470422576576d,bottom: 0.25116245365805967d,left: 0.20157713620609286d),
new NpgsqlTypes.NpgsqlBox(top: 0.5267053497755497d,right: 0.8376453072408528d,bottom: 0.39050741148185286d,left: 0.49909215293241693d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4847221719481136d,right: 0.5934176196950396d,bottom: 0.20290897613870917d,left: 0.4976371409508141d),
new NpgsqlTypes.NpgsqlBox(top: 0.7289149466326637d,right: 0.9341122687975554d,bottom: 0.09204204852212983d,left: 0.7835600598349132d),
new NpgsqlTypes.NpgsqlBox(top: 0.9059936790145353d,right: 0.6546842055343037d,bottom: 0.39123424083817915d,left: 0.15258353462398155d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7453213610233566d,right: 0.6763094816959229d,bottom: 0.6828411997896184d,left: 0.32391121697476244d),
new NpgsqlTypes.NpgsqlBox(top: 0.9075383003262598d,right: 0.4107209941377673d,bottom: 0.48432729931319507d,left: 0.143357491409135d),
new NpgsqlTypes.NpgsqlBox(top: 0.3325740966785974d,right: 0.5329384013497654d,bottom: 0.027472359319062d,left: 0.07561272309486389d),
new NpgsqlTypes.NpgsqlBox(top: 0.7881323929198093d,right: 0.9488983160587768d,bottom: 0.33181645760040435d,left: 0.44285176266717596d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7969984356372843d,right: 0.44483039827012627d,bottom: 0.18448410238800317d,left: 0.370592337247746d),
new NpgsqlTypes.NpgsqlBox(top: 0.7091777847286063d,right: 0.39555959081217273d,bottom: 0.6777835400818829d,left: 0.17026882756132478d),
new NpgsqlTypes.NpgsqlBox(top: 0.7684191408493842d,right: 0.6857275843863744d,bottom: 0.5996075750552928d,left: 0.1905537690020207d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4316561967931075d,right: 0.9227210938351279d,bottom: 0.4085752598704592d,left: 0.817518561262391d),
new NpgsqlTypes.NpgsqlBox(top: 0.5445455417595326d,right: 0.31244052807500566d,bottom: 0.1608007209418636d,left: 0.28465510481357614d),
new NpgsqlTypes.NpgsqlBox(top: 0.8936075485065047d,right: 0.5863118583832352d,bottom: 0.7631835398265919d,left: 0.5294226165296952d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8686882289493428d,right: 0.8742140704311426d,bottom: 0.4421581781532319d,left: 0.745846494677408d),
new NpgsqlTypes.NpgsqlBox(top: 0.8704401766313334d,right: 0.9489637440602674d,bottom: 0.5689419807475099d,left: 0.22416116070432057d),
new NpgsqlTypes.NpgsqlBox(top: 0.6137740494239529d,right: 0.37178711078077864d,bottom: 0.3311337286219046d,left: 0.018623363232848078d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8025703682458294d,right: 0.5533126225776569d,bottom: 0.6868573414053752d,left: 0.3188108273193758d),
new NpgsqlTypes.NpgsqlBox(top: 0.7481180712592065d,right: 0.7918053232293019d,bottom: 0.08767906822429894d,left: 0.558307636479753d),
new NpgsqlTypes.NpgsqlBox(top: 0.6336359246155073d,right: 0.45321041606137547d,bottom: 0.22361559620433757d,left: 0.01807435916149147d),
new NpgsqlTypes.NpgsqlBox(top: 0.8895467630320366d,right: 0.9864291741365832d,bottom: 0.3612489554776138d,left: 0.8442298267611431d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30772039674038754d,right: 0.650557319540068d,bottom: 0.13042977646382115d,left: 0.39640372451609596d),
new NpgsqlTypes.NpgsqlBox(top: 0.8306441495234757d,right: 0.957651395313545d,bottom: 0.7969322695986957d,left: 0.5015072903700121d),
new NpgsqlTypes.NpgsqlBox(top: 0.900104644985582d,right: 0.7975531598392815d,bottom: 0.23573808942956387d,left: 0.5894997757676286d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5370651551420281d,right: 0.6533469641799763d,bottom: 0.11152902033880929d,left: 0.4777275732365326d),
new NpgsqlTypes.NpgsqlBox(top: 0.8003716662712208d,right: 0.41930551166355357d,bottom: 0.09932556154889738d,left: 0.3164787307704472d),
new NpgsqlTypes.NpgsqlBox(top: 0.6943600403718012d,right: 0.6321770006392072d,bottom: 0.4161092342272593d,left: 0.4405771970340925d),
new NpgsqlTypes.NpgsqlBox(top: 0.6003878516423098d,right: 0.9791891287282104d,bottom: 0.5667319663408777d,left: 0.20839191389409828d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9098879268657493d,right: 0.8345936427154123d,bottom: 0.8200505848366252d,left: 0.2679850558530198d),
new NpgsqlTypes.NpgsqlBox(top: 0.6392119652117894d,right: 0.46475203322670966d,bottom: 0.24769307393260298d,left: 0.16436266655002274d),
new NpgsqlTypes.NpgsqlBox(top: 0.6669583875082119d,right: 0.8597269577183086d,bottom: 0.15400049709379005d,left: 0.6430077962815847d),
new NpgsqlTypes.NpgsqlBox(top: 0.9086675034742853d,right: 0.9020033242287422d,bottom: 0.041559416613961675d,left: 0.17283594673533664d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.43723309358416906d,right: 0.37343533860975375d,bottom: 0.04556130937089753d,left: 0.04167295949464511d),
new NpgsqlTypes.NpgsqlBox(top: 0.9835898878396503d,right: 0.38568559866665253d,bottom: 0.6860553084416325d,left: 0.374724727532184d),
new NpgsqlTypes.NpgsqlBox(top: 0.8907635957498683d,right: 0.7807735004160475d,bottom: 0.533491215718864d,left: 0.7025989144654855d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30526896581348706d,right: 0.7266087840466808d,bottom: 0.23116434104250594d,left: 0.29911242970287955d),
new NpgsqlTypes.NpgsqlBox(top: 0.9112676193248319d,right: 0.3629251165939047d,bottom: 0.049238845788656005d,left: 0.09829375217291181d),
new NpgsqlTypes.NpgsqlBox(top: 0.964390841934326d,right: 0.359091430917748d,bottom: 0.21654613446423254d,left: 0.1484993434234797d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.984075776821881d,right: 0.23700735582361865d,bottom: 0.6253783909402358d,left: 0.06684196036908197d),
new NpgsqlTypes.NpgsqlBox(top: 0.9669044388682402d,right: 0.9030864402287981d,bottom: 0.758559727104702d,left: 0.8731573470435331d),
new NpgsqlTypes.NpgsqlBox(top: 0.679111290137191d,right: 0.1923424789026782d,bottom: 0.010831166848147222d,left: 0.025229294450099582d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3793125622701564d,right: 0.8902047971261124d,bottom: 0.31576889056791857d,left: 0.8745274475825077d),
new NpgsqlTypes.NpgsqlBox(top: 0.6566877401236327d,right: 0.9064337147243637d,bottom: 0.29624759481964236d,left: 0.14848044881078581d),
new NpgsqlTypes.NpgsqlBox(top: 0.8709299315343246d,right: 0.7820570134151636d,bottom: 0.367732154978507d,left: 0.6767853843458517d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7439944133612612d,right: 0.5173039021499182d,bottom: 0.35263977063308893d,left: 0.04760005926925692d),
new NpgsqlTypes.NpgsqlBox(top: 0.5174820409413884d,right: 0.9845025053088131d,bottom: 0.23484900379008045d,left: 0.8373480890423081d),
new NpgsqlTypes.NpgsqlBox(top: 0.42162165706267996d,right: 0.8140359607949786d,bottom: 0.32161198604134955d,left: 0.1503274858080449d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8861920521735487d,right: 0.9010557810611483d,bottom: 0.7463863266529924d,left: 0.3112382707706085d),
new NpgsqlTypes.NpgsqlBox(top: 0.9695100857512812d,right: 0.6129566729308594d,bottom: 0.25758644693308075d,left: 0.560453839186658d),
new NpgsqlTypes.NpgsqlBox(top: 0.7925282953415985d,right: 0.9751766348959688d,bottom: 0.1337031879337125d,left: 0.49491636943401773d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6153847697556902d,right: 0.5565241880750307d,bottom: 0.23182950721597384d,left: 0.1406533488483136d),
new NpgsqlTypes.NpgsqlBox(top: 0.9141404921121136d,right: 0.7182095141700175d,bottom: 0.6653757094814583d,left: 0.31080838044442094d),
new NpgsqlTypes.NpgsqlBox(top: 0.6856971638231943d,right: 0.9699617313534951d,bottom: 0.6521377518488769d,left: 0.06923648843400843d),
new NpgsqlTypes.NpgsqlBox(top: 0.5998420705875782d,right: 0.9100546731632048d,bottom: 0.21725338108717762d,left: 0.06696727492626842d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6175546283933376d,right: 0.8767095820079789d,bottom: 0.28142346775742144d,left: 0.32394554882598603d),
new NpgsqlTypes.NpgsqlBox(top: 0.6802289473245364d,right: 0.8829110574933453d,bottom: 0.6410709856402034d,left: 0.07021220516331006d),
new NpgsqlTypes.NpgsqlBox(top: 0.7099450474971671d,right: 0.12165569748944816d,bottom: 0.6677487225036624d,left: 0.0428200300312761d),
new NpgsqlTypes.NpgsqlBox(top: 0.5369446921334d,right: 0.8601501965551677d,bottom: 0.4518243351812852d,left: 0.251924616573335d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6762001070317684d,right: 0.26468862054817743d,bottom: 0.6234003990287225d,left: 0.19941820784875064d),
new NpgsqlTypes.NpgsqlBox(top: 0.192690933851836d,right: 0.9032603661911016d,bottom: 0.1688985965933979d,left: 0.7931320775154012d),
new NpgsqlTypes.NpgsqlBox(top: 0.17296151219167788d,right: 0.6663307875250944d,bottom: 0.13430616605062728d,left: 0.5423784201918725d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6850260607213982d,right: 0.510715354586875d,bottom: 0.165565698340025d,left: 0.005475767447552182d),
new NpgsqlTypes.NpgsqlBox(top: 0.6266051080336906d,right: 0.8123815682141295d,bottom: 0.5912815088060217d,left: 0.4426354050740937d),
new NpgsqlTypes.NpgsqlBox(top: 0.22969612895508984d,right: 0.9193978189112539d,bottom: 0.057034266795589095d,left: 0.9078487960410527d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.15672200217468002d,right: 0.255664939780447d,bottom: 0.06502114564314154d,left: 0.02475222005660893d),
new NpgsqlTypes.NpgsqlBox(top: 0.9239581637919881d,right: 0.3447465128222392d,bottom: 0.025748760152083716d,left: 0.34092383057407705d),
new NpgsqlTypes.NpgsqlBox(top: 0.32227467090403483d,right: 0.8583173059034395d,bottom: 0.035634355631801284d,left: 0.15956801522394892d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3998603953924552d,right: 0.8092641838544465d,bottom: 0.12839357156182551d,left: 0.6075221221474525d),
new NpgsqlTypes.NpgsqlBox(top: 0.39450831406659725d,right: 0.7624319232360489d,bottom: 0.06905639210540848d,left: 0.4088881029745506d),
new NpgsqlTypes.NpgsqlBox(top: 0.7565444623510028d,right: 0.8468069786926115d,bottom: 0.09668102375484178d,left: 0.4018141342553405d),
new NpgsqlTypes.NpgsqlBox(top: 0.873815659026191d,right: 0.8555245862862098d,bottom: 0.5923735141227224d,left: 0.4321761680757006d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8733903499275293d,right: 0.4980247976835278d,bottom: 0.17642588097195666d,left: 0.14566135656742718d),
new NpgsqlTypes.NpgsqlBox(top: 0.6489538592442988d,right: 0.33249600912201793d,bottom: 0.03197996652408297d,left: 0.14382661175960554d),
new NpgsqlTypes.NpgsqlBox(top: 0.7711156688863918d,right: 0.4235043417594889d,bottom: 0.25189906012354724d,left: 0.3459396684731382d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8876861596448189d,right: 0.6909811966262278d,bottom: 0.47464477577089226d,left: 0.6412327321699197d),
new NpgsqlTypes.NpgsqlBox(top: 0.7098258842363411d,right: 0.22176136618613207d,bottom: 0.6884111381817034d,left: 0.1791471984948788d),
new NpgsqlTypes.NpgsqlBox(top: 0.3139757848598812d,right: 0.8191413591942799d,bottom: 0.20783924237779383d,left: 0.45623475309822503d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41509626582367565d,right: 0.8795927811509461d,bottom: 0.08430024762963895d,left: 0.17693670073955214d),
new NpgsqlTypes.NpgsqlBox(top: 0.8492024266275318d,right: 0.710328046005254d,bottom: 0.42162688324105946d,left: 0.5857010104819729d),
new NpgsqlTypes.NpgsqlBox(top: 0.6008030178834852d,right: 0.8683967516739937d,bottom: 0.2791132361763041d,left: 0.22636590515821553d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33993824419249985d,right: 0.5007639169764617d,bottom: 0.044929301785907816d,left: 0.05252946428583394d),
new NpgsqlTypes.NpgsqlBox(top: 0.48144940267823355d,right: 0.9131740815385118d,bottom: 0.24072455229214906d,left: 0.4390326668140876d),
new NpgsqlTypes.NpgsqlBox(top: 0.5212840554005663d,right: 0.6307200046226985d,bottom: 0.4350865214676941d,left: 0.5974299685939155d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7994109905697752d,right: 0.7897890850533383d,bottom: 0.24104013598146745d,left: 0.6857409314812433d),
new NpgsqlTypes.NpgsqlBox(top: 0.837615505134646d,right: 0.8818739886368209d,bottom: 0.3640410082788593d,left: 0.5129401211762167d),
new NpgsqlTypes.NpgsqlBox(top: 0.33050061518484586d,right: 0.7796014705651799d,bottom: 0.049540004070876775d,left: 0.7523847406270693d),
new NpgsqlTypes.NpgsqlBox(top: 0.4027373381397522d,right: 0.9566736923110872d,bottom: 0.2389788692258663d,left: 0.07266117799461491d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8571141718733268d,right: 0.19706248776987978d,bottom: 0.6886880609293001d,left: 0.11531773109738652d),
new NpgsqlTypes.NpgsqlBox(top: 0.6810892167328845d,right: 0.6176527903616725d,bottom: 0.08429549680782966d,left: 0.3712069340694599d),
new NpgsqlTypes.NpgsqlBox(top: 0.8576816537450416d,right: 0.340161770626223d,bottom: 0.4847656150136441d,left: 0.22555623188886997d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8512314741629615d,right: 0.7487824939701988d,bottom: 0.557822776729711d,left: 0.6743009529287606d),
new NpgsqlTypes.NpgsqlBox(top: 0.9691718710227336d,right: 0.7289998310057224d,bottom: 0.9018715526108622d,left: 0.1599190339545825d),
new NpgsqlTypes.NpgsqlBox(top: 0.6800910536374056d,right: 0.7870976252093754d,bottom: 0.6081201811419812d,left: 0.7569205674299735d),
new NpgsqlTypes.NpgsqlBox(top: 0.921018740541737d,right: 0.7936319428574446d,bottom: 0.6849670110918974d,left: 0.11194026861024686d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8551639879033788d,right: 0.6178659240778238d,bottom: 0.7841462802841018d,left: 0.5502074180183095d),
new NpgsqlTypes.NpgsqlBox(top: 0.19939090377773516d,right: 0.2243890802799d,bottom: 0.051196390764902566d,left: 0.11958068685041978d),
new NpgsqlTypes.NpgsqlBox(top: 0.7569893886725906d,right: 0.4367231653258481d,bottom: 0.07630970132873238d,left: 0.3974855133124783d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.709190914131691d,right: 0.7813181791975272d,bottom: 0.021914975380520896d,left: 0.47908837290975603d),
new NpgsqlTypes.NpgsqlBox(top: 0.786251905775437d,right: 0.7977689184638357d,bottom: 0.5294370386473141d,left: 0.4757925955991382d),
new NpgsqlTypes.NpgsqlBox(top: 0.33899882346481325d,right: 0.5453853821520952d,bottom: 0.3357955870629432d,left: 0.03237548200524487d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.48300101118053906d,right: 0.6834480884457653d,bottom: 0.020722237917303654d,left: 0.3439533311554749d),
new NpgsqlTypes.NpgsqlBox(top: 0.6086719173431915d,right: 0.9997061295028233d,bottom: 0.5063845612170408d,left: 0.6760671627337083d),
new NpgsqlTypes.NpgsqlBox(top: 0.5987068822265816d,right: 0.6059646739682827d,bottom: 0.15696703912446008d,left: 0.21207803654566326d),
new NpgsqlTypes.NpgsqlBox(top: 0.17475299419581836d,right: 0.3684886796290159d,bottom: 0.03385554739493801d,left: 0.10290642394966543d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.13003207954129148d,right: 0.9870335160991989d,bottom: 0.05304287724689094d,left: 0.4447184047367496d),
new NpgsqlTypes.NpgsqlBox(top: 0.8083579238223186d,right: 0.6894887068022143d,bottom: 0.4252999330574925d,left: 0.3169941702246578d),
new NpgsqlTypes.NpgsqlBox(top: 0.5866951597784367d,right: 0.3029147228467082d,bottom: 0.24097732698297059d,left: 0.18118796812774562d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9604254759830056d,right: 0.3805213133682349d,bottom: 0.8780716068160409d,left: 0.1746305390952796d),
new NpgsqlTypes.NpgsqlBox(top: 0.800869663877989d,right: 0.8363304695101669d,bottom: 0.396539867582264d,left: 0.6069230123612654d),
new NpgsqlTypes.NpgsqlBox(top: 0.42830597103524504d,right: 0.4377212875780918d,bottom: 0.04164073985180017d,left: 0.2095407011278302d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.786519896897086d,right: 0.8765973810802192d,bottom: 0.30283997658314266d,left: 0.22861466717791634d),
new NpgsqlTypes.NpgsqlBox(top: 0.9525455829464539d,right: 0.5869885853601524d,bottom: 0.16986086045012716d,left: 0.5820004371777421d),
new NpgsqlTypes.NpgsqlBox(top: 0.9464728066666702d,right: 0.5100019597008856d,bottom: 0.2118331505429205d,left: 0.2310194364176339d),
new NpgsqlTypes.NpgsqlBox(top: 0.5531180058512488d,right: 0.43192969137959825d,bottom: 0.19059264299991685d,left: 0.02594276393993933d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23976321797001032d,right: 0.19063530067988466d,bottom: 0.13850708296063308d,left: 0.056115191892974425d),
new NpgsqlTypes.NpgsqlBox(top: 0.9402531563689187d,right: 0.9041199743140143d,bottom: 0.012376237600176698d,left: 0.1759899454804521d),
new NpgsqlTypes.NpgsqlBox(top: 0.8202112524390561d,right: 0.7665540084661008d,bottom: 0.41248062306471933d,left: 0.6195588018787624d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.855560904292059d,right: 0.8481656764054982d,bottom: 0.12257485206357555d,left: 0.48594281515046034d),
new NpgsqlTypes.NpgsqlBox(top: 0.8842263255204821d,right: 0.380561196658323d,bottom: 0.7449470905834146d,left: 0.3704160535525841d),
new NpgsqlTypes.NpgsqlBox(top: 0.8583362966065881d,right: 0.2012858761337425d,bottom: 0.5204953953090524d,left: 0.06153249946707362d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6235270771179555d,right: 0.7392147016533054d,bottom: 0.13859703470435802d,left: 0.2738807840638048d),
new NpgsqlTypes.NpgsqlBox(top: 0.7893189460226053d,right: 0.9170061037426893d,bottom: 0.7150746802890596d,left: 0.8014196869446493d),
new NpgsqlTypes.NpgsqlBox(top: 0.7040301692552805d,right: 0.8921142494630577d,bottom: 0.3804931004320302d,left: 0.6595172952245651d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8859324278623779d,right: 0.5962471292066657d,bottom: 0.3388222662946049d,left: 0.4744635341628578d),
new NpgsqlTypes.NpgsqlBox(top: 0.31490026409342076d,right: 0.5277590284139044d,bottom: 0.13654860441952021d,left: 0.5209753079234561d),
new NpgsqlTypes.NpgsqlBox(top: 0.7182725978347705d,right: 0.6209880118725201d,bottom: 0.23461345376572584d,left: 0.34208131789033813d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9113589215286539d,right: 0.7674884319380677d,bottom: 0.5078491296596432d,left: 0.313748421178652d),
new NpgsqlTypes.NpgsqlBox(top: 0.7098787061816147d,right: 0.9683396479087124d,bottom: 0.6090571747386051d,left: 0.34232517913116167d),
new NpgsqlTypes.NpgsqlBox(top: 0.8535679447523946d,right: 0.3514126840014218d,bottom: 0.829596296709174d,left: 0.3251715510377231d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12306619549883269d,right: 0.9456833606359988d,bottom: 0.09671718779038385d,left: 0.8794202929161886d),
new NpgsqlTypes.NpgsqlBox(top: 0.7516097272631402d,right: 0.9369854794505887d,bottom: 0.4430018564063668d,left: 0.5315925889887567d),
new NpgsqlTypes.NpgsqlBox(top: 0.14500304750825488d,right: 0.09850943042892957d,bottom: 0.014222114963093335d,left: 0.0889254487682678d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9453900960480079d,right: 0.8249892220394475d,bottom: 0.12074657375042297d,left: 0.6323188166835151d),
new NpgsqlTypes.NpgsqlBox(top: 0.0764798168862878d,right: 0.8877248578609687d,bottom: 0.041347652419193026d,left: 0.36116428710958337d),
new NpgsqlTypes.NpgsqlBox(top: 0.5943191561593447d,right: 0.28517317378879226d,bottom: 0.593086480733259d,left: 0.0729706671387178d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8124770968744489d,right: 0.739221394141495d,bottom: 0.8091853460572003d,left: 0.5003923373711837d),
new NpgsqlTypes.NpgsqlBox(top: 0.8519685233632113d,right: 0.9244520103232124d,bottom: 0.5647043611139939d,left: 0.7531505049716299d),
new NpgsqlTypes.NpgsqlBox(top: 0.372195297517795d,right: 0.2415347195765446d,bottom: 0.3356039535154872d,left: 0.19481569378465302d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9029744559179544d,right: 0.544760996267459d,bottom: 0.8638301882163368d,left: 0.020124314549099354d),
new NpgsqlTypes.NpgsqlBox(top: 0.08856474094382483d,right: 0.9770861174581107d,bottom: 0.011971735231575797d,left: 0.33758191364848766d),
new NpgsqlTypes.NpgsqlBox(top: 0.6041169653697767d,right: 0.8144030574328125d,bottom: 0.17361239069682077d,left: 0.4713054572932217d),
new NpgsqlTypes.NpgsqlBox(top: 0.8214098636162888d,right: 0.5415081789146057d,bottom: 0.09202203320627156d,left: 0.4992775746423602d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9297437454993102d,right: 0.2789565666617939d,bottom: 0.3319073384993131d,left: 0.12598037210550206d),
new NpgsqlTypes.NpgsqlBox(top: 0.6620176517737776d,right: 0.9141126450445399d,bottom: 0.4512107122939273d,left: 0.6424638727717363d),
new NpgsqlTypes.NpgsqlBox(top: 0.3232054191802318d,right: 0.8672138780300596d,bottom: 0.006030602769619087d,left: 0.20409548127770827d),
new NpgsqlTypes.NpgsqlBox(top: 0.9244470102278374d,right: 0.6534868440258452d,bottom: 0.3848760658241963d,left: 0.3646689177891145d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.20131620998087907d,right: 0.9130667121737802d,bottom: 0.03960635025609871d,left: 0.13078006745587356d),
new NpgsqlTypes.NpgsqlBox(top: 0.23014470555858912d,right: 0.28940053401234433d,bottom: 0.08182855223629837d,left: 0.014601025984331106d),
new NpgsqlTypes.NpgsqlBox(top: 0.9322342898299183d,right: 0.9051981896777392d,bottom: 0.21654533789533847d,left: 0.2108050820205989d),
new NpgsqlTypes.NpgsqlBox(top: 0.3781575004963391d,right: 0.8677697603197299d,bottom: 0.12449309482714466d,left: 0.10224672787046452d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8663570745716865d,right: 0.6570256950343167d,bottom: 0.26993140784542446d,left: 0.6374760378047841d),
new NpgsqlTypes.NpgsqlBox(top: 0.9052547518295129d,right: 0.6096149456389831d,bottom: 0.10916578747298855d,left: 0.3428612317786369d),
new NpgsqlTypes.NpgsqlBox(top: 0.5766607515609297d,right: 0.5506626871983837d,bottom: 0.08922552811120699d,left: 0.05291996120604281d),
new NpgsqlTypes.NpgsqlBox(top: 0.9370615867150164d,right: 0.8934783258264971d,bottom: 0.0317357542289719d,left: 0.2528549318034701d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6932410185201635d,right: 0.705852025005268d,bottom: 0.6061379776013599d,left: 0.5401599838419734d),
new NpgsqlTypes.NpgsqlBox(top: 0.6427743998460482d,right: 0.5266209078551357d,bottom: 0.49181259454272186d,left: 0.02044766079286353d),
new NpgsqlTypes.NpgsqlBox(top: 0.445878665504322d,right: 0.29733865167923235d,bottom: 0.3862779435211773d,left: 0.12001884423252318d),
new NpgsqlTypes.NpgsqlBox(top: 0.9011376562891682d,right: 0.9609231674263402d,bottom: 0.7999467279748341d,left: 0.07440676146781988d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3455946565768867d,right: 0.7465794391947916d,bottom: 0.3247929421095658d,left: 0.6183061694001416d),
new NpgsqlTypes.NpgsqlBox(top: 0.739840879968947d,right: 0.6060276453689432d,bottom: 0.5501232782536793d,left: 0.2683301926859819d),
new NpgsqlTypes.NpgsqlBox(top: 0.8505437553425279d,right: 0.7459702363696765d,bottom: 0.3081494063161059d,left: 0.499516242541695d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6877172921922738d,right: 0.6086837280704431d,bottom: 0.5220853942484875d,left: 0.33305010196571017d),
new NpgsqlTypes.NpgsqlBox(top: 0.9918762310812943d,right: 0.0864724390695284d,bottom: 0.06217022173221165d,left: 0.034886920006342304d),
new NpgsqlTypes.NpgsqlBox(top: 0.7168495695669623d,right: 0.6327575068994639d,bottom: 0.6863112359951218d,left: 0.44140056611792255d),
new NpgsqlTypes.NpgsqlBox(top: 0.6533421741539088d,right: 0.24667791231435587d,bottom: 0.14676556197842927d,left: 0.03616546960852618d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42906190574778336d,right: 0.9708728332000485d,bottom: 0.3686115246728372d,left: 0.08124569857329345d),
new NpgsqlTypes.NpgsqlBox(top: 0.9193591563256326d,right: 0.9503798095438597d,bottom: 0.0047240720886435605d,left: 0.16375668713184255d),
new NpgsqlTypes.NpgsqlBox(top: 0.5453703688411672d,right: 0.9402155106399864d,bottom: 0.20925272238213888d,left: 0.010511284302155754d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.582155160742384d,right: 0.46446110092513626d,bottom: 0.27317251126632547d,left: 0.3693465842144409d),
new NpgsqlTypes.NpgsqlBox(top: 0.7771623443328799d,right: 0.1681022167292603d,bottom: 0.28670927383686506d,left: 0.00240512692546635d),
new NpgsqlTypes.NpgsqlBox(top: 0.3323654079654097d,right: 0.673138323637642d,bottom: 0.25479965150400663d,left: 0.10314468204482241d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3326846603765139d,right: 0.8636871312909497d,bottom: 0.10848845533155671d,left: 0.7036905355461401d),
new NpgsqlTypes.NpgsqlBox(top: 0.7529819291607501d,right: 0.2899030517831882d,bottom: 0.481216381142764d,left: 0.27094102165647194d),
new NpgsqlTypes.NpgsqlBox(top: 0.45478239104454665d,right: 0.5967814921968679d,bottom: 0.07740819562444912d,left: 0.2269579567794232d),
new NpgsqlTypes.NpgsqlBox(top: 0.7106074839644098d,right: 0.5826122789187053d,bottom: 0.5223568147736215d,left: 0.40805770736470437d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.686405675957483d,right: 0.8834991785940433d,bottom: 0.08024614665105512d,left: 0.3399278750384642d),
new NpgsqlTypes.NpgsqlBox(top: 0.5971118938853575d,right: 0.9930853370342904d,bottom: 0.3099864322669589d,left: 0.8433130930721251d),
new NpgsqlTypes.NpgsqlBox(top: 0.7166102450529312d,right: 0.47467237307414967d,bottom: 0.08819588873073059d,left: 0.3909809120994856d),
new NpgsqlTypes.NpgsqlBox(top: 0.7436462178431088d,right: 0.5684938673665859d,bottom: 0.6679549621577984d,left: 0.009623262564455226d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.428819422005716d,right: 0.8356561393496463d,bottom: 0.23229867798333403d,left: 0.6761907713696366d),
new NpgsqlTypes.NpgsqlBox(top: 0.8374994094336373d,right: 0.3489746740036991d,bottom: 0.17432156409128885d,left: 0.09113906572652097d),
new NpgsqlTypes.NpgsqlBox(top: 0.44693096293957424d,right: 0.2625313343106751d,bottom: 0.057556130920795257d,left: 0.20785792314212914d),
new NpgsqlTypes.NpgsqlBox(top: 0.7134202699686377d,right: 0.6393941720253317d,bottom: 0.061368187485710934d,left: 0.24252423523233713d),
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7481638279972495d,right: 0.9004003126759121d,bottom: 0.22899821667547582d,left: 0.32949429057935953d),
new NpgsqlTypes.NpgsqlBox(top: 0.42064763010993067d,right: 0.3799751373280825d,bottom: 0.049117207196382795d,left: 0.07710911109522756d),
new NpgsqlTypes.NpgsqlBox(top: 0.3912525848950795d,right: 0.5753449186452878d,bottom: 0.010012129067275d,left: 0.47411992526528635d),
new NpgsqlTypes.NpgsqlBox(top: 0.8912860766240897d,right: 0.3635982967550656d,bottom: 0.15402111750147285d,left: 0.2755448320438225d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4525232422839134d,right: 0.24486856624829956d,bottom: 0.130250523194808d,left: 0.03623386743454915d),
new NpgsqlTypes.NpgsqlBox(top: 0.8652427627178352d,right: 0.3709470422576576d,bottom: 0.25116245365805967d,left: 0.20157713620609286d),
new NpgsqlTypes.NpgsqlBox(top: 0.5267053497755497d,right: 0.8376453072408528d,bottom: 0.39050741148185286d,left: 0.49909215293241693d),
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8686882289493428d,right: 0.8742140704311426d,bottom: 0.4421581781532319d,left: 0.745846494677408d),
new NpgsqlTypes.NpgsqlBox(top: 0.8704401766313334d,right: 0.9489637440602674d,bottom: 0.5689419807475099d,left: 0.22416116070432057d),
new NpgsqlTypes.NpgsqlBox(top: 0.6137740494239529d,right: 0.37178711078077864d,bottom: 0.3311337286219046d,left: 0.018623363232848078d),
}));
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 18, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 63, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[32],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 152, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 73, query1, 105, query2))
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 169, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 18, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 24, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[34], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[30], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[31], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[32], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[33], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[30], false);NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[31], false);NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[32], false);NpgsqlBoxboxArray1M.AssertModel(models[32],_testData[33], false);NpgsqlBoxboxArray1M.AssertModel(models[33],_testData[34], false);
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

